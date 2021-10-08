using HMS.BLL;
using HMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.PL
{
    public partial class VisitorsPL : Form
    {
        VisitorsBLL visitorsBLL =  new VisitorsBLL();
        public VisitorsPL()
        {
            InitializeComponent();
            LoadGridView();
            PageAccess();
        }

        public void PageAccess()
        {
            var res = LoginDAL.lstUserRole.Where(x => x.PageName == "Visitors").FirstOrDefault();
            if (res != null)
            {
                if (res.AddCommand == true)
                {
                    button1.Visible = true;
                }

                if (res.EditCommand == true)
                {
                    dgvVisitors.Columns[0].Visible = true;
                }

                if (res.DeleteCommand == true)
                {
                    dgvVisitors.Columns[1].Visible = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AddVisitorsPL))
                {
                    f.Activate();
                    return;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(AddVisitorsPL))
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = new AddVisitorsPL(LoadGridView,0);
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        public int  LoadGridView()
        {
            visitorsBLL.GetVisitors(dgvVisitors);
            return 0;
        }

        private void dgvVisitors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVisitors.Columns["Edite"].Index && e.RowIndex >= 0)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AddVisitorsPL))
                    {
                        f.Activate();
                        return;
                    }
                }
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(AddVisitorsPL))
                    {
                        f.Activate();
                        return;
                    }
                }

                int Id = Convert.ToInt32(dgvVisitors.Rows[e.RowIndex].Cells[2].Value);
                 Form frm = new AddVisitorsPL(LoadGridView, Id);
                frm.MdiParent = MasterForm.ActiveForm;
                frm.Show();


            }

            if (e.ColumnIndex == dgvVisitors.Columns["DELETE"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvVisitors.Rows[e.RowIndex].Cells[2].Value);

                DialogResult dialogResult = MessageBox.Show("Want to delete?","System Alert",  MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    if (DeleteAppoiment(id) > 0)
                    {
                        MessageBox.Show("Delete Succesfully","System Alert",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        visitorsBLL.GetVisitors(dgvVisitors);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
                
            }
        }

        public int DeleteAppoiment(int id)
        {
            return  visitorsBLL.DeleteVisiter(id);
        }
    }
}
