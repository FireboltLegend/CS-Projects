-- Create Database
CREATE DATABASE StudentRecordSystemNormalized;
GO
USE StudentRecordSystemNormalized;
GO

-- Create Student Table
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    Fname VARCHAR(20),
    Lname VARCHAR(20),
    Username VARCHAR(20),
    Password VARCHAR(20)
);

-- Create Event Table
CREATE TABLE Event (
    EventID INT PRIMARY KEY,
    Date DATETIME,
    EventName VARCHAR(45),
    RSVPComplete BIT,
    Description VARCHAR(45)
);

-- Create EventType Table
CREATE TABLE EventType (
	EventTypeID INT PRIMARY KEY,
	Type VARCHAR(20),
	EventID INT NOT NULL FOREIGN KEY REFERENCES dbo.Event(EventID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create EventsAttended Table
CREATE TABLE EventsAttended
(
	StudentID INT NOT NULL FOREIGN KEY REFERENCES dbo.Student(StudentID) ON UPDATE CASCADE ON DELETE CASCADE,
	EventID INT NOT NULL FOREIGN KEY REFERENCES dbo.Event(EventID) ON UPDATE CASCADE ON DELETE CASCADE,
	PRIMARY KEY(StudentID, EventID)
);

-- Create Professor Table
CREATE TABLE Professor (
    ProfessorID INT PRIMARY KEY,
    Fname VARCHAR(20),
    Lname VARCHAR(20),
    Email VARCHAR(45),
    Office VARCHAR(45),
    OfficeHours DATETIME
);

-- Create Course Table
CREATE TABLE Course (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(45),
	ProfessorID INT FOREIGN KEY REFERENCES dbo.Professor(ProfessorID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create Schedule Table
CREATE TABLE Schedule(
	CourseID INT,
	ClassroomNo VARCHAR(10),
    Day VARCHAR(10),
    StartTime TIME,
    EndTime TIME,
	PRIMARY KEY (CourseID),
	FOREIGN KEY (CourseID) REFERENCES Course(CourseID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create TA Table
CREATE TABLE TA (
    TAID INT PRIMARY KEY,
    Fname VARCHAR(20),
    Lname VARCHAR(20),
    Email VARCHAR(45),
    Office VARCHAR(45),
    OfficeHours DATETIME
);

-- Create TAAssists Table
CREATE TABLE TAAssists (
	TAID INT,
	CourseID INT,
	PRIMARY KEY (TAID, CourseID),
	FOREIGN KEY (TAID) REFERENCES TA(TAID) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (CourseID) REFERENCES Course(CourseID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create Assignment Table
CREATE TABLE Assignment (
    AssignmentID INT PRIMARY KEY,
	CourseID INT FOREIGN KEY REFERENCES dbo.Course(CourseID) ON UPDATE CASCADE ON DELETE CASCADE,
    DueDate DATETIME,
    Description VARCHAR(45),
    AssignmentType VARCHAR(20) -- 'Exam', 'Homework', 'Quiz'
);

-- Create Exam Table (Subclass)
CREATE TABLE Exam
(
	ExamID INT PRIMARY KEY,
	AssignmentID INT NOT NULL FOREIGN KEY REFERENCES dbo.Assignment(AssignmentID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create Grade Table (Subclass)
CREATE TABLE Quiz
(
	QuizID INT PRIMARY KEY,
	AssignmentID INT NOT NULL FOREIGN KEY REFERENCES dbo.Assignment(AssignmentID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create Homework Table (Subclass)
CREATE TABLE Homework
(
	HomeworkID INT PRIMARY KEY,
	AssignmentID INT NOT NULL FOREIGN KEY REFERENCES dbo.Assignment(AssignmentID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create Enrollment Table
CREATE TABLE Enrollment
(
	StudentID INT NOT NULL FOREIGN KEY REFERENCES dbo.Student(StudentID) ON UPDATE CASCADE ON DELETE CASCADE,
	CourseID INT NOT NULL FOREIGN KEY REFERENCES dbo.Course(CourseID) ON UPDATE CASCADE ON DELETE CASCADE,
	PRIMARY KEY(StudentID, CourseID)
);

-- Create Finances Table
CREATE TABLE Finances (
    FinancesID INT PRIMARY KEY,
    StudentID INT,
    Amount DECIMAL(10, 2),
    FinancesType VARCHAR(45),
    PaymentDeadline DATETIME,
    Status BIT,
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create Dining Table
CREATE TABLE Dining (
    DiningID INT PRIMARY KEY,
    StudentID INT,
    MealPlanBalance DECIMAL(10, 2),
    SwipesPerWeek INT,
    MealPlanType VARCHAR(45),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create Housing Table
CREATE TABLE Housing (
    HousingID INT PRIMARY KEY,
    StudentID INT,
    BuildingNo VARCHAR(45),
    RoomNo VARCHAR(45),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Create RoommateAgreement Table (Weak entity of Housing)
CREATE TABLE RoommateAgreement (
    HousingID INT,
    DateSigned DATE,
    AgreementComplete BIT,
	PRIMARY KEY (HousingID),
    FOREIGN KEY (HousingID) REFERENCES Housing(HousingID) ON UPDATE CASCADE ON DELETE CASCADE
);

-- Insert into Student
INSERT INTO Student (StudentID, Fname, Lname, Username, Password) VALUES
(1, 'Alice', 'Johnson', 'alicej', 'password1'),
(2, 'Bob', 'Smith', 'bobsmith', 'password2'),
(3, 'Charlie', 'Brown', 'charlieb', 'password3'),
(4, 'Diana', 'Prince', 'dianap', 'password4'),
(5, 'Evan', 'Williams', 'evanw', 'password5'),
(6, 'Fiona', 'White', 'fionaw', 'password6'),
(7, 'George', 'Miller', 'georgem', 'password7'),
(8, 'Hannah', 'Lee', 'hannahlee', 'password8'),
(9, 'Ivy', 'Green', 'ivyg', 'password9'),
(10, 'Jake', 'Long', 'jakelong', 'password10');

-- Insert into Event
INSERT INTO Event (EventID, Date, EventName, RSVPComplete, Description) VALUES
(1, '2024-12-01 18:00:00', 'End of Semester Party', 1, 'Celebrate the end of semester'),
(2, '2024-11-20 15:00:00', 'Career Fair', 0, 'Meet potential employers'),
(3, '2024-10-15 12:00:00', 'Alumni Networking', 1, 'Networking with alumni'),
(4, '2024-09-10 09:00:00', 'Orientation', 1, 'New student orientation'),
(5, '2024-08-25 11:00:00', 'Welcome Back BBQ', 0, 'Kickoff the semester'),
(6, '2024-12-05 17:00:00', 'Holiday Gala', 0, 'End-of-year celebration'),
(7, '2024-10-20 10:00:00', 'Leadership Workshop', 1, 'Develop leadership skills'),
(8, '2024-11-01 14:00:00', 'Tech Expo', 1, 'Explore new technologies'),
(9, '2024-12-15 13:00:00', 'Winter Wonderland', 0, 'Winter-themed event'),
(10, '2024-11-25 09:30:00', 'Community Service Day', 1, 'Day of giving back');

-- Insert into EventType
INSERT INTO EventType (EventTypeID, Type, EventID) VALUES
(1, 'Party', 1),
(2, 'Career', 2),
(3, 'Networking', 3),
(4, 'Orientation', 4),
(5, 'Social', 5),
(6, 'Gala', 6),
(7, 'Workshop', 7),
(8, 'Tech', 8),
(9, 'Seasonal', 9),
(10, 'Community', 10);

-- Insert into EventsAttended
INSERT INTO EventsAttended (StudentID, EventID) VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), 
(6, 6), (7, 7), (8, 8), (9, 9), (10, 10);

-- Insert into Professor
INSERT INTO Professor (ProfessorID, Fname, Lname, Email, Office, OfficeHours) VALUES
(1, 'John', 'Doe', 'jdoe@university.edu', 'Bldg 1 Rm 101', '2024-12-05 10:00:00'),
(2, 'Emily', 'Smith', 'esmith@university.edu', 'Bldg 1 Rm 102', '2024-12-05 11:00:00'),
(3, 'Mark', 'Brown', 'mbrown@university.edu', 'Bldg 1 Rm 103', '2024-12-05 12:00:00'),
(4, 'Sarah', 'Johnson', 'sjohnson@university.edu', 'Bldg 2 Rm 201', '2024-12-05 09:00:00'),
(5, 'Robert', 'Davis', 'rdavis@university.edu', 'Bldg 2 Rm 202', '2024-12-05 13:00:00'),
(6, 'Linda', 'Clark', 'lclark@university.edu', 'Bldg 3 Rm 301', '2024-12-05 14:00:00'),
(7, 'James', 'Lewis', 'jlewis@university.edu', 'Bldg 3 Rm 302', '2024-12-05 15:00:00'),
(8, 'Patricia', 'Walker', 'pwalker@university.edu', 'Bldg 4 Rm 401', '2024-12-05 08:00:00'),
(9, 'Michael', 'Hall', 'mhall@university.edu', 'Bldg 4 Rm 402', '2024-12-05 16:00:00'),
(10, 'Barbara', 'Young', 'byoung@university.edu', 'Bldg 5 Rm 501', '2024-12-05 17:00:00');

-- Insert into Course
INSERT INTO Course (CourseID, CourseName, ProfessorID) VALUES
(1, 'Intro to Computer Science', 1),
(2, 'Calculus I', 2),
(3, 'Physics I', 3),
(4, 'Chemistry I', 4),
(5, 'Biology I', 5),
(6, 'Psychology', 6),
(7, 'Sociology', 7),
(8, 'Art History', 8),
(9, 'World Literature', 9),
(10, 'Political Science', 10);

-- Insert into Schedule
INSERT INTO Schedule (CourseID, ClassroomNo, Day, StartTime, EndTime) VALUES
(1, 'Rm 101', 'Monday', '09:00:00', '10:30:00'),
(2, 'Rm 102', 'Tuesday', '11:00:00', '12:30:00'),
(3, 'Rm 103', 'Wednesday', '13:00:00', '14:30:00'),
(4, 'Rm 201', 'Thursday', '15:00:00', '16:30:00'),
(5, 'Rm 202', 'Friday', '08:00:00', '09:30:00'),
(6, 'Rm 301', 'Monday', '10:00:00', '11:30:00'),
(7, 'Rm 302', 'Tuesday', '12:00:00', '13:30:00'),
(8, 'Rm 401', 'Wednesday', '14:00:00', '15:30:00'),
(9, 'Rm 402', 'Thursday', '16:00:00', '17:30:00'),
(10, 'Rm 501', 'Friday', '09:00:00', '10:30:00');

-- Insert into TA
INSERT INTO TA (TAID, Fname, Lname, Email, Office, OfficeHours) VALUES
(1, 'Kevin', 'Brown', 'kbrown@university.edu', 'TA Office 1', '2024-12-06 10:00:00'),
(2, 'Laura', 'Wilson', 'lwilson@university.edu', 'TA Office 2', '2024-12-06 11:00:00'),
(3, 'Tom', 'Jones', 'tjones@university.edu', 'TA Office 3', '2024-12-06 12:00:00'),
(4, 'Sara', 'Garcia', 'sgarcia@university.edu', 'TA Office 4', '2024-12-06 13:00:00'),
(5, 'Chris', 'Martinez', 'cmartinez@university.edu', 'TA Office 5', '2024-12-06 14:00:00'),
(6, 'Anna', 'Rodriguez', 'arodriguez@university.edu', 'TA Office 6', '2024-12-06 15:00:00'),
(7, 'Mia', 'Lopez', 'mlopez@university.edu', 'TA Office 7', '2024-12-06 16:00:00'),
(8, 'John', 'Davis', 'jdavis@university.edu', 'TA Office 8', '2024-12-06 17:00:00'),
(9, 'Eva', 'White', 'ewhite@university.edu', 'TA Office 9', '2024-12-06 18:00:00'),
(10, 'Nick', 'Anderson', 'nanderson@university.edu', 'TA Office 10', '2024-12-06 19:00:00');

-- Insert into TAAssists
INSERT INTO TAAssists (TAID, CourseID) VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5),
(6, 6), (7, 7), (8, 8), (9, 9), (10, 10);

-- Insert into Assignment
INSERT INTO Assignment (AssignmentID, CourseID, DueDate, Description, AssignmentType) VALUES
(1, 1, '2024-11-15 23:59:00', 'Midterm Exam', 'Exam'),
(2, 2, '2024-12-01 23:59:00', 'Final Exam', 'Exam'),
(3, 3, '2024-11-20 23:59:00', 'Homework 1', 'Homework'),
(4, 4, '2024-11-25 23:59:00', 'Quiz 1', 'Quiz'),
(5, 5, '2024-11-30 23:59:00', 'Homework 2', 'Homework'),
(6, 6, '2024-12-05 23:59:00', 'Final Exam', 'Exam'),
(7, 7, '2024-12-10 23:59:00', 'Project Presentation', 'Exam'),
(8, 8, '2024-12-15 23:59:00', 'Quiz 2', 'Quiz'),
(9, 9, '2024-12-20 23:59:00', 'Homework 3', 'Homework'),
(10, 10, '2024-12-25 23:59:00', 'Final Paper', 'Exam');

-- Insert into Exam
INSERT INTO Exam (ExamID, AssignmentID) VALUES
(1, 1), (2, 2), (3, 6), (4, 7), (5, 10);

-- Insert into Quiz
INSERT INTO Quiz (QuizID, AssignmentID) VALUES
(1, 4), (2, 8);

-- Insert into Homework
INSERT INTO Homework (HomeworkID, AssignmentID) VALUES
(1, 3), (2, 5), (3, 9);

-- Insert into Enrollment
INSERT INTO Enrollment (StudentID, CourseID) VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5),
(6, 6), (7, 7), (8, 8), (9, 9), (10, 10);

-- Insert into Finances
INSERT INTO Finances (FinancesID, StudentID, Amount, FinancesType, PaymentDeadline, Status) VALUES
(1, 1, 5000.00, 'Tuition', '2024-12-10', 1),
(2, 2, 2500.00, 'Dorm', '2024-11-30', 0),
(3, 3, 200.00, 'Meal Plan', '2024-12-15', 1),
(4, 4, 1500.00, 'Tuition', '2024-12-10', 1),
(5, 5, 1000.00, 'Library Fee', '2024-11-25', 0),
(6, 6, 300.00, 'Meal Plan', '2024-12-05', 1),
(7, 7, 150.00, 'Club Dues', '2024-12-20', 1),
(8, 8, 75.00, 'Lab Fee', '2024-11-28', 0),
(9, 9, 500.00, 'Parking', '2024-12-01', 1),
(10, 10, 800.00, 'Gym Membership', '2024-12-18', 0);

-- Insert into Dining
INSERT INTO Dining (DiningID, StudentID, MealPlanBalance, SwipesPerWeek, MealPlanType) VALUES
(1, 1, 1200.00, 14, 'Unlimited'),
(2, 2, 800.00, 10, 'Standard'),
(3, 3, 1500.00, 21, 'Premium'),
(4, 4, 1000.00, 14, 'Unlimited'),
(5, 5, 500.00, 7, 'Basic'),
(6, 6, 750.00, 10, 'Standard'),
(7, 7, 1300.00, 21, 'Premium'),
(8, 8, 600.00, 10, 'Standard'),
(9, 9, 900.00, 14, 'Unlimited'),
(10, 10, 400.00, 7, 'Basic');

-- Insert into Housing
INSERT INTO Housing (HousingID, StudentID, BuildingNo, RoomNo) VALUES
(1, 1, 'Bldg 1', 'Rm 101'),
(2, 2, 'Bldg 1', 'Rm 102'),
(3, 3, 'Bldg 2', 'Rm 201'),
(4, 4, 'Bldg 2', 'Rm 202'),
(5, 5, 'Bldg 3', 'Rm 301'),
(6, 6, 'Bldg 3', 'Rm 302'),
(7, 7, 'Bldg 4', 'Rm 401'),
(8, 8, 'Bldg 4', 'Rm 402'),
(9, 9, 'Bldg 5', 'Rm 501'),
(10, 10, 'Bldg 5', 'Rm 502');

-- Insert into RoommateAgreement
INSERT INTO RoommateAgreement (HousingID, DateSigned, AgreementComplete) VALUES
(1, '2024-09-01', 1),
(2, '2024-09-02', 1),
(3, '2024-09-03', 1),
(4, '2024-09-04', 1),
(5, '2024-09-05', 0),
(6, '2024-09-06', 1),
(7, '2024-09-07', 0),
(8, '2024-09-08', 1),
(9, '2024-09-09', 0),
(10, '2024-09-10', 1);

-- Select all from each table
SELECT * FROM Student;
SELECT * FROM Event;
SELECT * FROM EventType;
SELECT * FROM EventsAttended;
SELECT * FROM Professor;
SELECT * FROM Course;
SELECT * FROM Schedule;
SELECT * FROM TA;
SELECT * FROM TAAssists;
SELECT * FROM Assignment;
SELECT * FROM Exam;
SELECT * FROM Quiz;
SELECT * FROM Homework;
SELECT * FROM Enrollment;
SELECT * FROM Finances;
SELECT * FROM Dining;
SELECT * FROM Housing;
SELECT * FROM RoommateAgreement;
