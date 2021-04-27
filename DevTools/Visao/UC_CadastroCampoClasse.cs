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
    public partial class UC_CadastroCampoClasse : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Constrole do campo
        /// </summary>
        Model.MD_CamposClasseEntrada campo;

        /// <summary>
        /// Controle da classe ao qual o campo pertence
        /// </summary>
        Model.MD_ClasseEntrada classe;

        /// <summary>
        /// Controle da tela principal
        /// </summary>
        FO_Principal principal;

        /// <summary>
        /// Controle do cadatro da classe de entrada
        /// </summary>
        UC_CadastroClassesEntrada cadastroClassesEntrada;

        /// <summary>
        /// Controle da tarefa a ser executada
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
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_CAMPO_CLASSE);
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre o campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_campo_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome do campo");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação do tipo do campo
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
                this.InicialisUserControl();
            }
            else
            {
                this.Confirmar();
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                if(Message.MensagemConfirmaçãoYesNo("Deseja excluir o campo " + this.campo.DAO.Nomecampo + "?") == DialogResult.Yes)
                {
                    if (this.campo.DAO.Delete())
                    {
                        Message.MensagemSucesso("Campo excluído com sucesso!");
                        this.cadastroClassesEntrada.ExcluiCampo(this.campo);
                        this.btn_confirmar_Click(null, null);
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir");
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
                this.InicialisUserControl();
            }
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="campo"></param>
        /// <param name="classe"></param>
        /// <param name="tarefa"></param>
        /// <param name="cadastroClassesEntrada"></param>
        /// <param name="principal"></param>
        public UC_CadastroCampoClasse(Model.MD_CamposClasseEntrada campo, Model.MD_ClasseEntrada classe, Util.Enumerator.Tarefa tarefa, UC_CadastroClassesEntrada cadastroClassesEntrada, FO_Principal principal)
        {
            this.InitializeComponent();
            this.campo = campo;
            this.classe = classe;
            this.tarefa = tarefa;
            this.cadastroClassesEntrada = cadastroClassesEntrada;
            this.principal = principal;
            this.InicialisUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a tela
        /// </summary>
        public void InicialisUserControl()
        {
            this.Dock = DockStyle.Fill;
            this.ControlaTarefa();
        }

        /// <summary>
        /// Método que controla a tarefa sendo executada
        /// </summary>
        private void ControlaTarefa()
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tbx_nomeCampo.Enabled = this.cmb_tipoCampo.Enabled = false;
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.tbx_nomeCampo.Enabled = this.cmb_tipoCampo.Enabled = true;
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }

            if(this.tarefa != Util.Enumerator.Tarefa.INCLUIR)
            {
                this.tbx_nomeCampo.Text = this.campo.DAO.Nomecampo;
                this.cmb_tipoCampo.SelectedItem = this.campo.DAO.Tipocampo;
            }
            else
            {
                this.tbx_nomeCampo.Text = string.Empty;
                this.cmb_tipoCampo.SelectedIndex = 0;
                this.tbx_nomeCampo.Focus();
            }
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            if (string.IsNullOrEmpty(this.tbx_nomeCampo.Text))
            {
                Message.MensagemAlerta("Preencha o nome do campo!");
            }
            else if(this.cmb_tipoCampo.SelectedIndex == -1)
            {
                Message.MensagemAlerta("Selecione o tipo do campo!");
            }
            else
            {
                this.campo.DAO.Classereferente = this.classe.DAO.Codigo;
                this.campo.DAO.Codigoclasseentrada = -1;
                this.campo.DAO.Nomecampo = this.tbx_nomeCampo.Text;
                this.campo.DAO.Tipocampo = this.cmb_tipoCampo.SelectedItem.ToString();

                bool retorno = tarefa == Util.Enumerator.Tarefa.INCLUIR ? this.campo.DAO.Insert() : this.campo.DAO.Update();

                if (retorno)
                {
                    Message.MensagemSucesso((tarefa == Util.Enumerator.Tarefa.INCLUIR ? "Incluído" : "Alterado") + " com sucesso");

                    if (tarefa == Util.Enumerator.Tarefa.INCLUIR)
                    {
                        this.cadastroClassesEntrada.AdicionaCampoEntrada(campo);
                        if (Message.MensagemConfirmaçãoYesNo("Deseja cadastrar mais campo para a classe " + this.classe.DAO.NomeClasse + "?") == DialogResult.Yes)
                        {
                            this.campo = new Model.MD_CamposClasseEntrada(DataBase.Connection.GetIncrement("CAMPOSCLASSEENTRADA"));
                            this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                            this.InicialisUserControl();
                        }
                        else
                        {
                            this.btn_fechar_Click(null, null);
                        }
                    }
                    else
                    {
                        this.cadastroClassesEntrada.IniciaUserControl();
                        this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                        this.cadastroClassesEntrada.IniciaUserControl();
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
