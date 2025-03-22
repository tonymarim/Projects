namespace APP_v1
{
    partial class Conexão
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conexão));
            this.btGateway = new System.Windows.Forms.Button();
            this.btModbus = new System.Windows.Forms.Button();
            this.btPulso = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxPortName = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxBaudRate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxDataBits = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxParity = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxStopBits = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGateway
            // 
            this.btGateway.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGateway.Location = new System.Drawing.Point(266, 73);
            this.btGateway.Name = "btGateway";
            this.btGateway.Size = new System.Drawing.Size(136, 41);
            this.btGateway.TabIndex = 2;
            this.btGateway.Text = "Gateway";
            this.btGateway.UseVisualStyleBackColor = false;
            this.btGateway.Click += new System.EventHandler(this.btGateway_Click);
            // 
            // btModbus
            // 
            this.btModbus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btModbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModbus.Location = new System.Drawing.Point(428, 73);
            this.btModbus.Name = "btModbus";
            this.btModbus.Size = new System.Drawing.Size(136, 41);
            this.btModbus.TabIndex = 3;
            this.btModbus.Text = "Módulo ModBus";
            this.btModbus.UseVisualStyleBackColor = false;
            // 
            // btPulso
            // 
            this.btPulso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btPulso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPulso.Location = new System.Drawing.Point(592, 73);
            this.btPulso.Name = "btPulso";
            this.btPulso.Size = new System.Drawing.Size(136, 41);
            this.btPulso.TabIndex = 4;
            this.btPulso.Text = "Módulo Pulso";
            this.btPulso.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripComboBoxPortName,
            this.toolStripSeparator1,
            this.toolStripComboBoxBaudRate,
            this.toolStripSeparator2,
            this.toolStripComboBoxDataBits,
            this.toolStripSeparator3,
            this.toolStripComboBoxParity,
            this.toolStripSeparator4,
            this.toolStripComboBoxStopBits,
            this.toolStripButtonRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxPortName
            // 
            this.toolStripComboBoxPortName.Name = "toolStripComboBoxPortName";
            this.toolStripComboBoxPortName.Size = new System.Drawing.Size(121, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripComboBoxBaudRate
            // 
            this.toolStripComboBoxBaudRate.Name = "toolStripComboBoxBaudRate";
            this.toolStripComboBoxBaudRate.Size = new System.Drawing.Size(121, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripComboBoxDataBits
            // 
            this.toolStripComboBoxDataBits.Name = "toolStripComboBoxDataBits";
            this.toolStripComboBoxDataBits.Size = new System.Drawing.Size(121, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripComboBoxParity
            // 
            this.toolStripComboBoxParity.Name = "toolStripComboBoxParity";
            this.toolStripComboBoxParity.Size = new System.Drawing.Size(121, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripComboBoxStopBits
            // 
            this.toolStripComboBoxStopBits.Name = "toolStripComboBoxStopBits";
            this.toolStripComboBoxStopBits.Size = new System.Drawing.Size(121, 27);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 159);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(838, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(118, 22);
            this.toolStripLabel1.Text = "Desconectado";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Atualizar Portas";
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(19, 73);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(136, 41);
            this.btConnect.TabIndex = 8;
            this.btConnect.Text = "Conectar";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::APP_v1.Properties.Resources._6372970_about_detail_faq_help_info_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::APP_v1.Properties.Resources._118801_refresh_icon;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRefresh.Text = "toolStripButton2";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click_1);
            // 
            // Conexão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 184);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btPulso);
            this.Controls.Add(this.btModbus);
            this.Controls.Add(this.btGateway);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Conexão";
            this.Text = "Cadastrar Dispositivo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGateway;
        private System.Windows.Forms.Button btModbus;
        private System.Windows.Forms.Button btPulso;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxPortName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBaudRate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxDataBits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxParity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxStopBits;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConnect;
    }
}

