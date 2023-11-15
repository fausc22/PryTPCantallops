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
            this.label1 = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvEmpleados
            // 
            this.tvEmpleados.Location = new System.Drawing.Point(12, 28);
            this.tvEmpleados.Name = "tvEmpleados";
            this.tvEmpleados.Size = new System.Drawing.Size(106, 97);
            this.tvEmpleados.TabIndex = 0;
            this.tvEmpleados.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEmpleados_AfterSelect);
            this.tvEmpleados.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvEmpleados_NodeMouseDoubleClick);
            this.tvEmpleados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvEmpleados_MouseDoubleClick);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(146, 28);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(334, 412);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            this.rtbInfo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione empleado:";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(266, 12);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(101, 13);
            this.lblinfo.TabIndex = 3;
            this.lblinfo.Text = "Datos del empleado";
            this.lblinfo.Visible = false;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.tvEmpleados);
            this.Name = "frmEmpleados";
            this.Text = "Sistema de Gestion - Registro de empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvEmpleados;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblinfo;
    }
}