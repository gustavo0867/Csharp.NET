class Program {


    static void Main(string[] args)
    {
       
        int numberOfExpenses = getNumberOfExpenses();
        double[,] expensesCost = new double[numberOfExpenses,2];
        double totalBruto=0;
        double totalLiquido=0;

        for(int i=0; i<numberOfExpenses;i++)
        {
            for(int j=0; j<2;j++)
            {   
                if(j==0)
                {   
                    Console.WriteLine($"\nDigite o valor bruto do ${i+1}º gasto");
                    expensesCost[i,j] =  getExpenseCostFromUser(); 
                    totalBruto += expensesCost[i,j];
                }else{
                    Console.WriteLine($"Digite o valor líquido do ${i+1}º gasto");
                    expensesCost[i,j] =  getExpenseCostFromUser(); 
                    totalLiquido += expensesCost[i,j];
                }
            
            
            }
        }

        Console.WriteLine($"O total de gastos bruto foi de ${totalBruto} \nE o total de gastos líquido foi de: ${totalLiquido}");

    }

    public static int getNumberOfExpenses()
    {   
        Console.WriteLine("Entre com o número de despesas: ");
        string? entrada = Console.ReadLine();
        int number;

            if(!int.TryParse(entrada, out number)){

                do{
                    Console.WriteLine("Numero invalido Digite novamente");
                    entrada = Console.ReadLine();

            
                }while(!int.TryParse(entrada, out number));

                
            }
        return number;
      
    }

    public static double getExpenseCostFromUser (){

        string? entrada = Console.ReadLine();
        double number;

            if(!double.TryParse(entrada, out number)){

                do{
                    Console.WriteLine("Numero invalido Digite novamente");
                    entrada = Console.ReadLine();

            
                }while(!double.TryParse(entrada, out number));

                
            }
        return number;
      

    }

    

}