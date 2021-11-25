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
    public partial class HomePage : Form
    {
        StudentClass student = new StudentClass();

        public HomePage()
        {
            InitializeComponent();
            customizeDesign();
           
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            studentCount();
        }

        //create a function to display student count
        private void studentCount()
        {
            //Display the values
            label_totstd.Text = "Total Students : " + student.totalStudent();
            label_malestd.Text = "Male : " + student.maleStudent();
            label_femalestd.Text = "Female : " + student.femaleStudent();

        }

        #region StdSubmenu
        private void Students_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }

        private void button_stdreg_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            hideSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStdForm());
            //code
            hideSubmenu();
        }
        #endregion StdSubmenu


        #region LecSubmenu
        private void button3_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_lecsubmenu);
        }

        private void button_lecreg_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }

        private void button_lecmanage_Click(object sender, EventArgs e)
        {
            //code
            hideSubmenu();
        }
        #endregion LecSubmenu

        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_lecsubmenu.Visible = false;          
        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_lecsubmenu.Visible == true)
               panel_lecsubmenu.Visible = false;
           
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        //to show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_dash_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            
        }

        

    }
}
