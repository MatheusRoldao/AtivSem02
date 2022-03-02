using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class InjDep
    {
    }
    public interface IBancos//instanciamento da interface Bancos
        {        
        
            public void GetDouble(double X);//metodo que pega um double passando outro double como parametro

            public double ReturnDouble();//metodo que retorna um double
        }
    #region classe do banco NUBANK
    public class  Nubank: IBancos//instanciando Nubank herdando as propriedades da interface
        {
            private double InicialSaldo = 12000.00;//saldo inicial 
            public double AtualSaldo { get; set; }//propriedade que pegara e mostrará p saldo atual

            public Nubank()
            {
            AtualSaldo =InicialSaldo;//autal saldo irá receber o saldo inicial
            }

            public void GetDouble(double X)//metodo para pegar doubleS
            {
            AtualSaldo += X;//adicionará 
                Console.WriteLine("NOVO SALDO BANCO NUBANK APÓS A TRANSFERENCIA BANCÁRIA: R$" + AtualSaldo);//exibição 
            }

            public double ReturnDouble()//metodo usado para retornar um double
            {
            Console.Write("INSIRA O VALOR PARA SER TRANSFERIDO:");//exibição do valor que deve ser retirado da conta 
            float retirada = float.Parse(Console.ReadLine());//converção da variavel
            Console.WriteLine("SALDO ATUAL DE NUBANK: R${0} \nVALOR A SER TRANSFERIDO: R${1} ", AtualSaldo, retirada);//exibição das informaçoes
            Console.WriteLine("================================================================================================");
            AtualSaldo -= retirada;//removerá o valor informado pelo usuario
                return retirada;//retorna o valor retirado
            }
        }
    #endregion
    #region Classe do Banco Banco Do Brasil
    public class BancoDoBrasil : IBancos//instanciamento do Banco do Brasil herdando as propriedades da interface Bancos
        {
            private double InicialSaldo = 15000.00;//saldo inicial
            public double AtualSaldo { get; set; }//propriedade que pegara o saldo 

            public BancoDoBrasil()
            {
            AtualSaldo = InicialSaldo;//saldo atual irá receber o saldo incial
            }

            public void GetDouble(double X)
            {
            AtualSaldo += X;//adicionará 
           
            Console.WriteLine("NOVO SALDO BANCO DO BRASIL APÓS A TRANSFERENCIA BANCÁRIA: R$" + AtualSaldo);//exibie o saldo atual da conta
            }

            public double ReturnDouble()
            {
            Console.Write("INSIRA O VALOR PARA SER TRANSFERIDO:");//exibe o valor que deve ser retirado pelo usuario
               float retirada = float.Parse(Console.ReadLine());  //conversao e leitura da variavel
                Console.WriteLine("SALDO ATUAL DE BANCO DO BRASIL: R${0} \nVALOR A SER TRANSFERIDO: R${1}", AtualSaldo, retirada);
            Console.WriteLine("================================================================================================");
            AtualSaldo -= retirada;
                return retirada;
            }
        }
    #endregion
    #region Classes criadas para as transferencias Bancarias
    public class TranferenciaBancaria
        {
            private IBancos BancoTira;
            private IBancos BancoPega;

            public TranferenciaBancaria()//construtor colocado em sobrecarga
            {

            }

            public TranferenciaBancaria(IBancos bancoTira, IBancos bancoPega)//metodo que irá adicionar as propriedades passadas como parametro
            {
                this.BancoTira = bancoTira;
                this.BancoPega = bancoPega;
            }

            public void IniciarTranferencia()//metodo que irá iniciar a transferencia
            {
                double valor = BancoTira.ReturnDouble();
                BancoPega.GetDouble(valor);
            }

        }

    }
#endregion
