
namespace DevExpress
{
    partial class frmProgressPanel
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
            this.uiProg_Wait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SuspendLayout();
            // 
            // uiProg_Wait
            // 
            this.uiProg_Wait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.uiProg_Wait.Appearance.Options.UseBackColor = true;
            this.uiProg_Wait.Location = new System.Drawing.Point(26, 88);
            this.uiProg_Wait.Name = "uiProg_Wait";
            this.uiProg_Wait.Size = new System.Drawing.Size(246, 66);
            this.uiProg_Wait.TabIndex = 0;
            this.uiProg_Wait.Text = "progressPanel1";
            // 
            // frmProgressPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.uiProg_Wait);
            this.Name = "frmProgressPanel";
            this.Text = "frmProgressPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private XtraWaitForm.ProgressPanel uiProg_Wait;
    }
}