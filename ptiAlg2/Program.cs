namespace ptiAlg2;

class Program
{
    static void Main(string[] args)
    {
       Estoque estoque = new Estoque(); 

       int menu = 0;
       do
       {    
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("SISTEMA Del Campo AÇOGUE");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("\nMENU:");
            Console.WriteLine("\n[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");
            menu = Convert.ToInt32(Console.ReadLine());

            int pos = 0;
            int qtd = 0;

            switch(menu)
            {
                case 1:
                    Carne novoProduto = estoque.atribuiAtributosProdutos();
                    estoque.adicionar(novoProduto);
                    break;

                case 2:
                    Console.WriteLine("\nItens no Estoque: ");
                    estoque.listar();
                    break;

                case 3:
                    Console.WriteLine("Posição da Carne: ");
                    pos = Convert.ToInt32(Console.ReadLine());
                    estoque.remover(pos - 1);
                    estoque.listar();
                    break;
                
                case 4:
                    Console.WriteLine("\nItens no Estoque: ");
                    estoque.listar();

                    Console.WriteLine("Posição da Carne: ");
                    pos = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Quantidade de Entrada: ");
                    qtd = Convert.ToInt32(Console.ReadLine());

                    estoque.entrada(pos, qtd);
                    break;
                
                case 5:
                    Console.WriteLine("Posição da carne: ");
                    pos = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Quantidade de Saída: ");
                    qtd = Convert.ToInt32(Console.ReadLine());

                    estoque.saida(pos, qtd);

                    Console.WriteLine($"Estoque Atualizado: {estoque.vizualizaNomeCarne(pos)} {estoque.vizualizaEstoque(pos)}und");
                    break;
            }
       }
       while (menu != 0);

    }

}
