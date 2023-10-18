namespace UiWinFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLigar = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.textBoxImpulso = new System.Windows.Forms.TextBox();
            this.buttonFrear = new System.Windows.Forms.Button();
            this.buttonTrocarPneu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPneuDianteiroDireito = new System.Windows.Forms.TextBox();
            this.textBoxExibir = new System.Windows.Forms.TextBox();
            this.textBoxPneuTraseiroDireito = new System.Windows.Forms.TextBox();
            this.textBoxPneuDianteiroEsquerdo = new System.Windows.Forms.TextBox();
            this.textBoxPneuTraseiroEsquerdo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPneuDeEstepe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPneu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonLigar
            // 
            this.buttonLigar.Location = new System.Drawing.Point(11, 352);
            this.buttonLigar.Name = "buttonLigar";
            this.buttonLigar.Size = new System.Drawing.Size(94, 29);
            this.buttonLigar.TabIndex = 0;
            this.buttonLigar.Text = "Ligar";
            this.buttonLigar.UseVisualStyleBackColor = true;
            this.buttonLigar.Click += new System.EventHandler(this.butt_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(112, 352);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(98, 29);
            this.buttonAcelerar.TabIndex = 1;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // textBoxImpulso
            // 
            this.textBoxImpulso.Location = new System.Drawing.Point(11, 307);
            this.textBoxImpulso.Name = "textBoxImpulso";
            this.textBoxImpulso.Size = new System.Drawing.Size(406, 27);
            this.textBoxImpulso.TabIndex = 2;
            this.textBoxImpulso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonFrear
            // 
            this.buttonFrear.Location = new System.Drawing.Point(216, 352);
            this.buttonFrear.Name = "buttonFrear";
            this.buttonFrear.Size = new System.Drawing.Size(98, 29);
            this.buttonFrear.TabIndex = 4;
            this.buttonFrear.Text = "Frear";
            this.buttonFrear.UseVisualStyleBackColor = true;
            this.buttonFrear.Click += new System.EventHandler(this.buttonFrear_Click);
            // 
            // buttonTrocarPneu
            // 
            this.buttonTrocarPneu.Location = new System.Drawing.Point(21, 505);
            this.buttonTrocarPneu.Name = "buttonTrocarPneu";
            this.buttonTrocarPneu.Size = new System.Drawing.Size(98, 29);
            this.buttonTrocarPneu.TabIndex = 5;
            this.buttonTrocarPneu.Text = "Trocar Pneu";
            this.buttonTrocarPneu.UseVisualStyleBackColor = true;
            this.buttonTrocarPneu.Click += new System.EventHandler(this.buttonTrocarPneu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Impulso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(903, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalhes do carro";
            // 
            // textBoxPneuDianteiroDireito
            // 
            this.textBoxPneuDianteiroDireito.Location = new System.Drawing.Point(1215, 31);
            this.textBoxPneuDianteiroDireito.Multiline = true;
            this.textBoxPneuDianteiroDireito.Name = "textBoxPneuDianteiroDireito";
            this.textBoxPneuDianteiroDireito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDianteiroDireito.Size = new System.Drawing.Size(257, 295);
            this.textBoxPneuDianteiroDireito.TabIndex = 3;
            this.textBoxPneuDianteiroDireito.TextChanged += new System.EventHandler(this.TextBoxExibir_TextChanged);
            // 
            // textBoxExibir
            // 
            this.textBoxExibir.Location = new System.Drawing.Point(903, 31);
            this.textBoxExibir.Multiline = true;
            this.textBoxExibir.Name = "textBoxExibir";
            this.textBoxExibir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExibir.Size = new System.Drawing.Size(257, 295);
            this.textBoxExibir.TabIndex = 3;
            this.textBoxExibir.TextChanged += new System.EventHandler(this.TextBoxExibir_TextChanged);
            // 
            // textBoxPneuTraseiroDireito
            // 
            this.textBoxPneuTraseiroDireito.Location = new System.Drawing.Point(1215, 352);
            this.textBoxPneuTraseiroDireito.Multiline = true;
            this.textBoxPneuTraseiroDireito.Name = "textBoxPneuTraseiroDireito";
            this.textBoxPneuTraseiroDireito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuTraseiroDireito.Size = new System.Drawing.Size(257, 305);
            this.textBoxPneuTraseiroDireito.TabIndex = 3;
            this.textBoxPneuTraseiroDireito.TextChanged += new System.EventHandler(this.TextBoxExibir_TextChanged);
            // 
            // textBoxPneuDianteiroEsquerdo
            // 
            this.textBoxPneuDianteiroEsquerdo.Location = new System.Drawing.Point(587, 31);
            this.textBoxPneuDianteiroEsquerdo.Multiline = true;
            this.textBoxPneuDianteiroEsquerdo.Name = "textBoxPneuDianteiroEsquerdo";
            this.textBoxPneuDianteiroEsquerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDianteiroEsquerdo.Size = new System.Drawing.Size(257, 295);
            this.textBoxPneuDianteiroEsquerdo.TabIndex = 3;
            this.textBoxPneuDianteiroEsquerdo.TextChanged += new System.EventHandler(this.TextBoxExibir_TextChanged);
            // 
            // textBoxPneuTraseiroEsquerdo
            // 
            this.textBoxPneuTraseiroEsquerdo.Location = new System.Drawing.Point(587, 352);
            this.textBoxPneuTraseiroEsquerdo.Multiline = true;
            this.textBoxPneuTraseiroEsquerdo.Name = "textBoxPneuTraseiroEsquerdo";
            this.textBoxPneuTraseiroEsquerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuTraseiroEsquerdo.Size = new System.Drawing.Size(257, 305);
            this.textBoxPneuTraseiroEsquerdo.TabIndex = 3;
            this.textBoxPneuTraseiroEsquerdo.TextChanged += new System.EventHandler(this.TextBoxExibir_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pneu dianteiro esquerdo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pnaue traseiro esquerdo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1215, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pnaue traseiro direito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1215, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pnaue dianteiro direito";
            // 
            // textBoxPneuDeEstepe
            // 
            this.textBoxPneuDeEstepe.Location = new System.Drawing.Point(903, 352);
            this.textBoxPneuDeEstepe.Multiline = true;
            this.textBoxPneuDeEstepe.Name = "textBoxPneuDeEstepe";
            this.textBoxPneuDeEstepe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDeEstepe.Size = new System.Drawing.Size(257, 305);
            this.textBoxPneuDeEstepe.TabIndex = 3;
            this.textBoxPneuDeEstepe.TextChanged += new System.EventHandler(this.TextBoxExibir_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1536, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pnaue dianteiro direito";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(903, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estepe";
            // 
            // comboBoxPneu
            // 
            this.comboBoxPneu.FormattingEnabled = true;
            this.comboBoxPneu.Items.AddRange(new object[] {
            "Pneu dianteiro esquerdo",
            "Pneu dianteiro direito",
            "Pneu traseiro esquerdo",
            "Pneu traseiro direito"});
            this.comboBoxPneu.Location = new System.Drawing.Point(21, 471);
            this.comboBoxPneu.Name = "comboBoxPneu";
            this.comboBoxPneu.Size = new System.Drawing.Size(189, 28);
            this.comboBoxPneu.TabIndex = 8;
            this.comboBoxPneu.SelectedIndexChanged += new System.EventHandler(this.comboBoxPneu_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 669);
            this.Controls.Add(this.comboBoxPneu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTrocarPneu);
            this.Controls.Add(this.buttonFrear);
            this.Controls.Add(this.textBoxPneuDeEstepe);
            this.Controls.Add(this.textBoxPneuTraseiroDireito);
            this.Controls.Add(this.textBoxPneuTraseiroEsquerdo);
            this.Controls.Add(this.textBoxPneuDianteiroEsquerdo);
            this.Controls.Add(this.textBoxPneuDianteiroDireito);
            this.Controls.Add(this.textBoxExibir);
            this.Controls.Add(this.textBoxImpulso);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonLigar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLigar;
        private Button buttonAcelerar;
        private TextBox textBoxImpulso;
        private Button buttonFrear;
        private Button buttonTrocarPneu;
        private Label label1;
        private Label label2;
        private TextBox textBoxPneuDianteiroDireito;
        private TextBox textBoxExibir;
        private TextBox textBoxPneuTraseiroDireito;
        private TextBox textBoxPneuDianteiroEsquerdo;
        private TextBox textBoxPneuTraseiroEsquerdo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxPneuDeEstepe;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxPneu;
    }
}