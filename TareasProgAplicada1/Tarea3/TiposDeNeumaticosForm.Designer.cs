namespace TareasProgAplicada1.Tarea3
{
    partial class TiposDeNeumaticosForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarLabel = new System.Windows.Forms.Label();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.TipoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // BuscarLabel
            // 
            this.BuscarLabel.AutoSize = true;
            this.BuscarLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarLabel.Location = new System.Drawing.Point(33, 55);
            this.BuscarLabel.Name = "BuscarLabel";
            this.BuscarLabel.Size = new System.Drawing.Size(254, 22);
            this.BuscarLabel.TabIndex = 2;
            this.BuscarLabel.Text = "Digite un numero de neumatico";
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Location = new System.Drawing.Point(294, 55);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(238, 22);
            this.BuscarTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Location = new System.Drawing.Point(574, 55);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(118, 50);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.Location = new System.Drawing.Point(33, 83);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(206, 22);
            this.ResultadoLabel.TabIndex = 5;
            this.ResultadoLabel.Text = "El tipo seleccionado es: ";
            this.ResultadoLabel.Click += new System.EventHandler(this.ResultadoLabel_Click);
            // 
            // TipoTextBox
            // 
            this.TipoTextBox.Location = new System.Drawing.Point(294, 83);
            this.TipoTextBox.Name = "TipoTextBox";
            this.TipoTextBox.Size = new System.Drawing.Size(238, 22);
            this.TipoTextBox.TabIndex = 6;
            // 
            // TiposDeNeumaticosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 159);
            this.Controls.Add(this.TipoTextBox);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.BuscarTextBox);
            this.Controls.Add(this.BuscarLabel);
            this.Controls.Add(this.label2);
            this.Name = "TiposDeNeumaticosForm";
            this.Text = "Neumaticos";
            this.Load += new System.EventHandler(this.TiposDeNeumaticosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BuscarLabel;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.TextBox TipoTextBox;
    }
}