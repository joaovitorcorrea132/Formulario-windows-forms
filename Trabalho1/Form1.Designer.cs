namespace Trabalho1
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.labelMat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showData = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boxMatricula = new System.Windows.Forms.TextBox();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.telBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.cursoBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.modalidadeR1 = new System.Windows.Forms.RadioButton();
            this.modalidadeR2 = new System.Windows.Forms.RadioButton();
            this.modelBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AlunoR2 = new System.Windows.Forms.RadioButton();
            this.AlunoR1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transferidoR2 = new System.Windows.Forms.RadioButton();
            this.trasnferidoR1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.obsBox = new System.Windows.Forms.TextBox();
            this.pagamentoBox = new System.Windows.Forms.ComboBox();
            this.mensalidadeBox = new System.Windows.Forms.TextBox();
            this.diciplinasBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.modelBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMat
            // 
            this.labelMat.AutoSize = true;
            this.labelMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMat.Location = new System.Drawing.Point(25, 37);
            this.labelMat.Name = "labelMat";
            this.labelMat.Size = new System.Drawing.Size(83, 20);
            this.labelMat.TabIndex = 0;
            this.labelMat.Text = "Matrícula:";
            this.labelMat.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Curso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Disciplinas:";
            // 
            // showData
            // 
            this.showData.BackColor = System.Drawing.Color.RoyalBlue;
            this.showData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showData.Location = new System.Drawing.Point(28, 509);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(275, 56);
            this.showData.TabIndex = 7;
            this.showData.Text = "Mostrar dados";
            this.showData.UseVisualStyleBackColor = false;
            this.showData.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1014, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // boxMatricula
            // 
            this.boxMatricula.Location = new System.Drawing.Point(134, 35);
            this.boxMatricula.Name = "boxMatricula";
            this.boxMatricula.Size = new System.Drawing.Size(159, 22);
            this.boxMatricula.TabIndex = 9;
            // 
            // boxNome
            // 
            this.boxNome.Location = new System.Drawing.Point(134, 93);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(273, 22);
            this.boxNome.TabIndex = 10;
            // 
            // adressBox
            // 
            this.adressBox.Location = new System.Drawing.Point(134, 145);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(273, 22);
            this.adressBox.TabIndex = 11;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(134, 201);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(273, 22);
            this.telBox.TabIndex = 12;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(134, 250);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(273, 22);
            this.mailBox.TabIndex = 13;
            // 
            // cursoBox
            // 
            this.cursoBox.FormattingEnabled = true;
            this.cursoBox.Items.AddRange(new object[] {
            "Administração",
            "Ciências Contábeis",
            "Enfermagem",
            "Direito",
            "Fisioterapia",
            "Odontologia",
            "Engenharia Civil",
            "Engenharia da Computação"});
            this.cursoBox.Location = new System.Drawing.Point(134, 306);
            this.cursoBox.Name = "cursoBox";
            this.cursoBox.Size = new System.Drawing.Size(273, 24);
            this.cursoBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Semestres:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(599, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 20);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "1° Semestre";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(771, 135);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 20);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "2° Semestre";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(453, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Valor da mesnsalidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(453, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Forma de pagamento:";
            // 
            // modalidadeR1
            // 
            this.modalidadeR1.AutoSize = true;
            this.modalidadeR1.Location = new System.Drawing.Point(140, 18);
            this.modalidadeR1.Name = "modalidadeR1";
            this.modalidadeR1.Size = new System.Drawing.Size(96, 20);
            this.modalidadeR1.TabIndex = 0;
            this.modalidadeR1.TabStop = true;
            this.modalidadeR1.Text = "Graduação";
            this.modalidadeR1.UseVisualStyleBackColor = true;
            // 
            // modalidadeR2
            // 
            this.modalidadeR2.AutoSize = true;
            this.modalidadeR2.Location = new System.Drawing.Point(313, 18);
            this.modalidadeR2.Name = "modalidadeR2";
            this.modalidadeR2.Size = new System.Drawing.Size(75, 20);
            this.modalidadeR2.TabIndex = 1;
            this.modalidadeR2.TabStop = true;
            this.modalidadeR2.Text = "Colégio";
            this.modalidadeR2.UseVisualStyleBackColor = true;
            // 
            // modelBox
            // 
            this.modelBox.Controls.Add(this.modalidadeR2);
            this.modelBox.Controls.Add(this.modalidadeR1);
            this.modelBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modelBox.Location = new System.Drawing.Point(458, 53);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(529, 51);
            this.modelBox.TabIndex = 17;
            this.modelBox.TabStop = false;
            this.modelBox.Text = "Modalidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AlunoR2);
            this.groupBox1.Controls.Add(this.AlunoR1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(476, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 55);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno novo";
            // 
            // AlunoR2
            // 
            this.AlunoR2.AutoSize = true;
            this.AlunoR2.Location = new System.Drawing.Point(240, 21);
            this.AlunoR2.Name = "AlunoR2";
            this.AlunoR2.Size = new System.Drawing.Size(54, 20);
            this.AlunoR2.TabIndex = 1;
            this.AlunoR2.TabStop = true;
            this.AlunoR2.Text = "Não";
            this.AlunoR2.UseVisualStyleBackColor = true;
            // 
            // AlunoR1
            // 
            this.AlunoR1.AutoSize = true;
            this.AlunoR1.Location = new System.Drawing.Point(146, 21);
            this.AlunoR1.Name = "AlunoR1";
            this.AlunoR1.Size = new System.Drawing.Size(51, 20);
            this.AlunoR1.TabIndex = 0;
            this.AlunoR1.TabStop = true;
            this.AlunoR1.Text = "Sim";
            this.AlunoR1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transferidoR2);
            this.groupBox2.Controls.Add(this.trasnferidoR1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(858, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 55);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transferido";
            // 
            // transferidoR2
            // 
            this.transferidoR2.AutoSize = true;
            this.transferidoR2.Location = new System.Drawing.Point(229, 21);
            this.transferidoR2.Name = "transferidoR2";
            this.transferidoR2.Size = new System.Drawing.Size(54, 20);
            this.transferidoR2.TabIndex = 3;
            this.transferidoR2.TabStop = true;
            this.transferidoR2.Text = "Não";
            this.transferidoR2.UseVisualStyleBackColor = true;
            // 
            // trasnferidoR1
            // 
            this.trasnferidoR1.AutoSize = true;
            this.trasnferidoR1.Location = new System.Drawing.Point(139, 21);
            this.trasnferidoR1.Name = "trasnferidoR1";
            this.trasnferidoR1.Size = new System.Drawing.Size(51, 20);
            this.trasnferidoR1.TabIndex = 2;
            this.trasnferidoR1.TabStop = true;
            this.trasnferidoR1.Text = "Sim";
            this.trasnferidoR1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(472, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Observação:";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.RoyalBlue;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Save.Location = new System.Drawing.Point(750, 509);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(206, 56);
            this.Save.TabIndex = 28;
            this.Save.Text = "Salvar";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.RoyalBlue;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.Location = new System.Drawing.Point(977, 509);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(216, 56);
            this.Exit.TabIndex = 29;
            this.Exit.Text = "Fechar";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // obsBox
            // 
            this.obsBox.Location = new System.Drawing.Point(582, 398);
            this.obsBox.Multiline = true;
            this.obsBox.Name = "obsBox";
            this.obsBox.Size = new System.Drawing.Size(611, 84);
            this.obsBox.TabIndex = 31;
            // 
            // pagamentoBox
            // 
            this.pagamentoBox.FormattingEnabled = true;
            this.pagamentoBox.Items.AddRange(new object[] {
            "Á vista em dinheiro",
            "Á vista cartão",
            "Parcelado Cartão",
            "Parcelado Boleto"});
            this.pagamentoBox.Location = new System.Drawing.Point(685, 246);
            this.pagamentoBox.Name = "pagamentoBox";
            this.pagamentoBox.Size = new System.Drawing.Size(219, 24);
            this.pagamentoBox.TabIndex = 32;
            // 
            // mensalidadeBox
            // 
            this.mensalidadeBox.Location = new System.Drawing.Point(683, 199);
            this.mensalidadeBox.Name = "mensalidadeBox";
            this.mensalidadeBox.Size = new System.Drawing.Size(221, 22);
            this.mensalidadeBox.TabIndex = 33;
            // 
            // diciplinasBox
            // 
            this.diciplinasBox.Location = new System.Drawing.Point(134, 358);
            this.diciplinasBox.Multiline = true;
            this.diciplinasBox.Name = "diciplinasBox";
            this.diciplinasBox.Size = new System.Drawing.Size(273, 124);
            this.diciplinasBox.TabIndex = 30;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 584);
            this.Controls.Add(this.mensalidadeBox);
            this.Controls.Add(this.pagamentoBox);
            this.Controls.Add(this.obsBox);
            this.Controls.Add(this.diciplinasBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.cursoBox);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.adressBox);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.boxMatricula);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMat);
            this.Name = "form";
            this.Text = "Cadastro de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.modelBox.ResumeLayout(false);
            this.modelBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox boxMatricula;
        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.ComboBox cursoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton modalidadeR1;
        private System.Windows.Forms.RadioButton modalidadeR2;
        private System.Windows.Forms.GroupBox modelBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AlunoR2;
        private System.Windows.Forms.RadioButton AlunoR1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton transferidoR2;
        private System.Windows.Forms.RadioButton trasnferidoR1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox obsBox;
        private System.Windows.Forms.ComboBox pagamentoBox;
        private System.Windows.Forms.TextBox mensalidadeBox;
        private System.Windows.Forms.TextBox diciplinasBox;
    }
}

