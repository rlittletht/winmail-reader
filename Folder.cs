using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMailReader
{
    internal class Folder
    {
        private byte[] m_header;
        private List<MailItem> m_items = new List<MailItem>();

        public List<MailItem> Items => m_items;

        public Folder(byte[] header)
        {
            m_header = header;
        }

        public void AddItem(MailItem item)
        {
            m_items.Add(item);
        }
    }
}
