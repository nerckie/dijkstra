using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_trabfinal
{
    internal class Grafo
    {
        private List<Noh> nos;

        // Construtor da classe Grafo
        public Grafo()
        {

            nos = new List<Noh>();
        }

        // Método para adicionar um nó (cidade) ao grafo
        public void addnoh(string noh)
        {
            nos.Add(new Noh(noh));
        }

        // Método para imprimir todos os nós (cidades) no grafo com seus índices
        public void ImprimirNos()
        {
            for (int i = 0; i < nos.Count; i++)
            {
                Noh noh = nos[i];
                Console.WriteLine(noh.Cidade + " " + "[" + i + "]");
            }
        }

        // Método para obter um nó com base em seu índice
        public Noh GetNoh(int index)
        {
            
            if (index >= 0 && index < nos.Count)
            {
                return nos[index];
            }
            return null; // Retorna null se o índice estiver fora do intervalo
        }

        // Dijkstra
        public CaminhoMaisCurto Dijkstra(Noh origem, Noh destino)
        {

            // Dicionário para armazenar a distância mínima até cada cidade a partir da cidade de origem
            Dictionary<Noh, int> distancia = new Dictionary<Noh, int>();

            // Dicionário para armazenar os nós anteriores (cidades anteriores no caminho mais curto)
            Dictionary<Noh, Noh> anteriores = new Dictionary<Noh, Noh>();

            // Lista de nós não visitados
            List<Noh> nosNaoVisitados = new List<Noh>();

            // Inicialização das distâncias com "infinito" e anteriores como nulo para todas as cidades
            foreach (Noh noh in nos)
            {
                distancia[noh] = int.MaxValue;
                anteriores[noh] = null;
                nosNaoVisitados.Add(noh);
            }

            // A distância da cidade de origem para ela mesma é 0
            distancia[origem] = 0;

            // Algoritmo de Dijkstra para encontrar o caminho mais curto
            while (nosNaoVisitados.Count > 0)
            {
                // Seleciona o nó não visitado com a menor distância
                Noh nohAtual = nosNaoVisitados.OrderBy(n => distancia[n]).First();

                // Se o nó atual for igual ao destino, encerra a busca
                if (nohAtual == destino)
                    break;

                nosNaoVisitados.Remove(nohAtual);

                // Atualiza as distâncias tentativas através das arestas e cidades anteriores
                foreach (Aresta aresta in nohAtual.Arestas)
                {
                    int distanciaTentativa = distancia[nohAtual] + aresta.Peso;

                    if (distanciaTentativa < distancia[aresta.Destino])
                    {
                        distancia[aresta.Destino] = distanciaTentativa;
                        anteriores[aresta.Destino] = nohAtual;
                    }
                }
            }

            // Verifica se foi encontrado um caminho para o destino
            if (distancia[destino] == int.MaxValue)
                return null; // Não foi possível encontrar um caminho

            // Constrói o caminho mais curto a partir dos anteriores
            CaminhoMaisCurto caminhoMaisCurto = new CaminhoMaisCurto();
            Noh nohAtualCaminho = destino;

            // Percorre o caminho reversamente, do destino até a origem
            while (nohAtualCaminho != null)
            {
                caminhoMaisCurto.Caminho.Insert(0, nohAtualCaminho);
                nohAtualCaminho = anteriores[nohAtualCaminho];
            }

            // Define a distância total do caminho encontrado
            caminhoMaisCurto.DistanciaTotal = distancia[destino];

            return caminhoMaisCurto; // Retorna o caminho mais curto encontrado
        }
    }

}