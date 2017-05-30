using System;
using System.Collections.Generic;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.Controllers;
using Moq;
using NUnit.Framework;

namespace BancoDeQuestoesTeste
{
	[TestFixture]
	public class DisciplinaControllerTest
	{
		private DisciplinaController _disciplina;
		private MockRepository _repository;
		private Mock<IDisciplinaAppService> _disciplinaAppServiceMock;
		private Mock<IAreaAppService> _areaAppServiceMock;
	    private Mock<IProjetoAppService> _projetoAppMock;
	    private Mock<IMestreAppService> _mestreAppService;

		[SetUp]
		public void Setup()
		{
			_repository = new MockRepository(MockBehavior.Strict);
			_disciplinaAppServiceMock = _repository.Create<IDisciplinaAppService>();
			_areaAppServiceMock = _repository.Create<IAreaAppService>();
            _projetoAppMock = new Mock<IProjetoAppService>();
            _mestreAppService = new Mock<IMestreAppService>();
            _disciplina = new DisciplinaController(_disciplinaAppServiceMock.Object, _areaAppServiceMock.Object,_projetoAppMock.Object, _mestreAppService.Object);
		}

		[Test]
		public void TestIndex()
		{
            //Arrange
            var dadosViewModel = new DisciplinaViewModel()
            {
                Ativo = true,
                Nome = "Teste",
                Area = new Area(),
                AreaId = new Guid(),
                Bibliografia = "teste",
                Descricao = "teste",
                DisciplinaId = new Guid(),
                Nivel = "Alta Compexidade"
            };

            _disciplinaAppServiceMock.Setup(a => a.GetAll()).Returns(It.IsAny<ICollection<DisciplinaViewModel>>()).Verifiable();
            _areaAppServiceMock.Setup(a=>a.GetAll()).Returns(It.IsAny<IEnumerable<AreaViewModel>>()).Verifiable();

			//Act
			_disciplina.Index();

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteDetails()
		{
            //Arrange
            var dadosViewModel = new DisciplinaViewModel()
            {
                Ativo = true,
                Nome = "Teste",
                Area = new Area(),
                AreaId = new Guid(),
                Bibliografia = "teste",
                Descricao = "teste",
                DisciplinaId = new Guid(),
                Nivel = "Alta Compexidade"
            };

            //Arrange
            Guid id = new Guid();
			_disciplinaAppServiceMock.Setup(a => a.GetById(dadosViewModel.DisciplinaId)).Returns(dadosViewModel).Verifiable();

			//Act
			_disciplina.Details(id);

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteChamarPaginaCreate()
		{
			//Arrange
			_areaAppServiceMock.Setup(a=>a.GetAll()).Returns(It.IsAny<IEnumerable<AreaViewModel>>()).Verifiable();
			
			//Act
			_disciplina.Create();

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteCreateNovaDisciplina()
		{

			//Arrange
			var dadosViewModel = new DisciplinaViewModel()
			{
				Ativo = true,
				Nome = "Teste",
				Area = new Area(),
				AreaId = new Guid(),
				Bibliografia = "teste",
				Descricao = "teste",
				DisciplinaId = new Guid(),
				Nivel = "Alta Compexidade"
			};
			_disciplinaAppServiceMock.Setup(a => a.Add(dadosViewModel)).Returns(dadosViewModel).Verifiable();

			//Act
			_disciplina.Create(dadosViewModel);

			//Assert
			_repository.VerifyAll();
		}

		[Test]
		public void TesteCreateNovaDisciplinaFalho()
		{
			//Arrange
			var dadosViewModel = new DisciplinaViewModel()
			{
				Ativo = true,
				Nome = "",
				Area = new Area(),
				AreaId = new Guid(),
				Bibliografia = "",
				Descricao = "",
				DisciplinaId = new Guid(),
				Nivel = ""
			};

			_disciplinaAppServiceMock.Setup(a => a.Add(dadosViewModel)).Returns(dadosViewModel).Verifiable();

			//Act
			_disciplina.Create(dadosViewModel);

			//Assert
			_repository.VerifyAll();
		}
	}
}