using System;

public class GradeSchool
{
    private Dictionary<string, int> studentGrades = new();

    public bool Add(string student, int grade) => studentGrades.TryAdd(student, grade);

    public IEnumerable<string> Roster()
    {
        return studentGrades.OrderBy(x => x.Value)
                            .ThenBy(x => x.Key)
                            .Select(x => x.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return studentGrades.Where(x => x.Value == grade)
                            .OrderBy(x => x.Value)
                            .ThenBy(x => x.Key)
                            .Select(x => x.Key);
    }
}
//Made by ericssonGamerz4