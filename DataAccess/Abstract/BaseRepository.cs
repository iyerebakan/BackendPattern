using Core.Event;
using Entity;
using Entity.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public class BaseRepository<T> where T : BaseEntity
    {
        public void SaveChanges(T entity)
        {
            foreach (IEvent @event in entity.Events)
            {
                Console.WriteLine(new string('*', 50));
                Console.WriteLine($"Request Json {@event.GetType().Name} Start");
                @event.Execute();
                Console.WriteLine($"Request Json {@event.GetType().Name} End ");
            }
        }

        public bool Add(T entity)
        {
            Console.WriteLine($"Product Eklendi {JsonConvert.SerializeObject(entity)}");
            this.SaveChanges(entity);
            return true;
        }

        public bool Delete(T entity)
        {
            Console.WriteLine($"Product Silindi {JsonConvert.SerializeObject(entity)}");
            this.SaveChanges(entity);
            return true;
        }
    }
}
