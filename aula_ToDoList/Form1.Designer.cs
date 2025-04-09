namespace aula_ToDoList
{
    partial class Form_Principal
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
            lbl_tarefas = new Label();
            btn_atualizarTarefas = new Button();
            btn_novaTarefa = new Button();
            flp_listaTarefas = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lbl_tarefas
            // 
            lbl_tarefas.AutoSize = true;
            lbl_tarefas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tarefas.Location = new Point(23, 25);
            lbl_tarefas.Name = "lbl_tarefas";
            lbl_tarefas.Size = new Size(122, 21);
            lbl_tarefas.TabIndex = 0;
            lbl_tarefas.Text = "Minhas tarefas";
            // 
            // btn_atualizarTarefas
            // 
            btn_atualizarTarefas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_atualizarTarefas.Location = new Point(563, 26);
            btn_atualizarTarefas.Name = "btn_atualizarTarefas";
            btn_atualizarTarefas.Size = new Size(75, 23);
            btn_atualizarTarefas.TabIndex = 1;
            btn_atualizarTarefas.Text = "Atualizar";
            btn_atualizarTarefas.UseVisualStyleBackColor = true;
            btn_atualizarTarefas.Click += btn_atualizarTarefas_Click;
            // 
            // btn_novaTarefa
            // 
            btn_novaTarefa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_novaTarefa.Location = new Point(644, 26);
            btn_novaTarefa.Name = "btn_novaTarefa";
            btn_novaTarefa.Size = new Size(101, 23);
            btn_novaTarefa.TabIndex = 2;
            btn_novaTarefa.Text = "Nova Tarefa";
            btn_novaTarefa.UseVisualStyleBackColor = true;
            btn_novaTarefa.Click += btn_novaTarefa_Click;
            // 
            // flp_listaTarefas
            // 
            flp_listaTarefas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flp_listaTarefas.AutoScroll = true;
            flp_listaTarefas.BackColor = SystemColors.ControlLightLight;
            flp_listaTarefas.Location = new Point(12, 69);
            flp_listaTarefas.Name = "flp_listaTarefas";
            flp_listaTarefas.Size = new Size(744, 386);
            flp_listaTarefas.TabIndex = 3;
            flp_listaTarefas.Paint += flp_listaTarefas_Paint;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(783, 467);
            Controls.Add(flp_listaTarefas);
            Controls.Add(btn_novaTarefa);
            Controls.Add(btn_atualizarTarefas);
            Controls.Add(lbl_tarefas);
            Name = "Form_Principal";
            Text = "Aula -To-Do-List";
            Load += Form_Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tarefas;
        private Button btn_atualizarTarefas;
        private Button btn_novaTarefa;
        private FlowLayoutPanel flp_listaTarefas;
    }
}
