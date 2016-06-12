using System;

namespace DatabaseOperation
{
    internal class SqlServerDepartment : IDepartment
    {
        public void Insert(Department user)
        {
            Console.WriteLine("在SQL Server中给Department表增加一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SQL Server中根据Id得到Department表一条记录");
            return null;
        }
    }
}