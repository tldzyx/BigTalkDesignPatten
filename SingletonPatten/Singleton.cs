namespace SingletonPatten
{
    internal class Singleton
    {
        #region 饿汉式单例类
        //private static readonly Singleton __instance = new Singleton
        //public static Singleton GetInstance()
        //{
        //    return __instance;
        //}
        #endregion 饿汉式单例类

        #region 懒汉式单例类
        private static Singleton __instance;
        private static readonly object __lock = new object();
        public static Singleton GetInstance()
        {
            if (null == __instance)
            {
                lock (__lock)
                {
                    if (null == __instance)
                    {
                        __instance = new Singleton();
                    }
                }
            }
            return __instance;
        }
        #endregion 懒汉式单例类

        private Singleton()
        {
        }
    }
}