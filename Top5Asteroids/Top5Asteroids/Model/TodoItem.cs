using System;
using System.Collections.Generic;
using System.Text;

namespace Top5Asteroids
{
    class TodoItem
    {
        public string TodoText { get; set; }
        public bool Complete { get; set; }

        public TodoItem(string _todoText, bool _complete)
        {
            this.TodoText = _todoText;
            this.Complete = _complete;
        }

    }
}
