#pragma once

#include "errors/checks.h"
template <class T> class MapiSmartPtr
{
public:

	MapiSmartPtr(T * mapiObject)
	{ 
		m_pMapiItem = mapiObject; 
	}

	MapiSmartPtr()
	{ 
		m_pMapiItem = NULL; 
	}

	~MapiSmartPtr() 
	{ 
		try
		{
			FreeMapiObject();
		}
		catch (...)
		{		}
	}


	void FreeMapiObject()
	{
		if ( m_pMapiItem != NULL )
		{
			HRESULT hr = MAPIFreeBuffer(m_pMapiItem);
			check_mapi_err(hr);
			m_pMapiItem = NULL;
		}
	}

	operator T * () { return m_pMapiItem; }

	T* operator -> () { return m_pMapiItem; }

	T** operator & () { return &m_pMapiItem; }
//private:
	T *	m_pMapiItem;
};


typedef MapiSmartPtr<SPropValue> SmartSPropValue;
typedef MapiSmartPtr<SRowSet> SmartSRowSet;