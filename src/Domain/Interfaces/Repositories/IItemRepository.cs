using Domain.Entities;
namespace Domain.Interfaces.Repositories;

public interface IItemRepository
{
    Task<Item?> Get(int id);
    Task<IEnumerable<Item>?> List();
    Task Add(Item item);
    void Update(Item item);
    void Delete(int id);
    void Complete(int id);
}
