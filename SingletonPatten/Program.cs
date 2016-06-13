using System;

namespace SingletonPatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();

            Console.WriteLine($"两个对象是{(ReferenceEquals(instance1, instance2) ? "相" : "不")}同的实例。");

            Console.ReadKey(true);
        }
    }
}