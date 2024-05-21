# Abbas Khawaja
# aik210000
# The program requests for the size of the list and requests that the given size is a power of 2.
# The program will take in the inputted value and store them in a list.
# The program will then perform a bottom-up merge sort by starting with 1 value in each sublist and merging these individual sublists
# and will continue this until it reaches the end of the list. After this it will add values again to the sublist but add 2 elements instead of 1,
# essentially increasing sublists size by multiplying by 2. This continues on until the program sees the sublist size is the size of the list.
# At this point the list has reached the top and is sorted so it is output to the user.
.data
	list:	.space 128	# List that stores user elements
	list1:	.space 64	# Sublist 1
	list2:	.space 64	# Sublist 2
	mList:	.space 128	# List to store merged lists
	sizeP:	.asciiz "Enter the Size of the Array (Only Numbers that are a Power of 2 are Allowed): "
	ePrompt:.asciiz "Enter Element: "
	oArr:	.asciiz "Original Array: "
	nArr:	.asciiz "\nSorted Array: "
	space:	.asciiz " "
.text
.globl main
main:
	la	$t8, list	# Load address of list into $t8
	li	$v0, 4		# Prepare to output sizeP
	la	$a0, sizeP	# Load sizeP for output
	syscall			# System Call
	li	$v0, 5		# Prepare to take in integer user input
	syscall			# System Call
	move	$s2, $v0	# Store user inputted size into $s2
	li	$t3, 1		# Temporarily save size of array in $t3
	beq	$s2, 1, exit	# If the size of the given array is just 1, then exit as the list that the user is requesting to be storted is already sorted.
	li	$t4, 0		# Load 0 in $t4
	li	$t9, 0		# Load 0 in $t9
	jal	fillArr		# Jump to fillArr
	li	$v0, 4		# Prepare to output oArr
	la	$a0, oArr	# Load oArr for output
	syscall			# System Call
	jal	printArr	# Jump to printArr
	la	$t0, list1	# Load address of list1 into $t0
	la	$t1, list2	# Load address of list2 into $t1
	la	$t2, mList	# Load address of mList into $t2
	li	$t3, 1		# Load 1 in $t3 (size of the initial sublists)
	li	$t5, 8		# Load 8 in $t5 (decrement value for list and mList)
	li	$t6, 2		# Load 2 in $t6 (size of initial mList)
	li	$s0, 0		# Load 0 in $s0 (sublist 1 index)
	li	$s1, 0		# Load 0 in $s1 (sublist 2 index)
	j	loadLists	# Jump to loadLists
loadLists:
	jal	addEList1	# Jump to addEList1
	sub	$t8, $t8, $t5	# Decrement list by the decrement value
	add	$t7, $t7, $t6	# Increment list counter by size of mList
	j	merge		# Jump to merge
addEList1:
	lw	$t4, ($t8)	# Load current element from list into $t4
	sw	$t4, ($t0)	# Store current element from list into list1
	addi	$t0, $t0, 4	# Increment list1 pointer by 4
	addi	$t8, $t8, 4	# Increment list pointer by 4
	add	$s0, $s0, 1	# Increment index for list1 by 1
	bne	$s0, $t3, addEList1	# If list1 index is not equal to size of sublists, continue to add to list values to list1
	li	$s0, 0		# Reset list1 index
	j	addEList2	# Jump to addEList2
addEList2:
	lw	$t4, ($t8)	# Load current element from list into $t4
	sw	$t4, ($t1)	# Store current element from list into list2
	addi	$t1, $t1, 4	# Increment list2 pointer by 4
	addi	$t8, $t8, 4	# Increment list pointer by 4
	add	$s1, $s1, 1	# Increment index for list2 by 1
	bne	$s1, $t3, addEList2	# If list2 index is not equal to size of sublists, continue to add to list values to list2
	li	$s1, 0		# Reset list2 index
	move	$t4, $t3	# Set $t4 to size of list
	j	loopBackSLists	# Jump to loopBackSLists
fillArr:
	li	$v0, 4		# Prepare to ourput ePrompt
	la	$a0, ePrompt	# Load ePrompt for output
	syscall			# System Call
	li	$v0, 5		# Prepare to take in integer (word) input
	syscall			# System Call
	sw	$v0, ($t8)	# Store inputted word into list
	addi	$t8, $t8, 4	# Increment list index by 4
	addi	$t4, $t4, 1	# Increment list index by 1
	blt	$t4, $s2, fillArr	# If list index is less than size, continue to fillArr
	move	$t4, $s2	# Set $t4 to list size
	j	loopBack	# Jump to loopBack in order to reset list pointer
merge:
	lw	$t4, ($t0)	# Load current element from list1 into $t4
	lw	$t9, ($t1)	# Load current element from list2 into $t9
	ble	$t4, $t9, loop1	# Checks if current element in list1 is less than or equal to current element in list2, if it is, then jump to loop1
	j	loop2		# Else, jump to loop2
    
loop1:
	sw	$t4, ($t2)	# Store current element from list1 into mList
	addi	$t0, $t0, 4	# Increment list1 pointer by 4
	addi	$t2, $t2, 4	# Increment mList pointer by 4
	addi	$s0, $s0, 1	# Increment index for list1 by 1
	bne	$s0, $t3, merge	# Checks if index for list1 is not equal to size of sublist, if it is not equal to size of sublist, then jump back to merge
	li	$s0, 0		# Reset list1 index
	bne	$s1, $t3, exit1	# Checks if index for list2 is not equal to size of sublist, if it is not equal to size of sublist, then jump to exit1
	li	$s1, 0		# Reset list2 index
	sub	$t2, $t2, $t5	# Decrement mList by decrement value
	move	$t4, $t3	# Set $t4 to size of sublist
	jal	loopBackSLists	# Jump to loopBackSLists
	j	loadNext	# Jump to loadNext
