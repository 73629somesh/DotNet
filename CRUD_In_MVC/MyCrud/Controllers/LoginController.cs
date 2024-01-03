using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCrud.Models;
using BLL;
using BOL;
using System.Collections.Generic;
namespace MyCrud.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult LoginD()
    {
        Catalog cat=new Catalog();
        List<Login> list=cat.GetProducts();
        ViewData["Products"]=list;
        return View();
    }

  
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
