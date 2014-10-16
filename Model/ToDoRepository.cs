using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ToDoRepository : IToDoRepository
    {
        ToDoPlannerDbContext _toDoPlannerDbContext;

        public ToDoRepository(ToDoPlannerDbContext toDoPlannerDbContext)
        {
            _toDoPlannerDbContext = toDoPlannerDbContext;
        }

        public IQueryable<ToDo> GetAll()
        {
            //var ret = _toDoPlannerDbContext.ToDos.Include("CreatedBy");
            var ret = _toDoPlannerDbContext.ToDos.ToList<ToDo>().AsQueryable<ToDo>();
            return ret;
        }

        public ToDo GetById(Guid Id)
        {
            return _toDoPlannerDbContext.ToDos.Where(todo => todo.Id == Id).FirstOrDefault();
        }


        public ToDo Create(ToDo newentity)
        {
            return _toDoPlannerDbContext.ToDos.Add(newentity);
        }


        public bool Save()
        {
            try
            {
                return _toDoPlannerDbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
            
        }


        public bool Delete(ToDo entity)
        {
            var todelete = this.GetById(entity.Id);
            if (todelete != null)
            {
                //_toDoPlannerDbContext.ToDos.Remove(todelete);

                try
                {
                    ((IObjectContextAdapter)_toDoPlannerDbContext).ObjectContext.DeleteObject(todelete);
                    //return _toDoPlannerDbContext.SaveChanges() > 0;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
