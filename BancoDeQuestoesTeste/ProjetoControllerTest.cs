using System;
using System.Collections.Generic;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Mvc.Controllers;
using Moq;
using NUnit.Framework;

namespace BancoDeQuestoesTeste
{
	[TestFixture]
	public class ProjetoControllerTest
	{
		private ProjetoController _projeto;
		private MockRepository _repository;
		private Mock<IProjetoAppService> _iprojetoAppServiceMock;

		[SetUp]
		public void Setup()
		{
			_repository = new MockRepository(MockBehavior.Strict);
			_iprojetoAppServiceMock = _repository.Create<IProjetoAppService>();
			_projeto = new ProjetoController(_iprojetoAppServiceMock.Object);
		}

		[Test]
		public void TesteIndex()
		{
			//Arrange
			_iprojetoAppServiceMock.Setup(a => a.GetAll()).Returns(It.IsAny<IEnumerable<ProjetoViewModel>>()).Verifiable();

			//Act
			_projeto.Index();

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteDetails()
		{
			//Arrange

			Guid id = new Guid();

			_iprojetoAppServiceMock.Setup(a => a.GetById(id)).Returns(It.IsAny<ProjetoViewModel>()).Verifiable();

			//Act
			_projeto.Details(id);

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteChamarPaginaCreate()
		{
			//Act
			_projeto.Create();

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteCreateNovoProjeto()
		{

			//Arrange

			var dadosViewModel = new ProjetoViewModel()
			{
				Ativo = true,
				CodigoProjeto = 1,
				NomeProjeto = "TesteProjeto",
				ProjetoId = new Guid()
			};


			_iprojetoAppServiceMock.Setup(a => a.Add(dadosViewModel)).Returns(It.IsAny<ProjetoViewModel>()).Verifiable();

			//Act
			_projeto.Create(dadosViewModel);

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteCreateNovoProjetoFalho()
		{
			//Arrange
			var dadosViewModel = new ProjetoViewModel()
			{
				Ativo = true,
				CodigoProjeto = 1,
				NomeProjeto = "",
				ProjetoId = new Guid()
			};

			_iprojetoAppServiceMock.Setup(a => a.Add(dadosViewModel)).Returns(It.IsAny<ProjetoViewModel>()).Verifiable();

			//Act
			_projeto.Create(dadosViewModel);

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteChamarPaginaEdit()
		{
			//Arrange
			var id = new Guid();
			_iprojetoAppServiceMock.Setup(a=>a.GetById(id)).Returns(It.IsAny<ProjetoViewModel>()).Verifiable();

			//Act
			_projeto.Edit(id);

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteEditandoProjeto()
		{
			//Arrange
			var dadosViewModel = new ProjetoViewModel()
			{
				Ativo = true,
				CodigoProjeto = 2,
				NomeProjeto = "TesteProjeto",
				ProjetoId = new Guid()
			};

			_iprojetoAppServiceMock.Setup(a => a.Update(dadosViewModel)).Returns(It.IsAny<ProjetoViewModel>()).Verifiable();

			//Act
			_projeto.Edit(dadosViewModel);

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteChamarPaginaDelete()
		{
			//Arrange
			var id = new Guid();
			_iprojetoAppServiceMock.Setup(a => a.GetById(id)).Returns(It.IsAny<ProjetoViewModel>()).Verifiable();

			//Act
			_projeto.Delete(id);

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteDeletandoProjeto()
		{
			//Arrange
			var id = new Guid();
		
			_iprojetoAppServiceMock.Setup(a => a.Remove(id)).Verifiable();

			//Act
			_projeto.DeleteConfirmed(id);

			//Assert
			_repository.VerifyAll();
		}
	}
}

