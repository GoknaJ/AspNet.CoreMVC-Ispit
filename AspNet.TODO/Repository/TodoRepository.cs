using AspNet.TODO.Models;

namespace AspNet.TODO.Repository;

public class TodoRepository
{
    public static List<Todo> _todos;

    public List<Todo> GetTodos()
    {
        List<Todo> todos = new List<Todo>
            {
                new Todo { Id = 1, Name = "PARCIJALNI ISPIT – Osnove baza podataka", IsCompleted = true },
                new Todo { Id = 2, Name = "PARCIJALNI ISPIT – C# i .NET Framework: napredno korištenje", IsCompleted = true },
                new Todo { Id = 3, Name = "PARCIJALNI ISPIT – LINQ", IsCompleted = true },
                new Todo { Id = 4, Name = "PARCIJALNI ISPIT – ASP.NET Core MVC i Visual Studio", IsCompleted = true },
                new Todo { Id = 5, Name = "PARCIJALNI ISPIT – ASP.NET Core MVC u praksi: Postavljanje projekta", IsCompleted = false }
            };
        return todos;
    }
}