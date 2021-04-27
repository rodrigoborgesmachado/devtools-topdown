namespace Visao
{
    partial class UC_CadastroClassesEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CadastroClassesEntrada));
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.grb_cadastro = new System.Windows.Forms.GroupBox();
            this.grb_camposClasse = new System.Windows.Forms.GroupBox();
            this.dgv_camposClasse = new System.Windows.Forms.DataGridView();
            this.btn_visualizarVariavelEntrada = new System.Windows.Forms.Button();
            this.btn_removerCampoEntrada = new System.Windows.Forms.Button();
            this.btn_editarCampoEntrada = new System.Windows.Forms.Button();
            this.btn_adicionarCampoEntrada = new System.Windows.Forms.Button();
            this.grb_informacoesClasse = new System.Windows.Forms.GroupBox();
            this.tbx_classe = new System.Windows.Forms.TextBox();
            this.tbx_nomeClasse = new System.Windows.Forms.TextBox();
            this.btn_info_campo = new System.Windows.Forms.Button();
            this.lbl_tipoCampo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_info_tipoCampo = new System.Windows.Forms.Button();
            this.btn_info_tipoEntrada = new System.Windows.Forms.Button();
            this.cmb_tipoEntrada = new System.Windows.Forms.ComboBox();
            this.lbl_tipoEntrada = new System.Windows.Forms.Label();
            this.btn_reload_tabela = new System.Windows.Forms.Button();
            this.pan_botton.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.grb_cadastro.SuspendLayout();
            this.grb_camposClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_camposClasse)).BeginInit();
            this.grb_informacoesClasse.SuspendLayout();
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
            this.pan_botton.TabIndex = 25;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Location = new System.Drawing.Point(579, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 29);
            this.btn_excluir.TabIndex = 14;
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
            this.btn_confirmar.TabIndex = 13;
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
            this.pan_top.TabIndex = 26;
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
            this.btn_fechar.TabIndex = 15;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // grb_cadastro
            // 
            this.grb_cadastro.Controls.Add(this.grb_camposClasse);
            this.grb_cadastro.Controls.Add(this.grb_informacoesClasse);
            this.grb_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_cadastro.Location = new System.Drawing.Point(0, 20);
            this.grb_cadastro.Name = "grb_cadastro";
            this.grb_cadastro.Size = new System.Drawing.Size(740, 507);
            this.grb_cadastro.TabIndex = 27;
            this.grb_cadastro.TabStop = false;
            this.grb_cadastro.Text = "Cadastro de classe - Entrada";
            // 
            // grb_camposClasse
            // 
            this.grb_camposClasse.Controls.Add(this.btn_reload_tabela);
            this.grb_camposClasse.Controls.Add(this.dgv_camposClasse);
            this.grb_camposClasse.Controls.Add(this.btn_visualizarVariavelEntrada);
            this.grb_camposClasse.Controls.Add(this.btn_removerCampoEntrada);
            this.grb_camposClasse.Controls.Add(this.btn_editarCampoEntrada);
            this.grb_camposClasse.Controls.Add(this.btn_adicionarCampoEntrada);
            this.grb_camposClasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_camposClasse.Location = new System.Drawing.Point(3, 139);
            this.grb_camposClasse.Name = "grb_camposClasse";
            this.grb_camposClasse.Size = new System.Drawing.Size(734, 365);
            this.grb_camposClasse.TabIndex = 27;
            this.grb_camposClasse.TabStop = false;
            this.grb_camposClasse.Text = "Campos da Classe";
            // 
            // dgv_camposClasse
            // 
            this.dgv_camposClasse.AllowUserToAddRows = false;
            this.dgv_camposClasse.AllowUserToDeleteRows = false;
            this.dgv_camposClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_camposClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_camposClasse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_camposClasse.BackgroundColor = System.Drawing.Color.White;
            this.dgv_camposClasse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_camposClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_camposClasse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_camposClasse.EnableHeadersVisualStyles = false;
            this.dgv_camposClasse.Location = new System.Drawing.Point(9, 22);
            this.dgv_camposClasse.MultiSelect = false;
            this.dgv_camposClasse.Name = "dgv_camposClasse";
            this.dgv_camposClasse.RowHeadersVisible = false;
            this.dgv_camposClasse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_camposClasse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_camposClasse.ShowCellErrors = false;
            this.dgv_camposClasse.ShowCellToolTips = false;
            this.dgv_camposClasse.Size = new System.Drawing.Size(693, 289);
            this.dgv_camposClasse.StandardTab = true;
            this.dgv_camposClasse.TabIndex = 7;
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
            this.btn_visualizarVariavelEntrada.TabIndex = 11;
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
            this.btn_removerCampoEntrada.TabIndex = 10;
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
            this.btn_editarCampoEntrada.TabIndex = 9;
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
            this.btn_adicionarCampoEntrada.TabIndex = 8;
            this.btn_adicionarCampoEntrada.UseVisualStyleBackColor = true;
            this.btn_adicionarCampoEntrada.Click += new System.EventHandler(this.btn_adicionarCampoEntrada_Click);
            // 
            // grb_informacoesClasse
            // 
            this.grb_informacoesClasse.Controls.Add(this.tbx_classe);
            this.grb_informacoesClasse.Controls.Add(this.tbx_nomeClasse);
            this.grb_informacoesClasse.Controls.Add(this.btn_info_campo);
            this.grb_informacoesClasse.Controls.Add(this.lbl_tipoCampo);
            this.grb_informacoesClasse.Controls.Add(this.lbl_nome);
            this.grb_informacoesClasse.Controls.Add(this.btn_info_tipoCampo);
            this.grb_informacoesClasse.Controls.Add(this.btn_info_tipoEntrada);
            this.grb_informacoesClasse.Controls.Add(this.cmb_tipoEntrada);
            this.grb_informacoesClasse.Controls.Add(this.lbl_tipoEntrada);
            this.grb_informacoesClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_informacoesClasse.Location = new System.Drawing.Point(3, 19);
            this.grb_informacoesClasse.Name = "grb_informacoesClasse";
            this.grb_informacoesClasse.Size = new System.Drawing.Size(734, 120);
            this.grb_informacoesClasse.TabIndex = 26;
            this.grb_informacoesClasse.TabStop = false;
            this.grb_informacoesClasse.Text = "Informações da Classe";
            // 
            // tbx_classe
            // 
            this.tbx_classe.Location = new System.Drawing.Point(93, 80);
            this.tbx_classe.MaxLength = 50;
            this.tbx_classe.Name = "tbx_classe";
            this.tbx_classe.Size = new System.Drawing.Size(446, 23);
            this.tbx_classe.TabIndex = 5;
            // 
            // tbx_nomeClasse
            // 
            this.tbx_nomeClasse.Location = new System.Drawing.Point(93, 22);
            this.tbx_nomeClasse.MaxLength = 50;
            this.tbx_nomeClasse.Name = "tbx_nomeClasse";
            this.tbx_nomeClasse.Size = new System.Drawing.Size(446, 23);
            this.tbx_nomeClasse.TabIndex = 1;
            // 
            // btn_info_campo
            // 
            this.btn_info_campo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_campo.BackgroundImage")));
            this.btn_info_campo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_campo.Location = new System.Drawing.Point(545, 22);
            this.btn_info_campo.Name = "btn_info_campo";
            this.btn_info_campo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_campo.TabIndex = 2;
            this.btn_info_campo.UseVisualStyleBackColor = true;
            this.btn_info_campo.Click += new System.EventHandler(this.btn_info_campo_Click);
            // 
            // lbl_tipoCampo
            // 
            this.lbl_tipoCampo.AutoSize = true;
            this.lbl_tipoCampo.Location = new System.Drawing.Point(6, 83);
            this.lbl_tipoCampo.Name = "lbl_tipoCampo";
            this.lbl_tipoCampo.Size = new System.Drawing.Size(44, 16);
            this.lbl_tipoCampo.TabIndex = 24;
            this.lbl_tipoCampo.Text = "Classe";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 25);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(89, 16);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Nome variável";
            // 
            // btn_info_tipoCampo
            // 
            this.btn_info_tipoCampo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_tipoCampo.BackgroundImage")));
            this.btn_info_tipoCampo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_tipoCampo.Location = new System.Drawing.Point(545, 82);
            this.btn_info_tipoCampo.Name = "btn_info_tipoCampo";
            this.btn_info_tipoCampo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_tipoCampo.TabIndex = 4;
            this.btn_info_tipoCampo.UseVisualStyleBackColor = true;
            this.btn_info_tipoCampo.Click += new System.EventHandler(this.btn_info_tipoCampo_Click);
            // 
            // btn_info_tipoEntrada
            // 
            this.btn_info_tipoEntrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_tipoEntrada.BackgroundImage")));
            this.btn_info_tipoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_tipoEntrada.Location = new System.Drawing.Point(545, 53);
            this.btn_info_tipoEntrada.Name = "btn_info_tipoEntrada";
            this.btn_info_tipoEntrada.Size = new System.Drawing.Size(20, 20);
            this.btn_info_tipoEntrada.TabIndex = 3;
            this.btn_info_tipoEntrada.UseVisualStyleBackColor = true;
            this.btn_info_tipoEntrada.Click += new System.EventHandler(this.btn_info_tipoEntrada_Click);
            // 
            // cmb_tipoEntrada
            // 
            this.cmb_tipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_tipoEntrada.FormattingEnabled = true;
            this.cmb_tipoEntrada.Items.AddRange(new object[] {
            "Não Aplica",
            "Query",
            "FromBody",
            "FromRoute",
            "Url"});
            this.cmb_tipoEntrada.Location = new System.Drawing.Point(93, 51);
            this.cmb_tipoEntrada.Name = "cmb_tipoEntrada";
            this.cmb_tipoEntrada.Size = new System.Drawing.Size(446, 23);
            this.cmb_tipoEntrada.TabIndex = 3;
            // 
            // lbl_tipoEntrada
            // 
            this.lbl_tipoEntrada.AutoSize = true;
            this.lbl_tipoEntrada.Location = new System.Drawing.Point(6, 54);
            this.lbl_tipoEntrada.Name = "lbl_tipoEntrada";
            this.lbl_tipoEntrada.Size = new System.Drawing.Size(81, 16);
            this.lbl_tipoEntrada.TabIndex = 11;
            this.lbl_tipoEntrada.Text = "Tipo Entrada";
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
            this.btn_reload_tabela.TabIndex = 12;
            this.btn_reload_tabela.UseVisualStyleBackColor = true;
            this.btn_reload_tabela.Click += new System.EventHandler(this.btn_reload_tabela_Click);
            // 
            // UC_CadastroClassesEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.grb_cadastro);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroClassesEntrada";
            this.Size = new System.Drawing.Size(740, 562);
            this.pan_botton.ResumeLayout(false);
            this.pan_top.ResumeLayout(false);
            this.grb_cadastro.ResumeLayout(false);
            this.grb_camposClasse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_camposClasse)).EndInit();
            this.grb_informacoesClasse.ResumeLayout(false);
            this.grb_informacoesClasse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.GroupBox grb_cadastro;
        private System.Windows.Forms.Label lbl_tipoCampo;
        private System.Windows.Forms.Button btn_info_tipoCampo;
        private System.Windows.Forms.ComboBox cmb_tipoEntrada;
        private System.Windows.Forms.Label lbl_tipoEntrada;
        private System.Windows.Forms.Button btn_info_tipoEntrada;
        private System.Windows.Forms.TextBox tbx_nomeClasse;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_info_campo;
        private System.Windows.Forms.GroupBox grb_informacoesClasse;
        private System.Windows.Forms.GroupBox grb_camposClasse;
        private System.Windows.Forms.TextBox tbx_classe;
        private System.Windows.Forms.DataGridView dgv_camposClasse;
        private System.Windows.Forms.Button btn_visualizarVariavelEntrada;
        private System.Windows.Forms.Button btn_removerCampoEntrada;
        private System.Windows.Forms.Button btn_editarCampoEntrada;
        private System.Windows.Forms.Button btn_adicionarCampoEntrada;
        private System.Windows.Forms.Button btn_reload_tabela;
    }
}
