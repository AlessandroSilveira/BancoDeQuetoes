using AutoMapper;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Mvc.AutoMapper
{
	public class DomaintoviewModelMappingProfile : Profile
	{
		public override string ProfileName
		{
			get { return "ViewModelToDomainMappings"; }
		}

		protected  void Configure()
		{

            Mapper.Initialize(cfg => cfg.CreateMap<AreaViewModel, Area>());
            Mapper.Initialize(cfg => cfg.CreateMap<ProjetoViewModel, Projeto>());
            Mapper.Initialize(cfg => cfg.CreateMap<DisciplinaViewModel, Disciplina>());
            Mapper.Initialize(cfg => cfg.CreateMap<RevisorViewModel, Revisor>());
            Mapper.Initialize(cfg => cfg.CreateMap<RevisorFormacaoViewModel, RevisorFormacao>());
            Mapper.Initialize(cfg => cfg.CreateMap<MestreViewModel, Mestre>());
            Mapper.Initialize(cfg => cfg.CreateMap<MestreAreaViewModel, MestreArea>());
            Mapper.Initialize(cfg => cfg.CreateMap<MestreDependenteViewModel, MestreDependente>());
            Mapper.Initialize(cfg => cfg.CreateMap<MestreFormacaoViewModel, MestreFormacao>());
            Mapper.Initialize(cfg => cfg.CreateMap<TopicoAtribuidoViewModel, TopicoAtribuido>());
            Mapper.Initialize(cfg => cfg.CreateMap<StatusViewModel, Status>());


   //         Mapper.CreateMap<AreaViewModel, Area>();
			//Mapper.CreateMap<ProjetoViewModel, Projeto>();
			//Mapper.CreateMap<DisciplinaViewModel, Disciplina>();
			//Mapper.CreateMap<BancaViewModel, Banca>();
			//Mapper.CreateMap<RevisorViewModel, Revisor>();
			//Mapper.CreateMap<RevisorFormacaoViewModel, RevisorFormacao>();
			//Mapper.CreateMap<MestreViewModel, Mestre>();
			//Mapper.CreateMap<MestreAreaViewModel, MestreArea>();
			//Mapper.CreateMap<MestreDependenteViewModel, MestreDependente>();
			//Mapper.CreateMap<MestreFormacaoViewModel, MestreFormacao>();
			//Mapper.CreateMap<QuestaoViewModel, Questao>();
			//Mapper.CreateMap<TopicoAtribuidoViewModel, TopicoAtribuido>();
   //         Mapper.CreateMap<StatusViewModel, Status>();
        }
	}
}