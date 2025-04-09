namespace aula_ToDoList.Controllers
{
    partial class Bloquinho
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nomeTarefa = new Label();
            lbl_descricao = new Label();
            lbl_prioridade = new Label();
            btn_excluirTarefa = new Button();
            btn_editarTarefa = new Button();
            SuspendLayout();
            // 
            // lbl_nomeTarefa
            // 
            lbl_nomeTarefa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nomeTarefa.AutoEllipsis = true;
            lbl_nomeTarefa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nomeTarefa.Location = new Point(11, 8);
            lbl_nomeTarefa.Margin = new Padding(8);
            lbl_nomeTarefa.Name = "lbl_nomeTarefa";
            lbl_nomeTarefa.Size = new Size(129, 24);
            lbl_nomeTarefa.TabIndex = 0;
            lbl_nomeTarefa.Text = "Nome";
            // 
            // lbl_descricao
            // 
            lbl_descricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_descricao.Location = new Point(8, 40);
            lbl_descricao.Margin = new Padding(8, 0, 8, 8);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(181, 121);
            lbl_descricao.TabIndex = 1;
            lbl_descricao.Text = "...";
            // 
            // lbl_prioridade
            // 
            lbl_prioridade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_prioridade.AutoEllipsis = true;
            lbl_prioridade.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            lbl_prioridade.Location = new Point(8, 168);
            lbl_prioridade.Margin = new Padding(8, 0, 8, 8);
            lbl_prioridade.Name = "lbl_prioridade";
            lbl_prioridade.Size = new Size(181, 24);
            lbl_prioridade.TabIndex = 2;
            lbl_prioridade.Text = "Prioridade:";
            // 
            // btn_excluirTarefa
            // 
            btn_excluirTarefa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_excluirTarefa.Cursor = Cursors.Hand;
            btn_excluirTarefa.FlatAppearance.BorderSize = 0;
            btn_excluirTarefa.FlatStyle = FlatStyle.Flat;
            btn_excluirTarefa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_excluirTarefa.Image = Properties.Resources.trash_21;
            btn_excluirTarefa.Location = new Point(175, 8);
            btn_excluirTarefa.Margin = new Padding(8);
            btn_excluirTarefa.Name = "btn_excluirTarefa";
            btn_excluirTarefa.Size = new Size(24, 24);
            btn_excluirTarefa.TabIndex = 3;
            btn_excluirTarefa.UseVisualStyleBackColor = true;
            btn_excluirTarefa.Click += btn_excluirTarefa_Click;
            // 
            // btn_editarTarefa
            // 
            btn_editarTarefa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editarTarefa.Cursor = Cursors.Hand;
            btn_editarTarefa.FlatAppearance.BorderSize = 0;
            btn_editarTarefa.FlatStyle = FlatStyle.Flat;
            btn_editarTarefa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            btn_editarTarefa.Image = Properties.Resources.square_pen;
            btn_editarTarefa.Location = new Point(143, 8);
            btn_editarTarefa.Margin = new Padding(8, 8, 0, 8);
            btn_editarTarefa.Name = "btn_editarTarefa";
            btn_editarTarefa.Size = new Size(24, 24);
            btn_editarTarefa.TabIndex = 4;
            btn_editarTarefa.UseVisualStyleBackColor = true;
            btn_editarTarefa.Click += btn_editarTarefa_Click;
            // 
            // Bloquinho
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(btn_editarTarefa);
            Controls.Add(btn_excluirTarefa);
            Controls.Add(lbl_prioridade);
            Controls.Add(lbl_descricao);
            Controls.Add(lbl_nomeTarefa);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(4);
            Name = "Bloquinho";
            Size = new Size(200, 200);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_nomeTarefa;
        private Label lbl_descricao;
        private Label lbl_prioridade;
        private Button btn_excluirTarefa;
        private Button btn_editarTarefa;
    }
}
