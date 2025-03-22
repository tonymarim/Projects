using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_v1
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            // Configurações para evitar redimensionamento, maximização e minimização
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Borda fixa
            this.MaximizeBox = false; // Desabilita o botão de maximizar
            this.MinimizeBox = false; // Desabilita o botão de minimizar

            // Configurações do formulário de créditos
            this.Text = "Sobre";
            this.Size = new Size(410, 170);

            // Adiciona um Label para exibir os créditos
            Label lblCreditos = new Label();
            lblCreditos.Text = "Desenvolvido por: Núcleo de Tecnologia - SENAI São Carlos,SP\n\n" +
                               "Nome do Desenvolvedor: C{}darPlus\n" +
                               "Versão 1.0\n" +
                               "Data: 2025";
            lblCreditos.AutoSize = true;
            lblCreditos.Location = new Point(20, 40);
            lblCreditos.Font = new Font("Arial", 9, FontStyle.Bold);

            // Adiciona o Label ao formulário
            this.Controls.Add(lblCreditos);
        }
    }
}
