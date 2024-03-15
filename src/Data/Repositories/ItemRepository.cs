using Dapper;
using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly DapperContext _context;

        public ItemRepository(DapperContext context)
        {
            _context = context;
        }

        public async void Add(Item item)
        {
            var sql = @"insert into item (title, description, due, done, createdat)
                values (@title, @description, @due, false, GETDATE())";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(sql, new { item.Title, item.Description, item.Due });
        }

        public async void Complete(int id)
        {
            var sql = "update item set done = true where id = @id";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(sql, new { id });
        }

        public async void Delete(int id)
        {
            var sql = "delete from item where id = @id";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(sql, new { id });
        }

        public async Task<Item?> Get(int id)
        {
            var sql = "select * from item where id = @id";
            using var connection = _context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<Item>(sql, new { id });
        }

        public async Task<IEnumerable<Item>> List()
        {
            var sql = "select * from item where done = false";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<Item>(sql);
        }

        public async void Update(Item item)
        {
            var sql = @"update item set title = @title,
                description = @description,
                due = @due,
                done = @done,
                updatedat = GETDATE()
                where id = @id";
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(sql, new { item.Title, item.Description, item.Due, item.Done });
        }
    }
}
