using Microsoft.EntityFrameworkCore;
using Simple.Domain;
using Simple.Domain.Entities;

namespace Simple.Infrastructure
{
    public class SaleRepository : ISaleRepository
    {
        private readonly AppDbContext _context;

        public SaleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Sale sale)
        {
            _context.Add(sale);
            await _context.SaveChangesAsync();
        }

        public async Task<Sale> GetByIdAsync(Guid id)
        {
            return await _context.Sales
                 .Include(s => s.Items)
                 .FirstOrDefaultAsync(s => s.Id == id);
        }
        public async Task<IEnumerable<Sale>> GetAllAsync()
        {
            return await _context.Sales
                 .Include(s => s.Items).ToListAsync();
        }

        public async Task UpdateAsync(Sale sale)
        {
            _context.Update(sale);
            await _context.SaveChangesAsync();
        }
    }
}
