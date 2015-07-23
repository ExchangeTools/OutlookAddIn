#pragma once
class EventLogReporter
{
public:
	//EventLogReporter(void);
	//~EventLogReporter(void);
	static void WriteError();
	static void WriteWarning();
	static void WriteInformation();
private:
	static void WriteEvent();
};

