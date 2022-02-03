SELECT Employee.ID, Employee.Name, Department.Name 
FROM Employee 
LEFT JOIN Department ON Employee.DepartmentID = Department.ID 
WHERE Employee.ID = Employee.DepartmentID;