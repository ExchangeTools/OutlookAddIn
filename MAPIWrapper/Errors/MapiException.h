#pragma once
#include "BaseException.h"


class MapiException :
	public BaseException
{
public:
	MapiException(void);
	MapiException(HRESULT errorCode, LPSTR pFullFileName, int lineNumber ):
		BaseException(errorCode, pFullFileName, lineNumber)
	{
		m_errorPrefix = L"MAPI ";
	}
	~MapiException(void);
private:
	
};

