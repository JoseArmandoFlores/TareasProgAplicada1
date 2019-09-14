namespace TareasProgAplicada1.Tarea3
{
    partial class EstudiantesForm
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
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.CursoTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.CursoLabel = new System.Windows.Forms.Label();
            this.EdadLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(184, 147);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(110, 39);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(116, 104);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(328, 22);
            this.NumeroTextBox.TabIndex = 21;
            // 
            // CursoTextBox
            // 
            this.CursoTextBox.Location = new System.Drawing.Point(117, 76);
            this.CursoTextBox.Name = "CursoTextBox";
            this.CursoTextBox.Size = new System.Drawing.Size(327, 22);
            this.CursoTextBox.TabIndex = 20;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(117, 48);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(328, 22);
            this.EdadTextBox.TabIndex = 19;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(117, 20);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(328, 22);
            this.NombreTextBox.TabIndex = 18;
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroLabel.Location = new System.Drawing.Point(12, 105);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(73, 22);
            this.NumeroLabel.TabIndex = 16;
            this.NumeroLabel.Text = "Numero";
            // 
            // CursoLabel
            // 
            this.CursoLabel.AutoSize = true;
            this.CursoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CursoLabel.Location = new System.Drawing.Point(12, 77);
            this.CursoLabel.Name = "CursoLabel";
            this.CursoLabel.Size = new System.Drawing.Size(57, 22);
            this.CursoLabel.TabIndex = 15;
            this.CursoLabel.Text = "Curso";
            // 
            // EdadLabel
            // 
            this.EdadLabel.AutoSize = true;
            this.EdadLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdadLabel.Location = new System.Drawing.Point(12, 49);
            this.EdadLabel.Name = "EdadLabel";
            this.EdadLabel.Size = new System.Drawing.Size(51, 22);
            this.EdadLabel.TabIndex = 14;
            this.EdadLabel.Text = "Edad";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(12, 21);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(74, 22);
            this.NombreLabel.TabIndex = 13;
            this.NombreLabel.Text = "Nombre";
            // 
            // EstudiantesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 198);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.CursoTextBox);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NumeroLabel);
            this.Controls.Add(this.CursoLabel);
            this.Controls.Add(this.EdadLabel);
            this.Controls.Add(this.NombreLabel);
            this.Name = "EstudiantesForm";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.DisenoClaseInventarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.TextBox CursoTextBox;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.Label CursoLabel;
        private System.Windows.Forms.Label EdadLabel;
        private System.Windows.Forms.Label NombreLabel;
    }
}