using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;

using Office = Microsoft.Office.Core;

namespace OutlookAddIn
{
    public partial class ThisAddIn
    {

        Office.CommandBar _newToolBar;
        Office.CommandBarButton _enumerateHiearchyButton;
        Office.CommandBarButton _moveButton;
        Outlook.Explorers _selectExplorers;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            _selectExplorers = this.Application.Explorers;
            _selectExplorers.NewExplorer += new Outlook
                .ExplorersEvents_NewExplorerEventHandler(newExplorer_Event);
            AddToolbar();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void newExplorer_Event(Outlook.Explorer new_Explorer)
        {
            ((Outlook._Explorer)new_Explorer).Activate();
            _newToolBar = null;
            AddToolbar();
        }

        private void AddToolbar()
        {
                       
            const string btnEnumHierarchy = "Enumerate Hierarchy";
            if (_newToolBar == null)
            {
                Office.CommandBars cmdBars =
                    this.Application.ActiveExplorer().CommandBars;
                _newToolBar = cmdBars.Add("Test Bar",
                    Office.MsoBarPosition.msoBarTop, false, true);
            }
            try
            {
                Office.CommandBarButton button_1 =
                    (Office.CommandBarButton)_newToolBar.Controls
                    .Add(1, missing, missing, missing, missing);
                button_1.Style = Office
                    .MsoButtonStyle.msoButtonCaption;
                button_1.Caption = btnEnumHierarchy;
                button_1.Tag = btnEnumHierarchy;
                if (this._enumerateHiearchyButton == null)
                {
                    this._enumerateHiearchyButton = button_1;
                    _enumerateHiearchyButton.Click += new Office.
                        _CommandBarButtonEvents_ClickEventHandler
                        (EnumerateHierarchyClick);
                }

                Office.CommandBarButton button_2 = (Office
                    .CommandBarButton)_newToolBar.Controls.Add
                    (1, missing, missing, missing, missing);
                button_2.Style = Office
                    .MsoButtonStyle.msoButtonCaption;
                button_2.Caption = "Move folder";
                button_2.Tag = "Move folder";
                _newToolBar.Visible = true;
                if (this._moveButton == null)
                {
                    this._moveButton = button_2;
                    _moveButton.Click += _moveButton_Click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void _moveButton_Click(Office.CommandBarButton Ctrl, ref bool CancelDefault)
        {
            try
            {
                var form = new MoveForm();
                form.Application = this.Application;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnumerateHierarchyClick(Office.CommandBarButton ctrl,
                ref bool cancel)
        {
            try
            {
                var form = new EnumerateHierarchy();
                form.Application = this.Application;
                form.Folder = new Wrappers.FolderWrp(this.Application.ActiveExplorer().CurrentFolder);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
