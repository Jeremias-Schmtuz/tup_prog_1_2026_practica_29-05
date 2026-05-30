using System.Data;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        ExpedienteService servicio = new ExpedienteService();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servicio.RegistrarExpediente(tbNombre.Text, tbDNI.Text, Convert.ToDouble(tbMonto.Text));
            tbNombre.Text = "";
            tbDNI.Text = "";
            tbMonto.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = servicio.CaluclarTotal().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = servicio.VerMayor().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = servicio.VerCantidadDeIngresados().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 modalExp = new Form2();
            string[] expedientes = servicio.VerExpedientes();

            for (int i = 0; i < servicio.VerCantidadDeIngresados(); i++)
            {
                modalExp.lbExpedientes.Items.Add(expedientes[i]);
            }
            modalExp.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMonto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}