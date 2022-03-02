using System;
using System.Threading;
using static AtivSem02.Generics.Alunos;//referencia a classe Genereics e a lista de Alunos
using static AtivSem02.IBancos;//referencia a interface dentro do projeto



namespace AtivSem02
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region MENU 
            Console.ForegroundColor = ConsoleColor.Yellow;//exibi em amarelo o console
            Console.Write(@" 
  __  __                  
 |  \/  |                 
 | \  / | ___ _ __  _   _ 
 | |\/| |/ _ | '_ \| | | |
 | |  | |  __| | | | |_| |
 |_|  |_|\___|_| |_|\__,_|
                          
                          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nINSIRA O VALOR PARA O PROGRAMA DESEJADO\n[1]PESQUISAR ALUNOS\n[2]TRANSFERIR DINHEIRO ");//decisão de qual programa proseguir
            #endregion
            #region PROGRAMA ALUNOS 
            string option = Console.ReadLine();//variavel para controle de opção
            if (option == "1")//opção para a execução de alunos 
            {
                Console.Clear();//limpa o console após a opção
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(@" 
           _                       
     /\   | |                      
    /  \  | |_   _ _ __   ___  ___ 
   / /\ \ | | | | | '_ \ / _ \/ __|
  / ____ \| | |_| | | | | (_) \__ \
 /_/    \_|_|\__,_|_| |_|\___/|___/
                                   
                                   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nINSIRA UM CÓDIGO PARA QUE SEJA EFETUADA A PESQUISA\nEXEMPLO:X05000 SUBSTITUA O VALOR FINAL ");
                string id = Console.ReadLine();//identificador de alunos

                var aluno = ReturnLinq(id);//retorno do id 
                if (aluno != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ALUNO ENCONTRADO");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Nome: {0}   \n Idade: {1} anos    \n Id aluno: {2}", aluno.Nome, aluno.Idade, aluno.Id); ;//exibição das informaçoes contidas nos Id de cada aluno
                    return;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("ALUNO NÃO ENCONTRADO");

                }
            }
            #endregion
            #region PROGRAMA BANCO
            if (option == "2")//programa banco segunda opção
            {

                Console.Clear();   //limpar tela            
                Console.ForegroundColor = ConsoleColor.Yellow;//exibir em amarelo
                Console.Write(@" 
  ____                        
 |  _ \                       
 | |_) | __ _ _ __   ___ ___  
 |  _ < / _` | '_ \ / __/ _ \ 
 | |_) | (_| | | | | (_| (_) |
 |____/ \__,_|_| |_|\___\___/ 
                              
                              ");

                Nubank nubank = new Nubank();//instancia um banco
                BancoDoBrasil bancoDoBrasil = new BancoDoBrasil();//instancia de um novo banco
               
                
                int escolha;//variavel para controle de escolhas dentro do menu banco
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nINSIRA A SUA OPÇÃO:\n[1] NUBANK PARA BANCO DO BRASIL \n[2] BANCO DO BRASIL PARA NUBANK" );//exibe as opçoes de escolha
                escolha=int.Parse(Console.ReadLine());//conversao e leitura da variavel para o uso no laço
                Console.Clear();//limpa tela



                var sec = 4;//valor inicial de contagem                
                switch (escolha)//estrutura de decisão
                { 

                    case 1://primeira escolha
                        TranferenciaBancaria tranferencia1 = new TranferenciaBancaria(nubank, bancoDoBrasil);//instancia uma nova transferencia passando os banco como parametro
                        tranferencia1.IniciarTranferencia();   //inicar transferencia                    
                        
                        Console.WriteLine("\nDESEJA EXECUTAR A TRANFERENCIA?(S/N)");//decisao que será exibida para a transferir ou não
                        string confirmacao = Convert.ToString(Console.ReadLine()); 
                        if (confirmacao == "S"||confirmacao=="s") //estrutura de decisão                          
                        for (var i = 5 -1; i <= sec; i--)//laço usado para a exibição da contagem
                        {
                            Thread.Sleep(1000);//contador 
                            Console.Write("\rTRANSFERINDO:"+ i);//exibição do contador

                            if (i == 0)//usado para a exibição de "saldo transeferido" quando o contador chegar a 0
                           {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("\rSALDO TRANSFERIDO");//exibição de Saldo transferido
                                Console.ReadLine();
                                Environment.Exit(0);//utilizado para sair e parar quando o contador chegar a 0
                            }
                        }else
                        Console.ForegroundColor = ConsoleColor.Red;//exibe em vermelho
                        Console.WriteLine("TRANSFERÊNCIA NEGADA");//exibição de negação de transferencia
                                          
                            break;//para a escolha/caso
                        

                    case 2://segunda escolha                  
                        TranferenciaBancaria tranferencia4 = new TranferenciaBancaria(bancoDoBrasil, nubank);//instancia uma nova transferencia passando os banco como parametro
                        tranferencia4.IniciarTranferencia();//inicar transferencia   

                        Console.WriteLine("\nDESEJA EXECUTAR A TRANFERENCIA?(S/N)");
                        string confirmacao2 = Convert.ToString(Console.ReadLine());
                        if (confirmacao2 == "S" || confirmacao2 == "s")//estrutura de decisão  
                            for (var i = 5 - 1; i <= sec; i--)//laço usado para a exibição da contagem
                            {

                                Thread.Sleep(1000);//contador 
                                Console.Write("\rTRANSFERINDO:" + i);//exibição do contador
                                if (i == 0)//usado para a exibição de "saldo transeferido" quando o contador chegar a 0
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;//exibe em verde a mensagem "Saldo Transferido"
                                    Console.Write("\rSALDO TRANSFERIDO");//exibição de Saldo transferido
                                    Console.ReadLine();
                                    Environment.Exit(0);//utilizado para sair e parar quando o contador chegar a 0
                                }
                            }
                        else
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("TRANSFERÊNCIA NEGADA");

                              break;//para a escolha/caso                                             
              
                       
                }
                }
                Console.ReadKey();//ler o programa 
             
            }
        }
    #endregion
}
