﻿
using OutlookAddIn.Wrappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddIn
{
    public partial class EnumerateHierarchy : BaseForm
    {
        private FolderWrp _folder;
        

        public FolderWrp Folder 
        {
            set { _folder = value; }
        }
        public EnumerateHierarchy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_folder != null)
            {
                txtFolderPath.Text = _folder.FolderPath;
            }
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _folder.Dispose();
        }

        private void Enumerate_Click(object sender, EventArgs e)
        {
            try
            {

                string temp;
                var fldWrp = new MAPIWrapperLib.MapiFolderWrp();

                //fldWrp.MoveTo(_folder.Session.Session.MAPIOBJECT);

                MAPIWrapperLib.IMapiSubFolders subs = fldWrp.GetAllSubFolders(_folder.MAPIOBJECT);
                var count = subs.Count;
                var start = DateTime.Now;
                Debug.WriteLine(start.ToString());

                for (uint t = 0; t < count; t++)
                {
                    subs.GetNextItem(out temp);
                }
                var end = DateTime.Now;
                Debug.WriteLine(end.ToString());
                MessageBox.Show(String.Format("Elapsed time - '{0}'", (end - start).ToString(@"hh\:mm\:ss")), "Enumeration completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Debug.WriteLine(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _folder.Folder = NameSpace.PickFolder();
            txtFolderPath.Text = _folder.Folder.FolderPath;
            txtFolderPath.Update();
        }
    }
}
