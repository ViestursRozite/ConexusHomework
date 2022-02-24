SELECT `Name` AS 'Department_name', ( SUM_Salary / COUNT_People) AS 'Expenses_per_worker'
FROM (
    SELECT DepartmentID, SUM(Salary) AS 'SUM_Salary', COUNT(DepartmentID) AS 'COUNT_People'
    FROM `employee` 
    GROUP BY DepartmentID
) AS Totals 
INNER JOIN `department`
ON `Totals`.DepartmentID = `department`.`ID`
ORDER BY Expenses_per_worker ASC