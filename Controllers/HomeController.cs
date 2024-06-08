using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPET.Models;
using LHPet.Models;

namespace LHPET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Clientes
        Cliente cliente1 = new Cliente(01, "Artur", "000.000.000-11", "Arthur10@gmail.com", "Madruga");
        Cliente cliente2 = new Cliente(01, "Tomás", "000.000.000-12", "Tomas10@gmail.com", "Arnaldo");
        Cliente cliente3 = new Cliente(01, "Carlos", "000.000.000-13", "Carlos10@gmail.com", "Ildo");
        Cliente cliente4 = new Cliente(01, "Tadeu", "000.000.000-14", "Tadeu10@gmail.com", "joinha");

        // Lista de Clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        
        ViewBag.listaClientes = listaClientes;

        // Fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "Artur", "000.000.000-11", "Arthur10@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(01, "Tomás", "000.000.000-12", "Tomas10@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(01, "Carlos", "000.000.000-13", "Carlos10@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(01, "Tadeu", "000.000.000-14", "Tadeu10@gmail.com");
    
        //lista de fornecedor
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
