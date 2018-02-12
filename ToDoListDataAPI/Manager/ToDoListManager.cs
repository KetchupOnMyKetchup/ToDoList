using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListDataAPI.Models;
using ToDoListDataAPI.Repo;

namespace ToDoListDataAPI.Business
{
    public class ToDoListManager
    {
        ToDoListRepo _repo = new ToDoListRepo();

        public IEnumerable<ToDoItem> GetTodoItems()
        {
            return _repo.GetTodoItems();
        }

        public void InsertTodoItem(ToDoItem toDoItem)
        {
            _repo.InsertTodoItem(toDoItem);
        }

        public ToDoItem GetTodoItemById(int id)
        {
           return _repo.GetTodoItemById(id);
        }

        public void DeleteById(int id)
        {
            _repo.DeleteById(id);
        }

        public void EditDescription(ToDoItem todo)
        {
            _repo.EditDescription(todo);
        }
    }
}