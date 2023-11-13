namespace TPFinalRodriguez
{
    partial class frmListado
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
            this.cboCodigoEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.tvArchivos = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // cboCodigoEmpleado
            // 
            this.cboCodigoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoEmpleado.FormattingEnabled = true;
            this.cboCodigoEmpleado.Location = new System.Drawing.Point(275, 39);
            this.cboCodigoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cboCodigoEmpleado.Name = "cboCodigoEmpleado";
            this.cboCodigoEmpleado.Size = new System.Drawing.Size(160, 24);
            this.cboCodigoEmpleado.TabIndex = 5;
            this.cboCodigoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboCodigoEmpleado_SelectedIndexChanged);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(127, 43);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(105, 24);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.Text = "Empleado";
            // 
            // tvArchivos
            // 
            this.tvArchivos.Location = new System.Drawing.Point(131, 131);
            this.tvArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.tvArchivos.Name = "tvArchivos";
            this.tvArchivos.Size = new System.Drawing.Size(543, 281);
            this.tvArchivos.TabIndex = 3;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCodigoEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.tvArchivos);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCodigoEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TreeView tvArchivos;
    }
}