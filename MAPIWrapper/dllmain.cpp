// dllmain.cpp : Implementation of DllMain.

#include "stdafx.h"
#include "resource.h"
#include "MAPIWrapper_i.h"
#include "dllmain.h"
#include "errors\CppException.hpp"
CMAPIWrapperModule _AtlModule;

// DLL Entry Point
extern "C" BOOL WINAPI DllMain(HINSTANCE hInstance, DWORD dwReason, LPVOID lpReserved)
{
	hInstance;

	if (dwReason == DLL_PROCESS_ATTACH)
	{
		 CppException::SwitchSEXToCppException();
    }

	return _AtlModule.DllMain(dwReason, lpReserved); 
}
