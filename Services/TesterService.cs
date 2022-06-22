public class TesterService : ITesterService
{
    private readonly ITesterRepository _testerRepository;

    public TesterService(ITesterRepository testerRepository)
    {
        _testerRepository = testerRepository;
    }

    public List<Tester> GetAll()
    {
        return _testerRepository.GetAll();
    }

    public Tester GetById(int id)
    {
        return _testerRepository.GetById(id);
    }
    public void Add(Tester tester)
    {
        _testerRepository.Add(tester);
    }

    public void Update(Tester tester)
    {
        _testerRepository.Update(tester);
    }

    public void Delete(int id)
    {
        _testerRepository.Delete(id);
    }
}