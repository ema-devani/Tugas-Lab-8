using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public string NilaiA { get; set; }
        public string NilaiB { get; set; }
        public int Pilihan { get; set; }

        public int Penambahan(int a, int b)
        {
            return a + b;
        }

        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        public int Perkalian(int a, int b)
        {
            return a * b;
        }

        public static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
