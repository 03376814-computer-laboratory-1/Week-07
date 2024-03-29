﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_07
{
    class Program
    {
        static void Main(string[] args)
        {

            Student p = new Professor();
            p.SayHi();
            Console.ReadKey();
        }
    }
    class Vector
    {
        public Vector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }  // X - accessor (property)
        public int Y { get; set; }  // Y - accessor (property)

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
        // All operator overloads must be public and static.
        public static Vector operator +(Vector v1, Vector v2) //binary operator +
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1)  //unary operator -
        {
            return new Vector(-v1.X, -v1.Y);
        }
    }
}

class Person
{
    public virtual void SayHi()
    {
        Console.WriteLine("Hi I'm a person");
    }
}

class Student : Person
{
    public override void SayHi()
    {
        Console.WriteLine("Hi I'm a student");
    }
}

class Teacher : Person
{
    public new void SayHi()
    {
        Console.WriteLine("Hi I'm a teacher");
    }
}
class Professor : Person
{
    public new void SayHi()
    {
        Console.WriteLine("Hi I'm a teacher");
    }
}
