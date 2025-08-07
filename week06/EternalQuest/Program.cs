using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. creat new objetivo");
            Console.WriteLine("2. show objetivos");
            Console.WriteLine("3. Register progress");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save progress");
            Console.WriteLine("6. Load progress");
            Console.WriteLine("0. Exit");
            Console.Write("Chose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.ShowGoals();
                    break;
                case "3":
                    manager.ShowGoals();
                    Console.Write("Which goal did you complete? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoalEvent(index);
                    break;
                case "4":
                    manager.ShowScore();
                    break;
                case "5":
                    manager.Save("goals.txt");
                    Console.WriteLine("Progress saved.");
                    break;
                case "6":
                    manager.Load("goals.txt");
                    Console.WriteLine("Progress loaded.");
                    break;
                case "0":
                    running = false;
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Tipo de objetivo:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Chose: ");
        string type = Console.ReadLine();

        Console.Write("name: ");
        string name = Console.ReadLine();
        Console.Write("Descroption: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("How many times do you need to complete it? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus upon completion: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new CheckListGoal(name, desc, points, target, bonus));
                break;
        }
    }
}
