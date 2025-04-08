using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlaMundo{
    public class Endereco{
        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }
    }

    public class Cliente{
        public string Nome { get; set; }

        public Endereco EnderecoCliente { get; set; }

        public void MostrarDados(){
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Endereço: {EnderecoCliente.Rua}, {EnderecoCliente.Bairro}, {EnderecoCliente.Cidade}");
        }
    }

}