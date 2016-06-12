using System;

namespace DatabaseOperation
{
    internal class SqlServerUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SQL Server中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SQL Server中根据Id得到User表一条记录");
            return null;
        }
    }
}