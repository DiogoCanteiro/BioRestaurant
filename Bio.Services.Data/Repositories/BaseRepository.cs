using Bio.Services.Data.DbContexts;
using Bio.Services.Data.DbModels;
using Bio.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio.Services.Data.Repositories
{
    public class BaseRepository : IBaseRepository
    {

        protected readonly ApplicationDbContext _db;

        public BaseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<T> Create<T>(T entity) where T : class
        {
            _db.Add(entity);

            return await SaveChanges() ? entity : null;
        }

        public async Task<bool> Delete<T>(T entity) where T : class
        {
            _db.Remove(entity);

            return await SaveChanges() ? true : false;
        }

        public async Task<T> Update<T>(T entity) where T : class
        {
            _db.Update(entity);

            return await SaveChanges() ? entity : null;
        }

        private async Task<bool> SaveChanges()
        {
            return await _db.SaveChangesAsync() > 0;
        }
    }
}
