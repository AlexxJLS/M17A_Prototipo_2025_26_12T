namespace M17A_Prototipo_2025_26_12T.Emprestimo
{
    partial class F_Emprestimo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_emprestar = new System.Windows.Forms.Button();
            this.cb_livro = new System.Windows.Forms.ComboBox();
            this.cb_leitor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Leitor";
            // 
            // bt_emprestar
            // 
            this.bt_emprestar.Location = new System.Drawing.Point(214, 214);
            this.bt_emprestar.Name = "bt_emprestar";
            this.bt_emprestar.Size = new System.Drawing.Size(332, 67);
            this.bt_emprestar.TabIndex = 4;
            this.bt_emprestar.Text = "Emprestar";
            this.bt_emprestar.UseVisualStyleBackColor = true;
            this.bt_emprestar.Click += new System.EventHandler(this.bt_emprestar_Click);
            // 
            // cb_livro
            // 
            this.cb_livro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_livro.FormattingEnabled = true;
            this.cb_livro.Location = new System.Drawing.Point(214, 106);
            this.cb_livro.Name = "cb_livro";
            this.cb_livro.Size = new System.Drawing.Size(332, 24);
            this.cb_livro.TabIndex = 5;
            // 
            // cb_leitor
            // 
            this.cb_leitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_leitor.FormattingEnabled = true;
            this.cb_leitor.Location = new System.Drawing.Point(214, 157);
            this.cb_leitor.Name = "cb_leitor";
            this.cb_leitor.Size = new System.Drawing.Size(332, 24);
            this.cb_leitor.TabIndex = 6;
            // 
            // F_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_leitor);
            this.Controls.Add(this.cb_livro);
            this.Controls.Add(this.bt_emprestar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Emprestimo";
            this.Text = "F_Emprestimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_emprestar;
        private System.Windows.Forms.ComboBox cb_livro;
        private System.Windows.Forms.ComboBox cb_leitor;
    }
}