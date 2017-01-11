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
            this.bTIniciar = new System.Windows.Forms.Button();
            this.tBParar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lBNeuronios = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBinteraccao = new System.Windows.Forms.TextBox();
            this.tBRaio = new System.Windows.Forms.TextBox();
            this.tBPerc = new System.Windows.Forms.TextBox();
            this.tBInteraccoes = new System.Windows.Forms.TextBox();
            this.tBNeuronios = new System.Windows.Forms.TextBox();
            this.tBPontos = new System.Windows.Forms.TextBox();
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
            this.tB.Size = new System.Drawing.Size(725, 427);
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
            this.tP_PesInf.Size = new System.Drawing.Size(717, 401);
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
            this.rTb_Output.Size = new System.Drawing.Size(581, 352);
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
            this.tP_RedNeu.Size = new System.Drawing.Size(717, 401);
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
            this.dG_dados.Size = new System.Drawing.Size(707, 150);
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
            this.label1.Location = new System.Drawing.Point(4, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor Inicialdo erro :";
            // 
            // rT_Board
            // 
            this.rT_Board.Location = new System.Drawing.Point(110, 167);
            this.rT_Board.Name = "rT_Board";
            this.rT_Board.Size = new System.Drawing.Size(601, 228);
            this.rT_Board.TabIndex = 3;
            this.rT_Board.Text = "";
            // 
            // cB_Rand
            // 
            this.cB_Rand.AutoSize = true;
            this.cB_Rand.Location = new System.Drawing.Point(7, 331);
            this.cB_Rand.Name = "cB_Rand";
            this.cB_Rand.Size = new System.Drawing.Size(66, 17);
            this.cB_Rand.TabIndex = 2;
            this.cB_Rand.Text = "Random";
            this.cB_Rand.UseVisualStyleBackColor = true;
            // 
            // cB_Zero
            // 
            this.cB_Zero.AutoSize = true;
            this.cB_Zero.Location = new System.Drawing.Point(7, 308);
            this.cB_Zero.Name = "cB_Zero";
            this.cB_Zero.Size = new System.Drawing.Size(51, 17);
            this.cB_Zero.TabIndex = 2;
            this.cB_Zero.Text = "E = 0";
            this.cB_Zero.UseVisualStyleBackColor = true;
            // 
            // bt_Calcular
            // 
            this.bt_Calcular.Location = new System.Drawing.Point(7, 354);
            this.bt_Calcular.Name = "bt_Calcular";
            this.bt_Calcular.Size = new System.Drawing.Size(98, 41);
            this.bt_Calcular.TabIndex = 1;
            this.bt_Calcular.Text = "Calcular";
            this.bt_Calcular.UseVisualStyleBackColor = true;
            this.bt_Calcular.Click += new System.EventHandler(this.bt_Calcular_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.bTIniciar);
            this.tabPage1.Controls.Add(this.tBParar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lBNeuronios);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tBinteraccao);
            this.tabPage1.Controls.Add(this.tBRaio);
            this.tabPage1.Controls.Add(this.tBPerc);
            this.tabPage1.Controls.Add(this.tBInteraccoes);
            this.tabPage1.Controls.Add(this.tBNeuronios);
            this.tabPage1.Controls.Add(this.tBPontos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 401);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Redes Neuronais CV";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(7, 4);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(496, 391);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "mapa";
            // 
            // bTIniciar
            // 
            this.bTIniciar.Location = new System.Drawing.Point(613, 354);
            this.bTIniciar.Name = "bTIniciar";
            this.bTIniciar.Size = new System.Drawing.Size(98, 41);
            this.bTIniciar.TabIndex = 7;
            this.bTIniciar.Text = "Iniciar";
            this.bTIniciar.UseVisualStyleBackColor = true;
            this.bTIniciar.Click += new System.EventHandler(this.bTIniciar_Click);
            // 
            // tBParar
            // 
            this.tBParar.Location = new System.Drawing.Point(509, 354);
            this.tBParar.Name = "tBParar";
            this.tBParar.Size = new System.Drawing.Size(98, 41);
            this.tBParar.TabIndex = 7;
            this.tBParar.Text = "Parar";
            this.tBParar.UseVisualStyleBackColor = true;
            this.tBParar.Click += new System.EventHandler(this.tBParar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Interação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Raio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Percentagem Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interacções";
            // 
            // lBNeuronios
            // 
            this.lBNeuronios.AutoSize = true;
            this.lBNeuronios.Location = new System.Drawing.Point(557, 48);
            this.lBNeuronios.Name = "lBNeuronios";
            this.lBNeuronios.Size = new System.Drawing.Size(55, 13);
            this.lBNeuronios.TabIndex = 6;
            this.lBNeuronios.Text = "Neurónios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "N. Pontos";
            // 
            // tBinteraccao
            // 
            this.tBinteraccao.Enabled = false;
            this.tBinteraccao.Location = new System.Drawing.Point(617, 149);
            this.tBinteraccao.Name = "tBinteraccao";
            this.tBinteraccao.Size = new System.Drawing.Size(94, 20);
            this.tBinteraccao.TabIndex = 5;
            // 
            // tBRaio
            // 
            this.tBRaio.Location = new System.Drawing.Point(617, 123);
            this.tBRaio.Name = "tBRaio";
            this.tBRaio.Size = new System.Drawing.Size(94, 20);
            this.tBRaio.TabIndex = 5;
            // 
            // tBPerc
            // 
            this.tBPerc.Location = new System.Drawing.Point(617, 97);
            this.tBPerc.Name = "tBPerc";
            this.tBPerc.Size = new System.Drawing.Size(94, 20);
            this.tBPerc.TabIndex = 5;
            // 
            // tBInteraccoes
            // 
            this.tBInteraccoes.Location = new System.Drawing.Point(617, 71);
            this.tBInteraccoes.Name = "tBInteraccoes";
            this.tBInteraccoes.Size = new System.Drawing.Size(94, 20);
            this.tBInteraccoes.TabIndex = 5;
            // 
            // tBNeuronios
            // 
            this.tBNeuronios.Location = new System.Drawing.Point(617, 45);
            this.tBNeuronios.Name = "tBNeuronios";
            this.tBNeuronios.Size = new System.Drawing.Size(94, 20);
            this.tBNeuronios.TabIndex = 5;
            // 
            // tBPontos
            // 
            this.tBPontos.Location = new System.Drawing.Point(617, 19);
            this.tBPontos.Name = "tBPontos";
            this.tBPontos.Size = new System.Drawing.Size(94, 20);
            this.tBPontos.TabIndex = 5;
            this.tBPontos.TextChanged += new System.EventHandler(this.tBPontos_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 451);
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
        private System.Windows.Forms.Button tBParar;
        private AForge.Controls.Chart chart1;
    }
}

