using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMailReader
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            SetupMessageList();
        }

        public void SetupMessageList()
        {
            m_lvHeaders.View = View.Details;
            m_lvHeaders.Columns.Clear();

            m_lvHeaders.Columns.Add("key", "Key", 20, HorizontalAlignment.Left, null);
            m_lvHeaders.Columns.Add("from", "From", 50, HorizontalAlignment.Left, null);
            m_lvHeaders.Columns.Add("to", "To", 50, HorizontalAlignment.Left, null);
            m_lvHeaders.Columns.Add("subject", "Subject", 400, HorizontalAlignment.Left, null);
            m_lvHeaders.Columns.Add("recieved", "Received", 150, HorizontalAlignment.Left, null);
        }

        private Folder m_folder;

        static string BuildFolderName(string path, string leaf)
        {
            return Path.ChangeExtension(Path.Combine(path, leaf), "FLD");
        }
        private void DoLoad(object sender, EventArgs e)
        {
            m_folder = FolderReader.LoadFolder(BuildFolderName(m_ebFolderPath.Text, m_ebFolderName.Text));

            for (int i = 0; i < m_folder.Items.Count; i++)
            {
                m_lvHeaders.Items.Add(m_folder.Items[i].Header.BuildListViewItem(i));
            }
        }

        private void ShowMailItem(int mailItemTag)
        {
            m_ebBody.Clear();

            MailItem item = m_folder.Items[mailItemTag];

            m_ebBody.Lines = item.Body;
            m_ebFrom.Text = item.Header.From;
            m_ebTo.Text = item.Header.To;
            m_ebSubject.Text = item.Header.Subject;
            m_ebSent.Text = item.Header.SentDate;
            m_ebFlags.Text = item.Header.MailFlag;
            m_ebDates.Lines = item.Header.Dates;

        }

        private void DoChangeSelection(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ShowMailItem((int)e.Item.Tag);
            }
        }

        private void DoExportItem(object sender, EventArgs e)
        {
            int itemNum = (int)m_lvHeaders.SelectedItems[0].Tag;
            string outName = $"{Path.GetFileNameWithoutExtension(m_ebFolderName.Text)}_Export_{itemNum}";
            string outfileName = Path.ChangeExtension(
                Path.Combine(m_ebFolderPath.Text, outName),
                "txt");

            MailItem item = m_folder.Items[itemNum];

            using (StreamWriter writer = File.CreateText(outfileName))
            {
                writer.WriteLine($"From: {item.Header.From}");
                writer.WriteLine($"To: {item.Header.To}");
                writer.WriteLine($"Sent: {item.Header.SentDate}");
                writer.WriteLine($"Subject: {item.Header.From}");
                writer.WriteLine($"X-Mail-Flag: {item.Header.MailFlag}");
                foreach (string xdate in item.Header.XDates)
                {
                    writer.WriteLine(xdate);
                }
                writer.WriteLine($"");

                foreach (string line in item.Body)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
