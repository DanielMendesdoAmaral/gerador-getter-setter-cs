using System;

namespace GERADOR_DE_GETTERS_E_SETTERS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            string[] opcoes = new string[100];

            System.Console.WriteLine("BEM VINDO AO GERADOR DOS MÉTODOS ESPECIAIS GETTERS E SETTERS. INSIRA A SEGUIR OS NOMES DOS ATRIBUTOS. VOCÊ PODE INSERIR QUANTOS VOCÊ QUISER. INSIRA O NÚMERO 1 PARA PARAR DE INSERIR ATRIBUTOS E GERAR OS GETTERS E SETTERS. OS ATRIBUTOS DEVEM SER INSERIDOS COMO NO EXEMPLO: tipo identificador     ou    tipo identificadorCamelCase    . \n");

            for (int i=0; i<opcoes.Length; i++) {
                opcoes[i] = Console.ReadLine();
                opcoes[i] = opcoes[i].Trim();
                if (opcoes[i]=="1") {
                    break;
                }
            }

            Console.Clear();

            for (int i=0; i<100; i++) {
                if (opcoes[i]=="1") {
                    break;
                }
                else {
                    Gerador(opcoes[i]);
                }
            }

            
        }

        static void Gerador(params string[] m) {
            if (m.Length>=1) {
                string primeiraLetraMaiuscula;
                string[] tipoIdentificador;
                string parametro;

                for (int c=0; c<m.Length; c++) {
                    tipoIdentificador = m[c].Split(" ");
                    primeiraLetraMaiuscula = char.ToUpper(tipoIdentificador[1][0]) + tipoIdentificador[1].Substring(1);
                    parametro = tipoIdentificador[1].Substring(0, 1);

                    System.Console.WriteLine("        public " + tipoIdentificador[0] + " Get" + primeiraLetraMaiuscula + "() {\n            return " + tipoIdentificador[1] + "; \n        }");
                    System.Console.WriteLine("        public void Set" + primeiraLetraMaiuscula + "(" + tipoIdentificador[0] + " " + parametro + ") {\n            " + tipoIdentificador[1] + "=" + parametro + ";\n        }");
                }
            }
        }
    }
}