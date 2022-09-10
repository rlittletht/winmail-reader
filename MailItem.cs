using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMailReader
{
    internal class MailItem
    {
        public MailHeader Header { get; private set; }
        private List<string> m_body = new List<string>();

        public string[] Body => m_body.ToArray();

        public MailItem(MailHeader header)
        {
            Header = header;
        }

        public void AddBodyLine(string line)
        {
            m_body.Add(line);
        }
    }
}
