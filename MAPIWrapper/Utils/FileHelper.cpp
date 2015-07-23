#include "stdafx.h"
#include "filehelper.h"


FileHelper::FileHelper(void)
{

}
FileHelper::~FileHelper(void)
{
}
CComBSTR FileHelper::CutFileName(LPSTR pFullFileName)
{
	std::string szTempPath(pFullFileName);
	size_t pos = szTempPath.find_last_of("\\");

    if(pos != std::string::npos)
		return szTempPath.substr(pos + 1).c_str();
	else
		return szTempPath.c_str();
}