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
    public partial class UC_ControleMetodoRotaRepository : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Constrole da tela principal
        /// </summary>
        FO_Principal principal = null;

        /// <summary>
        /// Constrole da classe modelo da api
        /// </summary>
        Model.MD_ApiRepository apiRepository = null;

        /// <summary>
        /// Controle do projeto
        /// </summary>
        Model.MD_Projeto projeto = null;

        /// <summary>
        /// Controle da rota da tela
        /// </summary>
        Model.MD_RotasRepository metodoRota = null;

        /// <summary>
        /// Constrole da classe de rota
        /// </summary>
        UC_CadastroRotaRepository cadastroRota = null;

        /// <summary>
        /// Constrole da tarefa
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUIR;

        /// <summary>
        /// Lista dos campos de entrada
        /// </summary>
        List<Model.MD_CamposEntrada> listaCamposEntrada = new List<Model.MD_CamposEntrada>();

        /// <summary>
        /// Lista das classes de entrada
        /// </summary>
        List<Model.MD_ClasseEntrada> listaClasseEntrada = new List<Model.MD_ClasseEntrada>();

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no botão de fechar a janela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_METODO_ROTA_REPOSITORY);
        }

        /// <summary>
        /// Evento lançado no botão confirmar
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
            else if (string.IsNullOrEmpty(this.tbx_nomeMetodo.Text))
            {
                Message.MensagemAlerta("O nome do método não foi preenchido!");
            }
            else if (string.IsNullOrEmpty(this.tbx_rota.Text))
            {
                Message.MensagemAlerta("A rota não foi preenchida!");
            }
            else if(this.cmb_tipoMetodo.SelectedIndex == -1)
            {
                Message.MensagemAlerta("O tipo do método não foi selecionado!");
            }
            else
            {
                this.metodoRota.DAO.Consulta = this.tbx_ConsultaProcedure.Text;
                this.metodoRota.DAO.Codigoapirepository = this.apiRepository.DAO.Codigo;
                this.metodoRota.DAO.NomeMetodo = this.tbx_nomeMetodo.Text;
                this.metodoRota.DAO.Rota = this.tbx_rota.Text;
                this.metodoRota.DAO.TipoMetodo = this.cmb_tipoMetodo.SelectedItem.ToString();

                bool retorno = tarefa == Util.Enumerator.Tarefa.EDITAR ? this.metodoRota.DAO.Update() : this.metodoRota.DAO.Insert();

                if (retorno)
                {
                    Message.MensagemSucesso((tarefa == Util.Enumerator.Tarefa.EDITAR ? "Alterado" : "Incluído") + " com sucesso!");
                    if (this.cadastroRota == null)
                    {
                        this.cadastroRota.IniciaUserControl();
                    }
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                    this.InicializaUserControl();
                }
                else
                {
                    Message.MensagemErro("Erro ao inserir!");
                }
            }
        }

        /// <summary>
        /// Evento lançado quando selecionado o botão de excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                if(Message.MensagemConfirmaçãoYesNo("Deseja excluir o método " + this.metodoRota.DAO.NomeMetodo + "?") == DialogResult.Yes)
                {
                    if (this.metodoRota.DAO.Delete())
                    {
                        Message.MensagemSucesso("Excluído com sucesso!");
                        if(this.cadastroRota == null)
                        {
                            this.cadastroRota.IniciaUserControl();
                        }
                        this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_METODO_ROTA_REPOSITORY);
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir");
                    }
                }
                else
                {
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                    this.InicializaUserControl();
                }
            }
            else if(tarefa == Util.Enumerator.Tarefa.INCLUIR)
            {
                this.btn_fechar_Click(null, null);
            }
            else
            {
                this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                this.InicializaUserControl();
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de editar campo de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionarCampoEntrada_Click(object sender, EventArgs e)
        {
            if(Message.MensagemConfirmaçãoYesNo("O campo de entrada é uma classe?") == DialogResult.Yes)
            {
                this.principal.AbrirCadastroClasseEntrada(new Model.MD_ClasseEntrada(DataBase.Connection.GetIncrement("CLASSEENTRADA")), this.metodoRota, Util.Enumerator.Tarefa.INCLUIR, this);
            }
            else
            {
                this.principal.AbrirCadastroCampoEntrada(new Model.MD_CamposEntrada(DataBase.Connection.GetIncrement("CAMPOSENTRADA")), this.metodoRota, Util.Enumerator.Tarefa.INCLUIR, this);
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de edição do campo de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarCampoEntrada_Click(object sender, EventArgs e)
        {
            if(dgv_camposEntrada.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um campo de entrada na tabela!");
            }
            else
            {
                int codigo = int.Parse(this.dgv_camposEntrada.SelectedRows[0].Cells[0].FormattedValue.ToString());
                string tipo = this.dgv_camposEntrada.SelectedRows[0].Cells[1].FormattedValue.ToString();
                if (tipo.Equals("Campo"))
                {
                    this.principal.AbrirCadastroCampoEntrada(new Model.MD_CamposEntrada(codigo), this.metodoRota, Util.Enumerator.Tarefa.EDITAR, this);
                }
                else
                {
                    this.principal.AbrirCadastroClasseEntrada(new Model.MD_ClasseEntrada(codigo), this.metodoRota, Util.Enumerator.Tarefa.EDITAR, this);
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de remover o campo de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerCampoEntrada_Click(object sender, EventArgs e)
        {
            if (dgv_camposEntrada.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um campo de entrada na tabela!");
            }
            else
            {
                int codigo = int.Parse(this.dgv_camposEntrada.SelectedRows[0].Cells[0].FormattedValue.ToString());
                string tipo = this.dgv_camposEntrada.SelectedRows[0].Cells[1].FormattedValue.ToString();

                bool retorno = false;
                if (tipo.Equals("Campo"))
                {
                    Model.MD_CamposEntrada campo = new Model.MD_CamposEntrada(codigo);
                    retorno = campo.DAO.Delete();
                }
                else
                {
                    Model.MD_ClasseEntrada classe = new Model.MD_ClasseEntrada(codigo);
                    retorno = classe.DAO.Delete();
                }

                if (retorno)
                {
                    Message.MensagemSucesso("Excluído com sucesso");
                    this.CarregaTabelaVariaveisEntrada();
                }
                else
                {
                    Message.MensagemErro("Erro ao excluir o campo");
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de visualizar a variável
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_visualizarVariavelEntrada_Click(object sender, EventArgs e)
        {
            if (dgv_camposEntrada.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um campo de entrada na tabela!");
            }
            else
            {
                int codigo = int.Parse(this.dgv_camposEntrada.SelectedRows[0].Cells[0].FormattedValue.ToString());
                string tipo = this.dgv_camposEntrada.SelectedRows[0].Cells[1].FormattedValue.ToString();
                if (tipo.Equals("Campo"))
                {
                    this.principal.AbrirCadastroCampoEntrada(new Model.MD_CamposEntrada(codigo), this.metodoRota, Util.Enumerator.Tarefa.VISUALIZAR, this);
                }
                else
                {
                    this.principal.AbrirCadastroClasseEntrada(new Model.MD_ClasseEntrada(codigo), this.metodoRota, Util.Enumerator.Tarefa.VISUALIZAR, this);
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de visualizar a consulta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_visualizarConsulta_Click(object sender, EventArgs e)
        {
            FO_Consulta consulta = new FO_Consulta(this.tbx_ConsultaProcedure.Text);
            consulta.Show();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="rota"></param>
        /// <param name="api"></param>
        /// <param name="tarefa"></param>
        /// <param name="principal"></param>
        public UC_ControleMetodoRotaRepository(Model.MD_RotasRepository rota, Model.MD_ApiRepository api, Util.Enumerator.Tarefa tarefa, FO_Principal principal, UC_CadastroRotaRepository cadastroRota = null)
        {
            this.InitializeComponent();

            if(rota == null)
            {
                rota = new Model.MD_RotasRepository(DataBase.Connection.GetIncrement("ROTASREPOSITORY"));
            }
            this.metodoRota = rota;
            this.apiRepository = api;
            this.projeto = new Model.MD_Projeto(this.apiRepository.DAO.CodigoProjeto);
            this.tarefa = tarefa;
            this.principal = principal;
            this.cadastroRota = cadastroRota;

            this.InicializaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a tela
        /// </summary>
        public void InicializaUserControl()
        {
            this.Dock = DockStyle.Fill;
            this.grb_metodo.Text = "Método - Rota: " + this.apiRepository.DAO.NomeRota;
            this.ControlaTarefa();
            this.CarregaTabelaVariaveisEntrada();
        }

        /// <summary>
        /// Método que controla a apresentação dos campos
        /// </summary>
        public void ControlaTarefa()
        {
            if(tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.cmb_tipoMetodo.Enabled = this.tbx_ConsultaProcedure.Enabled = this.tbx_nomeMetodo.Enabled = this.tbx_rota.Enabled = false;
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.cmb_tipoMetodo.Enabled = this.tbx_ConsultaProcedure.Enabled = this.tbx_nomeMetodo.Enabled = this.tbx_rota.Enabled = true;
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }

            if(tarefa != Util.Enumerator.Tarefa.INCLUIR)
            {
                this.tbx_ConsultaProcedure.Text = this.metodoRota.DAO.Consulta;
                this.tbx_nomeMetodo.Text = this.metodoRota.DAO.NomeMetodo;
                this.tbx_rota.Text = this.metodoRota.DAO.Rota;
                this.cmb_tipoMetodo.SelectedItem = this.metodoRota.DAO.TipoMetodo;
            }
        }

        /// <summary>
        /// Método que carrega 
        /// </summary>
        public void CarregaTabelaVariaveisEntrada()
        {
            this.listaCamposEntrada = Model.MD_CamposEntrada.RetornaCamposEntradaRota(this.metodoRota.DAO.Codigo);
            this.listaClasseEntrada = Model.MD_ClasseEntrada.RetornaClassesEntradaRota(this.metodoRota.DAO.Codigo);

            this.dgv_camposEntrada.Rows.Clear();
            this.dgv_camposEntrada.Columns.Clear();

            this.dgv_camposEntrada.Columns.Add("Código", "Código");
            this.dgv_camposEntrada.Columns.Add("Tipo", "Tipo");
            this.dgv_camposEntrada.Columns.Add("Nome", "Nome");
            this.dgv_camposEntrada.Columns.Add("Tipo entrada", "Tipo entrada");
            this.dgv_camposEntrada.Columns.Add("Tipo campo", "Tipo campo");

            this.listaCamposEntrada.ForEach(c => CarregaTabelaVariaveisEntrada(c));
            this.listaClasseEntrada.ForEach(c => CarregaTabelaVariaveisEntrada(c));
        }

        /// <summary>
        /// Método que carrega tabela de entrada
        /// </summary>
        /// <param name="campo"></param>
        public void CarregaTabelaVariaveisEntrada(Model.MD_CamposEntrada campo)
        {
            List<string> list = new List<string>();
            list.Add(campo.DAO.Codigo.ToString());
            list.Add("Campo");
            list.Add(campo.DAO.NomeCampoEntrada);
            list.Add(campo.DAO.TipoEntrada);
            list.Add(campo.DAO.TipoCampoEntrada);

            this.dgv_camposEntrada.Rows.Add(list.ToArray());
        }

        /// <summary>
        /// Método que carrega tabela de entrada
        /// </summary>
        /// <param name="campo"></param>
        public void CarregaTabelaVariaveisEntrada(Model.MD_ClasseEntrada classe)
        {
            List<string> list = new List<string>();
            list.Add(classe.DAO.Codigo.ToString());
            list.Add("Classe");
            list.Add(classe.DAO.NomeClasse);
            list.Add(classe.DAO.TipoClasse);
            list.Add(classe.DAO.TipoEntrada);

            this.dgv_camposEntrada.Rows.Add(list.ToArray());
        }

        /// <summary>
        /// Método que adiciona na lista e no grid o novo campo
        /// </summary>
        /// <param name="campo"></param>
        public void AdicionaCampoEntrada(Model.MD_CamposEntrada campo)
        {
            this.CarregaTabelaVariaveisEntrada(campo);
            this.listaCamposEntrada.Add(campo);
        }

        /// <summary>
        /// Método que adiciona na lista e no grid a nova classe
        /// </summary>
        /// <param name="campo"></param>
        public void AdicionaClasseEntrada(Model.MD_ClasseEntrada classe)
        {
            this.CarregaTabelaVariaveisEntrada(classe);
            this.listaClasseEntrada.Add(classe);
        }

        /// <summary>
        /// Método que exlui na lista e no grid o campo
        /// </summary>
        /// <param name="campo"></param>
        public void ExcluiCampoEntrada(Model.MD_CamposEntrada campo)
        {
            this.listaCamposEntrada.Remove(campo);
            this.CarregaTabelaVariaveisEntrada();
        }

        /// <summary>
        /// Método que exclui na lista e no grid a classe
        /// </summary>
        /// <param name="campo"></param>
        public void ExcluiClasseEntrada(Model.MD_ClasseEntrada classe)
        {
            this.listaClasseEntrada.Remove(classe);
            this.CarregaTabelaVariaveisEntrada();
        }

        #endregion Métodos
        
    }
}
