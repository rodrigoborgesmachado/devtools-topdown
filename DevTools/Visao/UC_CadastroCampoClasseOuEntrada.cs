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
    public partial class UC_CadastroCampoClasseOuEntrada : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Controle da classe principal
        /// </summary>
        FO_Principal principal = null;

        /// <summary>
        /// Controle do campo de entrada
        /// </summary>
        Model.MD_CamposEntrada campoEntrada = null;

        /// <summary>
        /// Controle da classe do método da rota
        /// </summary>
        Model.MD_RotasRepository metodoRota = null;

        /// <summary>
        /// Controle da tela que chama para cadastro de campo de entrada
        /// </summary>
        UC_ControleMetodoRotaRepository controleMetodoRotaRepository = null;

        /// <summary>
        /// Tarefa de controle da classe
        /// </summary>
        Util.Enumerator.Tarefa tarefa;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão fechar da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_CAMPOS_ENTRADA);
        }

        /// <summary>
        /// Evento lançado no clique do botão de informção do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_campo_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome do campo");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação do tipo de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tipoEntrada_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Especificar o tipo da entrada, se é body, query ou url");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação do tipo do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tipoCampo_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Especificar o tipo do campo (string, inteiro, decimal, etc");
        }

        /// <summary>
        /// Evento lançado no clique do botão de confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITAR;
                this.IniciaUserControl();
            }
            else
            {
                this.Confirma();
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                if (Message.MensagemConfirmaçãoYesNo("Deseja excluir o campo " + this.campoEntrada + "?") == DialogResult.Yes)
                {
                    if (this.campoEntrada.DAO.Delete())
                    {
                        Message.MensagemSucesso("Excluído com sucesso!");
                        this.controleMetodoRotaRepository.ExcluiCampoEntrada(campoEntrada);
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

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="campoEntrada"></param>
        /// <param name="metodoRota"></param>
        /// <param name="tarefa"></param>
        /// <param name="controleMetodoRotaRepository"></param>
        /// <param name="principal"></param>
        public UC_CadastroCampoClasseOuEntrada(Model.MD_CamposEntrada campoEntrada, Model.MD_RotasRepository metodoRota, Util.Enumerator.Tarefa tarefa, UC_ControleMetodoRotaRepository controleMetodoRotaRepository, FO_Principal principal)
        {
            this.InitializeComponent();

            this.campoEntrada = campoEntrada;
            if (this.campoEntrada == null)
                this.campoEntrada = new Model.MD_CamposEntrada(DataBase.Connection.GetIncrement("CAMPOSENTRADA"));

            this.metodoRota = metodoRota;
            this.tarefa = tarefa;
            this.principal = principal;
            this.controleMetodoRotaRepository = controleMetodoRotaRepository;
            this.IniciaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a classe
        /// </summary>
        public void IniciaUserControl()
        {
            this.Dock = DockStyle.Fill;
            this.ControleTarefa();
        }

        /// <summary>
        /// Método que controla campos através da tarefa da tela
        /// </summary>
        private void ControleTarefa()
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tbx_nomeCampo.Enabled = this.cmb_tipoCampo.Enabled = this.cmb_tipoEntrada.Enabled = false;
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.tbx_nomeCampo.Enabled = this.cmb_tipoCampo.Enabled = this.cmb_tipoEntrada.Enabled = true;
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }

            if(this.tarefa != Util.Enumerator.Tarefa.INCLUIR)
            {
                this.tbx_nomeCampo.Text = this.campoEntrada.DAO.NomeCampoEntrada;
                this.cmb_tipoCampo.SelectedItem = this.campoEntrada.DAO.TipoCampoEntrada;
                this.cmb_tipoEntrada.SelectedItem = this.campoEntrada.DAO.TipoEntrada;
            }else
            {
                this.tbx_nomeCampo.Text = string.Empty;
                this.cmb_tipoCampo.SelectedIndex = 0;
                this.cmb_tipoEntrada.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirma()
        {
            if (string.IsNullOrEmpty(this.tbx_nomeCampo.Text))
            {
                Message.MensagemAlerta("Preencha o nome do campo!");
            }
            else if(this.cmb_tipoCampo.SelectedIndex == -1){
                Message.MensagemAlerta("Preencha o tipo do campo!");
            }
            else if(this.cmb_tipoEntrada.SelectedIndex == -1){
                Message.MensagemAlerta("Preencha o tipo de entrada!");
            }
            else
            {
                this.campoEntrada.DAO.CoditoRotaRepository = this.metodoRota.DAO.Codigo;
                this.campoEntrada.DAO.NomeCampoEntrada = this.tbx_nomeCampo.Text;
                this.campoEntrada.DAO.TipoCampoEntrada = this.cmb_tipoCampo.SelectedItem.ToString();
                this.campoEntrada.DAO.TipoEntrada = this.cmb_tipoEntrada.SelectedItem.ToString();

                bool retorno = tarefa == Util.Enumerator.Tarefa.INCLUIR ? this.campoEntrada.DAO.Insert() : this.campoEntrada.DAO.Update();
                if (retorno)
                {
                    Message.MensagemSucesso((tarefa == Util.Enumerator.Tarefa.INCLUIR ? "Incluído" : "Alterado") +" com sucesso!");

                    if(tarefa == Util.Enumerator.Tarefa.INCLUIR)
                    {
                        this.controleMetodoRotaRepository.AdicionaCampoEntrada(campoEntrada);
                        if(Message.MensagemConfirmaçãoYesNo("Deseja cadastrar um novo campo?") == DialogResult.Yes)
                        {
                            this.campoEntrada = new Model.MD_CamposEntrada(DataBase.Connection.GetIncrement("CAMPOSENTRADA"));
                            this.tarefa = Util.Enumerator.Tarefa.INCLUIR;
                            this.IniciaUserControl();
                        }
                        else
                        {
                            this.btn_fechar_Click(null, null);
                        }
                    }
                    else
                    {
                        this.controleMetodoRotaRepository.IniciaUserControl();
                        this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                        this.IniciaUserControl();
                    }
                }
                else
                {
                    Message.MensagemErro("Erro ao cadastrar");
                }
            }
        }

        #endregion Métodos
        
    }
}
