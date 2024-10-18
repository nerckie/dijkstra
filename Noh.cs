using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_trabfinal
{
    internal class Noh
    {
        // Atributos da classe Noh
        private string cidade;
        private List<Aresta> arestas;

        // Construtores
        public Noh(string cidade)
        {
            this.cidade = cidade;
            this.arestas = new List<Aresta>();
        }

        // Propriedades para acessar e modificar o nome da cidade do nó
        public string Cidade
        {
            get => cidade; // Retorna o nome da cidade
            set => cidade = value; // Define o nome da cidade
        }

        // Propriedade interna para acessar e modificar a lista de arestas do nó
        internal List<Aresta> Arestas
        {
            get => arestas; // Retorna a lista de arestas
            set => arestas = value; // Define a lista de arestas
        }

        // Método para adicionar uma nova aresta a partir deste nó
        public void addAresta(Noh destino, int peso)
        {
            arestas.Add(new Aresta(this, destino, peso));
        }
    }
}
