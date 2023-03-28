using BLL;
namespace Lista_de_Telefone
{
    public partial class Form1 : Form
    {
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsTelefone.DataSource = Repositorio;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Telefone telefone = new Telefone();
            telefone.Nome = "Nome";

            telefone.Numero = 1332027100;
            telefone.Endereco = "Endereço.";

            Repositorio.Incluir(telefone);
            bsTelefone.ResetBindings(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}