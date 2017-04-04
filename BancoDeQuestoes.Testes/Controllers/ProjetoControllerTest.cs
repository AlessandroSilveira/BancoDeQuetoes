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
			_projetoController = new ProjetoController(_projetoRepoMock.Object);
		}

		[Test]
		public void Index()
		{
			_projetoRepoMock.Setup(m=>m.List()).Verifiable();

			_projetoController.Index();

			_projetoRepoMock.Verify();
		}

		[Test]
		public void Details()
		{
			var id = 1;

			INSCR_BQ_PROJETO INSCR_BQ_PROJETO = null;
			_projetoRepoMock.Setup(m=>m.Find(id)).Returns(INSCR_BQ_PROJETO).Verifiable();
			_projetoController.Details(id);


			_projetoRepoMock.Verify();
		}

		[Test]
		public void CallCreatePage()
		{
			_projetoController.Create();

			_projetoRepoMock.Verify();
		}

		[Test]
		public void InserirCreate()
		{
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
			_projetoRepoMock.Setup(m => m.Find(1)).Returns(It.IsAny<INSCR_BQ_PROJETO>()).Verifiable();

			_projetoController.Edit(1);

			_projetoRepoMock.Verify();
		}

		[Test]
		public void SalvarEdit()
		{
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
			_projetoRepoMock.Setup(m => m.Find(1)).Returns(It.IsAny<INSCR_BQ_PROJETO>()).Verifiable();

			_projetoController.Edit(1);

			_projetoRepoMock.Verify();
		}

		[Test]
		public void ConfirmDelete()
		{
			var dados = new INSCR_BQ_PROJETO();

			_projetoRepoMock.Setup(m => m.Remove(dados)).Verifiable();

			_projetoController.Edit(1);
		}

		[Test]
		public void Dispose()
		{
			_projetoRepoMock.Setup(m => m.Dispose()).Verifiable();

			_projetoController.Edit(1);
		}
	}
	
}
