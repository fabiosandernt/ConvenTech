using System.Linq.Expressions;

namespace ConvenTech.CrossCutting.Repository 
{ 
    public interface IGenericRepository <T> where T : class
    {
        Task Save(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> Get(object id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> FindAllByCriteria(Expression<Func<T, bool>> expression);
        Task<T> FindOneByCriterio(Expression<Func<T, bool>> expression);
    }
}
