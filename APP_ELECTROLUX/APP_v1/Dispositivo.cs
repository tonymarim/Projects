using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace APP_v1
{
    public partial class Gateway : Form
    {
        // Variáveis para armazenar os valores confirmados
        private string confirmedIP = string.Empty;
        private string confirmedGateway = string.Empty;
        private string confirmedMask = string.Empty;

        // Declaração do SerialPort
        private SerialPort serialPort1 = new SerialPort();

        public Gateway()
        {
            InitializeComponent();

            // Inicializa a visibilidade dos botões
            btConfirmaIP.Visible = true;
            btConfirmaGateway.Visible = true;
            btConfirmaMask.Visible = true;
            btDesfazer.Visible = true; // Botão "Desfazer" só aparece após uma confirmação

            // Configura o ComboBox de portas COM
            ConfigurarComboBoxPortaCOM();
        }

        // Método para configurar o ComboBox de portas COM
        private void ConfigurarComboBoxPortaCOM()
        {
            // Limpa o ComboBox
            comboBoxPortaCOM.Items.Clear();

            // Obtém as portas COM disponíveis
            string[] portas = SerialPort.GetPortNames();

            if (portas.Length > 0)
            {
                // Adiciona as portas COM ao ComboBox
                comboBoxPortaCOM.Items.AddRange(portas);
                comboBoxPortaCOM.SelectedIndex = 0; // Seleciona a primeira porta por padrão
            }
            else
            {
                MessageBox.Show("Nenhuma porta COM encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para validar um endereço IPv4
        private bool ValidarIPv4(string endereco)
        {
            // Divide o endereço em partes usando o ponto como separador
            string[] partes = endereco.Split('.');

            // Verifica se há exatamente 4 partes
            if (partes.Length != 4)
                return false;

            // Verifica se cada parte está no intervalo de 0 a 255
            foreach (string parte in partes)
            {
                if (!int.TryParse(parte, out int valor) || valor < 0 || valor > 255)
                    return false;
            }

            return true;
        }

        // Evento do botão Confirmar IP
        private void btConfirmaIP_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxIP.MaskCompleted)
            {
                string ip = maskedTextBoxIP.Text;

                // Valida o endereço IP
                if (ValidarIPv4(ip))
                {
                    // Armazena o valor confirmado
                    confirmedIP = ip;

                    // Esconde o botão de confirmação
                    btConfirmaIP.Visible = false;

                    MessageBox.Show("IP confirmado: " + confirmedIP, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Endereço IP inválido. Certifique-se de que está no formato IPv4 (0-255).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo IP corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento do botão Confirmar Gateway
        private void btConfirmaGateway_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxGateway.MaskCompleted)
            {
                string gateway = maskedTextBoxGateway.Text;

                // Valida o endereço Gateway
                if (ValidarIPv4(gateway))
                {
                    // Armazena o valor confirmado
                    confirmedGateway = gateway;

                    // Esconde o botão de confirmação
                    btConfirmaGateway.Visible = false;

                    MessageBox.Show("Gateway confirmado: " + confirmedGateway, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Endereço Gateway inválido. Certifique-se de que está no formato IPv4 (0-255).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Gateway corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento do botão Confirmar Máscara
        private void btConfirmaMask_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxMask.MaskCompleted)
            {
                string mask = maskedTextBoxMask.Text;

                // Valida o endereço Máscara
                if (ValidarIPv4(mask))
                {
                    // Armazena o valor confirmado
                    confirmedMask = mask;

                    // Esconde o botão de confirmação
                    btConfirmaMask.Visible = false;

                    MessageBox.Show("Máscara confirmada: " + confirmedMask, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Endereço Máscara inválido. Certifique-se de que está no formato IPv4 (0-255).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Máscara corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento do botão Desfazer
        private void btDesfazer_Click(object sender, EventArgs e)
        {
            // Restaura a visibilidade dos botões de confirmação
            btConfirmaIP.Visible = true;
            btConfirmaGateway.Visible = true;
            btConfirmaMask.Visible = true;

            // Limpa os campos
            maskedTextBoxIP.Clear();
            maskedTextBoxGateway.Clear();
            maskedTextBoxMask.Clear();

            MessageBox.Show("Valores desfeitos e campos limpos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para abrir a porta serial
        private void AbrirPortaSerial()
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboBoxPortaCOM.SelectedItem.ToString(); // Usa a porta selecionada no ComboBox
                    serialPort1.BaudRate = 9600; // Define o baud rate
                    serialPort1.Open();
                    MessageBox.Show("Porta serial aberta com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a porta serial: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para fechar a porta serial
        private void FecharPortaSerial()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    MessageBox.Show("Porta serial fechada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar a porta serial: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento do botão Enviar Configuração
        private void btEnviarConfig_Click(object sender, EventArgs e)
        {
            AbrirPortaSerial(); // Abre a porta serial antes de enviar

            try
            {
                if (!btConfirmaIP.Visible && !btConfirmaGateway.Visible && !btConfirmaMask.Visible)
                {
                    string ip = maskedTextBoxIP.Text;
                    string gateway = maskedTextBoxGateway.Text;
                    string mask = maskedTextBoxMask.Text;

                    string resposta = "10"; // Tempo de resposta de 10 segundos
                    string scantime = "10"; // Varredura a cada 10 segundos

                    string acaoLer = checkBoxLer.Checked ? "ler" : "";
                    string acaoIncluir = checkBoxIncluir.Checked ? "incluir" : "";
                    string acaoApagar = checkBoxApagar.Checked ? "apagar" : "";

                    string dadosFormatados = $"$[{ip}][{gateway}][{mask}][resposta({resposta})][scantime({scantime}),{acaoLer},{acaoIncluir},{acaoApagar}]#\r\n";

                    if (serialPort1.IsOpen)
                    {
                        serialPort1.WriteLine(dadosFormatados);
                        MessageBox.Show("Configuração enviada com sucesso: " + dadosFormatados, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("A porta serial não está aberta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Confirme todos os campos antes de enviar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar configuração: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de fechamento do formulário
        private void Gateway_FormClosing(object sender, FormClosingEventArgs e)
        {
            FecharPortaSerial(); // Fecha a porta serial ao fechar o formulário
        }
    }
}