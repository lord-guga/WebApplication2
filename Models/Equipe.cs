using System.Collections.Generic;
using System.IO;
using WebApplication2.Interface;

namespace WebApplication2.Models
{
    public class Equipe : EquipeBase, iEquipe
    {
        // Herança usa-se 2 pontos :
        // Contrato da classe com a interface usa a vírgula ,
        public int IDEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        // variável de dados
        private const string caminhobd = "Database/equipe.csv";

        // Construtor
        public Equipe()
        {
            // método da classe de Herança EquipeBase
            CriarPastaOuArquivo(caminhobd);
        }

        // criar uma função que vai receber o objeto EQUIPE e retorna em csv.
        private string Preparar(Equipe e)
        {
            // Outro jeito: return $"{e.IDEquipe};{e.Nome};{e.Imagem}"
            return e.IDEquipe + ";" + e.Nome + ";" + e.Imagem;
        }

        public void Criar(Equipe novaequipe)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();

            // ler todas as linhas do arquivo csv. e armazenar em um array
            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                // 1; nome da equipe; caminho da imagem
                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.IDEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);
            }

            return listaEquipes;
        }
    }
}
