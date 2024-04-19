class Program
{
    static void Main(string[] args)
    {
        string carne = "";
        double precoCarne = 0;
        double quantcarne = 0;
        bool pagamentocomcartao = false;

        Console.WriteLine("Promoção de Carnes:");
        Console.WriteLine("Até 5 Kg \t Acima de 5 Kg");
        Console.WriteLine("File Duplo \t R$ 4,90 por Kg \t R$ 5,80 por Kg");
        Console.WriteLine("Alcatra \t R$ 5,90 por Kg \t R$ 6,80 por Kg");
        Console.WriteLine("Picanha \t R$ 6,90 por Kg \t R$ 7,80 por Kg");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine("Digite a carne que deseja comprar:");
        Console.WriteLine("1 - File Duplo");
        Console.WriteLine("2 - Alcatra");
        Console.WriteLine("3 - Picanha");

        int opcaoCarne = int.Parse(Console.ReadLine());

        switch (opcaoCarne)
        {
            case 1:
                carne = "File Duplo";
                precoCarne = 4.90;
                break;
            case 2:
                carne = "Alcatra";
                precoCarne = 5.90;
                break;
            case 3:
                carne = "Picanha";
                precoCarne = 6.90;
                break;
            default:
                Console.WriteLine("Escreva uma opção valida!");
                return;
        }

        Console.WriteLine("Digite quantos KG deseja:");
        quantcarne = double.Parse(Console.ReadLine());

        if (quantcarne <= 5)
        {
            precoCarne *= quantcarne;
        }
        else
        {
            if (carne == "File Duplo")
            {
                precoCarne = 5.80;
                precoCarne *= quantcarne;
            }
            else if (carne == "Alcatra")
            {
                precoCarne = 6.80;
                precoCarne *= quantcarne;
            }
            else if (carne == "Picanha")
            {
                precoCarne = 7.80;
                precoCarne *= quantcarne;
            }
        }

        Console.WriteLine("Pagamento com cartão Tabajara? (S/N)");
        string respostaPagamentoCartao = Console.ReadLine().ToLower();

        if (respostaPagamentoCartao == "s")
        {
            pagamentocomcartao = true;
        }

        double descontoCartao = 0;
        double valorAPagar = precoCarne * quantcarne;
        double valordesc = 0;

        if (pagamentocomcartao == true)
        {
            descontoCartao = (precoCarne * quantcarne * 0.05);
            valorAPagar = ((precoCarne * quantcarne) - descontoCartao) / 100;
            valordesc = (precoCarne - valorAPagar);
        }
        else
        {
            valorAPagar = 0;
        }


        Console.WriteLine("\n ---------------------------- Cupom Fiscal ----------------------------  \n");
        Console.WriteLine("Tipo da carne: {0}", carne);
        Console.WriteLine("Quantidade: {0} kg", quantcarne);
        Console.WriteLine("Preço por Kg: R$ {0}", precoCarne.ToString("F2"));
        Console.WriteLine("Valor do Desconto: R$ {0}", valorAPagar.ToString("F2"));
        Console.WriteLine("-----------------------------------------------------------------------"); 
        Console.WriteLine("Preço Total: R$ {0}", valordesc.ToString("F2"));
        Console.WriteLine("\n ----------------------------------------------------------------------  \n");
    }
}

