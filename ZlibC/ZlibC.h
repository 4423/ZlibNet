// ZlibC.h

#pragma once

extern "C" {
	__declspec(dllexport) int _uncompress(unsigned char dest[], unsigned long destLen, unsigned char src[], unsigned long srcLen);
}