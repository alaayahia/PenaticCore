using Microsoft.EntityFrameworkCore;
using PenaticCore.Domain.Models;
using PenaticCore.Infrastructure.Data;
using PenaticCore.Infrastructure.Helpers;
using PenaticCore.Infrastructure.Utils;
using System.Linq.Expressions;

namespace PenaticCore.Application.Common
{
    //IRepository Base
    public interface IRepositoryBase<T> where T : EntityBase
    {
        Task<T> AddAsync(T item);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
       
        Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate, params string[] includeProperties);
        IQueryable<T> TQueryable { get; set; }

    }

    //RepositoryBase
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        private readonly AppDbContext _context;
        protected readonly DbSet<T> table;

        private IQueryable<T> _tqueryable;
        private readonly MapperHelper _mapperHelper;

        public IQueryable<T> TQueryable
        {
            get => _tqueryable;
            set { _tqueryable = value ?? throw new ArgumentNullException(nameof(value), "Not Allowed To Be Null"); }
        }

        public RepositoryBase(AppDbContext context, MapperHelper mapperHelper)
        {
            _context = context;
            _mapperHelper = mapperHelper;
            table = _context.Set<T>();
            _tqueryable = _context.Set<T>();

        }

        public virtual async Task<T> AddAsync(T item)
        {
            item.Id = IdGenerator.GetNextId().ToString();
            item.CreatedAt = DateTime.Now;
            item.UpdatedAt = DateTime.Now;
            item.CreatedBy = "1";
            item.UpdatedBy = "1";
            item.IsActive = true;
            await table.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }
        public virtual async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await TQueryable.Where(predicate).ToListAsync();

        }
        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _tqueryable.SingleOrDefaultAsync(predicate);

        }
        public async Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate, params string[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().IgnoreAutoIncludes();

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.Where(predicate).ToListAsync();
        }










    }
}
