using BancoDeQuestoes.Controllers;
using BancoDeQuestoes.Interfaces;
using BancoDeQuestoes.Models;
using Moq;
using NUnit.Framework;

namespace BancoDeQuestoes.Testes.Controllers
{
	[TestFixture]
	public class ProjetoControllerTest
	{
		private ProjetoController _projetoController;
		private Mock<IProjetoRepository> _projetoRepoMock;

		[SetUp]
		public void Setup()
		{
			_projetoRepoMock = new Mock<IProjetoRepository>();
		}

		[Test]
		public void Index()
		{
			_projetoController = new ProjetoController(_projetoRepoMock.Object);

			_projetoRepoMock.Setup(m=>m.List()).Verifiable();

			_projetoController.Index();

			_projetoRepoMock.Verify();
		}

		[Test]
		public void Details()
		{
			_projetoController = new ProjetoController(_projetoRepoMock.Object);

			_projetoRepoMock.Setup(m=>m.Find(1)).Returns(It.IsAny<INSCR_BQ_PROJETO>()).Verifiable();

			_projetoController.Details(1);

			_projetoRepoMock.Verify();
		}

		[Test]
		public void CallCreatePage()
		{
			_projetoController = new ProjetoController(_projetoRepoMock.Object);

			_projetoController.Create();

			_projetoRepoMock.Verify();
		}

		[Test]
		public void InserirCreate()
		{
			_projetoController = new ProjetoController(_projetoRepoMock.Object);

			var dados = new INSCR_BQ_PROJETO()
			{
				DESC_ATIVO = "S",
				DESC_PROJETO = "Teste",
				COD_PROJETO = 1
			};

			_projetoRepoMock.Setup(m => m.Add(dados)).Verifiable();

			_projetoController.Create();

			
		}

		[Test]
		public void Edit()
		{
			_projetoController = new ProjetoController(_projetoRepoMock.Object);

			_projetoRepoMock.Setup(m => m.Find(1)).Returns(It.IsAny<INSCR_BQ_PROJETO>()).Verifiable();

			_projetoController.Edit(1);

			_projetoRepoMock.Verify();
		}

		[Test]
		public void SalvarEdit()
		{
			_projetoController = new ProjetoController(_projetoRepoMock.Object);

			var dados = new INSCR_BQ_PROJETO()
			{
				DESC_ATIVO = "S",
				DESC_PROJETO = "Teste",
				COD_PROJETO = 1
			};
			_projetoRepoMock.Setup(m => m.Update(dados)).Verifiable();

			_projetoController.Edit(1);

			
		}

		[Test]
		public void Delete()
		{
			_projetoController = new ProjetoController(_projetoRepoMock.Object);

			_projetoRepoMock.Setup(m => m.Find(1)).Returns(It.IsAny<INSCR_BQ_PROJETO>()).Verifiable();

			_projetoController.Edit(1);

			_projetoRepoMock.Verify();
		}

		[Test]
		public void ConfirmDelete()
		{
			_projetoController = new ProjetoController(_projetoRepoMock.Object);

			var dados = new INSCR_BQ_PROJETO();

			_projetoRepoMock.Setup(m => m.Remove(dados)).Verifiable();

			_projetoController.Edit(1);

			
		}

		[Test]
		public void Dispose()
		{
			_projetoController = new ProjetoController(_projetoRepoMock.Object);

			_projetoRepoMock.Setup(m => m.Dispose()).Verifiable();

			_projetoController.Edit(1);

			
		}
	}
	
}
