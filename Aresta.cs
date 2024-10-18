using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_trabfinal
{
    internal class Aresta
    {
        private Noh origem;
        private Noh destino;
        private int peso;

        // Construtor da classe
        public Aresta(Noh origem, Noh destino, int peso)
        {
            this.origem = origem;
            this.destino = destino;
            this.peso = peso;
        }

        // Propriedade pública para acessar e modificar o peso da aresta
        public int Peso
        {
            get => peso; // Retorna o valor do peso
            set => peso = value; // Define o valor do peso
        }

        // Propriedades internas para acessar e modificar os nós de origem e destino
        internal Noh Origem
        {
            get => origem; // Retorna o nó de origem
            set => origem = value; // Define o nó de origem
        }

        internal Noh Destino
        {
            get => destino; // Retorna o nó de destino
            set => destino = value; // Define o nó de destino
        }
    }
}
