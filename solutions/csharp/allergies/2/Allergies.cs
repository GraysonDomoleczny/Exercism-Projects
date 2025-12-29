public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private int _mask;
    
    public Allergies(int mask)
    {
        _mask = mask;
        while (_mask > 256) { _mask -= 256; }
    }

    public bool IsAllergicTo(Allergen allergen) =>
        List().Contains(allergen);

    public Allergen[] List()
    {
        List<Allergen> _allergyList = new List<Allergen>();
        
        if (_mask >= 128) { _allergyList.Add(Allergen.Cats); _mask -= 128; }
        if (_mask >= 64) { _allergyList.Add(Allergen.Pollen); _mask -= 64; }
        if (_mask >= 32) { _allergyList.Add(Allergen.Chocolate); _mask -= 32; }
        if (_mask >= 16) { _allergyList.Add(Allergen.Tomatoes); _mask -= 16; }
        if (_mask >= 8) { _allergyList.Add(Allergen.Strawberries); _mask -= 8; }
        if (_mask >= 4) { _allergyList.Add(Allergen.Shellfish); _mask -= 4; }
        if (_mask >= 2) { _allergyList.Add(Allergen.Peanuts); _mask -= 2; }
        if (_mask >= 1) { _allergyList.Add(Allergen.Eggs); _mask -= 1; }
        
        return _allergyList.AsEnumerable().Reverse().ToArray();
    }
}