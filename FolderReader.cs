using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TCore.StreamEx;

namespace WinMailReader
{
    internal class FolderReader
    {
        enum ReadingState
        {
            LookingForFrom,
            ReadingHeader,
            ReadingBody
        }

        public static Folder LoadFolder(string filename)
        {
            using (FileStream folderFile = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                // there are 0x07e4 bytes of header content in the folder...skip it
                byte[] folderHeader = new byte[0x7e4];

                int bytesRead = folderFile.Read(folderHeader, 0, folderHeader.Length);

                if (bytesRead != folderHeader.Length)
                    throw new Exception($"folder did not have full header, only read {bytesRead} bytes");

                Folder newFolder = new Folder(folderHeader);

                BufferedStreamEx folderStream = new BufferedStreamEx(folderFile, 0x07e4, folderFile.Length, 2048);

                // now walk through all the items

                // we read line by line. anything that starts with "From:" is special (otherwise it will have ">From:" in order to escape it.
                string line = null;
                ReadingState state = ReadingState.LookingForFrom;
                MailItem item = null;
                MailHeader header = null;
                bool fPushBack = false;
                string fieldPrevious = null;

                while (fPushBack || (line = folderStream.ReadLine()) != null)
                {
                    fPushBack = false;

                    if (state == ReadingState.LookingForFrom)
                    {
                        if (line.StartsWith("From "))
                        {
                            header = new MailHeader();
                            state = ReadingState.ReadingHeader;
                        }
                    }

                    if (state == ReadingState.ReadingHeader)
                    {
                        // split into field and value
                        string field, value;

                        // first, check for a continuation line from the previous field
                        (field, value) = MailHeader.SplitMailHeaderLine(line, fieldPrevious);

                        if (field != null)
                        {
                            header.SetHeaderItem(field, value);
                            fieldPrevious = field;
                        }
                        else
                        {
                            state = ReadingState.ReadingBody;
                            item = new MailItem(header);
                            header = null;
                        }
                    }

                    if (state == ReadingState.ReadingBody)
                    {
                        if (line.StartsWith("From "))
                        {
                            state = ReadingState.LookingForFrom;
                            newFolder.AddItem(item);
                            item = null;
                            fPushBack =
                                true; // so we don't read the line again...we want to process this line over again
                        }
                        else
                        {
                            item.AddBodyLine(line);
                        }
                    }
                }

                if (item != null)
                    newFolder.AddItem(item);
                if (header != null)
                {
                    throw new Exception("folder terminated while we were reading a header");
                }

                return newFolder;
            }
        }
    }
}
