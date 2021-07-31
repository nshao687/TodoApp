using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepository
    {
        private static List<Todo> _todos = new List<Todo>();
        public TodoRepositoryInMemory()
        {
            _todos = new List<Todo>
            {
                new Todo {Id = 1, Title = "ASP.NET cor 학습", IsDone = false},
                new Todo {Id = 2, Title = "BLAZOR 학습", IsDone = false},
                new Todo {Id = 3, Title = "C# 학습", IsDone = true},
            };
        }
        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }
}
