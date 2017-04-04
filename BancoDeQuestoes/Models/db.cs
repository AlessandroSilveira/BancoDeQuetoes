namespace BancoDeQuestoes.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class db : DbContext
    {
        public db()
            : base("name=db")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<DADOS_CONTATO> DADOS_CONTATO { get; set; }
        public virtual DbSet<DADOS_ESTAGIO> DADOS_ESTAGIO { get; set; }
        public virtual DbSet<DADOS_PESSOAIS> DADOS_PESSOAIS { get; set; }
        public virtual DbSet<INSCR_ADMIN> INSCR_ADMIN { get; set; }
        public virtual DbSet<INSCR_ADMIN_PERFIL> INSCR_ADMIN_PERFIL { get; set; }
        public virtual DbSet<INSCR_BANCO_BAIXA> INSCR_BANCO_BAIXA { get; set; }
        public virtual DbSet<INSCR_BQ_BANCA> INSCR_BQ_BANCA { get; set; }
        public virtual DbSet<INSCR_BQ_CARGO_CBO> INSCR_BQ_CARGO_CBO { get; set; }
        public virtual DbSet<INSCR_BQ_CONVITE_MESTRE> INSCR_BQ_CONVITE_MESTRE { get; set; }
        public virtual DbSet<INSCR_BQ_CONVITE_REVISAO_MESTRE> INSCR_BQ_CONVITE_REVISAO_MESTRE { get; set; }
        public virtual DbSet<INSCR_BQ_CONVITE_REVISOR> INSCR_BQ_CONVITE_REVISOR { get; set; }
        public virtual DbSet<INSCR_BQ_DISCIPLINA> INSCR_BQ_DISCIPLINA { get; set; }
        public virtual DbSet<INSCR_BQ_MESTRE> INSCR_BQ_MESTRE { get; set; }
        public virtual DbSet<INSCR_BQ_PROJETO> INSCR_BQ_PROJETO { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO> INSCR_BQ_QUESTAO { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_APROVADA> INSCR_BQ_QUESTAO_APROVADA { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_PROJETO> INSCR_BQ_QUESTAO_PROJETO { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_RECICLADA_COMP> INSCR_BQ_QUESTAO_RECICLADA_COMP { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_RECICLAR_REVISOR> INSCR_BQ_QUESTAO_RECICLAR_REVISOR { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_REVISADA> INSCR_BQ_QUESTAO_REVISADA { get; set; }
        public virtual DbSet<INSCR_BQ_QUESTAO_REVISOR> INSCR_BQ_QUESTAO_REVISOR { get; set; }
        public virtual DbSet<INSCR_BQ_RESPOSTA> INSCR_BQ_RESPOSTA { get; set; }
        public virtual DbSet<INSCR_BQ_RESPOSTA_REVISADA> INSCR_BQ_RESPOSTA_REVISADA { get; set; }
        public virtual DbSet<INSCR_BQ_REVISOR> INSCR_BQ_REVISOR { get; set; }
        public virtual DbSet<INSCR_BQ_STATUS> INSCR_BQ_STATUS { get; set; }
        public virtual DbSet<INSCR_BQ_TIPO_GRAU_FORMACAO> INSCR_BQ_TIPO_GRAU_FORMACAO { get; set; }
        public virtual DbSet<INSCR_BQ_TOP_DISC_CARGO> INSCR_BQ_TOP_DISC_CARGO { get; set; }
        public virtual DbSet<INSCR_BQ_TOPICO> INSCR_BQ_TOPICO { get; set; }
        public virtual DbSet<INSCR_BQ_TOPICO_ATRIBUIDO> INSCR_BQ_TOPICO_ATRIBUIDO { get; set; }
        public virtual DbSet<INSCR_CAD> INSCR_CAD { get; set; }
        public virtual DbSet<INSCR_CAD_COMP> INSCR_CAD_COMP { get; set; }
        public virtual DbSet<INSCR_CAD_DOCUMENTO> INSCR_CAD_DOCUMENTO { get; set; }
        public virtual DbSet<INSCR_CAD_HISTORICO> INSCR_CAD_HISTORICO { get; set; }
        public virtual DbSet<INSCR_CANDIDATO_SEBRAE> INSCR_CANDIDATO_SEBRAE { get; set; }
        public virtual DbSet<INSCR_CARGO> INSCR_CARGO { get; set; }
        public virtual DbSet<INSCR_CID> INSCR_CID { get; set; }
        public virtual DbSet<INSCR_CIDADE> INSCR_CIDADE { get; set; }
        public virtual DbSet<INSCR_CONCURSO> INSCR_CONCURSO { get; set; }
        public virtual DbSet<INSCR_CONVITE_REVISAO_MESTRE> INSCR_CONVITE_REVISAO_MESTRE { get; set; }
        public virtual DbSet<INSCR_COORDENADOR> INSCR_COORDENADOR { get; set; }
        public virtual DbSet<INSCR_COORDENADOR_ACESSO> INSCR_COORDENADOR_ACESSO { get; set; }
        public virtual DbSet<INSCR_COORDENADOR_ESCOLA> INSCR_COORDENADOR_ESCOLA { get; set; }
        public virtual DbSet<INSCR_CRONOGRAMA> INSCR_CRONOGRAMA { get; set; }
        public virtual DbSet<INSCR_CURSO> INSCR_CURSO { get; set; }
        public virtual DbSet<INSCR_DEFICIENCIA> INSCR_DEFICIENCIA { get; set; }
        public virtual DbSet<INSCR_DOCUMENTO> INSCR_DOCUMENTO { get; set; }
        public virtual DbSet<INSCR_ESCOLA> INSCR_ESCOLA { get; set; }
        public virtual DbSet<INSCR_ESCOLA_SALA> INSCR_ESCOLA_SALA { get; set; }
        public virtual DbSet<INSCR_ESTADO> INSCR_ESTADO { get; set; }
        public virtual DbSet<INSCR_EV> INSCR_EV { get; set; }
        public virtual DbSet<INSCR_IDERH_BANNER> INSCR_IDERH_BANNER { get; set; }
        public virtual DbSet<INSCR_IDERH_CAD_PROJETO> INSCR_IDERH_CAD_PROJETO { get; set; }
        public virtual DbSet<INSCR_IDERH_CADASTRO> INSCR_IDERH_CADASTRO { get; set; }
        public virtual DbSet<INSCR_IDERH_DEPOIMENTO> INSCR_IDERH_DEPOIMENTO { get; set; }
        public virtual DbSet<INSCR_IDERH_DICAS> INSCR_IDERH_DICAS { get; set; }
        public virtual DbSet<INSCR_IDERH_EMPRESA> INSCR_IDERH_EMPRESA { get; set; }
        public virtual DbSet<INSCR_IDERH_NOTICIA> INSCR_IDERH_NOTICIA { get; set; }
        public virtual DbSet<INSCR_IDERH_PROJETOS> INSCR_IDERH_PROJETOS { get; set; }
        public virtual DbSet<INSCR_IDERH_TIPO_MEDIA> INSCR_IDERH_TIPO_MEDIA { get; set; }
        public virtual DbSet<INSCR_IDIOMA> INSCR_IDIOMA { get; set; }
        public virtual DbSet<INSCR_INFORMATICA> INSCR_INFORMATICA { get; set; }
        public virtual DbSet<INSCR_INSTBOLETO> INSCR_INSTBOLETO { get; set; }
        public virtual DbSet<INSCR_LISTA1> INSCR_LISTA1 { get; set; }
        public virtual DbSet<INSCR_LOCAL> INSCR_LOCAL { get; set; }
        public virtual DbSet<INSCR_LOCAL_CARGO> INSCR_LOCAL_CARGO { get; set; }
        public virtual DbSet<INSCR_MODULO> INSCR_MODULO { get; set; }
        public virtual DbSet<INSCR_MUNICIPIOS_IBGE> INSCR_MUNICIPIOS_IBGE { get; set; }
        public virtual DbSet<INSCR_NACIONALIDADE> INSCR_NACIONALIDADE { get; set; }
        public virtual DbSet<INSCR_NIVEL_ESCOLAR> INSCR_NIVEL_ESCOLAR { get; set; }
        public virtual DbSet<INSCR_OCORRENCIA> INSCR_OCORRENCIA { get; set; }
        public virtual DbSet<INSCR_PAGAMENTO> INSCR_PAGAMENTO { get; set; }
        public virtual DbSet<INSCR_PERFIL> INSCR_PERFIL { get; set; }
        public virtual DbSet<INSCR_PERFIL_MODULO> INSCR_PERFIL_MODULO { get; set; }
        public virtual DbSet<INSCR_PESSOA> INSCR_PESSOA { get; set; }
        public virtual DbSet<INSCR_PESSOA_CONCURSO> INSCR_PESSOA_CONCURSO { get; set; }
        public virtual DbSet<INSCR_PESSOA_CONVOCACAO> INSCR_PESSOA_CONVOCACAO { get; set; }
        public virtual DbSet<INSCR_PESSOA_CURSO> INSCR_PESSOA_CURSO { get; set; }
        public virtual DbSet<INSCR_PESSOA_DEPENDENTE> INSCR_PESSOA_DEPENDENTE { get; set; }
        public virtual DbSet<INSCR_PESSOA_EXPERIENCIA> INSCR_PESSOA_EXPERIENCIA { get; set; }
        public virtual DbSet<INSCR_PESSOA_FORMACAO> INSCR_PESSOA_FORMACAO { get; set; }
        public virtual DbSet<INSCR_PESSOA_IDIOMA> INSCR_PESSOA_IDIOMA { get; set; }
        public virtual DbSet<INSCR_PESSOA_INFORMATICA> INSCR_PESSOA_INFORMATICA { get; set; }
        public virtual DbSet<INSCR_PESSOA_MINICURRICULO> INSCR_PESSOA_MINICURRICULO { get; set; }
        public virtual DbSet<INSCR_PESSOA_PAGAMENTO> INSCR_PESSOA_PAGAMENTO { get; set; }
        public virtual DbSet<INSCR_PESSOA_RESPOSTA_ISENCAO> INSCR_PESSOA_RESPOSTA_ISENCAO { get; set; }
        public virtual DbSet<INSCR_PESSOA_RESULTADO> INSCR_PESSOA_RESULTADO { get; set; }
        public virtual DbSet<INSCR_PESSOA_RESULTADO_OFICIAL> INSCR_PESSOA_RESULTADO_OFICIAL { get; set; }
        public virtual DbSet<INSCR_PESSOA_TELEFONE> INSCR_PESSOA_TELEFONE { get; set; }
        public virtual DbSet<INSCR_PROVA> INSCR_PROVA { get; set; }
        public virtual DbSet<INSCR_PROVA_CAD> INSCR_PROVA_CAD { get; set; }
        public virtual DbSet<INSCR_PROVA_CIDADE> INSCR_PROVA_CIDADE { get; set; }
        public virtual DbSet<INSCR_PROVA_CONFIG> INSCR_PROVA_CONFIG { get; set; }
        public virtual DbSet<INSCR_PROVA_CONFIG_VALOR> INSCR_PROVA_CONFIG_VALOR { get; set; }
        public virtual DbSet<INSCR_PROVA_ESCOLA> INSCR_PROVA_ESCOLA { get; set; }
        public virtual DbSet<INSCR_PROVA_ESCOLA_MAPA> INSCR_PROVA_ESCOLA_MAPA { get; set; }
        public virtual DbSet<INSCR_PROVA_ESCOLA_RH> INSCR_PROVA_ESCOLA_RH { get; set; }
        public virtual DbSet<INSCR_PROVA_LOCAL> INSCR_PROVA_LOCAL { get; set; }
        public virtual DbSet<INSCR_PROVA_LOCAL_SALA> INSCR_PROVA_LOCAL_SALA { get; set; }
        public virtual DbSet<INSCR_PROVA_PAGAMENTO> INSCR_PROVA_PAGAMENTO { get; set; }
        public virtual DbSet<INSCR_PROVA_PROCESSO> INSCR_PROVA_PROCESSO { get; set; }
        public virtual DbSet<INSCR_PROVA_PROCESSO_CARGO> INSCR_PROVA_PROCESSO_CARGO { get; set; }
        public virtual DbSet<INSCR_PROVA_PROCESSO_LOCAL> INSCR_PROVA_PROCESSO_LOCAL { get; set; }
        public virtual DbSet<INSCR_PROVA_PROCESSO_LOCAL_SALA> INSCR_PROVA_PROCESSO_LOCAL_SALA { get; set; }
        public virtual DbSet<INSCR_PUBLICACAO> INSCR_PUBLICACAO { get; set; }
        public virtual DbSet<INSCR_REMUNERACAO> INSCR_REMUNERACAO { get; set; }
        public virtual DbSet<INSCR_RESULTADO> INSCR_RESULTADO { get; set; }
        public virtual DbSet<INSCR_RESULTADO_CAD> INSCR_RESULTADO_CAD { get; set; }
        public virtual DbSet<INSCR_RESULTADO_CAD_ADMIN> INSCR_RESULTADO_CAD_ADMIN { get; set; }
        public virtual DbSet<INSCR_RESULTADO_CAD_HISTORICO> INSCR_RESULTADO_CAD_HISTORICO { get; set; }
        public virtual DbSet<INSCR_RESULTADO_COLUNA> INSCR_RESULTADO_COLUNA { get; set; }
        public virtual DbSet<INSCR_RESULTADO_COLUNA1> INSCR_RESULTADO_COLUNA1 { get; set; }
        public virtual DbSet<INSCR_RG_CAD> INSCR_RG_CAD { get; set; }
        public virtual DbSet<INSCR_SEQUENCE> INSCR_SEQUENCE { get; set; }
        public virtual DbSet<INSCR_TEMA_REDACAO> INSCR_TEMA_REDACAO { get; set; }
        public virtual DbSet<INSCR_TIPO_TELEFONE> INSCR_TIPO_TELEFONE { get; set; }
        public virtual DbSet<INSCR_USUARIO> INSCR_USUARIO { get; set; }
        public virtual DbSet<INSCR_VINCULO> INSCR_VINCULO { get; set; }
        public virtual DbSet<SISREC_CARGOS> SISREC_CARGOS { get; set; }
        public virtual DbSet<SISREC_DADOS_COMPLEMENTARES> SISREC_DADOS_COMPLEMENTARES { get; set; }
        public virtual DbSet<SISREC_DEPARTAMENTO> SISREC_DEPARTAMENTO { get; set; }
        public virtual DbSet<SISREC_ORGAO> SISREC_ORGAO { get; set; }
        public virtual DbSet<SISREC_PESSOA> SISREC_PESSOA { get; set; }
        public virtual DbSet<SISREC_SETOR_SERVICO> SISREC_SETOR_SERVICO { get; set; }
        public virtual DbSet<SISREC_USUARIO> SISREC_USUARIO { get; set; }
        public virtual DbSet<TELEFONES> TELEFONES { get; set; }
        public virtual DbSet<INSCR_CHAT_INTERACAO> INSCR_CHAT_INTERACAO { get; set; }
        public virtual DbSet<INSCR_NIVEL> INSCR_NIVEL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.CODIGO_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.E_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.CEP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.TIPO_DE_LOGRADOURO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.NUMERO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.ESTADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_CONTATO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_ESTAGIO>()
                .Property(e => e.CODIGO_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_ESTAGIO>()
                .Property(e => e.CURSO)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_ESTAGIO>()
                .Property(e => e.INSTITUICAO)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_ESTAGIO>()
                .Property(e => e.REGISTRO_ACADEMICO)
                .IsFixedLength();

            modelBuilder.Entity<DADOS_ESTAGIO>()
                .Property(e => e.MODALIDADE_CURSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.NACIONALIDADE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.NATURALIDADE_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.MUNICIPIO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.SEXO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.ESTADO_CIVIL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.ORGAO_EXPEDITOR_RG)
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.UF_RG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DADOS_PESSOAIS>()
                .Property(e => e.NECESSIDADES_ESPECIAIS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INSCR_ADMIN>()
                .HasMany(e => e.INSCR_ADMIN_PERFIL)
                .WithRequired(e => e.INSCR_ADMIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_ADMIN>()
                .HasMany(e => e.INSCR_CAD_DOCUMENTO)
                .WithRequired(e => e.INSCR_ADMIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_ADMIN>()
                .HasMany(e => e.INSCR_DOCUMENTO)
                .WithRequired(e => e.INSCR_ADMIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_ADMIN>()
                .HasMany(e => e.INSCR_OCORRENCIA)
                .WithRequired(e => e.INSCR_ADMIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_ADMIN>()
                .HasMany(e => e.INSCR_RESULTADO_CAD_ADMIN)
                .WithRequired(e => e.INSCR_ADMIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_ADMIN>()
                .HasMany(e => e.INSCR_RESULTADO_CAD_HISTORICO)
                .WithRequired(e => e.INSCR_ADMIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BANCO_BAIXA>()
                .HasMany(e => e.INSCR_INSTBOLETO)
                .WithRequired(e => e.INSCR_BANCO_BAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_CARGO_CBO>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithOptional(e => e.INSCR_BQ_CARGO_CBO)
                .HasForeignKey(e => e.ID_CARGO);

            modelBuilder.Entity<INSCR_BQ_CARGO_CBO>()
                .HasMany(e => e.INSCR_BQ_TOPICO)
                .WithOptional(e => e.INSCR_BQ_CARGO_CBO)
                .HasForeignKey(e => e.ID_CARGO);

            modelBuilder.Entity<INSCR_BQ_CARGO_CBO>()
                .HasMany(e => e.INSCR_BQ_TOP_DISC_CARGO)
                .WithRequired(e => e.INSCR_BQ_CARGO_CBO)
                .HasForeignKey(e => e.ID_CARGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_DISCIPLINA>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithRequired(e => e.INSCR_BQ_DISCIPLINA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_DISCIPLINA>()
                .HasMany(e => e.INSCR_BQ_TOPICO)
                .WithRequired(e => e.INSCR_BQ_DISCIPLINA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_DISCIPLINA>()
                .HasMany(e => e.INSCR_BQ_TOP_DISC_CARGO)
                .WithRequired(e => e.INSCR_BQ_DISCIPLINA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_MESTRE>()
                .HasMany(e => e.INSCR_BQ_CONVITE_MESTRE)
                .WithRequired(e => e.INSCR_BQ_MESTRE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_MESTRE>()
                .HasMany(e => e.INSCR_BQ_CONVITE_REVISAO_MESTRE)
                .WithRequired(e => e.INSCR_BQ_MESTRE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_MESTRE>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithRequired(e => e.INSCR_BQ_MESTRE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_PROJETO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_PROJETO)
                .WithRequired(e => e.INSCR_BQ_PROJETO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_PROJETO>()
                .HasMany(e => e.INSCR_BQ_TOP_DISC_CARGO)
                .WithRequired(e => e.INSCR_BQ_PROJETO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_PROJETO>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithRequired(e => e.INSCR_BQ_PROJETO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .Property(e => e.EXPORTAR_SEBRAE)
                .IsFixedLength();

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_RECICLAR_REVISOR)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISADA)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISOR)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA_REVISADA)
                .WithRequired(e => e.INSCR_BQ_QUESTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO_REVISADA>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_PROJETO)
                .WithRequired(e => e.INSCR_BQ_QUESTAO_REVISADA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO_REVISOR>()
                .Property(e => e.DESC_REVISAO_1)
                .IsUnicode(false);

            modelBuilder.Entity<INSCR_BQ_QUESTAO_REVISOR>()
                .Property(e => e.DESC_REVISAO_2)
                .IsUnicode(false);

            modelBuilder.Entity<INSCR_BQ_RESPOSTA>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA_REVISADA)
                .WithRequired(e => e.INSCR_BQ_RESPOSTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_CONVITE_REVISOR)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_RECICLAR_REVISOR)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISADA)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISOR)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_REVISOR>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA_REVISADA)
                .WithRequired(e => e.INSCR_BQ_REVISOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO>()
                .HasMany(e => e.INSCR_BQ_TOP_DISC_CARGO)
                .WithRequired(e => e.INSCR_BQ_TOPICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO>()
                .HasMany(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WithRequired(e => e.INSCR_BQ_TOPICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_CONVITE_MESTRE)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_QUESTAO_REVISADA)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_BQ_TOPICO_ATRIBUIDO>()
                .HasMany(e => e.INSCR_BQ_RESPOSTA_REVISADA)
                .WithRequired(e => e.INSCR_BQ_TOPICO_ATRIBUIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CAD>()
                .HasOptional(e => e.INSCR_CAD_COMP)
                .WithRequired(e => e.INSCR_CAD);

            modelBuilder.Entity<INSCR_CAD>()
                .HasMany(e => e.INSCR_CAD_DOCUMENTO)
                .WithRequired(e => e.INSCR_CAD)
                .HasForeignKey(e => new { e.ID_CONCURSO, e.RG_CAD })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CAD>()
                .HasOptional(e => e.INSCR_PAGAMENTO)
                .WithRequired(e => e.INSCR_CAD);

            modelBuilder.Entity<INSCR_CAD>()
                .HasMany(e => e.INSCR_PROVA_CAD)
                .WithRequired(e => e.INSCR_CAD)
                .HasForeignKey(e => new { e.ID_CONCURSO, e.RG_CAD })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CAD>()
                .HasMany(e => e.INSCR_RESULTADO_CAD_HISTORICO)
                .WithRequired(e => e.INSCR_CAD)
                .HasForeignKey(e => new { e.ID_CONCURSO, e.RG_CAD })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CAD>()
                .HasMany(e => e.INSCR_RESULTADO_CAD)
                .WithRequired(e => e.INSCR_CAD)
                .HasForeignKey(e => new { e.ID_CONCURSO, e.RG_CAD })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CARGO>()
                .Property(e => e.CARGO_VALOR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INSCR_CARGO>()
                .HasMany(e => e.INSCR_CAD)
                .WithOptional(e => e.INSCR_CARGO)
                .HasForeignKey(e => new { e.ID_CONCURSO, e.RG_CARGO });

            modelBuilder.Entity<INSCR_CARGO>()
                .HasMany(e => e.INSCR_LOCAL_CARGO)
                .WithRequired(e => e.INSCR_CARGO)
                .HasForeignKey(e => new { e.ID_CONCURSO, e.RG_CARGO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CARGO>()
                .HasMany(e => e.INSCR_PESSOA_CONCURSO)
                .WithOptional(e => e.INSCR_CARGO)
                .HasForeignKey(e => new { e.ID_CONCURSO, e.RG_CARGO });

            modelBuilder.Entity<INSCR_CARGO>()
                .HasMany(e => e.INSCR_PROVA_PROCESSO_CARGO)
                .WithRequired(e => e.INSCR_CARGO)
                .HasForeignKey(e => new { e.ID_CONCURSO, e.RG_CARGO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CIDADE>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_CAD)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_CAD_DOCUMENTO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_CANDIDATO_SEBRAE)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_CARGO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_CRONOGRAMA)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_DOCUMENTO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_EV)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasOptional(e => e.INSCR_INSTBOLETO)
                .WithRequired(e => e.INSCR_CONCURSO);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_LISTA1)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_LOCAL)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_PESSOA_CONVOCACAO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_PESSOA_RESPOSTA_ISENCAO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_PESSOA_RESULTADO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_PESSOA_RESULTADO_OFICIAL)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_PROVA_PROCESSO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_PUBLICACAO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_RESULTADO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_TEMA_REDACAO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_CONCURSO>()
                .HasMany(e => e.INSCR_USUARIO)
                .WithRequired(e => e.INSCR_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_COORDENADOR>()
                .HasMany(e => e.INSCR_COORDENADOR_ESCOLA)
                .WithRequired(e => e.INSCR_COORDENADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_COORDENADOR>()
                .HasMany(e => e.INSCR_PROVA_CIDADE)
                .WithRequired(e => e.INSCR_COORDENADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_COORDENADOR>()
                .HasMany(e => e.INSCR_PROVA_ESCOLA)
                .WithRequired(e => e.INSCR_COORDENADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_COORDENADOR>()
                .HasMany(e => e.INSCR_PROVA_PAGAMENTO)
                .WithRequired(e => e.INSCR_COORDENADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_DOCUMENTO>()
                .HasMany(e => e.INSCR_CAD_DOCUMENTO)
                .WithRequired(e => e.INSCR_DOCUMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_ESCOLA>()
                .HasMany(e => e.INSCR_COORDENADOR_ESCOLA)
                .WithRequired(e => e.INSCR_ESCOLA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_ESCOLA>()
                .HasMany(e => e.INSCR_ESCOLA_SALA)
                .WithRequired(e => e.INSCR_ESCOLA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_ESCOLA>()
                .HasMany(e => e.INSCR_PROVA_ESCOLA)
                .WithRequired(e => e.INSCR_ESCOLA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_ESTADO>()
                .Property(e => e.Sigla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INSCR_IDERH_CADASTRO>()
                .Property(e => e.CAD_CEP)
                .IsFixedLength();

            modelBuilder.Entity<INSCR_IDERH_CADASTRO>()
                .HasMany(e => e.INSCR_IDERH_CAD_PROJETO)
                .WithRequired(e => e.INSCR_IDERH_CADASTRO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_IDERH_PROJETOS>()
                .HasMany(e => e.INSCR_IDERH_CAD_PROJETO)
                .WithRequired(e => e.INSCR_IDERH_PROJETOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_LOCAL>()
                .HasMany(e => e.INSCR_LOCAL_CARGO)
                .WithRequired(e => e.INSCR_LOCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_MODULO>()
                .HasMany(e => e.INSCR_PERFIL_MODULO)
                .WithRequired(e => e.INSCR_MODULO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PERFIL>()
                .HasMany(e => e.INSCR_ADMIN_PERFIL)
                .WithRequired(e => e.INSCR_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PERFIL>()
                .HasMany(e => e.INSCR_PERFIL_MODULO)
                .WithRequired(e => e.INSCR_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA>()
                .HasMany(e => e.INSCR_PESSOA_CONCURSO)
                .WithRequired(e => e.INSCR_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA>()
                .HasMany(e => e.INSCR_PESSOA_CURSO)
                .WithRequired(e => e.INSCR_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA>()
                .HasMany(e => e.INSCR_PESSOA_DEPENDENTE)
                .WithRequired(e => e.INSCR_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA>()
                .HasMany(e => e.INSCR_PESSOA_EXPERIENCIA)
                .WithRequired(e => e.INSCR_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA>()
                .HasMany(e => e.INSCR_PESSOA_FORMACAO)
                .WithRequired(e => e.INSCR_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA>()
                .HasMany(e => e.INSCR_PESSOA_IDIOMA)
                .WithRequired(e => e.INSCR_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA>()
                .HasMany(e => e.INSCR_PESSOA_INFORMATICA)
                .WithRequired(e => e.INSCR_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA>()
                .HasMany(e => e.INSCR_PESSOA_MINICURRICULO)
                .WithRequired(e => e.INSCR_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA_CONCURSO>()
                .HasMany(e => e.INSCR_PESSOA_CONVOCACAO)
                .WithRequired(e => e.INSCR_PESSOA_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA_CONCURSO>()
                .HasMany(e => e.INSCR_PESSOA_RESPOSTA_ISENCAO)
                .WithRequired(e => e.INSCR_PESSOA_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PESSOA_CONCURSO>()
                .HasMany(e => e.INSCR_PESSOA_RESULTADO)
                .WithRequired(e => e.INSCR_PESSOA_CONCURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA>()
                .HasMany(e => e.INSCR_PROVA_CIDADE)
                .WithRequired(e => e.INSCR_PROVA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_CIDADE>()
                .HasMany(e => e.INSCR_PROVA_ESCOLA)
                .WithRequired(e => e.INSCR_PROVA_CIDADE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_CIDADE>()
                .HasMany(e => e.INSCR_PROVA_PAGAMENTO)
                .WithRequired(e => e.INSCR_PROVA_CIDADE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_LOCAL>()
                .HasMany(e => e.INSCR_PROVA_LOCAL_SALA)
                .WithRequired(e => e.INSCR_PROVA_LOCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_LOCAL>()
                .HasMany(e => e.INSCR_PROVA_PROCESSO_LOCAL)
                .WithRequired(e => e.INSCR_PROVA_LOCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_LOCAL_SALA>()
                .HasMany(e => e.INSCR_PROVA_PROCESSO_LOCAL_SALA)
                .WithRequired(e => e.INSCR_PROVA_LOCAL_SALA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_PROCESSO>()
                .HasMany(e => e.INSCR_PROVA_PROCESSO_CARGO)
                .WithRequired(e => e.INSCR_PROVA_PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_PROCESSO>()
                .HasMany(e => e.INSCR_PROVA_PROCESSO_LOCAL)
                .WithRequired(e => e.INSCR_PROVA_PROCESSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_PROCESSO_LOCAL>()
                .HasMany(e => e.INSCR_PESSOA_CONVOCACAO)
                .WithRequired(e => e.INSCR_PROVA_PROCESSO_LOCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_PROCESSO_LOCAL>()
                .HasMany(e => e.INSCR_PROVA_CAD)
                .WithRequired(e => e.INSCR_PROVA_PROCESSO_LOCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_PROVA_PROCESSO_LOCAL>()
                .HasMany(e => e.INSCR_PROVA_PROCESSO_LOCAL_SALA)
                .WithRequired(e => e.INSCR_PROVA_PROCESSO_LOCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_RESULTADO>()
                .HasMany(e => e.INSCR_CANDIDATO_SEBRAE)
                .WithRequired(e => e.INSCR_RESULTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_RESULTADO>()
                .HasMany(e => e.INSCR_PESSOA_RESULTADO)
                .WithRequired(e => e.INSCR_RESULTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_RESULTADO>()
                .HasMany(e => e.INSCR_PESSOA_RESULTADO_OFICIAL)
                .WithRequired(e => e.INSCR_RESULTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_RESULTADO>()
                .HasMany(e => e.INSCR_RESULTADO_CAD_HISTORICO)
                .WithRequired(e => e.INSCR_RESULTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_RESULTADO>()
                .HasMany(e => e.INSCR_RESULTADO_CAD)
                .WithRequired(e => e.INSCR_RESULTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_RESULTADO>()
                .HasMany(e => e.INSCR_RESULTADO_COLUNA)
                .WithRequired(e => e.INSCR_RESULTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_RESULTADO>()
                .HasMany(e => e.INSCR_RESULTADO_COLUNA1)
                .WithRequired(e => e.INSCR_RESULTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_RESULTADO_CAD>()
                .HasMany(e => e.INSCR_RESULTADO_CAD_ADMIN)
                .WithRequired(e => e.INSCR_RESULTADO_CAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSCR_USUARIO>()
                .HasMany(e => e.INSCR_PUBLICACAO)
                .WithRequired(e => e.INSCR_USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SISREC_DEPARTAMENTO>()
                .HasMany(e => e.SISREC_SETOR_SERVICO)
                .WithRequired(e => e.SISREC_DEPARTAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SISREC_ORGAO>()
                .HasMany(e => e.SISREC_CARGOS)
                .WithRequired(e => e.SISREC_ORGAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SISREC_ORGAO>()
                .HasMany(e => e.SISREC_DEPARTAMENTO)
                .WithRequired(e => e.SISREC_ORGAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SISREC_ORGAO>()
                .HasMany(e => e.SISREC_SETOR_SERVICO)
                .WithRequired(e => e.SISREC_ORGAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SISREC_PESSOA>()
                .HasMany(e => e.SISREC_DADOS_COMPLEMENTARES)
                .WithRequired(e => e.SISREC_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TELEFONES>()
                .Property(e => e.CODIGO_PESSOA)
                .IsUnicode(false);

            modelBuilder.Entity<TELEFONES>()
                .Property(e => e.COD_TIPO_TELEFONE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TELEFONES>()
                .Property(e => e.DDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TELEFONES>()
                .Property(e => e.TELEFONE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TELEFONES>()
                .Property(e => e.ACEITA_SMS)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
