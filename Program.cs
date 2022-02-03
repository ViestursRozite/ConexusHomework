using System;

namespace ConexusHomework
{
    class Program
    {
        //II. SQL vaicājumi 
        static void SQLQueries()
        {
            //II. SQL vaicājumi 
            string creation = @"CREATE TABLE IF NOT EXISTS Employee (
                ID INT NOT NULL, 
                DepartmentID INT NOT NULL, 
                ChiefID INT NULL, 
                Name VARCHAR(255) NOT NULL, 
                Salary DECIMAL NOT NULL, 
                PRIMARY KEY ('ID'), 

                CONSTRINT fk_Employee_Employee FOREIGN KEY (ChiefID) 
                REFERENCES Employee(ID), 
                CONSTRINT fk_Employee_Department1 FOREIGN KEY (DepartmentID) 
                REFERENCES Department (ID) 
                );

                CREATE TABLE IF NOT EXISTS Department (
                ID INT NOT NULL, 
                Name VARCHAR(255) NOT NULL, 
                PRIMARY KEY ('ID')
                ); ";

            //1. Uzrakstiet SQL pieprasījumu, kas atgriež darbiniekus
            //ar maksimālo atalgojumu savā departamentā. 

            string query1 = "SELECT ID, Name, DepartmentID, MAX(Salary) " +
                "FROM Employee " +
                "GROUP BY DepartmentID; ";

            //2. Uzrakstiet SQL pieprasījumu, kas noskaidro departamenta vadītājus

            string query2 = "SELECT Employee.ID, Employee.Name, Department.Name " +
                "FROM Employee " +
                "LEFT JOIN Department ON Employee.DepartmentID = Department.ID " +
                "WHERE Employee.ID = Employee.DepartmentID ;";

            //3. Uzrakstiet SQL pieprasījumu, kas sakārto departamentus pēc efektivitātes (darbinieku skaits pret kopējām
            //izmaksām). 

            //make temp_table1 (Employee.DepartmentID, count repeating Employee.DepartmentID)
            //make temp_table2 (Employee.DepartmentID, count total_costs at repeating Employee.DepartmentID)
            //combine into (Department.Name, cost_per_person)

            string query3 = "SELECT Employee.DepartmentID AS 'DepartmentID', COUNT(Employee.ID) AS 'Employees' " +
                "INTO Temp1 " +
                "GROUP BY Employee.DepartmentID " +
                "ORDER BY COUNT(Employee.ID) ";

            //4. Uzrakstiet SQL pieprasījumu, kas noskaidro katram departamentam darbinieku hierarhijas maksimālo līmeni. 

        }

        //III Izvēlieties programmēšanas valodu (vēlams izmantot C++/C#) un atbildiet uz jautājumiem:
        static void Main(string[] args)
        {
            //III Izvēlieties programmēšanas valodu (vēlams izmantot C++/C#) un atbildiet uz jautājumiem:

            //1. Uzrakstiet funkciju, kas, saņemot veselo skaitļu masīvu, pārceļ visas nulles uz masīva beigām, saglabājot pārējo
            //skaitļu kārtību. Mēģiniet izmantot pēc iespējas mazāk papildus atmiņas.
            //Piemērs: [5, 0, 8, 3, 0] => [5, 8, 3, 0, 0]. 
            int[] intArr = new int[] { 1, 0, 0, 4, 6, 0, 0, 9, 8, 4, 2, 4, 5, 0 };
            Console.WriteLine("unsorted [{0}]", string.Join(", ", intArr));
            ShoveAllInstancesOfIntToRightmost(intArr, 0);
            Console.WriteLine("shoveZero[{0}]", string.Join(", ", intArr));

            //2. Ko var noskaidrot ar pārbaudi, ja x – vesels skaitlis: x & (x - 1) == 0 ?
            string question = "(x & (x - 1) == 0)  how can this be used?";
            string answer = "Will return True at (int)'x' equals all powers of '2', ignoring '-' sign," +

                "at x = 1 (1 & 0) resuts: 2^0 = 1 therefore True" +

                "at x = 0 (0 & -1) we also get True, assumption: " +
                "'-' in 'int' is stored at leftmost position. " +
                "As this operates at rightmost end of 'int', all relevant data looks the same as a case for: (0 & 1) or (1 & 0)";
            Console.WriteLine("(( 0 & -1 ) == ( 0 & 1 )) : " + ((0 & -1) == (0 & 1)));//true

            //3. Uzrakstiet funkciju, kas masīvam noskaidro mediānu (elements, kas sadala kopu divās vienādās daļās: skaitļi,
            //mazāki par mediānu, un skaitļi, lielāki par mediānu). 
            Console.WriteLine("median: " + GetMedian(intArr));
        }

        public static int GetMedian(int[] sourceNumbers)
        {
            //make sure the list is sorted, but use a new array
            int[] sortedPNumbers = (int[])sourceNumbers.Clone();
            Array.Sort(sortedPNumbers);

            //get the median
            int size = sortedPNumbers.Length;
            int mid = size / 2;
            int median = (size % 2 != 0) ? (int)sortedPNumbers[mid] : ((int)sortedPNumbers[mid] + (int)sortedPNumbers[mid - 1]) / 2;
            return median;
        }

        static int[] ShoveAllInstancesOfIntToRightmost(int[] intArray, int number)
        {
            int numberElementsToShove = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                //when matching item found swap this position with the next unknown num
                if (intArray[i] == number)
                {
                    if (i + numberElementsToShove >= intArray.Length) return intArray;//allow exit if end of arr

                    //swap
                    intArray[i] = intArray[i + numberElementsToShove];
                    intArray[i + numberElementsToShove] = number;

                    while (intArray[i] == number)//still matching, a new instance was encountered
                    {
                        //note 1 new instance detected
                        numberElementsToShove += 1;

                        if (i + numberElementsToShove >= intArray.Length) return intArray;//allow exit if end of arr

                        //swap
                        intArray[i] = intArray[i + numberElementsToShove];
                        intArray[i + numberElementsToShove] = number;
                    }
                }
            }
            return intArray;//no specified number present
        }
    }
}
