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
            Mapper.CreateMap<Area, AreaViewModel>();
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
            Mapper.CreateMap<ConviteMestre, ConviteMestreViewModel>();
			Mapper.CreateMap<Resposta, RespostaViewModel>();
		}
	}
}