using Microsoft.AspNetCore.Mvc;
using DzBook.Models;

namespace DzBook.Controllers;

public class BooksController : Controller
{
    private static readonly List<Book> _books = new()
    {
        new() { Id = 1, Title = "Мастер и Маргарита", Author = "М. Булгаков", Year = 1967, Genre = "Роман",
                Description = "Философский роман о добре и зле, любви и трусости." },
        new() { Id = 2, Title = "Преступление и наказание", Author = "Ф. Достоевский", Year = 1866, Genre = "Роман",
                Description = "Психологическая драма о нравственном выборе." },
        new() { Id = 3, Title = "Война и мир", Author = "Л. Толстой", Year = 1869, Genre = "Эпопея",
                Description = "Эпопея о судьбах людей в эпоху наполеоновских войн." },
        new() { Id = 4, Title = "Тихий Дон", Author = "М. Шолохов", Year = 1940, Genre = "Эпопея",
                Description = "Судьба казачества в годы войны и революции." },
    };

    public IActionResult Index() => View(_books);

    public IActionResult Details(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        return book is null ? NotFound() : View(book);
    }
}