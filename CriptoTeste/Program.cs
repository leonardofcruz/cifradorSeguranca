using Criptografia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagemOriginal = "A sua missão é interceptar o objetivo!";
            string chave = "sincero";
            string chave2 = "SINCERO";
            string mensagemCifrada = "";
            string mensagemDecifrada = "";

            Biblioteca compCifra = new ComportamentoCriptografia();
            Biblioteca compDecifra = new ComportamentoDescriptografia();



            Biblioteca bib;
            if (cifra == 0)
            {
                bib = new Models.Biblioteca(CryptProvider.DES);

            }
            else
            {
                bib = new Models.Biblioteca(CryptProvider.Rijndael);
            }
            string _retorno = "";
            bib.Key = this.chave;
            if (operacao == 0)
            {
                _retorno = bib.Encrypt(textoOriginal);
            }
            else if (operacao == 1)
            {
                _retorno = bib.Decrypt(textoOriginal);
            }
            else
            {
                _retorno = "";
            }
            return _retorno;


            mensagemCifrada = compCifra.Cripto(mensagemOriginal.ToUpper(), chave, false);

            mensagemDecifrada = compDecifra.Cripto(mensagemCifrada, chave2, false);

            Console.WriteLine("Mensagem Original: {0}",mensagemOriginal);
            Console.WriteLine("Chave: {0}", chave);
            Console.WriteLine("Mensagem Cifrada: {0}", mensagemCifrada);
            Console.WriteLine("Mensagem Decifrada: {0}", mensagemDecifrada);



        }
    }
}
