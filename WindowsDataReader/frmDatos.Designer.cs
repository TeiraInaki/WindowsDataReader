
namespace WindowsDataReader
{
    partial class frmDatos
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
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.btnTraerPorID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraer = new System.Windows.Forms.TextBox();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProduct
            // 
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridProduct.Location = new System.Drawing.Point(0, 61);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(800, 389);
            this.gridProduct.TabIndex = 0;
            // 
            // btnTraerPorID
            // 
            this.btnTraerPorID.Location = new System.Drawing.Point(123, 12);
            this.btnTraerPorID.Name = "btnTraerPorID";
            this.btnTraerPorID.Size = new System.Drawing.Size(75, 35);
            this.btnTraerPorID.TabIndex = 1;
            this.btnTraerPorID.Text = "Buscar";
            this.btnTraerPorID.UseVisualStyleBackColor = true;
            this.btnTraerPorID.Click += new System.EventHandler(this.btnTraerPorID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Traer por CategoriaID";
            // 
            // txtTraer
            // 
            this.txtTraer.Location = new System.Drawing.Point(8, 27);
            this.txtTraer.Name = "txtTraer";
            this.txtTraer.Size = new System.Drawing.Size(106, 20);
            this.txtTraer.TabIndex = 3;
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(204, 12);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(75, 35);
            this.btnTraerTodos.TabIndex = 4;
            this.btnTraerTodos.Text = "Traer todos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.txtTraer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTraerPorID);
            this.Controls.Add(this.gridProduct);
            this.Name = "frmDatos";
            this.Text = "frmDatos";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.Button btnTraerPorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraer;
        private System.Windows.Forms.Button btnTraerTodos;
    }
}