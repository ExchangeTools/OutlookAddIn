#include "stdafx.h"
#include "MapiException.h"


MapiException::MapiException(void)
{
	m_errorPrefix = L"MAPI ";
}

MapiException::~MapiException(void)
{
}
