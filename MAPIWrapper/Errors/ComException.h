#pragma once
class ComException:BaseException
{
public:
	ComException(void);
	~ComException(void);
	ComException(HRESULT errorCode, LPSTR pFullFileName, int lineNumber ):
		BaseException(errorCode, pFullFileName, lineNumber)
	{
		m_errorPrefix = L"MAPI ";
	}
};

