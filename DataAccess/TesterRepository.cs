using Microsoft.EntityFrameworkCore;

public class TesterRepository : ITesterRepository
{
    private readonly AppDbContext _context;

    public TesterRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Tester> GetAll()
    {
        return _context.Testers.AsNoTracking().ToList();
    }

    public Tester GetById(int id)
    {
        return _context.Testers.Find(id);
    }

    public void Add(Tester tester)
    {
        _context.Testers.Add(tester);
        _context.SaveChanges();
    }

    public void Update(Tester tester)
    {
        _context.Testers.Update(tester);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var deleted = _context.Testers.Find(id);
        _context.Remove(deleted);
        _context.SaveChanges();
    }
}