class WeighingMachine
{
    private double _weight;
    
    public int Precision { get; }
    public double TareAdjustment { get; set; } = 5;
    public double Weight 
    {
        get => _weight;
        set => _weight = value >= 0 ? value : throw new ArgumentOutOfRangeException();
    }
    public string DisplayWeight => $"{(_weight - TareAdjustment).ToString($"F{Precision}")} kg";
    
    public WeighingMachine(int precision)
    { Precision = precision; }
}
