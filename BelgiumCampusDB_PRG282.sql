USE master;
CREATE DATABASE BelgiumCampusDB_PRG282;
GO

USE BelgiumCampusDB_PRG282;
CREATE TABLE Students
	(StudentID INT IDENTITY(101,1) PRIMARY KEY,
	FirstName NVARCHAR(30) NOT NULL,
	Surname NVARCHAR(30) NOT NULL,
	DOB DATE NOT NULL,
	Gender NVARCHAR(1) NOT NULL,
	Phone NVARCHAR(20) NOT NULL,
	StudentImage IMAGE
	);
GO


INSERT INTO Students(FirstName,Surname,DOB,Gender,Phone)
VALUES('Morgan','Pearson','2001-09-03','M','082-023-5559');
INSERT INTO Students(FirstName, Surname, DOB, Gender, Phone)
VALUES('Ella', 'Johnson', '1999-07-15', 'F', '076-321-9876');
INSERT INTO Students(FirstName, Surname, DOB, Gender, Phone)
VALUES('Sam', 'Nguyen', '2003-04-28', 'M', '064-555-1234');
INSERT INTO Students(FirstName, Surname, DOB, Gender, Phone)
VALUES('Sophia', 'Van Der Merwe', '2000-11-20', 'F', '083-456-7890');
GO

CREATE TABLE StudentAddress (
    AddressID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    Street NVARCHAR(100),
    City NVARCHAR(50),
    Province NVARCHAR(50),
    Country NVARCHAR(50),
    PostalCode NVARCHAR(20),
    CONSTRAINT FK_StudentAddress_StudentID FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);
GO
INSERT INTO StudentAddress (StudentID, Street, City, Province, Country, PostalCode)
VALUES (101, '725 Morgan Rd', 'Pretoria', 'KwaZulu-Natal', 'South Africa', '3865');
INSERT INTO StudentAddress (StudentID, Street, City, Province, Country, PostalCode)
VALUES (102, '789 Willow St', 'Cape Town', 'Western Cape', 'South Africa', '7100');
INSERT INTO StudentAddress (StudentID, Street, City, Province, Country, PostalCode)
VALUES (103, '12 Jasmine Ave', 'Durban', 'KwaZulu-Natal', 'South Africa', '4001');
INSERT INTO StudentAddress (StudentID, Street, City, Province, Country, PostalCode)
VALUES (104, '555 Garden Rd', 'Johannesburg', 'Gauteng', 'South Africa', '2000');


CREATE TABLE Course
	(
	CourseCode INT PRIMARY KEY,
	StudentID INT NOT NULL FOREIGN KEY REFERENCES Students(StudentID)
	);
GO


ALTER TABLE Course 
ADD CONSTRAINT FK_Student_Course FOREIGN KEY (StudentID) REFERENCES Students(StudentID);
INSERT INTO Course(CourseCode, StudentID) VALUES (1001, 101);
INSERT INTO Course(CourseCode, StudentID) VALUES (1002, 102);
INSERT INTO Course(CourseCode, StudentID) VALUES (1003, 103);
INSERT INTO Course(CourseCode, StudentID) VALUES (1004, 104);
GO

CREATE TABLE Modules
	(
	CourseCode INT PRIMARY KEY,
	ModuleName NVARCHAR(50),
	ModuleDescription NTEXT
	);
GO

ALTER TABLE Modules
ADD CONSTRAINT FK_Course_Modules FOREIGN KEY (CourseCode) REFERENCES Course(CourseCode);
INSERT INTO Modules(CourseCode, ModuleName, ModuleDescription) VALUES (1001, 'Mathematics 101', 'Basic math concepts and operations');
INSERT INTO Modules(CourseCode, ModuleName, ModuleDescription) VALUES (1002, 'Science Fundamentals', 'Introduction to fundamental scientific principles');
INSERT INTO Modules(CourseCode, ModuleName, ModuleDescription) VALUES (1003, 'Literature Studies', 'Exploring classical and contemporary literature');
INSERT INTO Modules(CourseCode, ModuleName, ModuleDescription) VALUES (1004, 'Programming Basics', 'Introduction to programming logic and concepts');

