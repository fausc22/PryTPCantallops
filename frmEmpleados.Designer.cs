namespace PryTPCantallops
{
    partial class frmEmpleados
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
            this.tvEmpleados = new System.Windows.Forms.TreeView();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tvEmpleados
            // 
            this.tvEmpleados.Location = new System.Drawing.Point(144, 81);
            this.tvEmpleados.Name = "tvEmpleados";
            this.tvEmpleados.Size = new System.Drawing.Size(121, 97);
            this.tvEmpleados.TabIndex = 0;
            this.tvEmpleados.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvEmpleados_NodeMouseDoubleClick);
            this.tvEmpleados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvEmpleados_MouseDoubleClick);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(383, 82);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(334, 191);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.tvEmpleados);
            this.Name = "frmEmpleados";
            this.Text = "Sistema de Gestion - Registro de empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvEmpleados;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}