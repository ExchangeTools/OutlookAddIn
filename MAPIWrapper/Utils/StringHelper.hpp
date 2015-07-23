#pragma once
#include "windef.h"
#include "MAPIDefS.h"
#include "stdio.h"
#include "..\Errors\checks.h"

class StringHelper
{
	StringHelper(void){}
	~StringHelper(void){}
public:
	static SBinary HexStringToSBinary(LPWSTR lpHexString)
	{
		check_arg(lpHexString != NULL);

		WCHAR *pos = lpHexString;
		SBinary bin={0};
		bin.cb = wcslen(lpHexString)/2;
		bin.lpb = new byte[bin.cb];

		for(ULONG count = 0; count < bin.cb; count++) 
		{
			swscanf_s(pos, L"%2hhx", &bin.lpb[count]);
			pos += 2;
		}
		return bin;
	}

	#pragma message("\nNeed refactoring: Slow, not secure and memory not effective.\n")
	static LPWSTR SBinaryToHexString(LPSBinary pBinary)
	{
		check_arg(pBinary != NULL);
		check_arg(pBinary->lpb != NULL);

		LPSTR pBuff = new char[pBinary->cb+1];
		char* pos = pBuff;
		for (ULONG i = 0; i < pBinary->cb; i++)
		{
			pos += sprintf_s(pos, pBinary->cb, "%02X", pBinary->lpb[i]);
		}

		return CComBSTR(pBuff).Detach();
	}
};