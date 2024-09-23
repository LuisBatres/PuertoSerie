namespace PuertoSerie
{
    partial class frmSerie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbPuertos = new ComboBox();
            btnConectar = new Button();
            label2 = new Label();
            rtbLog = new RichTextBox();
            txtEnviar = new TextBox();
            btnEnviar = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Puerto Serie";
            // 
            // cmbPuertos
            // 
            cmbPuertos.FormattingEnabled = true;
            cmbPuertos.Location = new Point(12, 27);
            cmbPuertos.Name = "cmbPuertos";
            cmbPuertos.Size = new Size(274, 23);
            cmbPuertos.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(292, 26);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(12, 56);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(436, 133);
            rtbLog.TabIndex = 4;
            rtbLog.Text = "";
            // 
            // txtEnviar
            // 
            txtEnviar.Location = new Point(12, 206);
            txtEnviar.Name = "txtEnviar";
            txtEnviar.Size = new Size(346, 23);
            txtEnviar.TabIndex = 5;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(373, 205);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(373, 26);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 259);
            Controls.Add(btnActualizar);
            Controls.Add(btnEnviar);
            Controls.Add(txtEnviar);
            Controls.Add(rtbLog);
            Controls.Add(label2);
            Controls.Add(btnConectar);
            Controls.Add(cmbPuertos);
            Controls.Add(label1);
            Name = "frmSerie";
            Text = "Puerto Serie";
            Load += frmSerie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPuertos;
        private Button btnConectar;
        private Label label2;
        private RichTextBox rtbLog;
        private TextBox txtEnviar;
        private Button btnEnviar;
        private Button btnActualizar;
    }
}
