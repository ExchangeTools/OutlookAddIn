#pragma once
#include "Errors\ComException.h"
#include "MAPIGuid.h"


class CMapiSessionWrp
{
public:
	static void GlobalInit(VARIANT mapiObject)
	{
		if(m_mapiSession != NULL)
			return;
		HRESULT hr = mapiObject.punkVal->QueryInterface( IID_IMAPISession, (LPVOID*)&m_mapiSession);
		check_com_err(hr);
		check_arg(m_mapiSession != NULL);
	}
	static IMAPISession * GetSession()
	{
		return m_mapiSession;
	}
	CMapiSessionWrp(void);
	~CMapiSessionWrp(void);
private:
	static IMAPISession* m_mapiSession;
};

