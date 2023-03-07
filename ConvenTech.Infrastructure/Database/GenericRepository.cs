
using ConvenTech.CrossCutting.GenericRepository;
using ConvenTech.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ConvenTech.Infrastructure.Database
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }

        public GenericRepository(ConvenTechContext context)
        {
            this.Context = context;
            this.Query = Context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await Query.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            Query.Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllByCriteria(Expression<Func<T, bool>> expression)
        {
            return await Query
                             .Where(expression)
                             .ToListAsync();
        }

        public async Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression)
        {
            return await Query.FirstOrDefaultAsync(expression);

        }

        public async Task<T> Get(object id)
        {
            return await Query.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Query.ToListAsync();
        }

        public async Task Save(T entity)
        {
            await Query.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            Query.Update(entity);
            await Context.SaveChangesAsync();

        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await Query.AnyAsync(expression);
        }
    }
}
