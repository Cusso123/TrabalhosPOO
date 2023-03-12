using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos3
{
    internal class ManipularArquivo
    {
        public string Conteudo;
        public string EnderecoNomeArquivo;

        public bool SalvarDadoseArquivos() 
        {
            try
            {
                File.WriteAllText(EnderecoNomeArquivo, Conteudo);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string PesquisarConteudoArquivo(string endereco)
        {
            try
            {
                return File.ReadAllText(endereco);
            } catch
            {
                return "";
            }
        }
    }
}
