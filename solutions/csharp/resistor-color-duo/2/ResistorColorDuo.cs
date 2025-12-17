public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] colorLabels = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

        int firstIndex = Array.IndexOf(colorLabels, colors[0]);
        int secondIndex = Array.IndexOf(colorLabels, colors[1]);

        return firstIndex * 10 + secondIndex;
    }
}
