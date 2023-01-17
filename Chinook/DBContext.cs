namespace Chinook
{
    public class DBContext
    {
        private ChinookContext _context;
        public DBContext(ChinookContext context)
        {
            _context = context;
        }
    }
}