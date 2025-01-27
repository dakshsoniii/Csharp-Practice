// CLASSES AND OBJECTS

// using System;

// public class Parent
// {
//     public void Display()
//     {
//         Console.WriteLine("I am a parent");
//     }

//     public static void Main(string[] args)
//     {
//         // Create an instance of the parent class to call the instance method Display
//         Parent parentInstance = new Parent();
//         parentInstance.Display();
//     }
// }

// ACCESSORS

// using System;
// public class Person{
//     private string name;
//     private int age;
    
//     public string Name{
//         get{ return name ;}
//         set{ name = value;}
//     }

//     public int Age{
//         get{ return age;}
//         set{age = value}
//     }
//     public void Display(){
//         Console.WriteLine($"Name: {Name}, Age:{Age}");
//     }
// }
// class Program{
//     public static void Main(string[] args){
//         Person person = new Person();

//         person.Name = "DAKSH";
//         person.Age = 21;
//         person.Display();
//     }
// }

// METHOD OVERLOADING

// using System;

// public class Printer{
//     public void Print(string message){
//         Console.WriteLine($"Printing string {message}");
//     }

//     public void Print(int number){
//         Console.WriteLine($"printing number {number}");

//     }

//     public void Print(string message, int copies){
//         for(int i=0;i<copies;i++){

//             Console.WriteLine($"Printing string: {message}");
//         }
//     }
// }
// public class Program{
//     public static void Main(string[] args){
//         Printer printer = new Printer();
//         printer.Print("daksh",10);
//     }
// }

// METHOD OVERRIDING

// using System;
// public class Musicplayer{
//     public virtual void Play(){
//         Console.WriteLine("Playing music");
//     }
// }

// public class Mp3player:Musicplayer{
//     public override void Play(){
//         Console.WriteLine("playing mp3 music");
//     }
// }

// public class Wavplayer:Musicplayer{
//     public override void Play()
//     {
//      Console.WriteLine("Playing wav music");
//     }
// }

// public class Program{
//     public static void Main(string[] args){

//         Musicplayer musicplayer = new Wavplayer();
//         musicplayer.Play();
//     }
// }

// ABSTRACTION

// hiding internal details and showing only necessary details of an object is called abstraction
// abstract class is a class that cannot be instantiated and is used to define or enforce a blueprint for derived classes
// it contains abstract method(method with implementation) and non abstract method(method without implementation)

// using System;

// abstract class Shape{
//     public abstract void draw();

//     public void display(){
//         Console.WriteLine("this is a shape");
//     }

// }

// class Circle:Shape{
//     public override void draw(){
//         Console.WriteLine("draw a circle");
//     }
// }

// class Square:Shape{
//     public override void draw(){
//         Console.WriteLine("draw a square");
//     }
// }

// class program{
//     public static void Main(string[] args){
//     Shape shape = new Circle();
//     shape.draw();
//     Shape shape1 = new Square();
//     shape1.draw();
    
//     }
// }

// ENCAPSULATION
// Encapsulation is the process of bundling the data members and methods that operate on the data members into a single unit called a class
// In C#, encapsulation is achieved using:
// Access modifiers like private, protected, internal, and public.
// Properties (getters and setters) to control how data is accessed and modified.

// using System;

// class Person{
//     private string name;

//     public string Name{
//         get{return name;}
//         set{name=value;}
//     } 
// }

// class Program{
// public static void Main(string[] args){
//     Person person = new Person();
//     person.Name="Daksh";

//     Console.WriteLine("hello Mr "+ person.Name);
// }
// }r



