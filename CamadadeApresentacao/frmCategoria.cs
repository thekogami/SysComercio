using System.Windows.Forms;
using CamadaNegocio;

namespace CamadadeApresentacao
{
    public partial class frmCategoria : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        public frmCategoria()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.txtNome, "Insira o nome da Categoria");
        }

        // Mostrar mensagem de confirma��o
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistma Com�rcio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mostrar mensagem de erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistma Com�rcio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Limpar campos
        private void Limpar()
        {
            this.txtNome.Text = string.Empty;
            this.txtIdCategoria.Text = string.Empty;
            this.txtDescricao.Text = string.Empty;
        }

        //Habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txtNome.ReadOnly = !valor;
            this.txtDescricao.ReadOnly = !valor;
            this.txtIdCategoria.ReadOnly = !valor;
        }

        //Habilitar os bot�es
        private void botoes()
        {
            if(this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        //Ocultar as Colunas do Grid


        private void frmCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}