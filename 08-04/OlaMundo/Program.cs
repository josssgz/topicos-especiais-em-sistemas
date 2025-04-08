using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;
using OlaMundo;

class Program{
    static void Main(string[] args){
        Endereco endereco = new Endereco{
            Rua = "Tralalelo Tralala",
            Bairro = "Ballerina Cappuccina",
            Cidade = "Curitiba"
        };

        Cliente cliente = new Cliente(){
            Nome = "Jairo",
            EnderecoCliente = endereco
        };

        cliente.MostrarDados();
    }
}