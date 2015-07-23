// dllmain.h : Declaration of module class.

class CMAPIWrapperModule : public ATL::CAtlDllModuleT< CMAPIWrapperModule >
{
public :
	DECLARE_LIBID(LIBID_MAPIWrapperLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_MAPIWRAPPER, "{7A23346B-6F3E-4E4A-9F81-971946BC05F8}")
};

extern class CMAPIWrapperModule _AtlModule;
