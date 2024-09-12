public class Estoque
{
    Carne[] carnes = new Carne[0];

    public void adicionar (Carne carne)
    {
        Carne[] novoVetor = new Carne[carnes.Length + 1];
        for (int pos = 0; pos < carnes.Length; pos++)
        {
            Carne item = carnes [pos];
            novoVetor[pos] = item;
        }
        novoVetor [novoVetor.Length - 1] = carne;

        carnes = novoVetor;

    }
    public void listar()
    {
        int cont = 1;
        foreach (Carne item in carnes)
        {
            Console.WriteLine($"{cont}. {item.nome} (R${item.preco}) - {item.estoque} no estoque");
            cont ++;
        }   
    }
    public void entrada(int pos, int qtd)
    {
        Carne carne = carnes[pos - 1];
        carne.estoque += qtd;
        
    } 
    public void saida(int pos, int qtd)
    {
       Carne carne = carnes[pos - 1];
       carne.estoque -= qtd; 
    }
    public void remover(int pos)
    {
        var lista = carnes.ToList();
        lista.RemoveAt(pos);
        carnes = lista.ToArray();   
    }
    public Carne vizualizaProduto(int pos)
    {
        Carne carne = carnes[pos - 1];
        return carne;
    }
    public string vizualizaNomeCarne(int pos)
    {
        Carne carne = carnes[pos - 1];
        string nome = carne.nome;
        return nome;
    }
    public int vizualizaEstoque(int pos)
    {
        Carne carne = carnes [pos - 1];
        return carne.estoque;
    }
        public Carne atribuiAtributosProdutos()
    {
        Carne novoCorte = new Carne();
                
                Console.WriteLine("Nome do corte: ");
                novoCorte.nome = Console.ReadLine();

                Console.WriteLine("Preço: ");
                novoCorte.preco = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Raça do boi: ");
                novoCorte.tipoBoi = Console.ReadLine();

                Console.WriteLine("Validade:");
                novoCorte.validade = Console.ReadLine();

                Console.WriteLine("SIF: ");
                novoCorte.sif = Convert.ToInt32(Console.ReadLine());
                
                return novoCorte;

    }
}