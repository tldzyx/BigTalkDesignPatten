namespace DatabaseOperation
{
    internal interface IUser
    {
        void Insert(User user);

        User GetUser(int id);
    }
}