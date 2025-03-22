using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;

namespace APP_v1
{
    public partial class Conexao : Form
    {
        public Conexao()
        {
            InitializeComponent();
            InitializeToolStripComboBoxes();
            UpdateButtonState(false);

            // Associa o evento Click ao ToolStripButton
            //toolStripButtonAbout.Click += toolStripAbout_Click;
        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de créditos
            About aboutForm = new About();

            // Exibe o formulário de créditos como uma janela modal
            aboutForm.ShowDialog();
        }

        // Evento de clique no ToolStripButton

        private void InitializeToolStripComboBoxes()
        {
            UpdateComPorts();
            toolStripComboBoxBaudRate.Items.AddRange(new object[] { 9600, 19200, 38400, 57600, 115200 });
            toolStripComboBoxBaudRate.SelectedIndex = 0;
            toolStripComboBoxDataBits.Items.AddRange(new object[] { 5, 6, 7, 8 });
            toolStripComboBoxDataBits.SelectedIndex = 3;
            toolStripComboBoxParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            toolStripComboBoxParity.SelectedIndex = 0;
            toolStripComboBoxStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            toolStripComboBoxStopBits.SelectedIndex = 1;
        }

        private void UpdateComPorts()
        {
            toolStripComboBoxPortName.Items.Clear();
            string[] portNames = SerialPort.GetPortNames();
            if (portNames.Length == 0)
            {
                MessageBox.Show("Nenhuma porta COM encontrada.");
            }
            else
            {
                toolStripComboBoxPortName.Items.AddRange(portNames);
                toolStripComboBoxPortName.SelectedIndex = 0;
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                toolStripButtonDisconnect_Click(sender, e);  // Desconectar se já estiver conectado
            }
            else
            {
                toolStripButtonConnect_Click(sender, e);  // Conectar se não estiver conectado
            }
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = toolStripComboBoxPortName.SelectedItem.ToString();
                    serialPort1.BaudRate = int.Parse(toolStripComboBoxBaudRate.SelectedItem.ToString());
                    serialPort1.DataBits = int.Parse(toolStripComboBoxDataBits.SelectedItem.ToString());
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), toolStripComboBoxParity.SelectedItem.ToString());
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), toolStripComboBoxStopBits.SelectedItem.ToString());

                    serialPort1.Open();
                    toolStripLabel1.Text = "Conectado";
                    btConnect.Text = "Desconectar"; // Alterar o texto para "Desconectar"
                    UpdateButtonState(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private void toolStripButtonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                toolStripLabel1.Text = "Desconectado";
                btConnect.Text = "Conectar"; // Alterar o texto para "Conectar"
                UpdateButtonState(false);
            }
        }

        private void UpdateButtonState(bool connected)
        {
            btGateway.Enabled = connected;
            btModbus.Enabled = connected;
            btPulso.Enabled = connected;
            Color buttonColor = connected ? Color.LightGreen : SystemColors.Control;
            btGateway.BackColor = buttonColor;
            btModbus.BackColor = buttonColor;
            btPulso.BackColor = buttonColor;
        }

        private void Conexao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void btGateway_Click(object sender, EventArgs e)
        {
            Gateway gatewayForm = new Gateway(serialPort1);
            gatewayForm.Show();
        }
    }
}
