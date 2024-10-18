//internal class Grafo
//{
//    private List<Noh> nos;

//    public Grafo()
//    {
//        nos = new List<Noh>();
//    }

//    public void addnoh(string noh)
//    {
//        nos.Add(new Noh(noh));
//    }
//    public void ImprimirNos()
//    {
//        foreach (Noh noh in nos)
//        {
//            Console.WriteLine(noh.Cidade);
//        }

//    }
//    public Noh GetNoh(int index)
//    {
//        if (index >= 0 && index < nos.Count)
//        {
//            return nos[index];
//        }
//        return null;
//    }
//}
//internal class Noh
//{
//    //atribbutos da classe noh

//    private string cidade;
//    private List<Aresta> arestas;

//    //construtores

//    public Noh(string cidade)
//    {
//        this.cidade = cidade;
//        this.arestas = new List<Aresta>();
//    }

//    //get and set 
//    public string Cidade { get => cidade; set => cidade = value; }
//    internal List<Aresta> Arestas { get => arestas; set => arestas = value; }

//    //métodos

//    public void addAresta(Noh destino, int peso)
//    {
//        arestas.Add(new Aresta(this, destino, peso));
//    }

//}
//internal class Aresta
//{
//    private Noh origem;
//    private Noh destino;
//    private int peso;

//    public Aresta(Noh origem, Noh destino, int peso)
//    {
//        this.origem = origem;
//        this.destino = destino;
//        this.peso = peso;
//    }

//    public int Peso { get => peso; set => peso = value; }
//    internal Noh Origem { get => origem; set => origem = value; }
//    internal Noh Destino { get => destino; set => destino = value; }
//}
