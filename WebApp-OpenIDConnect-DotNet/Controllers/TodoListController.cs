using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using TodoSPA.Models;

namespace TodoSPA.Controllers
{
    [Authorize]
    public class TodoListController : ApiController
    {

        // GET: api/TodoList
        public IEnumerable<Todo> Get()
        {
            string owner = ClaimsPrincipal.Current.FindFirst(ClaimTypes.NameIdentifier).Value;
            var descriptions = new List<string> { "This is a fake, todo", "Yup, still fake",
            "I'm a fake todo, today", "Fake todo. Keep moving"};

            IEnumerable<Todo> currentUserToDos = new List<Todo> {
                new Todo{ Description = descriptions[new Random().Next(0, 3)],
                    ID =1, Owner = owner}
            };
            return currentUserToDos;
        }

        // GET: api/TodoList/5
        public Todo Get(int id)
        {
            string owner = ClaimsPrincipal.Current.FindFirst(ClaimTypes.NameIdentifier).Value;
            Todo todo = new Todo { Description = "This is a fake, todo", ID = 1, Owner = owner };
            //db.Todoes.First(a => a.Owner == owner && a.ID == id);
            return todo;
        }

        // POST: api/TodoList
        public void Post(Todo todo)
        {
            string owner = ClaimsPrincipal.Current.FindFirst(ClaimTypes.NameIdentifier).Value;
            todo.Owner = owner;
            //db.Todoes.Add(todo);
            //db.SaveChanges();
        }

        // PUT: api/TodoList
        public void Put(Todo todo)
        {
            string owner = ClaimsPrincipal.Current.FindFirst(ClaimTypes.NameIdentifier).Value;
            //Todo xtodo = db.Todoes.First(a => a.Owner == owner && a.ID == todo.ID);
            //if (todo != null)
            //{
            //    xtodo.Description = todo.Description;
            //    db.SaveChanges();
            //}
        }

        // DELETE: api/TodoList/5
        public void Delete(int id)
        {
            string owner = ClaimsPrincipal.Current.FindFirst(ClaimTypes.NameIdentifier).Value;
            //Todo todo = db.Todoes.First(a => a.Owner == owner && a.ID == id);
            //if (todo != null)
            //{
            //    db.Todoes.Remove(todo);
            //    db.SaveChanges();
            //}
        }
    }
}
