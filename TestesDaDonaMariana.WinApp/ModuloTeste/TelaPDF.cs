using TestesDaDonaMariana.WinApp.Compartilhado;

namespace TestesDaDonaMariana.WinApp.ModuloTeste
{
    public partial class TelaPDF : Form
    {
        public TelaPDF(string titulo)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this.titulo.Text = titulo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                localFile.Text = folderBrowserDialog.SelectedPath;
            }
        }

        public string AtualizarDiretorio()
        {
            return localFile.Text;
        }
    }
}
