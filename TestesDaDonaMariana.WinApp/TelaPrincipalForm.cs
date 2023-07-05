using TestesDaDonaMariana.Infra.Dados.Sql.ModuloDisciplina;
using TestesDaDonaMariana.Infra.Dados.Sql.ModuloMateria;
using TestesDaDonaMariana.WinApp.Compartilhado;
using TestesDaDonaMariana.WinApp.ModuloMateria;

namespace TestesDaDonaMariana.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        private RepositorioMateriaEmSql repositorioMateria = new RepositorioMateriaEmSql();
        private RepositorioDisciplinaEmSql repositorioDisciplina = new RepositorioDisciplinaEmSql();
        private static TelaPrincipalForm telaPrincipal;
        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
        }

        private void matériasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {

            toolStrip1.Enabled = true;
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btn_Adicionar.ToolTipText = controlador.ToolTipInserir;
            btn_Editar.ToolTipText = controlador.ToolTipEditar;
            btn_Excluir.ToolTipText = controlador.ToolTipExcluir;


            btn_Adicionar.Enabled = controlador.InserirHabilitado;
            btn_Editar.Enabled = controlador.EditarHabilitado;
            btn_Excluir.Enabled = controlador.ExcluirHabilitado;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }
        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }
        public void AtualizarRodape(string mensagem)
        {
            lbRodape.Text = mensagem;
        }
    }
}