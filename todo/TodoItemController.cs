using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoItems;
//using Controller.Models;

namespace TodoItems.Controllers
{

    [Route("api/todolist/{listId}/tasks")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private TodoItemService todoItemService;

        public TodoItemController(TodoItemService service)
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
        public ActionResult<TodoItem> PostTaskById(int listId, TodoItem todoItem)
        {
            TodoItem createdItem = todoItemService.Create(todoItem, listId);

            return Created($"api/todolist/{listId}/tasks/{createdItem.Id}", createdItem);
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