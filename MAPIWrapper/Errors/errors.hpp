#pragma once
#include "EventLogReporter.h"
#include "CppException.hpp"


#define CATCH_SEH									\
catch(CppException& exp)                            \
{													\
    hr = E_FAIL;									\
    exp.HideWindowsErrorReportingDialog();          \
	EventLogReporter::WriteError();					\
    Error(L"Something bad happened.");		\
}
