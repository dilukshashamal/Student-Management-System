using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class ManageStdForm : Form
    {
        StudentClass student = new StudentClass();


        public ManageStdForm()
        {
            InitializeComponent();
        }

        private void ManageStdForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        // To show student list in DatagridView
        public void showTable()
        {
            DataGridView_student.DataSource = student.getStudentlist();
            DataGridView_student.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
