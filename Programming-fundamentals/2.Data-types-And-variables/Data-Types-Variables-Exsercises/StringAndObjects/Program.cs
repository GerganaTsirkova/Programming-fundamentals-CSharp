﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloworld = hello +" "+ world;
            string final = (string)helloworld;
            Console.WriteLine(final);
        }
    }
}
