using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Top5Asteroids
{
    class TodoListViewModel
    {
        public ObservableCollection<TodoItem> todoItems { get; set; }
        public string NewTodoInputValue { get; set; }

        public DateTime Date { get; set; }

        public TodoListViewModel()
        {
            todoItems = new ObservableCollection<TodoItem>();

            todoItems.Add(new TodoItem("todo 1", false));
            todoItems.Add(new TodoItem("todo 2", false));
            todoItems.Add(new TodoItem("todo 3", false));
        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        void AddTodoItem()
        {
            todoItems.Add(new TodoItem(NewTodoInputValue, false));
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(Object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;

            todoItems.Remove(todoItemBeingRemoved);

            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}
