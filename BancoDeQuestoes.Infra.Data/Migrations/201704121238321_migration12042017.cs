namespace BancoDeQuestoes.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration12042017 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FormacaoRevisor", "RevisorId", "dbo.Revisor");
            DropIndex("dbo.FormacaoRevisor", new[] { "RevisorId" });
            CreateTable(
                "dbo.INSCR_BQ_TOP_DISC_CARGO",
                c => new
                    {
                        ID_TOP_DISC_CARGO = c.Int(nullable: false, identity: true),
                        ID_TOPICO = c.Int(nullable: false),
                        ID_DISCIPLINA = c.Int(nullable: false),
                        ID_CARGO = c.Int(nullable: false),
                        ID_PROJETO = c.Int(nullable: false),
                        COD_PROJETO = c.Int(nullable: false),
                        DESC_STATUS = c.String(maxLength: 1),
                        Disciplina_DisciplinaId = c.Int(),
                        INSCR_BQ_CARGO_CBO_ID_CARGO_CBO = c.Int(),
                        Projeto_ProjetoId = c.Int(),
                        Area_AreaId = c.Int(),
                    })
                .PrimaryKey(t => t.ID_TOP_DISC_CARGO)
                .ForeignKey("dbo.Disciplina", t => t.Disciplina_DisciplinaId)
                .ForeignKey("dbo.INSCR_BQ_CARGO_CBO", t => t.INSCR_BQ_CARGO_CBO_ID_CARGO_CBO)
                .ForeignKey("dbo.Projeto", t => t.Projeto_ProjetoId)
                .ForeignKey("dbo.INSCR_BQ_DISCIPLINA", t => t.ID_DISCIPLINA)
                .ForeignKey("dbo.Area", t => t.Area_AreaId)
                .Index(t => t.ID_DISCIPLINA)
                .Index(t => t.Disciplina_DisciplinaId)
                .Index(t => t.INSCR_BQ_CARGO_CBO_ID_CARGO_CBO)
                .Index(t => t.Projeto_ProjetoId)
                .Index(t => t.Area_AreaId);
            
            CreateTable(
                "dbo.INSCR_BQ_CARGO_CBO",
                c => new
                    {
                        ID_CARGO_CBO = c.Int(nullable: false, identity: true),
                        DESC_CARGO = c.String(maxLength: 250),
                        DESC_ATIVO = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.ID_CARGO_CBO);
            
            CreateTable(
                "dbo.INSCR_BQ_TOPICO_ATRIBUIDO",
                c => new
                    {
                        ID_TOPICO_ATRIBUIDO = c.Int(nullable: false, identity: true),
                        ID_PROJETO = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        ID_CARGO = c.Int(),
                        COD_PROJETO = c.Int(nullable: false),
                        ID_MESTRE = c.Int(nullable: false),
                        ID_TOPICO = c.Int(nullable: false),
                        NUM_QUESTOES = c.Int(nullable: false),
                        QUESTOES_REALIZADAS = c.Int(),
                        DATA_ENTREGA = c.String(nullable: false, maxLength: 10),
                        DESC_STATUS = c.String(maxLength: 20),
                        DESC_NIVEL = c.String(nullable: false, maxLength: 50),
                        DESC_VALOR = c.String(maxLength: 10),
                        DESC_ACEITE = c.String(maxLength: 1),
                        DESC_OBSERVACAO = c.String(),
                        DATA_ATRIBUICAO = c.String(maxLength: 50),
                        Disciplina_DisciplinaId = c.Int(),
                        INSCR_BQ_CARGO_CBO_ID_CARGO_CBO = c.Int(),
                        Projeto_ProjetoId = c.Int(),
                        INSCR_BQ_DISCIPLINA_ID_DISCIPLINA = c.Int(),
                    })
                .PrimaryKey(t => t.ID_TOPICO_ATRIBUIDO)
                .ForeignKey("dbo.Area", t => t.AreaId)
                .ForeignKey("dbo.Disciplina", t => t.Disciplina_DisciplinaId)
                .ForeignKey("dbo.INSCR_BQ_CARGO_CBO", t => t.INSCR_BQ_CARGO_CBO_ID_CARGO_CBO)
                .ForeignKey("dbo.Projeto", t => t.Projeto_ProjetoId)
                .ForeignKey("dbo.INSCR_BQ_MESTRE", t => t.ID_MESTRE)
                .ForeignKey("dbo.INSCR_BQ_DISCIPLINA", t => t.INSCR_BQ_DISCIPLINA_ID_DISCIPLINA)
                .Index(t => t.AreaId)
                .Index(t => t.ID_MESTRE)
                .Index(t => t.Disciplina_DisciplinaId)
                .Index(t => t.INSCR_BQ_CARGO_CBO_ID_CARGO_CBO)
                .Index(t => t.Projeto_ProjetoId)
                .Index(t => t.INSCR_BQ_DISCIPLINA_ID_DISCIPLINA);
            
            CreateTable(
                "dbo.INSCR_BQ_CONVITE_MESTRE",
                c => new
                    {
                        ID_CONVITE_MESTRE = c.Int(nullable: false, identity: true),
                        ID_CONVITE = c.Int(nullable: false),
                        ID_MESTRE = c.Int(nullable: false),
                        ID_TOPICO_ATRIBUIDO = c.Int(nullable: false),
                        NUM_QUESTAO = c.Int(nullable: false),
                        DESC_ACEITE = c.Int(nullable: false),
                        TIPO_PAGAMENTO = c.String(maxLength: 50),
                        DESC_VALOR = c.String(maxLength: 50),
                        DATA_ACEITE = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_CONVITE_MESTRE)
                .ForeignKey("dbo.INSCR_BQ_MESTRE", t => t.ID_MESTRE)
                .ForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", t => t.ID_TOPICO_ATRIBUIDO)
                .Index(t => t.ID_MESTRE)
                .Index(t => t.ID_TOPICO_ATRIBUIDO);
            
            CreateTable(
                "dbo.INSCR_BQ_MESTRE",
                c => new
                    {
                        ID_MESTRE = c.Int(nullable: false, identity: true),
                        ID_BANCA = c.Int(nullable: false),
                        DESC_NOME = c.String(nullable: false, maxLength: 500),
                        DESC_CEP = c.String(nullable: false, maxLength: 8),
                        DESC_ENDERECO = c.String(nullable: false),
                        DESC_COMPLEMENTO = c.String(maxLength: 100),
                        DESC_NUMERO = c.String(nullable: false, maxLength: 5),
                        DESC_BAIRRO = c.String(nullable: false, maxLength: 100),
                        DESC_CIDADE = c.String(nullable: false, maxLength: 50),
                        DESC_ESTADO = c.String(nullable: false, maxLength: 2),
                        DESC_FORMACAO = c.String(),
                        GRAU_FORMACAO = c.String(maxLength: 50),
                        DESC_INSTITUICAO = c.String(maxLength: 50),
                        DESC_FORMACAO_2 = c.String(),
                        GRAU_FORMACAO_2 = c.String(maxLength: 50),
                        DESC_INSTITUICAO_2 = c.String(maxLength: 50),
                        DESC_FORMACAO_3 = c.String(),
                        GRAU_FORMACAO_3 = c.String(maxLength: 50),
                        DESC_INSTITUICAO_3 = c.String(maxLength: 50),
                        DESC_FORMACAO_4 = c.String(maxLength: 50),
                        GRAU_FORMACAO_4 = c.String(maxLength: 50),
                        DESC_INSTITUICAO_4 = c.String(maxLength: 50),
                        DESC_CPF = c.String(nullable: false, maxLength: 11),
                        DESC_EMAIL = c.String(nullable: false, maxLength: 150),
                        DESC_EMAIL_2 = c.String(nullable: false, maxLength: 150),
                        DESC_DDD = c.String(nullable: false, maxLength: 2),
                        DESC_TELEFONE = c.String(nullable: false, maxLength: 8),
                        DESC_DDD_CEL = c.String(nullable: false, maxLength: 2),
                        DESC_CELULAR = c.String(nullable: false, maxLength: 9),
                        DESC_SENHA = c.String(nullable: false, maxLength: 8),
                        DESC_DISCIPLINA = c.String(maxLength: 50),
                        DESC_ATIVO = c.String(maxLength: 1),
                        DESC_BANCO = c.String(nullable: false, maxLength: 50),
                        DESC_AGENCIA = c.String(nullable: false, maxLength: 50),
                        DESC_TIPO_CONTA = c.String(nullable: false, maxLength: 50),
                        DESC_CONTA = c.String(nullable: false, maxLength: 50),
                        DESC_FILHOS = c.String(maxLength: 2),
                        DESC_PIS = c.String(maxLength: 50),
                        DESC_NOME_DEPENDENTE1 = c.String(maxLength: 250),
                        DESC_DOCUMENTO_DEPENDENTE1 = c.String(maxLength: 15),
                        DESC_DATA_NASCIMENTO_DEPENDENTE1 = c.String(maxLength: 10),
                        DESC_NOME_DEPENDENTE2 = c.String(maxLength: 250),
                        DESC_DOCUMENTO_DEPENDENTE2 = c.String(maxLength: 15),
                        DESC_DATA_NASCIMENTO_DEPENDENTE2 = c.String(maxLength: 10),
                        DESC_NOME_DEPENDENTE3 = c.String(maxLength: 15),
                        DESC_DOCUMENTO_DEPENDENTE3 = c.String(maxLength: 15),
                        DESC_DATA_NASCIMENTO_DEPENDENTE3 = c.String(maxLength: 10),
                        CURRICULO = c.String(maxLength: 3),
                        DIPLOMA = c.String(maxLength: 3),
                        DESC_ACEITE = c.String(maxLength: 1),
                        ENTREGOU_COPIA_DIPLOMA_GRADUACAO = c.String(maxLength: 50),
                        DIPLOMA_GRADUACAO_AUTENTICADO = c.String(maxLength: 50),
                        NUMERO_COPIAS_DIPLOMA_AUTENTICADO = c.String(maxLength: 50),
                        ENTREGOU_COPIA_DIPLOMA_POSGRADUACAO = c.String(maxLength: 50),
                        DIPLOMA_POSGRADUACAO_AUTENTICADO = c.String(maxLength: 50),
                        NUMERO_COPIAS_DIPLOMA_POSGRADUACAO_AUTENTICADO = c.String(maxLength: 50),
                        ENTREGOU_COPIA_DIPLOMA_MESTRADO = c.String(maxLength: 50),
                        DIPLOMA_MESTRADO_AUTENTICADO = c.String(maxLength: 50),
                        NUMERO_COPIAS_DIPLOMA_MESTRADO_AUTENTICADO = c.String(maxLength: 50),
                        ENTREGOU_COPIA_DIPLOMA_DOUTORADO = c.String(maxLength: 50),
                        DIPLOMA_DOUTORADO_AUTENTICADO = c.String(maxLength: 50),
                        NUMERO_COPIAS_DIPLOMA_DOUTORADO_AUTENTICADO = c.String(maxLength: 50),
                        MINICURRICULO = c.String(),
                    })
                .PrimaryKey(t => t.ID_MESTRE)
                .ForeignKey("dbo.INSCR_BQ_BANCA", t => t.ID_BANCA)
                .Index(t => t.ID_BANCA);
            
            CreateTable(
                "dbo.INSCR_BQ_BANCA",
                c => new
                    {
                        ID_BANCA = c.Int(nullable: false, identity: true),
                        DESC_BANCA = c.String(nullable: false, maxLength: 50),
                        DESC_STATUS = c.String(nullable: false, maxLength: 1),
                        DESC_VALOR_PORCENTAGEM = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.ID_BANCA);
            
            CreateTable(
                "dbo.INSCR_BQ_CONVITE_REVISAO_MESTRE",
                c => new
                    {
                        ID_CONVITE_REVISAO_MESTRE = c.Int(nullable: false, identity: true),
                        ID_MESTRE = c.Int(nullable: false),
                        ID_QUESTAO = c.Int(),
                        DESC_ACEITE = c.Int(),
                        DATA_ACEITE = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID_CONVITE_REVISAO_MESTRE)
                .ForeignKey("dbo.INSCR_BQ_MESTRE", t => t.ID_MESTRE)
                .ForeignKey("dbo.INSCR_BQ_QUESTAO", t => t.ID_QUESTAO)
                .Index(t => t.ID_MESTRE)
                .Index(t => t.ID_QUESTAO);
            
            CreateTable(
                "dbo.INSCR_BQ_QUESTAO",
                c => new
                    {
                        ID_QUESTAO = c.Int(nullable: false, identity: true),
                        ID_TOPICO_ATRIBUIDO = c.Int(nullable: false),
                        NUM_QUESTAO = c.Int(nullable: false),
                        DESC_QUESTAO = c.String(),
                        DESC_ARQUIVO = c.String(maxLength: 250),
                        DESC_STATUS = c.String(maxLength: 50),
                        NUM_REVISAO = c.Int(),
                        DESC_FINALIZAR = c.Int(),
                        DESC_NIVEL = c.String(maxLength: 50),
                        DESC_IMAGEM = c.String(maxLength: 250),
                        DESC_CONVITE_ACEITE = c.String(maxLength: 1),
                        DESC_REVISAO_1 = c.String(maxLength: 1),
                        DESC_REVISAO_2 = c.String(maxLength: 1),
                        EXPORTAR_SEBRAE = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.ID_QUESTAO)
                .ForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", t => t.ID_TOPICO_ATRIBUIDO)
                .Index(t => t.ID_TOPICO_ATRIBUIDO);
            
            CreateTable(
                "dbo.INSCR_BQ_CONVITE_REVISOR",
                c => new
                    {
                        ID_CONVITE_REVISOR = c.Int(nullable: false, identity: true),
                        ID_CONVITE = c.Int(nullable: false),
                        ID_REVISOR = c.Int(nullable: false),
                        ID_QUESTAO = c.Int(),
                        NUM_QUESTAO = c.Int(nullable: false),
                        DESC_ACEITE = c.Int(nullable: false),
                        TIPO_PAGAMENTO = c.String(maxLength: 50),
                        DESC_VALOR = c.String(maxLength: 50),
                        DATA_ACEITE = c.String(maxLength: 50),
                        Revisor_RevisorId = c.Int(),
                    })
                .PrimaryKey(t => t.ID_CONVITE_REVISOR)
                .ForeignKey("dbo.INSCR_BQ_QUESTAO", t => t.ID_QUESTAO)
                .ForeignKey("dbo.Revisor", t => t.Revisor_RevisorId)
                .Index(t => t.ID_QUESTAO)
                .Index(t => t.Revisor_RevisorId);
            
            CreateTable(
                "dbo.INSCR_BQ_QUESTAO_RECICLAR_REVISOR",
                c => new
                    {
                        ID_QUESTAO_RECICLAR_REVISOR = c.Int(nullable: false, identity: true),
                        ID_REVISOR = c.Int(nullable: false),
                        ID_QUESTAO = c.Int(nullable: false),
                        DESC_DATA_ENTREGA = c.String(maxLength: 10),
                        DESC_STATUS = c.String(maxLength: 50),
                        DESC_VALOR = c.String(maxLength: 10),
                        Revisor_RevisorId = c.Int(),
                    })
                .PrimaryKey(t => t.ID_QUESTAO_RECICLAR_REVISOR)
                .ForeignKey("dbo.INSCR_BQ_QUESTAO", t => t.ID_QUESTAO)
                .ForeignKey("dbo.Revisor", t => t.Revisor_RevisorId)
                .Index(t => t.ID_QUESTAO)
                .Index(t => t.Revisor_RevisorId);
            
            CreateTable(
                "dbo.INSCR_BQ_QUESTAO_REVISADA",
                c => new
                    {
                        ID_QUESTAO_REVISADA = c.Int(nullable: false, identity: true),
                        ID_REVISOR = c.Int(nullable: false),
                        ID_QUESTAO = c.Int(nullable: false),
                        ID_TOPICO_ATRIBUIDO = c.Int(nullable: false),
                        NUM_QUESTAO = c.Int(nullable: false),
                        DESC_QUESTAO = c.String(nullable: false),
                        DESC_ARQUIVO = c.String(nullable: false),
                        DESC_STATUS = c.String(nullable: false, maxLength: 50),
                        NUM_REVISAO = c.Int(nullable: false),
                        DESC_OBSERVACAO_REVISOR = c.String(),
                        DESC_OBSERVACAO_REVISOR_2 = c.String(),
                        DATA_APROVACAO = c.String(maxLength: 50),
                        DESC_OBSERVACAO_RECUSA = c.String(),
                        DESC_IMAGEM = c.String(maxLength: 50),
                        DESC_REVISAO_1 = c.String(maxLength: 1),
                        DESC_REVISAO_2 = c.String(maxLength: 1),
                        DESC_JUSTIFICATIVA_REVISAO = c.String(),
                        Revisor_RevisorId = c.Int(),
                    })
                .PrimaryKey(t => t.ID_QUESTAO_REVISADA)
                .ForeignKey("dbo.INSCR_BQ_QUESTAO", t => t.ID_QUESTAO)
                .ForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", t => t.ID_TOPICO_ATRIBUIDO)
                .ForeignKey("dbo.Revisor", t => t.Revisor_RevisorId)
                .Index(t => t.ID_QUESTAO)
                .Index(t => t.ID_TOPICO_ATRIBUIDO)
                .Index(t => t.Revisor_RevisorId);
            
            CreateTable(
                "dbo.INSCR_BQ_QUESTAO_PROJETO",
                c => new
                    {
                        ID_QUESTAO_PROJETO = c.Int(nullable: false, identity: true),
                        ID_QUESTAO_REVISADA = c.Int(nullable: false),
                        ID_PROJETO = c.Int(nullable: false),
                        Projeto_ProjetoId = c.Int(),
                    })
                .PrimaryKey(t => t.ID_QUESTAO_PROJETO)
                .ForeignKey("dbo.INSCR_BQ_QUESTAO_REVISADA", t => t.ID_QUESTAO_REVISADA)
                .ForeignKey("dbo.Projeto", t => t.Projeto_ProjetoId)
                .Index(t => t.ID_QUESTAO_REVISADA)
                .Index(t => t.Projeto_ProjetoId);
            
            CreateTable(
                "dbo.INSCR_BQ_QUESTAO_REVISOR",
                c => new
                    {
                        ID_QUESTAO_REVISOR = c.Int(nullable: false, identity: true),
                        ID_REVISOR = c.Int(nullable: false),
                        ID_QUESTAO = c.Int(nullable: false),
                        DESC_DATA_ENTREGA = c.String(maxLength: 10),
                        DESC_STATUS = c.String(maxLength: 50),
                        DESC_VALOR = c.String(maxLength: 10),
                        DESC_REVISAO_1 = c.String(maxLength: 1),
                        DESC_REVISAO_2 = c.String(maxLength: 1),
                        Revisor_RevisorId = c.Int(),
                    })
                .PrimaryKey(t => t.ID_QUESTAO_REVISOR)
                .ForeignKey("dbo.INSCR_BQ_QUESTAO", t => t.ID_QUESTAO)
                .ForeignKey("dbo.Revisor", t => t.Revisor_RevisorId)
                .Index(t => t.ID_QUESTAO)
                .Index(t => t.Revisor_RevisorId);
            
            CreateTable(
                "dbo.INSCR_BQ_RESPOSTA_REVISADA",
                c => new
                    {
                        ID_RESPOSTA_REVISADA = c.Int(nullable: false, identity: true),
                        ID_REVISOR = c.Int(nullable: false),
                        ID_RESPOSTA = c.Int(nullable: false),
                        ID_QUESTAO = c.Int(nullable: false),
                        ID_TOPICO_ATRIBUIDO = c.Int(nullable: false),
                        DESC_RESPOSTA = c.String(nullable: false),
                        DESC_CORRECAO = c.String(nullable: false, maxLength: 20),
                        DESC_JUSTIFICATIVA = c.String(nullable: false),
                        DESC_STATUS = c.String(nullable: false, maxLength: 50),
                        DESC_OBSERVACAO_REVISOR = c.String(),
                        DESC_OBSERVACAO_REVISOR_2 = c.String(),
                        NUM_REVISAO = c.Int(),
                        DESC_IMAGEM = c.String(maxLength: 250),
                        Revisor_RevisorId = c.Int(),
                    })
                .PrimaryKey(t => t.ID_RESPOSTA_REVISADA)
                .ForeignKey("dbo.INSCR_BQ_QUESTAO", t => t.ID_QUESTAO)
                .ForeignKey("dbo.INSCR_BQ_RESPOSTA", t => t.ID_RESPOSTA)
                .ForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", t => t.ID_TOPICO_ATRIBUIDO)
                .ForeignKey("dbo.Revisor", t => t.Revisor_RevisorId)
                .Index(t => t.ID_RESPOSTA)
                .Index(t => t.ID_QUESTAO)
                .Index(t => t.ID_TOPICO_ATRIBUIDO)
                .Index(t => t.Revisor_RevisorId);
            
            CreateTable(
                "dbo.INSCR_BQ_RESPOSTA",
                c => new
                    {
                        ID_RESPOSTA = c.Int(nullable: false, identity: true),
                        ID_TOPICO_ATRIBUIDO = c.Int(nullable: false),
                        ID_QUESTAO = c.Int(nullable: false),
                        DESC_RESPOSTA = c.String(nullable: false),
                        DESC_CORRECAO = c.String(nullable: false, maxLength: 10),
                        DESC_JUSTIFICATIVA = c.String(nullable: false),
                        DESC_STATUS = c.String(nullable: false, maxLength: 50),
                        DESC_OBSERVACAO_REVISOR = c.String(),
                        DESC_OBSERVACAO_REVISOR_2 = c.String(),
                        DESC_IMAGEM = c.String(maxLength: 250),
                        DESC_IMAGEM_JUSTIFICATIVA = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID_RESPOSTA)
                .ForeignKey("dbo.INSCR_BQ_QUESTAO", t => t.ID_QUESTAO)
                .ForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", t => t.ID_TOPICO_ATRIBUIDO)
                .Index(t => t.ID_TOPICO_ATRIBUIDO)
                .Index(t => t.ID_QUESTAO);
            
            CreateTable(
                "dbo.INSCR_BQ_MESTRE_FORMACAO",
                c => new
                    {
                        ID_MESTRE_FORMACAO = c.Int(nullable: false, identity: true),
                        ID_MESTRE = c.Int(nullable: false),
                        DESC_TIPO_FORMACAO = c.String(nullable: false, maxLength: 100),
                        DESC_CURSO = c.String(nullable: false, maxLength: 100),
                        DESC_INSTITUICAO = c.String(nullable: false, maxLength: 100),
                        DESC_COPIA_DIPLOMA = c.Boolean(nullable: false),
                        DESC_DIPLOMA_AUTENTICADO = c.Boolean(nullable: false),
                        DESC_NUMERO_COPIAS = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_MESTRE_FORMACAO)
                .ForeignKey("dbo.INSCR_BQ_MESTRE", t => t.ID_MESTRE)
                .Index(t => t.ID_MESTRE);
            
            CreateTable(
                "dbo.MestreDependente",
                c => new
                    {
                        IdMestreDependente = c.Int(nullable: false, identity: true),
                        IDMestre = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Documento = c.String(nullable: false, maxLength: 100),
                        DataDeNascimento = c.DateTime(nullable: false),
                        INSCR_BQ_MESTRE_ID_MESTRE = c.Int(),
                    })
                .PrimaryKey(t => t.IdMestreDependente)
                .ForeignKey("dbo.INSCR_BQ_MESTRE", t => t.INSCR_BQ_MESTRE_ID_MESTRE)
                .Index(t => t.INSCR_BQ_MESTRE_ID_MESTRE);
            
            CreateTable(
                "dbo.INSCR_BQ_DISCIPLINA",
                c => new
                    {
                        ID_DISCIPLINA = c.Int(nullable: false, identity: true),
                        DESC_DISCIPLINA = c.String(maxLength: 250),
                        TIPO_CONH_ESPEC = c.String(maxLength: 1),
                        DESC_ATIVO = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.ID_DISCIPLINA);
            
            CreateTable(
                "dbo.INSCR_ADMIN",
                c => new
                    {
                        ID_ADMIN = c.Int(nullable: false),
                        DESC_NOME = c.String(nullable: false, maxLength: 50),
                        DESC_PERFIL = c.String(nullable: false, maxLength: 50),
                        DESC_SENHA = c.String(nullable: false, maxLength: 50),
                        DESC_USUARIO = c.String(maxLength: 50),
                        DESC_ATIVO = c.String(maxLength: 1),
                        DESC_EMAIL = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.ID_ADMIN);
            
            CreateTable(
                "dbo.INSCR_ADMIN_PERFIL",
                c => new
                    {
                        ID_ADMIN_PERFIL = c.Int(nullable: false),
                        ID_ADMIN = c.Int(nullable: false),
                        ID_PERFIL = c.Int(nullable: false),
                        ID_CONCURSO = c.Int(),
                        DESC_VARIAVEL = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_ADMIN_PERFIL)
                .ForeignKey("dbo.INSCR_ADMIN", t => t.ID_ADMIN)
                .Index(t => t.ID_ADMIN);
            
            CreateTable(
                "dbo.INSCR_BQ_QUESTAO_APROVADA",
                c => new
                    {
                        ID_QUESTAO_APROVADA = c.Int(nullable: false, identity: true),
                        ID_QUESTAO = c.Int(nullable: false),
                        PROJETO_1 = c.String(maxLength: 50),
                        PROJETO_2 = c.String(maxLength: 50),
                        PROJETO_3 = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_QUESTAO_APROVADA);
            
            CreateTable(
                "dbo.INSCR_BQ_QUESTAO_RECICLADA_COMP",
                c => new
                    {
                        ID_QUESTAO_RECICLADA_COMP = c.Int(nullable: false, identity: true),
                        ID_QUESTAO = c.Int(nullable: false),
                        ID_ADMIN = c.Int(nullable: false),
                        DATA_RECICLAGEM = c.DateTime(nullable: false),
                        ID_QUESTAO_REVISADA = c.Int(),
                    })
                .PrimaryKey(t => t.ID_QUESTAO_RECICLADA_COMP);
            
            CreateTable(
                "dbo.INSCR_BQ_STATUS",
                c => new
                    {
                        ID_STATUS = c.Int(nullable: false, identity: true),
                        ID_DESC_STATUS = c.Int(),
                        DESC_STATUS = c.String(nullable: false, maxLength: 150),
                        DESC_ATIVO = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.ID_STATUS);
            
            CreateTable(
                "dbo.INSCR_BQ_TIPO_GRAU_FORMACAO",
                c => new
                    {
                        ID_TIPO_GRAU_FORMACAO = c.Int(nullable: false, identity: true),
                        DESC_TIPO_GRAU_FORMACAO = c.String(maxLength: 50),
                        DESC_ATIVO = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.ID_TIPO_GRAU_FORMACAO);
            
            AddColumn("dbo.Disciplina", "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO", c => c.Int());
            AddColumn("dbo.Disciplina", "INSCR_BQ_DISCIPLINA_ID_DISCIPLINA", c => c.Int());
            AlterColumn("dbo.Disciplina", "Descricao", c => c.String());
            AlterColumn("dbo.Disciplina", "Nome", c => c.String());
            AlterColumn("dbo.Disciplina", "Bibliografia", c => c.String());
            AlterColumn("dbo.Disciplina", "Nivel", c => c.String());
            AlterColumn("dbo.Revisor", "Nome", c => c.String());
            AlterColumn("dbo.Revisor", "Cep", c => c.String());
            AlterColumn("dbo.Revisor", "Endereco", c => c.String());
            AlterColumn("dbo.Revisor", "Complemento", c => c.String());
            AlterColumn("dbo.Revisor", "Numero", c => c.String());
            AlterColumn("dbo.Revisor", "Bairro", c => c.String());
            AlterColumn("dbo.Revisor", "Cidade", c => c.String());
            AlterColumn("dbo.Revisor", "Uf", c => c.String());
            AlterColumn("dbo.Revisor", "Cpf", c => c.String());
            AlterColumn("dbo.Revisor", "Email", c => c.String());
            AlterColumn("dbo.Revisor", "EmailSecundario", c => c.String());
            AlterColumn("dbo.Revisor", "Telefone", c => c.String());
            AlterColumn("dbo.Revisor", "Celular", c => c.String());
            AlterColumn("dbo.Revisor", "Senha", c => c.String());
            CreateIndex("dbo.Disciplina", "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO");
            CreateIndex("dbo.Disciplina", "INSCR_BQ_DISCIPLINA_ID_DISCIPLINA");
            AddForeignKey("dbo.Disciplina", "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO", "dbo.INSCR_BQ_CARGO_CBO", "ID_CARGO_CBO");
            AddForeignKey("dbo.Disciplina", "INSCR_BQ_DISCIPLINA_ID_DISCIPLINA", "dbo.INSCR_BQ_DISCIPLINA", "ID_DISCIPLINA");
            DropTable("dbo.Banca");
            DropTable("dbo.FormacaoRevisor");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FormacaoRevisor",
                c => new
                    {
                        FormacaoRevisorId = c.Int(nullable: false, identity: true),
                        RevisorId = c.Int(nullable: false),
                        Formacao = c.String(nullable: false, maxLength: 150),
                        Instituicao = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FormacaoRevisorId);
            
            CreateTable(
                "dbo.Banca",
                c => new
                    {
                        BancaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 150),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BancaId);
            
            DropForeignKey("dbo.INSCR_ADMIN_PERFIL", "ID_ADMIN", "dbo.INSCR_ADMIN");
            DropForeignKey("dbo.INSCR_BQ_TOP_DISC_CARGO", "Area_AreaId", "dbo.Area");
            DropForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", "INSCR_BQ_DISCIPLINA_ID_DISCIPLINA", "dbo.INSCR_BQ_DISCIPLINA");
            DropForeignKey("dbo.Disciplina", "INSCR_BQ_DISCIPLINA_ID_DISCIPLINA", "dbo.INSCR_BQ_DISCIPLINA");
            DropForeignKey("dbo.INSCR_BQ_TOP_DISC_CARGO", "ID_DISCIPLINA", "dbo.INSCR_BQ_DISCIPLINA");
            DropForeignKey("dbo.INSCR_BQ_CONVITE_MESTRE", "ID_TOPICO_ATRIBUIDO", "dbo.INSCR_BQ_TOPICO_ATRIBUIDO");
            DropForeignKey("dbo.MestreDependente", "INSCR_BQ_MESTRE_ID_MESTRE", "dbo.INSCR_BQ_MESTRE");
            DropForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", "ID_MESTRE", "dbo.INSCR_BQ_MESTRE");
            DropForeignKey("dbo.INSCR_BQ_MESTRE_FORMACAO", "ID_MESTRE", "dbo.INSCR_BQ_MESTRE");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO", "ID_TOPICO_ATRIBUIDO", "dbo.INSCR_BQ_TOPICO_ATRIBUIDO");
            DropForeignKey("dbo.INSCR_BQ_RESPOSTA_REVISADA", "Revisor_RevisorId", "dbo.Revisor");
            DropForeignKey("dbo.INSCR_BQ_RESPOSTA_REVISADA", "ID_TOPICO_ATRIBUIDO", "dbo.INSCR_BQ_TOPICO_ATRIBUIDO");
            DropForeignKey("dbo.INSCR_BQ_RESPOSTA", "ID_TOPICO_ATRIBUIDO", "dbo.INSCR_BQ_TOPICO_ATRIBUIDO");
            DropForeignKey("dbo.INSCR_BQ_RESPOSTA_REVISADA", "ID_RESPOSTA", "dbo.INSCR_BQ_RESPOSTA");
            DropForeignKey("dbo.INSCR_BQ_RESPOSTA", "ID_QUESTAO", "dbo.INSCR_BQ_QUESTAO");
            DropForeignKey("dbo.INSCR_BQ_RESPOSTA_REVISADA", "ID_QUESTAO", "dbo.INSCR_BQ_QUESTAO");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO_REVISOR", "Revisor_RevisorId", "dbo.Revisor");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO_REVISOR", "ID_QUESTAO", "dbo.INSCR_BQ_QUESTAO");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO_REVISADA", "Revisor_RevisorId", "dbo.Revisor");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO_REVISADA", "ID_TOPICO_ATRIBUIDO", "dbo.INSCR_BQ_TOPICO_ATRIBUIDO");
            DropForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", "Projeto_ProjetoId", "dbo.Projeto");
            DropForeignKey("dbo.INSCR_BQ_TOP_DISC_CARGO", "Projeto_ProjetoId", "dbo.Projeto");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO_PROJETO", "Projeto_ProjetoId", "dbo.Projeto");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO_PROJETO", "ID_QUESTAO_REVISADA", "dbo.INSCR_BQ_QUESTAO_REVISADA");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO_REVISADA", "ID_QUESTAO", "dbo.INSCR_BQ_QUESTAO");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO_RECICLAR_REVISOR", "Revisor_RevisorId", "dbo.Revisor");
            DropForeignKey("dbo.INSCR_BQ_QUESTAO_RECICLAR_REVISOR", "ID_QUESTAO", "dbo.INSCR_BQ_QUESTAO");
            DropForeignKey("dbo.INSCR_BQ_CONVITE_REVISOR", "Revisor_RevisorId", "dbo.Revisor");
            DropForeignKey("dbo.INSCR_BQ_CONVITE_REVISOR", "ID_QUESTAO", "dbo.INSCR_BQ_QUESTAO");
            DropForeignKey("dbo.INSCR_BQ_CONVITE_REVISAO_MESTRE", "ID_QUESTAO", "dbo.INSCR_BQ_QUESTAO");
            DropForeignKey("dbo.INSCR_BQ_CONVITE_REVISAO_MESTRE", "ID_MESTRE", "dbo.INSCR_BQ_MESTRE");
            DropForeignKey("dbo.INSCR_BQ_CONVITE_MESTRE", "ID_MESTRE", "dbo.INSCR_BQ_MESTRE");
            DropForeignKey("dbo.INSCR_BQ_MESTRE", "ID_BANCA", "dbo.INSCR_BQ_BANCA");
            DropForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO", "dbo.INSCR_BQ_CARGO_CBO");
            DropForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", "Disciplina_DisciplinaId", "dbo.Disciplina");
            DropForeignKey("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", "AreaId", "dbo.Area");
            DropForeignKey("dbo.Disciplina", "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO", "dbo.INSCR_BQ_CARGO_CBO");
            DropForeignKey("dbo.INSCR_BQ_TOP_DISC_CARGO", "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO", "dbo.INSCR_BQ_CARGO_CBO");
            DropForeignKey("dbo.INSCR_BQ_TOP_DISC_CARGO", "Disciplina_DisciplinaId", "dbo.Disciplina");
            DropIndex("dbo.INSCR_ADMIN_PERFIL", new[] { "ID_ADMIN" });
            DropIndex("dbo.MestreDependente", new[] { "INSCR_BQ_MESTRE_ID_MESTRE" });
            DropIndex("dbo.INSCR_BQ_MESTRE_FORMACAO", new[] { "ID_MESTRE" });
            DropIndex("dbo.INSCR_BQ_RESPOSTA", new[] { "ID_QUESTAO" });
            DropIndex("dbo.INSCR_BQ_RESPOSTA", new[] { "ID_TOPICO_ATRIBUIDO" });
            DropIndex("dbo.INSCR_BQ_RESPOSTA_REVISADA", new[] { "Revisor_RevisorId" });
            DropIndex("dbo.INSCR_BQ_RESPOSTA_REVISADA", new[] { "ID_TOPICO_ATRIBUIDO" });
            DropIndex("dbo.INSCR_BQ_RESPOSTA_REVISADA", new[] { "ID_QUESTAO" });
            DropIndex("dbo.INSCR_BQ_RESPOSTA_REVISADA", new[] { "ID_RESPOSTA" });
            DropIndex("dbo.INSCR_BQ_QUESTAO_REVISOR", new[] { "Revisor_RevisorId" });
            DropIndex("dbo.INSCR_BQ_QUESTAO_REVISOR", new[] { "ID_QUESTAO" });
            DropIndex("dbo.INSCR_BQ_QUESTAO_PROJETO", new[] { "Projeto_ProjetoId" });
            DropIndex("dbo.INSCR_BQ_QUESTAO_PROJETO", new[] { "ID_QUESTAO_REVISADA" });
            DropIndex("dbo.INSCR_BQ_QUESTAO_REVISADA", new[] { "Revisor_RevisorId" });
            DropIndex("dbo.INSCR_BQ_QUESTAO_REVISADA", new[] { "ID_TOPICO_ATRIBUIDO" });
            DropIndex("dbo.INSCR_BQ_QUESTAO_REVISADA", new[] { "ID_QUESTAO" });
            DropIndex("dbo.INSCR_BQ_QUESTAO_RECICLAR_REVISOR", new[] { "Revisor_RevisorId" });
            DropIndex("dbo.INSCR_BQ_QUESTAO_RECICLAR_REVISOR", new[] { "ID_QUESTAO" });
            DropIndex("dbo.INSCR_BQ_CONVITE_REVISOR", new[] { "Revisor_RevisorId" });
            DropIndex("dbo.INSCR_BQ_CONVITE_REVISOR", new[] { "ID_QUESTAO" });
            DropIndex("dbo.INSCR_BQ_QUESTAO", new[] { "ID_TOPICO_ATRIBUIDO" });
            DropIndex("dbo.INSCR_BQ_CONVITE_REVISAO_MESTRE", new[] { "ID_QUESTAO" });
            DropIndex("dbo.INSCR_BQ_CONVITE_REVISAO_MESTRE", new[] { "ID_MESTRE" });
            DropIndex("dbo.INSCR_BQ_MESTRE", new[] { "ID_BANCA" });
            DropIndex("dbo.INSCR_BQ_CONVITE_MESTRE", new[] { "ID_TOPICO_ATRIBUIDO" });
            DropIndex("dbo.INSCR_BQ_CONVITE_MESTRE", new[] { "ID_MESTRE" });
            DropIndex("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", new[] { "INSCR_BQ_DISCIPLINA_ID_DISCIPLINA" });
            DropIndex("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", new[] { "Projeto_ProjetoId" });
            DropIndex("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", new[] { "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO" });
            DropIndex("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", new[] { "Disciplina_DisciplinaId" });
            DropIndex("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", new[] { "ID_MESTRE" });
            DropIndex("dbo.INSCR_BQ_TOPICO_ATRIBUIDO", new[] { "AreaId" });
            DropIndex("dbo.Disciplina", new[] { "INSCR_BQ_DISCIPLINA_ID_DISCIPLINA" });
            DropIndex("dbo.Disciplina", new[] { "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO" });
            DropIndex("dbo.INSCR_BQ_TOP_DISC_CARGO", new[] { "Area_AreaId" });
            DropIndex("dbo.INSCR_BQ_TOP_DISC_CARGO", new[] { "Projeto_ProjetoId" });
            DropIndex("dbo.INSCR_BQ_TOP_DISC_CARGO", new[] { "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO" });
            DropIndex("dbo.INSCR_BQ_TOP_DISC_CARGO", new[] { "Disciplina_DisciplinaId" });
            DropIndex("dbo.INSCR_BQ_TOP_DISC_CARGO", new[] { "ID_DISCIPLINA" });
            AlterColumn("dbo.Revisor", "Senha", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Revisor", "Celular", c => c.String(nullable: false, maxLength: 9));
            AlterColumn("dbo.Revisor", "Telefone", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Revisor", "EmailSecundario", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Revisor", "Email", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Revisor", "Cpf", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Revisor", "Uf", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Revisor", "Cidade", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Revisor", "Bairro", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Revisor", "Numero", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Revisor", "Complemento", c => c.String(maxLength: 100));
            AlterColumn("dbo.Revisor", "Endereco", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Revisor", "Cep", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Revisor", "Nome", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Disciplina", "Nivel", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Disciplina", "Bibliografia", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Disciplina", "Nome", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Disciplina", "Descricao", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.Disciplina", "INSCR_BQ_DISCIPLINA_ID_DISCIPLINA");
            DropColumn("dbo.Disciplina", "INSCR_BQ_CARGO_CBO_ID_CARGO_CBO");
            DropTable("dbo.INSCR_BQ_TIPO_GRAU_FORMACAO");
            DropTable("dbo.INSCR_BQ_STATUS");
            DropTable("dbo.INSCR_BQ_QUESTAO_RECICLADA_COMP");
            DropTable("dbo.INSCR_BQ_QUESTAO_APROVADA");
            DropTable("dbo.INSCR_ADMIN_PERFIL");
            DropTable("dbo.INSCR_ADMIN");
            DropTable("dbo.INSCR_BQ_DISCIPLINA");
            DropTable("dbo.MestreDependente");
            DropTable("dbo.INSCR_BQ_MESTRE_FORMACAO");
            DropTable("dbo.INSCR_BQ_RESPOSTA");
            DropTable("dbo.INSCR_BQ_RESPOSTA_REVISADA");
            DropTable("dbo.INSCR_BQ_QUESTAO_REVISOR");
            DropTable("dbo.INSCR_BQ_QUESTAO_PROJETO");
            DropTable("dbo.INSCR_BQ_QUESTAO_REVISADA");
            DropTable("dbo.INSCR_BQ_QUESTAO_RECICLAR_REVISOR");
            DropTable("dbo.INSCR_BQ_CONVITE_REVISOR");
            DropTable("dbo.INSCR_BQ_QUESTAO");
            DropTable("dbo.INSCR_BQ_CONVITE_REVISAO_MESTRE");
            DropTable("dbo.INSCR_BQ_BANCA");
            DropTable("dbo.INSCR_BQ_MESTRE");
            DropTable("dbo.INSCR_BQ_CONVITE_MESTRE");
            DropTable("dbo.INSCR_BQ_TOPICO_ATRIBUIDO");
            DropTable("dbo.INSCR_BQ_CARGO_CBO");
            DropTable("dbo.INSCR_BQ_TOP_DISC_CARGO");
            CreateIndex("dbo.FormacaoRevisor", "RevisorId");
            AddForeignKey("dbo.FormacaoRevisor", "RevisorId", "dbo.Revisor", "RevisorId");
        }
    }
}
