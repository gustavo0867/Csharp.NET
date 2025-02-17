using System; 

class URI {

        public static void Main(string[] args) { 

            
        int a = LerNumero();
        int b= LerNumero();

        Console.WriteLine("A soma é: "+soma(a,b));
        
    

    }

    static int LerNumero (){

        int numeroValidado;
        string? entrada;

        while(true){
            Console.WriteLine("Digite um número: ");
            entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numeroValidado))
                {
                return numeroValidado; // Sai do loop e retorna o valor se for válido
                }
            else
                {
                    Console.WriteLine("Número inválido. Digite novamente."); 
                }

        }

    }



    static int soma(int a, int b){
        int soma= a+b;

        return soma;
    }

}







int[]  teste = new int[5]



string[] testando= {"1"}