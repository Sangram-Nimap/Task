CREATE DATABASE MyDatabase;
USE MyDatabase;

CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50),
    Age INT,
    Class VARCHAR(20)
);

CREATE TABLE Employees (
    EmployeeId INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);

INSERT INTO Students (Name, Age, Class) VALUES ('Rahul', 16, '10th');
INSERT INTO Students (Name, Age, Class) VALUES ('Anjali', 17, '11th');
INSERT INTO Students (Name, Age, Class) VALUES ('Ramesh', 15, '9th');
INSERT INTO Students (Name, Age, Class) VALUES ('Sneha', 16, '10th');
INSERT INTO Students (Name, Age, Class) VALUES ('Aman', 17, '12th');
INSERT INTO Students (Name, Age, Class) VALUES ('Divya', 14, '8th');
INSERT INTO Students (Name, Age, Class) VALUES ('Karan', 18, '12th');
INSERT INTO Students (Name, Age, Class) VALUES ('Neha', 15, '9th');

INSERT INTO Employees (Name, Department, Salary) VALUES ('Suresh', 'HR', 25000);
INSERT INTO Employees (Name, Department, Salary) VALUES ('Meena', 'IT', 45000);
INSERT INTO Employees (Name, Department, Salary) VALUES ('Amit', 'IT', 40000);

SELECT * FROM Students;
SELECT * FROM Employees;

SELECT Name, Age FROM Students WHERE Age > 15;
SELECT * FROM Employees WHERE Department = 'IT';

SELECT * FROM Students ORDER BY Name ASC;
SELECT * FROM Employees ORDER BY Salary DESC;

SELECT * FROM Students WHERE Name LIKE 'R%';
SELECT * FROM Employees WHERE Name LIKE '%a';

UPDATE Students SET Class = '12th' WHERE Name = 'Anjali';
UPDATE Employees SET Salary = 47000 WHERE Name = 'Amit';

DELETE FROM Students WHERE Name = 'Ramesh';
DELETE FROM Employees WHERE Name = 'Suresh';

DROP TABLE Students;
DROP TABLE Employees;

DROP DATABASE MyDatabase;
