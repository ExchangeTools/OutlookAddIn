using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace OutlookAddIn
{
    public class BaseForm : Form
    {
        private Outlook.NameSpace _nameSpace;
        public Outlook.Application Application { protected get; set; }
        protected Outlook.NameSpace NameSpace 
        {
            get
            {
                if( _nameSpace == null)
                    _nameSpace = Application.GetNamespace("Mapi");
                return _nameSpace;
            }
            set { _nameSpace = value; }
        }

    }
}
