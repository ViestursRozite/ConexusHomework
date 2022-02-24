using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ConexusHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //make testing data
            string cs = @"server=localhost;userid=root;password=password;database=cum";
            var con = new MySqlConnection(cs);
            var rand = new Random();

            con.Open();

            for (int i = 0; i < 100; i++)//Make managers
            {
                MySqlCommand command = con.CreateCommand();   ///("SELECT * FROM Employee;");

                var cm = $"INSERT INTO Employee (`DepartmentID`, `ChiefId`, `Name`, `Salary`) " +
                    $"VALUES ({rand.Next(1, 7)}, NULL, 'Employee name: {rand.Next(1, 3000)} .', {rand.Next(500, 6000)}); ";

                command.CommandText = cm;

                command.ExecuteNonQuery();
                Console.WriteLine($"Added manager nr {i}");
            }

            for (int i = 0; i < 1000; i++)//make workers
            {
                MySqlCommand command = con.CreateCommand();   ///("SELECT * FROM Employee;");

                var cm = $"INSERT INTO Employee (`DepartmentID`, `ChiefId`, `Name`, `Salary`) " +
                    $"VALUES ({rand.Next(1, 7)}, {rand.Next(1, 99)}, 'Employee Name: {rand.Next(10000, 300000)} .', {rand.Next(500, 6000)}); ";

                command.CommandText = cm;

                command.ExecuteNonQuery();
                Console.WriteLine($"Added worker nr {i}");
            }

            Console.WriteLine(con.Database); 
            Console.WriteLine($"MySQL version : {con.ServerVersion}");
        }
    }
}
