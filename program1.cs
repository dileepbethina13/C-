using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    //class Animal
    //{
    //    public string name;

    //    public void display()
    //    {
    //        Console.WriteLine("I am Animal");
    //    }
    //}

    //class Dog : Animal
    //{
    //    public void getName()
    //    {
    //        Console.WriteLine("My name is: " + name);
    //    }

    //}
    //Method overriding
    //class Animal
    //{
    //    public virtual void eat()
    //    {
    //        Console.WriteLine("I Eat Food");
    //    }

    //}
    //class Dog : Animal
    //{
    //    public override void eat()
    //    {
    //        //Calling method from Animal class
    //        base.eat();
    //        Console.WriteLine("Dogs eat Dog Food.");
    //    }
    //}
    //Importance of inheritance is Code Reusable
    //class RegularPolygon
    //{
    //    public void calculatePerimeter(int length, int sides)
    //    {
    //        int result = length * sides;
    //        Console.WriteLine("Perimeter: " + result);
    //    }
    //}
    //class Square : RegularPolygon
    //{
    //    public int length = 200;
    //    public int sides = 4;
    //    public void calculateArea()
    //    {
    //        int area = length * length;
    //        Console.WriteLine("Area of Square: " + area);
    //    }


    //}
    //class Rectangle : RegularPolygon
    //{
    //    public int length = 100;
    //    public int breadth = 200;
    //    public int sides = 4;
    //    public void calculateRectangle()
    //    {
    //        int area = length * breadth;
    //        Console.WriteLine("Area of Rectangle: " + area);
    //    }
    //}
    //Abstract Method
    //abstract class Language
    //{
    //    //Non Abstract Method
    //    public void display()
    //    {
    //        Console.WriteLine("Non Abstract Method");
    //    }
    //}
    //abstract class Animal
    //{
    //    public abstract void makesound();

    //}
    //class Dog : Animal
    //{
    //    public override void makesound()
    //    {
    //        Console.WriteLine("Bow Bow");
    //    }
    //}
    //abstarct class with get and set characters
    //abstract class Animal
    //{
    //    protected string name;
    //    //abstract class
    //    public abstract string Name
    //    {
    //        get;
    //        set;
    //    }

    //}
    //class Dog : Animal
    //{
    //    public override string Name
    //    {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            name = value;
    //        }
    //    }
    //}

    //abstract class Animal
    //{
    //    public Animal()
    //    {
    //        Console.WriteLine("Animal Constructor");
    //    }
    //}
    //class Dog : Animal
    //{
    //    public Dog()
    //    {
    //        Console.WriteLine("Dog Constructor");
    //    }
    //}
    
    class Car
    {

        public string color;
        public int maxspeed;
        public void journey()
        {
            Console.WriteLine("The Car is Going as Fast as It Can");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.color = "Red";
            obj.maxspeed = 160;
            Console.WriteLine(obj.color);
            Console.WriteLine(obj.maxspeed);
            Car obj1 = new Car();
            obj1.color = "Blue";
            obj1.maxspeed = 200;
            Console.WriteLine(obj1.color);
            Console.WriteLine(obj1.maxspeed);
            obj.journey();
            
            //Program obj = new Program();
            //obj.color = "red";
            //obj.maxspeed = 100;
            //Console.WriteLine(obj.color);
            //Console.WriteLine(obj.maxspeed);
            //Program obj1 = new Program();
            //obj1.color = "Blue";
            //obj1.maxspeed = 160;
            //Console.WriteLine("From Object 1");
            //Console.WriteLine(obj1.color + " " + obj1.maxspeed);
            //obj.journey();
            //Dog obj = new Dog();
            
            //Dog obj = new Dog();
            //obj.Name = "Bujju Thalulu";
            //Console.WriteLine("Name: " + obj.Name);
            //Dog obj = new Dog();
            //obj.makesound();
            //Program obj1 = new Program();
            //obj1.display();

            //Square obj1 = new Square();
            //obj1.calculateArea();
            //obj1.calculatePerimeter(obj1.length, obj1.sides);

            //Rectangle obj2 = new Rectangle();
            //obj2.calculateRectangle();
            //obj2.calculatePerimeter(obj2.length, obj2.sides);

            //Dog obj = new Dog();
            ////accessing the overridden method
            //obj.eat();

            //Dog obj = new Dog();
            //obj.name = "Bujji Thalli";

            //obj.display();

            //obj.getName();

            Console.ReadLine();
        }
    }
}
