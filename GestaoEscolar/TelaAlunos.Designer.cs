
namespace GestaoEscolar
{
    partial class TelaAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlunos));
            this.pnlAlunos = new Guna.UI2.WinForms.Guna2Panel();
            this.tabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCadAluno = new System.Windows.Forms.Label();
            this.btnVoltarMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluirAluno = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovoAluno = new Guna.UI2.WinForms.Guna2Button();
            this.txtTelefoneAluno = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCadastrarAluno = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmailAluno = new System.Windows.Forms.Label();
            this.lblTelefoneAluno = new System.Windows.Forms.Label();
            this.lblEnderecoAluno = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.txtEmailAluno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEnderecoAluno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomeAluno = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConsultarAluno = new Guna.UI2.WinForms.Guna2Button();
            this.lblPesqAluno = new System.Windows.Forms.Label();
            this.txtPesquisarAluno = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvAlunos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.editar_aluno = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir_aluno = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlAlunos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlunos
            // 
            this.pnlAlunos.BackColor = System.Drawing.Color.White;
            this.pnlAlunos.Controls.Add(this.tabControl1);
            this.pnlAlunos.Location = new System.Drawing.Point(64, 54);
            this.pnlAlunos.Name = "pnlAlunos";
            this.pnlAlunos.ShadowDecoration.Depth = 40;
            this.pnlAlunos.ShadowDecoration.Enabled = true;
            this.pnlAlunos.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnlAlunos.Size = new System.Drawing.Size(874, 479);
            this.pnlAlunos.TabIndex = 0;
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
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCadAluno);
            this.tabPage1.Controls.Add(this.btnVoltarMenu);
            this.tabPage1.Controls.Add(this.btnExcluirAluno);
            this.tabPage1.Controls.Add(this.btnNovoAluno);
            this.tabPage1.Controls.Add(this.txtTelefoneAluno);
            this.tabPage1.Controls.Add(this.btnCadastrarAluno);
            this.tabPage1.Controls.Add(this.lblEmailAluno);
            this.tabPage1.Controls.Add(this.lblTelefoneAluno);
            this.tabPage1.Controls.Add(this.lblEnderecoAluno);
            this.tabPage1.Controls.Add(this.lblNomeAluno);
            this.tabPage1.Controls.Add(this.txtEmailAluno);
            this.tabPage1.Controls.Add(this.txtEnderecoAluno);
            this.tabPage1.Controls.Add(this.txtNomeAluno);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASTRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCadAluno
            // 
            this.lblCadAluno.AutoSize = true;
            this.lblCadAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadAluno.Location = new System.Drawing.Point(241, 25);
            this.lblCadAluno.Name = "lblCadAluno";
            this.lblCadAluno.Size = new System.Drawing.Size(374, 43);
            this.lblCadAluno.TabIndex = 26;
            this.lblCadAluno.Text = "CADASTRO ALUNO";
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
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Animated = true;
            this.btnExcluirAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirAluno.BorderRadius = 20;
            this.btnExcluirAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirAluno.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluirAluno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluirAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcluirAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcluirAluno.FillColor = System.Drawing.Color.DarkRed;
            this.btnExcluirAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnExcluirAluno.ForeColor = System.Drawing.Color.White;
            this.btnExcluirAluno.Location = new System.Drawing.Point(588, 362);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.PressedColor = System.Drawing.Color.Empty;
            this.btnExcluirAluno.PressedDepth = 40;
            this.btnExcluirAluno.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnExcluirAluno.Size = new System.Drawing.Size(174, 45);
            this.btnExcluirAluno.TabIndex = 24;
            this.btnExcluirAluno.Text = "EXCLUIR";
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.Animated = true;
            this.btnNovoAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoAluno.BorderRadius = 20;
            this.btnNovoAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoAluno.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoAluno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNovoAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNovoAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNovoAluno.FillColor = System.Drawing.Color.Gray;
            this.btnNovoAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnNovoAluno.ForeColor = System.Drawing.Color.White;
            this.btnNovoAluno.Location = new System.Drawing.Point(194, 362);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.PressedColor = System.Drawing.Color.Empty;
            this.btnNovoAluno.PressedDepth = 40;
            this.btnNovoAluno.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnNovoAluno.Size = new System.Drawing.Size(93, 45);
            this.btnNovoAluno.TabIndex = 18;
            this.btnNovoAluno.Text = "NOVO";
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // txtTelefoneAluno
            // 
            this.txtTelefoneAluno.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtTelefoneAluno.BorderColor = System.Drawing.Color.LightGray;
            this.txtTelefoneAluno.BorderRadius = 20;
            this.txtTelefoneAluno.BorderThickness = 2;
            this.txtTelefoneAluno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefoneAluno.DefaultText = "";
            this.txtTelefoneAluno.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelefoneAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefoneAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefoneAluno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefoneAluno.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTelefoneAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtTelefoneAluno.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefoneAluno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefoneAluno.Location = new System.Drawing.Point(194, 217);
            this.txtTelefoneAluno.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefoneAluno.MaxLength = 11;
            this.txtTelefoneAluno.Name = "txtTelefoneAluno";
            this.txtTelefoneAluno.PasswordChar = '\0';
            this.txtTelefoneAluno.PlaceholderText = "(99) 00000-0000";
            this.txtTelefoneAluno.SelectedText = "";
            this.txtTelefoneAluno.Size = new System.Drawing.Size(568, 49);
            this.txtTelefoneAluno.TabIndex = 16;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Animated = true;
            this.btnCadastrarAluno.BorderRadius = 20;
            this.btnCadastrarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarAluno.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarAluno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrarAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrarAluno.FillColor = System.Drawing.Color.MediumBlue;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.btnCadastrarAluno.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(316, 362);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.PressedColor = System.Drawing.Color.Empty;
            this.btnCadastrarAluno.PressedDepth = 40;
            this.btnCadastrarAluno.Size = new System.Drawing.Size(242, 45);
            this.btnCadastrarAluno.TabIndex = 20;
            this.btnCadastrarAluno.Text = "CADASTRAR";
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // lblEmailAluno
            // 
            this.lblEmailAluno.AutoSize = true;
            this.lblEmailAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAluno.Location = new System.Drawing.Point(110, 288);
            this.lblEmailAluno.Name = "lblEmailAluno";
            this.lblEmailAluno.Size = new System.Drawing.Size(76, 22);
            this.lblEmailAluno.TabIndex = 23;
            this.lblEmailAluno.Text = "E-MAIL";
            // 
            // lblTelefoneAluno
            // 
            this.lblTelefoneAluno.AutoSize = true;
            this.lblTelefoneAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneAluno.Location = new System.Drawing.Point(74, 232);
            this.lblTelefoneAluno.Name = "lblTelefoneAluno";
            this.lblTelefoneAluno.Size = new System.Drawing.Size(112, 22);
            this.lblTelefoneAluno.TabIndex = 22;
            this.lblTelefoneAluno.Text = "TELEFONE";
            // 
            // lblEnderecoAluno
            // 
            this.lblEnderecoAluno.AutoSize = true;
            this.lblEnderecoAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoAluno.Location = new System.Drawing.Point(65, 174);
            this.lblEnderecoAluno.Name = "lblEnderecoAluno";
            this.lblEnderecoAluno.Size = new System.Drawing.Size(120, 22);
            this.lblEnderecoAluno.TabIndex = 21;
            this.lblEnderecoAluno.Text = "ENDEREÇO";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(118, 112);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(68, 22);
            this.lblNomeAluno.TabIndex = 19;
            this.lblNomeAluno.Text = "NOME";
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.BorderColor = System.Drawing.Color.LightGray;
            this.txtEmailAluno.BorderRadius = 20;
            this.txtEmailAluno.BorderThickness = 2;
            this.txtEmailAluno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAluno.DefaultText = "";
            this.txtEmailAluno.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtEmailAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAluno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAluno.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtEmailAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAluno.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmailAluno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailAluno.Location = new System.Drawing.Point(193, 273);
            this.txtEmailAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailAluno.MaxLength = 70;
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.PasswordChar = '\0';
            this.txtEmailAluno.PlaceholderText = "contato@email.com";
            this.txtEmailAluno.SelectedText = "";
            this.txtEmailAluno.Size = new System.Drawing.Size(569, 49);
            this.txtEmailAluno.TabIndex = 17;
            // 
            // txtEnderecoAluno
            // 
            this.txtEnderecoAluno.BorderColor = System.Drawing.Color.LightGray;
            this.txtEnderecoAluno.BorderRadius = 20;
            this.txtEnderecoAluno.BorderThickness = 2;
            this.txtEnderecoAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnderecoAluno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnderecoAluno.DefaultText = "";
            this.txtEnderecoAluno.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtEnderecoAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnderecoAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnderecoAluno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnderecoAluno.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtEnderecoAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtEnderecoAluno.ForeColor = System.Drawing.Color.DimGray;
            this.txtEnderecoAluno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnderecoAluno.Location = new System.Drawing.Point(193, 158);
            this.txtEnderecoAluno.Margin = new System.Windows.Forms.Padding(5);
            this.txtEnderecoAluno.MaxLength = 150;
            this.txtEnderecoAluno.Name = "txtEnderecoAluno";
            this.txtEnderecoAluno.PasswordChar = '\0';
            this.txtEnderecoAluno.PlaceholderText = "Rua, Número, Bairro, Cidade, Estado, Complemento";
            this.txtEnderecoAluno.SelectedText = "";
            this.txtEnderecoAluno.Size = new System.Drawing.Size(569, 49);
            this.txtEnderecoAluno.TabIndex = 15;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BorderColor = System.Drawing.Color.LightGray;
            this.txtNomeAluno.BorderRadius = 20;
            this.txtNomeAluno.BorderThickness = 2;
            this.txtNomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeAluno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeAluno.DefaultText = "";
            this.txtNomeAluno.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtNomeAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeAluno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeAluno.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtNomeAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtNomeAluno.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomeAluno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeAluno.Location = new System.Drawing.Point(193, 100);
            this.txtNomeAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeAluno.MaxLength = 100;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.PasswordChar = '\0';
            this.txtNomeAluno.PlaceholderText = "Nome Completo";
            this.txtNomeAluno.SelectedText = "";
            this.txtNomeAluno.Size = new System.Drawing.Size(569, 49);
            this.txtNomeAluno.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConsultarAluno);
            this.tabPage2.Controls.Add(this.lblPesqAluno);
            this.tabPage2.Controls.Add(this.txtPesquisarAluno);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSULTA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConsultarAluno
            // 
            this.btnConsultarAluno.Animated = true;
            this.btnConsultarAluno.AutoRoundedCorners = true;
            this.btnConsultarAluno.BorderRadius = 21;
            this.btnConsultarAluno.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarAluno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultarAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultarAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAluno.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAluno.Location = new System.Drawing.Point(339, 253);
            this.btnConsultarAluno.Name = "btnConsultarAluno";
            this.btnConsultarAluno.Size = new System.Drawing.Size(180, 45);
            this.btnConsultarAluno.TabIndex = 18;
            this.btnConsultarAluno.Text = "PESQUISAR";
            this.btnConsultarAluno.Click += new System.EventHandler(this.btnConsultarAluno_Click);
            // 
            // lblPesqAluno
            // 
            this.lblPesqAluno.AutoSize = true;
            this.lblPesqAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqAluno.Location = new System.Drawing.Point(235, 25);
            this.lblPesqAluno.Name = "lblPesqAluno";
            this.lblPesqAluno.Size = new System.Drawing.Size(385, 43);
            this.lblPesqAluno.TabIndex = 17;
            this.lblPesqAluno.Text = "PESQUISAR ALUNO";
            // 
            // txtPesquisarAluno
            // 
            this.txtPesquisarAluno.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPesquisarAluno.BorderRadius = 20;
            this.txtPesquisarAluno.BorderThickness = 3;
            this.txtPesquisarAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisarAluno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisarAluno.DefaultText = "";
            this.txtPesquisarAluno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisarAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisarAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisarAluno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisarAluno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisarAluno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtPesquisarAluno.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txtPesquisarAluno.HoverState.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisarAluno.Location = new System.Drawing.Point(256, 188);
            this.txtPesquisarAluno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPesquisarAluno.MaxLength = 150;
            this.txtPesquisarAluno.Name = "txtPesquisarAluno";
            this.txtPesquisarAluno.PasswordChar = '\0';
            this.txtPesquisarAluno.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPesquisarAluno.PlaceholderText = "Pesquise o RM do aluno aqui";
            this.txtPesquisarAluno.SelectedText = "";
            this.txtPesquisarAluno.Size = new System.Drawing.Size(344, 45);
            this.txtPesquisarAluno.TabIndex = 16;
            this.txtPesquisarAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvAlunos);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(866, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TODOS ALUNOS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAlunos.ColumnHeadersHeight = 50;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar_aluno,
            this.excluir_aluno});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlunos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlunos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAlunos.Location = new System.Drawing.Point(0, 0);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAlunos.RowHeadersVisible = false;
            this.dgvAlunos.RowTemplate.Height = 35;
            this.dgvAlunos.Size = new System.Drawing.Size(866, 431);
            this.dgvAlunos.TabIndex = 0;
            this.dgvAlunos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAlunos.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAlunos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAlunos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAlunos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAlunos.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAlunos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAlunos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.dgvAlunos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlunos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAlunos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAlunos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAlunos.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvAlunos.ThemeStyle.ReadOnly = true;
            this.dgvAlunos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAlunos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlunos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAlunos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAlunos.ThemeStyle.RowsStyle.Height = 35;
            this.dgvAlunos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAlunos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            this.dgvAlunos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAlunos_CellFormatting);
            this.dgvAlunos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAlunos_DataBindingComplete);
            // 
            // editar_aluno
            // 
            this.editar_aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar_aluno.FillWeight = 101.6949F;
            this.editar_aluno.HeaderText = "";
            this.editar_aluno.Image = ((System.Drawing.Image)(resources.GetObject("editar_aluno.Image")));
            this.editar_aluno.MinimumWidth = 50;
            this.editar_aluno.Name = "editar_aluno";
            this.editar_aluno.ReadOnly = true;
            this.editar_aluno.Width = 50;
            // 
            // excluir_aluno
            // 
            this.excluir_aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.excluir_aluno.FillWeight = 99.66102F;
            this.excluir_aluno.HeaderText = "";
            this.excluir_aluno.Image = ((System.Drawing.Image)(resources.GetObject("excluir_aluno.Image")));
            this.excluir_aluno.MinimumWidth = 50;
            this.excluir_aluno.Name = "excluir_aluno";
            this.excluir_aluno.ReadOnly = true;
            this.excluir_aluno.Width = 50;
            // 
            // TelaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.pnlAlunos);
            this.Name = "TelaAlunos";
            this.Text = "MENU ALUNOS";
            this.Shown += new System.EventHandler(this.TelaAlunos_Shown);
            this.pnlAlunos.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlAlunos;
        private Guna.UI2.WinForms.Guna2TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2Button btnNovoAluno;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefoneAluno;
        private Guna.UI2.WinForms.Guna2Button btnCadastrarAluno;
        private System.Windows.Forms.Label lblEmailAluno;
        private System.Windows.Forms.Label lblTelefoneAluno;
        private System.Windows.Forms.Label lblEnderecoAluno;
        private System.Windows.Forms.Label lblNomeAluno;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailAluno;
        private Guna.UI2.WinForms.Guna2TextBox txtEnderecoAluno;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeAluno;
        private Guna.UI2.WinForms.Guna2Button btnVoltarMenu;
        private Guna.UI2.WinForms.Guna2Button btnExcluirAluno;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisarAluno;
        private System.Windows.Forms.Label lblPesqAluno;
        private System.Windows.Forms.Label lblCadAluno;
        private Guna.UI2.WinForms.Guna2Button btnConsultarAluno;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidrmalunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomealunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoalunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonealunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailalunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn editar_aluno;
        private System.Windows.Forms.DataGridViewImageColumn excluir_aluno;
    }
}