using AutoMapper;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.AutoMapper
{
	public class DomaintoviewModelMappingProfile : Profile
	{
		public override string ProfileName
		{
			get { return "ViewModelToDomainMappings"; }
		}

		protected override  void Configure()
		{
			Mapper.CreateMap<ClienteViewModel, Cliente>();
			Mapper.CreateMap<ProdutoViewModel, Produto>();

		}
	}
}