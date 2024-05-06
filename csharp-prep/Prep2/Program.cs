using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter you grade: ");
        String answer = Console.ReadLine();
        int grade = int.Parse(answer);

        String letter = "";
        
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }
        
        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }
         
        else
        {
            letter = "F";
        }


        String sign = "";
        if (grade % 10 >= 7)
        {
            sign = "+";
        }

        else if (grade % 10 < 3)
        {
            sign = "-";
        }

        else{
            sign = "";
        }
        
        Console.WriteLine($"Your letter is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation! You passed.");
        }
        else 
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}