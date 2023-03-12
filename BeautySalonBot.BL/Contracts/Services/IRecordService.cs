namespace BeautySalonBot.BL.Contracts.Services
{
	public interface IEntityService<T> where T : class
	{
		public T Create(T entity);
		public T Get(Guid entityId);
		public T Update(T entity);
		public void Delete(Guid entityId);
		public IEnumerable<T> GetAll();
		public IEnumerable<T> GetFiltred(Func<T, bool> filter);
	}
}
