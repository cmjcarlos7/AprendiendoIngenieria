using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    class MySQLDataBaseService
    {
        public void GetData()
        {
            // Get data from database.
        }
    }

    class DataAccess
    {
        private MySQLDataBaseService MySQLDataBaseService;

        public DataAccess()
        {
            MySQLDataBaseService = new MySQLDataBaseService();
        }

        public void GetData()
        {
            MySQLDataBaseService.GetData();
            // ...
        }
    }
}
