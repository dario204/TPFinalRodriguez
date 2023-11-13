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
            this.tvArchivos = new System.Windows.Forms.TreeView();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboCodigoEmpleado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tvArchivos
            // 
            this.tvArchivos.Location = new System.Drawing.Point(26, 105);
            this.tvArchivos.Name = "tvArchivos";
            this.tvArchivos.Size = new System.Drawing.Size(408, 229);
            this.tvArchivos.TabIndex = 0;
            this.tvArchivos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArchivos_AfterSelect);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(23, 33);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(83, 18);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cboCodigoEmpleado
            // 
            this.cboCodigoEmpleado.FormattingEnabled = true;
            this.cboCodigoEmpleado.Location = new System.Drawing.Point(134, 30);
            this.cboCodigoEmpleado.Name = "cboCodigoEmpleado";
            this.cboCodigoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cboCodigoEmpleado.TabIndex = 2;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(684, 577);
            this.Controls.Add(this.cboCodigoEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.tvArchivos);
            this.Name = "frmListado";
            this.Text = "frmListado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvArchivos;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboCodigoEmpleado;
    }
}