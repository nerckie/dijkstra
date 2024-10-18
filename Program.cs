using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ca_trabfinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo(); //criando grafo
            grafo.addnoh("Douradinhos"); //cidade 0
            grafo.addnoh("Ituiutaba"); //cidade 1
            grafo.addnoh("Capinópolis"); //cidade 2
            grafo.addnoh("Centralina"); //cidade 3
            grafo.addnoh("Itumbiara"); //cidade 4
            grafo.addnoh("Tupaciguara"); //cidade 5
            grafo.addnoh("Monte Alegre de Minas"); //cidade 6
            grafo.addnoh("Uberlândia"); //cidade 7
            grafo.addnoh("Araguari"); //cidade 8
            grafo.addnoh("Cascalho Rico"); //cidade 9
            grafo.addnoh("Grupiara"); //cidade 10
            grafo.addnoh("Estrela do Sul"); //cidade 11
            grafo.addnoh("Romaria"); //cidade 12
            grafo.addnoh("São Juliana"); //cidade 13
            grafo.addnoh("Indianópolis"); //cidade 14

            //criando os nós que representam as cidades

            Noh Douradinhos = grafo.GetNoh(0);
            Noh Ituiutaba = grafo.GetNoh(1);
            Noh Capinópolis = grafo.GetNoh(2);
            Noh Centralina = grafo.GetNoh(3);
            Noh Itumbiara = grafo.GetNoh(4);
            Noh Tupaciguara = grafo.GetNoh(5);
            Noh Monte_Alegre_de_Minas = grafo.GetNoh(6);
            Noh Uberlândia = grafo.GetNoh(7);
            Noh Araguari = grafo.GetNoh(8);
            Noh Cascalho_Rico = grafo.GetNoh(9);
            Noh Grupiara = grafo.GetNoh(10);
            Noh Estrela_do_Sul = grafo.GetNoh(11);
            Noh Romaria = grafo.GetNoh(12);
            Noh São_Juliana = grafo.GetNoh(13);
            Noh Indianópolis = grafo.GetNoh(14);

            //adicionando as arestas de cada cidade

            Douradinhos.addAresta(Ituiutaba, 90);
            Douradinhos.addAresta(Monte_Alegre_de_Minas, 28);
            Douradinhos.addAresta(Uberlândia, 63);

            Ituiutaba.addAresta(Douradinhos, 90);
            Ituiutaba.addAresta(Monte_Alegre_de_Minas, 85);
            Ituiutaba.addAresta(Capinópolis, 30);

            Capinópolis.addAresta(Ituiutaba, 30);
            Capinópolis.addAresta(Centralina, 40);

            Centralina.addAresta(Capinópolis, 40);
            Centralina.addAresta(Monte_Alegre_de_Minas, 75);
            Centralina.addAresta(Itumbiara, 20);

            Itumbiara.addAresta(Centralina, 20);
            Itumbiara.addAresta(Tupaciguara, 55);

            Tupaciguara.addAresta(Itumbiara, 55);
            Tupaciguara.addAresta(Uberlândia, 60);
            Tupaciguara.addAresta(Monte_Alegre_de_Minas, 44);

            Monte_Alegre_de_Minas.addAresta(Douradinhos, 28);
            Monte_Alegre_de_Minas.addAresta(Ituiutaba, 85);
            Monte_Alegre_de_Minas.addAresta(Centralina, 75);
            Monte_Alegre_de_Minas.addAresta(Tupaciguara, 44);
            Monte_Alegre_de_Minas.addAresta(Uberlândia, 60);

            Uberlândia.addAresta(Douradinhos, 63);
            Uberlândia.addAresta(Monte_Alegre_de_Minas, 60);
            Uberlândia.addAresta(Tupaciguara, 60);
            Uberlândia.addAresta(Indianópolis, 45);
            Uberlândia.addAresta(Romaria, 78);
            Uberlândia.addAresta(Araguari, 30);

            Araguari.addAresta(Uberlândia, 30);
            Araguari.addAresta(Estrela_do_Sul, 34);
            Araguari.addAresta(Cascalho_Rico, 28);

            Cascalho_Rico.addAresta(Araguari, 28);
            Cascalho_Rico.addAresta(Grupiara, 32);

            Grupiara.addAresta(Cascalho_Rico, 32);
            Grupiara.addAresta(Estrela_do_Sul, 38);

            Estrela_do_Sul.addAresta(Grupiara, 38);
            Estrela_do_Sul.addAresta(Araguari, 34);
            Estrela_do_Sul.addAresta(Romaria, 27);

            Romaria.addAresta(Estrela_do_Sul, 27);
            Romaria.addAresta(Uberlândia, 78);
            Romaria.addAresta(São_Juliana, 28);

            São_Juliana.addAresta(Romaria, 28);
            São_Juliana.addAresta(Indianópolis, 40);

            Indianópolis.addAresta(São_Juliana, 40);
            Indianópolis.addAresta(Uberlândia, 45);

            //imprimindo as cidades com indices

            grafo.ImprimirNos();
            
            //coletando as opções do usuario

            Console.WriteLine("Escolha a cidade de origem:");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha a cidade de destino:");
            int d = Convert.ToInt32(Console.ReadLine());

            //definindo o noh de origem e destino para usar o dijkstra

            Noh origem = grafo.GetNoh(o); 
            Noh destino = grafo.GetNoh(d);

           
            // chamando a função dijkstra

            CaminhoMaisCurto caminho = grafo.Dijkstra(origem, destino);

            //imprimindo caminho
        
            Console.Write("Caminho de " + origem.Cidade + " a " + destino.Cidade +": ");
            foreach (Noh noh in caminho.Caminho)
            {
                Console.Write(noh.Cidade +" -> ");
            }
            Console.WriteLine("Percorrendo "+ caminho.DistanciaTotal +" KM");
           
        }
    }
}