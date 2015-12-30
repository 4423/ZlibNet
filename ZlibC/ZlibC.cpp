// これは メイン DLL ファイルです。

#include "stdafx.h"

#include "ZlibC.h"
#include "zlib.h"

int _uncompress(unsigned char dest[], unsigned long destLen, unsigned char src[], unsigned long srcLen)
{
	return uncompress(dest, &destLen, src, srcLen);
}
