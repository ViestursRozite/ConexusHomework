SELECT ID, Name, DepartmentID, MAX(Salary) 
FROM Employee 
GROUP BY DepartmentID; 