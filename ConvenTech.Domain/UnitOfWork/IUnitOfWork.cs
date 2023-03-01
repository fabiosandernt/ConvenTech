using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenTech.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
