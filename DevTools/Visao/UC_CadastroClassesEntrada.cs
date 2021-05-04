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
    public partial class UC_CadastroClassesEntrada : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Classe de entrada
        /// </summary>
        Model.MD_ClasseEntrada classeEntrada;

        /// <summary>
        /// Classe de entrada
        /// </summary>
        Model.MD_ClasseEntrada classeMae;

        /// <summary>
        /// Classe de controle da rota
        /// </summary>
        Model.MD_RotasRepository metodoRota;

        /// <summary>
        /// Lista dos campos da classe de entrada
        /// </summary>
        List<Model.MD_CamposClasseEntrada> listaCampos;

        /// <summary>
        /// Lista dos campos da classe de entrada
        /// </summary>
        List<Model.MD_ClasseEntrada> listaClasses;

        /// <summary>
        /// Controle da classe principal
        /// </summary>
        FO_Principal principal;

        /// <summary>
        /// Controle da tela que cadastra as classes
        /// </summary>
        UC_ControleMetodoRotaRepository controleRotaRepository;

        /// <summary>
        /// Controle da tela de cadastro da classe mae
        /// </summary>
        UC_CadastroClassesEntrada cadastroClasseMae;

        /// <summary>
        /// Controle da tarefa sendo executada na tela
        /// </summary>
        Util.Enumerator.Tarefa tarefa;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento capturado no clique do botão fechar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(this.classeMae != null ? Util.Enumerator.Telas.CADASTRO_CLASSE_CLASSE_FILHA : Util.Enumerator.Telas.CADASTRO_CLASSE_ENTRADA);
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação do nome da variável
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_campo_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome que a variável vai ter no método");
        }

        /// <summary>
        /// Evento lançado no clique da informação do tipo de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tipoEntrada_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Tipo de entrada da classe. Caso não for uma classe de entrada, colocar não aplica");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação para o nome da classe de retorno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tipoCampo_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome da classe de entrada");
        }

        /// <summary>
        /// Evento lançado no clique do botão de adicionar campo da classe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionarCampoEntrada_Click(object sender, EventArgs e)
        {
            if(Message.MensagemConfirmaçãoYesNo("Deseja cadastrar uma classe?") == DialogResult.Yes)
            {
                this.principal.AbrirCadastroClasseEntradaFilha(new Model.MD_ClasseEntrada(DataBase.Connection.GetIncrement("CLASSEENTRADA")), this.classeEntrada, this.metodoRota, Util.Enumerator.Tarefa.INCLUIR, this);
            }
            else
            {
                this.principal.AbrirCadastroCampoClasse(new Model.MD_CamposClasseEntrada(DataBase.Connection.GetIncrement("CAMPOSCLASSEENTRADA")), this.classeEntrada, Util.Enumerator.Tarefa.INCLUIR, this);
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão para edicar o campo da classe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarCampoEntrada_Click(object sender, EventArgs e)
        {
            if(this.dgv_camposClasse.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um campo ou classe da listagem");
            }
            else
            {
                int codigo = int.Parse(this.dgv_camposClasse.SelectedRows[0].Cells[0].FormattedValue.ToString());
                string tipo = this.dgv_camposClasse.SelectedRows[0].Cells[1].FormattedValue.ToString();
                if (tipo.Equals("Campo"))
                {
                    this.principal.AbrirCadastroCampoClasse(new Model.MD_CamposClasseEntrada(codigo), this.classeEntrada, Util.Enumerator.Tarefa.EDITAR, this);
                }
                else{
                    this.principal.AbrirCadastroClasseEntradaFilha(new Model.MD_ClasseEntrada(codigo), this.classeEntrada, this.metodoRota, Util.Enumerator.Tarefa.EDITAR, this);
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de remover o campo da classe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerCampoEntrada_Click(object sender, EventArgs e)
        {
            if (this.dgv_camposClasse.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um campo ou classe da listagem");
            }
            else
            {
                int codigo = int.Parse(this.dgv_camposClasse.SelectedRows[0].Cells[0].FormattedValue.ToString());
                string tipo = this.dgv_camposClasse.SelectedRows[0].Cells[1].FormattedValue.ToString();
                if (tipo.Equals("Campo"))
                {
                    Model.MD_CamposClasseEntrada campo = new Model.MD_CamposClasseEntrada(codigo);
                    if(Message.MensagemConfirmaçãoYesNo("Deseja excluir o campo " + campo.DAO.NomeCampo + "?") == DialogResult.Yes)
                    {
                        if (campo.DAO.Delete())
                        {
                            Message.MensagemSucesso("Excluídos com sucesso");
                            this.IniciaUserControl();
                        }
                        else
                        {
                            Message.MensagemErro("Erro ao exluir");
                        }
                    }
                }
                else
                {
                    Model.MD_ClasseEntrada classe = new Model.MD_ClasseEntrada(codigo);
                    if (Message.MensagemConfirmaçãoYesNo("Deseja excluir o campo " + classe.DAO.NomeClasse + "?") == DialogResult.Yes)
                    {
                        if (classe.DAO.Delete())
                        {
                            Message.MensagemSucesso("Excluídos com sucesso");
                            this.IniciaUserControl();
                        }
                        else
                        {
                            Message.MensagemErro("Erro ao exluir");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de visualizar o campo da classe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_visualizarVariavelEntrada_Click(object sender, EventArgs e)
        {
            if (this.dgv_camposClasse.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um campo ou classe da listagem");
            }
            else
            {
                int codigo = int.Parse(this.dgv_camposClasse.SelectedRows[0].Cells[0].FormattedValue.ToString());
                string tipo = this.dgv_camposClasse.SelectedRows[0].Cells[1].FormattedValue.ToString();
                if (tipo.Equals("Campo"))
                {
                    this.principal.AbrirCadastroCampoClasse(new Model.MD_CamposClasseEntrada(codigo), this.classeEntrada, Util.Enumerator.Tarefa.VISUALIZAR, this);
                }
                else
                {
                    this.principal.AbrirCadastroClasseEntradaFilha(new Model.MD_ClasseEntrada(codigo), this.classeEntrada, this.metodoRota, Util.Enumerator.Tarefa.VISUALIZAR, this);
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
                this.IniciaUserControl();
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
            if(tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                if(Message.MensagemConfirmaçãoYesNo("Deseja excluir a classe " + this.classeEntrada.DAO.NomeClasse) == DialogResult.Yes)
                {
                    if (classeEntrada.DAO.Delete())
                    {
                        Message.MensagemSucesso("Classe excluída!");
                        if(this.controleRotaRepository != null)
                        {
                            this.controleRotaRepository.ExcluiClasseEntrada(this.classeEntrada);
                        }
                        this.btn_fechar_Click(null, null);
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir a classe");
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
                this.IniciaUserControl();
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de reload da tabela
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
        /// <param name="classeEntrada"></param>
        /// <param name="metodoRota"></param>
        /// <param name="tarefa"></param>
        /// <param name="controleRotaRepository"></param>
        /// <param name="principal"></param>
        public UC_CadastroClassesEntrada(Model.MD_ClasseEntrada classeEntrada, Model.MD_RotasRepository metodoRota, Util.Enumerator.Tarefa tarefa, UC_ControleMetodoRotaRepository controleRotaRepository, FO_Principal principal)
        {
            InitializeComponent();
            if(classeEntrada == null)
            {
                classeEntrada = new Model.MD_ClasseEntrada(DataBase.Connection.GetIncrement("CLASSEENTRADA"));
            }

            this.classeEntrada = classeEntrada;
            this.classeMae = null;
            this.metodoRota = metodoRota;
            this.tarefa = tarefa;
            this.controleRotaRepository = controleRotaRepository;
            this.principal = principal;
            this.cadastroClasseMae = null;
            this.IniciaUserControl();
        }

        /// <summary>
        /// Construtor secundario da classe
        /// </summary>
        /// <param name="classeEntrada"></param>
        /// <param name="metodoRota"></param>
        /// <param name="tarefa"></param>
        /// <param name="controleRotaRepository"></param>
        /// <param name="principal"></param>
        public UC_CadastroClassesEntrada(Model.MD_ClasseEntrada classeEntrada, Model.MD_ClasseEntrada classeMae, Model.MD_RotasRepository metodoRota, Util.Enumerator.Tarefa tarefa, UC_CadastroClassesEntrada cadastroClasseMae, FO_Principal principal)
        {
            InitializeComponent();
            if (classeEntrada == null)
            {
                classeEntrada = new Model.MD_ClasseEntrada(DataBase.Connection.GetIncrement("CLASSEENTRADA"));
            }

            this.classeEntrada = classeEntrada;
            this.classeMae = classeMae;
            this.metodoRota = metodoRota;
            this.tarefa = tarefa;
            this.controleRotaRepository = null;
            this.principal = principal;
            this.cadastroClasseMae = cadastroClasseMae;
            this.IniciaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a tela
        /// </summary>
        public void IniciaUserControl()
        {
            this.Dock = DockStyle.Fill;
            this.ControlaTarefa();
            this.CarregaTabelaCamposClasse();
        }

        /// <summary>
        /// Método que controla a tarefa a ser executado 
        /// </summary>
        private void ControlaTarefa()
        {
            if (tarefa == Util.Enumerator.Tarefa.VISUALIZAR)
            {
                this.tbx_nomeClasse.Enabled = this.tbx_classe.Enabled = this.cmb_tipoEntrada.Enabled = false;
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.tbx_nomeClasse.Enabled = this.tbx_classe.Enabled = this.cmb_tipoEntrada.Enabled = true;
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }

            if (tarefa != Util.Enumerator.Tarefa.INCLUIR)
            {
                this.tbx_nomeClasse.Text = this.classeEntrada.DAO.NomeClasse;
                this.tbx_classe.Text = this.classeEntrada.DAO.TipoClasse;
                this.cmb_tipoEntrada.SelectedItem = this.classeEntrada.DAO.TipoEntrada;
            }
            else
            {
                this.tbx_nomeClasse.Text = string.Empty;
                this.tbx_classe.Text = string.Empty;
                this.cmb_tipoEntrada.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Método que carrega a tabela com os campos da classe
        /// </summary>
        public void CarregaTabelaCamposClasse()
        {
            this.listaCampos = Model.MD_CamposClasseEntrada.RetornaCamposClasseEntrada(this.classeEntrada.DAO.Codigo);
            this.listaClasses = Model.MD_ClasseEntrada.RetornaClassesFilhas(this.classeEntrada.DAO.Codigo);

            this.dgv_camposClasse.Rows.Clear();
            this.dgv_camposClasse.Columns.Clear();

            this.dgv_camposClasse.Columns.Add("Código", "Código");
            this.dgv_camposClasse.Columns.Add("Tipo", "Tipo");
            this.dgv_camposClasse.Columns.Add("Nome", "Nome");
            this.dgv_camposClasse.Columns.Add("Tipo campo", "Tipo campo");

            this.listaCampos.ForEach(c => CarregaTabelaCamposClasse(c));
            this.listaClasses.ForEach(c => CarregaTabelaCamposClasse(c));
        }

        /// <summary>
        /// Método que carrega tabela de entrada
        /// </summary>
        /// <param name="campo"></param>
        public void CarregaTabelaCamposClasse(Model.MD_CamposClasseEntrada campo)
        {
            List<string> list = new List<string>();
            list.Add(campo.DAO.Codigo.ToString());
            list.Add("Campo");
            list.Add(campo.DAO.NomeCampo);
            list.Add(campo.DAO.TipoCampo);

            this.dgv_camposClasse.Rows.Add(list.ToArray());
        }

        /// <summary>
        /// Método que carrega tabela de entrada
        /// </summary>
        /// <param name="campo"></param>
        public void CarregaTabelaCamposClasse(Model.MD_ClasseEntrada classe)
        {
            List<string> list = new List<string>();
            list.Add(classe.DAO.Codigo.ToString());
            list.Add("Classe");
            list.Add(classe.DAO.NomeClasse);
            list.Add(classe.DAO.TipoClasse);

            this.dgv_camposClasse.Rows.Add(list.ToArray());
        }

        /// <summary>
        /// Método que adiciona na lista e no grid o novo campo
        /// </summary>
        /// <param name="campo"></param>
        public void AdicionaCampoEntrada(Model.MD_CamposClasseEntrada campo)
        {
            this.CarregaTabelaCamposClasse(campo);
            this.listaCampos.Add(campo);
        }

        /// <summary>
        /// Método que adiciona na lista e no grid a nova classe
        /// </summary>
        /// <param name="campo"></param>
        public void AdicionaClasseEntrada(Model.MD_ClasseEntrada classe)
        {
            this.CarregaTabelaCamposClasse(classe);
            this.listaClasses.Add(classe);
        }

        /// <summary>
        /// Método que exlui na lista e no grid o campo
        /// </summary>
        /// <param name="campo"></param>
        public void ExcluiCampo(Model.MD_CamposClasseEntrada campo)
        {
            this.listaCampos.Remove(campo);
            this.CarregaTabelaCamposClasse();
        }

        /// <summary>
        /// Método que exclui na lista e no grid a classe
        /// </summary>
        /// <param name="campo"></param>
        public void ExcluiClasseEntrada(Model.MD_ClasseEntrada classe)
        {
            this.listaClasses.Remove(classe);
            this.CarregaTabelaCamposClasse();
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        public void Confirmar()
        {
            if (string.IsNullOrEmpty(this.tbx_classe.Text))
            {
                Message.MensagemAlerta("Preencha a classe");
            }
            else if (string.IsNullOrEmpty(this.tbx_nomeClasse.Text))
            {
                Message.MensagemAlerta("Preencha o nome da classe");
            }
            else
            {
                this.classeEntrada.DAO.ClasseMae = classeMae == null ? -1 : this.classeMae.DAO.Codigo;
                this.classeEntrada.DAO.Codigorotarepository = classeMae == null ? this.metodoRota.DAO.Codigo  : -1;
                this.classeEntrada.DAO.NomeClasse = this.tbx_nomeClasse.Text;
                this.classeEntrada.DAO.TipoClasse = this.tbx_classe.Text;
                this.classeEntrada.DAO.TipoEntrada = this.cmb_tipoEntrada.SelectedItem.ToString();

                bool retorno = this.tarefa == Util.Enumerator.Tarefa.INCLUIR ? this.classeEntrada.DAO.Insert() : this.classeEntrada.DAO.Update();
                if (retorno)
                {
                    Message.MensagemSucesso((this.tarefa == Util.Enumerator.Tarefa.INCLUIR ? "Incluído" : "Alterado") + " com sucesso");

                    if(this.tarefa == Util.Enumerator.Tarefa.INCLUIR)
                    {
                        if (classeMae != null)
                        {
                            this.cadastroClasseMae.AdicionaClasseEntrada(this.classeEntrada);
                        }
                        else
                        {
                            if (this.controleRotaRepository != null)
                                this.controleRotaRepository.AdicionaClasseEntrada(this.classeEntrada);
                        }
                    }
                    else
                    {
                        if (classeMae != null)
                        {
                            this.cadastroClasseMae.IniciaUserControl();
                        }
                        else
                        {
                            if (this.controleRotaRepository != null)
                                this.controleRotaRepository.IniciaUserControl();
                        }
                    }

                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZAR;
                    this.IniciaUserControl();
                }
                else
                {
                    Message.MensagemErro("Erro ao cadastrar classe");
                }
            }
        }

        #endregion Métodos
        
    }
}
