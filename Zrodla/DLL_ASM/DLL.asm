.486
.model flat, stdcall
.data
.code

;************************************************************************
; Procedura obliczaj¹ca macierz U. Parametry wejœciowe: macierzU (miejsce
; na wynik) oraz rozmiar macierzy.
;************************************************************************
computeMatrixU_ASM proc matrixU:ptr qword, matrixSize:dword
push ebx

mov edx, matrixU
mov eax, 0 ; eax = k
.while eax < (matrixSize - 1)
	mov ebx, eax
	inc ebx ; ebx = i
	.while ebx < matrixSize
		mov ecx, eax
		inc ecx ; ecx = j
		.while ecx < matrixSize
			;matrixU[k * size + k]
			mov edi, eax
			imul edi, matrixSize
			add edi, eax
			fld qword ptr [edx + 8*edi]

			;matrixU[k * size + j]
			mov edi, eax
			imul edi, matrixSize
			add edi, ecx
			fld qword ptr [edx + 8*edi]

			;matrixU[i * size + k]
			mov edi, ebx
			imul edi, matrixSize
			add edi, eax
			fld qword ptr [edx + 8*edi]

			fmulp
			fdivrp

			;matrixU[i * size + j]
			mov edi, ebx
			imul edi, matrixSize
			add edi, ecx
			fld qword ptr [edx + 8*edi]

			fsubrp
			fstp qword ptr [edx + 8*edi]
			inc ecx
		.endw
		inc ebx
	.endw
	inc eax
.endw

pop ebx
ret
computeMatrixU_ASM endp


;************************************************************************
; Procedura obliczaj¹ca macierz L. Parametry wejœciowe: macierzL (miejsce
; na wynik), macierzU oraz rozmiar macierzy.
;************************************************************************
computeMatrixL_ASM proc matrixL:ptr qword, matrixU:ptr qword, matrixSize:dword
push ebx

mov ecx, 0 ; ecx = k
_for_k:
	.if ecx == (matrixSize-1)
	jmp _end_for_k
	.endif
	mov ebx, ecx
	inc ebx ; ebx = j
	_for_i:
		cmp ebx, matrixSize
		jae _end_for_i
		push ebx		
		imul ebx, matrixSize ; ebx = i*size + k
		add ebx, ecx		
		mov eax, ecx ; eax = k*size + k
		imul eax, matrixSize
		add eax, ecx
				
		mov edx, matrixU
		fld qword ptr [edx + 8*ebx]
		fld qword ptr [edx + 8*eax]
		fdiv
		mov edx, matrixL
		fstp qword ptr [edx + 8*ebx]

		pop ebx
		inc ebx
		jmp _for_i
	_end_for_i:
	inc ecx
	jmp _for_k
_end_for_k:
mov eax, 0 ; eax = i
mov ebx, 0 ; ebx = j
_second_for_i:
	cmp eax, matrixSize
	jae _end_second_for_i
	_second_for_j:
		cmp ebx, matrixSize
		jae _end_second_for_j
			.if eax > ebx
				mov ecx, eax ; ecx = i * size + j
				imul ecx, matrixSize
				add ecx, ebx
				mov edx, matrixU
				fldz ; laduj stala zero
				fstp qword ptr [edx + 8*ecx]			
			.endif
			.if eax == ebx
				mov ecx, eax ; ecx = i * size + j
				imul ecx, matrixSize
				add ecx, ebx
				mov edx, matrixL
				fld1 ; laduj stala jeden
				fstp qword ptr [edx + 8*ecx]
			.endif
		inc ebx
		jmp _second_for_j
	_end_second_for_j:
	inc eax
	jmp _second_for_i
_end_second_for_i:

pop ebx
ret
computeMatrixL_ASM endp


;************************************************************************
; Procedura obliczaj¹ca wektor Y. Parametry wejœciowe: wektor Y (miejsce 
; na wynik), wektor B, macierz L oraz rozmiar macierzy.
;************************************************************************
computeVectorY_ASM proc vectorY:ptr qword, vectorB:ptr qword, matrixL:ptr qword, matrixSize:dword
push ebx

mov eax, vectorY
mov ebx, vectorB
mov ecx, matrixL
fld qword ptr [ebx]
fstp qword ptr [eax]

mov esi, 1 ; esi = i
_for_i:
	cmp esi, matrixSize
	jae _end_for_i

	fldz
	mov edi, 0 ; edi = k
	_for_k:
		.if (edi <= esi)
			mov edx, esi
			imul edx, matrixSize
			add edx, edi			
			fld qword ptr [ecx + 8*edx]
			fld qword ptr [eax + 8*edi]
			fmul
			fadd
		.else
			jmp _end_for_k
		.endif
		inc edi
		jmp _for_k
	_end_for_k:	
	fld qword ptr [ebx + 8*esi]
	fsubrp
	fstp qword ptr [eax + 8*esi]
	inc esi
	jmp _for_i
_end_for_i:

pop ebx
ret
computeVectorY_ASM endp

computeVectorX_ASM proc vectorX:ptr qword, vectorY:ptr qword, matrixU:ptr qword, matrixSize:dword
push ebx



pop ebx
ret
computeVectorX_ASM endp
end