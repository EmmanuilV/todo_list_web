using System.Collections.Generic;

namespace TodoItems
{
    public class TodoItemService
    {
        private Dictionary<int, List<TodoItem>> todoLists = new Dictionary<int, List<TodoItem>>();
        private int todoId = 2;
        
        //private int todoListId = 0;

        public TodoItemService()
        {
            todoLists.Add(2, new List<TodoItem>() {
                new TodoItem(){Id = 1, Title = "first task"},
                new TodoItem(){Id = 2, Title = "second task"}
            });

            todoLists.Add(1, new List<TodoItem>() {
                new TodoItem(){Id = 1, Title = "first task"},
                new TodoItem(){Id = 2, Title = "second task"}
            });
        }

        public List<TodoItem> GetAll(int id)
        {
            return todoLists[id];
        }

        //метод, котрий створює номий Item
        public TodoItem Create(TodoItem item, int id)
        {
            item.Id = ++todoId;
            if (todoLists.ContainsKey(id))
            {
                todoLists[id].Add(item);
            }
            else
            {
                //todoListId++;
                todoLists.Add(id, new List<TodoItem>());
                todoId = 0;
                item.Id = ++todoId;
                todoLists[id].Add(item);
            }
            //todoListId++;
            return item;
        }
        public Dictionary<int, List<TodoItem>> GetAllLists()
        {
            return todoLists;
        }

    }


}