using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class ToDoPlannerController : ApiController
    {
        //IToDoRepository _toDoRepository;
        //IToDoUserRepository _toDoUserRepository;
        
        IUnitOfWorkToDoPlanner _uowtodo;

        //public ToDoPlannerController(IToDoRepository toDoRepository, IToDoUserRepository toDoUserRepository)
        //{
        //    _toDoRepository = toDoRepository;
        //    _toDoUserRepository = toDoUserRepository;
        //}

        public ToDoPlannerController(IUnitOfWorkToDoPlanner uowtodo)
        {
            _uowtodo = uowtodo;
        }
        
        // GET api/<controller>
        public IEnumerable<ToDo> Get()
        {
            //return _toDoRepository.GetAll();
            return _uowtodo.GetAllToDos();
        }

        // GET api/<controller>/5
        public ToDo Get(Guid id)
        {
            var ret = _uowtodo.GetToDoById(id);
            return ret;
        }

        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{

        //}

        // POST api/<controller>
        public ToDo Post(ToDo newToDo)
        {
            //return null;
            
            //var _newToDo = newToDo;

            ////get the user
            ////var user = _toDoUserRepository.GetById(newToDo.CreatedBy.Id);
            //var user = _toDoUserRepository.GetByName(newToDo.CreatedBy.FirstName, newToDo.CreatedBy.LastName);

            //_newToDo.Id = Guid.NewGuid();
            //_newToDo.CreatedOn = DateTime.Now;
            //_newToDo.CreatedBy = user;

            //_newToDo = _toDoRepository.Create(_newToDo);
            //var saveResult = _toDoRepository.Save();

            //if (saveResult) return _newToDo;
            //else return null;

            return _uowtodo.CreateToDo(newToDo);

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public bool Delete(Guid id)
        {
            return _uowtodo.DeleteToDo(id);
        }
    }
}