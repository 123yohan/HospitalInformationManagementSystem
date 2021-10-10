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
    public partial class PostalViewPL : Form
    {
        PostalBLL postalBLL;
       
        public PostalViewPL()
        {
            InitializeComponent();
            postalBLL = new PostalBLL();

            DataLoadGrid();
            PageAccess();
        }

        public void PageAccess()
        {
            var res = LoginDAL.lstUserRole.Where(x => x.PageName == "Postal").FirstOrDefault();
            if (res != null)
            {
                if (res.AddCommand == true)
                {
                    btnAddPostal.Visible = true;
                }

                if (res.EditCommand == true)
                {
                    dgvPostal.Columns[0].Visible = true;
                }

                if (res.DeleteCommand == true)
                {
                    dgvPostal.Columns[8].Visible = true;
                }
            }
        }

        public int DataLoadGrid()
        {
            
                postalBLL.GetAllPostals(dgvPostal);
                return 0;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPostal_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(AddPostalPL))
                {
                    f.Activate();
                    return;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(AddPostalPL))
                {
                    f.Activate();
                    return;
                }
            }
           
            Form frm = new AddPostalPL(DataLoadGrid,0);
            frm.MdiParent = MasterForm.ActiveForm;
            frm.Show();
        }

        private void dgvPostal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPostal.Columns["Edite"].Index && e.RowIndex >= 0)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == typeof(AddPostalPL))
                    {
                        f.Activate();
                        return;
                    }
                }
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(AddPostalPL))
                    {
                        f.Activate();
                        return;
                    }
                }

                int Id = Convert.ToInt32(dgvPostal.Rows[e.RowIndex].Cells[1].Value);
                Form frm = new AddPostalPL(DataLoadGrid,Id);
                frm.MdiParent = MasterForm.ActiveForm;
                frm.Show();


            }



            if (e.ColumnIndex == dgvPostal.Columns["DELETE"].Index && e.RowIndex >= 0)
            {

                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    int Id = Convert.ToInt32(dgvPostal.Rows[e.RowIndex].Cells[1].Value);
                    if (DeleteAppoiment(Id) > 0)
                    {
                        MessageBox.Show("Delete Succesfully", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataLoadGrid();
                    }
                }

                
            }
        }

        public int DeleteAppoiment(int id)
        {
            return postalBLL.DeletePostal(id);
        }

        private void PostalViewPL_Load(object sender, EventArgs e)
        {

        }
    }
}
