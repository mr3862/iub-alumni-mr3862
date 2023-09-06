using System.ComponentModel;

namespace IUBAlumniUSA.Services;


public static class Utility
{
    public enum Roles
    {
        [Description("SuperAdmin")]
        SuperAdmin,
        [Description("Admin")]
        Admin,
        [Description("Basic")]
        Basic
    }
}
