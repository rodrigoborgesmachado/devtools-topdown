namespace Visao
{
    partial class UC_CadastroCampoClasseOuEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CadastroCampoClasseOuEntrada));
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.pan_tot = new System.Windows.Forms.Panel();
            this.grb_cadastro = new System.Windows.Forms.GroupBox();
            this.tbx_nomeCampo = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_info_campo = new System.Windows.Forms.Button();
            this.lbl_tipoEntrada = new System.Windows.Forms.Label();
            this.btn_info_tipoEntrada = new System.Windows.Forms.Button();
            this.cmb_tipoEntrada = new System.Windows.Forms.ComboBox();
            this.cmb_tipoCampo = new System.Windows.Forms.ComboBox();
            this.lbl_tipoCampo = new System.Windows.Forms.Label();
            this.btn_info_tipoCampo = new System.Windows.Forms.Button();
            this.pan_botton.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.pan_tot.SuspendLayout();
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
            this.pan_botton.TabIndex = 23;
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
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 24;
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
            // pan_tot
            // 
            this.pan_tot.Controls.Add(this.grb_cadastro);
            this.pan_tot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_tot.Location = new System.Drawing.Point(0, 20);
            this.pan_tot.Name = "pan_tot";
            this.pan_tot.Size = new System.Drawing.Size(740, 507);
            this.pan_tot.TabIndex = 25;
            // 
            // grb_cadastro
            // 
            this.grb_cadastro.Controls.Add(this.cmb_tipoCampo);
            this.grb_cadastro.Controls.Add(this.lbl_tipoCampo);
            this.grb_cadastro.Controls.Add(this.btn_info_tipoCampo);
            this.grb_cadastro.Controls.Add(this.cmb_tipoEntrada);
            this.grb_cadastro.Controls.Add(this.lbl_tipoEntrada);
            this.grb_cadastro.Controls.Add(this.btn_info_tipoEntrada);
            this.grb_cadastro.Controls.Add(this.tbx_nomeCampo);
            this.grb_cadastro.Controls.Add(this.lbl_nome);
            this.grb_cadastro.Controls.Add(this.btn_info_campo);
            this.grb_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_cadastro.Location = new System.Drawing.Point(0, 0);
            this.grb_cadastro.Name = "grb_cadastro";
            this.grb_cadastro.Size = new System.Drawing.Size(740, 507);
            this.grb_cadastro.TabIndex = 0;
            this.grb_cadastro.TabStop = false;
            this.grb_cadastro.Text = "Cadastro de campo - Entrada";
            // 
            // tbx_nomeCampo
            // 
            this.tbx_nomeCampo.Location = new System.Drawing.Point(93, 22);
            this.tbx_nomeCampo.MaxLength = 50;
            this.tbx_nomeCampo.Name = "tbx_nomeCampo";
            this.tbx_nomeCampo.Size = new System.Drawing.Size(446, 23);
            this.tbx_nomeCampo.TabIndex = 6;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 25);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(48, 16);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Campo";
            // 
            // btn_info_campo
            // 
            this.btn_info_campo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_campo.BackgroundImage")));
            this.btn_info_campo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_campo.Location = new System.Drawing.Point(545, 22);
            this.btn_info_campo.Name = "btn_info_campo";
            this.btn_info_campo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_campo.TabIndex = 7;
            this.btn_info_campo.UseVisualStyleBackColor = true;
            this.btn_info_campo.Click += new System.EventHandler(this.btn_info_campo_Click);
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
            // btn_info_tipoEntrada
            // 
            this.btn_info_tipoEntrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_tipoEntrada.BackgroundImage")));
            this.btn_info_tipoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_tipoEntrada.Location = new System.Drawing.Point(545, 53);
            this.btn_info_tipoEntrada.Name = "btn_info_tipoEntrada";
            this.btn_info_tipoEntrada.Size = new System.Drawing.Size(20, 20);
            this.btn_info_tipoEntrada.TabIndex = 10;
            this.btn_info_tipoEntrada.UseVisualStyleBackColor = true;
            this.btn_info_tipoEntrada.Click += new System.EventHandler(this.btn_info_tipoEntrada_Click);
            // 
            // cmb_tipoEntrada
            // 
            this.cmb_tipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_tipoEntrada.FormattingEnabled = true;
            this.cmb_tipoEntrada.Items.AddRange(new object[] {
            "Query",
            "FromBody",
            "Url"});
            this.cmb_tipoEntrada.Location = new System.Drawing.Point(93, 51);
            this.cmb_tipoEntrada.Name = "cmb_tipoEntrada";
            this.cmb_tipoEntrada.Size = new System.Drawing.Size(446, 23);
            this.cmb_tipoEntrada.TabIndex = 22;
            // 
            // cmb_tipoCampo
            // 
            this.cmb_tipoCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoCampo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_tipoCampo.FormattingEnabled = true;
            this.cmb_tipoCampo.Items.AddRange(new object[] {
            "string",
            "int",
            "decimal",
            "char",
            "DateTime"});
            this.cmb_tipoCampo.Location = new System.Drawing.Point(93, 80);
            this.cmb_tipoCampo.Name = "cmb_tipoCampo";
            this.cmb_tipoCampo.Size = new System.Drawing.Size(446, 23);
            this.cmb_tipoCampo.TabIndex = 25;
            // 
            // lbl_tipoCampo
            // 
            this.lbl_tipoCampo.AutoSize = true;
            this.lbl_tipoCampo.Location = new System.Drawing.Point(6, 83);
            this.lbl_tipoCampo.Name = "lbl_tipoCampo";
            this.lbl_tipoCampo.Size = new System.Drawing.Size(78, 16);
            this.lbl_tipoCampo.TabIndex = 24;
            this.lbl_tipoCampo.Text = "Tipo Campo";
            // 
            // btn_info_tipoCampo
            // 
            this.btn_info_tipoCampo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_tipoCampo.BackgroundImage")));
            this.btn_info_tipoCampo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_tipoCampo.Location = new System.Drawing.Point(545, 82);
            this.btn_info_tipoCampo.Name = "btn_info_tipoCampo";
            this.btn_info_tipoCampo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_tipoCampo.TabIndex = 23;
            this.btn_info_tipoCampo.UseVisualStyleBackColor = true;
            this.btn_info_tipoCampo.Click += new System.EventHandler(this.btn_info_tipoCampo_Click);
            // 
            // UC_CadastroCampoClasseOuEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_tot);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroCampoClasseOuEntrada";
            this.Size = new System.Drawing.Size(740, 562);
            this.pan_botton.ResumeLayout(false);
            this.pan_top.ResumeLayout(false);
            this.pan_tot.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.GroupBox grb_cadastro;
        private System.Windows.Forms.Label lbl_tipoEntrada;
        private System.Windows.Forms.Button btn_info_tipoEntrada;
        private System.Windows.Forms.TextBox tbx_nomeCampo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_info_campo;
        private System.Windows.Forms.ComboBox cmb_tipoEntrada;
        private System.Windows.Forms.ComboBox cmb_tipoCampo;
        private System.Windows.Forms.Label lbl_tipoCampo;
        private System.Windows.Forms.Button btn_info_tipoCampo;
    }
}
