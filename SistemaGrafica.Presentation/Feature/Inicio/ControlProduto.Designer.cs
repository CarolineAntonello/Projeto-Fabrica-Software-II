namespace SistemaGrafica.Presentation.Feature.Inicio
{
    partial class ControlProduto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listProduto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listProduto
            // 
            this.listProduto.FormattingEnabled = true;
            this.listProduto.Location = new System.Drawing.Point(0, 0);
            this.listProduto.Name = "listProduto";
            this.listProduto.Size = new System.Drawing.Size(437, 212);
            this.listProduto.TabIndex = 0;
            // 
            // ControlProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listProduto);
            this.Name = "ControlProduto";
            this.Size = new System.Drawing.Size(440, 209);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProduto;
    }
}
