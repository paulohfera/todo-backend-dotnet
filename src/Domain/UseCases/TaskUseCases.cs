using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Domain;

public class TaskUseCases
{
    public IItemRepository _repository;

    public TaskUseCases(IItemRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Item>> List()
    {
        return await _repository.List();
    }
}
