namespace Visao
{
    partial class UC_ControleMetodoRotaRepository
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.pan_completo = new System.Windows.Forms.Panel();
            this.grb_metodo = new System.Windows.Forms.GroupBox();
            this.pan_tot = new System.Windows.Forms.Panel();
            this.grb_variaveisEntrada = new System.Windows.Forms.GroupBox();
            this.dgv_camposSaida = new System.Windows.Forms.DataGridView();
            this.btn_visualizarCampoSaida = new System.Windows.Forms.Button();
            this.btn_removerCampoSaida = new System.Windows.Forms.Button();
            this.btn_editarCampoSaida = new System.Windows.Forms.Button();
            this.btn_cadastrarCampoSaida = new System.Windows.Forms.Button();
            this.grb_dadosEntrada = new System.Windows.Forms.GroupBox();
            this.dgv_camposEntrada = new System.Windows.Forms.DataGridView();
            this.btn_visualizarVariavelEntrada = new System.Windows.Forms.Button();
            this.btn_removerCampoEntrada = new System.Windows.Forms.Button();
            this.btn_editarCampoEntrada = new System.Windows.Forms.Button();
            this.btn_adicionarCampoEntrada = new System.Windows.Forms.Button();
            this.grb_cadastro = new System.Windows.Forms.GroupBox();
            this.btn_visualizarConsulta = new System.Windows.Forms.Button();
            this.lbl_consultaProcedure = new System.Windows.Forms.Label();
            this.btn_info_consultaProcedure = new System.Windows.Forms.Button();
            this.tbx_ConsultaProcedure = new System.Windows.Forms.TextBox();
            this.cmb_tipoMetodo = new System.Windows.Forms.ComboBox();
            this.lbl_tipoMetodo = new System.Windows.Forms.Label();
            this.btn_info_TipoMetodo = new System.Windows.Forms.Button();
            this.lbl_rota = new System.Windows.Forms.Label();
            this.btn_infoRotaMetodo = new System.Windows.Forms.Button();
            this.tbx_rota = new System.Windows.Forms.TextBox();
            this.lbl_nomeMetodo = new System.Windows.Forms.Label();
            this.btn_info_metodo = new System.Windows.Forms.Button();
            this.tbx_nomeMetodo = new System.Windows.Forms.TextBox();
            this.pan_botton.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.pan_completo.SuspendLayout();
            this.grb_metodo.SuspendLayout();
            this.pan_tot.SuspendLayout();
            this.grb_variaveisEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_camposSaida)).BeginInit();
            this.grb_dadosEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_camposEntrada)).BeginInit();
            this.grb_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_excluir);
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 527);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(740, 35);
            this.pan_botton.TabIndex = 22;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Location = new System.Drawing.Point(581, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 29);
            this.btn_excluir.TabIndex = 21;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(662, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 20;
            this.btn_confirmar.Text = "Cadastrar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 23;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.BackColor = System.Drawing.Color.Red;
            this.btn_fechar.BackgroundImage = global::DevTools.Properties.Resources.window_close_100px20x20;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fechar.Location = new System.Drawing.Point(720, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(20, 20);
            this.btn_fechar.TabIndex = 22;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.grb_metodo);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 20);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(740, 507);
            this.pan_completo.TabIndex = 24;
            // 
            // grb_metodo
            // 
            this.grb_metodo.Controls.Add(this.pan_tot);
            this.grb_metodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_metodo.Location = new System.Drawing.Point(0, 0);
            this.grb_metodo.Name = "grb_metodo";
            this.grb_metodo.Size = new System.Drawing.Size(740, 507);
            this.grb_metodo.TabIndex = 0;
            this.grb_metodo.TabStop = false;
            this.grb_metodo.Text = "Método - <rota>";
            // 
            // pan_tot
            // 
            this.pan_tot.AllowDrop = true;
            this.pan_tot.Controls.Add(this.grb_variaveisEntrada);
            this.pan_tot.Controls.Add(this.grb_dadosEntrada);
            this.pan_tot.Controls.Add(this.grb_cadastro);
            this.pan_tot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_tot.Location = new System.Drawing.Point(3, 19);
            this.pan_tot.Name = "pan_tot";
            this.pan_tot.Size = new System.Drawing.Size(734, 485);
            this.pan_tot.TabIndex = 0;
            // 
            // grb_variaveisEntrada
            // 
            this.grb_variaveisEntrada.Controls.Add(this.dgv_camposSaida);
            this.grb_variaveisEntrada.Controls.Add(this.btn_visualizarCampoSaida);
            this.grb_variaveisEntrada.Controls.Add(this.btn_removerCampoSaida);
            this.grb_variaveisEntrada.Controls.Add(this.btn_editarCampoSaida);
            this.grb_variaveisEntrada.Controls.Add(this.btn_cadastrarCampoSaida);
            this.grb_variaveisEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_variaveisEntrada.Location = new System.Drawing.Point(0, 299);
            this.grb_variaveisEntrada.Name = "grb_variaveisEntrada";
            this.grb_variaveisEntrada.Size = new System.Drawing.Size(734, 156);
            this.grb_variaveisEntrada.TabIndex = 2;
            this.grb_variaveisEntrada.TabStop = false;
            this.grb_variaveisEntrada.Text = "Variáveis de Saída";
            // 
            // dgv_camposSaida
            // 
            this.dgv_camposSaida.AllowUserToAddRows = false;
            this.dgv_camposSaida.AllowUserToDeleteRows = false;
            this.dgv_camposSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_camposSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_camposSaida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_camposSaida.BackgroundColor = System.Drawing.Color.White;
            this.dgv_camposSaida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_camposSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_camposSaida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_camposSaida.EnableHeadersVisualStyles = false;
            this.dgv_camposSaida.Location = new System.Drawing.Point(19, 22);
            this.dgv_camposSaida.MultiSelect = false;
            this.dgv_camposSaida.Name = "dgv_camposSaida";
            this.dgv_camposSaida.RowHeadersVisible = false;
            this.dgv_camposSaida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_camposSaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_camposSaida.ShowCellErrors = false;
            this.dgv_camposSaida.ShowCellToolTips = false;
            this.dgv_camposSaida.Size = new System.Drawing.Size(683, 128);
            this.dgv_camposSaida.StandardTab = true;
            this.dgv_camposSaida.TabIndex = 15;
            // 
            // btn_visualizarCampoSaida
            // 
            this.btn_visualizarCampoSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_visualizarCampoSaida.BackgroundImage = global::DevTools.Properties.Resources.eye_100px20x20;
            this.btn_visualizarCampoSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_visualizarCampoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_visualizarCampoSaida.Location = new System.Drawing.Point(708, 100);
            this.btn_visualizarCampoSaida.Name = "btn_visualizarCampoSaida";
            this.btn_visualizarCampoSaida.Size = new System.Drawing.Size(20, 20);
            this.btn_visualizarCampoSaida.TabIndex = 19;
            this.btn_visualizarCampoSaida.UseVisualStyleBackColor = true;
            this.btn_visualizarCampoSaida.Click += new System.EventHandler(this.btn_visualizarCampoSaida_Click);
            // 
            // btn_removerCampoSaida
            // 
            this.btn_removerCampoSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removerCampoSaida.BackgroundImage = global::DevTools.Properties.Resources.close_outline_100px20x20;
            this.btn_removerCampoSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_removerCampoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removerCampoSaida.Location = new System.Drawing.Point(708, 74);
            this.btn_removerCampoSaida.Name = "btn_removerCampoSaida";
            this.btn_removerCampoSaida.Size = new System.Drawing.Size(20, 20);
            this.btn_removerCampoSaida.TabIndex = 18;
            this.btn_removerCampoSaida.UseVisualStyleBackColor = true;
            this.btn_removerCampoSaida.Click += new System.EventHandler(this.btn_removerCampoSaida_Click);
            // 
            // btn_editarCampoSaida
            // 
            this.btn_editarCampoSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editarCampoSaida.BackgroundImage = global::DevTools.Properties.Resources.lead_pencil_100px20x20;
            this.btn_editarCampoSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_editarCampoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editarCampoSaida.Location = new System.Drawing.Point(708, 48);
            this.btn_editarCampoSaida.Name = "btn_editarCampoSaida";
            this.btn_editarCampoSaida.Size = new System.Drawing.Size(20, 20);
            this.btn_editarCampoSaida.TabIndex = 17;
            this.btn_editarCampoSaida.UseVisualStyleBackColor = true;
            this.btn_editarCampoSaida.Click += new System.EventHandler(this.btn_editarCampoSaida_Click);
            // 
            // btn_cadastrarCampoSaida
            // 
            this.btn_cadastrarCampoSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrarCampoSaida.BackgroundImage = global::DevTools.Properties.Resources.plus20x20;
            this.btn_cadastrarCampoSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrarCampoSaida.Location = new System.Drawing.Point(708, 22);
            this.btn_cadastrarCampoSaida.Name = "btn_cadastrarCampoSaida";
            this.btn_cadastrarCampoSaida.Size = new System.Drawing.Size(20, 20);
            this.btn_cadastrarCampoSaida.TabIndex = 16;
            this.btn_cadastrarCampoSaida.UseVisualStyleBackColor = true;
            this.btn_cadastrarCampoSaida.Click += new System.EventHandler(this.btn_cadastrarCampoSaida_Click);
            // 
            // grb_dadosEntrada
            // 
            this.grb_dadosEntrada.Controls.Add(this.dgv_camposEntrada);
            this.grb_dadosEntrada.Controls.Add(this.btn_visualizarVariavelEntrada);
            this.grb_dadosEntrada.Controls.Add(this.btn_removerCampoEntrada);
            this.grb_dadosEntrada.Controls.Add(this.btn_editarCampoEntrada);
            this.grb_dadosEntrada.Controls.Add(this.btn_adicionarCampoEntrada);
            this.grb_dadosEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_dadosEntrada.Location = new System.Drawing.Point(0, 143);
            this.grb_dadosEntrada.Name = "grb_dadosEntrada";
            this.grb_dadosEntrada.Size = new System.Drawing.Size(734, 156);
            this.grb_dadosEntrada.TabIndex = 1;
            this.grb_dadosEntrada.TabStop = false;
            this.grb_dadosEntrada.Text = "Variáveis de Entrada";
            // 
            // dgv_camposEntrada
            // 
            this.dgv_camposEntrada.AllowUserToAddRows = false;
            this.dgv_camposEntrada.AllowUserToDeleteRows = false;
            this.dgv_camposEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_camposEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_camposEntrada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_camposEntrada.BackgroundColor = System.Drawing.Color.White;
            this.dgv_camposEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_camposEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_camposEntrada.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_camposEntrada.EnableHeadersVisualStyles = false;
            this.dgv_camposEntrada.Location = new System.Drawing.Point(19, 22);
            this.dgv_camposEntrada.MultiSelect = false;
            this.dgv_camposEntrada.Name = "dgv_camposEntrada";
            this.dgv_camposEntrada.RowHeadersVisible = false;
            this.dgv_camposEntrada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_camposEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_camposEntrada.ShowCellErrors = false;
            this.dgv_camposEntrada.ShowCellToolTips = false;
            this.dgv_camposEntrada.Size = new System.Drawing.Size(683, 128);
            this.dgv_camposEntrada.StandardTab = true;
            this.dgv_camposEntrada.TabIndex = 10;
            // 
            // btn_visualizarVariavelEntrada
            // 
            this.btn_visualizarVariavelEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_visualizarVariavelEntrada.BackgroundImage = global::DevTools.Properties.Resources.eye_100px20x20;
            this.btn_visualizarVariavelEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_visualizarVariavelEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_visualizarVariavelEntrada.Location = new System.Drawing.Point(708, 100);
            this.btn_visualizarVariavelEntrada.Name = "btn_visualizarVariavelEntrada";
            this.btn_visualizarVariavelEntrada.Size = new System.Drawing.Size(20, 20);
            this.btn_visualizarVariavelEntrada.TabIndex = 14;
            this.btn_visualizarVariavelEntrada.UseVisualStyleBackColor = true;
            this.btn_visualizarVariavelEntrada.Click += new System.EventHandler(this.btn_visualizarVariavelEntrada_Click);
            // 
            // btn_removerCampoEntrada
            // 
            this.btn_removerCampoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removerCampoEntrada.BackgroundImage = global::DevTools.Properties.Resources.close_outline_100px20x20;
            this.btn_removerCampoEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_removerCampoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removerCampoEntrada.Location = new System.Drawing.Point(708, 74);
            this.btn_removerCampoEntrada.Name = "btn_removerCampoEntrada";
            this.btn_removerCampoEntrada.Size = new System.Drawing.Size(20, 20);
            this.btn_removerCampoEntrada.TabIndex = 13;
            this.btn_removerCampoEntrada.UseVisualStyleBackColor = true;
            this.btn_removerCampoEntrada.Click += new System.EventHandler(this.btn_removerCampoEntrada_Click);
            // 
            // btn_editarCampoEntrada
            // 
            this.btn_editarCampoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editarCampoEntrada.BackgroundImage = global::DevTools.Properties.Resources.lead_pencil_100px20x20;
            this.btn_editarCampoEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_editarCampoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editarCampoEntrada.Location = new System.Drawing.Point(708, 48);
            this.btn_editarCampoEntrada.Name = "btn_editarCampoEntrada";
            this.btn_editarCampoEntrada.Size = new System.Drawing.Size(20, 20);
            this.btn_editarCampoEntrada.TabIndex = 12;
            this.btn_editarCampoEntrada.UseVisualStyleBackColor = true;
            this.btn_editarCampoEntrada.Click += new System.EventHandler(this.btn_editarCampoEntrada_Click);
            // 
            // btn_adicionarCampoEntrada
            // 
            this.btn_adicionarCampoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adicionarCampoEntrada.BackgroundImage = global::DevTools.Properties.Resources.plus20x20;
            this.btn_adicionarCampoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionarCampoEntrada.Location = new System.Drawing.Point(708, 22);
            this.btn_adicionarCampoEntrada.Name = "btn_adicionarCampoEntrada";
            this.btn_adicionarCampoEntrada.Size = new System.Drawing.Size(20, 20);
            this.btn_adicionarCampoEntrada.TabIndex = 11;
            this.btn_adicionarCampoEntrada.UseVisualStyleBackColor = true;
            this.btn_adicionarCampoEntrada.Click += new System.EventHandler(this.btn_adicionarCampoEntrada_Click);
            // 
            // grb_cadastro
            // 
            this.grb_cadastro.Controls.Add(this.btn_visualizarConsulta);
            this.grb_cadastro.Controls.Add(this.lbl_consultaProcedure);
            this.grb_cadastro.Controls.Add(this.btn_info_consultaProcedure);
            this.grb_cadastro.Controls.Add(this.tbx_ConsultaProcedure);
            this.grb_cadastro.Controls.Add(this.cmb_tipoMetodo);
            this.grb_cadastro.Controls.Add(this.lbl_tipoMetodo);
            this.grb_cadastro.Controls.Add(this.btn_info_TipoMetodo);
            this.grb_cadastro.Controls.Add(this.lbl_rota);
            this.grb_cadastro.Controls.Add(this.btn_infoRotaMetodo);
            this.grb_cadastro.Controls.Add(this.tbx_rota);
            this.grb_cadastro.Controls.Add(this.lbl_nomeMetodo);
            this.grb_cadastro.Controls.Add(this.btn_info_metodo);
            this.grb_cadastro.Controls.Add(this.tbx_nomeMetodo);
            this.grb_cadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_cadastro.Location = new System.Drawing.Point(0, 0);
            this.grb_cadastro.Name = "grb_cadastro";
            this.grb_cadastro.Size = new System.Drawing.Size(734, 143);
            this.grb_cadastro.TabIndex = 0;
            this.grb_cadastro.TabStop = false;
            this.grb_cadastro.Text = "Cadastro do Método";
            // 
            // btn_visualizarConsulta
            // 
            this.btn_visualizarConsulta.BackgroundImage = global::DevTools.Properties.Resources.eye_100px20x20;
            this.btn_visualizarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_visualizarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_visualizarConsulta.Location = new System.Drawing.Point(589, 113);
            this.btn_visualizarConsulta.Name = "btn_visualizarConsulta";
            this.btn_visualizarConsulta.Size = new System.Drawing.Size(20, 20);
            this.btn_visualizarConsulta.TabIndex = 9;
            this.btn_visualizarConsulta.UseVisualStyleBackColor = true;
            this.btn_visualizarConsulta.Click += new System.EventHandler(this.btn_visualizarConsulta_Click);
            // 
            // lbl_consultaProcedure
            // 
            this.lbl_consultaProcedure.AutoSize = true;
            this.lbl_consultaProcedure.Location = new System.Drawing.Point(6, 115);
            this.lbl_consultaProcedure.Name = "lbl_consultaProcedure";
            this.lbl_consultaProcedure.Size = new System.Drawing.Size(57, 16);
            this.lbl_consultaProcedure.TabIndex = 24;
            this.lbl_consultaProcedure.Text = "Consulta";
            // 
            // btn_info_consultaProcedure
            // 
            this.btn_info_consultaProcedure.BackgroundImage = global::DevTools.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_consultaProcedure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_consultaProcedure.Location = new System.Drawing.Point(563, 113);
            this.btn_info_consultaProcedure.Name = "btn_info_consultaProcedure";
            this.btn_info_consultaProcedure.Size = new System.Drawing.Size(20, 20);
            this.btn_info_consultaProcedure.TabIndex = 8;
            this.btn_info_consultaProcedure.UseVisualStyleBackColor = true;
            // 
            // tbx_ConsultaProcedure
            // 
            this.tbx_ConsultaProcedure.Location = new System.Drawing.Point(109, 112);
            this.tbx_ConsultaProcedure.MaxLength = 35000;
            this.tbx_ConsultaProcedure.Name = "tbx_ConsultaProcedure";
            this.tbx_ConsultaProcedure.Size = new System.Drawing.Size(448, 23);
            this.tbx_ConsultaProcedure.TabIndex = 7;
            // 
            // cmb_tipoMetodo
            // 
            this.cmb_tipoMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_tipoMetodo.FormattingEnabled = true;
            this.cmb_tipoMetodo.Items.AddRange(new object[] {
            "HttpsPost",
            "HttpsGet",
            "HttpsDelete"});
            this.cmb_tipoMetodo.Location = new System.Drawing.Point(111, 83);
            this.cmb_tipoMetodo.Name = "cmb_tipoMetodo";
            this.cmb_tipoMetodo.Size = new System.Drawing.Size(446, 23);
            this.cmb_tipoMetodo.TabIndex = 5;
            // 
            // lbl_tipoMetodo
            // 
            this.lbl_tipoMetodo.AutoSize = true;
            this.lbl_tipoMetodo.Location = new System.Drawing.Point(6, 83);
            this.lbl_tipoMetodo.Name = "lbl_tipoMetodo";
            this.lbl_tipoMetodo.Size = new System.Drawing.Size(99, 16);
            this.lbl_tipoMetodo.TabIndex = 20;
            this.lbl_tipoMetodo.Text = "Tipo do Método";
            // 
            // btn_info_TipoMetodo
            // 
            this.btn_info_TipoMetodo.BackgroundImage = global::DevTools.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_TipoMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_TipoMetodo.Location = new System.Drawing.Point(563, 84);
            this.btn_info_TipoMetodo.Name = "btn_info_TipoMetodo";
            this.btn_info_TipoMetodo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_TipoMetodo.TabIndex = 6;
            this.btn_info_TipoMetodo.UseVisualStyleBackColor = true;
            // 
            // lbl_rota
            // 
            this.lbl_rota.AutoSize = true;
            this.lbl_rota.Location = new System.Drawing.Point(6, 54);
            this.lbl_rota.Name = "lbl_rota";
            this.lbl_rota.Size = new System.Drawing.Size(34, 16);
            this.lbl_rota.TabIndex = 17;
            this.lbl_rota.Text = "Rota";
            // 
            // btn_infoRotaMetodo
            // 
            this.btn_infoRotaMetodo.BackgroundImage = global::DevTools.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_infoRotaMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoRotaMetodo.Location = new System.Drawing.Point(563, 52);
            this.btn_infoRotaMetodo.Name = "btn_infoRotaMetodo";
            this.btn_infoRotaMetodo.Size = new System.Drawing.Size(20, 20);
            this.btn_infoRotaMetodo.TabIndex = 4;
            this.btn_infoRotaMetodo.UseVisualStyleBackColor = true;
            // 
            // tbx_rota
            // 
            this.tbx_rota.Location = new System.Drawing.Point(109, 51);
            this.tbx_rota.MaxLength = 50;
            this.tbx_rota.Name = "tbx_rota";
            this.tbx_rota.Size = new System.Drawing.Size(448, 23);
            this.tbx_rota.TabIndex = 3;
            // 
            // lbl_nomeMetodo
            // 
            this.lbl_nomeMetodo.AutoSize = true;
            this.lbl_nomeMetodo.Location = new System.Drawing.Point(3, 25);
            this.lbl_nomeMetodo.Name = "lbl_nomeMetodo";
            this.lbl_nomeMetodo.Size = new System.Drawing.Size(106, 16);
            this.lbl_nomeMetodo.TabIndex = 14;
            this.lbl_nomeMetodo.Text = "Nome do método";
            // 
            // btn_info_metodo
            // 
            this.btn_info_metodo.BackgroundImage = global::DevTools.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_metodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_metodo.Location = new System.Drawing.Point(563, 23);
            this.btn_info_metodo.Name = "btn_info_metodo";
            this.btn_info_metodo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_metodo.TabIndex = 2;
            this.btn_info_metodo.UseVisualStyleBackColor = true;
            // 
            // tbx_nomeMetodo
            // 
            this.tbx_nomeMetodo.Location = new System.Drawing.Point(109, 22);
            this.tbx_nomeMetodo.MaxLength = 50;
            this.tbx_nomeMetodo.Name = "tbx_nomeMetodo";
            this.tbx_nomeMetodo.Size = new System.Drawing.Size(448, 23);
            this.tbx_nomeMetodo.TabIndex = 1;
            // 
            // UC_ControleMetodoRotaRepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_completo);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_ControleMetodoRotaRepository";
            this.Size = new System.Drawing.Size(740, 562);
            this.pan_botton.ResumeLayout(false);
            this.pan_top.ResumeLayout(false);
            this.pan_completo.ResumeLayout(false);
            this.grb_metodo.ResumeLayout(false);
            this.pan_tot.ResumeLayout(false);
            this.grb_variaveisEntrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_camposSaida)).EndInit();
            this.grb_dadosEntrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_camposEntrada)).EndInit();
            this.grb_cadastro.ResumeLayout(false);
            this.grb_cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel pan_completo;
        private System.Windows.Forms.GroupBox grb_metodo;
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.GroupBox grb_cadastro;
        private System.Windows.Forms.Label lbl_tipoMetodo;
        private System.Windows.Forms.Button btn_info_TipoMetodo;
        private System.Windows.Forms.Label lbl_rota;
        private System.Windows.Forms.Button btn_infoRotaMetodo;
        private System.Windows.Forms.TextBox tbx_rota;
        private System.Windows.Forms.Label lbl_nomeMetodo;
        private System.Windows.Forms.Button btn_info_metodo;
        private System.Windows.Forms.TextBox tbx_nomeMetodo;
        private System.Windows.Forms.ComboBox cmb_tipoMetodo;
        private System.Windows.Forms.Label lbl_consultaProcedure;
        private System.Windows.Forms.Button btn_info_consultaProcedure;
        private System.Windows.Forms.TextBox tbx_ConsultaProcedure;
        private System.Windows.Forms.GroupBox grb_dadosEntrada;
        private System.Windows.Forms.Button btn_visualizarVariavelEntrada;
        private System.Windows.Forms.Button btn_removerCampoEntrada;
        private System.Windows.Forms.Button btn_editarCampoEntrada;
        private System.Windows.Forms.Button btn_adicionarCampoEntrada;
        private System.Windows.Forms.GroupBox grb_variaveisEntrada;
        private System.Windows.Forms.DataGridView dgv_camposSaida;
        private System.Windows.Forms.Button btn_visualizarCampoSaida;
        private System.Windows.Forms.Button btn_removerCampoSaida;
        private System.Windows.Forms.Button btn_editarCampoSaida;
        private System.Windows.Forms.Button btn_cadastrarCampoSaida;
        private System.Windows.Forms.DataGridView dgv_camposEntrada;
        private System.Windows.Forms.Button btn_visualizarConsulta;
    }
}
