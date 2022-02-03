//make temp_table1 (Employee.DepartmentID, count repeating Employee.DepartmentID)
//make temp_table2 (Employee.DepartmentID, count total_costs at repeating Employee.DepartmentID)
//combine into (Department.Name, cost_per_person)

SELECT Employee.DepartmentID AS 'DepartmentID', COUNT(Employee.ID) AS 'Employees' 
INTO Temp1 
GROUP BY Employee.DepartmentID 
ORDER BY COUNT(Employee.ID);