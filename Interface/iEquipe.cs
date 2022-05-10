using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Interface
{
    public interface iEquipe
    {
        // Contrato
        // Representa os métodos que são obrigatórios para uma classe

        void Criar(Equipe novaequipe);
        List<Equipe> LerEquipes();
    }
}
