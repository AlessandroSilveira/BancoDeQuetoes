using AutoMapper;
using BancoDeQuestoes.Application.ViewModels;
using BancoDeQuestoes.Domain.Entities;

namespace BancoDeQuestoes.Application.AutoMapper
{
	public class ViewModelToDomainMappingProfile :Profile
	{
		public override string ProfileName => "ViewModelToDomainMappings";

	    protected override void Configure()
		{
            //Mapper.Initialize(cfg => cfg.CreateMap<Area, AreaViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<Projeto, ProjetoViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<Disciplina, DisciplinaViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<Banca, BancaViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<Revisor, RevisorViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<RevisorFormacao, RevisorFormacaoViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<Mestre, MestreViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<MestreArea, MestreAreaViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<MestreDependente, MestreDependenteViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<MestreFormacao, MestreFormacaoViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<Questao, QuestaoViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<TopicoAtribuido, TopicoAtribuidoViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<Status, StatusViewModel>());

            Mapper.CreateMap<Projeto, ProjetoViewModel>();
            Mapper.CreateMap<Disciplina, DisciplinaViewModel>();
            Mapper.CreateMap<Banca, BancaViewModel>();
            Mapper.CreateMap<Revisor, RevisorViewModel>();
            Mapper.CreateMap<RevisorFormacao, RevisorFormacaoViewModel>();
            Mapper.CreateMap<Mestre, MestreViewModel>();
            Mapper.CreateMap<MestreArea, MestreAreaViewModel>();
            Mapper.CreateMap<MestreDependente, MestreDependenteViewModel>();
            Mapper.CreateMap<MestreFormacao, MestreFormacaoViewModel>();
            Mapper.CreateMap<Questao, QuestaoViewModel>();
            Mapper.CreateMap<TopicoAtribuido, TopicoAtribuidoViewModel>();
            Mapper.CreateMap<Status, StatusViewModel>();
        }
	}
}