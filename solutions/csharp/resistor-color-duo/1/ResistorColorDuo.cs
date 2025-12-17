public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] colorLabels = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        return int.Parse($"{Array.IndexOf(colorLabels, colors[0])}{Array.IndexOf(colorLabels, colors[1])}");
    }
}
