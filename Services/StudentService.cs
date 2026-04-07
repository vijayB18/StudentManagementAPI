using StudentManagementAPI.Models;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Student>> GetAll() => await _repository.GetAll();

    public async Task<Student> GetById(int id) => await _repository.GetById(id);

    public async Task<Student> Add(Student student) => await _repository.Add(student);

    public async Task<Student> Update(Student student) => await _repository.Update(student);

    public async Task<bool> Delete(int id) => await _repository.Delete(id);
}