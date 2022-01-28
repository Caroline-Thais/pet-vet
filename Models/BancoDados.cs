using System;
using System.Collections.Generic;

namespace Segunda_Atividade.Models
{
    static public class BancoDados
    {
         private static List<Agendamento> agendamentos = new List<Agendamento>();

         public static void Incluir(Agendamento agendamento)
       {
           agendamentos.Add(agendamento);
       }
       public static List<Agendamento> Listar()
       {
           return agendamentos;
       }
    }
}