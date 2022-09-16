using LaptopsOnline.Data;
using LaptopsOnline.Models;

namespace LaptopsOnline.Services
{
        public class SqlCarouselsRepository : IRepository<Carousel>
        {
            private LaptopsOnlineDbContex _context;

            public SqlCarouselsRepository(LaptopsOnlineDbContex context)
            {
                _context = context;
            }
            public bool Add(Carousel item)
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

            public bool Delete(Carousel item)
            {
                try
                {
                    Carousel carousel = Get(item.Id);
                    if (carousel != null)
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

            public bool Edit(Carousel item)
            {
                throw new NotImplementedException();
            }

            public Carousel Get(int id)
            {
                if (_context.Carousels.Count(x => x.Id == id) > 0)
                {
                    return _context.Carousels.First(x => x.Id == id);
                }
                else { return null; }
            }

            public IEnumerable<Carousel> GetAll()
            {
                return _context.Carousels;
            }
        
    }
}
