# Abbas Khawaja
# aik210000
# The program assumes that two ordered lists are provided and will take the current element of each list and compare them
# If the current value of list1 is less than or equal to the current value of list2, then it will be added to the new list mList
# Else, the current value of list2 will be added to mList
# When the current element is added to the list, it is also printed out as well along with a space character for space separation
# If the index for either list reaches 5, the program will check if the other index has also reached 5, if it has, then the program will exit
# If not, that means there is still elements in the other list to add and the program will add those elements into mList
# After this, the program will terminate
.data
	list1:	.word -8, 0, 5, 6, 7
	list2:	.word -7, -6, -5, 1, 3
	mList:	.space 40	# List to store merged lists
	space:	.ascii " "
.text
	la	$t0, list1	# Load address of list1 into $t0
	la	$t1, list2	# Load address of list2 into $t1
	la	$t2, mList	# Load address of mList into $t2
	li	$t3, 0		# Initialize index for list1 to 0
	li	$t4, 0		# Initialize index for list2 to 0
	j	merge		# Jump to merge
merge:
	lw	$t5, ($t0)	# Load current element from list1 into $t5
	lw	$t6, ($t1)	# Load current element from list2 into $t6
	ble	$t5, $t6, loop1	# Checks if current element in list1 is less than or equal to current element in list2, if it is, then jump to loop1
	j	loop2		# Else, jump to loop2
    
loop1:
	sw	$t5, ($t2)	# Store current element from list1 into mList
	li	$v0, 1		# Prepare to output integer
	add	$a0, $zero, $t5	# Load current element from list1 for output
	syscall			# System call
	li	$v0, 4		# Prepare to output space character
	la	$a0, space	# Load space character for output
	syscall			# System call
	addi	$t0, $t0, 4	# Increment list1 pointer by 4
	addi	$t2, $t2, 4	# Increment mList pointer by 4
	addi	$t3, $t3, 1	# Increment index for list1 by 1
	bne	$t3, 5, merge	# Checks if index for list1 is not equal to 5, if it is not equal to 5, then jump back to merge
	bne	$t4, 5, exit1	# Checks if index for list2 is not equal to 5, if it is not equal to 5, then jump to exit1
	j	exit		# Else, jump to exit
loop2:
	sw	$t6, ($t2)	# Store current element from list2 into mList
	li	$v0, 1		# Prepare to output integer
	add	$a0, $zero, $t6	# Load current element from list2 for output
	syscall			# System call
	li	$v0, 4		# Prepare to output space character
	la	$a0, space	# Load space character for output
	syscall			# System call
	addi	$t1, $t1, 4	# Increment list2 pointer by 4
	addi	$t2, $t2, 4	# Increment mList pointer by 4
	addi	$t4, $t4, 1	# Increment index for list2 by 1
	bne	$t4, 5, merge	# Checks if index for list2 is not equal to 5, if it is not equal to 5, then jump back to merge
	bne	$t3, 5, exit2	# Checks if index for list1 is not equal to 5, it it is not equal to 5, then jump to exit2
	j	exit		# Else, jump to exit
exit1:
	lw	$t6, ($t1)	# Load current element from list2 into $t6
	sw	$t6, ($t2)	# Store current element from list2 into mList
	li	$v0, 1		# Prepare to output integer
	add	$a0, $zero, $t6	# Load current element from list2 for output
	syscall			# System call
	li	$v0, 4		# Prepare to output space character
	la	$a0, space	# Load space character for output
	syscall			# System call
	addi	$t1, $t1, 4	# Increment list2 pointer by 4
	addi	$t2, $t2, 4	# Increment mList pointer by 4
	addi	$t4, $t4, 1	# Increment index for list2 by 1
	bne	$t4, 5, exit1	# Checks if index for list2 is not equal to 5, if it is not equal to 5, then jump back to exit1
	j	exit		# Else, jump to exit
exit2:
	lw	$t5, ($t0)	# Load current element from list1 into $t5
	sw	$t5, ($t2)	# Store current element from list1 into mList
	li	$v0, 1		# Prepare to output integer
	add	$a0, $zero, $t5	# Load current element from list1 for output
	syscall			# System call
	li	$v0, 4		# Prepare to output space character
	la	$a0, space	# Load space character for output
	syscall			# System call
	addi	$t0, $t0, 4	# Increment list1 pointer by 4
	addi	$t2, $t2, 4	# Increment mList pointer by 4
	addi	$t3, $t3, 1	# Increment index for list1 by 1
	bne	$t3, 5, exit2	# Checks if index for list1 is not equal to 5, if it is not equal to 5, then jump back to exit1
	j	exit		# Else, jump to exit
exit:
	li	$v0, 10		# Prepare to terminate program
	syscall			# System call
