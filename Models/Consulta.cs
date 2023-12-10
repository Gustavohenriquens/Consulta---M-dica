    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace projeto_1.Models
    {
        public class Consulta
        {      
            private List<string> agendamentoNome = new List<string>();

            Dictionary<string, string> consulta = new Dictionary<string, string>();


            public void AgendarConsulta()
            {
                Console.WriteLine("----- Agendamento de Consulta Médica -----");
                Console.WriteLine("Qual o seu Nome :");
                string nome = Console.ReadLine().ToUpper();

                // Console.WriteLine("Digite sua Idade :");
                // int idade = Convert.ToInt32(Console.ReadLine().ToUpper());

                Console.WriteLine();
                Console.WriteLine("Qual Horário você quer marcar para sua consulta ?");
                string horario = Console.ReadLine().ToUpper();
                
                consulta.Add(nome,horario);
            }


            public void visualiarConsulta()
            {
                if(consulta.Any())
                {
                    Console.WriteLine("----- Consultas marcadas -----");
                    Console.WriteLine();

                    foreach (var item in consulta)
                    {
                        Console.WriteLine($"Nome = {item.Key}, Horário = {item.Value}");
                    }

                    Console.WriteLine();
                }
            }





            public void DesmarcarConsulta()
            {

                Console.WriteLine("----- Lista de Consultas -----");
                Console.WriteLine();

                int cont = 1;
                foreach (var nomes in consulta)
                {
                    Console.WriteLine($"{cont} - {nomes}");
                    cont++;
                }
                Console.WriteLine();
                Console.WriteLine("----- Desmarcar Consulta -----");
                Console.WriteLine();

                Console.WriteLine("Digite seu nome cadastrado para desmarcar consulta :");

                string removeConsulta = Console.ReadLine().ToUpper();
                string nomeDoUsuario = removeConsulta;

                if(consulta.Any())
                {
                consulta.Remove(nomeDoUsuario);
                    Console.WriteLine($" {nomeDoUsuario} foi removido da consulta! ");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse nome não está marcado para consulta. Confira se o nome corretamente");
                }
            }




        public void remarcarConsulta()
{
            if (consulta.Any())
            {
            Console.WriteLine("----- Consultas disponíveis -----");
            Console.WriteLine();

            int cont = 1;
            foreach (var paciente in consulta)
            {
            Console.WriteLine($"{cont} - {paciente}");
            cont++;
            }

            Console.WriteLine();
            Console.WriteLine("Digite o nome do paciente para remarcar a consulta :");
            string nomePaciente = Console.ReadLine().ToUpper();

            if (consulta.ContainsKey(nomePaciente))
            {

            Console.WriteLine();
            Console.WriteLine("Digite um novo nome:");
            string novoNome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite um novo Horário:");
            string novoHorario = Console.ReadLine();

            // Salvar os valores antigos
            string horarioAntigo = consulta[nomePaciente];

            // Remover a entrada antiga
            consulta.Remove(nomePaciente);

            // Adicionar a nova entrada
            consulta.Add(novoNome, novoHorario);

            Console.WriteLine();
            Console.WriteLine($"Consulta de {nomePaciente} mudou o nome para {novoNome} e remarcou sua consulta para ({novoHorario} horas)");
        }
        else
        {
            Console.WriteLine($"ERRO! Consulta para {nomePaciente} não encontrada.");
        }
    }
    else
    {
        Console.WriteLine("ERRO! Não há consultas disponíveis.");
    }
}






        }
    }