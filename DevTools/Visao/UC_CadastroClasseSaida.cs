using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visao
{
    public partial class UC_CadastroClasseSaida : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Controle da classe de tipo de saída
        /// </summary>
        UC_CadastroTipoRetorno telaCadastroTipoRetorno;

        /// <summary>
        /// Controle da classe mãe de saída
        /// </summary>
        UC_CadastroClasseSaida telaClasseMae;

        /// <summary>
        /// Controle da classe principal
        /// </summary>
        FO_Principal principal;

        /// <summary>
        /// Controle do retorno da rota repository
        /// </summary>
        Model.MD_RetornoRotaRepository retornoRotaRepository;

        /// <summary>
        /// Controle da classe de retorno 
        /// </summary>
        Model.MD_ClasseRetornoRepository classeRetorno;

        /// <summary>
        /// Controle da classe mãe
        /// </summary>
        Model.MD_ClasseRetornoRepository classeRetornoMae;

        /// <summary>
        /// Lista dos campos da classe
        /// </summary>
        List<Model.MD_CamposClasseRetorno> listaCampos = new List<Model.MD_CamposClasseRetorno>();

        /// <summary>
        /// Lista de classes de retorno
        /// </summary>
        List<Model.MD_ClasseRetornoRepository> listaClasses = new List<Model.MD_ClasseRetornoRepository>();

        /// <summary>
        /// Controle da tarefa do campo
        /// </summary>
        Util.Enumerator.Tarefa tarefa;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento acionado no clique do botão fechar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(this.classeRetornoMae == null ? Util.Enumerator.Telas.CADASTRO_CLASSE_SAIDA : Util.Enumerator.Telas.CADASTRO_CLASSE_CLASSE_FILHA);
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_nomeClasse_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome da classe");
        }

        /// <summary>
        /// Evento lançado no clique do botão de adicionar campo da classe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionarCampoEntrada_Click(object sender, EventArgs e)
        {
            if (Message.MensagemConfirmaçãoYesNo("Vai adicionar uma classe à essa?") == DialogResult.Yes)
            {
                this.principal.AbrirCadastroClasseSaidaFilha(new Model.MD_ClasseRetornoRepository(DataBase.Connection.GetIncrement("CLASSERETORNOREPOSITORY")), this.classeRetorno, Util.Enumerator.Tarefa.INCLUIR, this);
            }
            else
            {
                this.principal.AbrirCadastroCampoSaida(new Model.MD_CamposClasseRetorno(DataBase.Connection.GetIncrement("CAMPOSCLASSERETORNO")), this.classeRetorno, Util.Enumerator.Tarefa.INCLUIR, this);
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarCampoEntrada_Click(object sender, EventArgs e)
        {
            if (this.dgv_camposClasse.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid");
            }
            else
            {
                int codigo = int.Parse(this.dgv_camposClasse.SelectedRows[0].Cells[0].FormattedValue.ToString());
                if (this.dgv_camposClasse.SelectedRows[0].Cells[3].FormattedValue.ToString().Equals("Classe"))
                {
                    this.principal.AbrirCadastroClasseSaidaFilha(this.listaClasses.Where(l => l.DAO.Codigo.Equals(codigo)).FirstOrDefault(), this.classeRetorno, Util.Enumerator.Tarefa.EDITAR, this);
                }
                else
                {
                    this.principal.AbrirCadastroCampoSaida(new Model.MD_CamposClasseRetorno(codigo), this.classeRetorno, Util.Enumerator.Tarefa.EDITAR, this);
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão remover campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerCampoEntrada_Click(object sender, EventArgs e)
        {
            if (this.dgv_camposClasse.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid");
            }
            else
            {
                int codigo = int.Parse(this.dgv_camposClasse.SelectedRows[0].Cells[0].FormattedValue.ToString());
                if (this.dgv_camposClasse.SelectedRows[0].Cells[3].FormattedValue.ToString().Equals("Classe"))
                {
                    Model.MD_ClasseRetornoRepository classe = this.listaClasses.Where(l => l.DAO.Codigo.Equals(codigo)).FirstOrDefault();
                    if(Message.MensagemConfirmaçãoYesNo("Deseja excluir a classe " + classe.DAO.Nome + "?") == DialogResult.Yes)
                    {
                        if (classe.DAO.Delete())
                        {
                            Message.MensagemSucesso("Excluído com sucesso!");
                        }
                        else
                        {
                            Message.MensagemErro("Erro ao excluir!");
                        }
                    }
                }
                else
                {
                    Model.MD_CamposClasseRetorno classe = this.listaCampos.Where(l => l.DAO.Codigo.Equals(codigo)).FirstOrDefault();
                    if (Message.MensagemConfirmaçãoYesNo("Deseja excluir a classe " + classe.DAO.NomeCampo + "?") == DialogResult.Yes)
                    {
                        if (classe.DAO.Delete())
                        {
                            Message.MensagemSucesso("Excluído com sucesso!");
                        }
                        else
                        {
                            Message.MensagemErro("Erro ao excluir!");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de visualizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_visualizarVariavelEntrada_Click(object sender, EventArgs e)
        {
            if (this.dgv_camposClasse.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid");
            }
            else
            {
                int codigo = int.Parse(this.dgv_camposClasse.SelectedRows[0].Cells[0].FormattedValue.ToString());
                if (this.dgv_camposClasse.SelectedRows[0].Cells[3].FormattedValue.ToString().Equals("Classe"))
                {
                    this.principal.AbrirCadastroClasseSaidaFilha(this.listaClasses.Where(l => l.DAO.Codigo.Equals(codigo)).FirstOrDefault(), this.classeRetorno, Util.Enumerator.Tarefa.VISUALIZAR, this);
                }
                else
                {
                    this.principal.AbrirCadastroCampoSaida(new Model.MD_CamposClasseRetorno(codigo), this.classeRetorno, Util.Enumerator.Tarefa.VISUALIZAR, this);
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do bõtão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITAR;
            }
            else
            {
                this.Confirmar();
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                if(Message.MensagemConfirmaçãoYesNo("Deseja excluir a classe " + classeRetorno.DAO.Nome + "?") == DialogResult.Yes)
                {
                    if (this.classeRetorno.DAO.Delete())
                    {
                        Message.MensagemSucesso("Excluído com sucesso!");
                        if (classeRetornoMae == null)
                        {
                            this.telaCadastroTipoRetorno.IniciaUserControl();
                        }
                        else
                        {
                            this.telaClasseMae.IniciaUserControl();
                        }
                        this.btn_fechar_Click(null, null);
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir");
                    }
                }
            }
            else if (this.tarefa == Util.Enumerator.Tarefa.INCLUIR)
            {
                this.btn_fechar_Click(null, null);
            }
            else
            {
                this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                this.IniciaUserControl();
            }
        }

        /// <summary>
        /// Evento disparado no clique da opção de reload da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reload_tabela_Click(object sender, EventArgs e)
        {
            this.CarregaTabelaCamposClasse();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="classeRetorno">Classe a ser inserida</param>
        /// <param name="retornoRotaRepository"></param>
        /// <param name="tarefa"></param>
        /// <param name="telaCadastroTipoRetorno"></param>
        /// <param name="principal"></param>
        public UC_CadastroClasseSaida(Model.MD_ClasseRetornoRepository classeRetorno, Model.MD_RetornoRotaRepository retornoRotaRepository, Util.Enumerator.Tarefa tarefa, UC_CadastroTipoRetorno telaCadastroTipoRetorno, FO_Principal principal)
        {
            InitializeComponent();
            if(classeRetorno == null)
            {
                classeRetorno = new Model.MD_ClasseRetornoRepository(DataBase.Connection.GetIncrement("CLASSERETORNOREPOSITORY"));
            }

            this.classeRetorno = classeRetorno;
            this.retornoRotaRepository = retornoRotaRepository;
            this.classeRetornoMae = null;
            this.telaCadastroTipoRetorno = telaCadastroTipoRetorno;
            this.telaClasseMae = null;
            this.tarefa = tarefa;
            this.principal = principal;
            this.IniciaUserControl();
        }

        /// <summary>
        /// Construtor secundário da classe
        /// </summary>
        /// <param name="classeRetorno"></param>
        /// <param name="classeRetornoMae"></param>
        /// <param name="tarefa"></param>
        /// <param name="telaClasseMae"></param>
        /// <param name="principal"></param>
        public UC_CadastroClasseSaida(Model.MD_ClasseRetornoRepository classeRetorno, Model.MD_ClasseRetornoRepository classeRetornoMae, Util.Enumerator.Tarefa tarefa, UC_CadastroClasseSaida telaClasseMae, FO_Principal principal)
        {
            InitializeComponent();
            if (classeRetorno == null)
            {
                classeRetorno = new Model.MD_ClasseRetornoRepository(DataBase.Connection.GetIncrement("CLASSERETORNOREPOSITORY"));
            }

            this.classeRetorno = classeRetorno;
            this.retornoRotaRepository = null;
            this.classeRetornoMae = classeRetornoMae;
            this.telaCadastroTipoRetorno = null;
            this.telaClasseMae = telaClasseMae;
            this.tarefa = tarefa;
            this.principal = principal;
            this.IniciaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicia o formulário
        /// </summary>
        public void IniciaUserControl()
        {
            this.Dock = DockStyle.Fill;
            this.ControlaTarefa();
            this.CarregaTabelaCamposClasse();
        }

        /// <summary>
        /// Método que controla a tarefa da tela
        /// </summary>
        private void ControlaTarefa()
        {
            if(tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tbx_nomeClasse.Enabled = false;
                this.btn_adicionarCampoEntrada.Enabled = this.btn_editarCampoEntrada.Enabled = this.btn_removerCampoEntrada.Enabled = this.btn_visualizarVariavelEntrada.Enabled = true;
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.tbx_nomeClasse.Enabled = true;
                this.btn_adicionarCampoEntrada.Enabled = this.btn_editarCampoEntrada.Enabled = this.btn_removerCampoEntrada.Enabled = this.btn_visualizarVariavelEntrada.Enabled = false;
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }

            if(tarefa != Util.Enumerator.Tarefa.INCLUIR)
            {
                this.tbx_nomeClasse.Text = this.classeRetorno.DAO.Nome;
            }
        }

        /// <summary>
        /// Método que carrega a tabela com os campos da classe
        /// </summary>
        public void CarregaTabelaCamposClasse()
        {
            this.listaClasses = Model.MD_ClasseRetornoRepository.RetornaRetornosClasses(this.classeRetorno.DAO.Codigo);
            this.listaCampos = Model.MD_CamposClasseRetorno.RetornaRetornosCampoClasses(this.classeRetorno.DAO.Codigo);

            this.dgv_camposClasse.Rows.Clear();
            this.dgv_camposClasse.Columns.Clear();

            this.dgv_camposClasse.Columns.Add("Código", "Código");
            this.dgv_camposClasse.Columns.Add("Nome", "Nome");
            this.dgv_camposClasse.Columns.Add("Tipo", "Tipo");
            this.dgv_camposClasse.Columns.Add("Tipo retorno", "Tipo retorno");

            this.listaCampos.ForEach(c => CarregaTabelaCamposClasse(c));
            this.listaClasses.ForEach(c => CarregaTabelaCamposClasse(c));
        }

        /// <summary>
        /// Método que carrega tabela de entrada
        /// </summary>
        /// <param name="campo"></param>
        public void CarregaTabelaCamposClasse(Model.MD_CamposClasseRetorno campo)
        {
            List<string> list = new List<string>();
            list.Add(campo.DAO.Codigo.ToString());
            list.Add(campo.DAO.NomeCampo);
            list.Add(campo.DAO.TipoCampo);
            list.Add("Campo");

            this.dgv_camposClasse.Rows.Add(list.ToArray());
        }

        /// <summary>
        /// Método que carrega tabela de entrada
        /// </summary>
        /// <param name="campo"></param>
        public void CarregaTabelaCamposClasse(Model.MD_ClasseRetornoRepository campo)
        {
            List<string> list = new List<string>();
            list.Add(campo.DAO.Codigo.ToString());
            list.Add(campo.DAO.Nome);
            list.Add(string.Empty);
            list.Add("Classe");

            this.dgv_camposClasse.Rows.Add(list.ToArray());
        }

        /// <summary>
        /// Método que adiciona na lista e no grid o novo campo
        /// </summary>
        /// <param name="campo"></param>
        public void AdicionaCampoRetorno(Model.MD_CamposClasseRetorno campo)
        {
            this.CarregaTabelaCamposClasse(campo);
            this.listaCampos.Add(campo);
        }

        /// <summary>
        /// Método que adiciona na lista e no grid o novo campo
        /// </summary>
        /// <param name="campo"></param>
        public void AdicionaCampoRetorno(Model.MD_ClasseRetornoRepository campo)
        {
            this.CarregaTabelaCamposClasse(campo);
            this.listaClasses.Add(campo);
        }

        /// <summary>
        /// Método que exlui na lista e no grid o campo
        /// </summary>
        /// <param name="campo"></param>
        public void ExcluiCampo(Model.MD_CamposClasseRetorno campo)
        {
            this.listaCampos.Remove(campo);
            this.CarregaTabelaCamposClasse();
        }

        /// <summary>
        /// Método que exlui na lista e no grid o campo
        /// </summary>
        /// <param name="campo"></param>
        public void ExcluiCampo(Model.MD_ClasseRetornoRepository campo)
        {
            this.listaClasses.Remove(campo);
            this.CarregaTabelaCamposClasse();
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            if (string.IsNullOrEmpty(this.tbx_nomeClasse.Text))
            {
                Message.MensagemAlerta("O nome da classe não foi informado");
            }
            else
            {
                this.classeRetorno.DAO.Nome = this.tbx_nomeClasse.Text;
                this.classeRetorno.DAO.Classemae = (this.classeRetornoMae == null ? -1 : this.classeRetornoMae.DAO.Codigo);
                this.classeRetorno.DAO.Comentario = string.Empty;

                if(classeRetornoMae == null)
                {
                    this.classeRetorno.DAO.Classemae = -1;
                    this.classeRetorno.DAO.RotaRetorno = retornoRotaRepository.DAO.Codigo;
                }
                else
                {
                    this.classeRetorno.DAO.Classemae = classeRetornoMae.DAO.Codigo;
                    this.classeRetorno.DAO.RotaRetorno = -1;
                }

                bool retorno = this.tarefa == Util.Enumerator.Tarefa.INCLUIR ? this.classeRetorno.DAO.Insert() : this.classeRetorno.DAO.Update();
                if (retorno)
                {
                    Message.MensagemSucesso((tarefa == Util.Enumerator.Tarefa.INCLUIR ? "Incluído" : "Alterado") + " com sucesso");
                    if(this.tarefa == Util.Enumerator.Tarefa.INCLUIR)
                    {
                        if(classeRetornoMae == null)
                        {
                            this.telaCadastroTipoRetorno.AdicionaCampoRetorno(this.classeRetorno);
                        }
                        else
                        {
                            this.telaClasseMae.AdicionaCampoRetorno(this.classeRetorno);
                        }
                    }
                    else
                    {
                        if (classeRetornoMae == null)
                        {
                            this.telaCadastroTipoRetorno.IniciaUserControl();
                        }
                        else
                        {
                            this.telaClasseMae.IniciaUserControl();
                        }
                    }
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                    this.IniciaUserControl();
                }
                else
                {
                    Message.MensagemErro("Erro ao " + (this.tarefa == Util.Enumerator.Tarefa.INCLUIR ? "incluir" : "alterar"));
                }
            }
        }


        #endregion Métodos
        
    }
}
