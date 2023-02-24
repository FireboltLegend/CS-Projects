	.data	
arg1:	.word	0
arg2:	.word	0
	.text
	.globl main
main:
	li 	$v0, 5		# Read Int
	syscall			# System Call
	la 	$t1, arg1
	sw 	$v0, 0($t1)	# Stores user input in $t1
	li 	$v0, 5		# Read Int
	syscall			# System Call
	la 	$t2, arg2
	sw 	$v0, 0($t2)	# Stores user input in $t2
	lw	$s1, 0($t1)	# Load $t1 value in $s1
	lw	$t1, 0($t2)	# Load $t2 value in $t1

	addi	$s3, $zero, 0	# Adds zero and zero and stores it in $s3
	blez	$t2, fin	# Checks if $t2 is less than or equal to zero, if it is, it will execute fin function
	blez	$t1, fin	# Checks if $t1 is less than or equal to zero, if it is, it will execute fin function
fori:
	add	$s3, $s3, $s1	# Adds $s3 value and $s1 value and stores it in $s3
	addi	$t1, $t1, -1	# Adds $t1 value and -1 and stores it in $t1
	bnez	$t1, fori	# Checks if $t1 is not equal to zero, if it is not equal to zero, it will exectute fori function again
fin:
	li	$v0, 1		# Prepares to print
	add	$a0, $zero, $s3	# Prints result
	syscall			# System Call
	li	$v0, 10		# Program Termination
	syscall			# System Call
