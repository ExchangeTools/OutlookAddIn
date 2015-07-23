#include "stdafx.h"
#include "BaseException.h"



BaseException::BaseException(void)
{
	m_description = CComBSTR(L"");
}


BaseException::~BaseException(void)
{
}
