using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IUnitOfWorkToDoPlanner
    {
        IQueryable<ToDo> GetAllToDos();
        ToDo GetToDoById(Guid Id);
        ToDo CreateToDo(ToDo newentity);
        bool DeleteToDo(Guid id);

        IQueryable<ToDoUser> GetAllToDoUsers();
        ToDoUser GetToDoUserById(Guid Id);
        ToDoUser CreateToDoUser(ToDo newentity);
        bool DeleteToDoUser(ToDoUser entity);

        IQueryable<ToDo> GetAllToDosForUser(ToDoUser user);

    }
}
