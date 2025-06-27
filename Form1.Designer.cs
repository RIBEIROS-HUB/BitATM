namespace sistemaCaixaEletronico
{
    partial class sistemaCaixaEletronico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoSaqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoDepósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblVlrSaldo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagIni = new System.Windows.Forms.TabPage();
            this.btnImprimeExtrato = new System.Windows.Forms.Button();
            this.lblSldCifrao = new System.Windows.Forms.Label();
            this.lblDispCxCifrao = new System.Windows.Forms.Label();
            this.grpBxExtrato = new System.Windows.Forms.GroupBox();
            this.rtbExtrato = new System.Windows.Forms.RichTextBox();
            this.lblContNtsDez = new System.Windows.Forms.Label();
            this.lblContNtsVinte = new System.Windows.Forms.Label();
            this.lblContNtsCinquenta = new System.Windows.Forms.Label();
            this.lblContNtsCem = new System.Windows.Forms.Label();
            this.lblVlrCaixa = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblDezReais = new System.Windows.Forms.Label();
            this.lblVinteReais = new System.Windows.Forms.Label();
            this.lblCinquentaReais = new System.Windows.Forms.Label();
            this.lblCemReais = new System.Windows.Forms.Label();
            this.lblNotasDisponiveis = new System.Windows.Forms.Label();
            this.tabPagSaque = new System.Windows.Forms.TabPage();
            this.btnConfSaque = new System.Windows.Forms.Button();
            this.txtVlrSacado = new System.Windows.Forms.TextBox();
            this.lblVlrSacado = new System.Windows.Forms.Label();
            this.lblSldSaque = new System.Windows.Forms.Label();
            this.lblSldCif = new System.Windows.Forms.Label();
            this.lblSld = new System.Windows.Forms.Label();
            this.btnCancSaque = new System.Windows.Forms.Button();
            this.tabPagDep = new System.Windows.Forms.TabPage();
            this.txtVlrDepositado = new System.Windows.Forms.TextBox();
            this.lbltextDep = new System.Windows.Forms.Label();
            this.lblSldDeposito = new System.Windows.Forms.Label();
            this.lblSldCifr = new System.Windows.Forms.Label();
            this.lblSldDep = new System.Windows.Forms.Label();
            this.btnConfDep = new System.Windows.Forms.Button();
            this.btnCancDep = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPagIni.SuspendLayout();
            this.grpBxExtrato.SuspendLayout();
            this.tabPagSaque.SuspendLayout();
            this.tabPagDep.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaudacao.Location = new System.Drawing.Point(16, 16);
            this.lblSaudacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(0, 20);
            this.lblSaudacao.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem,
            this.novoSaqueToolStripMenuItem,
            this.novoDepósitoToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.paginaInicialToolStripMenuItem.Text = "Página Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // novoSaqueToolStripMenuItem
            // 
            this.novoSaqueToolStripMenuItem.Name = "novoSaqueToolStripMenuItem";
            this.novoSaqueToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.novoSaqueToolStripMenuItem.Text = "Novo Saque";
            this.novoSaqueToolStripMenuItem.Click += new System.EventHandler(this.novoSaqueToolStripMenuItem_Click);
            // 
            // novoDepósitoToolStripMenuItem
            // 
            this.novoDepósitoToolStripMenuItem.Name = "novoDepósitoToolStripMenuItem";
            this.novoDepósitoToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.novoDepósitoToolStripMenuItem.Text = "Novo Depósito";
            this.novoDepósitoToolStripMenuItem.Click += new System.EventHandler(this.novoDepósitoToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaldo.Location = new System.Drawing.Point(16, 50);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(49, 20);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblVlrSaldo
            // 
            this.lblVlrSaldo.AutoSize = true;
            this.lblVlrSaldo.Location = new System.Drawing.Point(97, 50);
            this.lblVlrSaldo.Name = "lblVlrSaldo";
            this.lblVlrSaldo.Size = new System.Drawing.Size(59, 20);
            this.lblVlrSaldo.TabIndex = 3;
            this.lblVlrSaldo.Text = "5.000,00";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagIni);
            this.tabControl.Controls.Add(this.tabPagSaque);
            this.tabControl.Controls.Add(this.tabPagDep);
            this.tabControl.Location = new System.Drawing.Point(0, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(752, 398);
            this.tabControl.TabIndex = 4;
            // 
            // tabPagIni
            // 
            this.tabPagIni.Controls.Add(this.btnImprimeExtrato);
            this.tabPagIni.Controls.Add(this.lblSldCifrao);
            this.tabPagIni.Controls.Add(this.lblDispCxCifrao);
            this.tabPagIni.Controls.Add(this.grpBxExtrato);
            this.tabPagIni.Controls.Add(this.lblContNtsDez);
            this.tabPagIni.Controls.Add(this.lblContNtsVinte);
            this.tabPagIni.Controls.Add(this.lblContNtsCinquenta);
            this.tabPagIni.Controls.Add(this.lblContNtsCem);
            this.tabPagIni.Controls.Add(this.lblVlrCaixa);
            this.tabPagIni.Controls.Add(this.btnDepositar);
            this.tabPagIni.Controls.Add(this.btnSacar);
            this.tabPagIni.Controls.Add(this.lblDezReais);
            this.tabPagIni.Controls.Add(this.lblVinteReais);
            this.tabPagIni.Controls.Add(this.lblCinquentaReais);
            this.tabPagIni.Controls.Add(this.lblCemReais);
            this.tabPagIni.Controls.Add(this.lblNotasDisponiveis);
            this.tabPagIni.Controls.Add(this.lblVlrSaldo);
            this.tabPagIni.Controls.Add(this.lblSaudacao);
            this.tabPagIni.Controls.Add(this.lblSaldo);
            this.tabPagIni.Location = new System.Drawing.Point(4, 29);
            this.tabPagIni.Name = "tabPagIni";
            this.tabPagIni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagIni.Size = new System.Drawing.Size(744, 365);
            this.tabPagIni.TabIndex = 0;
            this.tabPagIni.Text = "Página Inicial";
            this.tabPagIni.UseVisualStyleBackColor = true;
            // 
            // btnImprimeExtrato
            // 
            this.btnImprimeExtrato.BackColor = System.Drawing.Color.Navy;
            this.btnImprimeExtrato.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnImprimeExtrato.ForeColor = System.Drawing.Color.White;
            this.btnImprimeExtrato.Location = new System.Drawing.Point(550, 319);
            this.btnImprimeExtrato.Name = "btnImprimeExtrato";
            this.btnImprimeExtrato.Size = new System.Drawing.Size(182, 38);
            this.btnImprimeExtrato.TabIndex = 20;
            this.btnImprimeExtrato.Text = "Imprimir Extrato";
            this.btnImprimeExtrato.UseVisualStyleBackColor = false;
            this.btnImprimeExtrato.Click += new System.EventHandler(this.btnImprimeExtrato_Click);
            // 
            // lblSldCifrao
            // 
            this.lblSldCifrao.AutoSize = true;
            this.lblSldCifrao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblSldCifrao.Location = new System.Drawing.Point(71, 50);
            this.lblSldCifrao.Name = "lblSldCifrao";
            this.lblSldCifrao.Size = new System.Drawing.Size(25, 20);
            this.lblSldCifrao.TabIndex = 19;
            this.lblSldCifrao.Text = "R$";
            // 
            // lblDispCxCifrao
            // 
            this.lblDispCxCifrao.AutoSize = true;
            this.lblDispCxCifrao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblDispCxCifrao.Location = new System.Drawing.Point(194, 84);
            this.lblDispCxCifrao.Name = "lblDispCxCifrao";
            this.lblDispCxCifrao.Size = new System.Drawing.Size(25, 20);
            this.lblDispCxCifrao.TabIndex = 18;
            this.lblDispCxCifrao.Text = "R$";
            // 
            // grpBxExtrato
            // 
            this.grpBxExtrato.BackColor = System.Drawing.Color.LightGray;
            this.grpBxExtrato.Controls.Add(this.rtbExtrato);
            this.grpBxExtrato.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.grpBxExtrato.ForeColor = System.Drawing.Color.Navy;
            this.grpBxExtrato.Location = new System.Drawing.Point(359, 16);
            this.grpBxExtrato.Name = "grpBxExtrato";
            this.grpBxExtrato.Size = new System.Drawing.Size(379, 297);
            this.grpBxExtrato.TabIndex = 17;
            this.grpBxExtrato.TabStop = false;
            this.grpBxExtrato.Text = "Extrato";
            this.grpBxExtrato.Enter += new System.EventHandler(this.grpBxExtrato_Enter);
            // 
            // rtbExtrato
            // 
            this.rtbExtrato.BackColor = System.Drawing.Color.LightGray;
            this.rtbExtrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbExtrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbExtrato.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.rtbExtrato.Location = new System.Drawing.Point(3, 28);
            this.rtbExtrato.Name = "rtbExtrato";
            this.rtbExtrato.ReadOnly = true;
            this.rtbExtrato.Size = new System.Drawing.Size(373, 266);
            this.rtbExtrato.TabIndex = 0;
            this.rtbExtrato.Text = "";
            // 
            // lblContNtsDez
            // 
            this.lblContNtsDez.AutoSize = true;
            this.lblContNtsDez.Location = new System.Drawing.Point(195, 223);
            this.lblContNtsDez.Name = "lblContNtsDez";
            this.lblContNtsDez.Size = new System.Drawing.Size(23, 20);
            this.lblContNtsDez.TabIndex = 16;
            this.lblContNtsDez.Text = "36";
            // 
            // lblContNtsVinte
            // 
            this.lblContNtsVinte.AutoSize = true;
            this.lblContNtsVinte.Location = new System.Drawing.Point(195, 189);
            this.lblContNtsVinte.Name = "lblContNtsVinte";
            this.lblContNtsVinte.Size = new System.Drawing.Size(23, 20);
            this.lblContNtsVinte.TabIndex = 15;
            this.lblContNtsVinte.Text = "62";
            // 
            // lblContNtsCinquenta
            // 
            this.lblContNtsCinquenta.AutoSize = true;
            this.lblContNtsCinquenta.Location = new System.Drawing.Point(195, 153);
            this.lblContNtsCinquenta.Name = "lblContNtsCinquenta";
            this.lblContNtsCinquenta.Size = new System.Drawing.Size(23, 20);
            this.lblContNtsCinquenta.TabIndex = 14;
            this.lblContNtsCinquenta.Text = "26";
            // 
            // lblContNtsCem
            // 
            this.lblContNtsCem.AutoSize = true;
            this.lblContNtsCem.Location = new System.Drawing.Point(195, 118);
            this.lblContNtsCem.Name = "lblContNtsCem";
            this.lblContNtsCem.Size = new System.Drawing.Size(23, 20);
            this.lblContNtsCem.TabIndex = 13;
            this.lblContNtsCem.Text = "21";
            // 
            // lblVlrCaixa
            // 
            this.lblVlrCaixa.AutoSize = true;
            this.lblVlrCaixa.Location = new System.Drawing.Point(217, 84);
            this.lblVlrCaixa.Name = "lblVlrCaixa";
            this.lblVlrCaixa.Size = new System.Drawing.Size(59, 20);
            this.lblVlrCaixa.TabIndex = 12;
            this.lblVlrCaixa.Text = "5.000,00";
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDepositar.FlatAppearance.BorderSize = 0;
            this.btnDepositar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnDepositar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDepositar.Location = new System.Drawing.Point(175, 259);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(138, 37);
            this.btnDepositar.TabIndex = 10;
            this.btnDepositar.Text = "Depósitar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSacar.FlatAppearance.BorderSize = 0;
            this.btnSacar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnSacar.ForeColor = System.Drawing.Color.White;
            this.btnSacar.Location = new System.Drawing.Point(20, 259);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(138, 37);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblDezReais
            // 
            this.lblDezReais.AutoSize = true;
            this.lblDezReais.Location = new System.Drawing.Point(16, 224);
            this.lblDezReais.Name = "lblDezReais";
            this.lblDezReais.Size = new System.Drawing.Size(57, 20);
            this.lblDezReais.TabIndex = 8;
            this.lblDezReais.Text = "R$10,00";
            // 
            // lblVinteReais
            // 
            this.lblVinteReais.AutoSize = true;
            this.lblVinteReais.Location = new System.Drawing.Point(16, 190);
            this.lblVinteReais.Name = "lblVinteReais";
            this.lblVinteReais.Size = new System.Drawing.Size(57, 20);
            this.lblVinteReais.TabIndex = 7;
            this.lblVinteReais.Text = "R$20,00";
            // 
            // lblCinquentaReais
            // 
            this.lblCinquentaReais.AutoSize = true;
            this.lblCinquentaReais.Location = new System.Drawing.Point(16, 154);
            this.lblCinquentaReais.Name = "lblCinquentaReais";
            this.lblCinquentaReais.Size = new System.Drawing.Size(57, 20);
            this.lblCinquentaReais.TabIndex = 6;
            this.lblCinquentaReais.Text = "R$50,00";
            // 
            // lblCemReais
            // 
            this.lblCemReais.AutoSize = true;
            this.lblCemReais.Location = new System.Drawing.Point(16, 119);
            this.lblCemReais.Name = "lblCemReais";
            this.lblCemReais.Size = new System.Drawing.Size(64, 20);
            this.lblCemReais.TabIndex = 5;
            this.lblCemReais.Text = "R$100,00";
            // 
            // lblNotasDisponiveis
            // 
            this.lblNotasDisponiveis.AutoSize = true;
            this.lblNotasDisponiveis.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotasDisponiveis.Location = new System.Drawing.Point(16, 84);
            this.lblNotasDisponiveis.Name = "lblNotasDisponiveis";
            this.lblNotasDisponiveis.Size = new System.Drawing.Size(173, 20);
            this.lblNotasDisponiveis.TabIndex = 4;
            this.lblNotasDisponiveis.Text = "Valor Disponível no Caixa:";
            // 
            // tabPagSaque
            // 
            this.tabPagSaque.Controls.Add(this.btnConfSaque);
            this.tabPagSaque.Controls.Add(this.txtVlrSacado);
            this.tabPagSaque.Controls.Add(this.lblVlrSacado);
            this.tabPagSaque.Controls.Add(this.lblSldSaque);
            this.tabPagSaque.Controls.Add(this.lblSldCif);
            this.tabPagSaque.Controls.Add(this.lblSld);
            this.tabPagSaque.Controls.Add(this.btnCancSaque);
            this.tabPagSaque.Location = new System.Drawing.Point(4, 29);
            this.tabPagSaque.Name = "tabPagSaque";
            this.tabPagSaque.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagSaque.Size = new System.Drawing.Size(744, 365);
            this.tabPagSaque.TabIndex = 1;
            this.tabPagSaque.Text = "Saque";
            this.tabPagSaque.UseVisualStyleBackColor = true;
            // 
            // btnConfSaque
            // 
            this.btnConfSaque.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConfSaque.FlatAppearance.BorderSize = 0;
            this.btnConfSaque.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfSaque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfSaque.Location = new System.Drawing.Point(140, 317);
            this.btnConfSaque.Name = "btnConfSaque";
            this.btnConfSaque.Size = new System.Drawing.Size(293, 42);
            this.btnConfSaque.TabIndex = 23;
            this.btnConfSaque.Text = "Confirmar Saque";
            this.btnConfSaque.UseVisualStyleBackColor = false;
            this.btnConfSaque.Click += new System.EventHandler(this.btnConfSaque_Click);
            // 
            // txtVlrSacado
            // 
            this.txtVlrSacado.Location = new System.Drawing.Point(16, 88);
            this.txtVlrSacado.Name = "txtVlrSacado";
            this.txtVlrSacado.Size = new System.Drawing.Size(170, 26);
            this.txtVlrSacado.TabIndex = 0;
            // 
            // lblVlrSacado
            // 
            this.lblVlrSacado.AutoSize = true;
            this.lblVlrSacado.Location = new System.Drawing.Point(12, 55);
            this.lblVlrSacado.Name = "lblVlrSacado";
            this.lblVlrSacado.Size = new System.Drawing.Size(174, 20);
            this.lblVlrSacado.TabIndex = 22;
            this.lblVlrSacado.Text = "Digite o valor a ser sacado:";
            // 
            // lblSldSaque
            // 
            this.lblSldSaque.AutoSize = true;
            this.lblSldSaque.Location = new System.Drawing.Point(86, 13);
            this.lblSldSaque.Name = "lblSldSaque";
            this.lblSldSaque.Size = new System.Drawing.Size(59, 20);
            this.lblSldSaque.TabIndex = 21;
            this.lblSldSaque.Text = "5.000,00";
            // 
            // lblSldCif
            // 
            this.lblSldCif.AutoSize = true;
            this.lblSldCif.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblSldCif.Location = new System.Drawing.Point(59, 13);
            this.lblSldCif.Name = "lblSldCif";
            this.lblSldCif.Size = new System.Drawing.Size(25, 20);
            this.lblSldCif.TabIndex = 20;
            this.lblSldCif.Text = "R$";
            // 
            // lblSld
            // 
            this.lblSld.AutoSize = true;
            this.lblSld.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblSld.Location = new System.Drawing.Point(9, 13);
            this.lblSld.Name = "lblSld";
            this.lblSld.Size = new System.Drawing.Size(49, 20);
            this.lblSld.TabIndex = 13;
            this.lblSld.Text = "Saldo:";
            // 
            // btnCancSaque
            // 
            this.btnCancSaque.BackColor = System.Drawing.Color.Gray;
            this.btnCancSaque.FlatAppearance.BorderSize = 0;
            this.btnCancSaque.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancSaque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancSaque.Location = new System.Drawing.Point(442, 317);
            this.btnCancSaque.Name = "btnCancSaque";
            this.btnCancSaque.Size = new System.Drawing.Size(293, 42);
            this.btnCancSaque.TabIndex = 12;
            this.btnCancSaque.Text = "Cancelar Solicitação";
            this.btnCancSaque.UseVisualStyleBackColor = false;
            this.btnCancSaque.Click += new System.EventHandler(this.btnCancSaque_Click);
            // 
            // tabPagDep
            // 
            this.tabPagDep.Controls.Add(this.txtVlrDepositado);
            this.tabPagDep.Controls.Add(this.lbltextDep);
            this.tabPagDep.Controls.Add(this.lblSldDeposito);
            this.tabPagDep.Controls.Add(this.lblSldCifr);
            this.tabPagDep.Controls.Add(this.lblSldDep);
            this.tabPagDep.Controls.Add(this.btnConfDep);
            this.tabPagDep.Controls.Add(this.btnCancDep);
            this.tabPagDep.Location = new System.Drawing.Point(4, 29);
            this.tabPagDep.Name = "tabPagDep";
            this.tabPagDep.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagDep.Size = new System.Drawing.Size(744, 365);
            this.tabPagDep.TabIndex = 2;
            this.tabPagDep.Text = "Depósito";
            this.tabPagDep.UseVisualStyleBackColor = true;
            // 
            // txtVlrDepositado
            // 
            this.txtVlrDepositado.Location = new System.Drawing.Point(13, 77);
            this.txtVlrDepositado.Name = "txtVlrDepositado";
            this.txtVlrDepositado.Size = new System.Drawing.Size(194, 26);
            this.txtVlrDepositado.TabIndex = 29;
            // 
            // lbltextDep
            // 
            this.lbltextDep.AutoSize = true;
            this.lbltextDep.Location = new System.Drawing.Point(9, 43);
            this.lbltextDep.Name = "lbltextDep";
            this.lbltextDep.Size = new System.Drawing.Size(198, 20);
            this.lbltextDep.TabIndex = 28;
            this.lbltextDep.Text = "Digite o valor a ser depositado:";
            // 
            // lblSldDeposito
            // 
            this.lblSldDeposito.AutoSize = true;
            this.lblSldDeposito.Location = new System.Drawing.Point(85, 8);
            this.lblSldDeposito.Name = "lblSldDeposito";
            this.lblSldDeposito.Size = new System.Drawing.Size(59, 20);
            this.lblSldDeposito.TabIndex = 27;
            this.lblSldDeposito.Text = "5.000,00";
            // 
            // lblSldCifr
            // 
            this.lblSldCifr.AutoSize = true;
            this.lblSldCifr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblSldCifr.Location = new System.Drawing.Point(60, 8);
            this.lblSldCifr.Name = "lblSldCifr";
            this.lblSldCifr.Size = new System.Drawing.Size(25, 20);
            this.lblSldCifr.TabIndex = 26;
            this.lblSldCifr.Text = "R$";
            // 
            // lblSldDep
            // 
            this.lblSldDep.AutoSize = true;
            this.lblSldDep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblSldDep.Location = new System.Drawing.Point(9, 8);
            this.lblSldDep.Name = "lblSldDep";
            this.lblSldDep.Size = new System.Drawing.Size(49, 20);
            this.lblSldDep.TabIndex = 25;
            this.lblSldDep.Text = "Saldo:";
            // 
            // btnConfDep
            // 
            this.btnConfDep.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConfDep.FlatAppearance.BorderSize = 0;
            this.btnConfDep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfDep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfDep.Location = new System.Drawing.Point(146, 317);
            this.btnConfDep.Name = "btnConfDep";
            this.btnConfDep.Size = new System.Drawing.Size(293, 42);
            this.btnConfDep.TabIndex = 24;
            this.btnConfDep.Text = "Confirmar Depósito";
            this.btnConfDep.UseVisualStyleBackColor = false;
            this.btnConfDep.Click += new System.EventHandler(this.btnConfDep_Click);
            // 
            // btnCancDep
            // 
            this.btnCancDep.BackColor = System.Drawing.Color.Gray;
            this.btnCancDep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancDep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancDep.Location = new System.Drawing.Point(445, 317);
            this.btnCancDep.Name = "btnCancDep";
            this.btnCancDep.Size = new System.Drawing.Size(293, 42);
            this.btnCancDep.TabIndex = 13;
            this.btnCancDep.Text = "Cancelar Solicitação";
            this.btnCancDep.UseVisualStyleBackColor = false;
            this.btnCancDep.Click += new System.EventHandler(this.btnCancDep_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(464, 2);
            this.dateTimePicker.MinDate = new System.DateTime(2025, 6, 21, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(284, 26);
            this.dateTimePicker.TabIndex = 17;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // sistemaCaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 428);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "sistemaCaixaEletronico";
            this.Text = "Caixa Eletrônico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPagIni.ResumeLayout(false);
            this.tabPagIni.PerformLayout();
            this.grpBxExtrato.ResumeLayout(false);
            this.tabPagSaque.ResumeLayout(false);
            this.tabPagSaque.PerformLayout();
            this.tabPagDep.ResumeLayout(false);
            this.tabPagDep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoSaqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoDepósitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblVlrSaldo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagSaque;
        private System.Windows.Forms.TabPage tabPagIni;
        private System.Windows.Forms.Label lblCemReais;
        private System.Windows.Forms.Label lblNotasDisponiveis;
        private System.Windows.Forms.TabPage tabPagDep;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblDezReais;
        private System.Windows.Forms.Label lblVinteReais;
        private System.Windows.Forms.Label lblCinquentaReais;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label lblContNtsVinte;
        private System.Windows.Forms.Label lblContNtsCinquenta;
        private System.Windows.Forms.Label lblContNtsCem;
        private System.Windows.Forms.Label lblVlrCaixa;
        private System.Windows.Forms.Label lblContNtsDez;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox grpBxExtrato;
        private System.Windows.Forms.Button btnCancSaque;
        private System.Windows.Forms.Button btnCancDep;
        private System.Windows.Forms.Label lblSldCifrao;
        private System.Windows.Forms.Label lblDispCxCifrao;
        private System.Windows.Forms.TextBox txtVlrSacado;
        private System.Windows.Forms.Label lblVlrSacado;
        private System.Windows.Forms.Label lblSldSaque;
        private System.Windows.Forms.Label lblSldCif;
        private System.Windows.Forms.Label lblSld;
        private System.Windows.Forms.Button btnConfSaque;
        private System.Windows.Forms.Button btnImprimeExtrato;
        private System.Windows.Forms.Button btnConfDep;
        private System.Windows.Forms.Label lblSldDep;
        private System.Windows.Forms.Label lblSldCifr;
        private System.Windows.Forms.Label lblSldDeposito;
        private System.Windows.Forms.Label lbltextDep;
        private System.Windows.Forms.TextBox txtVlrDepositado;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbExtrato;
    }
}