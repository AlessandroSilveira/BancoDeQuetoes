using System;
using BancoDeQuestoes.Infra.Data.Context;
using BancoDeQuestoes.Infra.Data.Interfaces;

namespace BancoDeQuestoes.Infra.Data.UoW
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly Db _context;
		private bool _disposed;

		public UnitOfWork(Db context)
		{
			_context = context;
		}

		public void BeginTransaction()
		{
			_disposed = false;
		}

		public void Commit()
		{
			_context.SaveChanges();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed && disposing)
				_context.Dispose();
			_disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}