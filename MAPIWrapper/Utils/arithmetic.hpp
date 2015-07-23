#pragma once
#include "windef.h"
#include "..\Errors\checks.h"

class Arithmetic
{
public:
	static void IncrementLast4Bytes(LPBYTE pHexString, ULONG lenght)
	{
		check_arg(pHexString != NULL);
		check_arg(lenght >= 4);
		
		DWORD dwTemp = pHexString[lenght-4] << 24;
        dwTemp |= pHexString[lenght-3] << 16;
        dwTemp |= pHexString[lenght-2] << 8;
        dwTemp |= pHexString[lenght-1];
        
		dwTemp ++;
        
		pHexString[lenght-1] = (char)dwTemp;
        pHexString[lenght-2] = (char)(dwTemp >> 8);
        pHexString[lenght-3] = (char)(dwTemp >> 16);
        pHexString[lenght-4] = (char)(dwTemp >> 24);
	}
};