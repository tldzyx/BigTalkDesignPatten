namespace DatabaseOperation
{
    internal interface IDepartment
    {
        void Insert(Department user);

        Department GetDepartment(int id);
    }
}