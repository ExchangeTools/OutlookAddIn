#include "stdafx.h"
#include "ComException.h"


ComException::ComException(void)
{
	m_errorPrefix = L"MAPI ";
}


ComException::~ComException(void)
{
}
