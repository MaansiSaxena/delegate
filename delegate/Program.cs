using System;

namespace delegate
{
    class Program
    {
        public delegate void addDelegate(int a, int b);
        public delegate void greetingDelegate(string name);

        public void add (int x, int y)
        {
            Console.WriteLine(@"The sume of {0} and {1} is {2},x y,(x+y)");
        }
        public static string Greetings(string name)
        {
            return "Hello" + name;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            addDelegate ad = new addDelegate(obj.add);
            greetingDelegate gd = new greetingDelegate(Program.Greetings);
        //invoking 
            ad.invoke(100, 200);
            string s = gd("mansi");
            Console.WriteLine(s);

        }
    }
}
