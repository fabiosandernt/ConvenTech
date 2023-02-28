
namespace ConvenTech.CrossCutting.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
