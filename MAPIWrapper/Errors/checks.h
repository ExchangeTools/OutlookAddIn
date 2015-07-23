#pragma once
#include "MapiException.h"


#define check_com_err(err) { if(FAILED(err)) throw ComException(err,__FILE__, __LINE__); }
#define check_mapi_err(err) { if(FAILED(err)) throw MapiException(err,__FILE__, __LINE__); }
#define check_arg(cond) { if(cond != true) throw BaseException(L"Invalid argument", E_INVALIDARG, __FILE__, __LINE__); }

