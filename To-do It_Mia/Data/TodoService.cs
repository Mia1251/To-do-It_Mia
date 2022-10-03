using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It_Mia.Models;

namespace To_do_It_Mia.Data
{
    public class TodoService
    {
        private static Todo[] todoList = new Todo[0];

        public Todo[] TodoList
        {
            get
            {
                return todoList;
            }
            set
            {
                todoList = value;
            }
        }
        public int Size()
        {
            return todoList.Length;
        }
        public Todo[] FindAll()
        {
            return TodoList;
        }
        public Todo FindById(int todoId)
        {
            return todoList[todoId];
        }
        public Todo addTodo(string Description)
        {
            Todo newTodo = new Todo(PersonSequencer.NextPersonId(), Description);
            Array.Resize(ref todoList, todoList.Length + 1);
            todoList[todoList.Length - 1] = newTodo;
            return newTodo;
        }
        public void Clear()
        {
            todoList = new Todo[0];
        }
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            Todo[] todoList = new Todo[0];

            for (int i = 0; i < todoList.Length; i++)
            {
                if (todoList[i].Done == doneStatus)
                {
                    todoList.Append(todoList[i]);
                }
            }
            return (Todo[]) todoList.ToArray();
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            Todo[] todoList = new Todo[0];

            for (int i =0; i < todoList.Length; i++)
            {
                if (todoList[i].Assignee == assignee)
                {
                    todoList.Append(todoList[i]);
                }
            }
            return (Todo[]) todoList.ToArray();
        }
        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] todoList = new Todo[0];

            for (int i = 0; i < todoList.Length; i++)
            {
                if (todoList[i].Assignee == null)
                {
                    todoList.Append(todoList[i]);
                }
            }
            return (Todo[])todoList.ToArray();
        }
        public Todo[] removeObjectFromArray(int index)
        {
            Todo[] newTodoList = new Todo[0];

            for (int i = 0; i < todoList.Length; i++)
            {
                if (i != index)
                {
                    Array.Resize(ref todoList, todoList.Length);
                    newTodoList.CopyTo(todoList, 0);
                }
            }
            return newTodoList;
        }
    }
}
