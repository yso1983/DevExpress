using DevExpress.XtraEditors;
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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        //콤보박스 객체 선언
        private RepositoryItemComboBox gradeComboBox;
        public XtraForm1()
        {
            InitializeComponent();

            this.Shown += DevForm_Shown;
            this.uBtn_Add.Click += UBtn_Add_Click;
            this.uBtn_Delete.Click += UBtn_Delete_Click;
        }

        private void DevForm_Shown(object sender, EventArgs e)
        {
            InitGridCOntrol();

            this.uiGrid_Main.DataSource = GetData();

            //콤보박스 선언
            this.gradeComboBox = new RepositoryItemComboBox();
            this.gridView1.Columns[2].ColumnEdit = this.gradeComboBox;
            InitializeComboBoxEdit();
        }
        private void UBtn_Delete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void UBtn_Add_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void InitializeComboBoxEdit()
        {
            DevExpressHelper.ClearComboBoxEditData(this.gradeComboBox);
            DevExpressHelper.SetComboBoxEditData(this.gradeComboBox, "1", "2", "3", "4");

            this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, "Grade", gradeComboBox.Items[0]);
            this.gradeComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Grade");
            dt.Columns.Add("Score");

            dt.Rows.Add(new string[] { "홍길동", "28", "2", "100" });
            dt.Rows.Add(new string[] { "아무개", "56", "3", "10" });
            dt.Rows.Add(new string[] { "안정환", "34", "2", "78" });
            dt.Rows.Add(new string[] { "설기현", "33", "1", "54" });
            dt.Rows.Add(new string[] { "아이유", "28", "1", "45" });
            dt.Rows.Add(new string[] { "제시", "23", "2", "10" });

            return dt;
        }

        private void InitGridCOntrol()
        {
            GridView gv = this.uiGrid_Main.MainView as GridView;
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsBehavior.Editable = true;

            //Row Cell 스타일 이벤트 선언
            //gv.RowCellStyle += DevForm_RowCellStyle;
        }

        private void DevForm_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            GridView view = sender as GridView;

            if (view == null)
                return;

            if (e.RowHandle != view.FocusedRowHandle)
            {
                if (e.Column.Name.Contains("Name"))
                {
                    e.Appearance.ForeColor = Color.Blue;
                }
                else if (e.Column.Name.Contains("Grade"))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }

            var row = this.gridView1.GetRowCellDisplayText(e.RowHandle, "Name");

            if (row.Equals("홍길동"))
            {
                e.Appearance.BackColor = Color.OrangeRed;
            }
        }
    }

    public class DevExpressHelper
    {
        public static void ClearComboBoxEditData(RepositoryItemComboBox sourceControl)
        {
            sourceControl.Items.Clear();
        }

        public static void SetComboBoxEditData(RepositoryItemComboBox sourceControl, params string[] itemValueArray)
        {
            foreach (var itemValue in itemValueArray)
            {
                sourceControl.Items.Add(itemValue);
            }
        }
    }
}