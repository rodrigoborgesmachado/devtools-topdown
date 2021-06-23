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
    public partial class UC_CadastroRotaRepository : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Controle da classe principal
        /// </summary>
        FO_Principal principal = null;

        /// <summary>
        /// Controle do projeto referente ao cadastro da rota
        /// </summary>
        Model.MD_Projeto projeto = null;

        /// <summary>
        /// Controle da apiRepository carregada na tela
        /// </summary>
        Model.MD_ApiRepository apiRepository;

        /// <summary>
        /// Controle dos métodos da apiRepository
        /// </summary>
        List<Model.MD_RotasRepository> listaMetodos = new List<Model.MD_RotasRepository>();

        /// <summary>
        /// Constrolador da tarefa que a tela está executando
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUIR;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão fechar da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_ROTA_REPOSITORY);
        }

        /// <summary>
        /// Evento lançado no botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if(tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITAR;
                this.IniciaUserControl();
            }
            else
            {
                if (string.IsNullOrEmpty(this.tbx_nomeRota.Text))
                {
                    Message.MensagemAlerta("Não foi preenchida o nome da rota");
                }
                else if (string.IsNullOrEmpty(this.tbx_rota.Text))
                {
                    Message.MensagemAlerta("Não foi preenchida a rota");
                }
                else
                {
                    this.apiRepository.DAO.CodigoProjeto = projeto.DAO.Codigo;
                    this.apiRepository.DAO.Descricao = this.tbx_descricao.Text;
                    this.apiRepository.DAO.NomeRota = this.tbx_nomeRota.Text;
                    this.apiRepository.DAO.Rota = this.tbx_rota.Text;

                    bool retorno = tarefa == Util.Enumerator.Tarefa.INCLUIR ? this.apiRepository.DAO.Insert() : this.apiRepository.DAO.Update();
                    if (retorno)
                    {
                        Message.MensagemSucesso((tarefa == Util.Enumerator.Tarefa.INCLUIR ? "Incluído" : "Alterado") + " com sucesso!");
                        this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                        this.IniciaUserControl();
                        this.principal.CarregaTreeViewAutomaticamente();
                    }
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique da opção excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                if(Message.MensagemConfirmaçãoYesNo("Deseja excluir a rota: " + this.apiRepository.DAO.NomeRota + "?") == DialogResult.Yes)
                {
                    if (this.apiRepository.DAO.Delete())
                    {
                        Message.MensagemSucesso("Excluído!");
                        this.principal.CarregaTreeViewAutomaticamente();
                        this.btn_fechar_Click(sender, e);
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir!");
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
        /// Evento lançado no clique do botão de informação do nome da rota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_NomeRota_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome da rota para criar as classes de controller e repository.");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação da rota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoRota_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Rota de acesso ao controller.");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação da descrição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_descricao_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Descrição a ser colocada como comentário na classe de rota e repository");
        }

        /// <summary>
        /// Evento lançado no clique do botão de adicionar método
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionarMetodo_Click(object sender, EventArgs e)
        {
            this.principal.AbrirJanelaCadastroMetotoRotaRepository(this.apiRepository.DAO.Codigo, DataBase.Connection.GetIncrement("ROTASREPOSITORY"), Util.Enumerator.Tarefa.INCLUIR, this);
        }

        /// <summary>
        /// Evento lançado no clique do botão editar método
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarMetodo_Click(object sender, EventArgs e)
        {
            if(this.dgv_metodos.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Nenhum método selecionado!");
            }
            else
            {
                int index = this.dgv_metodos.SelectedRows[0].Index;
                this.principal.AbrirJanelaCadastroMetotoRotaRepository(this.apiRepository.DAO.Codigo, this.listaMetodos[index].DAO.Codigo, Util.Enumerator.Tarefa.EDITAR, this);
            }
        }

        /// <summary>
        /// Evento lançado ao clicar em remover o método
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerMetodo_Click(object sender, EventArgs e)
        {
            if (this.dgv_metodos.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Nenhum método selecionado!");
            }
            else
            {
                int index = this.dgv_metodos.SelectedRows[0].Index;
                if (Message.MensagemConfirmaçãoYesNo("Deseja excluir o método " + this.listaMetodos[index].DAO.NomeMetodo + "?") == DialogResult.Yes)
                {
                    if (this.listaMetodos[index].DAO.Delete())
                    {
                        Message.MensagemSucesso("Método apagado com sucesso!");
                        this.listaMetodos.RemoveAt(index);
                        this.dgv_metodos.Rows.RemoveAt(index);
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir");
                    }
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de visualizar o método
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_visualizarMetodo_Click(object sender, EventArgs e)
        {
            if (this.dgv_metodos.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Nenhum método selecionado!");
            }
            else
            {
                int index = this.dgv_metodos.SelectedRows[0].Index;
                this.principal.AbrirJanelaCadastroMetotoRotaRepository(this.apiRepository.DAO.Codigo, this.listaMetodos[index].DAO.Codigo, Util.Enumerator.Tarefa.VISUALIZAR, this);
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de reload da tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reload_tabela_Click(object sender, EventArgs e)
        {
            this.CarregaListagemMetodos();
        }

        /// <summary>
        /// Evento lançado no clique do botão gerar relatório
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_gerarRelatorio_Click(object sender, EventArgs e)
        {
            this.GerarRelatorio();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="projeto"></param>
        /// <param name="tarefa"></param>
        /// <param name="principal"></param>
        /// <param name="apiRepository"></param>
        public UC_CadastroRotaRepository(Model.MD_Projeto projeto, Util.Enumerator.Tarefa tarefa, FO_Principal principal, Model.MD_ApiRepository apiRepository = null)
        {
            InitializeComponent();
            this.projeto = projeto;
            this.tarefa = tarefa;
            this.principal = principal;
            this.apiRepository = apiRepository;

            if(this.apiRepository == null)
            {
                this.apiRepository = new Model.MD_ApiRepository(DataBase.Connection.GetIncrement("APIREPOSITORY"));
            }

            this.IniciaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a tela
        /// </summary>
        public void IniciaUserControl()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroRotaRepositoryGet().IniciaUserControl()", Util.Global.TipoLog.DETALHADO);
            this.Dock = DockStyle.Fill;
            this.ControlaTarefa();
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.CarregaListagemMetodos();
            }
        }

        /// <summary>
        /// Método que controla a apresentação dos campos da tela
        /// </summary>
        public void ControlaTarefa()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroRotaRepositoryGet().ControlaTarefa()", Util.Global.TipoLog.DETALHADO);
            if(this.tarefa == Util.Enumerator.Tarefa.INCLUIR || this.tarefa == Util.Enumerator.Tarefa.EDITAR)
            {
                grb_metodos.Visible = false;
                this.tbx_descricao.Enabled = this.tbx_nomeRota.Enabled = this.tbx_rota.Enabled = true;
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }
            else
            {
                grb_metodos.Visible = true;
                this.tbx_descricao.Enabled = this.tbx_nomeRota.Enabled = this.tbx_rota.Enabled = false;
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }

            if (this.tarefa != Util.Enumerator.Tarefa.INCLUIR)
            {
                this.tbx_descricao.Text = this.apiRepository.DAO.Descricao;
                this.tbx_nomeRota.Text = this.apiRepository.DAO.NomeRota;
                this.tbx_rota.Text = this.apiRepository.DAO.Rota;
            }
        }

        /// <summary>
        /// Método que carrega no grid os métodos da rota
        /// </summary>
        private void CarregaListagemMetodos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroRotaRepositoryGet().CarregaListagemMetodos()", Util.Global.TipoLog.DETALHADO);

            this.dgv_metodos.Columns.Clear();
            this.dgv_metodos.Rows.Clear();

            this.dgv_metodos.Columns.Add("Nome", "Nome");
            this.dgv_metodos.Columns.Add("Rota", "Rota");
            this.dgv_metodos.Columns.Add("Tipo Método", "Tipo Método");
            this.dgv_metodos.Columns.Add("Consulta", "Consulta");

            this.listaMetodos = Model.MD_RotasRepository.RetornaMetodosApi(this.apiRepository.DAO.Codigo);

            this.listaMetodos.ForEach(m => CarregaListagemMetodos(m));

            this.lbl_quantidadeMetodos.Visible = this.listaMetodos.Count > 0;
            this.lbl_quantidadeMetodos.Text = this.listaMetodos.Count.ToString("000") + " métodos";
        }

        /// <summary>
        /// Método que preenche a tabela com os métodos
        /// </summary>
        /// <param name="metodo"></param>
        private void CarregaListagemMetodos(Model.MD_RotasRepository metodo)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroRotaRepositoryGet().CarregaListagemMetodos()", Util.Global.TipoLog.DETALHADO);
            List<string> list = new List<string>();
            list.Add(metodo.DAO.NomeMetodo);
            list.Add(metodo.DAO.Rota);
            list.Add(metodo.DAO.TipoMetodo);
            list.Add(metodo.DAO.Consulta);

            this.dgv_metodos.Rows.Add(list.ToArray());
        }

        /// <summary>
        /// Método que adiciona o método ao cadastro da rota
        /// </summary>
        /// <param name="metodo"></param>
        public void AdicionaMetodo(Model.MD_RotasRepository metodo)
        {
            this.listaMetodos.Add(metodo);
            this.CarregaListagemMetodos(metodo);
        }

        /// <summary>
        /// Método que gera o relatório
        /// </summary>
        private void GerarRelatorio()
        {
            string mensagemErro = string.Empty;
            if(Regras.RelatorioApi.Criar(this.apiRepository, out mensagemErro))
            {
                Visao.Message.MensagemSucesso("Criado com sucesso!");
                if(Visao.Message.MensagemConfirmaçãoYesNo("Deseja abrir o aruqivo?") == DialogResult.Yes){
                    System.Diagnostics.Process.Start(Util.Global.app_temp_html_file);
                }
            }
            else
            {
                Visao.Message.MensagemErro("Erro ao gerar o relatório." + Environment.NewLine + mensagemErro);
            }
        }

        #endregion Métodos

    }
}
