using System.Collections.Generic;

namespace Models
{
    public static class BaseDados
{
    private static List<Convidado> dados = new List<Convidado>();

        public static bool  Incluir(Convidado u) {

            foreach (Convidado item in dados)
            {
                if (item.nome == u.nome)
                    return false;
            }
            dados.Add(u);
            return true;
        }


    public static List<Convidado> Listar ()

        {
            return dados;
        }
   }  
}