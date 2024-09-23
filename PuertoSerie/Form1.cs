using System.IO.Ports;
namespace PuertoSerie
{
    public partial class frmSerie : Form
    {


        SerialPort sp = new SerialPort();

        public frmSerie()
        {
            InitializeComponent();
        }

        private void frmSerie_Load(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames(); cmbPuertos.DataSource = SerialPort.GetPortNames();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            sp.WriteLine(txtEnviar.Text);
            txtEnviar.Clear();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                sp.PortName = cmbPuertos.Text;
                sp.Open();
                sp.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort actualSP = (SerialPort)sender;


            string inData = actualSP.ReadLine();
            rtbLog.Invoke(new MethodInvoker(
                        delegate
                        {
                            rtbLog.Text = rtbLog.Text + inData;
                        }

                        ));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames(); cmbPuertos.DataSource = SerialPort.GetPortNames();
        }
    }
}
