using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Text;

namespace APP_v1
{
    public partial class Conexão : Form
    {
        public Conexão()
        {
            InitializeComponent();
            InitializeToolStripComboBoxes();
            UpdateButtonState(false);

            // Configura o timer1
            timer1.Interval = 2000; // 2 segundos
            timer1.Tick += Timer1_Tick; // Evento que será chamado quando o timer acabar
        }

        private void InitializeToolStripComboBoxes()
        {
            // Verifica as portas COM disponíveis
            UpdateComPorts();

            // Preenche o ComboBox de BaudRate com valores comuns
            toolStripComboBoxBaudRate.Items.AddRange(new object[] { 9600, 19200, 38400, 57600, 115200 });
            toolStripComboBoxBaudRate.SelectedIndex = 0;

            // Preenche o ComboBox de DataBits com valores comuns
            toolStripComboBoxDataBits.Items.AddRange(new object[] { 5, 6, 7, 8 });
            toolStripComboBoxDataBits.SelectedIndex = 3;

            // Preenche o ComboBox de Parity com os valores do enum Parity
            toolStripComboBoxParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            toolStripComboBoxParity.SelectedIndex = 0;

            // Preenche o ComboBox de StopBits com os valores do enum StopBits
            toolStripComboBoxStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            toolStripComboBoxStopBits.SelectedIndex = 1;
        }

        // Função para atualizar as portas COM disponíveis
        private void UpdateComPorts()
        {
            // Limpa o ComboBox de portas
            toolStripComboBoxPortName.Items.Clear();

            // Verifica as portas COM disponíveis
            string[] portNames = SerialPort.GetPortNames();
            if (portNames.Length == 0)
            {
                MessageBox.Show("Nenhuma porta COM encontrada. Verifique a conexão do dispositivo!.");
            }
            else
            {
                toolStripComboBoxPortName.Items.AddRange(portNames);
                toolStripComboBoxPortName.SelectedIndex = 0;
            }
        }

        // Evento do botão de atualização de portas
        private void toolStripButtonRefresh_Click_1(object sender, EventArgs e)
        {
            UpdateComPorts();

            // Exibe o texto "Atualizar Portas" no botão
            this.toolStripButtonRefresh.Text = "Atualizar Portas";

            // Inicia o timer para limpar o texto após 2 segundos
            timer1.Start();
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = toolStripComboBoxPortName.SelectedItem.ToString();
                serialPort1.BaudRate = int.Parse(toolStripComboBoxBaudRate.SelectedItem.ToString());
                serialPort1.DataBits = int.Parse(toolStripComboBoxDataBits.SelectedItem.ToString());
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), toolStripComboBoxParity.SelectedItem.ToString());
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), toolStripComboBoxStopBits.SelectedItem.ToString());

                serialPort1.Open();
                toolStripLabel1.Text = "Conectado";
                UpdateButtonState(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar:" + ex.Message);
            }
        }

        private void toolStripButtonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                toolStripLabel1.Text = "Desconectado";
                UpdateButtonState(false);
            }
        }

        private void UpdateButtonState(bool connected)
        {
            // Habilita ou desabilita os botões
            btGateway.Enabled = connected;
            btModbus.Enabled = connected;
            btPulso.Enabled = connected;

            // Altera a cor de fundo dos botões
            if (connected)
            {
                // Cor verde quando habilitados
                btGateway.BackColor = Color.LightGreen;
                btModbus.BackColor = Color.LightGreen;
                btPulso.BackColor = Color.LightGreen;
            }
            else
            {
                // Cor padrão quando desabilitados
                btGateway.BackColor = SystemColors.Control; // Cor padrão do Windows
                btModbus.BackColor = SystemColors.Control;
                btPulso.BackColor = SystemColors.Control;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripButtonRefresh.Text = ""; // Limpa o texto do botão
            timer1.Stop(); // Para o timer
        }

        // Evento do botão btConnect
        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    // Se a porta estiver aberta, fecha a conexão
                    serialPort1.Close();
                    toolStripLabel1.Text = "Desconectado";
                    UpdateButtonState(false);
                    btConnect.Text = "Conectar"; // Altera o texto do botão para "Conectar"
                    MessageBox.Show("Porta serial fechada com sucesso!"); // Mensagem de confirmação
                }
                else
                {
                    // Se a porta estiver fechada, abre a conexão
                    if (toolStripComboBoxPortName.SelectedItem == null)
                    {
                        MessageBox.Show("Selecione uma porta COM válida.");
                        return;
                    }

                    // Configura a porta serial
                    serialPort1.PortName = toolStripComboBoxPortName.SelectedItem.ToString();
                    serialPort1.BaudRate = int.Parse(toolStripComboBoxBaudRate.SelectedItem.ToString());
                    serialPort1.DataBits = int.Parse(toolStripComboBoxDataBits.SelectedItem.ToString());
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), toolStripComboBoxParity.SelectedItem.ToString());
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), toolStripComboBoxStopBits.SelectedItem.ToString());

                    // Tenta abrir a porta serial
                    serialPort1.Open();

                    // Verifica se a porta foi aberta com sucesso
                    if (serialPort1.IsOpen)
                    {
                        toolStripLabel1.Text = "Conectado";
                        UpdateButtonState(true);
                        btConnect.Text = "Desconectar"; // Altera o texto do botão para "Desconectar"
                        MessageBox.Show("Porta serial aberta com sucesso!"); // Mensagem de confirmação
                    }
                    else
                    {
                        MessageBox.Show("Falha ao abrir a porta serial.");
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Acesso à porta COM foi negado. Verifique se a porta está em uso ou se você tem permissões suficientes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar/desconectar: " + ex.Message);
            }
        }
        // Evento do botão btGateway
        private void btGateway_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário Gateway
            Gateway gatewayForm = new Gateway();

            // Exibe o formulário Gateway
            gatewayForm.Show();
        }
    }
}