SELECT `Name` AS 'Department', `Chief_worker_layers`
FROM (    
    
    SELECT `DepartmentID`, MAX(`depth`) AS 'Chief_worker_layers'
    FROM(

        WITH RECURSIVE `EmployeeAndChiefs` (`DepartmentID`, `ID`, `ChiefId`, `depth`) 
        AS(
            SELECT 
                `DepartmentID`, 
                `ID`, 
                `ChiefId`, 
                0
            FROM `Employee`
            WHERE `ChiefId` IS NULL

            UNION ALL

            SELECT 
                `Employee`.`DepartmentID`, 
                `Employee`.`ID`, 
                `Employee`.`ChiefId`, 
                `EmployeeAndChiefs`.`depth` + 1 
            FROM 
                `Employee`
                JOIN `EmployeeAndChiefs` ON `Employee`.`ChiefId` = `EmployeeAndChiefs`.`ID`
            )
        SELECT * FROM EmployeeAndChiefs

    ) AS chief_recursion 
    GROUP BY `DepartmentID`

) AS unnamed_departments
INNER JOIN `department`
ON `unnamed_departments`.DepartmentID = `department`.`ID`
ORDER BY `Chief_worker_layers` DESC