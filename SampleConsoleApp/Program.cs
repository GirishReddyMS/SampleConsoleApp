using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Program
    {
        public readonly int smpReadOnly;
        public const int smpConst = 0;

        public delegate double addDelegate(int a, int b);
        static void Main(string[] args)
        {
            
            ReadOnlyEx readOnlyInstance = new ReadOnlyEx();
            Console.WriteLine(readOnlyInstance.number);

            ReadOnlyEx differentInstance = new ReadOnlyEx(true);
            Console.WriteLine(differentInstance.number);

            Console.ReadLine();
        }


    }

    class ReadOnlyEx
    {
        public readonly int number = 10;
        public ReadOnlyEx()
        {
            number = 20;
        }
        public ReadOnlyEx(bool IsDifferentInstance)
        {
            number = 100;
        }
    }
    enum Sides
    {
        Left = 5,
        Right = 10,
        Top = 15,
        Bottom = 20
    }
}
