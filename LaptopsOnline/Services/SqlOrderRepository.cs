using LaptopsOnline.Data;
using LaptopsOnline.Models;
using LaptopsOnline.Services;


namespace LittlePacktBookStore.Services
{
    public class SqlOrdersRepository : IRepository<Order>
    {
        private LaptopsOnlineDbContex _context;

        public SqlOrdersRepository(LaptopsOnlineDbContex context)
        {
            _context = context;
        }
        public bool Add(Order item)
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

        public bool Delete(Order Item)
        {
            try
            {
                Order order = Get(Item.Id);
                if (order != null)
                {
                    _context.Remove(Item);
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

        public bool Edit(Order item)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            if (_context.Orders.Count(x => x.Id == id) > 0)
            {
                return _context.Orders.First(x => x.Id == id);
            }
            return null;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders;
        }
    }
}
