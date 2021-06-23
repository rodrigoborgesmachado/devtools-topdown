namespace Visao
{
    partial class UC_CadastroRotaRepository
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
            this.pan_tot = new System.Windows.Forms.Panel();
            this.pan_formularioGeral = new System.Windows.Forms.Panel();
            this.gpb_cadastroGeral = new System.Windows.Forms.GroupBox();
            this.pan_informacoesRota = new System.Windows.Forms.Panel();
            this.grb_metodos = new System.Windows.Forms.GroupBox();
            this.btn_reload_tabela = new System.Windows.Forms.Button();
            this.btn_visualizarMetodo = new System.Windows.Forms.Button();
            this.btn_removerMetodo = new System.Windows.Forms.Button();
            this.btn_editarMetodo = new System.Windows.Forms.Button();
            this.btn_adicionarMetodo = new System.Windows.Forms.Button();
            this.dgv_metodos = new System.Windows.Forms.DataGridView();
            this.pan_dadosRota = new System.Windows.Forms.Panel();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.btn_info_descricao = new System.Windows.Forms.Button();
            this.tbx_descricao = new System.Windows.Forms.TextBox();
            this.lbl_rota = new System.Windows.Forms.Label();
            this.btn_infoRota = new System.Windows.Forms.Button();
            this.tbx_rota = new System.Windows.Forms.TextBox();
            this.lbl_nomeRota = new System.Windows.Forms.Label();
            this.btn_info_rota = new System.Windows.Forms.Button();
            this.tbx_nomeRota = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.lbl_quantidadeMetodos = new System.Windows.Forms.Label();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_gerarRelatorio = new System.Windows.Forms.Button();
            this.pan_tot.SuspendLayout();
            this.pan_formularioGeral.SuspendLayout();
            this.gpb_cadastroGeral.SuspendLayout();
            this.pan_informacoesRota.SuspendLayout();
            this.grb_metodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_metodos)).BeginInit();
            this.pan_dadosRota.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_tot
            // 
            this.pan_tot.AutoScroll = true;
            this.pan_tot.Controls.Add(this.pan_formularioGeral);
            this.pan_tot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_tot.Location = new System.Drawing.Point(0, 20);
            this.pan_tot.Name = "pan_tot";
            this.pan_tot.Size = new System.Drawing.Size(740, 507);
            this.pan_tot.TabIndex = 19;
            // 
            // pan_formularioGeral
            // 
            this.pan_formularioGeral.AllowDrop = true;
            this.pan_formularioGeral.AutoScroll = true;
            this.pan_formularioGeral.Controls.Add(this.gpb_cadastroGeral);
            this.pan_formularioGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_formularioGeral.Location = new System.Drawing.Point(0, 0);
            this.pan_formularioGeral.Name = "pan_formularioGeral";
            this.pan_formularioGeral.Size = new System.Drawing.Size(740, 507);
            this.pan_formularioGeral.TabIndex = 0;
            // 
            // gpb_cadastroGeral
            // 
            this.gpb_cadastroGeral.Controls.Add(this.pan_informacoesRota);
            this.gpb_cadastroGeral.Controls.Add(this.pan_dadosRota);
            this.gpb_cadastroGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_cadastroGeral.Location = new System.Drawing.Point(0, 0);
            this.gpb_cadastroGeral.Name = "gpb_cadastroGeral";
            this.gpb_cadastroGeral.Size = new System.Drawing.Size(740, 507);
            this.gpb_cadastroGeral.TabIndex = 0;
            this.gpb_cadastroGeral.TabStop = false;
            this.gpb_cadastroGeral.Text = "Configuração de Rota";
            // 
            // pan_informacoesRota
            // 
            this.pan_informacoesRota.Controls.Add(this.grb_metodos);
            this.pan_informacoesRota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_informacoesRota.Location = new System.Drawing.Point(3, 129);
            this.pan_informacoesRota.Name = "pan_informacoesRota";
            this.pan_informacoesRota.Size = new System.Drawing.Size(734, 375);
            this.pan_informacoesRota.TabIndex = 7;
            // 
            // grb_metodos
            // 
            this.grb_metodos.Controls.Add(this.btn_reload_tabela);
            this.grb_metodos.Controls.Add(this.btn_visualizarMetodo);
            this.grb_metodos.Controls.Add(this.btn_removerMetodo);
            this.grb_metodos.Controls.Add(this.btn_editarMetodo);
            this.grb_metodos.Controls.Add(this.btn_adicionarMetodo);
            this.grb_metodos.Controls.Add(this.dgv_metodos);
            this.grb_metodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_metodos.Location = new System.Drawing.Point(0, 0);
            this.grb_metodos.Name = "grb_metodos";
            this.grb_metodos.Size = new System.Drawing.Size(734, 375);
            this.grb_metodos.TabIndex = 0;
            this.grb_metodos.TabStop = false;
            this.grb_metodos.Text = "Métodos";
            // 
            // btn_reload_tabela
            // 
            this.btn_reload_tabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reload_tabela.BackgroundImage = global::DevTools.Properties.Resources.refresh120x20;
            this.btn_reload_tabela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reload_tabela.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reload_tabela.Location = new System.Drawing.Point(708, 126);
            this.btn_reload_tabela.Name = "btn_reload_tabela";
            this.btn_reload_tabela.Size = new System.Drawing.Size(20, 20);
            this.btn_reload_tabela.TabIndex = 11;
            this.btn_reload_tabela.UseVisualStyleBackColor = true;
            this.btn_reload_tabela.Click += new System.EventHandler(this.btn_reload_tabela_Click);
            // 
            // btn_visualizarMetodo
            // 
            this.btn_visualizarMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_visualizarMetodo.BackgroundImage = global::DevTools.Properties.Resources.eye_100px20x20;
            this.btn_visualizarMetodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_visualizarMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_visualizarMetodo.Location = new System.Drawing.Point(708, 100);
            this.btn_visualizarMetodo.Name = "btn_visualizarMetodo";
            this.btn_visualizarMetodo.Size = new System.Drawing.Size(20, 20);
            this.btn_visualizarMetodo.TabIndex = 10;
            this.btn_visualizarMetodo.UseVisualStyleBackColor = true;
            this.btn_visualizarMetodo.Click += new System.EventHandler(this.btn_visualizarMetodo_Click);
            // 
            // btn_removerMetodo
            // 
            this.btn_removerMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removerMetodo.BackgroundImage = global::DevTools.Properties.Resources.close_outline_100px20x20;
            this.btn_removerMetodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_removerMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removerMetodo.Location = new System.Drawing.Point(708, 74);
            this.btn_removerMetodo.Name = "btn_removerMetodo";
            this.btn_removerMetodo.Size = new System.Drawing.Size(20, 20);
            this.btn_removerMetodo.TabIndex = 9;
            this.btn_removerMetodo.UseVisualStyleBackColor = true;
            this.btn_removerMetodo.Click += new System.EventHandler(this.btn_removerMetodo_Click);
            // 
            // btn_editarMetodo
            // 
            this.btn_editarMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editarMetodo.BackgroundImage = global::DevTools.Properties.Resources.lead_pencil_100px20x20;
            this.btn_editarMetodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_editarMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editarMetodo.Location = new System.Drawing.Point(708, 48);
            this.btn_editarMetodo.Name = "btn_editarMetodo";
            this.btn_editarMetodo.Size = new System.Drawing.Size(20, 20);
            this.btn_editarMetodo.TabIndex = 8;
            this.btn_editarMetodo.UseVisualStyleBackColor = true;
            this.btn_editarMetodo.Click += new System.EventHandler(this.btn_editarMetodo_Click);
            // 
            // btn_adicionarMetodo
            // 
            this.btn_adicionarMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adicionarMetodo.BackgroundImage = global::DevTools.Properties.Resources.plus20x20;
            this.btn_adicionarMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionarMetodo.Location = new System.Drawing.Point(708, 22);
            this.btn_adicionarMetodo.Name = "btn_adicionarMetodo";
            this.btn_adicionarMetodo.Size = new System.Drawing.Size(20, 20);
            this.btn_adicionarMetodo.TabIndex = 7;
            this.btn_adicionarMetodo.UseVisualStyleBackColor = true;
            this.btn_adicionarMetodo.Click += new System.EventHandler(this.btn_adicionarMetodo_Click);
            // 
            // dgv_metodos
            // 
            this.dgv_metodos.AllowUserToAddRows = false;
            this.dgv_metodos.AllowUserToDeleteRows = false;
            this.dgv_metodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_metodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_metodos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_metodos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_metodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_metodos.ColumnHeadersHeight = 29;
            this.dgv_metodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_metodos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_metodos.EnableHeadersVisualStyles = false;
            this.dgv_metodos.Location = new System.Drawing.Point(6, 22);
            this.dgv_metodos.MultiSelect = false;
            this.dgv_metodos.Name = "dgv_metodos";
            this.dgv_metodos.RowHeadersVisible = false;
            this.dgv_metodos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_metodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_metodos.ShowCellErrors = false;
            this.dgv_metodos.ShowCellToolTips = false;
            this.dgv_metodos.Size = new System.Drawing.Size(696, 347);
            this.dgv_metodos.StandardTab = true;
            this.dgv_metodos.TabIndex = 25;
            // 
            // pan_dadosRota
            // 
            this.pan_dadosRota.Controls.Add(this.lbl_descricao);
            this.pan_dadosRota.Controls.Add(this.btn_info_descricao);
            this.pan_dadosRota.Controls.Add(this.tbx_descricao);
            this.pan_dadosRota.Controls.Add(this.lbl_rota);
            this.pan_dadosRota.Controls.Add(this.btn_infoRota);
            this.pan_dadosRota.Controls.Add(this.tbx_rota);
            this.pan_dadosRota.Controls.Add(this.lbl_nomeRota);
            this.pan_dadosRota.Controls.Add(this.btn_info_rota);
            this.pan_dadosRota.Controls.Add(this.tbx_nomeRota);
            this.pan_dadosRota.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_dadosRota.Location = new System.Drawing.Point(3, 23);
            this.pan_dadosRota.Name = "pan_dadosRota";
            this.pan_dadosRota.Size = new System.Drawing.Size(734, 106);
            this.pan_dadosRota.TabIndex = 6;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(15, 68);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(79, 19);
            this.lbl_descricao.TabIndex = 11;
            this.lbl_descricao.Text = "Descricao";
            // 
            // btn_info_descricao
            // 
            this.btn_info_descricao.BackgroundImage = global::DevTools.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_descricao.Location = new System.Drawing.Point(560, 66);
            this.btn_info_descricao.Name = "btn_info_descricao";
            this.btn_info_descricao.Size = new System.Drawing.Size(20, 20);
            this.btn_info_descricao.TabIndex = 5;
            this.btn_info_descricao.UseVisualStyleBackColor = true;
            this.btn_info_descricao.Click += new System.EventHandler(this.btn_info_descricao_Click);
            // 
            // tbx_descricao
            // 
            this.tbx_descricao.Location = new System.Drawing.Point(106, 65);
            this.tbx_descricao.MaxLength = 50;
            this.tbx_descricao.Name = "tbx_descricao";
            this.tbx_descricao.Size = new System.Drawing.Size(448, 27);
            this.tbx_descricao.TabIndex = 5;
            // 
            // lbl_rota
            // 
            this.lbl_rota.AutoSize = true;
            this.lbl_rota.Location = new System.Drawing.Point(15, 39);
            this.lbl_rota.Name = "lbl_rota";
            this.lbl_rota.Size = new System.Drawing.Size(41, 19);
            this.lbl_rota.TabIndex = 8;
            this.lbl_rota.Text = "Rota";
            // 
            // btn_infoRota
            // 
            this.btn_infoRota.BackgroundImage = global::DevTools.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_infoRota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoRota.Location = new System.Drawing.Point(560, 37);
            this.btn_infoRota.Name = "btn_infoRota";
            this.btn_infoRota.Size = new System.Drawing.Size(20, 20);
            this.btn_infoRota.TabIndex = 3;
            this.btn_infoRota.UseVisualStyleBackColor = true;
            this.btn_infoRota.Click += new System.EventHandler(this.btn_infoRota_Click);
            // 
            // tbx_rota
            // 
            this.tbx_rota.Location = new System.Drawing.Point(106, 36);
            this.tbx_rota.MaxLength = 50;
            this.tbx_rota.Name = "tbx_rota";
            this.tbx_rota.Size = new System.Drawing.Size(448, 27);
            this.tbx_rota.TabIndex = 3;
            // 
            // lbl_nomeRota
            // 
            this.lbl_nomeRota.AutoSize = true;
            this.lbl_nomeRota.Location = new System.Drawing.Point(15, 10);
            this.lbl_nomeRota.Name = "lbl_nomeRota";
            this.lbl_nomeRota.Size = new System.Drawing.Size(82, 19);
            this.lbl_nomeRota.TabIndex = 5;
            this.lbl_nomeRota.Text = "Nome rota";
            // 
            // btn_info_rota
            // 
            this.btn_info_rota.BackgroundImage = global::DevTools.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_rota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_rota.Location = new System.Drawing.Point(560, 8);
            this.btn_info_rota.Name = "btn_info_rota";
            this.btn_info_rota.Size = new System.Drawing.Size(20, 20);
            this.btn_info_rota.TabIndex = 2;
            this.btn_info_rota.UseVisualStyleBackColor = true;
            this.btn_info_rota.Click += new System.EventHandler(this.btn_info_NomeRota_Click);
            // 
            // tbx_nomeRota
            // 
            this.tbx_nomeRota.Location = new System.Drawing.Point(106, 7);
            this.tbx_nomeRota.MaxLength = 50;
            this.tbx_nomeRota.Name = "tbx_nomeRota";
            this.tbx_nomeRota.Size = new System.Drawing.Size(448, 27);
            this.tbx_nomeRota.TabIndex = 1;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Location = new System.Drawing.Point(581, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 29);
            this.btn_excluir.TabIndex = 13;
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
            this.btn_confirmar.TabIndex = 12;
            this.btn_confirmar.Text = "Cadastrar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_gerarRelatorio);
            this.pan_botton.Controls.Add(this.lbl_quantidadeMetodos);
            this.pan_botton.Controls.Add(this.btn_excluir);
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 527);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(740, 35);
            this.pan_botton.TabIndex = 20;
            // 
            // lbl_quantidadeMetodos
            // 
            this.lbl_quantidadeMetodos.AutoSize = true;
            this.lbl_quantidadeMetodos.Location = new System.Drawing.Point(6, 10);
            this.lbl_quantidadeMetodos.Name = "lbl_quantidadeMetodos";
            this.lbl_quantidadeMetodos.Size = new System.Drawing.Size(84, 19);
            this.lbl_quantidadeMetodos.TabIndex = 14;
            this.lbl_quantidadeMetodos.Text = "X métodos";
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 21;
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
            this.btn_fechar.TabIndex = 14;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_gerarRelatorio
            // 
            this.btn_gerarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerarRelatorio.Location = new System.Drawing.Point(493, 3);
            this.btn_gerarRelatorio.Name = "btn_gerarRelatorio";
            this.btn_gerarRelatorio.Size = new System.Drawing.Size(82, 29);
            this.btn_gerarRelatorio.TabIndex = 15;
            this.btn_gerarRelatorio.Text = "Relatório";
            this.btn_gerarRelatorio.UseVisualStyleBackColor = true;
            this.btn_gerarRelatorio.Click += new System.EventHandler(this.Btn_gerarRelatorio_Click);
            // 
            // UC_CadastroRotaRepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_tot);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroRotaRepository";
            this.Size = new System.Drawing.Size(740, 562);
            this.pan_tot.ResumeLayout(false);
            this.pan_formularioGeral.ResumeLayout(false);
            this.gpb_cadastroGeral.ResumeLayout(false);
            this.pan_informacoesRota.ResumeLayout(false);
            this.grb_metodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_metodos)).EndInit();
            this.pan_dadosRota.ResumeLayout(false);
            this.pan_dadosRota.PerformLayout();
            this.pan_botton.ResumeLayout(false);
            this.pan_botton.PerformLayout();
            this.pan_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_info_rota;
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.Panel pan_formularioGeral;
        private System.Windows.Forms.GroupBox gpb_cadastroGeral;
        private System.Windows.Forms.Label lbl_nomeRota;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.TextBox tbx_nomeRota;
        private System.Windows.Forms.Panel pan_dadosRota;
        private System.Windows.Forms.Label lbl_rota;
        private System.Windows.Forms.Button btn_infoRota;
        private System.Windows.Forms.TextBox tbx_rota;
        private System.Windows.Forms.Panel pan_informacoesRota;
        private System.Windows.Forms.GroupBox grb_metodos;
        private System.Windows.Forms.Button btn_removerMetodo;
        private System.Windows.Forms.Button btn_editarMetodo;
        private System.Windows.Forms.Button btn_adicionarMetodo;
        private System.Windows.Forms.DataGridView dgv_metodos;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Button btn_info_descricao;
        private System.Windows.Forms.TextBox tbx_descricao;
        private System.Windows.Forms.Button btn_visualizarMetodo;
        private System.Windows.Forms.Button btn_reload_tabela;
        private System.Windows.Forms.Label lbl_quantidadeMetodos;
        private System.Windows.Forms.Button btn_gerarRelatorio;
    }
}
