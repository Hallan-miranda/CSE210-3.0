public static class GoalFactory
{
    public static Goal Deserialize(string data)
    {
        var parts = data.Split('|');
        switch (parts[0])
        {
            case "Simple":
                var simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    simple.RecordEvent();
                }
                return simple;

            case "Eternal":
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));

            case "Checklist":
                var checklist = new CheckListGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5])
                );

                int completedTimes = int.Parse(parts[6]);
                for (int i = 0; i < completedTimes; i++)
                {
                    checklist.RecordEvent();
                }

                return checklist;

            default:
                throw new Exception("Tipo de objetivo desconhecido: " + parts[0]);
        }
    }
}