#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <pthread.h>
#include <semaphore.h>
#include <time.h>
#include <ctype.h>

sem_t patientMutex;
sem_t nurseMutex;
sem_t doctorMutex;
sem_t queueMutex;
sem_t receptionistPatientMutex;
sem_t waitOnReceptionist;
sem_t startRegisteration;
sem_t patientSeated;
sem_t patientReady[3];
sem_t doctorReady[3];
sem_t patientReceived[3];
sem_t doctorKnowsPatient[3];
sem_t patientInsideOffice[15];
sem_t appointmentDone[15];
sem_t patientEnterRoom[15];
sem_t giveAdvice[15];
int patientCount = 0;
int nurseCount = 0;
int doctorCount = 0;
int patientNumND[3];
int receptionistPatientNum;
int receptionistDoctorNum;
int nurseExit[3];
int doctorExit[3];

typedef struct counters
{
    int patients;
	int nurses;
    int doctors;
} counters;

counters counter;

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

Queue* nurseQueue[3];

void patient(void *counter)
{
	counters *c = (counters *) counter;
	// Initialize Patient ID
	int patientNum;
	// Initialize Doctor ID
	int doctorNum;
	// Assign a random doctor to the patient
	doctorNum = rand() % c->doctors;
	// Wait for patientMutex to be available
	sem_wait(&patientMutex);
	// Assign patient thread ID
	patientNum = patientCount;
	// Increment patientCount
	patientCount++;
	// Release patientMutex
	sem_post(&patientMutex);

	printf("Patient %d enters waiting room, waits for receptionist\n", patientNum);
	// Wait for receptionistPatientMutex to be available
	sem_wait(&receptionistPatientMutex);
	// Tell receptionist the Patient ID to register
	receptionistPatientNum = patientNum;
	// Tell receptionist the Doctor ID to assign
	receptionistDoctorNum = doctorNum;
	// Release startRegisteration
	sem_post(&startRegisteration);
	// Wait for receptionist to finish registering patient
	sem_wait(&waitOnReceptionist);
	printf("Patient %d leaves receptionist and sits in waiting room\n", patientNum);
	// Inform receptionist that patient is seated
	sem_post(&patientSeated);
	// Release receptionistPatientMutex
	sem_post(&receptionistPatientMutex);

	// Wait for doctor to let patient in room
	sem_wait(&patientEnterRoom[patientNum]);
	printf("Patient %d enters doctor %d's office\n", patientNum, doctorNum);
	// Inform doctor that patient is inside office
	sem_post(&patientInsideOffice[patientNum]);
	// Wait for doctor to give advice
	sem_wait(&giveAdvice[patientNum]);
	printf("Patient %d receives advice from doctor %d\n", patientNum, doctorNum);
	// Wait for doctor to finish appointment
	sem_wait(&appointmentDone[patientNum]);
	printf("Patient %d leaves\n", patientNum);
}

void receptionist(void *counter)
{
	counters *c = (counters *) counter;
	int i = 0;
	int nurseNum;
	while(i < c->patients)
	{
		i++;
		// Wait for startRegisteration to be available
		sem_wait(&startRegisteration);
		printf("Receptionist registers patient %d\n", receptionistPatientNum);
		nurseNum = receptionistDoctorNum;
		// Wait for queueMutex to be available
		sem_wait(&queueMutex);
		// Add patient to nurse queue
		enqueue(nurseQueue[nurseNum], receptionistPatientNum);
		// Release queueMutex
		sem_post(&queueMutex);
		// Send patient back to waiting room
		sem_post(&waitOnReceptionist);
		// Wait for patient to be seated
		sem_wait(&patientSeated);
		// Inform nurse that patient is ready
		sem_post(&patientReady[nurseNum]);
	}
	// Inform all nurses that no more patients are coming
	for(i = 0; i < c->nurses; i++)
	{
		nurseExit[i] = 1;
		sem_post(&patientReady[i]);
	}
}

void nurse()
{
	int nurseNum;
	sem_wait(&nurseMutex);
	nurseNum = nurseCount;
	nurseCount++;
	sem_post(&nurseMutex);
	while(!nurseExit[nurseNum] || !isEmpty(nurseQueue[nurseNum]))
	{
		// Wait for doctor to be ready
		sem_wait(&doctorReady[nurseNum]);
		// Wait for Receptionist to inform that patient is ready
		sem_wait(&patientReady[nurseNum]);
		if(nurseExit[nurseNum] == 1 && isEmpty(nurseQueue[nurseNum]))
		{
			break;
		}
		// Wait for queueMutex to be available
		sem_wait(&queueMutex);
		// Assign patient to nurse
		patientNumND[nurseNum] = dequeue(nurseQueue[nurseNum]);
		// Release queueMutex
		sem_post(&queueMutex);
		
		printf("Nurse %d takes patient %d to doctor's office\n", nurseNum, patientNumND[nurseNum]);
		sem_post(&patientReceived[nurseNum]);

		// Wait for doctor to receive patient ID
		sem_wait(&doctorKnowsPatient[nurseNum]);
	}
	// Inform doctor that no more patients are coming
	doctorExit[nurseNum] = 1;
	sem_post(&patientReceived[nurseNum]);
}

