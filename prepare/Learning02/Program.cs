using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._company = "PartnerHero";
        job1._jobTitle = "Technical Support";
        job1._startYear = "2022";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._company = "24/7 Intouch";
        job2._jobTitle = "Customer Support";
        job2._startYear = "2021";
        job2._endYear = "2022";

   
        Resume Myresume = new Resume();
        Myresume._name = "Eliezer Rivera";
        Myresume._jobs.Add(job1);
        Myresume._jobs.Add(job2);

        Myresume.DisplayDetails();
    }
}