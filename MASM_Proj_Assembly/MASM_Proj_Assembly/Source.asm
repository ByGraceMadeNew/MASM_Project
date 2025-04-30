.386
.model flat, stdcall
option casemap:none

ExitProcess PROTO, dwExitCode: DWORD
GetTickCount PROTO
INCLUDE Irvine32.inc
INCLUDELIB Irvine32.lib

.data
n              dd 46
fibArray       dd 50 dup(?)
start DWORD 0


.code


FibonacciRecursive proc
    push ebp
    mov ebp, esp
    push ebx
    push esi
    push edi

    mov eax, [ebp+8]        ; n
    mov esi, [ebp+12]       ; fibArray pointer

    cmp eax, 0
    jne check_one
    ; n == 0
    mov dword ptr [esi], 0
    mov eax, 0
    jmp done

check_one:
    cmp eax, 1
    jne check_recursive
    ; n == 1
    mov dword ptr [esi+4], 1
    mov eax, 1
    jmp done

check_recursive:
    ; Recursive call for (n-1)
    dec eax
    push esi
    push eax
    call FibonacciRecursive
    add esp, 8

    
    ; Compute fibArray[n]

    mov eax, [ebp+8]     
    mov edx, eax
    dec edx
    imul edx, 4
    mov edx, [esi+edx]   

    mov ebx, eax
    sub ebx, 2
    imul ebx, 4
    add edx, [esi+ebx]   

    imul eax, 4
    mov [esi+eax], edx   

    mov eax, edx         
    jmp done

done:
    pop edi
    pop esi
    pop ebx
    pop ebp
    ret
FibonacciRecursive endp


error_case:
    INVOKE ExitProcess, 0

main proc

    ; --- Validate input ---
    cmp n, 46
    ja error_case
    cmp n, 0
    jle error_case

    

    ; --- Run Fibonacci ---
    push offset fibArray
    push n
    call FibonacciRecursive
    call WriteInt           
    call Crlf



    

    INVOKE ExitProcess, 0
main endp

end main
