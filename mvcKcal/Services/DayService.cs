namespace mvcKcal;

public class DayService
{
    static List<Day> days = new List<Day>();
    static int nextId = 0;

    public static List<Day> GetAll() => days;

    public static Day? Get(int id) => days.Find(i => i.Id == id);

    public static void Create(Day day)
    {
        day.Id = nextId++;
        days.Add(day);
    }

    public static void Update(Day day)
    {
        int index = days.FindIndex(d => d.Id == day.Id);
        if (index != -1) days[index] = day;
    }


    public static void Delete(int id)
    {
        Day? day = Get(id);
        if (day != null) days.Remove(day);
    }
}


