namespace TareasProgAplicada1.Tarea3
{
    partial class EstructuraTiendaForm
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
            this.ArticuloLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.ArticuloTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MyDataGridView = new System.Windows.Forms.DataGridView();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.ArticuloColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticuloLabel
            // 
            this.ArticuloLabel.AutoSize = true;
            this.ArticuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticuloLabel.Location = new System.Drawing.Point(41, 25);
            this.ArticuloLabel.Name = "ArticuloLabel";
            this.ArticuloLabel.Size = new System.Drawing.Size(66, 20);
            this.ArticuloLabel.TabIndex = 1;
            this.ArticuloLabel.Text = "Artículo";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(41, 53);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(57, 20);
            this.PrecioLabel.TabIndex = 2;
            this.PrecioLabel.Text = "Precio";
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(41, 81);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(75, 20);
            this.CantidadLabel.TabIndex = 3;
            this.CantidadLabel.Text = "Cantidad";
            // 
            // ArticuloTextBox
            // 
            this.ArticuloTextBox.Location = new System.Drawing.Point(127, 25);
            this.ArticuloTextBox.Name = "ArticuloTextBox";
            this.ArticuloTextBox.Size = new System.Drawing.Size(195, 22);
            this.ArticuloTextBox.TabIndex = 4;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(127, 53);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(195, 22);
            this.PrecioTextBox.TabIndex = 5;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(127, 81);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(195, 22);
            this.CantidadTextBox.TabIndex = 6;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(366, 53);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(116, 40);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MyDataGridView
            // 
            this.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticuloColumn,
            this.PrecioColumn,
            this.CantidadColumn,
            this.Total});
            this.MyDataGridView.Location = new System.Drawing.Point(12, 180);
            this.MyDataGridView.Name = "MyDataGridView";
            this.MyDataGridView.RowHeadersWidth = 51;
            this.MyDataGridView.RowTemplate.Height = 24;
            this.MyDataGridView.Size = new System.Drawing.Size(688, 199);
            this.MyDataGridView.TabIndex = 8;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(41, 109);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(46, 20);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(127, 109);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(195, 22);
            this.TotalTextBox.TabIndex = 10;
            // 
            // ArticuloColumn
            // 
            this.ArticuloColumn.HeaderText = "Artículo";
            this.ArticuloColumn.MinimumWidth = 6;
            this.ArticuloColumn.Name = "ArticuloColumn";
            this.ArticuloColumn.Width = 125;
            // 
            // PrecioColumn
            // 
            this.PrecioColumn.HeaderText = "Precio";
            this.PrecioColumn.MinimumWidth = 6;
            this.PrecioColumn.Name = "PrecioColumn";
            this.PrecioColumn.Width = 125;
            // 
            // CantidadColumn
            // 
            this.CantidadColumn.HeaderText = "Cantidad";
            this.CantidadColumn.MinimumWidth = 6;
            this.CantidadColumn.Name = "CantidadColumn";
            this.CantidadColumn.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // EstructuraTiendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 391);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.MyDataGridView);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.ArticuloTextBox);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.ArticuloLabel);
            this.Name = "EstructuraTiendaForm";
            this.Text = "Estructura tienda";
            this.Load += new System.EventHandler(this.EstructuraTiendaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ArticuloLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.TextBox ArticuloTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.DataGridView MyDataGridView;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}