using System;

namespace ProjetoModeloDDD.Dominio.Entidade
{
    class Cliente
    {
        public int ClienteID { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public bool ClienteExpecial(Cliente cliente)
        {
            //verifica se cliente ta ativo, e que tenha mais de 5 anos de cadastro
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }

    }
}
