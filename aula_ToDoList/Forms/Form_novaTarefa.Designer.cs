namespace aula_ToDoList.Forms
{
    partial class Form_novaTarefa
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
            lbl_Nome = new Label();
            lbl_descricao = new Label();
            lbl_importacia = new Label();
            txt_nome = new TextBox();
            rtb_descricao = new RichTextBox();
            nud_importacia = new NumericUpDown();
            btn_salvar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_importacia).BeginInit();
            SuspendLayout();
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_Nome.Location = new Point(17, 17);
            lbl_Nome.Margin = new Padding(8);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(59, 21);
            lbl_Nome.TabIndex = 0;
            lbl_Nome.Text = "Nome:";
            // 
            // lbl_descricao
            // 
            lbl_descricao.AutoSize = true;
            lbl_descricao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_descricao.Location = new Point(17, 78);
            lbl_descricao.Margin = new Padding(8);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(85, 21);
            lbl_descricao.TabIndex = 1;
            lbl_descricao.Text = "Descrição:";
            lbl_descricao.Click += label2_Click;
            // 
            // lbl_importacia
            // 
            lbl_importacia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_importacia.AutoSize = true;
            lbl_importacia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_importacia.Location = new Point(388, 78);
            lbl_importacia.Margin = new Padding(8);
            lbl_importacia.Name = "lbl_importacia";
            lbl_importacia.Size = new Size(102, 21);
            lbl_importacia.TabIndex = 2;
            lbl_importacia.Text = "Importância:";
            // 
            // txt_nome
            // 
            txt_nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nome.Location = new Point(82, 14);
            txt_nome.Margin = new Padding(8);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(591, 29);
            txt_nome.TabIndex = 3;
            // 
            // rtb_descricao
            // 
            rtb_descricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_descricao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rtb_descricao.Location = new Point(12, 136);
            rtb_descricao.Margin = new Padding(8);
            rtb_descricao.Name = "rtb_descricao";
            rtb_descricao.Size = new Size(721, 270);
            rtb_descricao.TabIndex = 4;
            rtb_descricao.Text = "";
            // 
            // nud_importacia
            // 
            nud_importacia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nud_importacia.Location = new Point(521, 76);
            nud_importacia.Margin = new Padding(8);
            nud_importacia.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nud_importacia.Name = "nud_importacia";
            nud_importacia.Size = new Size(155, 29);
            nud_importacia.TabIndex = 5;
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_salvar.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salvar.Location = new Point(638, 437);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(95, 32);
            btn_salvar.TabIndex = 6;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // Form_novaTarefa
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(750, 493);
            Controls.Add(btn_salvar);
            Controls.Add(nud_importacia);
            Controls.Add(rtb_descricao);
            Controls.Add(txt_nome);
            Controls.Add(lbl_importacia);
            Controls.Add(lbl_descricao);
            Controls.Add(lbl_Nome);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(4);
            MinimumSize = new Size(640, 400);
            Name = "Form_novaTarefa";
            Text = "Adicionar Tarefa";
            Load += Form_novaTarefa_Load;
            ((System.ComponentModel.ISupportInitialize)nud_importacia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nome;
        private Label lbl_descricao;
        private Label lbl_importacia;
        private TextBox txt_nome;
        private RichTextBox rtb_descricao;
        private NumericUpDown nud_importacia;
        private Button btn_salvar;
    }
}