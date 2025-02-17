using Microsoft.AspNetCore.Mvc;
using Restaurant.Service.Services;
using Restaurant.ViewModel.DishViewModels;

namespace Restaurant.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DishesController : ControllerBase
{
    private readonly DishService _service;
    private readonly ILogger<DishesController> _logger;

    public DishesController(DishService service, ILogger<DishesController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpPost("/adddish")]
    public async Task<IActionResult> AddDish([FromForm]CreateDishViewModel model)
    {
        var dish = await _service.CreateDishAsync(model);
        if(dish) return Ok(dish);
        return BadRequest(dish);
    }
}