
namespace WindowsDataReader
{
    partial class frmCustomers
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
            this.btnTraerClientes = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerClientes
            // 
            this.btnTraerClientes.Location = new System.Drawing.Point(12, 12);
            this.btnTraerClientes.Name = "btnTraerClientes";
            this.btnTraerClientes.Size = new System.Drawing.Size(142, 27);
            this.btnTraerClientes.TabIndex = 0;
            this.btnTraerClientes.Text = "Traer Clientes";
            this.btnTraerClientes.UseVisualStyleBackColor = true;
            this.btnTraerClientes.Click += new System.EventHandler(this.btnTraerClientes_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(12, 45);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(776, 393);
            this.gridClientes.TabIndex = 1;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.btnTraerClientes);
            this.Name = "frmCustomers";
            this.Text = "frmCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerClientes;
        private System.Windows.Forms.DataGridView gridClientes;
    }
}