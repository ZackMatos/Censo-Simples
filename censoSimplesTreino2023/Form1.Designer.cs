namespace censoSimplesTreino2023
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.cb_civil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.lb_pessoas = new System.Windows.Forms.Label();
            this.lb_maioridade = new System.Windows.Forms.Label();
            this.lb_solteiro = new System.Windows.Forms.Label();
            this.lb_casado = new System.Windows.Forms.Label();
            this.lb_masculino = new System.Windows.Forms.Label();
            this.lb_feminino = new System.Windows.Forms.Label();
            this.lb_experiente = new System.Windows.Forms.Label();
            this.lb_menoresIdade = new System.Windows.Forms.Label();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cadastrar.Location = new System.Drawing.Point(30, 291);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(200, 44);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(167, 16);
            this.tb_nome.MaxLength = 20;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(140, 20);
            this.tb_nome.TabIndex = 1;
            this.tb_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite sua idade:";
            // 
            // tb_idade
            // 
            this.tb_idade.Location = new System.Drawing.Point(167, 42);
            this.tb_idade.MaxLength = 3;
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(140, 20);
            this.tb_idade.TabIndex = 4;
            this.tb_idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_idade_KeyPress);
            // 
            // cb_civil
            // 
            this.cb_civil.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_civil.FormattingEnabled = true;
            this.cb_civil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado"});
            this.cb_civil.Location = new System.Drawing.Point(167, 71);
            this.cb_civil.Name = "cb_civil";
            this.cb_civil.Size = new System.Drawing.Size(140, 21);
            this.cb_civil.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado cívil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selecione seu sexo:";
            // 
            // cb_sexo
            // 
            this.cb_sexo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_sexo.Location = new System.Drawing.Point(167, 102);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(140, 21);
            this.cb_sexo.TabIndex = 8;
            // 
            // lb_pessoas
            // 
            this.lb_pessoas.AutoSize = true;
            this.lb_pessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pessoas.Location = new System.Drawing.Point(596, 16);
            this.lb_pessoas.Name = "lb_pessoas";
            this.lb_pessoas.Size = new System.Drawing.Size(169, 20);
            this.lb_pessoas.TabIndex = 9;
            this.lb_pessoas.Text = "Pessoas Cadastradas:";
            this.lb_pessoas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_maioridade
            // 
            this.lb_maioridade.AutoSize = true;
            this.lb_maioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maioridade.Location = new System.Drawing.Point(596, 42);
            this.lb_maioridade.Name = "lb_maioridade";
            this.lb_maioridade.Size = new System.Drawing.Size(134, 20);
            this.lb_maioridade.TabIndex = 10;
            this.lb_maioridade.Text = "Maiores de idade:";
            // 
            // lb_solteiro
            // 
            this.lb_solteiro.AutoSize = true;
            this.lb_solteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_solteiro.Location = new System.Drawing.Point(596, 100);
            this.lb_solteiro.Name = "lb_solteiro";
            this.lb_solteiro.Size = new System.Drawing.Size(75, 20);
            this.lb_solteiro.TabIndex = 11;
            this.lb_solteiro.Text = "Solteiros:";
            // 
            // lb_casado
            // 
            this.lb_casado.AutoSize = true;
            this.lb_casado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_casado.Location = new System.Drawing.Point(596, 130);
            this.lb_casado.Name = "lb_casado";
            this.lb_casado.Size = new System.Drawing.Size(76, 20);
            this.lb_casado.TabIndex = 12;
            this.lb_casado.Text = "Casados:";
            // 
            // lb_masculino
            // 
            this.lb_masculino.AutoSize = true;
            this.lb_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masculino.Location = new System.Drawing.Point(596, 159);
            this.lb_masculino.Name = "lb_masculino";
            this.lb_masculino.Size = new System.Drawing.Size(84, 20);
            this.lb_masculino.TabIndex = 13;
            this.lb_masculino.Text = "Masculino:";
            // 
            // lb_feminino
            // 
            this.lb_feminino.AutoSize = true;
            this.lb_feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_feminino.Location = new System.Drawing.Point(596, 188);
            this.lb_feminino.Name = "lb_feminino";
            this.lb_feminino.Size = new System.Drawing.Size(78, 20);
            this.lb_feminino.TabIndex = 14;
            this.lb_feminino.Text = "Feminino:";
            // 
            // lb_experiente
            // 
            this.lb_experiente.AutoSize = true;
            this.lb_experiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_experiente.ForeColor = System.Drawing.Color.Teal;
            this.lb_experiente.Location = new System.Drawing.Point(11, 254);
            this.lb_experiente.Name = "lb_experiente";
            this.lb_experiente.Size = new System.Drawing.Size(0, 16);
            this.lb_experiente.TabIndex = 15;
            // 
            // lb_menoresIdade
            // 
            this.lb_menoresIdade.AutoSize = true;
            this.lb_menoresIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menoresIdade.Location = new System.Drawing.Point(596, 72);
            this.lb_menoresIdade.Name = "lb_menoresIdade";
            this.lb_menoresIdade.Size = new System.Drawing.Size(140, 20);
            this.lb_menoresIdade.TabIndex = 16;
            this.lb_menoresIdade.Text = "Menores de idade:";
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bt_limpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_limpar.Location = new System.Drawing.Point(582, 291);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(200, 44);
            this.bt_limpar.TabIndex = 17;
            this.bt_limpar.Text = "LIMPAR";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 347);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.lb_menoresIdade);
            this.Controls.Add(this.lb_experiente);
            this.Controls.Add(this.lb_feminino);
            this.Controls.Add(this.lb_masculino);
            this.Controls.Add(this.lb_casado);
            this.Controls.Add(this.lb_solteiro);
            this.Controls.Add(this.lb_maioridade);
            this.Controls.Add(this.lb_pessoas);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_civil);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.btn_cadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.ComboBox cb_civil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Label lb_pessoas;
        private System.Windows.Forms.Label lb_maioridade;
        private System.Windows.Forms.Label lb_solteiro;
        private System.Windows.Forms.Label lb_casado;
        private System.Windows.Forms.Label lb_masculino;
        private System.Windows.Forms.Label lb_feminino;
        private System.Windows.Forms.Label lb_experiente;
        private System.Windows.Forms.Label lb_menoresIdade;
        private System.Windows.Forms.Button bt_limpar;
    }
}

