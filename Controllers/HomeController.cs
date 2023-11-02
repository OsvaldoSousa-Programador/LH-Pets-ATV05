using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPetATV5.Models;

namespace LHPetATV5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {

        // instancias do tipo cliente.
        Cliente cliente01 = new Cliente(01, "Abelhiodo do Mel", "054.748.362-78", "abelhiodoM@gmail.com", "Pandonildo");
        Cliente cliente02 = new Cliente(02, "José da Ameixa", "054.748.362-75", "josedaameixa@gmail.com", "Juvenildo");
        Cliente cliente03 = new Cliente(03, "Maria Abertina", "054.748.362-74", "mariaalbertina@gmail.com", "Passarildo");
        Cliente cliente04 = new Cliente(04, "Cleber Augusto", "054.748.362-77", "cleberaugusto@gmail.com", "Capivarilda");
        Cliente cliente05 = new Cliente(05, "Barbara Sousa", "054.748.362-71", "barbarasousa@gmail.com", "Caramelonildo");

        // Lista de Clientes e atribuir os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente01);
        listaClientes.Add(cliente02);
        listaClientes.Add(cliente03);
        listaClientes.Add(cliente04);
        listaClientes.Add(cliente05);

        ViewBag.listaClientes = listaClientes;

        // instancias do tipo fornecedores.
        Fornecedor fornecedor1 = new Fornecedor(01, "Forne 01", "054.748.362-78", "forne01@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Forne 02", "054.748.362-78", "forne02@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Forne 03", "054.748.362-78", "forne03@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Forne 04", "054.748.362-78", "forne04@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Forne 05", "054.748.362-78", "forne05@gmail.com");

        // Lista de fonecedores e atribuir os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        
        return View();



    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
