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
    public partial class UC_CadastroTipoRetorno : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Controle do retorno da rota API
        /// </summary>
        Model.MD_RetornoRotaRepository retornoRotaApi;

        /// <summary>
        /// Controle da rota para cadastro
        /// </summary>
        Model.MD_RotasRepository rota;

        /// <summary>
        /// Lista das classes do retorno
        /// </summary>
        List<Model.MD_ClasseRetornoRepository> listaClasses = new List<Model.MD_ClasseRetornoRepository>();

        /// <summary>
        /// Lista dos campos do retorno
        /// </summary>
        List<Model.MD_CamposClasseRetorno> listaCampos = new List<Model.MD_CamposClasseRetorno>();

        /// <summary>
        /// Controle do cadastro da rota
        /// </summary>
        UC_ControleMetodoRotaRepository controleMetodoRotaRepository;

        /// <summary>
        /// Controle da tela principal
        /// </summary>
        FO_Principal principal;

        /// <summary>
        /// Controle da tarefa da classe
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
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_TIPO_SAIDA);
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação do tipo de saída
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tipoCampo_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Tipo do campo de retorno");
        }

        /// <summary>
        /// Evento disparado no clique do botão para incluir campo de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionarCampoEntrada_Click(object sender, EventArgs e)
        {
            if(this.tarefa == Util.Enumerator.Tarefa.INCLUIR)
            {
                Message.MensagemAlerta("Termine o cadastro para depois inserir um retorno");
                return;
            }

            if (Message.MensagemConfirmaçãoYesNo("O campo é uma classe?") == DialogResult.Yes)
            {
                this.principal.AbrirCadastroClasseSaida(new Model.MD_ClasseRetornoRepository(DataBase.Connection.GetIncrement("CLASSERETORNOREPOSITORY")), this.retornoRotaApi, Util.Enumerator.Tarefa.INCLUIR, this);
            }
            else
            {
                this.principal.AbrirCadastroCampoSaida(new Model.MD_CamposClasseRetorno(DataBase.Connection.GetIncrement("CAMPOSCLASSERETORNO")), this.retornoRotaApi, Util.Enumerator.Tarefa.INCLUIR, this);
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de editar o campo de saída
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarCampoEntrada_Click(object sender, EventArgs e)
        {
            if(this.dgv_camposClasse.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Seelcione um item na lista");
            }
            else
            {
                int codigo = int.Parse(dgv_camposClasse.SelectedRows[0].Cells[0].FormattedValue.ToString());
                if (this.dgv_camposClasse.SelectedRows[0].Cells[3].FormattedValue.ToString().Equals("Classe"))
                {
                    this.principal.AbrirCadastroClasseSaida(this.listaClasses.Where(c => c.DAO.Codigo.Equals(codigo)).FirstOrDefault(), this.retornoRotaApi, Util.Enumerator.Tarefa.EDITAR, this);
                }
                else
                {
                    this.principal.AbrirCadastroCampoSaida(this.listaCampos.Where(c => c.DAO.Codigo.Equals(codigo)).FirstOrDefault(), retornoRotaApi, Util.Enumerator.Tarefa.EDITAR, this);
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de remover o campo de saída
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerCampoEntrada_Click(object sender, EventArgs e)
        {
            if (this.dgv_camposClasse.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Seelcione um item na lista");
            }
            else
            {
                int codigo = int.Parse(dgv_camposClasse.SelectedRows[0].Cells[0].FormattedValue.ToString());
                if (this.dgv_camposClasse.SelectedRows[0].Cells[3].FormattedValue.ToString().Equals("Classe"))
                {
                    Model.MD_ClasseRetornoRepository campo = this.listaClasses.Where(c => c.DAO.Codigo.Equals(codigo)).FirstOrDefault();
                    if(Message.MensagemConfirmaçãoYesNo("Deseja excluir a classe " + campo.DAO.Nome + "?") == DialogResult.Yes)
                    {
                        if (campo.DAO.Delete())
                        {
                            Message.MensagemSucesso("Excluído com sucesso");
                        }
                        else
                        {
                            Message.MensagemErro("Erro ao excluir!");
                        }
                    }
                }
                else
                {
                    Model.MD_CamposClasseRetorno campo = this.listaCampos.Where(c => c.DAO.Codigo.Equals(codigo)).FirstOrDefault();
                    if (Message.MensagemConfirmaçãoYesNo("Deseja excluir o campo " + campo.DAO.NomeCampo + "?") == DialogResult.Yes)
                    {
                        if (campo.DAO.Delete())
                        {
                            Message.MensagemSucesso("Excluído com sucesso");
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
        /// Evento lanãdo no clique do botão de visualizar o campo de saída
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_visualizarVariavelEntrada_Click(object sender, EventArgs e)
        {
            if (this.dgv_camposClasse.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Seelcione um item na lista");
            }
            else
            {
                int codigo = int.Parse(dgv_camposClasse.SelectedRows[0].Cells[0].FormattedValue.ToString());
                if (this.dgv_camposClasse.SelectedRows[0].Cells[3].FormattedValue.ToString().Equals("Classe"))
                {
                    this.principal.AbrirCadastroClasseSaida(this.listaClasses.Where(c => c.DAO.Codigo.Equals(codigo)).FirstOrDefault(), this.retornoRotaApi, Util.Enumerator.Tarefa.VISUALIZAR, this);
                }
                else
                {
                    this.principal.AbrirCadastroCampoSaida(this.listaCampos.Where(c => c.DAO.Codigo.Equals(codigo)).FirstOrDefault(), retornoRotaApi, Util.Enumerator.Tarefa.VISUALIZAR, this);
                }
            }
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
            if(this.tarefa != Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                this.InicializaUserControl();
            }
            else
            {
                if(Message.MensagemConfirmaçãoYesNo("Deseja excluir o tipo de retorno " + this.retornoRotaApi.DAO.Tiporetorno) == DialogResult.Yes)
                {
                    if (this.retornoRotaApi.DAO.Delete())
                    {
                        Message.MensagemSucesso("Excluído com sucesso!");
                        this.controleMetodoRotaRepository.ExcluiSaida(this.retornoRotaApi);
                        this.btn_fechar_Click(null, null);
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir");
                    }
                }
            }
        }

        #endregion Eventos

        #region Consturores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="retornoRotaApi"></param>
        /// <param name="rota"></param>
        /// <param name="tarefa"></param>
        /// <param name="controleMetodoRotaRepository"></param>
        /// <param name="principal"></param>
        public UC_CadastroTipoRetorno(Model.MD_RetornoRotaRepository retornoRotaApi, Model.MD_RotasRepository rota, Util.Enumerator.Tarefa tarefa, UC_ControleMetodoRotaRepository controleMetodoRotaRepository, FO_Principal principal)
        {
            this.InitializeComponent();
            this.retornoRotaApi = retornoRotaApi;
            this.rota = rota;
            this.tarefa = tarefa;
            this.controleMetodoRotaRepository = controleMetodoRotaRepository;
            this.principal = principal;

            this.InicializaUserControl();
            this.ckb_classe.CheckedChanged += delegate { this.grb_camposClasse.Visible = this.ckb_classe.Checked; };
        }

        #endregion Consturores

        #region Métodos

        /// <summary>
        /// Método que incializa o formulário
        /// </summary>
        public void InicializaUserControl()
        {
            this.Dock = DockStyle.Fill;
            this.ControlaTarefa();
            this.CarregaTabelaCamposClasse();

            this.grb_camposClasse.Visible = this.ckb_classe.Checked;
        }

        /// <summary>
        /// Método que controla a tarefa
        /// </summary>
        private void ControlaTarefa()
        {
            if(tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tbx_tipoCampo.Enabled = this.ckb_classe.Enabled = false;
                this.btn_adicionarCampoEntrada.Enabled = this.btn_editarCampoEntrada.Enabled = this.btn_removerCampoEntrada.Enabled = this.btn_visualizarVariavelEntrada.Enabled = true;
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.btn_adicionarCampoEntrada.Enabled = this.btn_editarCampoEntrada.Enabled = this.btn_removerCampoEntrada.Enabled = this.btn_visualizarVariavelEntrada.Enabled = false;
                this.tbx_tipoCampo.Enabled = this.ckb_classe.Enabled = true;
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }

            if(tarefa != Util.Enumerator.Tarefa.INCLUIR)
            {
                this.tbx_tipoCampo.Text = retornoRotaApi.DAO.Tiporetorno;
                this.ckb_classe.Checked = retornoRotaApi.DAO.EhClasse != "0";
            }
            else
            {
                this.tbx_tipoCampo.Text = string.Empty;
                this.ckb_classe.Checked = false;
            }
        }

        /// <summary>
        /// Método que carrega a tabela com os campos da classe
        /// </summary>
        public void CarregaTabelaCamposClasse()
        {
            this.listaClasses = Model.MD_ClasseRetornoRepository.RetornaRetornosClasses(this.retornoRotaApi.DAO.Codigo);
            this.listaCampos = Model.MD_CamposClasseRetorno.RetornaRetornosCampoRota(this.retornoRotaApi.DAO.Codigo);

            this.dgv_camposClasse.Rows.Clear();
            this.dgv_camposClasse.Columns.Clear();

            this.dgv_camposClasse.Columns.Add("Código", "Código");
            this.dgv_camposClasse.Columns.Add("Nome", "Nome");
            this.dgv_camposClasse.Columns.Add("Tipo Campo", "Tipo Campo");
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
            if (string.IsNullOrEmpty(this.tbx_tipoCampo.Text))
            {
                Message.MensagemAlerta("O tipo de campo não foi preenchido");
            }
            else
            {
                if (this.ckb_classe.Checked)
                {
                    Model.MD_ClasseRetornoRepository classeRetorno = new Model.MD_ClasseRetornoRepository(DataBase.Connection.GetIncrement("CLASSERETORNOREPOSITORY"));
                    classeRetorno.DAO.Classemae = -1;
                    classeRetorno.DAO.Comentario = string.Empty;
                    classeRetorno.DAO.Nome = this.tbx_tipoCampo.Text;
                    classeRetorno.DAO.Insert();
                    this.retornoRotaApi.DAO.CodigoClasseRetorno = classeRetorno.DAO.Codigo;
                    this.retornoRotaApi.DAO.EhClasse = "1";
                }
                else
                {
                    this.retornoRotaApi.DAO.EhClasse = "0";
                    this.retornoRotaApi.DAO.CodigoClasseRetorno = -1;
                }
                this.retornoRotaApi.DAO.Codigorotarepository = this.rota.DAO.Codigo;
                this.retornoRotaApi.DAO.Tiporetorno = this.tbx_tipoCampo.Text;

                bool retorno = this.tarefa == Util.Enumerator.Tarefa.INCLUIR ? this.retornoRotaApi.DAO.Insert() : this.retornoRotaApi.DAO.Update();
                if (retorno)
                {
                    Message.MensagemSucesso("Cadastrado com sucesso!");
                    if(this.controleMetodoRotaRepository != null)
                        this.controleMetodoRotaRepository.AdicionaSaida(this.retornoRotaApi);

                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                    this.InicializaUserControl();
                }
                else
                {
                    Message.MensagemErro("Erro ao cadastrar!");
                }
            }
        }

        #endregion Métodos
        
    }
}
