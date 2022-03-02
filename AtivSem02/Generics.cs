using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    public  class Generics
    {
        public class Alunos
        {   //propriedades com seus respectivos metodos get/set
            public byte Idade { get; set; }
            public string Nome { get; set; }
            public string Id { get; set; }
            #region Lista com Alunos
            public static List<Alunos> ReturnAlunos()//metodo que passa uma lista
            {
                List<Alunos> ListaAlunos = new List<Alunos>();//instancia uma nova lista
                Alunos aluno01 = new Alunos();//essas são as instancias de 10 alunos 
                Alunos aluno02 = new Alunos();
                Alunos aluno03 = new Alunos();
                Alunos aluno04 = new Alunos();
                Alunos aluno05 = new Alunos();
                Alunos aluno06 = new Alunos();
                Alunos aluno07 = new Alunos();
                Alunos aluno08 = new Alunos();
                Alunos aluno09 = new Alunos();
                Alunos aluno10 = new Alunos();

                aluno01.Nome = "Matheus Santos";//informaçoes do aluno1
                aluno01.Idade = 21;
                aluno01.Id = "X05001";

                ListaAlunos.Add(aluno01);//adiciona na lista passando qual aluno como parametro

                aluno02.Nome = "Barbara Rosa";
                aluno02.Idade = 15;
                aluno02.Id = "X05002";

                ListaAlunos.Add(aluno02);

                aluno03.Nome = "Junior Mattos";
                aluno03.Idade = 19;
                aluno03.Id = "X05003";

                ListaAlunos.Add(aluno03);

                aluno04.Nome = "luiz Eduardo";
                aluno04.Idade = 33;
                aluno04.Id = "X05004";

                ListaAlunos.Add(aluno04);

                aluno05.Nome = "kaique Nardini";
                aluno05.Idade = 44;
                aluno05.Id = "X05005";

                ListaAlunos.Add(aluno05);

                aluno06.Nome = "Bruna Freitas";
                aluno06.Idade = 32;
                aluno06.Id = "X05006";

                ListaAlunos.Add(aluno06);

                aluno07.Nome = "Rauani Rosa";
                aluno07.Idade = 53;
                aluno07.Id = "X05007";

                ListaAlunos.Add(aluno07);

                aluno08.Nome = "Otavio Chaves";
                aluno08.Idade = 25;
                aluno08.Id = "X05008";

                ListaAlunos.Add(aluno08);
                

                aluno09.Nome = "Paula Silva";
                aluno09.Idade = 35;
                aluno09.Id = "X05009";

                ListaAlunos.Add(aluno09);
              

                aluno10.Nome = "Rogerio Dias";
                aluno10.Idade = 14;
                aluno10.Id = "X05010";

                ListaAlunos.Add(aluno10);
                return ListaAlunos;//retorna a lista de alunos após a injeção das informaçoes respectivamente
            }

            public static Alunos ReturnLinq(string id)//metodo Alunos que passa o Id de cada aluno como parametro
            {
                Alunos aluno = new Alunos();
                try//tratamento de erro
                {
                    var listaDeAlunos = ReturnAlunos();
                    aluno = listaDeAlunos.Find(i => i.Id == id);//encontra os alunos com seus respectivos ID
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;//exibiçao em amarelo 
                    Console.WriteLine("Lista não encontrada");//exibe caso naão seja encontrado o aluno
                }
                return aluno;//retorna aluno

            }
            #endregion
        }

    }
}
