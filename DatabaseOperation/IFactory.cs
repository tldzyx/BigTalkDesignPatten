namespace DatabaseOperation
{
    internal interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}