loop2:
	sw	$t9, ($t2)	# Store current element from list2 into mList
	addi	$t1, $t1, 4	# Increment list2 pointer by 4
	addi	$t2, $t2, 4	# Increment mList pointer by 4
	addi	$s1, $s1, 1	# Increment index for list2 by 1
	bne	$s1, $t3, merge	# Checks if index for list2 is not equal to size of sublist, if it is not equal to size of sublist, then jump back to merge
	li	$s1, 0		# Reset list2 index
	bne	$s0, $t3, exit2	# Checks if index for list1 is not equal to size of sublist, it it is not equal to size of sublist, then jump to exit2
	li	$s0, 0		# Reset list1 index
	sub	$t2, $t2, $t5	# Decrement mList by decrement value
	move	$t4, $t3	# Set $t4 to size of sublist
	jal	loopBackSLists	# Jump to loopBackSLists
	j	loadNext	# Jump to loadNext
exit1:
	lw	$t9, ($t1)	# Load current element from list2 into $t9
	sw	$t9, ($t2)	# Store current element from list2 into mList
	addi	$t1, $t1, 4	# Increment list2 pointer by 4
	addi	$t2, $t2, 4	# Increment mList pointer by 4
	addi	$s1, $s1, 1	# Increment index for list2 by 1
	bne	$s1, $t3, exit1	# Checks if index for list2 is not equal to 5, if it is not equal to 5, then jump back to exit1
	li	$s1, 0		# Reset list2 index
	sub	$t2, $t2, $t5	# Decrement mList by decrement value
	move	$t4, $t3	# Set $t4 to size of sublist
	jal	loopBackSLists	# Jump to loopBackSLists
	j	loadNext	# Jump to loadNext
exit2:
	lw	$t4, ($t0)	# Load current element from list1 into $t4
	sw	$t4, ($t2)	# Store current element from list1 into mList
	addi	$t0, $t0, 4	# Increment list1 pointer by 4
	addi	$t2, $t2, 4	# Increment mList pointer by 4
	addi	$s0, $s0, 1	# Increment index for list1 by 1
	bne	$s0, $t3, exit2	# Checks if index for list1 is not equal to 5, if it is not equal to 5, then jump back to exit1
	li	$s0, 0		# Reset list1 index
	sub	$t2, $t2, $t5	# Decrement mList by decrement value
	move	$t4, $t3	# Set $t4 to size of sublist
	jal	loopBackSLists	# Jump to loopBackSLists
	j	loadNext	# Jump to loadNext
loadNext:
	lw	$t4, ($t2)	# Load current element from mList into $t4
	sw	$t4, ($t8)	# Store current element from mList into list
	addi	$t8, $t8, 4	# Increment list pointer by 4
	addi	$t2, $t2, 4	# Increment mList pointer by 4
	addi	$s0, $s0, 1	# Increment counter by 1
	bne	$s0, $t6, loadNext	# If counter is not equal to size of mList, continue to loadNext element
	li	$s0, 0		# Reset list1 index
	sub	$t2, $t2, $t5	# Decrement mList pointer by decrement value
	beq	$s2, $t7, nextLevel	# If all elements in one level are sorted, jump to nextLevel
	j	loadLists	# Jump to loadLists
nextLevel:
	sll	$t5, $t5, 1	# Multiply decrement value by 2
	sll	$t3, $t3, 1	# Multiply size of sublists by 2
	sll	$t6, $t6, 1	# Multiply size of mList by 2
	move	$t4, $s2	# Set $t4 to size of list
	jal	loopBack	# Jump to loopBack
	beq	$t3, $s2, exit	# Check if size of sublists is equal to the size of list and jump to exit if so
	li	$t7, 0		# Reset list counter to 0
	li	$s0, 0		# Reset list1 index
	li	$s1, 0		# Reset list2 index
	j	loadLists	# Jump to loadLists
loopBackSLists:
	subi	$t0, $t0, 4	# Decrement list1 pointer by 4
	subi	$t1, $t1, 4	# Decrement list2 pointer by 4
	subi	$t4, $t4, 1	# Decrement counter by 1
	bnez	$t4, loopBackSLists	# If counter is not 0, continue to decrement sublist pointers
	jr	$ra		# Jump to return address
loopBack:
	subi	$t8, $t8, 4	# Decrement list pointer by 4
	subi	$t4, $t4, 1	# Decrement $t4 which at the start holds list size by 1
	bnez	$t4, loopBack	# If $t4 is not equal to zero, continue to decrement list pointer
	jr	$ra		# Jump to return address
printArr:
	lw	$t4, ($t8)	# Load current value in list into $t4
	li	$v0, 1		# Prepare to output integer (word)
	add	$a0, $zero, $t4	# Add $t4 value and $zero into output
	syscall			# System Call
	li	$v0, 4		# Prepare to output space character
	la	$a0, space	# Load space character for output
	syscall			# System call
	addi	$t8, $t8, 4	# Increment list pointer by 4
	addi	$t9, $t9, 1	# Increment $t9 counter by 1
	blt	$t9, $s2, printArr	# If $t9 counter is less than $s2, continue to print list values
	move	$t4, $s2	# Set $t4 to list size
	j	loopBack	# Jump to loopBack
exit:
	li	$v0, 4		# Prepare to output nArr
	la	$a0, nArr	# Load sizeP for output
	syscall			# System Call
	li	$t9, 0		# Load 0 into $t9
	jal	printArr	# Jump to printArr
	li	$v0, 10		# Prepare to terminate program
	syscall			# System call
