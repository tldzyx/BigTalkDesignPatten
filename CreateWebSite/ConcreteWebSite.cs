using System;

namespace CreateWebSite
{
    internal class ConcreteWebSite : WebSite
    {
        private readonly string _name;

        public ConcreteWebSite(string name)
        {
            _name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine($"网站分类：{_name} 用户：{user.Name}");
        }
    }
}