public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{    
    private readonly string _diagram;
    private List<Plant> _studentPlants = new List<Plant>();
    private readonly List<string> _studentNames = new List<string>()
    {
        "Alice", "Bob", "Charlie", "David", "Eve", "Fred", 
        "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"
    };
    
    public KindergartenGarden(string diagram) => _diagram = diagram;

    public IEnumerable<Plant> Plants(string student)
    {
        int diagramLength = _diagram.Length / 2;
        string diagramTop = _diagram.Substring(0, diagramLength);
        string diagramBottom = _diagram.Substring(diagramLength + 1, diagramLength);
        
        int studentPosition = _studentNames.IndexOf(student) * 2;

        string plantsToCheck = diagramTop.Substring(studentPosition, 2) +
                               diagramBottom.Substring(studentPosition, 2);

        foreach (char plant in plantsToCheck)
        {
            if (plant == 'G') _studentPlants.Add(Plant.Grass);
            if (plant == 'C') _studentPlants.Add(Plant.Clover);
            if (plant == 'R') _studentPlants.Add(Plant.Radishes);
            if (plant == 'V') _studentPlants.Add(Plant.Violets);
        }

        return _studentPlants;

        
            
    }
}