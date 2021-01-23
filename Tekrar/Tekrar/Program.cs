using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar
{
    public enum Error { NotFound=404,HttpAuhtrize=500};
    class Program
    {
        static void Main(string[] args)
        {
            #region Static
            //Student s1 = new Student();
            //s1.Name = "Kamran";
            //Student.Count = 5;
            //Console.WriteLine(Student.Count);
            //s1.Test();
            #endregion

            #region Sealed
            Engineer engineer = new Engineer();
            #endregion

            #region Generic
            //MyList<int> intList = new MyList<int>();
            //MyList<string> strList = new MyList<string>();
            MyList<Student,Person> list = new MyList<Student,Person>();
            Area area = new Area();
            #endregion

            #region Extension
            string word = "Hello";
            //Console.WriteLine(word.GetFirstChar());
            #endregion

            #region Boxing,Upcasting
            //object str = "Aqil";
            #endregion

            #region Downcasting
            object s = "Word";
            int x = (int)s;
            #endregion

            #region Operator overloading
            Student s1 = new Student();
            Student s2 = new Student();
            Console.WriteLine(s1>s2);
            #endregion
        }
    }

    #region Extension
    public static class Extension
    {
        public static char GetFirstChar(this string str)
        {
            return str[0];
        }
    }
    #endregion

    #region Generic
    struct Area
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Area(int x,int y)
        {
            X = x;
            Y = y;
        }
    }
    class MyList<T,J> where T:class,J,new()
    {
        private T MyProperty;

        public T Get()
        {
            return MyProperty;
        }
    }
    #endregion

    #region Static,Polymorphism
    interface IRun
    {
        void Run();
    }

    abstract class Person
    {
        public int Age;
        public virtual void Test()
        {
            Console.WriteLine("Person Test");
        }

        public abstract void Eat();
    }
    class Student:Person,IRun
    {
        public Student()
        {

        }
        public Student(string s)
        {

        }
        private string name;
        public string Surname {  get; set; }
        public string Name 
        {   get
            {
                return name;
            }
            set
            {
                if (value != "1")
                {
                    name = value;
                    return;
                }
                Console.WriteLine("Bele deyer set ede bilmersen");
            }
        }
        public static int Count;

        //static Student()
        //{
        //    Console.WriteLine("I am static");
        //}

        public static bool operator >(Student s1,Student s2)
        {
            return s1.Age > s2.Age;
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.Age < s2.Age;
        }

        public override void Test()
        {
            Console.WriteLine("Student Test");
        }

        public void Info()
        {
            Console.WriteLine(Name);
        }

        public void Info(int n)
        {
            Console.WriteLine(Name);
        }

        public void Info(string n)
        {
            Console.WriteLine(Name);
        }

        public override void Eat()
        {
            Console.WriteLine("Telebe yemek yemir");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Sealed
    class Man : Person
    {
        public sealed override void Test()
        {
            Console.WriteLine("Maked Sealed");
        }
        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
    sealed class Engineer:Man
    {
        //public virtual int Sum()
        //{
        //    return 5;
        //}
    }
    #endregion
}
