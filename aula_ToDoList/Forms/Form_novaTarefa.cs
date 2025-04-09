using aula_ToDoList.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_ToDoList.Forms
{
    public partial class Form_novaTarefa : Form
    {

        private tarefaDTO tarefaEditada { get; set; }
        private bool modoEditar { get; set; }
        public Form_novaTarefa()
        {
            InitializeComponent();
            modoEditar = false;
        }


        public Form_novaTarefa(tarefaDTO tarefaASerEditada)
        {
            InitializeComponent();
            this.Text = "Editar Tarefa";
            txt_nome.Text = tarefaASerEditada.Nome;
            rtb_descricao.Text = tarefaASerEditada.Descricao;
            nud_importacia.Value = tarefaASerEditada.Importancia;
            tarefaEditada = tarefaASerEditada;
            modoEditar = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void funcao_editar()
        {
            tarefaDAL.EditarTarefa(
                new tarefaDTO(
                        tarefaEditada.ID,
                        txt_nome.Text,
                        rtb_descricao.Text,
                        (int)nud_importacia.Value



                 )
             );

            MessageBox.Show(

                "Tarefa editada com sucesso",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void funcao_salvar()
        {
            tarefaDAL.AdicionarTarefa(

                txt_nome.Text,
                rtb_descricao.Text,
                Convert.ToInt32(nud_importacia.Value)

            );

            MessageBox.Show(

                "Tarefa adicionada!",
                "Atenção!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (modoEditar == true)
            {
                funcao_editar();
            }
            else
            {
                funcao_salvar();
            }



            //this.Close();
        }

        private void Form_novaTarefa_Load(object sender, EventArgs e)
        {

        }
    }
}
