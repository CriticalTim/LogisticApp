using Microsoft.EntityFrameworkCore;

namespace LogisticApp.Data
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
                _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product productFromDB = await _context.Products.SingleOrDefaultAsync(x => x.ProductId == id);
            return productFromDB;
        }

        public async Task<bool> InsertProducts(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateProducts(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteProducts(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
