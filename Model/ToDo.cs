using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [KnownType(typeof(ToDoUser))]
    public class ToDo
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }  
        public virtual ToDoUser CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    
}
