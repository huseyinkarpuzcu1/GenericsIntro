using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("yarrak");

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
