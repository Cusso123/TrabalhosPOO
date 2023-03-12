 using Arquivos3;

ManipularArquivo arquivo = new ManipularArquivo();
arquivo.EnderecoNomeArquivo = "Caminho do Diretorio do Arquivo txt.";
arquivo.Conteudo = "Conteúdo do arquivo txt.";

bool sucesso = arquivo.SalvarDadoseArquivos();
if (sucesso)
{
    Console.WriteLine("Arquivo txt salvo com sucesso.");
}
else
{
    Console.WriteLine("Erro ao salvar aquivo txt.");
}

string conteudoArquivo = arquivo.PesquisarConteudoArquivo(arquivo.EnderecoNomeArquivo);
if (conteudoArquivo != "")
{
    Console.WriteLine("Arquivo txt encontrado:");
    Console.WriteLine(conteudoArquivo);
}
else
{
    Console.WriteLine("Erro ao pesquisar o arquivo txt.");
}

Console.ReadKey();
