using System;
using System.Collections.Generic;

namespace Todo.Models
{
    public class TodoItem
    {
        public int intID { get; set; }
        public string Name { get; set; }
        public string isComplete { get; set; }

        public static implicit operator List<object>(TodoItem v)
        {
            throw new NotImplementedException();
        }
    }
}
