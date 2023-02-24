	.data
N:	.word, 5
	.text
	.globl main
main:
	lw	$t1, N		# Loads N value in $t1
	addi	$t2, $zero, 0	# Stores zero in $t2, this is where the result is stored
	addi	$t0, $zero, 2	# Store 2 in $t0
	div	$t0, $t1, $t0	# Divide input by 2
	mfhi	$s1		# Save remainder in $s1
	blt	$t1, 2, end	# Checks if $t1 is less than 2, if it is, then the program will jump to end
	beqz	$s1, evenLoop	# Checks if $s1 is equal to zero if it is, then $t1 is even and the program will jump to evenLoop
	bnez	$s1, subOdd	# Checks if $s1 is not equal to zero, if it is, then $t1 is odd and the program will jump to subOdd
evenLoop:
	add	$t2, $t2, $t1	# Adds $t1 value and $t2 value and stores it in #t2
	subi	$t1, $t1, 2	# Subtracts 2 from $t1 and stores it in $t1
	beqz	$t1, end	# Checks if $t1 is equal to zero, if it is, then the program will jump to end
	j	evenLoop	# Runs evenLoop again
subOdd:
	subi	$t1, $t1, 1	# Subtracts 1 from #t1 to make it even and begin the count
	j	oddLoop		# Jumps to oddLoop
oddLoop:
	add	$t2, $t2, $t1	# Adds $t1 value and $t2 value and stores it in #t2
	subi	$t1, $t1, 2	# Subtracts 2 from $t1 and stores it in $t1
	beqz	$t1, end	# Checks if $t1 is equal to zero, if it is, then the program will jump to end
	j	oddLoop		# Runs oddLoop again
end:
	li	$v0, 1		# Prepare to print and integer
	add	$a0, $zero, $t2	# Add result for output
	syscall			# System call
	li	$v0, 10		# Prepare to terminate program
	syscall			# System call
