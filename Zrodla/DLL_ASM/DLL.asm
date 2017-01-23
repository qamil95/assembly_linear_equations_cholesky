.486
.model flat, stdcall
.data
.code

;************************************************************************;
; Testowa procedura, dodaje do siebie dwie liczby                        ;
;************************************************************************;
test_asm proc x:qword, y:qword
	finit
	fld x
	fld y
	fadd
	ret
test_asm endp

computeMatrixU_ASM proc matrixU:ptr qword, matrixSize:dword

computeMatrixU_ASM endp

computeMatrixL_ASM proc matrixL:ptr qword, matrixU:ptr qword, matrixSize:dword
push ebx

mov ecx, 0
_for_k:
	inc ecx
	cmp ecx, matrixSize
	dec ecx
	jae _end_for_k
	mov ebx, ecx
	inc ebx
	_for_i:
		cmp ebx, matrixSize
		jae _end_for_i
		push ebx

		imul ebx, matrixSize
		add ebx, ecx
		mov eax, ecx
		imul eax, matrixSize
		add eax, ecx
		; ecx = k
		; ebx = i*size + k
		; eax = k*size + k
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
mov eax, 0
mov ebx, 0
_second_for_i:
	cmp eax, matrixSize
	jae _end_second_for_i
	_second_for_j:
		cmp ebx, matrixSize
		jae _end_second_for_j
			.if eax > ebx
				mov ecx, eax
				imul ecx, matrixSize
				add ecx, ebx
				mov edx, matrixU
				fldz
				fstp qword ptr [edx + 8*ecx]			
			.endif
			.if eax == ebx
				mov ecx, eax
				imul ecx, matrixSize
				add ecx, ebx
				mov edx, matrixL
				fld1
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

computeVectorY_ASM proc vectorY:ptr qword, vectorB:ptr qword, matrixL:ptr qword, matrixSize:dword

computeVectorY_ASM endp

computeVectorX_ASM proc vectorX:ptr qword, vectorY:ptr qword, matrixU:ptr qword, matrixSize:dword

computeVectorX_ASM endp
end