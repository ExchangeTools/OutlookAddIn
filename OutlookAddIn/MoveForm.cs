using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutlookAddIn
{
    public partial class MoveForm : BaseForm
    {
        private Microsoft.Office.Interop.Outlook.MAPIFolder _srcFolder;
        private Microsoft.Office.Interop.Outlook.MAPIFolder _trgFolder;
        public MoveForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_srcFolderSelection_Click(object sender, EventArgs e)
        {
            _srcFolder = NameSpace.PickFolder();
            _txtSrcFolder.Text = _srcFolder.FolderPath;
            _txtSrcFolder.Update();
        }

        private void m_btnTrgFolder_Click(object sender, EventArgs e)
        {
            _trgFolder = NameSpace.PickFolder();
            _txtTrgFolder.Text = _trgFolder.FolderPath;
            _txtTrgFolder.Update();
        }

        private void m_btnMove_Click(object sender, EventArgs e)
        {
            if (_srcFolder == null)
            {
                MessageBox.Show("Pick up Source folder.");
                return;
            }
            if (_trgFolder == null)
            {
                MessageBox.Show("Pick up Target folder.");
                return;
            }
            var start = DateTime.Now;
            _txtOutput.AppendText( String.Format("Moving '{0}' folder to '{1}'.\n", _srcFolder.Name, _trgFolder.FolderPath));
            _srcFolder.MoveTo(_trgFolder);
            var finish = DateTime.Now;
            _txtOutput.AppendText(String.Format("Moving completed. Elapsed time - '{0}'.\n", (finish - start).ToString(@"hh\:mm\:ss")));
        }
    }
}
