using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_ToDoList
{
    public class tarefaDTO
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Importancia { get; set; }

        public tarefaDTO(int id, string nome, string descricao, int importancia)
        {
            ID = id;
            Nome = nome;
            Descricao = descricao;
            Importancia = importancia;
        }

        public tarefaDTO(string nome, string descricao, int importancia)
        {
            Nome = nome;
            Descricao = descricao;
            Importancia = importancia;
        }
    }
}
