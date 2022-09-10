using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMailReader
{
    internal class MailHeader
    {
        private Dictionary<string, string> m_dates = new Dictionary<string, string>();

        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Date => m_dates[""];
        public string MailFlag { get; set; } = "";

        public string SentDate => m_dates["Sent"];

        public string[] Dates
        {
            get
            {
                List<String> dates = new List<String>();
                foreach (string key in m_dates.Keys)
                {
                    if (key.Length == 0)
                        dates.Add($"default: {m_dates[key]}");
                    else
                        dates.Add($"{key}: {m_dates[key]}");
                }

                return dates.ToArray();
            }
        }

        public string[] XDates
        {
            get
            {
                List<String> dates = new List<String>();
                foreach (string key in m_dates.Keys)
                {
                    if (key.Length == 0)
                        dates.Add($"X-Default-Date: {m_dates[key]}");
                    else
                        dates.Add($"X-{key}-Date: {m_dates[key]}");
                }

                return dates.ToArray();
            }
        }
        /*----------------------------------------------------------------------------
            %%Function: AddDate
            %%Qualified: WinMailReader.MailHeader.AddDate

            Add a date to the list of dates we know about
        ----------------------------------------------------------------------------*/
        public void AddDate(string value, string flagOverride = null)
        {
            if (!m_dates.ContainsKey(""))
                m_dates.Add("", value);

            if (flagOverride == null)
                flagOverride = MailFlag;

            if (!m_dates.ContainsKey(flagOverride))
                m_dates.Add(flagOverride, value);
        }

        /*----------------------------------------------------------------------------
            %%Function: SplitMailHeaderLine
            %%Qualified: WinMailReader.MailHeader.SplitMailHeaderLine
        ----------------------------------------------------------------------------*/
        public static (string, string) SplitMailHeaderLine(string line, string fieldPrevious)
        {
            int ichDelim; 

            // "From" is a very special value
            if (line.StartsWith("From "))
            {
                ichDelim = 4;
            }
            else
            {
                if (fieldPrevious != null)
                {
                    if (line.StartsWith("   "))
                    {
                        return (fieldPrevious, line.Trim());
                    }
                }

                ichDelim = line.IndexOf(':');
            }

            if (ichDelim == -1)
                return (null, null);

            string field = line.Substring(0, ichDelim);
            string value = line.Substring(ichDelim + 1).Trim();

            return (field, value);
        }

        /*----------------------------------------------------------------------------
            %%Function: SetHeaderItem
            %%Qualified: WinMailReader.MailHeader.SetHeaderItem
        ----------------------------------------------------------------------------*/
        public void SetHeaderItem(string field, string value)
        {
            if (field == "From")
            {
                // value is actually two parts
                int ichDelim = value.IndexOf(' ');
                if (ichDelim == -1)
                    From = value;
                else
                {
                    From = value.Substring(0, ichDelim);
                    AddDate(value.Substring(ichDelim).Trim(), "Sent");
                }
            }
            else if (field == "To")
                To = value;
            else if (field == "Subject")
                Subject = value;
            else if (field == "Mail-Flag")
                MailFlag = value;
            else if (field == "Date")
                AddDate(value);
        }

        public ListViewItem BuildListViewItem(int mailItemTag)
        {
            ListViewItem item = new ListViewItem();

            item.Tag = mailItemTag;
            item.SubItems[0] = new ListViewItem.ListViewSubItem(item, mailItemTag.ToString());
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, From));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, To));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Subject));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, SentDate));

            return item;
        }
    }
}
