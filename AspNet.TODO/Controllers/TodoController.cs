using AspNet.TODO.Repository;
using Microsoft.AspNetCore.Mvc;
using AspNet.TODO.Models;

namespace AspNet.TODO.Controllers;

public class TodoController : Controller
{
    private readonly TodoRepository _repository;
    public TodoController(TodoRepository repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
    {
        var todos = _repository.GetTodos();
        return View(todos);
    }
}
