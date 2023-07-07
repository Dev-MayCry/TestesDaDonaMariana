using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using TestesDaDonaMariana.Dominio.ModuloQuestao;
using TestesDaDonaMariana.Dominio.ModuloTeste;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloAlternativa;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloQuestao;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloTeste;
using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloTeste {


    internal class ControladorTeste : ControladorBase {

        private TabelaTesteControl tabelaTeste;
        private RepositorioMateriaEmSql repositorioMateria;
        private RepositorioDisciplinaEmSql repositorioDisciplina;
        private RepositorioQuestaoEmSql repositorioQuestao;
        private RepositorioTesteEmSql repositorioTeste;
        private RepositorioAlternativaEmSql repositorioAlternativa;

        public ControladorTeste(RepositorioMateriaEmSql repositorioMateria, RepositorioDisciplinaEmSql repositorioDisciplina, RepositorioQuestaoEmSql repositorioQuestao, RepositorioTesteEmSql repositorioTeste, RepositorioAlternativaEmSql repositorioAlternativa) {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioTeste= repositorioTeste;
            this.repositorioAlternativa= repositorioAlternativa;
        }

        public override string ToolTipInserir => "Gerar Novo Teste";
        public override string ToolTipExcluir => "Excluir Teste Existente";
        public override string ToolTipDuplicar => "Duplicar Teste Existente";
        public override string ToolTipVisualizar => "Visualizar Teste Existente";
        public override string ToolTipImprimir => "Imprimir Teste Selecionado";

        public override string LabelTipoCadastro => "Cadastro de Testes";
     
        public override bool VisualizarHabilitado { get { return true; } }
        public override bool DuplicarHabilitado { get { return true; } }
        public override bool ImprimirHabilitado { get { return true; } }

        

        public override void Excluir() {
            Teste testeSelecionado = ObterTesteSelecionada();

            if (testeSelecionado == null) {
                MessageBox.Show($"Nenhum teste selecionado!", "Exclusão de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o teste {testeSelecionado.titulo}?", "Exclusão de Testes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (opcaoEscolhida == DialogResult.OK) {
                repositorioTeste.Excluir(testeSelecionado);
                repositorioTeste.ExcluirRelacao(testeSelecionado);
            }

            CarregarTestes();
        }
       
        public override void Inserir() {
            TelaTeste telaTeste = new TelaTeste(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());
            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            while (opcaoEscolhida == DialogResult.OK) {
                Teste teste = telaTeste.ObterTeste();
                if (ValidarNome(teste)) {

                    opcaoEscolhida = telaTeste.ShowDialog();
                    continue;
                }

                repositorioTeste.Inserir(teste);

                foreach (Questao q in teste.questoes) {

                    repositorioTeste.InserirQuestoes(teste.id, q.id);

                }
                break;
                
            }
            CarregarTestes();
        }

        private bool ValidarNome(Teste teste) {
            if (repositorioTeste.SelecionarTodos().Any(t => t.titulo == teste.titulo)) {
                MessageBox.Show($"Não é possível cadastrar um teste com o mesmo título", "Novo Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            } else if (teste.titulo.Length < 3) {
                MessageBox.Show($"O título do teste não pode ser menor que 3 caracteres!", "Novo Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            } else if (teste.questoes.Count == 0) {
                MessageBox.Show($"Não é possível salvar um teste sem questões!", "Novo Teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            return false;
        }

        public override void Duplicar() {

            Teste testeSelecionado = ObterTesteSelecionada();

            if (testeSelecionado == null) {
                MessageBox.Show($"Nenhum teste selecionado!", "Duplicação de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTeste tela = new TelaTeste(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());
            tela.ConfigurarTela(testeSelecionado);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            while (opcaoEscolhida == DialogResult.OK) {
                Teste teste = tela.ObterTeste();
                if (ValidarNome(teste)) {

                    opcaoEscolhida = tela.ShowDialog();
                    continue;
                }

                repositorioTeste.Inserir(teste);

                foreach (Questao q in teste.questoes) {

                    repositorioTeste.InserirQuestoes(teste.id, q.id);

                }
                break;

            }
            CarregarTestes();
        }

        public override void Visualizar() {

            Teste testeSelecionado = ObterTesteSelecionada();

            repositorioTeste.CarregarQuestoes(testeSelecionado);


            if (testeSelecionado == null) {
                MessageBox.Show($"Nenhum teste selecionado!", "Edição de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTeste tela = new TelaTeste(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos(), repositorioQuestao.SelecionarTodos());
            tela.ConfigurarTelaLeitura(testeSelecionado);


            DialogResult opcaoEscolhida = tela.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK) {


            }
            CarregarTestes();

        }

        public override void Imprimir()
        {
            Teste teste = ObterTesteSelecionada();

            repositorioTeste.CarregarQuestoes(teste);

            foreach (Questao q in teste.questoes)
            {
                foreach (Alternativa a in repositorioAlternativa.SelecionarTodos())
                {
                    if (a.questao.id == q.id)
                        q.alternativas.Add(a);
                }
            }

            PdfDocument document;
            PdfPage page;
            XGraphics gfx;
            XFont fonteTitulo, fonteTexto;

            ImprimirInicioPDF(teste, out document, out page, out gfx, out fonteTitulo, out fonteTexto);
            ImprimirQuestoes(teste, document, ref page, ref gfx, fonteTitulo, fonteTexto);
            ConfirmarImpressao(document);

        }

        private static void ImprimirQuestoes(Teste teste, PdfDocument document, ref PdfPage page, ref XGraphics gfx, XFont fonteTitulo, XFont fonteTexto)
        {
            for (int i = 0; i < teste.questoes.Count; i++)
            {
                gfx.DrawString($"{i + 1}. {teste.questoes[0].enunciado}", fonteTitulo, XBrushes.Black, new XRect(-100, -200, page.Width, page.Height), XStringFormats.Center);

                for (int j = 0; j < teste.questoes[i].alternativas.Count; j++)
                {
                    gfx.DrawString($"{Convert.ToChar(97 + j)}) {teste.questoes[i].alternativas[j].descricao}", fonteTexto, XBrushes.Black, new XRect(-100, -170 + (20 * j), page.Width, page.Height), XStringFormats.Center);
                }

                if(i < teste.questoes.Count - 1)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                }
            }

            //page = document.AddPage();
            //gfx = XGraphics.FromPdfPage(page);

            //gfx.DrawString($"a) {teste.questoes[0].alternativas[0].descricao}", fonteTexto, XBrushes.Black, new XRect(0, 150, page.Width, page.Height), XStringFormats.Center);
            //gfx.DrawString($"b) {teste.questoes[0].alternativas[1].descricao}", fonteTexto, XBrushes.Black, new XRect(0, 200, page.Width, page.Height), XStringFormats.Center);
            //gfx.DrawString($"c) {teste.questoes[0].alternativas[2].descricao}", fonteTexto, XBrushes.Black, new XRect(0, 250, page.Width, page.Height), XStringFormats.Center);

        }

        private static void ImprimirInicioPDF(Teste teste, out PdfDocument document, out PdfPage page, out XGraphics gfx, out XFont fonteTitulo, out XFont fonteTexto)
        {
            //Create PDF Document
            document = new PdfDocument();

            //You will have to add Page in PDF Document
            page = document.AddPage();

            //For drawing in PDF Page you will nedd XGraphics Object
            gfx = XGraphics.FromPdfPage(page);

            //For Test you will have to define font to be used
            XFont fonteTituloPrincipal = new XFont("Verdana", 24, XFontStyle.Bold);
            fonteTitulo = new XFont("Verdana", 20, XFontStyle.Bold);
            fonteTexto = new XFont("Verdana", 14, XFontStyle.Regular);

            //Finally use XGraphics & font object to draw text in PDF Page
            gfx.DrawString($"{teste.titulo}", fonteTituloPrincipal, XBrushes.Black, new XRect(0, -380, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString($"Disciplina: {teste.disciplina}", fonteTitulo, XBrushes.Black, new XRect(0, -330, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString($"Matéria: {teste.materia}", fonteTitulo, XBrushes.Black, new XRect(0, -300, page.Width, page.Height), XStringFormats.Center);
        }

        private static void ConfirmarImpressao(PdfDocument document)
        {
            //Specify file name of the PDF file
            string filename = "D:/Visual Studio Projects/TesteDaDonaMariana/TestesDaDonaMariana.pdf";

            try
            {
                //Save PDF File
                document.Save(filename);
            }
            catch
            {
                MessageBox.Show("PDF Impresso?");
            }

            MessageBox.Show("PDF Impresso!");
        }

        public override UserControl ObterListagem() {
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTestes();
            return tabelaTeste;
        }

        private Teste ObterTesteSelecionada() {
            int id = tabelaTeste.ObterIdSelecionado();

            return repositorioTeste.SelecionarPorId(id);
        }
        private void CarregarTestes() {
            List<Teste> testes = repositorioTeste.SelecionarTodos();
            tabelaTeste.AtualizarRegistros(testes);
        }
    }
}
