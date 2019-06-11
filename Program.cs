﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstact_class
{
    abstract class car
    {
        public void details(int no, string name)
        {
            Console.WriteLine("the car no{0} is number {1}", no, name);
        }
        public abstract void shape();
        public abstract void colour();
    }

    class B : car
    {
        public override void colour()
        {
            Console.WriteLine("The colour is red");
        }
        public override void shape()
        {
            Console.WriteLine("THE SHAPE IS SQAURE");
        }
    }


    class program
    {
        static void Main(string[] args)
        {

            B obj = new B();
            
            obj.colour();
            obj.shape();
            Console.ReadLine();


        }
    }
}

