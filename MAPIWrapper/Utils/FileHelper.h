#pragma once

using namespace ATL;
class FileHelper 
{
public:
	FileHelper(void);
	~FileHelper(void);
	static CComBSTR CutFileName(LPSTR pFullFileName);
};