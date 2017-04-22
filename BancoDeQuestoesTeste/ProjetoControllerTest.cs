using System;
using System.Collections.Generic;
using BancoDeQuestoes.Mvc.Controllers;
using Moq;
using NUnit.Framework;

namespace BancoDeQuestoesTeste
{
    [TestFixture]
	public class ProjetoControllerTest
	{
		//private ProjetoController _projeto;
		//private MockRepository _repository;
		//private Mock<IProjetoAppService> _iprojetoAppServiceMock;
	
		//private Mock<IAppServiceBase<Projeto>> _appServiceBase;

		[SetUp]
		public void Setup()
		{
			//_repository = new MockRepository(MockBehavior.Strict);
			//_iprojetoAppServiceMock = _repository.Create<IProjetoAppService>();
		
			// _appServiceBase = new Mock<IAppServiceBase<Projeto>>();
			
			
		}

		[Test]
		public void TesteIndex()
		{
			////Arrange
			//_iprojetoAppServiceMock.Setup(a=>a.GetAll()).Returns(It.IsAny<IEnumerable<Projeto>>()).Verifiable();

			////Act
			//_projeto.Index();

			////Assert
			//_repository.VerifyAll();
		}

		[Test]
		public void TesteDetails()
		{
			////Arrange
			//_iprojetoAppServiceMock.Setup(a => a.GetById(1)).Returns(It.IsAny<Projeto>()).Verifiable();

			////Act
			//_projeto.Details(1);

			////Assert
			//_repository.VerifyAll();
		}

		[Test]
		public void TesteChamarPaginaCreate()
		{
			////Act
			//_projeto.Create();

			////Assert
			//_repository.VerifyAll();
		}

	    [Test]
	    public void TesteCreateNovoProjeto()
	    {

	        //Arrange
	        //var dadosProjeto = new Projeto()
	        //{
	        //	Ativo = true,
	        //	CodigoProjeto = 1,
	        //	NomeProjeto = "TesteProjeto",
	        //	ProjetoId = new Guid()
	        //};
	        //var dadosViewModel = new ProjetoViewModel()
	        //{
	        //	Ativo = true,
	        //	CodigoProjeto = 1,
	        //	NomeProjeto = "TesteProjeto",
	        //	ProjetoId = new Guid()

	        //};


	        //	_appServiceBase.Setup(a => a.GetAll()).Returns(It.IsAny<IEnumerable<Projeto>>());
	        //	//_mapperWrapperMock.Setup(a => a.Map(typeof(Projeto), typeof(ProjetoViewModel),_appServiceBase.Object.GetAll())).Returns(It.IsAny<object>()).Verifiable();

	        //	_iprojetoAppServiceMock.Setup(a=>a.Add(dadosProjeto)).Verifiable();

	        //	//Act
	        //	_projeto.Create(dadosViewModel);

	        //	//Assert
	        //	_repository.VerifyAll();
	        //}
	    }
	}
}
