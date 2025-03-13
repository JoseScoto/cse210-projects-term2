using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2002;
        //job1.Display(); Removing these lines that are printing info

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Data Scientist";
        job2._startYear = 2003;
        job2._endYear = 2010;
        //job2.Display(); Removing these lines that are printing info

        Resume myResume = new Resume();
        myResume._name = "Jose Escoto";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Leaving only the Display method from our Resume class
        myResume.Display();
    }
}