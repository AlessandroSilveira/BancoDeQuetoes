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
			Mapper.CreateMap<Cliente,ClienteViewModel>();
			Mapper.CreateMap<Produto,ProdutoViewModel > ();

		}
	}
}