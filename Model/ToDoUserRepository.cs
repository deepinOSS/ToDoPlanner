using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IToDoUserRepository:IRepository<ToDoUser,Guid>
    {
        ToDoUser GetByName(string firstName, string lastName);
    }

    public class ToDoUserRepository : IToDoUserRepository
    {
        ToDoPlannerDbContext _toDoPlannerDbContext;

        public ToDoUserRepository(ToDoPlannerDbContext toDoPlannerDbContext)
        {
            _toDoPlannerDbContext = toDoPlannerDbContext;
        }



        public IQueryable<ToDoUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public ToDoUser GetById(Guid Id)
        {
            return _toDoPlannerDbContext.ToDoUsers.Where(u => u.Id == Id).FirstOrDefault();
        }

        public ToDoUser Create(ToDoUser newentity)
        {
            throw new NotImplementedException();
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

        public ToDoUser GetByName(string firstName, string lastName)
        {
            var ret = _toDoPlannerDbContext.ToDoUsers.Where(u => u.FirstName == firstName && u.LastName == lastName).FirstOrDefault();
            return ret;
        }


        public bool Delete(ToDoUser entity)
        {
            var todelete = this.GetById(entity.Id);
            if (todelete != null)
            {
                

                try
                {
                    ((IObjectContextAdapter)_toDoPlannerDbContext).ObjectContext.DeleteObject(todelete);
                    //_toDoPlannerDbContext.SaveChanges();
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
