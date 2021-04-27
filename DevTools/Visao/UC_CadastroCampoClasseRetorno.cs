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
    public partial class UC_CadastroCampoClasseRetorno : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Classe de controle do campo de retorno
        /// </summary>
        Model.MD_CamposClasseRetorno campoRetorno;

        /// <summary>
        /// classe de armasenamento repository
        /// </summary>
        Model.MD_ClasseRetornoRepository classeRepository;

        /// <summary>
        /// Controle da classe de retorno repository
        /// </summary>
        Model.MD_RetornoRotaRepository retornoRotaRepository;

        /// <summary>
        /// controle da classe de saída
        /// </summary>
        UC_CadastroClasseSaida telaClasseSaida;

        /// <summary>
        /// Controle da classe de cadastro de retorno
        /// </summary>
        UC_CadastroTipoRetorno cadastroTipoRetorno;

        /// <summary>
        /// Controle da classe principal
        /// </summary>
        FO_Principal principal;

        /// <summary>
        /// Controle da tarefa da tela
        /// </summary>
        Util.Enumerator.Tarefa tarefa;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão fechar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(this.telaClasseSaida != null ? Util.Enumerator.Telas.CADASTRO_CAMPO_SAIDA_CLASSE : Util.Enumerator.Telas.CADASTRO_CAMPO_SAIDA);
        }

        /// <summary>
        /// Evento lançado no clique do campo informação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_campo_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome do campo");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tipoCampo_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Tipo do campo");
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITAR;
                this.InicializaUserControl();
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
                if(Message.MensagemConfirmaçãoYesNo("Deseja excluir o campo " + campoRetorno.DAO.NomeCampo + "?") == DialogResult.Yes)
                {
                    if (this.campoRetorno.DAO.Delete())
                    {
                        Message.MensagemSucesso("Excluído com sucesso!");
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir!");
                    }
                }
            }
            else if(this.tarefa == Util.Enumerator.Tarefa.INCLUIR)
            {
                this.btn_fechar_Click(null, null);
            }
            else
            {
                this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                this.InicializaUserControl();
            }
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Contrutor principal da classe
        /// </summary>
        /// <param name="campoRetorno"></param>
        /// <param name="classeRepository"></param>
        /// <param name="tarefa"></param>
        /// <param name="telaClasseSaida"></param>
        /// <param name="principal"></param>
        public UC_CadastroCampoClasseRetorno(Model.MD_CamposClasseRetorno campoRetorno, Model.MD_ClasseRetornoRepository classeRepository, Util.Enumerator.Tarefa tarefa, UC_CadastroClasseSaida telaClasseSaida, FO_Principal principal)
        {
            InitializeComponent();
            this.campoRetorno = campoRetorno;
            this.classeRepository = classeRepository;
            this.retornoRotaRepository = null;
            this.telaClasseSaida = telaClasseSaida;
            this.cadastroTipoRetorno = null;
            this.tarefa = tarefa;
            this.principal = principal;
            this.InicializaUserControl();
        }

        /// <summary>
        /// Construtor secundário
        /// </summary>
        /// <param name="campoRetorno"></param>
        /// <param name="retornoRotaRepository"></param>
        /// <param name="tarefa"></param>
        /// <param name="cadastroTipoRetorno"></param>
        /// <param name="principal"></param>
        public UC_CadastroCampoClasseRetorno(Model.MD_CamposClasseRetorno campoRetorno, Model.MD_RetornoRotaRepository retornoRotaRepository, Util.Enumerator.Tarefa tarefa, UC_CadastroTipoRetorno cadastroTipoRetorno, FO_Principal principal)
        {
            InitializeComponent();
            this.campoRetorno = campoRetorno;
            this.classeRepository = null;
            this.retornoRotaRepository = retornoRotaRepository;
            this.telaClasseSaida = null;
            this.cadastroTipoRetorno = cadastroTipoRetorno;
            this.tarefa = tarefa;
            this.principal = principal;
            this.InicializaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o user control
        /// </summary>
        public void InicializaUserControl()
        {
            this.Dock = DockStyle.Fill;
            this.ControleTarefa();
        }

        /// <summary>
        /// Método que controla a tarefa da tela
        /// </summary>
        private void ControleTarefa()
        {
            if(tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tbx_nomeCampo.Enabled = this.cmb_tipoCampo.Enabled = false;
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
            else{
                this.tbx_nomeCampo.Enabled = this.cmb_tipoCampo.Enabled = true;
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }

            if(tarefa != Util.Enumerator.Tarefa.INCLUIR)
            {
                this.tbx_nomeCampo.Text = this.campoRetorno.DAO.NomeCampo;
                this.cmb_tipoCampo.SelectedItem = this.campoRetorno.DAO.TipoCampo;
            }
            else
            {
                this.cmb_tipoCampo.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            if (string.IsNullOrEmpty(this.tbx_nomeCampo.Text))
            {
                Message.MensagemAlerta("O nome do campo não foi fornecido");
            }
            else if(this.cmb_tipoCampo.SelectedIndex == -1)
            {
                Message.MensagemAlerta("Selecione o tipo do campo");
            }
            else
            {
                this.campoRetorno.DAO.NomeCampo = this.tbx_nomeCampo.Text;
                this.campoRetorno.DAO.TipoCampo = this.cmb_tipoCampo.SelectedItem.ToString();
                if(classeRepository != null)
                {
                    this.campoRetorno.DAO.Codigoclasse = this.classeRepository.DAO.Codigo.ToString();
                    this.campoRetorno.DAO.CodigoRotaRetorno = "-1";
                }
                else
                {
                    this.campoRetorno.DAO.Codigoclasse = "-1";
                    this.campoRetorno.DAO.CodigoRotaRetorno = this.retornoRotaRepository.DAO.Codigo.ToString();
                }
                this.campoRetorno.DAO.Comentariocampo = string.Empty;

                bool retorno = tarefa == Util.Enumerator.Tarefa.INCLUIR ? this.campoRetorno.DAO.Insert() : this.campoRetorno.DAO.Update();
                if (retorno)
                {
                    Message.MensagemSucesso((tarefa == Util.Enumerator.Tarefa.INCLUIR ? "Incluído" : "Alterado") + " com sucesso!");

                    if(this.tarefa == Util.Enumerator.Tarefa.INCLUIR)
                    {
                        if (classeRepository != null)
                        {
                            this.telaClasseSaida.AdicionaCampoRetorno(this.campoRetorno);
                        }
                        else
                        {
                            this.cadastroTipoRetorno.AdicionaCampoRetorno(this.campoRetorno);
                        }

                        if (Message.MensagemConfirmaçãoYesNo("Deseja cadastrar mais um campo?") == DialogResult.Yes)
                        {
                            if (classeRepository != null)
                            {
                                this.principal.AbrirCadastroCampoSaida(new Model.MD_CamposClasseRetorno(DataBase.Connection.GetIncrement("CAMPOSCLASSERETORNO")), this.classeRepository, Util.Enumerator.Tarefa.INCLUIR, this.telaClasseSaida);
                            }
                            else
                            {
                                this.principal.AbrirCadastroCampoSaida(new Model.MD_CamposClasseRetorno(DataBase.Connection.GetIncrement("CAMPOSCLASSERETORNO")), this.retornoRotaRepository, Util.Enumerator.Tarefa.INCLUIR, this.cadastroTipoRetorno);
                            }
                        }
                        else
                        {
                            this.btn_fechar_Click(null, null);
                        }
                    }
                    else
                    {
                        if (classeRepository != null)
                        {
                            this.telaClasseSaida.IniciaUserControl();
                        }
                        else
                        {
                            this.cadastroTipoRetorno.IniciaUserControl();
                        }
                    }
                    
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
