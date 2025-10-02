static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (department == null && id == null)//NEW OWNER
            return $"{name} - OWNER";

        else if (department == null)//OWNER
            return $"[{id}] - {name} - OWNER";

        else if (id != null)//EMPLOYEE
            return $"[{id}] - {name} - {department.ToUpper()}";

        else//NEW EMPLOYEE       
            return $"{name} - {department.ToUpper()}";
    }
}
