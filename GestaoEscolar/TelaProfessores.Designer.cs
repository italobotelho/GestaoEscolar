
namespace GestaoEscolar
{
    partial class TelaProfessores
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProfessores));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCadProf = new System.Windows.Forms.Label();
            this.btnVoltarMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluirProf = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovoProf = new Guna.UI2.WinForms.Guna2Button();
            this.txtTelefoneProf = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCadastrarProf = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmailProf = new System.Windows.Forms.Label();
            this.lblTelefoneProf = new System.Windows.Forms.Label();
            this.lblEnderecoProf = new System.Windows.Forms.Label();
            this.lblNomeProf = new System.Windows.Forms.Label();
            this.txtEmailProf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEnderecoProf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomeProf = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConsultarProf = new Guna.UI2.WinForms.Guna2Button();
            this.lblPesqProf = new System.Windows.Forms.Label();
            this.txtPesquisarProf = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvProf = new Guna.UI2.WinForms.Guna2DataGridView();
            this.editar_prof = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir_prof = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.tabControl1);
            this.guna2Panel1.Location = new System.Drawing.Point(64, 54);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 40;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.guna2Panel1.Size = new System.Drawing.Size(874, 479);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 479);
            this.tabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCadProf);
            this.tabPage1.Controls.Add(this.btnVoltarMenu);
            this.tabPage1.Controls.Add(this.btnExcluirProf);
            this.tabPage1.Controls.Add(this.btnNovoProf);
            this.tabPage1.Controls.Add(this.txtTelefoneProf);
            this.tabPage1.Controls.Add(this.btnCadastrarProf);
            this.tabPage1.Controls.Add(this.lblEmailProf);
            this.tabPage1.Controls.Add(this.lblTelefoneProf);
            this.tabPage1.Controls.Add(this.lblEnderecoProf);
            this.tabPage1.Controls.Add(this.lblNomeProf);
            this.tabPage1.Controls.Add(this.txtEmailProf);
            this.tabPage1.Controls.Add(this.txtEnderecoProf);
            this.tabPage1.Controls.Add(this.txtNomeProf);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASTRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCadProf
            // 
            this.lblCadProf.AutoSize = true;
            this.lblCadProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProf.Location = new System.Drawing.Point(198, 26);
            this.lblCadProf.Name = "lblCadProf";
            this.lblCadProf.Size = new System.Drawing.Size(474, 43);
            this.lblCadProf.TabIndex = 26;
            this.lblCadProf.Text = "CADASTRO PROFESSOR";
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Animated = true;
            this.btnVoltarMenu.AutoRoundedCorners = true;
            this.btnVoltarMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltarMenu.BorderRadius = 21;
            this.btnVoltarMenu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnVoltarMenu.BorderThickness = 2;
            this.btnVoltarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltarMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltarMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltarMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltarMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnVoltarMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnVoltarMenu.ForeColor = System.Drawing.Color.Black;
            this.btnVoltarMenu.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnVoltarMenu.Location = new System.Drawing.Point(50, 362);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.PressedColor = System.Drawing.Color.Empty;
            this.btnVoltarMenu.PressedDepth = 40;
            this.btnVoltarMenu.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnVoltarMenu.Size = new System.Drawing.Size(73, 45);
            this.btnVoltarMenu.TabIndex = 25;
            this.btnVoltarMenu.Text = "MENU";
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnExcluirProf
            // 
            this.btnExcluirProf.Animated = true;
            this.btnExcluirProf.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirProf.BorderRadius = 20;
            this.btnExcluirProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluirProf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluirProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcluirProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcluirProf.FillColor = System.Drawing.Color.DarkRed;
            this.btnExcluirProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnExcluirProf.ForeColor = System.Drawing.Color.White;
            this.btnExcluirProf.Location = new System.Drawing.Point(588, 362);
            this.btnExcluirProf.Name = "btnExcluirProf";
            this.btnExcluirProf.PressedColor = System.Drawing.Color.Empty;
            this.btnExcluirProf.PressedDepth = 40;
            this.btnExcluirProf.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnExcluirProf.Size = new System.Drawing.Size(174, 45);
            this.btnExcluirProf.TabIndex = 24;
            this.btnExcluirProf.Text = "EXCLUIR";
            this.btnExcluirProf.Click += new System.EventHandler(this.btnExcluirProf_Click);
            // 
            // btnNovoProf
            // 
            this.btnNovoProf.Animated = true;
            this.btnNovoProf.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoProf.BorderRadius = 20;
            this.btnNovoProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoProf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoProf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNovoProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNovoProf.FillColor = System.Drawing.Color.Black;
            this.btnNovoProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnNovoProf.ForeColor = System.Drawing.Color.White;
            this.btnNovoProf.Location = new System.Drawing.Point(194, 362);
            this.btnNovoProf.Name = "btnNovoProf";
            this.btnNovoProf.PressedColor = System.Drawing.Color.Empty;
            this.btnNovoProf.PressedDepth = 40;
            this.btnNovoProf.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnNovoProf.Size = new System.Drawing.Size(93, 45);
            this.btnNovoProf.TabIndex = 18;
            this.btnNovoProf.Text = "NOVO";
            this.btnNovoProf.Click += new System.EventHandler(this.btnNovoProf_Click);
            // 
            // txtTelefoneProf
            // 
            this.txtTelefoneProf.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtTelefoneProf.BorderColor = System.Drawing.Color.LightGray;
            this.txtTelefoneProf.BorderRadius = 20;
            this.txtTelefoneProf.BorderThickness = 2;
            this.txtTelefoneProf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefoneProf.DefaultText = "";
            this.txtTelefoneProf.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelefoneProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefoneProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefoneProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefoneProf.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTelefoneProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtTelefoneProf.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefoneProf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefoneProf.Location = new System.Drawing.Point(194, 217);
            this.txtTelefoneProf.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefoneProf.MaxLength = 11;
            this.txtTelefoneProf.Name = "txtTelefoneProf";
            this.txtTelefoneProf.PasswordChar = '\0';
            this.txtTelefoneProf.PlaceholderText = "(99) 00000-0000";
            this.txtTelefoneProf.SelectedText = "";
            this.txtTelefoneProf.Size = new System.Drawing.Size(568, 49);
            this.txtTelefoneProf.TabIndex = 16;
            // 
            // btnCadastrarProf
            // 
            this.btnCadastrarProf.Animated = true;
            this.btnCadastrarProf.BorderRadius = 20;
            this.btnCadastrarProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarProf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarProf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrarProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrarProf.FillColor = System.Drawing.Color.MediumBlue;
            this.btnCadastrarProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnCadastrarProf.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProf.Location = new System.Drawing.Point(316, 362);
            this.btnCadastrarProf.Name = "btnCadastrarProf";
            this.btnCadastrarProf.PressedColor = System.Drawing.Color.Empty;
            this.btnCadastrarProf.PressedDepth = 40;
            this.btnCadastrarProf.Size = new System.Drawing.Size(242, 45);
            this.btnCadastrarProf.TabIndex = 20;
            this.btnCadastrarProf.Text = "CADASTRAR";
            this.btnCadastrarProf.Click += new System.EventHandler(this.btnCadastrarProf_Click);
            // 
            // lblEmailProf
            // 
            this.lblEmailProf.AutoSize = true;
            this.lblEmailProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailProf.Location = new System.Drawing.Point(110, 288);
            this.lblEmailProf.Name = "lblEmailProf";
            this.lblEmailProf.Size = new System.Drawing.Size(76, 22);
            this.lblEmailProf.TabIndex = 23;
            this.lblEmailProf.Text = "E-MAIL";
            // 
            // lblTelefoneProf
            // 
            this.lblTelefoneProf.AutoSize = true;
            this.lblTelefoneProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneProf.Location = new System.Drawing.Point(74, 232);
            this.lblTelefoneProf.Name = "lblTelefoneProf";
            this.lblTelefoneProf.Size = new System.Drawing.Size(112, 22);
            this.lblTelefoneProf.TabIndex = 22;
            this.lblTelefoneProf.Text = "TELEFONE";
            // 
            // lblEnderecoProf
            // 
            this.lblEnderecoProf.AutoSize = true;
            this.lblEnderecoProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoProf.Location = new System.Drawing.Point(65, 174);
            this.lblEnderecoProf.Name = "lblEnderecoProf";
            this.lblEnderecoProf.Size = new System.Drawing.Size(120, 22);
            this.lblEnderecoProf.TabIndex = 21;
            this.lblEnderecoProf.Text = "ENDEREÇO";
            // 
            // lblNomeProf
            // 
            this.lblNomeProf.AutoSize = true;
            this.lblNomeProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProf.Location = new System.Drawing.Point(118, 112);
            this.lblNomeProf.Name = "lblNomeProf";
            this.lblNomeProf.Size = new System.Drawing.Size(68, 22);
            this.lblNomeProf.TabIndex = 19;
            this.lblNomeProf.Text = "NOME";
            // 
            // txtEmailProf
            // 
            this.txtEmailProf.BorderColor = System.Drawing.Color.LightGray;
            this.txtEmailProf.BorderRadius = 20;
            this.txtEmailProf.BorderThickness = 2;
            this.txtEmailProf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailProf.DefaultText = "";
            this.txtEmailProf.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtEmailProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailProf.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtEmailProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailProf.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmailProf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailProf.Location = new System.Drawing.Point(193, 273);
            this.txtEmailProf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailProf.MaxLength = 70;
            this.txtEmailProf.Name = "txtEmailProf";
            this.txtEmailProf.PasswordChar = '\0';
            this.txtEmailProf.PlaceholderText = "contato@email.com";
            this.txtEmailProf.SelectedText = "";
            this.txtEmailProf.Size = new System.Drawing.Size(569, 49);
            this.txtEmailProf.TabIndex = 17;
            // 
            // txtEnderecoProf
            // 
            this.txtEnderecoProf.BorderColor = System.Drawing.Color.LightGray;
            this.txtEnderecoProf.BorderRadius = 20;
            this.txtEnderecoProf.BorderThickness = 2;
            this.txtEnderecoProf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnderecoProf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnderecoProf.DefaultText = "";
            this.txtEnderecoProf.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtEnderecoProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnderecoProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnderecoProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnderecoProf.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtEnderecoProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtEnderecoProf.ForeColor = System.Drawing.Color.DimGray;
            this.txtEnderecoProf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnderecoProf.Location = new System.Drawing.Point(193, 158);
            this.txtEnderecoProf.Margin = new System.Windows.Forms.Padding(5);
            this.txtEnderecoProf.MaxLength = 150;
            this.txtEnderecoProf.Name = "txtEnderecoProf";
            this.txtEnderecoProf.PasswordChar = '\0';
            this.txtEnderecoProf.PlaceholderText = "Rua, Número, Bairro, Cidade, Estado, Complemento";
            this.txtEnderecoProf.SelectedText = "";
            this.txtEnderecoProf.Size = new System.Drawing.Size(569, 49);
            this.txtEnderecoProf.TabIndex = 15;
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.BorderColor = System.Drawing.Color.LightGray;
            this.txtNomeProf.BorderRadius = 20;
            this.txtNomeProf.BorderThickness = 2;
            this.txtNomeProf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeProf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeProf.DefaultText = "";
            this.txtNomeProf.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtNomeProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeProf.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtNomeProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtNomeProf.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomeProf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeProf.Location = new System.Drawing.Point(193, 100);
            this.txtNomeProf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeProf.MaxLength = 100;
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.PasswordChar = '\0';
            this.txtNomeProf.PlaceholderText = "Nome Completo";
            this.txtNomeProf.SelectedText = "";
            this.txtNomeProf.Size = new System.Drawing.Size(569, 49);
            this.txtNomeProf.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConsultarProf);
            this.tabPage2.Controls.Add(this.lblPesqProf);
            this.tabPage2.Controls.Add(this.txtPesquisarProf);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSULTA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConsultarProf
            // 
            this.btnConsultarProf.Animated = true;
            this.btnConsultarProf.AutoRoundedCorners = true;
            this.btnConsultarProf.BorderRadius = 21;
            this.btnConsultarProf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarProf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultarProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultarProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProf.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProf.Location = new System.Drawing.Point(339, 253);
            this.btnConsultarProf.Name = "btnConsultarProf";
            this.btnConsultarProf.Size = new System.Drawing.Size(180, 45);
            this.btnConsultarProf.TabIndex = 18;
            this.btnConsultarProf.Text = "PESQUISAR";
            this.btnConsultarProf.Click += new System.EventHandler(this.btnConsultarProf_Click);
            // 
            // lblPesqProf
            // 
            this.lblPesqProf.AutoSize = true;
            this.lblPesqProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqProf.Location = new System.Drawing.Point(188, 27);
            this.lblPesqProf.Name = "lblPesqProf";
            this.lblPesqProf.Size = new System.Drawing.Size(485, 43);
            this.lblPesqProf.TabIndex = 17;
            this.lblPesqProf.Text = "PESQUISAR PROFESSOR";
            // 
            // txtPesquisarProf
            // 
            this.txtPesquisarProf.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPesquisarProf.BorderRadius = 20;
            this.txtPesquisarProf.BorderThickness = 3;
            this.txtPesquisarProf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisarProf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisarProf.DefaultText = "";
            this.txtPesquisarProf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisarProf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisarProf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisarProf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisarProf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisarProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtPesquisarProf.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtPesquisarProf.HoverState.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisarProf.Location = new System.Drawing.Point(244, 190);
            this.txtPesquisarProf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPesquisarProf.MaxLength = 150;
            this.txtPesquisarProf.Name = "txtPesquisarProf";
            this.txtPesquisarProf.PasswordChar = '\0';
            this.txtPesquisarProf.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPesquisarProf.PlaceholderText = "Pesquise a MATRÍCULA do professor aqui";
            this.txtPesquisarProf.SelectedText = "";
            this.txtPesquisarProf.Size = new System.Drawing.Size(376, 45);
            this.txtPesquisarProf.TabIndex = 16;
            this.txtPesquisarProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvProf);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(866, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TODOS PROFESSORES";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvProf
            // 
            this.dgvProf.AllowUserToAddRows = false;
            this.dgvProf.AllowUserToDeleteRows = false;
            this.dgvProf.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProf.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProf.ColumnHeadersHeight = 50;
            this.dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar_prof,
            this.excluir_prof});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProf.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProf.Location = new System.Drawing.Point(0, 0);
            this.dgvProf.Name = "dgvProf";
            this.dgvProf.ReadOnly = true;
            this.dgvProf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProf.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProf.RowHeadersVisible = false;
            this.dgvProf.RowTemplate.Height = 35;
            this.dgvProf.Size = new System.Drawing.Size(866, 431);
            this.dgvProf.TabIndex = 0;
            this.dgvProf.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProf.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProf.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvProf.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProf.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProf.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvProf.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProf.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.dgvProf.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProf.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProf.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProf.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProf.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvProf.ThemeStyle.ReadOnly = true;
            this.dgvProf.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProf.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProf.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProf.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvProf.ThemeStyle.RowsStyle.Height = 35;
            this.dgvProf.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProf.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProf_CellContentClick);
            this.dgvProf.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProf_CellFormatting);
            this.dgvProf.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProf_DataBindingComplete);
            // 
            // editar_prof
            // 
            this.editar_prof.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar_prof.FillWeight = 101.6949F;
            this.editar_prof.HeaderText = "";
            this.editar_prof.Image = ((System.Drawing.Image)(resources.GetObject("editar_prof.Image")));
            this.editar_prof.MinimumWidth = 50;
            this.editar_prof.Name = "editar_prof";
            this.editar_prof.ReadOnly = true;
            this.editar_prof.Width = 50;
            // 
            // excluir_prof
            // 
            this.excluir_prof.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.excluir_prof.FillWeight = 99.66102F;
            this.excluir_prof.HeaderText = "";
            this.excluir_prof.Image = ((System.Drawing.Image)(resources.GetObject("excluir_prof.Image")));
            this.excluir_prof.MinimumWidth = 50;
            this.excluir_prof.Name = "excluir_prof";
            this.excluir_prof.ReadOnly = true;
            this.excluir_prof.Width = 50;
            // 
            // TelaProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TelaProfessores";
            this.Text = "MENU PROFESSORES";
            this.Shown += new System.EventHandler(this.TelaProfessores_Shown);
            this.guna2Panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCadProf;
        private Guna.UI2.WinForms.Guna2Button btnVoltarMenu;
        private Guna.UI2.WinForms.Guna2Button btnExcluirProf;
        private Guna.UI2.WinForms.Guna2Button btnNovoProf;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefoneProf;
        private Guna.UI2.WinForms.Guna2Button btnCadastrarProf;
        private System.Windows.Forms.Label lblEmailProf;
        private System.Windows.Forms.Label lblTelefoneProf;
        private System.Windows.Forms.Label lblEnderecoProf;
        private System.Windows.Forms.Label lblNomeProf;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailProf;
        private Guna.UI2.WinForms.Guna2TextBox txtEnderecoProf;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeProf;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnConsultarProf;
        private System.Windows.Forms.Label lblPesqProf;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisarProf;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProf;
        private System.Windows.Forms.DataGridViewImageColumn editar_prof;
        private System.Windows.Forms.DataGridViewImageColumn excluir_prof;
    }
}