﻿using BancoDeQuestoes.Domain.Interfaces.Repository;


namespace BancoDeQuestoes.Application
{
	public class ApplicationService
	{
		private readonly IUnitOfWork _unitOfWork;

		public ApplicationService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}


		public void BeginTransaction()
		{
			_unitOfWork.BeginTransaction();
		}

		public void Commit()
		{
			_unitOfWork.Commit();
		}
	}
}