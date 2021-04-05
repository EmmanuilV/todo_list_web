using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoItems;
//using Controller.Models;

namespace TodoItems.Controllers
{

    [Route("api/todolist")]
    [ApiController]
    public class TodoItemSecondController : ControllerBase
    {
        private TodoItemService todoItemService;

        public TodoItemSecondController(TodoItemService service)
        {
            this.todoItemService = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetTodoItems(int listId)
        {
            return todoItemService.GetAll(listId);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItemById(int id)
        {
            // TODO: Your code here
            await Task.Yield();

            return null;
        }

        [HttpPost]
        public ActionResult<TodoItem> PostTaskById(TodoItem todoItem)
        {
            int listId = int.Parse(this.Request.Query["listId"]);

            TodoItem createdItem = todoItemService.Create(todoItem, listId);
            return createdItem;
        }
    
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(int id, TodoItem model)
        {
            // TODO: Your code here
            await Task.Yield();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TodoItem>> DeleteTodoItemById(int id)
        {
            // TODO: Your code here
            await Task.Yield();

            return null;
        }
    }


}