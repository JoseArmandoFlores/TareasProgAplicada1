namespace TareasProgAplicada1.Tarea3
{
    partial class EstructurasEnlazadasForm
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
            this.MyDataGridView = new System.Windows.Forms.DataGridView();
            this.NombrePersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadPersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaPersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadMasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CedulaTextBox = new System.Windows.Forms.TextBox();
            this.EdadPersonaTextBox = new System.Windows.Forms.TextBox();
            this.NombrePersonaTextBox = new System.Windows.Forms.TextBox();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.EdadLabel = new System.Windows.Forms.Label();
            this.NombrePersLabel = new System.Windows.Forms.Label();
            this.RazaTextBox = new System.Windows.Forms.TextBox();
            this.EdadMascotaTextBox = new System.Windows.Forms.TextBox();
            this.NombreMascotaTextBox = new System.Windows.Forms.TextBox();
            this.RazaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosPersLabel = new System.Windows.Forms.Label();
            this.DatosMasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyDataGridView
            // 
            this.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePersColumn,
            this.EdadPersColumn,
            this.CedulaPersColumn,
            this.NombreMasColumn,
            this.EdadMasColumn,
            this.RazaColumn});
            this.MyDataGridView.Location = new System.Drawing.Point(12, 259);
            this.MyDataGridView.Name = "MyDataGridView";
            this.MyDataGridView.RowHeadersWidth = 51;
            this.MyDataGridView.RowTemplate.Height = 24;
            this.MyDataGridView.Size = new System.Drawing.Size(759, 199);
            this.MyDataGridView.TabIndex = 17;
            // 
            // NombrePersColumn
            // 
            this.NombrePersColumn.HeaderText = "Nombre dueño";
            this.NombrePersColumn.MinimumWidth = 6;
            this.NombrePersColumn.Name = "NombrePersColumn";
            this.NombrePersColumn.Width = 125;
            // 
            // EdadPersColumn
            // 
            this.EdadPersColumn.HeaderText = "Edad dueño";
            this.EdadPersColumn.MinimumWidth = 6;
            this.EdadPersColumn.Name = "EdadPersColumn";
            this.EdadPersColumn.Width = 125;
            // 
            // CedulaPersColumn
            // 
            this.CedulaPersColumn.HeaderText = "Cedula";
            this.CedulaPersColumn.MinimumWidth = 6;
            this.CedulaPersColumn.Name = "CedulaPersColumn";
            this.CedulaPersColumn.Width = 125;
            // 
            // NombreMasColumn
            // 
            this.NombreMasColumn.HeaderText = "Nombre mascota";
            this.NombreMasColumn.MinimumWidth = 6;
            this.NombreMasColumn.Name = "NombreMasColumn";
            this.NombreMasColumn.Width = 125;
            // 
            // EdadMasColumn
            // 
            this.EdadMasColumn.HeaderText = "Edad mascota";
            this.EdadMasColumn.MinimumWidth = 6;
            this.EdadMasColumn.Name = "EdadMasColumn";
            this.EdadMasColumn.Width = 125;
            // 
            // RazaColumn
            // 
            this.RazaColumn.HeaderText = "Raza";
            this.RazaColumn.MinimumWidth = 6;
            this.RazaColumn.Name = "RazaColumn";
            this.RazaColumn.Width = 125;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(345, 192);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(116, 40);
            this.GuardarButton.TabIndex = 16;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CedulaTextBox
            // 
            this.CedulaTextBox.Location = new System.Drawing.Point(121, 145);
            this.CedulaTextBox.Name = "CedulaTextBox";
            this.CedulaTextBox.Size = new System.Drawing.Size(195, 22);
            this.CedulaTextBox.TabIndex = 15;
            // 
            // EdadPersonaTextBox
            // 
            this.EdadPersonaTextBox.Location = new System.Drawing.Point(121, 117);
            this.EdadPersonaTextBox.Name = "EdadPersonaTextBox";
            this.EdadPersonaTextBox.Size = new System.Drawing.Size(195, 22);
            this.EdadPersonaTextBox.TabIndex = 14;
            // 
            // NombrePersonaTextBox
            // 
            this.NombrePersonaTextBox.Location = new System.Drawing.Point(121, 89);
            this.NombrePersonaTextBox.Name = "NombrePersonaTextBox";
            this.NombrePersonaTextBox.Size = new System.Drawing.Size(195, 22);
            this.NombrePersonaTextBox.TabIndex = 13;
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.Location = new System.Drawing.Point(47, 143);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(66, 22);
            this.CedulaLabel.TabIndex = 12;
            this.CedulaLabel.Text = "Cedula";
            // 
            // EdadLabel
            // 
            this.EdadLabel.AutoSize = true;
            this.EdadLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdadLabel.Location = new System.Drawing.Point(47, 115);
            this.EdadLabel.Name = "EdadLabel";
            this.EdadLabel.Size = new System.Drawing.Size(51, 22);
            this.EdadLabel.TabIndex = 11;
            this.EdadLabel.Text = "Edad";
            // 
            // NombrePersLabel
            // 
            this.NombrePersLabel.AutoSize = true;
            this.NombrePersLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePersLabel.Location = new System.Drawing.Point(47, 89);
            this.NombrePersLabel.Name = "NombrePersLabel";
            this.NombrePersLabel.Size = new System.Drawing.Size(74, 22);
            this.NombrePersLabel.TabIndex = 10;
            this.NombrePersLabel.Text = "Nombre";
            // 
            // RazaTextBox
            // 
            this.RazaTextBox.Location = new System.Drawing.Point(527, 143);
            this.RazaTextBox.Name = "RazaTextBox";
            this.RazaTextBox.Size = new System.Drawing.Size(195, 22);
            this.RazaTextBox.TabIndex = 23;
            // 
            // EdadMascotaTextBox
            // 
            this.EdadMascotaTextBox.Location = new System.Drawing.Point(527, 115);
            this.EdadMascotaTextBox.Name = "EdadMascotaTextBox";
            this.EdadMascotaTextBox.Size = new System.Drawing.Size(195, 22);
            this.EdadMascotaTextBox.TabIndex = 22;
            // 
            // NombreMascotaTextBox
            // 
            this.NombreMascotaTextBox.Location = new System.Drawing.Point(527, 87);
            this.NombreMascotaTextBox.Name = "NombreMascotaTextBox";
            this.NombreMascotaTextBox.Size = new System.Drawing.Size(195, 22);
            this.NombreMascotaTextBox.TabIndex = 21;
            // 
            // RazaLabel
            // 
            this.RazaLabel.AutoSize = true;
            this.RazaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RazaLabel.Location = new System.Drawing.Point(453, 143);
            this.RazaLabel.Name = "RazaLabel";
            this.RazaLabel.Size = new System.Drawing.Size(49, 22);
            this.RazaLabel.TabIndex = 20;
            this.RazaLabel.Text = "Raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            // 
            // DatosPersLabel
            // 
            this.DatosPersLabel.AutoSize = true;
            this.DatosPersLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosPersLabel.Location = new System.Drawing.Point(138, 39);
            this.DatosPersLabel.Name = "DatosPersLabel";
            this.DatosPersLabel.Size = new System.Drawing.Size(109, 22);
            this.DatosPersLabel.TabIndex = 24;
            this.DatosPersLabel.Text = "Datos dueño";
            // 
            // DatosMasLabel
            // 
            this.DatosMasLabel.AutoSize = true;
            this.DatosMasLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosMasLabel.Location = new System.Drawing.Point(523, 39);
            this.DatosMasLabel.Name = "DatosMasLabel";
            this.DatosMasLabel.Size = new System.Drawing.Size(125, 22);
            this.DatosMasLabel.TabIndex = 25;
            this.DatosMasLabel.Text = "Datos mascota";
            // 
            // EstructurasEnlazadasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 470);
            this.Controls.Add(this.DatosMasLabel);
            this.Controls.Add(this.DatosPersLabel);
            this.Controls.Add(this.RazaTextBox);
            this.Controls.Add(this.EdadMascotaTextBox);
            this.Controls.Add(this.NombreMascotaTextBox);
            this.Controls.Add(this.RazaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MyDataGridView);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CedulaTextBox);
            this.Controls.Add(this.EdadPersonaTextBox);
            this.Controls.Add(this.NombrePersonaTextBox);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.EdadLabel);
            this.Controls.Add(this.NombrePersLabel);
            this.Name = "EstructurasEnlazadasForm";
            this.Text = "Estructuras enlazadas";
            this.Load += new System.EventHandler(this.EstructurasEnlazadasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MyDataGridView;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox CedulaTextBox;
        private System.Windows.Forms.TextBox EdadPersonaTextBox;
        private System.Windows.Forms.TextBox NombrePersonaTextBox;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label EdadLabel;
        private System.Windows.Forms.Label NombrePersLabel;
        private System.Windows.Forms.TextBox RazaTextBox;
        private System.Windows.Forms.TextBox EdadMascotaTextBox;
        private System.Windows.Forms.TextBox NombreMascotaTextBox;
        private System.Windows.Forms.Label RazaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadPersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaPersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadMasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaColumn;
        private System.Windows.Forms.Label DatosPersLabel;
        private System.Windows.Forms.Label DatosMasLabel;
    }
}