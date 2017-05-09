using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Shop.Infra.Model;

namespace Shop.Infra.Repository
{
	public interface IRepository<T> where T : BaseEntity, new()
	{
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		void Delete(Expression<Func<T, bool>> predicate);
		T GetById(int? id);
		T Get(Expression<Func<T, bool>> predicate);
		IEnumerable<T> GetAll();
		IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate);

		/*
		Task AddAsync(T enity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
		Task DeleteAsync(Expression<Func<T, bool>> predicate);
		Task<T> GetByIdAsync(int id);
		Task<T> GetAsync(Expression<Func<T, bool>> predicate);
		Task<IEnumerable<T>> GetAllAsync();
		Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> predicate);
		*/
	}
}