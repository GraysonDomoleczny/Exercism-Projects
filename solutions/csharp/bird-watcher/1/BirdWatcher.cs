class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay) => this.birdsPerDay = birdsPerDay;

    public static int[] LastWeek() =>
        [0, 2, 5, 3, 7, 8, 4];

    public int Today() =>
        birdsPerDay[6];

    public void IncrementTodaysCount() =>
        birdsPerDay[6] += 1;

    public bool HasDayWithoutBirds()
    {
        foreach (int bird in birdsPerDay)
            if (bird == 0)
                return true;
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int numberOfBirds = 0;
        for (int i = 0; i < numberOfDays; i++)
            numberOfBirds += birdsPerDay[i];
        return numberOfBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int bird in birdsPerDay)
            if (bird > 4)
                busyDays += 1;
        return busyDays;
    }
}
