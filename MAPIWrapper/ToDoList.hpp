#pragma once

#define STR2(x) #x
#define STR1(x) STR2(x)
#define WRN_MSG __FILE__ "("STR1(__LINE__)") : Warning Msg: "


//////////////////////////////////////////////////////
#pragma message("\nTODO:\
1. Develop a class to DUMP memmory after SEH.\n\
2. EventLogReporter class realisation is required.\n\
3. Will be amazing to have DEBUG mode with extended logging.\n\
4. Write stack backtrace to crash log(msdn.microsoft.com/en-us/library/ms680650%28v=VS.85%29.aspx). \n")


