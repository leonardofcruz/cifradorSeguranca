using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Criptografia.Models
{
    public class Cifra 
    {
        public string textoOriginal { get; set; }
        public string chave { get; set; }
        public int cifra { get; set; }
        public int operacao { get; set; }

        public string textoModificado
        {
            get
            {
                Biblioteca bib;
                if (cifra == 0 )
                {
                    bib = new Models.Biblioteca(CryptProvider.DES);

                } else 
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
            }

            set { }

        }

        public bool Validado()
        {
            bool _retorna = true;

            Biblioteca bib = new Biblioteca();
            if (!bib.Valida(this.textoOriginal, this.chave))
            {
                _retorna = false;
            }

            return _retorna;
        }

    }
}