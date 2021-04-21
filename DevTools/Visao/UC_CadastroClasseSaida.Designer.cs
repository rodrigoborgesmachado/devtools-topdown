namespace Visao
{
    partial class UC_CadastroClasseSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CadastroClasseSaida));
            this.tbx_nomeClasse = new System.Windows.Forms.TextBox();
            this.grb_cadastroClasse = new System.Windows.Forms.GroupBox();
            this.lbl_tipoCampo = new System.Windows.Forms.Label();
            this.dgv_camposClasse = new System.Windows.Forms.DataGridView();
            this.grb_cadastro = new System.Windows.Forms.GroupBox();
            this.grb_camposClasse = new System.Windows.Forms.GroupBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_visualizarVariavelEntrada = new System.Windows.Forms.Button();
            this.btn_removerCampoEntrada = new System.Windows.Forms.Button();
            this.btn_editarCampoEntrada = new System.Windows.Forms.Button();
            this.btn_adicionarCampoEntrada = new System.Windows.Forms.Button();
            this.btn_info_nomeClasse = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.grb_cadastroClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_camposClasse)).BeginInit();
            this.grb_cadastro.SuspendLayout();
            this.grb_camposClasse.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_nomeClasse
            // 
            this.tbx_nomeClasse.Location = new System.Drawing.Point(56, 16);
            this.tbx_nomeClasse.MaxLength = 50;
            this.tbx_nomeClasse.Name = "tbx_nomeClasse";
            this.tbx_nomeClasse.Size = new System.Drawing.Size(483, 23);
            this.tbx_nomeClasse.TabIndex = 25;
            // 
            // grb_cadastroClasse
            // 
            this.grb_cadastroClasse.Controls.Add(this.tbx_nomeClasse);
            this.grb_cadastroClasse.Controls.Add(this.lbl_tipoCampo);
            this.grb_cadastroClasse.Controls.Add(this.btn_info_nomeClasse);
            this.grb_cadastroClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_cadastroClasse.Location = new System.Drawing.Point(3, 19);
            this.grb_cadastroClasse.Name = "grb_cadastroClasse";
            this.grb_cadastroClasse.Size = new System.Drawing.Size(734, 53);
            this.grb_cadastroClasse.TabIndex = 26;
            this.grb_cadastroClasse.TabStop = false;
            this.grb_cadastroClasse.Text = "Dados da Classe";
            // 
            // lbl_tipoCampo
            // 
            this.lbl_tipoCampo.AutoSize = true;
            this.lbl_tipoCampo.Location = new System.Drawing.Point(6, 19);
            this.lbl_tipoCampo.Name = "lbl_tipoCampo";
            this.lbl_tipoCampo.Size = new System.Drawing.Size(44, 16);
            this.lbl_tipoCampo.TabIndex = 24;
            this.lbl_tipoCampo.Text = "Classe";
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
            this.dgv_camposClasse.Size = new System.Drawing.Size(693, 356);
            this.dgv_camposClasse.StandardTab = true;
            this.dgv_camposClasse.TabIndex = 39;
            // 
            // grb_cadastro
            // 
            this.grb_cadastro.Controls.Add(this.grb_camposClasse);
            this.grb_cadastro.Controls.Add(this.grb_cadastroClasse);
            this.grb_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_cadastro.Location = new System.Drawing.Point(0, 20);
            this.grb_cadastro.Name = "grb_cadastro";
            this.grb_cadastro.Size = new System.Drawing.Size(740, 507);
            this.grb_cadastro.TabIndex = 31;
            this.grb_cadastro.TabStop = false;
            this.grb_cadastro.Text = "Cadastro de campo";
            // 
            // grb_camposClasse
            // 
            this.grb_camposClasse.Controls.Add(this.dgv_camposClasse);
            this.grb_camposClasse.Controls.Add(this.btn_visualizarVariavelEntrada);
            this.grb_camposClasse.Controls.Add(this.btn_removerCampoEntrada);
            this.grb_camposClasse.Controls.Add(this.btn_editarCampoEntrada);
            this.grb_camposClasse.Controls.Add(this.btn_adicionarCampoEntrada);
            this.grb_camposClasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_camposClasse.Location = new System.Drawing.Point(3, 72);
            this.grb_camposClasse.Name = "grb_camposClasse";
            this.grb_camposClasse.Size = new System.Drawing.Size(734, 432);
            this.grb_camposClasse.TabIndex = 28;
            this.grb_camposClasse.TabStop = false;
            this.grb_camposClasse.Text = "Campos da Classe";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Location = new System.Drawing.Point(579, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 29);
            this.btn_excluir.TabIndex = 24;
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
            this.btn_confirmar.TabIndex = 23;
            this.btn_confirmar.Text = "Cadastrar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_excluir);
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 527);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(740, 35);
            this.pan_botton.TabIndex = 29;
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 30;
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
            this.btn_visualizarVariavelEntrada.TabIndex = 38;
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
            this.btn_removerCampoEntrada.TabIndex = 37;
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
            this.btn_editarCampoEntrada.TabIndex = 36;
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
            this.btn_adicionarCampoEntrada.TabIndex = 35;
            this.btn_adicionarCampoEntrada.UseVisualStyleBackColor = true;
            this.btn_adicionarCampoEntrada.Click += new System.EventHandler(this.btn_adicionarCampoEntrada_Click);
            // 
            // btn_info_nomeClasse
            // 
            this.btn_info_nomeClasse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_nomeClasse.BackgroundImage")));
            this.btn_info_nomeClasse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_nomeClasse.Location = new System.Drawing.Point(545, 18);
            this.btn_info_nomeClasse.Name = "btn_info_nomeClasse";
            this.btn_info_nomeClasse.Size = new System.Drawing.Size(20, 20);
            this.btn_info_nomeClasse.TabIndex = 23;
            this.btn_info_nomeClasse.UseVisualStyleBackColor = true;
            this.btn_info_nomeClasse.Click += new System.EventHandler(this.btn_info_nomeClasse_Click);
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
            this.btn_fechar.TabIndex = 17;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // UC_CadastroClasseSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.grb_cadastro);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroClasseSaida";
            this.Size = new System.Drawing.Size(740, 562);
            this.grb_cadastroClasse.ResumeLayout(false);
            this.grb_cadastroClasse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_camposClasse)).EndInit();
            this.grb_cadastro.ResumeLayout(false);
            this.grb_camposClasse.ResumeLayout(false);
            this.pan_botton.ResumeLayout(false);
            this.pan_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_nomeClasse;
        private System.Windows.Forms.Button btn_info_nomeClasse;
        private System.Windows.Forms.GroupBox grb_cadastroClasse;
        private System.Windows.Forms.Label lbl_tipoCampo;
        private System.Windows.Forms.DataGridView dgv_camposClasse;
        private System.Windows.Forms.Button btn_visualizarVariavelEntrada;
        private System.Windows.Forms.GroupBox grb_cadastro;
        private System.Windows.Forms.GroupBox grb_camposClasse;
        private System.Windows.Forms.Button btn_removerCampoEntrada;
        private System.Windows.Forms.Button btn_editarCampoEntrada;
        private System.Windows.Forms.Button btn_adicionarCampoEntrada;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Panel pan_top;
    }
}
