using System;
using System.Collections.Generic;
using System.Text;

namespace Generator_For_Simple_Passwords.Views
{
    class Display
    {
        public int n;
        public int l;
        public string Passwords { get; set; }
        public Display()
        {
            n = int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());
        }

        public void Print()
        {
           Console.WriteLine(String.Join("", Passwords));
        }
    }
}
