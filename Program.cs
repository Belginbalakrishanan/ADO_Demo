﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD.SelectType();
            Console.WriteLine("After deleting data");
            CRUD.DeleteType();
            CRUD.SelectType();

        }
    }
}
