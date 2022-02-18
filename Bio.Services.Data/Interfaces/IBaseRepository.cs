using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Services.Data.Interfaces
{
    public interface IBaseRepository
    {
        Task<T> Create<T>(T entity) where T : class;

        Task<T> Update<T>(T entity) where T : class;

        Task<bool> Delete<T>(T entity) where T : class;
    }
}
