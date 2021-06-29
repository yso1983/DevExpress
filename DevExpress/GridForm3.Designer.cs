
namespace DevExpress
{
    partial class GridForm3
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
            this.uiGrid_Main = new DevExpress.XtraGrid.GridControl();
            this.uiView_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiGrid_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiView_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGrid_Main
            // 
            this.uiGrid_Main.Location = new System.Drawing.Point(12, 12);
            this.uiGrid_Main.MainView = this.uiView_Main;
            this.uiGrid_Main.Name = "uiGrid_Main";
            this.uiGrid_Main.Size = new System.Drawing.Size(776, 405);
            this.uiGrid_Main.TabIndex = 0;
            this.uiGrid_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.uiView_Main});
            // 
            // uiView_Main
            // 
            this.uiView_Main.GridControl = this.uiGrid_Main;
            this.uiView_Main.Name = "uiView_Main";
            // 
            // GridForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiGrid_Main);
            this.Name = "GridForm3";
            this.Text = "GridForm";
            ((System.ComponentModel.ISupportInitialize)(this.uiGrid_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiView_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl uiGrid_Main;
        private XtraGrid.Views.Grid.GridView uiView_Main;
    }
}