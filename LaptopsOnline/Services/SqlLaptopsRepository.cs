using LaptopsOnline.Data;
using LaptopsOnline.Models;

namespace LaptopsOnline.Services
{
    public class SqlLaptopsRepository : IRepository<Laptop>
    {
        private LaptopsOnlineDbContex _context;

        public SqlLaptopsRepository(LaptopsOnlineDbContex context) 
        {
            _context = context;
        }
        public bool Add(Laptop item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
                return true;    
            }
            catch (Exception)
            {
                return false;   
            }
        }

        public bool Delete(Laptop item)
        {
            try
            {
                Laptop laptop = Get(item.Id);
                if(laptop != null)
                {
                    _context.Remove(item);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Laptop item)
        {
            throw new NotImplementedException();
        }

        public Laptop Get(int id)
        {
            if(_context.Laptops.Count(x => x.Id == id)>0)
            {
                return _context.Laptops.First(x => x.Id == id);
            }
            else { return null; }
        }

        public IEnumerable<Laptop> GetAll()
        {
            return _context.Laptops;
        }
    }
}
