/*
	Autor: Kamil Ziêtek
	Rok akademicki: 2016/2017
	Semestr: 5
	Grupa: 8
*/

#include "DLL.h"

/**************************************************************************/
/* Funkcja obliczaj¹ca macierz U.Parametry wejœciowe : macierzU(miejsce   */
/* na wynik) oraz rozmiar macierzy.                                       */
/**************************************************************************/
void computeMatrixU_C(double* matrixU, int size) {
	for (int k = 0; k < size - 1; k++)
		for (int i = k + 1; i < size; i++)		
			for (int j = k + 1; j < size; j++)			
				matrixU[i*size+j] = matrixU[i*size+j] - ((matrixU[i*size+k] * matrixU[k*size+j]) / matrixU[k*size+k]);
}

/***************************************************************************/
/* Funkcja obliczaj¹ca macierz L. Parametry wejœciowe: macierzL (miejsce   */
/* na wynik), macierzU oraz rozmiar macierzy.                              */
/***************************************************************************/
void computeMatrixL_C(double* matrixL, double* matrixU, int size)
{
	for (int k = 0; k < size - 1; k++)
		for (int i = k + 1; i < size; i++)
			matrixL[i*size+k] = (matrixU[i*size+k] / matrixU[k*size+k]);

	for (int i = 0; i < size; i++)
		for (int j = 0; j < size; j++)
		{
			if (i > j) matrixU[i * size + j] = 0;
			if (i == j) matrixL[i * size + j] = 1;
		}
}

/**************************************************************************/
/* Funkcja obliczaj¹ca wektor Y. Parametry wejœciowe: wektor Y (miejsce   */
/* na wynik), wektor B, macierz L oraz rozmiar macierzy.                  */
/**************************************************************************/
void computeVectorY_C(double* vectorY, double* vectorB, double* matrixL, int size)
{
	vectorY[0] = vectorB[0];
	for (int i = 1; i < size; i++)
	{
		double sum = 0;
		for (int k = 0; k <= i; k++)
		{
			sum += matrixL[i*size+k] * vectorY[k];
		}
		vectorY[i] = vectorB[i] - sum;
	}
}

/**************************************************************************/
/* Funkcja obliczaj¹ca wektor X. Parametry wejœciowe: wektor X (miejsce   */
/* na wynik), wektor Y, macierz U oraz rozmiar macierzy.                  */
/**************************************************************************/
void computeVectorX_C(double* vectorX, double* vectorY, double* matrixU, int size)
{
	vectorX[size - 1] = vectorY[size - 1] / matrixU[(size - 1)*size + (size - 1)];
	for (int i = size - 2; i >= 0; i--)
	{
		double sum = 0;
		for (int k = i + 1; k < size; k++)
		{
			sum += matrixU[i*size + k] * vectorX[k];
		}
		vectorX[i] = (vectorY[i] - sum) / matrixU[i*size+i];
	}
}