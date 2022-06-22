public interface ITesterService
{
    List<Tester> GetAll();
    Tester GetById(int id);
    void Add(Tester tester);
    void Update(Tester tester);
    void Delete(int id);
}