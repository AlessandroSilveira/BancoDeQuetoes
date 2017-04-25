using System;
using System.Collections.Generic;

namespace BancoDeQuestoes.Domain.Entities
{
	public  class Revisor
    {
	    public Revisor()
	    {
		    RevisorId = Guid.NewGuid();
	    }

        public Guid RevisorId { get; set; }
		public string Nome { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string EmailSecundario { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
        public virtual Area Area { get; set; }
        public bool Ativo { get; set; }

		public virtual ICollection<RevisorFormacao> RevisorFormacao { get; set; } = new List<RevisorFormacao>();
	}
}
