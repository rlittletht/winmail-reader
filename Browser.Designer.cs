namespace WinMailReader
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_lvHeaders = new System.Windows.Forms.ListView();
            this.m_pbLoad = new System.Windows.Forms.Button();
            this.m_ebBody = new System.Windows.Forms.TextBox();
            this.m_ebFlags = new System.Windows.Forms.TextBox();
            this.m_ebDates = new System.Windows.Forms.TextBox();
            this.m_lblFlags = new System.Windows.Forms.Label();
            this.m_lblDates = new System.Windows.Forms.Label();
            this.m_pbExport = new System.Windows.Forms.Button();
            this.m_ebFrom = new System.Windows.Forms.TextBox();
            this.m_ebTo = new System.Windows.Forms.TextBox();
            this.m_ebSent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_ebSubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_ebFolderName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_ebFolderPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lvHeaders
            // 
            this.m_lvHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lvHeaders.FullRowSelect = true;
            this.m_lvHeaders.HideSelection = false;
            this.m_lvHeaders.Location = new System.Drawing.Point(12, 97);
            this.m_lvHeaders.Name = "m_lvHeaders";
            this.m_lvHeaders.ShowGroups = false;
            this.m_lvHeaders.Size = new System.Drawing.Size(1084, 903);
            this.m_lvHeaders.TabIndex = 0;
            this.m_lvHeaders.UseCompatibleStateImageBehavior = false;
            this.m_lvHeaders.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DoChangeSelection);
            // 
            // m_pbLoad
            // 
            this.m_pbLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pbLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_pbLoad.Location = new System.Drawing.Point(2092, 12);
            this.m_pbLoad.Name = "m_pbLoad";
            this.m_pbLoad.Size = new System.Drawing.Size(84, 33);
            this.m_pbLoad.TabIndex = 1;
            this.m_pbLoad.Text = "Load";
            this.m_pbLoad.UseVisualStyleBackColor = true;
            this.m_pbLoad.Click += new System.EventHandler(this.DoLoad);
            // 
            // m_ebBody
            // 
            this.m_ebBody.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ebBody.Location = new System.Drawing.Point(1116, 228);
            this.m_ebBody.Multiline = true;
            this.m_ebBody.Name = "m_ebBody";
            this.m_ebBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_ebBody.Size = new System.Drawing.Size(1060, 772);
            this.m_ebBody.TabIndex = 2;
            this.m_ebBody.WordWrap = false;
            // 
            // m_ebFlags
            // 
            this.m_ebFlags.Location = new System.Drawing.Point(2065, 100);
            this.m_ebFlags.Multiline = true;
            this.m_ebFlags.Name = "m_ebFlags";
            this.m_ebFlags.Size = new System.Drawing.Size(111, 89);
            this.m_ebFlags.TabIndex = 3;
            this.m_ebFlags.WordWrap = false;
            // 
            // m_ebDates
            // 
            this.m_ebDates.Location = new System.Drawing.Point(1597, 100);
            this.m_ebDates.Multiline = true;
            this.m_ebDates.Name = "m_ebDates";
            this.m_ebDates.Size = new System.Drawing.Size(352, 89);
            this.m_ebDates.TabIndex = 4;
            this.m_ebDates.WordWrap = false;
            // 
            // m_lblFlags
            // 
            this.m_lblFlags.AutoSize = true;
            this.m_lblFlags.Location = new System.Drawing.Point(1979, 103);
            this.m_lblFlags.Name = "m_lblFlags";
            this.m_lblFlags.Size = new System.Drawing.Size(80, 20);
            this.m_lblFlags.TabIndex = 5;
            this.m_lblFlags.Text = "Mail Flags";
            // 
            // m_lblDates
            // 
            this.m_lblDates.AutoSize = true;
            this.m_lblDates.Location = new System.Drawing.Point(1511, 106);
            this.m_lblDates.Name = "m_lblDates";
            this.m_lblDates.Size = new System.Drawing.Size(52, 20);
            this.m_lblDates.TabIndex = 6;
            this.m_lblDates.Text = "Dates";
            // 
            // m_pbExport
            // 
            this.m_pbExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pbExport.Location = new System.Drawing.Point(2092, 51);
            this.m_pbExport.Name = "m_pbExport";
            this.m_pbExport.Size = new System.Drawing.Size(84, 33);
            this.m_pbExport.TabIndex = 7;
            this.m_pbExport.Text = "E&xport";
            this.m_pbExport.UseVisualStyleBackColor = true;
            this.m_pbExport.Click += new System.EventHandler(this.DoExportItem);
            // 
            // m_ebFrom
            // 
            this.m_ebFrom.Location = new System.Drawing.Point(1181, 100);
            this.m_ebFrom.Name = "m_ebFrom";
            this.m_ebFrom.Size = new System.Drawing.Size(281, 26);
            this.m_ebFrom.TabIndex = 8;
            // 
            // m_ebTo
            // 
            this.m_ebTo.Location = new System.Drawing.Point(1181, 132);
            this.m_ebTo.Name = "m_ebTo";
            this.m_ebTo.Size = new System.Drawing.Size(281, 26);
            this.m_ebTo.TabIndex = 9;
            // 
            // m_ebSent
            // 
            this.m_ebSent.Location = new System.Drawing.Point(1181, 164);
            this.m_ebSent.Name = "m_ebSent";
            this.m_ebSent.Size = new System.Drawing.Size(281, 26);
            this.m_ebSent.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1112, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1112, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1112, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sent";
            // 
            // m_ebSubject
            // 
            this.m_ebSubject.Location = new System.Drawing.Point(1181, 196);
            this.m_ebSubject.Name = "m_ebSubject";
            this.m_ebSubject.Size = new System.Drawing.Size(995, 26);
            this.m_ebSubject.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1112, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Subject";
            // 
            // m_ebFolderName
            // 
            this.m_ebFolderName.Location = new System.Drawing.Point(1922, 19);
            this.m_ebFolderName.Name = "m_ebFolderName";
            this.m_ebFolderName.Size = new System.Drawing.Size(152, 26);
            this.m_ebFolderName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1816, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Folder Name";
            // 
            // m_ebFolderPath
            // 
            this.m_ebFolderPath.Location = new System.Drawing.Point(1525, 19);
            this.m_ebFolderPath.Name = "m_ebFolderPath";
            this.m_ebFolderPath.Size = new System.Drawing.Size(281, 26);
            this.m_ebFolderPath.TabIndex = 18;
            this.m_ebFolderPath.Text = "c:\\temp\\mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1428, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Folder Path";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2188, 1012);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_ebFolderPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_ebFolderName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_ebSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_ebSent);
            this.Controls.Add(this.m_ebTo);
            this.Controls.Add(this.m_ebFrom);
            this.Controls.Add(this.m_pbExport);
            this.Controls.Add(this.m_lblDates);
            this.Controls.Add(this.m_lblFlags);
            this.Controls.Add(this.m_ebDates);
            this.Controls.Add(this.m_ebFlags);
            this.Controls.Add(this.m_ebBody);
            this.Controls.Add(this.m_pbLoad);
            this.Controls.Add(this.m_lvHeaders);
            this.Name = "Browser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView m_lvHeaders;
        private System.Windows.Forms.Button m_pbLoad;
        private System.Windows.Forms.TextBox m_ebBody;
        private System.Windows.Forms.TextBox m_ebFlags;
        private System.Windows.Forms.TextBox m_ebDates;
        private System.Windows.Forms.Label m_lblFlags;
        private System.Windows.Forms.Label m_lblDates;
        private System.Windows.Forms.Button m_pbExport;
        private System.Windows.Forms.TextBox m_ebFrom;
        private System.Windows.Forms.TextBox m_ebTo;
        private System.Windows.Forms.TextBox m_ebSent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_ebSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_ebFolderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_ebFolderPath;
        private System.Windows.Forms.Label label6;
    }
}

