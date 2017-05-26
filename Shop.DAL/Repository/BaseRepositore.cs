using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Shop.DAL.Context;
using Shop.Infra.Model;

namespace Shop.DAL.Repository
{
	/// <summary>
	/// The models repository
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class BaseRepository<T> where T : BaseEntity, new()
	{
		/// <summary>
		/// The db context
		/// </summary>
		private readonly ShopContext _dbContext;

		/// <summary>
		/// The current db table
		/// </summary>
		private readonly DbSet<T> _dbSet;

		/// <summary>
		/// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
		/// </summary>
		/// <param name="shopContext">
		/// The Db context.
		/// </param>
		protected BaseRepository(ShopContext shopContext)
		{
			_dbContext = shopContext;
			_dbSet = _dbContext.Set<T>();
		}

		/// <summary>
		/// Gets the _shopContext.
		/// </summary>
		protected ShopContext DbContext
		{
			get
			{
				return _dbContext;
			}
		}

		/// <summary>
		/// Gets the current db set.
		/// </summary>
		protected IDbSet<T> DbSet
		{
			get
			{
				return _dbSet;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity"></param>
		public virtual void Add(T entity)
		{
			_dbSet.Add(entity);
			_dbContext.SaveChanges();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity"></param>
		public virtual void Update(T entity)
		{
			_dbSet.Attach(entity);
			_dbContext.Entry(entity).State = EntityState.Modified;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity"></param>
		public virtual void Delete(T entity)
		{
			_dbSet.Remove(entity);
			_dbContext.SaveChanges();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="predicate"></param>
		public virtual void Delete(Expression<Func<T, bool>> predicate)
		{
			IEnumerable<T> objects = _dbSet.Where<T>(predicate).AsEnumerable();
			foreach (var obj in objects)
				_dbSet.Remove(obj);
			_dbContext.SaveChanges();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public virtual T GetById(int id)
		{
			return _dbSet.Find(id);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public virtual IEnumerable<T> GetAll()
		{
			return _dbSet.ToList();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate)
		{
			return _dbSet.Where(predicate).ToList();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public virtual T Get(Expression<Func<T, bool>> predicate)
		{
			return _dbSet.Where(predicate).FirstOrDefault<T>();
		}

		#region Async
		/*
		/// <summary>
		/// 
		/// </summary>
		/// <param name="enity"></param>
		/// <returns></returns>
		public virtual async Task AddAsync(T enity)
		{
			DbSet.Add(enity);
			await _dbContext.SaveChangesAsync().ConfigureAwait(false);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public virtual async Task UpdateAsync(T entity)
		{
			_dbSet.Attach(entity);
			_dbContext.Entry(entity).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync().ConfigureAwait(false);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public virtual async Task DeleteAsync(T entity)
		{
			_dbSet.Attach(entity);
			_dbSet.Remove(entity);
			await _dbContext.SaveChangesAsync().ConfigureAwait(false);
		}

		/// <summary>
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public virtual async Task DeleteAsync(Expression<Func<T, bool>> predicate)
		{
			var objects = _dbSet.Where(predicate).AsEnumerable();
			foreach (var obj in objects)
			{
				_dbSet.Remove(obj);
				await _dbContext.SaveChangesAsync().ConfigureAwait(false);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public virtual async Task<T> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id).ConfigureAwait(false);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public virtual async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
		{
			return await _dbSet.Where(predicate).FirstOrDefaultAsync<T>().ConfigureAwait(false);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public virtual async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync().ConfigureAwait(false);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public virtual async Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> predicate)
		{
			return await _dbSet.Where(predicate).ToListAsync().ConfigureAwait(false);
		}
		*/
#endregion

	}
}