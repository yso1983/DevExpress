
namespace DevExpress
{
    partial class XtraForm1
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.uBtn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.uBtn_Delete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiGrid_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGrid_Main
            // 
            this.uiGrid_Main.Location = new System.Drawing.Point(12, 12);
            this.uiGrid_Main.MainView = this.gridView1;
            this.uiGrid_Main.Name = "uiGrid_Main";
            this.uiGrid_Main.Size = new System.Drawing.Size(1192, 767);
            this.uiGrid_Main.TabIndex = 0;
            this.uiGrid_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.uiGrid_Main;
            this.gridView1.Name = "gridView1";
            // 
            // uBtn_Add
            // 
            this.uBtn_Add.Location = new System.Drawing.Point(823, 785);
            this.uBtn_Add.Name = "uBtn_Add";
            this.uBtn_Add.Size = new System.Drawing.Size(159, 63);
            this.uBtn_Add.TabIndex = 1;
            this.uBtn_Add.Text = "Add";
            // 
            // uBtn_Delete
            // 
            this.uBtn_Delete.Location = new System.Drawing.Point(1010, 785);
            this.uBtn_Delete.Name = "uBtn_Delete";
            this.uBtn_Delete.Size = new System.Drawing.Size(159, 63);
            this.uBtn_Delete.TabIndex = 2;
            this.uBtn_Delete.Text = "Delete";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 860);
            this.Controls.Add(this.uBtn_Delete);
            this.Controls.Add(this.uBtn_Add);
            this.Controls.Add(this.uiGrid_Main);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.uiGrid_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl uiGrid_Main;
        private XtraGrid.Views.Grid.GridView gridView1;
        private XtraEditors.SimpleButton uBtn_Add;
        private XtraEditors.SimpleButton uBtn_Delete;
    }
}