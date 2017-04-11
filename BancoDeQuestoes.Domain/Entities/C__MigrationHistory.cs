using System.ComponentModel.DataAnnotations;

namespace BancoDeQuestoes.Domain.Entities
{
    public  class C__MigrationHistory
    {
		[Key]
		public string MigrationId { get; set; }
		public string ContextKey { get; set; }
        public byte[] Model { get; set; }
        public string ProductVersion { get; set; }
    }
}
