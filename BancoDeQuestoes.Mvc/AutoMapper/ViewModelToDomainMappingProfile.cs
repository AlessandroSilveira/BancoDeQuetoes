using AutoMapper;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.AutoMapper
{
	public class ViewModelToDomainMappingProfile :Profile
	{
		public override string ProfileName
		{
			get { return "ViewModelToDomainMappings"; }
		}

		protected override void Configure()
		{
			
			Mapper.CreateMap<Area, AreaViewModel>();
			Mapper.CreateMap<Projeto, ProjetoViewModel>();
			Mapper.CreateMap<Disciplina, DisciplinaViewModel>();
			Mapper.CreateMap<Banca, BancaViewModel>();
			Mapper.CreateMap<Revisor, RevisorViewModel>();
			Mapper.CreateMap<RevisorFormacao, FormacaoRevisorViewModel>();
			Mapper.CreateMap<Mestre, MestreViewModel>();
			Mapper.CreateMap<MestreArea, MestreAreaViewModel>();
			Mapper.CreateMap<MestreDependente, MestreDependenteViewModel>();
			Mapper.CreateMap<MestreFormacao, MestreFormacaoViewModel>();
			Mapper.CreateMap<Questao, QuestaoViewModel>();
			Mapper.CreateMap<TopicoAtribuido, TopicoAtribuidoViewModel>();


		}
	}
}