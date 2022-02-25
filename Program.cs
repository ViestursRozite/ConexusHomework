using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using MySql.Data.MySqlClient;

namespace ConexusHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            path = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));

            Console.WriteLine("Conexus Homework:\n" +
                "SQL Given two tables Employee and Department, structured as: \n" +
                "Press key to continiue:");
            Console.ReadKey(true);
            Console.WriteLine(@"
            CREATE TABLE IF NOT EXISTS Department (
	            `ID` INT NOT NULL,
	            `Name` VARCHAR(255) NOT NULL,
	            PRIMARY KEY (`ID`)
            );

            CREATE TABLE IF NOT EXISTS Employee (
	            `ID` INT NOT NULL PRIMARY KEY,
	            `DepartmentID` INT NOT NULL,
	            `ChiefId` INT NULL,
	            `Name` VARCHAR(255) NOT NULL,
	            `Salary` DECIMAL NOT NULL,
	            CONSTRAINT `fk_Employee_Employee` FOREIGN KEY (`ChiefId`) REFERENCES Employee (`ID`),
	            CONSTRAINT `fk_Employee_Department` FOREIGN KEY (`DepartmentID`) REFERENCES Department (`ID`) 
            );
            ");
            Console.WriteLine("Press key to continiue:\n");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("1. Uzrakstiet SQL pieprasījumu, kas atgriež darbiniekus ar maksimālo atalgojumu savā departamentā.");
            Console.WriteLine("Return employee with MAX(Salary) in their department");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);
            Console.WriteLine(File.ReadAllText(path + "SQL_1st_question_DONE.sql"));
            Console.WriteLine("\nWill work");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("2. Uzrakstiet SQL pieprasījumu, kas noskaidro departamenta vadītājus.");
            Console.WriteLine("Return chiefs of a department\nIn this case the Logistics department");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);
            Console.WriteLine(File.ReadAllText(path + "SQL_2nd_question_DONE.sql"));
            Console.WriteLine("\nWill give return all top level chiefs of the Logistics department");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("3. Uzrakstiet SQL pieprasījumu, kas sakārto departamentus pēc efektivitātes (darbinieku skaits pret kopējām izmaksām).");
            Console.WriteLine("Return 2 columns: Department and Expenses_per_worker, order them by productivity");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);
            Console.WriteLine(File.ReadAllText(path + "SQL_3rd_question_DONE.sql"));
            Console.WriteLine("\n2 columns showing department and how much they spend on average per person");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("4. Uzrakstiet SQL pieprasījumu, kas noskaidro katram departamentam darbinieku hierarhijas maksimālo līmeni.");
            Console.WriteLine("Return 2 columns: Department and maximum depth of chief-subordinate relations present");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);
            Console.WriteLine(File.ReadAllText(path + "SQL_4th_question_DONE.sql"));
            Console.WriteLine("\nShould give Department and a number for maximum depth present in department\n0 would mean that there is a chief without subordinates");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("Task 2 - Izvēlieties programmēšanas valodu (vēlams izmantot C++/C#) un atbildiet uz jautājumiem:");
            Console.WriteLine("1. Uzrakstiet funkciju, kas, saņemot veselo skaitļu masīvu, \n" +
                "pārceļ visas nulles uz masīva beigām, saglabājot pārējo skaitļu kārtību. \n" +
                "Mēģiniet izmantot pēc iespējas mazāk papildus atmiņas. Piemērs: [5, 0, 8, 3, 0] => [5, 8, 3, 0, 0].");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);
            Console.WriteLine("ArrayOperation.AllToRightMost(Array, 0);\n" +
                "will do so, demonstrated in tests\n");
            var a = new int[] { 5, 0, 8, 3, 0 };
            Console.WriteLine("[{0}]", string.Join(", ", a));
            Console.WriteLine("Turns into =>");
            Console.WriteLine("[{0}]", string.Join(", ", Task2_ArrayOperation.AllToRightMost(a, 0)));
            Console.WriteLine("\nDone by swapping elemrnts within the array");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("2. Ko var noskaidrot ar pārbaudi, ja x – vesels skaitlis: x & (x - 1) == 0 ?");
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);
            Console.WriteLine(File.ReadAllText(path + "Task_BitwiseOperationExplained.txt"));
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("3. Uzrakstiet funkciju, kas masīvam noskaidro mediānu \n" +
                "(elements, kas sadala kopu divās vienādās daļās: skaitļi, mazāki par mediānu, \n" +
                "un skaitļi, lielāki par mediānu).\n");
            Console.WriteLine("FindMedian.Median(array);\n" +
               "will do so, demonstrated in tests\n");
            var b = new double[] { 5, 0, 8, 3, 0 };
            Console.WriteLine("[{0}]", string.Join(", ", b));
            Console.WriteLine("↓");
            Console.WriteLine(Task2_FindMedian.Median(b));
            Console.WriteLine("\nPress key to continiue:\n");
            Console.ReadKey(true);

            Console.Clear();
        }
    }
}
