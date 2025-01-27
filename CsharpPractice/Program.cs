using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// cd is used to change the directory
// cd.. is used to go back to the previous directory
// dotnet new console -o Giraffe is used to create a new project
// dotnet run is used to run the project
// dotnet restore is used to restore the project
// dotnet build is used to build the project

namespace Giraffe{
    class Program{
        static void Main(string[] args){
            //  Console.WriteLine("Hello Daksh");
            // Console.WriteLine("   /|");
            // Console.WriteLine("  / |");
            // Console.WriteLine(" /--|");
            // Console.WriteLine("/   |");
            // Console.ReadLine();
            // String characterName="john";
            // int characterAge=35;
            // Console.WriteLine("there was a man in gandhinager named "+characterName);
            // Console.WriteLine("he was "+ characterAge+ " years old");
            // Console.WriteLine("he really liked the name "+characterName);
            // Console.WriteLine("but didnt like being "+characterAge);
            
            // string phrase = "giraffe academy";
            // char grade = 'A';
            // int age = 30;
            // double gpa = 3.3;
            // bool isMale=true;
            // Console.WriteLine(false);

            // Console.WriteLine("Giraffe Academy "+ "is cool");

            // string phrase = "Giraffe Academy";
            // Console.WriteLine(phrase.Length);
            // Console.WriteLine(phrase.ToUpper());
            // Console.WriteLine(phrase.ToLower());
            // Console.WriteLine(phrase.Contains("Academy"));
            // Console.WriteLine(phrase[5]);
            // Console.WriteLine(phrase[10]);
            // Console.WriteLine(phrase.IndexOf("Academy"));
            // Console.WriteLine(phrase.IndexOf("d"));
            // Console.WriteLine(phrase.Substring(8,3));

            // Console.WriteLine(5+8);
            // Console.WriteLine(5-8);
            // Console.WriteLine(5*8);
            // Console.WriteLine(5/8);
            // Console.WriteLine(5%2);
            // Console.WriteLine(4+2*3); out put is 10

            // Console.WriteLine(5+8.1);

            // int num = 6;
            // num++;
            // Console.WriteLine(num);

            // Console.WriteLine(Math.Abs(-40));
            // Console.WriteLine(Math.Pow(3,2));
            // Console.WriteLine(Math.Sqrt(36));
            // Console.WriteLine(Math.Max(4,15));
            // Console.WriteLine(Math.Min(4,15));
            // Console.WriteLine(Math.Round(4.7));

            // TO TAKE USER INPUT

            // Console.WriteLine("Enter your Name: ");
            // string name= Console.ReadLine();
            // Console.WriteLine("Enter your age:");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.Write("hello "+name);
            // Console.WriteLine("Hello " + name + " you are " + age+" years old");

            // int num = Convert.ToInt32("45");
            // Console.WriteLine(num+6);
            
            // string color, noun, celebrity;
            // Console.WriteLine("Enter a color:");
            // color = Console.ReadLine();
            // Console.WriteLine("Enter a noun:");
            // noun = Console.ReadLine();
            // Console.WriteLine("name  a celebrity:");
            // celebrity = Console.ReadLine();
            // Console.WriteLine("Roses are "+color);
            // Console.WriteLine(noun+" are blue");
            // Console.WriteLine("I love "+celebrity);

            // Console.ReadLine();

            // ARRAYS

            // int[] luckyNumbers= {4,8,15,16,23,42};
            // luckyNumbers[1]=900;
            // Console.WriteLine(luckyNumbers[1]);
            // string[] friends= new string[10];
            // friends[0]="Jim";
            // friends[1]="Kelly";
            // Console.WriteLine(friends[1]);
            // Console.WriteLine(luckyNumbers[0]);
            // Console.ReadLine();
            // // print whole arr
            // for(int i=0;i<luckyNumbers.Length;i++){
            //     Console.WriteLine(luckyNumbers[i]);

            // METHODS
            
            // SayHi("Mike", 21);
            // SayHi("nohan", 54);
            // SayHi("daksh", 25);

            // Console.WriteLine(Cube(5));

            // IF-ELSE STATEMENT

            // bool isMale = false;
            // bool isTall = false;

            // if(isMale && isTall){
            //     Console.WriteLine("person is tall male");
            // }
            // else if (isMale && !isTall){
            //     Console.WriteLine("person is short male");
            // }
            // else if (!isMale && isTall){
            //     Console.WriteLine("person is tall but not male");
            // }
            // else{
            //     Console.WriteLine("person is female");
            // }

            // }
            // static void SayHi(string name, int age){
            //     Console.WriteLine("Hello "+name+" your age is "+age);
            // }

            // static int Cube(int num){
            //     int result = num*num*num;
            //     return result;
            // }

            // Console.WriteLine(GetMax(10,20,15));

            // CALUCULATOR

            // Console.Write("Enter a number: ");
            // double num1 = Convert.ToDouble(Console.ReadLine());

            // Console.Write("Enter Operator: ");
            // string op = Console.ReadLine();

            // Console.Write("Enter a number: ");
            // double num2 = Convert.ToDouble(Console.ReadLine()); 

            // if (op == "+"){
            //     Console.WriteLine(num1+num2);
            // }
            // else if(op == "-"){
            //     Console.WriteLine(num1-num2);
            // }
            // else if(op == "*"){
            //     Console.WriteLine(num1*num2);
            // }
            // else if(op == "/"){
            //     Console.WriteLine(num1/num2);
            // }
            // else{
            //     Console.WriteLine("Invalid Operator");
            // }
            
            // SWITCH STATEMENT

            Console.WriteLine(GetDay(0));
            Console.ReadLine();





            }

            // SWITCH STATEMENT
            static string GetDay(int dayNum){
            string dayName;
            switch(dayNum){
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }
            return dayName;


            // static int GetMax(int num1, int num2, int num3){
            //     int result;
            //     if(num1>num2 && num1>num3){
            //         result= num1;
            //     }
            //     else if(num2>num1 && num2>num3){
            //         result = num2;
            //     }
            //     else{
            //         result = num3;
            //     }
            //     return result;
            // }
            
        }
}
}