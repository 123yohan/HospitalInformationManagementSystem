using HMS.BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.PL
{
    public partial class ApprovedAppoinmentPL : Form
    {
        AppoitmentBLL appoitmentBLL;
        AppointmentReportBLL AppointmentReportBLL;
        public ApprovedAppoinmentPL()
        {
            InitializeComponent();
            appoitmentBLL = new AppoitmentBLL();
            AppointmentReportBLL = new AppointmentReportBLL();
            AppointmentReportBLL.GetApprovedAppointments(dgvAppointmentReport);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApprovedAppoinmentPL_Load(object sender, EventArgs e)
        {

        }

        public async void CompletedAppoiment()
        {
           await appoitmentBLL.CompletedAppointment(1);
        }

        private async void dgvAppointmentReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                DataGridViewRow row = dgvAppointmentReport.Rows[e.RowIndex];
                row.Cells["Completed"].Value = !Convert.ToBoolean(row.Cells["Completed"].EditedFormattedValue);
                if (Convert.ToBoolean(row.Cells["Completed"].Value))
                {

                    await appoitmentBLL.CompletedAppointment(Convert.ToInt32(row.Cells[6].Value));
                    AppointmentReportBLL.GetApprovedAppointments(dgvAppointmentReport);
                }
            }
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (dgvAppointmentReport.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dgvAppointmentReport.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dgvAppointmentReport.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            //Adding DataRow
                            foreach (DataGridViewRow row in dgvAppointmentReport.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pTable.AddCell(cell.Value.ToString());
                                }
                            }
                  
                            

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }

        }
    }
}
