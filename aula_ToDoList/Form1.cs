using aula_ToDoList.Controllers;
using aula_ToDoList.DAL;
using aula_ToDoList.Forms;

namespace aula_ToDoList
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }

        private void flp_listaTarefas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_atualizarTarefas_Click(object sender, EventArgs e)
        {
            flp_listaTarefas.Controls.Clear();

            foreach (tarefaDTO tarefa in tarefaDAL.ListarTarefas())
            {
                flp_listaTarefas.Controls.Add(
                    new Bloquinho(tarefa)

                );
            }
        }

        private void btn_novaTarefa_Click(object sender, EventArgs e)
        {
            Form_novaTarefa form_novaTarefa = new Form_novaTarefa();
            form_novaTarefa.ShowDialog();
            

        }
    }
}
