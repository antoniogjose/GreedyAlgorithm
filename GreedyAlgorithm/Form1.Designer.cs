namespace GreedyAlgorithm
{
    partial class Form1
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
            this.tB = new System.Windows.Forms.TabControl();
            this.tP_PesInf = new System.Windows.Forms.TabPage();
            this.cBA = new System.Windows.Forms.CheckBox();
            this.cB_Gready = new System.Windows.Forms.CheckBox();
            this.rTb_Output = new System.Windows.Forms.RichTextBox();
            this.tB_cidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tP_RedNeu = new System.Windows.Forms.TabPage();
            this.dG_dados = new System.Windows.Forms.DataGridView();
            this.X0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.rT_Board = new System.Windows.Forms.RichTextBox();
            this.cB_Rand = new System.Windows.Forms.CheckBox();
            this.cB_Zero = new System.Windows.Forms.CheckBox();
            this.bt_Calcular = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new AForge.Controls.Chart();
            this.btAlterar = new System.Windows.Forms.Button();
            this.bTAdicionar = new System.Windows.Forms.Button();
            this.bTIniciar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lBNeuronios = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBinteraccao = new System.Windows.Forms.TextBox();
            this.tBRaio = new System.Windows.Forms.TextBox();
            this.tBPerc = new System.Windows.Forms.TextBox();
            this.tBInteraccoes = new System.Windows.Forms.TextBox();
            this.tBNeuronios = new System.Windows.Forms.TextBox();
            this.tBPontos = new System.Windows.Forms.TextBox();
            this.tBLat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBLong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBArea = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btPois = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tByMax = new System.Windows.Forms.TextBox();
            this.tBxMax = new System.Windows.Forms.TextBox();
            this.tBxMin = new System.Windows.Forms.TextBox();
            this.tByMin = new System.Windows.Forms.TextBox();
            this.tBPoisF = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tB.SuspendLayout();
            this.tP_PesInf.SuspendLayout();
            this.tP_RedNeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_dados)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB
            // 
            this.tB.Controls.Add(this.tP_PesInf);
            this.tB.Controls.Add(this.tP_RedNeu);
            this.tB.Controls.Add(this.tabPage1);
            this.tB.Location = new System.Drawing.Point(13, 13);
            this.tB.Name = "tB";
            this.tB.SelectedIndex = 0;
            this.tB.Size = new System.Drawing.Size(830, 488);
            this.tB.TabIndex = 0;
            // 
            // tP_PesInf
            // 
            this.tP_PesInf.Controls.Add(this.cBA);
            this.tP_PesInf.Controls.Add(this.cB_Gready);
            this.tP_PesInf.Controls.Add(this.rTb_Output);
            this.tP_PesInf.Controls.Add(this.tB_cidade);
            this.tP_PesInf.Controls.Add(this.button1);
            this.tP_PesInf.Location = new System.Drawing.Point(4, 22);
            this.tP_PesInf.Name = "tP_PesInf";
            this.tP_PesInf.Padding = new System.Windows.Forms.Padding(3);
            this.tP_PesInf.Size = new System.Drawing.Size(822, 462);
            this.tP_PesInf.TabIndex = 0;
            this.tP_PesInf.Text = "Pesquisa Informada";
            this.tP_PesInf.UseVisualStyleBackColor = true;
            // 
            // cBA
            // 
            this.cBA.AutoSize = true;
            this.cBA.Location = new System.Drawing.Point(7, 119);
            this.cBA.Name = "cBA";
            this.cBA.Size = new System.Drawing.Size(37, 17);
            this.cBA.TabIndex = 4;
            this.cBA.Text = "A*";
            this.cBA.UseVisualStyleBackColor = true;
            this.cBA.CheckedChanged += new System.EventHandler(this.cBA_CheckedChanged_1);
            // 
            // cB_Gready
            // 
            this.cB_Gready.AutoSize = true;
            this.cB_Gready.Location = new System.Drawing.Point(7, 96);
            this.cB_Gready.Name = "cB_Gready";
            this.cB_Gready.Size = new System.Drawing.Size(60, 17);
            this.cB_Gready.TabIndex = 3;
            this.cB_Gready.Text = "Gready";
            this.cB_Gready.UseVisualStyleBackColor = true;
            this.cB_Gready.CheckedChanged += new System.EventHandler(this.cB_Gready_CheckedChanged_1);
            // 
            // rTb_Output
            // 
            this.rTb_Output.Location = new System.Drawing.Point(113, 28);
            this.rTb_Output.Name = "rTb_Output";
            this.rTb_Output.ReadOnly = true;
            this.rTb_Output.Size = new System.Drawing.Size(703, 428);
            this.rTb_Output.TabIndex = 2;
            this.rTb_Output.Text = "";
            // 
            // tB_cidade
            // 
            this.tB_cidade.Location = new System.Drawing.Point(6, 28);
            this.tB_cidade.Name = "tB_cidade";
            this.tB_cidade.Size = new System.Drawing.Size(100, 20);
            this.tB_cidade.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tP_RedNeu
            // 
            this.tP_RedNeu.Controls.Add(this.dG_dados);
            this.tP_RedNeu.Controls.Add(this.label1);
            this.tP_RedNeu.Controls.Add(this.rT_Board);
            this.tP_RedNeu.Controls.Add(this.cB_Rand);
            this.tP_RedNeu.Controls.Add(this.cB_Zero);
            this.tP_RedNeu.Controls.Add(this.bt_Calcular);
            this.tP_RedNeu.Location = new System.Drawing.Point(4, 22);
            this.tP_RedNeu.Name = "tP_RedNeu";
            this.tP_RedNeu.Padding = new System.Windows.Forms.Padding(3);
            this.tP_RedNeu.Size = new System.Drawing.Size(822, 462);
            this.tP_RedNeu.TabIndex = 1;
            this.tP_RedNeu.Text = "Redes Neurais Artificiais: PERCEPTRON";
            this.tP_RedNeu.UseVisualStyleBackColor = true;
            // 
            // dG_dados
            // 
            this.dG_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X0,
            this.X1,
            this.X2,
            this.U,
            this.t});
            this.dG_dados.Location = new System.Drawing.Point(4, 7);
            this.dG_dados.Name = "dG_dados";
            this.dG_dados.Size = new System.Drawing.Size(812, 150);
            this.dG_dados.TabIndex = 5;
            this.dG_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // X0
            // 
            this.X0.HeaderText = "X0";
            this.X0.Name = "X0";
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            // 
            // U
            // 
            this.U.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.U.HeaderText = "U";
            this.U.Name = "U";
            // 
            // t
            // 
            this.t.HeaderText = "t";
            this.t.Name = "t";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor Inicialdo erro :";
            // 
            // rT_Board
            // 
            this.rT_Board.Location = new System.Drawing.Point(110, 167);
            this.rT_Board.Name = "rT_Board";
            this.rT_Board.Size = new System.Drawing.Size(706, 289);
            this.rT_Board.TabIndex = 3;
            this.rT_Board.Text = "";
            // 
            // cB_Rand
            // 
            this.cB_Rand.AutoSize = true;
            this.cB_Rand.Location = new System.Drawing.Point(6, 392);
            this.cB_Rand.Name = "cB_Rand";
            this.cB_Rand.Size = new System.Drawing.Size(66, 17);
            this.cB_Rand.TabIndex = 2;
            this.cB_Rand.Text = "Random";
            this.cB_Rand.UseVisualStyleBackColor = true;
            // 
            // cB_Zero
            // 
            this.cB_Zero.AutoSize = true;
            this.cB_Zero.Location = new System.Drawing.Point(6, 369);
            this.cB_Zero.Name = "cB_Zero";
            this.cB_Zero.Size = new System.Drawing.Size(51, 17);
            this.cB_Zero.TabIndex = 2;
            this.cB_Zero.Text = "E = 0";
            this.cB_Zero.UseVisualStyleBackColor = true;
            // 
            // bt_Calcular
            // 
            this.bt_Calcular.Location = new System.Drawing.Point(6, 415);
            this.bt_Calcular.Name = "bt_Calcular";
            this.bt_Calcular.Size = new System.Drawing.Size(98, 41);
            this.bt_Calcular.TabIndex = 1;
            this.bt_Calcular.Text = "Calcular";
            this.bt_Calcular.UseVisualStyleBackColor = true;
            this.bt_Calcular.Click += new System.EventHandler(this.bt_Calcular_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.btPois);
            this.tabPage1.Controls.Add(this.btAlterar);
            this.tabPage1.Controls.Add(this.bTAdicionar);
            this.tabPage1.Controls.Add(this.bTIniciar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lBNeuronios);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tBinteraccao);
            this.tabPage1.Controls.Add(this.tBRaio);
            this.tabPage1.Controls.Add(this.tBPerc);
            this.tabPage1.Controls.Add(this.tBInteraccoes);
            this.tabPage1.Controls.Add(this.tBNeuronios);
            this.tabPage1.Controls.Add(this.tBPoisF);
            this.tabPage1.Controls.Add(this.tBArea);
            this.tabPage1.Controls.Add(this.tBLong);
            this.tabPage1.Controls.Add(this.tBLat);
            this.tabPage1.Controls.Add(this.tByMin);
            this.tabPage1.Controls.Add(this.tBxMin);
            this.tabPage1.Controls.Add(this.tBxMax);
            this.tabPage1.Controls.Add(this.tByMax);
            this.tabPage1.Controls.Add(this.tBPontos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 462);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Redes Neuronais CV";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(102, 32);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(496, 373);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "mapa";
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(712, 255);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(94, 24);
            this.btAlterar.TabIndex = 7;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.bTAlterar_Click);
            // 
            // bTAdicionar
            // 
            this.bTAdicionar.Location = new System.Drawing.Point(710, 59);
            this.bTAdicionar.Name = "bTAdicionar";
            this.bTAdicionar.Size = new System.Drawing.Size(94, 24);
            this.bTAdicionar.TabIndex = 7;
            this.bTAdicionar.Text = "Adicionar";
            this.bTAdicionar.UseVisualStyleBackColor = true;
            this.bTAdicionar.Click += new System.EventHandler(this.bTAdicionar_Click);
            // 
            // bTIniciar
            // 
            this.bTIniciar.Location = new System.Drawing.Point(604, 415);
            this.bTIniciar.Name = "bTIniciar";
            this.bTIniciar.Size = new System.Drawing.Size(202, 41);
            this.bTIniciar.TabIndex = 7;
            this.bTIniciar.Text = "Iniciar";
            this.bTIniciar.UseVisualStyleBackColor = true;
            this.bTIniciar.Click += new System.EventHandler(this.bTIniciar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Interação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Raio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Percentagem Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interacções";
            // 
            // lBNeuronios
            // 
            this.lBNeuronios.AutoSize = true;
            this.lBNeuronios.Location = new System.Drawing.Point(652, 288);
            this.lBNeuronios.Name = "lBNeuronios";
            this.lBNeuronios.Size = new System.Drawing.Size(55, 13);
            this.lBNeuronios.TabIndex = 6;
            this.lBNeuronios.Text = "Neurónios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(99, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "( Algoritmo Elástico )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "(Adicione o número de Cidades MAX:50)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "N. Pontos";
            // 
            // tBinteraccao
            // 
            this.tBinteraccao.Enabled = false;
            this.tBinteraccao.Location = new System.Drawing.Point(712, 389);
            this.tBinteraccao.Name = "tBinteraccao";
            this.tBinteraccao.Size = new System.Drawing.Size(94, 20);
            this.tBinteraccao.TabIndex = 5;
            // 
            // tBRaio
            // 
            this.tBRaio.Location = new System.Drawing.Point(712, 363);
            this.tBRaio.Name = "tBRaio";
            this.tBRaio.Size = new System.Drawing.Size(94, 20);
            this.tBRaio.TabIndex = 5;
            // 
            // tBPerc
            // 
            this.tBPerc.Location = new System.Drawing.Point(712, 337);
            this.tBPerc.Name = "tBPerc";
            this.tBPerc.Size = new System.Drawing.Size(94, 20);
            this.tBPerc.TabIndex = 5;
            // 
            // tBInteraccoes
            // 
            this.tBInteraccoes.Location = new System.Drawing.Point(712, 311);
            this.tBInteraccoes.Name = "tBInteraccoes";
            this.tBInteraccoes.Size = new System.Drawing.Size(94, 20);
            this.tBInteraccoes.TabIndex = 5;
            // 
            // tBNeuronios
            // 
            this.tBNeuronios.Location = new System.Drawing.Point(712, 285);
            this.tBNeuronios.Name = "tBNeuronios";
            this.tBNeuronios.Size = new System.Drawing.Size(94, 20);
            this.tBNeuronios.TabIndex = 5;
            // 
            // tBPontos
            // 
            this.tBPontos.Location = new System.Drawing.Point(710, 32);
            this.tBPontos.Name = "tBPontos";
            this.tBPontos.Size = new System.Drawing.Size(94, 20);
            this.tBPontos.TabIndex = 5;
            this.tBPontos.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // tBLat
            // 
            this.tBLat.Location = new System.Drawing.Point(710, 89);
            this.tBLat.Name = "tBLat";
            this.tBLat.Size = new System.Drawing.Size(94, 20);
            this.tBLat.TabIndex = 5;
            this.tBLat.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Latitude";
            // 
            // tBLong
            // 
            this.tBLong.Location = new System.Drawing.Point(710, 115);
            this.tBLong.Name = "tBLong";
            this.tBLong.Size = new System.Drawing.Size(94, 20);
            this.tBLong.TabIndex = 5;
            this.tBLong.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(653, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Longitude";
            // 
            // tBArea
            // 
            this.tBArea.Location = new System.Drawing.Point(710, 141);
            this.tBArea.Name = "tBArea";
            this.tBArea.Size = new System.Drawing.Size(94, 20);
            this.tBArea.TabIndex = 5;
            this.tBArea.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(675, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Area";
            // 
            // btPois
            // 
            this.btPois.Location = new System.Drawing.Point(710, 201);
            this.btPois.Name = "btPois";
            this.btPois.Size = new System.Drawing.Size(94, 24);
            this.btPois.TabIndex = 7;
            this.btPois.Text = "Pesquisar POI´s";
            this.btPois.UseVisualStyleBackColor = true;
            this.btPois.Click += new System.EventHandler(this.btPois_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(476, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Pontos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(551, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Poi´s";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tByMax
            // 
            this.tByMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tByMax.Location = new System.Drawing.Point(6, 51);
            this.tByMax.Name = "tByMax";
            this.tByMax.Size = new System.Drawing.Size(90, 13);
            this.tByMax.TabIndex = 5;
            this.tByMax.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // tBxMax
            // 
            this.tBxMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBxMax.Location = new System.Drawing.Point(476, 424);
            this.tBxMax.Name = "tBxMax";
            this.tBxMax.Size = new System.Drawing.Size(122, 13);
            this.tBxMax.TabIndex = 5;
            this.tBxMax.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // tBxMin
            // 
            this.tBxMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBxMin.Location = new System.Drawing.Point(102, 424);
            this.tBxMin.Name = "tBxMin";
            this.tBxMin.Size = new System.Drawing.Size(99, 13);
            this.tBxMin.TabIndex = 5;
            this.tBxMin.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // tByMin
            // 
            this.tByMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tByMin.Location = new System.Drawing.Point(6, 385);
            this.tByMin.Name = "tByMin";
            this.tByMin.Size = new System.Drawing.Size(90, 13);
            this.tByMin.TabIndex = 5;
            this.tByMin.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // tBPoisF
            // 
            this.tBPoisF.Location = new System.Drawing.Point(710, 167);
            this.tBPoisF.Name = "tBPoisF";
            this.tBPoisF.ReadOnly = true;
            this.tBPoisF.Size = new System.Drawing.Size(94, 20);
            this.tBPoisF.TabIndex = 5;
            this.tBPoisF.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(614, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Poi´s Encontrados";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(584, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 513);
            this.Controls.Add(this.tB);
            this.Name = "Form1";
            this.Text = "Inteligencia Artificial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tB.ResumeLayout(false);
            this.tP_PesInf.ResumeLayout(false);
            this.tP_PesInf.PerformLayout();
            this.tP_RedNeu.ResumeLayout(false);
            this.tP_RedNeu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_dados)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tB;
        private System.Windows.Forms.TabPage tP_PesInf;
        private System.Windows.Forms.CheckBox cBA;
        private System.Windows.Forms.CheckBox cB_Gready;
        private System.Windows.Forms.RichTextBox rTb_Output;
        private System.Windows.Forms.TextBox tB_cidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tP_RedNeu;
        private System.Windows.Forms.RichTextBox rT_Board;
        private System.Windows.Forms.CheckBox cB_Rand;
        private System.Windows.Forms.CheckBox cB_Zero;
        private System.Windows.Forms.Button bt_Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dG_dados;
        private System.Windows.Forms.DataGridViewTextBoxColumn X0;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn U;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lBNeuronios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNeuronios;
        private System.Windows.Forms.TextBox tBPontos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBinteraccao;
        private System.Windows.Forms.TextBox tBRaio;
        private System.Windows.Forms.TextBox tBPerc;
        private System.Windows.Forms.TextBox tBInteraccoes;
        private System.Windows.Forms.Button bTIniciar;
        private AForge.Controls.Chart chart1;
        private System.Windows.Forms.Button bTAdicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btPois;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBArea;
        private System.Windows.Forms.TextBox tBLong;
        private System.Windows.Forms.TextBox tBLat;
        private System.Windows.Forms.TextBox tByMin;
        private System.Windows.Forms.TextBox tBxMin;
        private System.Windows.Forms.TextBox tBxMax;
        private System.Windows.Forms.TextBox tByMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBPoisF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