void doctor()
{
	int doctorNum;
	int patientNum;
	sem_wait(&doctorMutex);
	doctorNum = doctorCount;
	doctorCount++;
	sem_post(&doctorMutex);
	while(!doctorExit[doctorNum])
	{
		// Inform nurse that doctor is ready
		sem_post(&doctorReady[doctorNum]);
		// Wait for patient to be received
		sem_wait(&patientReceived[doctorNum]);
		if(doctorExit[doctorNum] == 1)
		{
			break;
		}
		// Receive patient ID
		patientNum = patientNumND[doctorNum];
		// Inform nurse that patient ID is received
		sem_post(&doctorKnowsPatient[doctorNum]);

		// Inform patient to enter room
		sem_post(&patientEnterRoom[patientNumND[doctorNum]]);
		// Wait for patient to be inside room
		sem_wait(&patientInsideOffice[patientNum]);

		printf("Doctor %d listens to symptoms from patient %d\n", doctorNum, patientNum);
		// Inform patient that advice is given
		sem_post(&giveAdvice[patientNumND[doctorNum]]);
		// Wait for patient to leave
		sem_post(&appointmentDone[patientNumND[doctorNum]]);
	}
}

int main(int argc, char *argv[])
{
	if(argc != 3)
	{
		printf("Incorrect Number of Command Line Arguments\n");
		exit(EXIT_FAILURE);
	}
	counter.doctors = atoi(argv[1]);
	counter.nurses = atoi(argv[1]);
	counter.patients = atoi(argv[2]);

	// Create Nurse queues
	int i;
	for(i = 0; i < counter.nurses; i++)
	{
		nurseQueue[i] = createQueue();
	}
	for(i = 0; i < counter.nurses; i++)
	{
		nurseExit[i] = 0;
	}
	for(i = 0; i < counter.doctors; i++)
	{
		doctorExit[i] = 0;
	}

	// Initialize semaphores
	sem_init(&patientMutex, 0, 1);
	sem_init(&nurseMutex, 0, 1);
	sem_init(&doctorMutex, 0, 1);
	sem_init(&queueMutex, 0, 1);
	sem_init(&receptionistPatientMutex, 0, 1);
	sem_init(&waitOnReceptionist, 0, 0);
	sem_init(&startRegisteration, 0, 0);
	sem_init(&patientSeated, 0, 0);
	for(i = 0; i < counter.nurses; i++)
	{
		sem_init(&patientReady[i], 0, 0);
	}
	for(i = 0; i < counter.nurses; i++)
	{
		sem_init(&doctorReady[i], 0, 0);
	}
	for(i = 0; i < counter.nurses; i++)
	{
		sem_init(&patientReceived[i], 0, 0);
	}
	for(i = 0; i < counter.nurses; i++)
	{
		sem_init(&doctorKnowsPatient[i], 0, 0);
	}
	for(i = 0; i < counter.patients; i++)
	{
		sem_init(&patientInsideOffice[i], 0, 0);
	}
	for(i = 0; i < counter.patients; i++)
	{
		sem_init(&appointmentDone[i], 0, 0);
	}
	for(i = 0; i < counter.patients; i++)
	{
		sem_init(&patientEnterRoom[i], 0, 0);
	}
	for(i = 0; i < counter.patients; i++)
	{
		sem_init(&giveAdvice[i], 0, 0);
	}

	// Create threads
	pthread_t p[counter.patients];
	pthread_t n[counter.nurses];
	pthread_t d[counter.doctors];
	pthread_t r;
	pthread_create(&r, NULL, &receptionist, (void *) &counter);
	for(i = 0; i < counter.patients; i++)
	{
		pthread_create(&p[i], NULL, &patient, (void *) &counter);
	}
	for(i = 0; i < counter.nurses; i++)
	{
		pthread_create(&n[i], NULL, &nurse, NULL);
	}
	for(i = 0; i < counter.doctors; i++)
	{
		pthread_create(&d[i], NULL, &doctor, NULL);
	}

	// Join threads
	pthread_join(r, NULL);
	for(i = 0; i < counter.patients; i++)
	{
		pthread_join(p[i], NULL);
	}
	for(i = 0; i < counter.nurses; i++)
	{
		pthread_join(n[i], NULL);
	}
	for(i = 0; i < counter.doctors; i++)
	{
		pthread_join(d[i], NULL);
	}

	// Destroy semaphores
	sem_destroy(&patientMutex);
	sem_destroy(&nurseMutex);
	sem_destroy(&doctorMutex);
	sem_destroy(&queueMutex);
	sem_destroy(&receptionistPatientMutex);
	sem_destroy(&waitOnReceptionist);
	sem_destroy(&startRegisteration);
	sem_destroy(&patientSeated);
	for(i = 0; i < counter.nurses; i++)
	{
		sem_destroy(&patientReady[i]);
	}
	for(i = 0; i < counter.nurses; i++)
	{
		sem_destroy(&doctorReady[i]);
	}
	for(i = 0; i < counter.nurses; i++)
	{
		sem_destroy(&patientReceived[i]);
	}
	for(i = 0; i < counter.nurses; i++)
	{
		sem_destroy(&doctorKnowsPatient[i]);
	}
	for(i = 0; i < counter.patients; i++)
	{
		sem_destroy(&patientInsideOffice[i]);
	}
	for(i = 0; i < counter.patients; i++)
	{
		sem_destroy(&appointmentDone[i]);
	}
	for(i = 0; i < counter.patients; i++)
	{
		sem_destroy(&patientEnterRoom[i]);
	}
	for(i = 0; i < counter.patients; i++)
	{
		sem_destroy(&giveAdvice[i]);
	}

	printf("Simulation complete\n");

	return 0;
}