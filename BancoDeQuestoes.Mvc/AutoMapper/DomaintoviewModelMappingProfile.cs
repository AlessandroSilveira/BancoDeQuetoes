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
			
			Mapper.CreateMap<AreaViewModel, Area>();
			Mapper.CreateMap<ProjetoViewModel, Projeto>();
			Mapper.CreateMap<DisciplinaViewModel, Disciplina>();
			Mapper.CreateMap<BancaViewModel, Banca>();
			Mapper.CreateMap<RevisorViewModel, Revisor>();
			Mapper.CreateMap<FormacaoRevisorViewModel, FormacaoRevisor>();
		}
	}
}