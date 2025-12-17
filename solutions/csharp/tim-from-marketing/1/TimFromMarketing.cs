static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null && department == null) 
            {return $"{name} - OWNER";}
        if (department == null)
            {return $"[{id}] - {name} - OWNER";}
        if (id != null)
            {return $"[{id}] - {name} - {department.ToUpper()}";}
        return $"{name} - {department.ToUpper()}";
    }
}
