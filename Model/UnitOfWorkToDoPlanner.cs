using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UnitOfWorkToDoPlanner:IUnitOfWorkToDoPlanner
    {
        IToDoRepository _IToDoRepository;
        IToDoUserRepository _IToDoUserRepository;

        public UnitOfWorkToDoPlanner(IToDoRepository IToDoRepository,IToDoUserRepository IToDoUserRepository)
        {
            _IToDoRepository = IToDoRepository;
            _IToDoUserRepository = IToDoUserRepository;
        }
        
        public IQueryable<ToDo> GetAllToDos()
        {
            return _IToDoRepository.GetAll();
        }

        public ToDo GetToDoById(Guid Id)
        {
            return _IToDoRepository.GetById(Id);
        }

        public ToDo CreateToDo(ToDo newentity)
        {
            var _newToDo = newentity;

            //get the user
            //var user = _toDoUserRepository.GetById(newToDo.CreatedBy.Id);
            var user = _IToDoUserRepository.GetByName(newentity.CreatedBy.FirstName, newentity.CreatedBy.LastName);

            _newToDo.Id = Guid.NewGuid();
            _newToDo.CreatedOn = DateTime.Now;
            _newToDo.CreatedBy = user;

            _newToDo = _IToDoRepository.Create(_newToDo);
            var saveResult = _IToDoRepository.Save();

            if (saveResult) return _newToDo;
            else return null;
        }

        public bool DeleteToDo(Guid id)
        {
            //get the ToDo
            var delTodo = _IToDoRepository.GetById(id);
            if (delTodo != null)
            {
                var deleted = _IToDoRepository.Delete(delTodo);
                if (deleted) return _IToDoRepository.Save();
                else return false;
            }
            else
                return false;
        }

        public IQueryable<ToDoUser> GetAllToDoUsers()
        {
            return _IToDoUserRepository.GetAll();
        }

        public ToDoUser GetToDoUserById(Guid Id)
        {
            return _IToDoUserRepository.GetById(Id);
        }

        public ToDoUser CreateToDoUser(ToDo newentity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteToDoUser(ToDoUser entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ToDo> GetAllToDosForUser(ToDoUser user)
        {
            return _IToDoRepository.GetAll().Where(t => t.CreatedBy == user);
        }
    }
}
