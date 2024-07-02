using System.Drawing.Printing;

namespace GenerarCHeque
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;
            float amount = float.Parse(txtAmount.Text);
            string payTheOrderOf = txtPayOrderOf.Text;
            string memo = txtMemo.Text;

            try
            {
                Conexion conexion = Conexion.getInstancia();
                int idcheck = conexion.InsertarCheque(companyName, amount, payTheOrderOf, memo);
                txtId.Text = idcheck.ToString();
                MessageBox.Show("Cheque guardado exitosamente. ID: " + idcheck);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cheque: " + ex.Message);
            }

            
        }

        private void rbnWood_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnWood.Checked)
            {
                this.BackgroundImage = Properties.Resources.wood;
            }
            if (rbnBrick.Checked)
            {
                this.BackgroundImage = Properties.Resources.brick;

            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }
}
