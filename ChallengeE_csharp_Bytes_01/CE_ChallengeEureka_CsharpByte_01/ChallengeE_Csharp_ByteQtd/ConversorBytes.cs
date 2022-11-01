using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeE_Csharp_ByteQtd
{
    public class ConversorBytes
    {
        int valor;
        int count;
        public int getQuantidade(string[] valores)
        {
            
            //implemente aqui

            for (int i = 0; i < valores.Length; i++)
            {
                try
                {
                    valor = Convert.ToInt32(valores[i]);
                    if (valor <= 255)
                    {
                        count++;
                    }
                }
                catch (Exception)
                {

                }
                
            }
            return count;
        }

        public int getQuantidadeFormato(string[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                try
                {
                    valor = Convert.ToInt32(valores[i]);
                }
                catch (Exception)
                {
                    count++;
                }
                
            }
            return count;
        }
        public int getQuantidadeForaDaFaixa(string[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                try
                {
                    valor = Convert.ToInt32(valores[i]);
                    if (valor > 255)
                    {
                        count++;
                    }
                }
                catch (Exception)
                {
                   
                }
                
            }
            return count;
        }
    }
}
