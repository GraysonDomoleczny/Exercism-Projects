public enum Plant
{
    Violets = 'V',
    Radishes = 'R',
    Clover = 'C',
    Grass = 'G'
}

public class KindergartenGarden
{    
    private readonly string _diagram;
    private readonly List<string> _studentNames = new List<string>()
    {
        "Alice", "Bob", "Charlie", "David", "Eve", "Fred", 
        "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"
    };
    
    public KindergartenGarden(string diagram) => _diagram = diagram;

    public IEnumerable<Plant> Plants(string student)
    {
        int studentIndex = _studentNames.IndexOf(student) * 2;
        string plantsToCheck = _diagram.Substring(studentIndex, 2) +
                               _diagram.Substring(studentIndex + _diagram.Length / 2 + 1, 2);

        foreach (char plant in plantsToCheck)
            yield return (Plant)plant;    
    }
}