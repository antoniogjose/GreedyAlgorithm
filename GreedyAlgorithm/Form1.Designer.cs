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
            this.button1 = new System.Windows.Forms.Button();
            this.tB_cidade = new System.Windows.Forms.TextBox();
            this.rTb_Output = new System.Windows.Forms.RichTextBox();
            this.cB_Gready = new System.Windows.Forms.CheckBox();
            this.cBA = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB_cidade
            // 
            this.tB_cidade.Location = new System.Drawing.Point(12, 12);
            this.tB_cidade.Name = "tB_cidade";
            this.tB_cidade.Size = new System.Drawing.Size(100, 20);
            this.tB_cidade.TabIndex = 1;
            // 
            // rTb_Output
            // 
            this.rTb_Output.Location = new System.Drawing.Point(119, 12);
            this.rTb_Output.Name = "rTb_Output";
            this.rTb_Output.ReadOnly = true;
            this.rTb_Output.Size = new System.Drawing.Size(581, 352);
            this.rTb_Output.TabIndex = 2;
            this.rTb_Output.Text = "";
            // 
            // cB_Gready
            // 
            this.cB_Gready.AutoSize = true;
            this.cB_Gready.Location = new System.Drawing.Point(13, 80);
            this.cB_Gready.Name = "cB_Gready";
            this.cB_Gready.Size = new System.Drawing.Size(60, 17);
            this.cB_Gready.TabIndex = 3;
            this.cB_Gready.Text = "Gready";
            this.cB_Gready.UseVisualStyleBackColor = true;
            this.cB_Gready.CheckedChanged += new System.EventHandler(this.cB_Gready_CheckedChanged);
            // 
            // cBA
            // 
            this.cBA.AutoSize = true;
            this.cBA.Location = new System.Drawing.Point(13, 103);
            this.cBA.Name = "cBA";
            this.cBA.Size = new System.Drawing.Size(37, 17);
            this.cBA.TabIndex = 3;
            this.cBA.Text = "A*";
            this.cBA.UseVisualStyleBackColor = true;
            this.cBA.CheckedChanged += new System.EventHandler(this.cBA_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 376);
            this.Controls.Add(this.cBA);
            this.Controls.Add(this.cB_Gready);
            this.Controls.Add(this.rTb_Output);
            this.Controls.Add(this.tB_cidade);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tB_cidade;
        private System.Windows.Forms.RichTextBox rTb_Output;
        private System.Windows.Forms.CheckBox cB_Gready;
        private System.Windows.Forms.CheckBox cBA;
    }
}

