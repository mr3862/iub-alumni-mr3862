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
}
