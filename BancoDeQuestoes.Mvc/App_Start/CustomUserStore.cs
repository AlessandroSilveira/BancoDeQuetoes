using System.Threading.Tasks;
using BancoDeQuestoes.Mvc.Models;
using Microsoft.AspNet.Identity;

namespace BancoDeQuestoes.Mvc
{
	internal class CustomUserStore : IUserStore<ApplicationUser, string>
	{
		private ApplicationDbContext _applicationDbContext;

		public CustomUserStore(ApplicationDbContext applicationDbContext)
		{
			_applicationDbContext = applicationDbContext;
		}

		public void Dispose()
		{
			throw new System.NotImplementedException();
		}

		public Task CreateAsync(ApplicationUser user)
		{
			throw new System.NotImplementedException();
		}

		public Task UpdateAsync(ApplicationUser user)
		{
			throw new System.NotImplementedException();
		}

		public Task DeleteAsync(ApplicationUser user)
		{
			throw new System.NotImplementedException();
		}

		public Task<ApplicationUser> FindByIdAsync(string userId)
		{
			throw new System.NotImplementedException();
		}

		public Task<ApplicationUser> FindByNameAsync(string userName)
		{
			throw new System.NotImplementedException();
		}
	}
}