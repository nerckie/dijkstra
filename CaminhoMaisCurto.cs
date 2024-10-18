using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca_trabfinal
{
    internal class CaminhoMaisCurto
    {
        // Propriedade para acessar e modificar a lista de nós no caminho mais curto
        public List<Noh> Caminho { get; set; }

        // Propriedade para acessar e modificar a distância total do caminho mais curto
        public int DistanciaTotal { get; set; }

        // Construtor da classe
        public CaminhoMaisCurto()
        {
            // Inicializa a lista de nós no caminho como vazia
            Caminho = new List<Noh>();

            // Inicializa a distância total como zero
            DistanciaTotal = 0;
        }
    }
}
