using System;

class Program
{
    static void Main(string[] args)
    {
         job job1 = new job();
        job1._company = "Metanoeo";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;
        job1.Display();
    }
}