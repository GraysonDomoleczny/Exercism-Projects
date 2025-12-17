static class Badge
{
    public static string Print(int? id, string name, string? department) =>
        (id, department) switch
        {
            (null, null) => $"{name} - OWNER",
            (_, null)    => $"[{id}] - {name} - OWNER",
            (null, _)    => $"{name} - {department.ToUpper()}",
            _            => $"[{id}] - {name} - {department.ToUpper()}"
        };
}
