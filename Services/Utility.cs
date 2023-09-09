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
    public enum Country
    {
        [Description("USA")]
        USA,
        [Description("Canada")]
        Canada,

    }

    public enum DegreeLevel
    {
        [Description("B")]
        Bachelor,
        [Description("M")]
        Master,
    }
}
