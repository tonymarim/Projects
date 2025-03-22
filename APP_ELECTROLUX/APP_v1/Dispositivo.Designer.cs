namespace APP_v1
{
    partial class Gateway
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gateway));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxIP = new System.Windows.Forms.MaskedTextBox();
            this.btConfirmaIP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxGateway = new System.Windows.Forms.MaskedTextBox();
            this.btConfirmaGateway = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxMask = new System.Windows.Forms.MaskedTextBox();
            this.btConfirmaMask = new System.Windows.Forms.Button();
            this.btDesfazer = new System.Windows.Forms.Button();
            this.btEnviarConfig = new System.Windows.Forms.Button();
            this.pictureBoxSair = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxLer = new System.Windows.Forms.CheckBox();
            this.checkBoxIncluir = new System.Windows.Forms.CheckBox();
            this.checkBoxApagar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuração do Gateway";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço IP";
            // 
            // maskedTextBoxIP
            // 
            this.maskedTextBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxIP.Location = new System.Drawing.Point(163, 63);
            this.maskedTextBoxIP.Mask = "000\\.000\\.000\\.000";
            this.maskedTextBoxIP.Name = "maskedTextBoxIP";
            this.maskedTextBoxIP.Size = new System.Drawing.Size(172, 31);
            this.maskedTextBoxIP.TabIndex = 2;
            // 
            // btConfirmaIP
            // 
            this.btConfirmaIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmaIP.Location = new System.Drawing.Point(341, 63);
            this.btConfirmaIP.Name = "btConfirmaIP";
            this.btConfirmaIP.Size = new System.Drawing.Size(75, 31);
            this.btConfirmaIP.TabIndex = 3;
            this.btConfirmaIP.Text = "Confirma";
            this.btConfirmaIP.UseVisualStyleBackColor = true;
            this.btConfirmaIP.Click += new System.EventHandler(this.btConfirmaIP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gateway";
            // 
            // maskedTextBoxGateway
            // 
            this.maskedTextBoxGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxGateway.Location = new System.Drawing.Point(163, 115);
            this.maskedTextBoxGateway.Mask = "000\\.000\\.000\\.000";
            this.maskedTextBoxGateway.Name = "maskedTextBoxGateway";
            this.maskedTextBoxGateway.Size = new System.Drawing.Size(172, 31);
            this.maskedTextBoxGateway.TabIndex = 5;
            // 
            // btConfirmaGateway
            // 
            this.btConfirmaGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmaGateway.Location = new System.Drawing.Point(341, 115);
            this.btConfirmaGateway.Name = "btConfirmaGateway";
            this.btConfirmaGateway.Size = new System.Drawing.Size(75, 31);
            this.btConfirmaGateway.TabIndex = 6;
            this.btConfirmaGateway.Text = "Confirma";
            this.btConfirmaGateway.UseVisualStyleBackColor = true;
            this.btConfirmaGateway.Click += new System.EventHandler(this.btConfirmaGateway_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mask";
            // 
            // maskedTextBoxMask
            // 
            this.maskedTextBoxMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxMask.Location = new System.Drawing.Point(163, 168);
            this.maskedTextBoxMask.Mask = "000\\.000\\.000\\.000";
            this.maskedTextBoxMask.Name = "maskedTextBoxMask";
            this.maskedTextBoxMask.Size = new System.Drawing.Size(172, 31);
            this.maskedTextBoxMask.TabIndex = 8;
            // 
            // btConfirmaMask
            // 
            this.btConfirmaMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmaMask.Location = new System.Drawing.Point(341, 168);
            this.btConfirmaMask.Name = "btConfirmaMask";
            this.btConfirmaMask.Size = new System.Drawing.Size(75, 31);
            this.btConfirmaMask.TabIndex = 9;
            this.btConfirmaMask.Text = "Confirma";
            this.btConfirmaMask.UseVisualStyleBackColor = true;
            this.btConfirmaMask.Click += new System.EventHandler(this.btConfirmaMask_Click);
            // 
            // btDesfazer
            // 
            this.btDesfazer.BackColor = System.Drawing.Color.IndianRed;
            this.btDesfazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesfazer.Location = new System.Drawing.Point(312, 271);
            this.btDesfazer.Name = "btDesfazer";
            this.btDesfazer.Size = new System.Drawing.Size(104, 31);
            this.btDesfazer.TabIndex = 10;
            this.btDesfazer.Text = "Desfazer";
            this.btDesfazer.UseVisualStyleBackColor = false;
            this.btDesfazer.Click += new System.EventHandler(this.btDesfazer_Click);
            // 
            // btEnviarConfig
            // 
            this.btEnviarConfig.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btEnviarConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviarConfig.Location = new System.Drawing.Point(154, 271);
            this.btEnviarConfig.Name = "btEnviarConfig";
            this.btEnviarConfig.Size = new System.Drawing.Size(104, 31);
            this.btEnviarConfig.TabIndex = 11;
            this.btEnviarConfig.Text = "Enviar";
            this.btEnviarConfig.UseVisualStyleBackColor = false;
            this.btEnviarConfig.Click += new System.EventHandler(this.btEnviarConfig_Click);
            // 
            // pictureBoxSair
            // 
            this.pictureBoxSair.Image = global::APP_v1.Properties.Resources._728935_exit_left_logout_arrow_move_icon;
            this.pictureBoxSair.InitialImage = global::APP_v1.Properties.Resources._728935_exit_left_logout_arrow_move_icon;
            this.pictureBoxSair.Location = new System.Drawing.Point(354, 390);
            this.pictureBoxSair.Name = "pictureBoxSair";
            this.pictureBoxSair.Size = new System.Drawing.Size(62, 48);
            this.pictureBoxSair.TabIndex = 17;
            this.pictureBoxSair.TabStop = false;
            this.pictureBoxSair.Click += new System.EventHandler(this.pictureBoxSair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sair";
            // 
            // checkBoxLer
            // 
            this.checkBoxLer.AutoSize = true;
            this.checkBoxLer.Location = new System.Drawing.Point(34, 239);
            this.checkBoxLer.Name = "checkBoxLer";
            this.checkBoxLer.Size = new System.Drawing.Size(41, 17);
            this.checkBoxLer.TabIndex = 12;
            this.checkBoxLer.Text = "Ler";
            this.checkBoxLer.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncluir
            // 
            this.checkBoxIncluir.AutoSize = true;
            this.checkBoxIncluir.Location = new System.Drawing.Point(34, 262);
            this.checkBoxIncluir.Name = "checkBoxIncluir";
            this.checkBoxIncluir.Size = new System.Drawing.Size(54, 17);
            this.checkBoxIncluir.TabIndex = 13;
            this.checkBoxIncluir.Text = "Incluir";
            this.checkBoxIncluir.UseVisualStyleBackColor = true;
            // 
            // checkBoxApagar
            // 
            this.checkBoxApagar.AutoSize = true;
            this.checkBoxApagar.Location = new System.Drawing.Point(34, 285);
            this.checkBoxApagar.Name = "checkBoxApagar";
            this.checkBoxApagar.Size = new System.Drawing.Size(60, 17);
            this.checkBoxApagar.TabIndex = 14;
            this.checkBoxApagar.Text = "Apagar";
            this.checkBoxApagar.UseVisualStyleBackColor = true;
            // 
            // Gateway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxSair);
            this.Controls.Add(this.checkBoxApagar);
            this.Controls.Add(this.checkBoxIncluir);
            this.Controls.Add(this.checkBoxLer);
            this.Controls.Add(this.btEnviarConfig);
            this.Controls.Add(this.btDesfazer);
            this.Controls.Add(this.btConfirmaMask);
            this.Controls.Add(this.maskedTextBoxMask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btConfirmaGateway);
            this.Controls.Add(this.maskedTextBoxGateway);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btConfirmaIP);
            this.Controls.Add(this.maskedTextBoxIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gateway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração do Gateway";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIP;
        private System.Windows.Forms.Button btConfirmaIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGateway;
        private System.Windows.Forms.Button btConfirmaGateway;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMask;
        private System.Windows.Forms.Button btConfirmaMask;
        private System.Windows.Forms.Button btDesfazer;
        private System.Windows.Forms.Button btEnviarConfig;
        private System.Windows.Forms.PictureBox pictureBoxSair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxLer;
        private System.Windows.Forms.CheckBox checkBoxIncluir;
        private System.Windows.Forms.CheckBox checkBoxApagar;
    }
}