using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Domain;

public class ItemUseCases
{
    public IItemRepository _repository;

    public ItemUseCases(IItemRepository repository)
    {
        _repository = repository;
    }

    public async Task Add(Item item)
    {
        await _repository.Add(item);
    }

    public async Task<IEnumerable<Item>?> List()
    {
        return await _repository.List();
    }
}
