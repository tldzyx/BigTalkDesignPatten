using System;

namespace DatabaseOperation
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //IFactory factory = new SqlServerFactory();
            IFactory factory = new AccessFactory();

            IUser iu = DataAccess.CreateUser();
            
            User user = new User();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAccess.CreateDepartment();

            Department department = new Department();
            id.Insert(department);
            id.GetDepartment(1);

            Console.ReadKey(true);
        }
    }
}