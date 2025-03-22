using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace APP_v1
{
    public partial class Gateway : Form
    {
        private SerialPort serialPort;
        private string confirmedIP = "";
        private string confirmedGateway = "";
        private string confirmedMask = "";

        public Gateway(SerialPort existingPort)
        {
            InitializeComponent();
            serialPort = existingPort;
            // Inicializa a visibilidade dos botões
            btConfirmaIP.Visible = true;
            btConfirmaGateway.Visible = true;
            btConfirmaMask.Visible = true;
            btDesfazer.Visible = true;

            // Associa o evento Click ao PictureBox
            pictureBoxSair.Click += pictureBoxSair_Click;
        }

        private bool ValidarIPv4(string endereco)
        {
            string[] partes = endereco.Split('.');
            if (partes.Length != 4) return false;

            foreach (string parte in partes)
            {
                if (!int.TryParse(parte, out int valor) || valor < 0 || valor > 255)
                    return false;
            }
            return true;
        }

        private void ConfirmarEndereco(ref string campo, string valor, Button botao)
        {
            if (ValidarIPv4(valor))
            {
                campo = valor;
                botao.Visible = false;  // Torna o botão invisível após confirmação
                MessageBox.Show("Confirmado: " + campo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Endereço inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btConfirmaIP_Click(object sender, EventArgs e)
        {
            ConfirmarEndereco(ref confirmedIP, maskedTextBoxIP.Text, btConfirmaIP);
        }

        private void btConfirmaGateway_Click(object sender, EventArgs e)
        {
            ConfirmarEndereco(ref confirmedGateway, maskedTextBoxGateway.Text, btConfirmaGateway);
        }

        private void btConfirmaMask_Click(object sender, EventArgs e)
        {
            ConfirmarEndereco(ref confirmedMask, maskedTextBoxMask.Text, btConfirmaMask);
        }

        private void btDesfazer_Click(object sender, EventArgs e)
        {
            // Limpar os campos de IP, Gateway e Máscara
            confirmedIP = confirmedGateway = confirmedMask = "";
            btConfirmaIP.Visible = true;
            btConfirmaGateway.Visible = true;
            btConfirmaMask.Visible = true;
            maskedTextBoxIP.Clear();
            maskedTextBoxGateway.Clear();
            maskedTextBoxMask.Clear();

            // Desmarcar os checkboxes
            checkBoxLer.Checked = false;
            checkBoxIncluir.Checked = false;
            checkBoxApagar.Checked = false;

            MessageBox.Show("Valores resetados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btEnviarConfig_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    // Verificar se todos os campos estão confirmados (botões invisíveis)
                    if (btConfirmaIP.Visible == false && btConfirmaGateway.Visible == false && btConfirmaMask.Visible == false)
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

                        // Envia os dados pela porta serial
                        serialPort.WriteLine(dadosFormatados);
                        MessageBox.Show("Configuração enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Marcar os checkboxes automaticamente após envio bem-sucedido
                        checkBoxLer.Checked = true;
                        checkBoxIncluir.Checked = true;
                        checkBoxApagar.Checked = true;
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
            else
            {
                MessageBox.Show("A porta serial não está aberta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gateway_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void pictureBoxSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
