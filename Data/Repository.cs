using IUBAlumniUSA.Models;

namespace IUBAlumniUSA.Data;

public class Repository
{
    private readonly ApplicationDbContext _dbContext;

    public Repository(ApplicationDbContext dbContext)
    {
         _dbContext = dbContext;
    }

    public bool IsProfileExists(string userId)
    {

        var prof = _dbContext.Profiles.Where(p => p.IdentityUserId == userId).FirstOrDefault();

        if (prof != null)
            return true;


        return false;
    }

    public Profile GetProfile(string userId)
    {
        var prof = _dbContext.Profiles.Where(p => p.IdentityUserId == userId).FirstOrDefault();      

        return prof;
    }

    public bool IsProfileApproved(string userId)
    {
        var prof = _dbContext.Profiles.Where(p => p.IdentityUserId == userId && p.IsApproved == true).FirstOrDefault();

        return prof != null;
    }

    public IQueryable<Degree>  GetDegrees()
    {
        return _dbContext.Degrees.AsQueryable();
    }

    //public List<string> GetAllAdminEmails()
    //{
    //    var adminEmails = new List<string>();
    //    //_dbContext.Users.admin
    //}

    private List<SysConfig> _sysConfigs = null;
    public String GetSysConfigByKey(string key)
    {
        string value = "";

        if(_sysConfigs == null  && _dbContext!= null)
        {
            _sysConfigs = _dbContext.SysConfigs.ToList();
        }

        var conf = _sysConfigs?.Where(c => c.Key == key).FirstOrDefault();
        value = conf?.Value.ToString();
        return value;
    }
}
