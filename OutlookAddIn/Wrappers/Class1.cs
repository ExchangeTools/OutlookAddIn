using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddIn.Wrappers
{
    public class FolderWrp : IDisposable
    {
        private Outlook.MAPIFolder _mapiFolder;

        public Outlook.MAPIFolder Folder 
        { 
            set { _mapiFolder = value; }
            get { return _mapiFolder; }
        }
        public FolderWrp(Outlook.MAPIFolder mAPIFolder)
        {
            
            _mapiFolder = mAPIFolder;
        }

        public void Dispose()
        {
            if (_mapiFolder != null)
            {
                Marshal.ReleaseComObject(_mapiFolder);
                _mapiFolder = null;
            }
        }

        public void AddToFavorites([OptionalAttribute]object fNoUI, [OptionalAttribute]object Name)
        {
            throw new NotImplementedException();
        }

        public void AddToPFFavorites()
        {
            throw new NotImplementedException();
        }

        public string AddressBookName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Outlook.Application Application
        {
            get { throw new NotImplementedException(); }
        }

        public Outlook.OlObjectClass Class
        {
            get { throw new NotImplementedException(); }
        }

        public Outlook.MAPIFolder CopyTo(Outlook.MAPIFolder DestinationFolder)
        {
            throw new NotImplementedException();
        }

        public Outlook.View CurrentView
        {
            get { throw new NotImplementedException(); }
        }

        public bool CustomViewsOnly
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Outlook.OlItemType DefaultItemType
        {
            get { throw new NotImplementedException(); }
        }

        public string DefaultMessageClass
        {
            get { throw new NotImplementedException(); }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public string Description
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public string EntryID
        {
            get { throw new NotImplementedException(); }
        }

        public string FolderPath
        {
            get { return _mapiFolder.FolderPath; }
        }

        public Outlook.Folders Folders
        {
            get { throw new NotImplementedException(); }
        }

        public string FullFolderPath
        {
            get { return _mapiFolder.FolderPath; }
        }

        public Outlook.CalendarSharing GetCalendarExporter()
        {
            throw new NotImplementedException();
        }

        public stdole.StdPicture GetCustomIcon()
        {
            throw new NotImplementedException();
        }

        public Outlook.Explorer GetExplorer([OptionalAttribute]object DisplayMode)
        {
            throw new NotImplementedException();
        }

        public Outlook.StorageItem GetStorage(string StorageIdentifier, Outlook.OlStorageIdentifierType StorageIdentifierType)
        {
            throw new NotImplementedException();
        }

        public Outlook.Table GetTable([OptionalAttribute]object Filter, [OptionalAttribute]object TableContents)
        {
            throw new NotImplementedException();
        }

        public bool InAppFolderSyncObject
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSharePointFolder
        {
            get { throw new NotImplementedException(); }
        }

        public Outlook.Items Items
        {
            get { throw new NotImplementedException(); }
        }

        public dynamic MAPIOBJECT
        {
            get { return _mapiFolder.MAPIOBJECT; }
        }

        public void MoveTo(Outlook.MAPIFolder DestinationFolder)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public dynamic Parent
        {
            get { throw new NotImplementedException(); }
        }

        public Outlook.PropertyAccessor PropertyAccessor
        {
            get { throw new NotImplementedException(); }
        }

        public Outlook.NameSpace Session
        {
            get { return _mapiFolder.Session; }
        }

        public void SetCustomIcon(stdole.StdPicture Picture)
        {
            throw new NotImplementedException();
        }

        public bool ShowAsOutlookAB
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Outlook.OlShowItemCount ShowItemCount
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Outlook.Store Store
        {
            get { throw new NotImplementedException(); }
        }

        public string StoreID
        {
            get { throw new NotImplementedException(); }
        }

        public int UnReadItemCount
        {
            get { throw new NotImplementedException(); }
        }

        public Outlook.UserDefinedProperties UserDefinedProperties
        {
            get { throw new NotImplementedException(); }
        }

        public dynamic UserPermissions
        {
            get { throw new NotImplementedException(); }
        }

        public Outlook.Views Views
        {
            get { throw new NotImplementedException(); }
        }

        public bool WebViewAllowNavigation
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool WebViewOn
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string WebViewURL
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
