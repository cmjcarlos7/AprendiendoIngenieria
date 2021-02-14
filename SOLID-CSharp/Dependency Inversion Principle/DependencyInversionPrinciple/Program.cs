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

    interface IDataBaseService
    {
        public void GetData();
    }
    class MySQLDataBaseService : IDataBaseService
    {
        public void GetData()
        {
            // Get data from database.
        }
    }

    class SQLServerDataBaseService : IDataBaseService
    {
        public void GetData()
        {
            // Get data from database.
        }
    }

    class DataAccess
    {
        private IDataBaseService DataBaseService;

        public DataAccess(IDataBaseService dataBaseService)
        {
            DataBaseService = dataBaseService;
        }

        public void GetData()
        {
            DataBaseService.GetData();
            // ...
        }
    }
}
