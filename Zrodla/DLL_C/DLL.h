#pragma once
#define EXPORT_DLL __declspec(dllexport)

extern "C" {
	EXPORT_DLL double licz_c(double x, double y);
}