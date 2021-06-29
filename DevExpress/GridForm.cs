using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress
{
    public partial class GridForm : DevExpress.XtraEditors.XtraForm
    {
        public GridForm()
        {
            InitializeComponent();
            this.Shown += DevForm_Shown;
        }

        private void DevForm_Shown(object sender, EventArgs e)
        {
            InitGridControl();

            this.uiGrid_Main.DataSource = GetData();
            InitCheckBox();
        }

        private void InitCheckBox()
        {
            RepositoryItemCheckEdit repositoryCheckEdit = uiGrid_Main.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;
            repositoryCheckEdit.ValueChecked = "True";
            repositoryCheckEdit.ValueUnchecked = "False";
            gridView1.Columns["Check"].ColumnEdit = repositoryCheckEdit;

            gridView1.OptionsSelection.MultiSelect = true;
        }

        private object GetData()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Grade");
            dt.Columns.Add("Score");
            dt.Columns.Add("Check");

            dt.Rows.Add(new string[] { "홍길동", "28", "2", "100", "True" });
            dt.Rows.Add(new string[] { "아무개", "56", "3", "10", "True" });
            dt.Rows.Add(new string[] { "안정환", "34", "2", "78", "False" });
            dt.Rows.Add(new string[] { "설기현", "33", "1", "54", "False" });
            dt.Rows.Add(new string[] { "아이유", "28", "1", "45", "True" });
            dt.Rows.Add(new string[] { "제시", "23", "2", "10", "False" });

            return dt;
        }

        private void InitGridControl()
        {
            GridView gv = this.uiGrid_Main.MainView as GridView;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsBehavior.Editable = true;
        }
    }
}
