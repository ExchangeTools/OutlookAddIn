#pragma once

#include "utils\filehelper.h"
using namespace ATL; 
class BaseException
{
public:
	BaseException(void);

	BaseException(HRESULT errorCode, LPSTR pFullFileName, int lineNumber )
	{
		std::wostringstream stringStream;
				
		stringStream << m_errorPrefix << L"Error code: '" << errorCode << L"', file name: '" << 
			FileHelper::CutFileName(pFullFileName) << L"', line number: '" << lineNumber << "'.";
		m_description.Append(stringStream.str().c_str());
		m_code = errorCode; 
	}

	BaseException(LPWSTR errorDescription, HRESULT errorCode, LPSTR pFullFileName, int lineNumber )
	{
		std::wostringstream stringStream;
				
		stringStream << m_errorPrefix << L"Error description: '" << errorDescription << L"', file name: '" << 
			FileHelper::CutFileName(pFullFileName) << L"', line number: '" << lineNumber << "'.";
		m_description.Append(stringStream.str().c_str());
		m_code = errorCode; 
	}

	~BaseException(void);
	virtual DWORD Code () const { return m_code; }
	virtual CComBSTR Description () const { return m_description; }

protected:
	DWORD       m_code;
	CComBSTR    m_description;
	CComBSTR	m_errorPrefix; 
};

