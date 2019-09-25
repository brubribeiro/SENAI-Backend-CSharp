using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criacao do documento
                Document exercicioDoc = new Document();                
            #endregion

            #region Criacao de secao no documento
                Section secao1 = exercicioDoc.AddSection();
            #endregion

            #region Criar um paragrafo
                Paragraph titulo = secao1.AddParagraph();
            #endregion

            #region Adiciona texto ao paragrafo
                titulo.AppendText("Exercício resolvido!\n\n");
            #endregion

            #region Formatar paragrafo
                // Através da propriedade HorizontalAlignment, é posível alinhar o parágrafo
                titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

                Paragraph texto1 = secao1.AddParagraph();

                texto1.AppendText("\tFonte Arial Negrito, Itálico e Sublinhado, Tamanho 18\n");

                ParagraphStyle estilo01 = new ParagraphStyle(exercicioDoc);
                estilo01.Name = "Estilo texto1";
                estilo01.CharacterFormat.FontName = "Arial";
                estilo01.CharacterFormat.FontSize = 18;
                estilo01.CharacterFormat.Bold = true;
                estilo01.CharacterFormat.Italic = true;
                estilo01.CharacterFormat.UnderlineStyle = UnderlineStyle.Single; 

                exercicioDoc.Styles.Add(estilo01);

                texto1.ApplyStyle(estilo01.Name);           
                
            #endregion

            #region Salvar arquivo
                // Salva o arquivo em .Docx
                // Utiliza o método SaveToFile para salvar o arquivo no formato desejado
                // Assim como no Word, caso já exista um arquivo com este nome, é substituído.
                exercicioDoc.SaveToFile(@"saida\exercicio_arquivo_word.docx", FileFormat.Docx);
            #endregion
        }
    }
}
