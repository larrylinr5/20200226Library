using System.Configuration;

namespace _20200226Library
{
    public class Class1
    {
        public string Result1()
        {
            return "1234";
        }
        public string Result2()
        {
            var value = ConfigurationManager.AppSettings["a1"]; //config
            return value;
        }
    }
}
