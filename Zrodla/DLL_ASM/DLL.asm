.486
.model flat, stdcall
.data
.code
test_asm proc x:qword, y:qword
	finit
	fld x
	fld y
	fadd
	ret
test_asm endp
end