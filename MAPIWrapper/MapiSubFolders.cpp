// MapiSubFolders.cpp : Implementation of CMapiSubFolders

#include "stdafx.h"
#include "MapiSubFolders.h"


// CMapiSubFolders

void CMapiSubFolders::Init(IMAPITable * pTable)
{
	m_ptrTable = pTable;
}
void CMapiSubFolders::SetSeekRowAndColumns()
{
	if(m_isSetSeekRowAndColumns)
		return;
	HRESULT hr = E_FAIL;
	//THROW_MAPI_ERR(pRoot, hr);
	hr = m_ptrTable->SeekRow(BOOKMARK_BEGINNING,0,NULL);
	//THROW_MAPI_ERR(pTable, hr);

	SizedSPropTagArray(2, sptCols) = { 2, { PR_ENTRYID, PR_DISPLAY_NAME } };
    hr = m_ptrTable->SetColumns((LPSPropTagArray)&sptCols , 0);
	m_isSetSeekRowAndColumns = true;
}


STDMETHODIMP CMapiSubFolders::GetNextItem(BSTR* DisplayName)
{
	SetSeekRowAndColumns();

	HRESULT hr = E_FAIL;
	try
	{
		if(m_pRows == NULL || m_counter == 255)
		{
			hr = m_ptrTable->QueryRows(255, 0, &m_pRows);
			m_counter = 0;
		}

		if(m_pRows->cRows == 0)
			return S_OK;

		for(int j = 0; j<2; j++)
		{
			if(m_pRows->aRow[m_counter].lpProps[j].ulPropTag == PR_DISPLAY_NAME)
			{
				*DisplayName = ::SysAllocString(m_pRows->aRow[m_counter].lpProps[j].Value.lpszW);
				m_counter++;
				return S_OK;
			}
		}
	}
	catch(...)
	{
		m_pRows = NULL;
	}
	

	return hr;
}


STDMETHODIMP CMapiSubFolders::get_Count(ULONG* pVal)
{
	return m_ptrTable->GetRowCount(0, pVal);
}
