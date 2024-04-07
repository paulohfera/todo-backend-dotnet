using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api;

public class ItemController : BaseController
{
    private readonly ItemUseCases _itemUseCases;

    public ItemController(ItemUseCases itemUseCases)
    {
        _itemUseCases = itemUseCases;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var itens = await _itemUseCases.List();
        return Ok(itens);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Item item)
    {
        await _itemUseCases.Add(item);
        return Ok();
    }
}
