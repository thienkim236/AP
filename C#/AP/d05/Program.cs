﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05
{
    //Dinh nghia delegate DCasio
    public delegate int DCasio(int n1, int n2);

    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 23;

            DCasio casioMul = new DCasio(MyMaths.Mult);
            casioMul(x, y);
            Console.WriteLine();

            MyMaths oMath = new MyMaths();
            DCasio casioAdd = new DCasio(oMath.Add);
            casioAdd(x, y);
            Console.WriteLine();

            //1 delegate co the chua dia chi cua nhieu ham
            DCasio casio = new DCasio(MyMaths.Mult);
            casio += oMath.Add;
            casio += oMath.Sub;
            casio(x, y);
            Console.WriteLine();

            //Bo bot ham Add
            casio -= oMath.Add;
            casio(x, y);

            Console.ReadKey();
        }
    } //Ket thuc Program

    public class MyMaths
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            return a + b;
        }
        public int Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            return a * b;
        }
    }
}
