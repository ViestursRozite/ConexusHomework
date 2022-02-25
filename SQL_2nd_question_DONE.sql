SELECT All_columns_merged.`ID`, All_columns_merged.`Department_name`, All_columns_merged.`ChiefId`, All_columns_merged.`Name`, All_columns_merged.`Salary` 
FROM (
    SELECT `employee`.`ID`, `DepartmentID`, `ChiefId`, `employee`.`Name`, `Salary`, `department`.`Name` AS 'Department_name' FROM `employee`
    LEFT JOIN `department`
    ON `employee`.`DepartmentID` = `department`.`ID`
) AS All_columns_merged
WHERE `Department_name` = 'Logistics';