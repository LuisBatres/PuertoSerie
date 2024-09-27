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
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Puerto Serie";
            // 
            // cmbPuertos
            // 
            cmbPuertos.FormattingEnabled = true;
            cmbPuertos.Location = new Point(14, 36);
            cmbPuertos.Margin = new Padding(3, 4, 3, 4);
            cmbPuertos.Name = "cmbPuertos";
            cmbPuertos.Size = new Size(313, 28);
            cmbPuertos.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(334, 35);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(86, 31);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 99);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(14, 75);
            rtbLog.Margin = new Padding(3, 4, 3, 4);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(498, 176);
            rtbLog.TabIndex = 4;
            rtbLog.Text = "";
            // 
            // txtEnviar
            // 
            txtEnviar.Location = new Point(14, 275);
            txtEnviar.Margin = new Padding(3, 4, 3, 4);
            txtEnviar.Name = "txtEnviar";
            txtEnviar.Size = new Size(395, 27);
            txtEnviar.TabIndex = 5;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(426, 273);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(86, 31);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(426, 35);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(518, 37);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Desconectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmSerie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 345);
            Controls.Add(button1);
            Controls.Add(btnActualizar);
            Controls.Add(btnEnviar);
            Controls.Add(txtEnviar);
            Controls.Add(rtbLog);
            Controls.Add(label2);
            Controls.Add(btnConectar);
            Controls.Add(cmbPuertos);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
    }
}
