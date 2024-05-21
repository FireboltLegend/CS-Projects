#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Structure to represent a job
typedef struct Job
{
	char jobName;
	int startTime;
	int duration;
	int remainingTime;
} Job;

// Structure to represent a queue node
typedef struct QueueNode
{
	int data;
	struct QueueNode* next;
} QueueNode;

// Structure to represent a queue
typedef struct Queue
{
	QueueNode *front, *rear;
} Queue;

// Function to create a new queue node
QueueNode* createQueueNode(int data)
{
	QueueNode* newNode = (QueueNode*)malloc(sizeof(QueueNode));
	if (!newNode)
	{
		printf("Memory allocation error\n");
		exit(EXIT_FAILURE);
	}
	newNode->data = data;
	newNode->next = NULL;
	return newNode;
}

// Function to create an empty queue
Queue* createQueue()
{
	Queue* queue = (Queue*)malloc(sizeof(Queue));
	if (!queue)
	{
		printf("Memory allocation error\n");
		exit(EXIT_FAILURE);
	}
	queue->front = queue->rear = NULL;
	return queue;
}

// Function to check if the queue is empty
int isEmpty(Queue* queue)
{
	return (queue->front == NULL);
}

// Function to enqueue an element into the queue
void enqueue(Queue* queue, int data)
{
	QueueNode* newNode = createQueueNode(data);
	if (isEmpty(queue))
	{
		queue->front = queue->rear = newNode;
	}
	else
	{
		queue->rear->next = newNode;
		queue->rear = newNode;
	}
}

// Function to dequeue an element from the queue
int dequeue(Queue* queue)
{
	if (isEmpty(queue))
	{
		printf("Queue is empty\n");
		exit(EXIT_FAILURE);
	}
	QueueNode* temp = queue->front;
	int data = temp->data;
	queue->front = queue->front->next;
	free(temp);
	return data;
}

// Queue for Round-Robin (RR) Scheduling
Queue* rr;
// Array of jobs
Job jobs[26];

int main(int argc, char *argv[])
{
	// Open the file
	FILE *file = fopen(argv[1], "r");
	if (file == NULL)
	{
		printf("Error: Cannot open file\n");
		return 1;
	}

	// Read the file
	char line[100];
	int count = 0;
	char* token;
	while (fgets(line, sizeof(line), file))
	{
		// Tokenize the line
		token = strtok(line, "\t");
		// Store the job name
		jobs[count].jobName = token[0];
		token = strtok(NULL, "\t");
		// Store the job start time
		jobs[count].startTime = atoi(token);
		token = strtok(NULL, "\t");
		// Store the job duration
		jobs[count].duration = atoi(token);
		// Initialize the remaining time
		jobs[count].remainingTime = jobs[count].duration;
		count++;
	}

	// Close the file
	fclose(file);

	// First-Come, First-Served (FCFS) Scheduling
	printf("FCFS\n\n");

	// Initialize iterator variables
	int i;
	int j;
	int k;

	// Print the job names
	for(i = 0; i < count; i++)
	{
		printf("%c ", jobs[i].jobName);
	}
	printf("\n");

	// Print the schedule
	int time = 0;
	for(i = 0; i < count; i++)
	{
		for(j = 0; j < jobs[i].duration; j++)
		{
			while(jobs[i].startTime > time)
			{
				printf("\n");
				time++;
			}
			for(k = 0; k < i; k++)
			{
				printf("  ");
			}
			printf("X");
			printf("\n");
			time++;
		}
	}

	// Round-Robin (RR) Scheduling
	printf("\nRR\n\n");

	// Print the job names
	for(i = 0; i < count; i++)
	{
		printf("%c ", jobs[i].jobName);
	}
	printf("\n");

	// Print the schedule
	rr = createQueue();
	time = 0;
	int tracker = 0;
	int jobIndex;
	enqueue(rr, tracker);
	tracker++;
	int decrement = count;

	// Implement the Round-Robin (RR) Scheduling algorithm
	while(!isEmpty(rr) || decrement > 0)
	{
		// Check if the there is a job to be scheduled
		if(isEmpty(rr))
		{
			// There is no job to be scheduled yet
			time++;
			printf("\n");
			// Check if there is a job to be enqueued
			if(jobs[tracker].startTime <= time && tracker < count)
			{
				enqueue(rr, tracker);
				tracker++;
			}
			continue;
		}
		// Schedule the job
		jobIndex = dequeue(rr);
		// Print the spaces
		for(j = 0; j < jobIndex; j++)
		{
			printf("  ");
		}
		// Print the X and the new line
		printf("X ");
		printf("\n");
		// Update the time and the remaining time of the job
		time++;
		jobs[jobIndex].remainingTime--;
		// Check if there is a job to be enqueued
		if(jobs[tracker].startTime <= time && tracker < count)
		{
			enqueue(rr, tracker);
			tracker++;
		}
		// Check if the job is done
		if(jobs[jobIndex].remainingTime == 0)
		{
			decrement--;
			continue;
		}
		// Enqueue the job since it is not done yet
		enqueue(rr, jobIndex);
	}

	return 0;
}