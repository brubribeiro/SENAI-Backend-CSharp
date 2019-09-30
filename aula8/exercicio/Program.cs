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

            #region Adicionar uma tabela
                // Adiciona uma tabela à seção secaoCorpo
                Table tabela = secao1.AddTable(true);

                // Cria o cabeçalho da tabela
                String[] cabecalho = {"Nome","Descrição","Fornecedor","Preço"};

                // Cria os dados da tabela
                String[][] dados = {
                    new String[]{"Marmita 1","Vegetal muito nutritivo","1","R$ 10,00",},
                    new String[]{"Marmita 2","Vegetal muito consumido","1","R$ 11,00"},
                    new String[]{"Marmita 3","Vegetal utilizado","1","R$ 12,00"},
                };

                // Adiciona as células na tabela
                tabela.ResetCells(dados.Length + 1, cabecalho.Length);

                // Adiciona uma linha na posição [0] do vetor de linhas
                TableRow Linha1 = tabela.Rows[0];
                // Define que esta linha é o cabeçalho
                Linha1.IsHeader = true;

                // Define a altura da linha
                Linha1.Height = 23;

                // Formatação do cabeçalho
                Linha1.RowFormat.BackColor = Color.AliceBlue;

                // Percorre as colunas do cabeçalho
                for (int i = 0; i < cabecalho.Length; i++)
                {
                    Paragraph p = Linha1.Cells[i].AddParagraph();
                    // Alinhamento das células
                    Linha1.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                    // Formatação dos dados do cabeçalho
                    TextRange TR = p.AppendText(cabecalho[i]);
                    TR.CharacterFormat.FontName = "Calibri";
                    TR.CharacterFormat.FontSize = 14;
                    TR.CharacterFormat.TextColor = Color.Teal;
                    TR.CharacterFormat.Bold = true;
                }

                // Adiciona as linhas do corpo da tabela
                for (int r = 0; r < dados.Length; r++)
                {
                    TableRow LinhaDados = tabela.Rows[r + 1];
                    // Define a altura da linha
                    LinhaDados.Height = 20;

                    // Percorre as colunas
                    for (int c = 0; c < dados[r].Length; c++)
                    {
                        // Alinha as células
                        LinhaDados.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                        // Preecher os dados nas linhas
                        Paragraph p2 = LinhaDados.Cells[c].AddParagraph();
                        TextRange TR2 = p2.AppendText(dados[r][c]);

                        // Formatar as células
                        p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                        TR2.CharacterFormat.FontName = "Calibri";
                        TR2.CharacterFormat.FontSize = 12;
                        TR2.CharacterFormat.TextColor = Color.Brown;
                    }
                }
            #endregion

            #region Criacao de secao no documento
                Section secao2 = exercicioDoc.AddSection();
            #endregion

            #region Inserir imagens
                // Adiciona um parágrafo à secao secaoCapa
                Paragraph imagemCapa = secao2.AddParagraph();

                // Adiciona um texto ao parágrafo imagemCapa
                //imagemCapa.AppendText("\n\n\tAgora vamos inserir uma imagem ao documento\n\n");

                // Centraliza horizontalmente o parágrafo imagemCapa
                imagemCapa.Format.HorizontalAlignment = HorizontalAlignment.Center;

                // Adiciona uma imagem com o nome imagemExemplo ao parágrafo imagemCapa
                DocPicture imagemExemplo = imagemCapa.AppendPicture(Image.FromFile(@"saida\img\logo_csharp.png"));

                // Define uma largura e uma altura para a imagem
                imagemExemplo.Width = 300;
                imagemExemplo.Height = 300;
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
