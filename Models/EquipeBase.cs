using System.IO;

namespace WebApplication2.Models
{
    public class EquipeBase
    {
        public void CriarPastaOuArquivo(string caminho)
        {
            // "nome da pasta/nome do arquivo.csv"
            string pasta = caminho.Split('/')[0];

            // se o diretório não existir, fazer a criação
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }
    }
}
