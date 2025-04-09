using aula_ToDoList.DAL;
using aula_ToDoList.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_ToDoList.Controllers
{
    public partial class Bloquinho : UserControl
    {
        private int atributoID { get; set; }

        private tarefaDTO tarefaASerEditada { get; set; }

        public Bloquinho()
        {
            InitializeComponent();
        }


        public Bloquinho(tarefaDTO minhaTarefa)
        {
            InitializeComponent();
            atributoID = minhaTarefa.ID;
            lbl_nomeTarefa.Text = minhaTarefa.Nome;
            lbl_descricao.Text = minhaTarefa.Descricao;
            lbl_prioridade.Text += $" {minhaTarefa.Importancia}";
            tarefaASerEditada = minhaTarefa;
        }

        private void btn_excluirTarefa_Click(object sender, EventArgs e)
        {
            tarefaDAL.ExcluirTarefa(atributoID);
        }

        private void btn_editarTarefa_Click(object sender, EventArgs e)
        {
            Form_novaTarefa form_NovaTarefa = new Form_novaTarefa(tarefaASerEditada);
            form_NovaTarefa.ShowDialog();
        }
    }
}
