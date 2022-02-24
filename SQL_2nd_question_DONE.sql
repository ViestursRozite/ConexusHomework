SELECT T.`ID`, T.`Department_name`, T.`ChiefId`, T.`Name`, T.`Salary` 
FROM (
    SELECT `employee`.`ID`, `DepartmentID`, `ChiefId`, `employee`.`Name`, `Salary`, `department`.`Name` AS 'Department_name' FROM `employee`
    LEFT JOIN `department`
    ON `employee`.`DepartmentID` = `department`.`ID`
) AS T
WHERE `Department_name` = 'Logistics';