using Microsoft.AspNetCore.Mvc;
using DataPaintLibrary.Services.Interfaces;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

[Authorize]
public class UsersController : Controller
{
    private readonly IAppCollectionService _appCollectionService;

    public UsersController(IAppCollectionService appCollectionService)
    {
        _appCollectionService = appCollectionService;
    }

    [HttpGet]
    [Route("LoadUsers")]
    public async Task<IActionResult> LoadUsers()
    {
        try
        {
            var users = await _appCollectionService.GetAllUsersAsync();
            if (users == null)
            {
                return NotFound();
            }
            return PartialView("_Users", users);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error");
        }
    }
}