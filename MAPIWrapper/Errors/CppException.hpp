#pragma once

#include <eh.h>
#include <windows.h>

class CppException
{
public:
	CppException(EXCEPTION_POINTERS* pExp)
	{
		m_pExp = pExp;
		//m_pExp->ContextRecord->
	}
	static void SwitchSEXToCppException()
	{
		_set_se_translator(translator_func);
	}

	void HideWindowsErrorReportingDialog()
	{
		SetErrorMode(SEM_NOGPFAULTERRORBOX);
	}
private:
	static void translator_func( unsigned int u, EXCEPTION_POINTERS* pExp )
	{
		throw CppException(pExp);
	}

	EXCEPTION_POINTERS* m_pExp;
};