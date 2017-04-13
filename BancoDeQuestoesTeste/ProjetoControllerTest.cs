using System.Collections.Generic;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.Controllers;
using BancoDeQuestoes.Mvc.ViewModels;
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
		private Mock<IMappingEngine> _mapperMock;

		[SetUp]
		public void Setup()
		{
			_repository = new MockRepository(MockBehavior.Strict);
			_iprojetoAppServiceMock = _repository.Create<IProjetoAppService>();
			_projeto = new ProjetoController(_iprojetoAppServiceMock.Object);
			_mapperMock = _repository.Create<IMappingEngine>();
		}

		[Test]
		public void TesteIndex()
		{
			//Arrange
			_iprojetoAppServiceMock.Setup(a=>a.GetAll()).Returns(It.IsAny<IEnumerable<Projeto>>()).Verifiable();

			//Act
			_projeto.Index();

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteDetails()
		{
			//Arrange
			_iprojetoAppServiceMock.Setup(a => a.GetById(1)).Returns(It.IsAny<Projeto>()).Verifiable();

			//Act
			_projeto.Details(1);

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
			var dadosProjeto = new Projeto()
			{
				Ativo = true,
				CodigoProjeto = 1,
				NomeProjeto = "TesteProjeto",
				ProjetoId =1 
			};
			var dadosViewModel = new ProjetoViewModel()
			{
				Ativo = true,
				CodigoProjeto = 1,
				NomeProjeto = "TesteProjeto",
				ProjetoId = 1

			};
			_mapperMock.Setup(a=>a.Map(dadosViewModel,dadosProjeto)).Returns(It.IsAny<Projeto>()).Verifiable();
			_iprojetoAppServiceMock.Setup(a=>a.Add(dadosProjeto)).Verifiable();

			//Act
			_projeto.Create(dadosViewModel);

			//Assert
			_repository.VerifyAll();
		}
	}
}
