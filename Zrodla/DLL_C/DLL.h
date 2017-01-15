#pragma once
#define EXPORT_DLL __declspec(dllexport)

extern "C" {
	EXPORT_DLL double test_C(double x, double y);
	EXPORT_DLL void computeMatrixU_C(double* matrixU, int size);
	EXPORT_DLL void computeMatrixL_C(double* matrixL, double* matrixU, int size);
	EXPORT_DLL void computeVectorY_C(double* vectorY, double* vectorB, double* matrixL, int size);
	EXPORT_DLL void computeVectorX_C(double* vectorX, double* vectorY, double* matrixU, int size);
}