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
            cmbPuertos.DataSource = SerialPort.GetPortNames();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                try
                {
                    /*
                    // Enviar texto desde el cuadro de texto a través del puerto serie
                    sp.WriteLine(txtEnviar.Text);
                    rtbLog.AppendText("Enviado: " + txtEnviar.Text + Environment.NewLine);
                    txtEnviar.Clear();
                    */
                    // Verifica si el texto enviado es 'a' o 's'
                    string mensaje = txtEnviar.Text;  // Convierte el texto a minúsculas para evitar errores de mayúsculas

                    if (mensaje == "S" || mensaje == "N")
                    {
                        sp.WriteLine(mensaje);  // Envía el texto al puerto serie
                        rtbLog.AppendText("Enviado: " + mensaje + Environment.NewLine);
                        txtEnviar.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingresa 'a' para encender o 's' para apagar el LED.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Primero debes conectar el puerto serie.");
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
<<<<<<< Updated upstream
                sp.PortName = cmbPuertos.Text;
                sp.Open();
                MessageBox.Show("Conectado");
                sp.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
=======
                try
                {
                    // Configurar el puerto serial
                    sp.PortName = cmbPuertos.Text;
                    sp.BaudRate = 9600;  // Configura la velocidad en baudios
                    /*sp.DataBits = 8;
                    sp.Parity = Parity.None;
                    sp.StopBits = StopBits.One;*/
>>>>>>> Stashed changes

                    // Abrir el puerto y asignar el evento de recepción de datos
                    sp.Open();
                    sp.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

                    MessageBox.Show("Puerto conectado exitosamente.");
                    btnConectar.Enabled = false;
                    button1.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar el puerto: " + ex.Message);
                }
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Este método se ejecuta cuando se reciben datos a través del puerto serial
            try
            {
                SerialPort actualSP = (SerialPort)sender;

                // Leer los datos recibidos del puerto serial
                string inData = actualSP.ReadLine();
                rtbLog.Invoke(new MethodInvoker(
                    delegate
                    {
                        // Mostrar los datos recibidos en el log
                        rtbLog.AppendText(inData + "\n");
                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recibir datos: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cmbPuertos.DataSource = SerialPort.GetPortNames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                try
                {
                    sp.Close();
                    MessageBox.Show("Puerto desconectado exitosamente.");
                    btnConectar.Enabled = true;
                    button1.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al desconectar el puerto: " + ex.Message);
                }
            }
        }
    }
}
