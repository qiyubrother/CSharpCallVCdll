using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpCallVCdll
{
    class Program
    {
        [DllImport(@"C:\Users\qiyub\source\repos\CSharpCallVCdll\Debug\VCdll.dll")]
        public static extern int Add(int a, int b);
        static void Main(string[] args)
        {
            var a = 100;
            var b = 200;
            Console.WriteLine($"{a}+{b}={Add(a, b)}");
        }
    }
}
