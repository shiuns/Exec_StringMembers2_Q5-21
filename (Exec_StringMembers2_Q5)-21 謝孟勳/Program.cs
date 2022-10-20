using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Exec_StringMembers2_Q5__21_謝孟勳
{
    //比對使用者輸入值是否為 "Allen" 不拘大小寫
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Allen Kou";
            if (Regex.IsMatch(name, "[A-Z]"))
            {
                Console.WriteLine("是不拘大小寫");
            }
        }
    }
}
