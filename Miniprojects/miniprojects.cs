// // TO CALCULATE THE AVERAGE SCORE OF STUDENTS AND GRADE THEM ACCORDINGLY

// int currentAssignments = 5;

// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;

// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;

// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;

// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;

// int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
// int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
// int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
// decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
// decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
// decimal jeongScore = (decimal)jeongSum / currentAssignments;

// Console.WriteLine("Students\t\tgrades\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
// Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
// Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
// Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

// RANDOM NUMBER GENERATOR


// int number = 7;
// string text = "seven";

// Console.WriteLine(number);
// Console.WriteLine();
// Console.WriteLine(text);


// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

// DICEROLL GAME---------------------------------------------------------------------------------------------------

// Random dice = new Random();

// int roll1 = dice.Next(1,7);
// int roll2 = dice.Next(1,7);
// int roll3 = dice.Next(1,7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if(roll1 == roll2 || roll2 == roll3 || roll1== roll3){

// if(roll1 == roll2 && roll2 == roll3){
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
// }
// else{
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
// }
// }
// if(total >= 15){
//     Console.WriteLine("You win a new car!");
// }
// else if(total >= 10){
//     Console.WriteLine("You win a new laptop!");
// }
// else if(total == 7){
//     Console.WriteLine("You win a trip for two!");
// }
// else if(total < 7){
//     Console.WriteLine("You win a cat!");
// }
// else{
//     Console.WriteLine("You loss!");
// }

// SUBSCRIPTION PLAN---------------------------------------------------------------------------------------------------

// Random days = new Random();
// int day = days.Next(0, 11);

// Console.WriteLine($"Day {day}");
// if(day <=10){
//     Console.WriteLine("You have 10 days left you got 5% discount.");
// }
// else if(day <=5){
//     Console.WriteLine("you have 5 days left you got 10% discount.");
// }
// else if(day <=3){
//     Console.WriteLine("you have 3 days left you got 20% discount.");
// }
// else if(day == 1){
//     Console.WriteLine("you have 1 day left you got 50% discount.");
// }
// else{
//     Console.WriteLine("Your trial has expired.");
// }

// string[] orderID = new string[3];

// // orderID[0] = "A123";
// // orderID[1] = "B456";
// // orderID[2] = "C789";
// string[] orderID= {"A123", "B456", "C789"};
// Console.WriteLine(orderID[0]);
// Console.WriteLine(orderID[1]);
// Console.WriteLine(orderID[2]);

// orderID[0] = "D000";
// Console.WriteLine(orderID[0]);
// Console.WriteLine(orderID.Length);

// int[] inventory={100, 200, 300, 400, 500};
// int sum = 0;
// int bin = 0;
// foreach(int items in inventory){
//     sum += items;
//     bin++;
//     Console.WriteLine($"bin number: {bin} and the current sum is {sum}");
// }

// string[] orderID = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
// foreach(string name in orderID){
//     if(name.StartsWith("B")) {
//         Console.WriteLine(name);
//     }  
// }


// GRADE CALCULATOR---------------------------------------------------------------------------------------------------

// initialize variables - graded assignments 
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{

    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }


    // int sumAssignmentScores = 0;



    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumExamScores = sumExamScores + score;
        }

        else
        {
            gradedExtraCreditAssignments += 1;
            sumExtraCreditScores += score;
        }
    }
    currentStudentExamScore = (decimal)sumExamScores / examAssignments;
    decimal extraCreditBonus = (decimal)sumExtraCreditScores * 0.10M;
    decimal extraCreditPoints = extraCreditBonus / examAssignments;
    currentStudentGrade = (sumExamScores + extraCreditBonus) / examAssignments;
    currentStudentExtraCreditScore = sumExtraCreditScores;
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
}
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

