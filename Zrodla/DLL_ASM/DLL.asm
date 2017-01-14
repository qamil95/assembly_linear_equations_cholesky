.486
.model flat, stdcall
.data
.code
licz_asm proc x:qword, y:qword
	finit
	fld x
	fld y
	fadd
	ret
licz_asm endp
end