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
GO


/*Stored proc*/
USE BelgiumCampusDB_PRG282;
GO
/*Display Student*/
CREATE PROCEDURE spGetStudents
AS
BEGIN
    SELECT 
        S.StudentID,
        S.FirstName,
        S.Surname,
        S.DOB,
        S.Gender,
        S.Phone,
        SA.Street,
        SA.City,
        SA.Province,
        SA.Country,
        SA.PostalCode,
        M.ModuleName,
        M.ModuleDescription
    FROM 
        Students AS S
    JOIN 
        StudentAddress AS SA ON S.StudentID = SA.StudentID
    JOIN 
        Course AS C ON S.StudentID = C.StudentID
    JOIN 
        Modules AS M ON C.CourseCode = M.CourseCode;
END
GO

/*Delete Student*/
CREATE PROCEDURE spDeleteStudent
    @stdID INT
AS
BEGIN
    DELETE FROM Course WHERE StudentID = @stdID;
    DELETE FROM StudentAddress WHERE StudentID = @stdID;
    DELETE FROM Students WHERE StudentID = @stdID;
END
GO
/*Delete module*/
CREATE PROCEDURE spDeleteModule
    @CourseCode INT
AS
BEGIN
    DELETE FROM Modules WHERE CourseCode = @CourseCode;
END
GO

/*Get Student image*/
CREATE PROCEDURE spGetStudentImage
    @stdID INT
AS
BEGIN
    SELECT StudentImage
    FROM Students
    WHERE StudentID = @stdID;
END
GO

/*Add student*/
CREATE PROCEDURE spAddStudent
    @stdID INT,
    @name NVARCHAR(30),
    @surname NVARCHAR(30),
    @dob DATE,
    @gender NVARCHAR(1),
    @phone NVARCHAR(20),
    @stdImg IMAGE -- Assuming StudentImage is of type IMAGE
AS
BEGIN
    INSERT INTO Students (StudentID, FirstName, Surname, DOB, Gender, Phone, StudentImage)
    VALUES (@stdID, @name, @surname, @dob, @gender, @phone, @stdImg);
END
GO

/*Add student address*/
CREATE PROCEDURE spAddStudentAddress
    @stdID INT,
    @street NVARCHAR(100),
    @city NVARCHAR(50),
    @prov NVARCHAR(50),
    @country NVARCHAR(50),
    @postalCode NVARCHAR(20)
AS
BEGIN
    INSERT INTO StudentAddress (StudentID, Street, City, Province, Country, PostalCode)
    VALUES (@stdID, @street, @city, @prov, @country, @postalCode);
END
GO

/*Add student course*/
CREATE PROCEDURE spAddCourse
    @courseCode INT,
    @stdID INT
AS
BEGIN
    INSERT INTO Course (CourseCode, StudentID)
    VALUES (@courseCode, @stdID);
END
GO

/*Add new module*/
CREATE PROCEDURE spAddModule
    @courseCode INT,
    @moduleName NVARCHAR(50),
    @moduleDesc NTEXT
AS
BEGIN
    INSERT INTO Modules (CourseCode, ModuleName, ModuleDescription)
    VALUES (@courseCode, @moduleName, @moduleDesc);
END
GO

/*Update module*/
CREATE PROCEDURE spUpdateModulesData
    @moduleID INT,
    @newModuleName NVARCHAR(50),
    @newModuleDescription NTEXT
AS
BEGIN
    UPDATE Modules
    SET ModuleName = @newModuleName, ModuleDescription = @newModuleDescription
    WHERE CourseCode = @moduleID;
END
GO

/* Update Student*/
CREATE PROCEDURE spUpdateStudentsData
    @stdID INT,
    @newFirstName NVARCHAR(30),
    @newSurname NVARCHAR(30),
    @newDOB DATE,
    @newGender NVARCHAR(1),
    @newPhone NVARCHAR(20)
AS
BEGIN
    UPDATE Students
    SET FirstName = @newFirstName, Surname = @newSurname, DOB = @newDOB, Gender = @newGender, Phone = @newPhone
    WHERE StudentID = @stdID;
END
GO

/*Update StudentAddress*/
CREATE PROCEDURE spUpdateStudentAddress
    @stdID INT,
    @newStreet NVARCHAR(100),
    @newCity NVARCHAR(50),
    @newProvince NVARCHAR(50),
    @newCountry NVARCHAR(50),
    @newPostalCode NVARCHAR(20)
AS
BEGIN
    UPDATE StudentAddress
    SET Street = @newStreet, City = @newCity, Province = @newProvince, Country = @newCountry, PostalCode = @newPostalCode
    WHERE StudentID = @stdID;
END
GO

/*Search Student*/
CREATE PROCEDURE spSearchStudent
    @stdID INT
AS
BEGIN
    SELECT *
    FROM Students AS S
    JOIN StudentAddress AS SA ON S.StudentID = SA.StudentID
    JOIN Course AS C ON S.StudentID = C.StudentID
    JOIN Modules AS M ON C.CourseCode = M.CourseCode
    WHERE S.StudentID = @stdID;
END
GO

/*Search module*/
CREATE PROCEDURE spSearchModule
    @courseID INT
AS
BEGIN
    SELECT *
    FROM Modules
    WHERE CourseCode = @courseID;
END