using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmStudent : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            try

            {
                setGridViewStyle(dataGV);
                var listFacultys = facultyService.GetAll();
                var listStudents = studentService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<Student> listStudents)
        {
            dataGV.Rows.Clear();
            foreach (var item in listStudents)
            {
                int index = dataGV.Rows.Add();
                dataGV.Rows[index].Cells[0].Value = item.StudentID;
                dataGV.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dataGV.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGV.Rows[index].Cells[3].Value = item.AverageScore + "";
                if (item.MajorID != null)
                    dataGV.Rows[index].Cells[4].Value = item.Major.MajorName + "";

            }
        }


        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.cbbkhoa.DataSource = listFacultys;
            this.cbbkhoa.DisplayMember = "FacultyName";
            this.cbbkhoa.ValueMember = "FacultyID";
        }



        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnaddupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student
                {
                    StudentID = int.Parse(txtmssv.Text),
                    FullName = txthoten.Text,
                    FacultyID = int.Parse(cbbkhoa.SelectedValue.ToString()),
                    AverageScore = double.Parse(txtdtb.Text)
                };

                studentService.InsertUpdate(student);

                MessageBox.Show("Student added/updated successfully.");

                var listStudents = studentService.GetAll();
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvSV(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGV.Rows[e.RowIndex];
                txtmssv.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                cbbkhoa.Text = row.Cells[2].Value.ToString();
                txtdtb.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGV.SelectedRows.Count > 0)
                {
                    int studentID = int.Parse(dataGV.SelectedRows[0].Cells[0].Value.ToString());

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?",
                        "Delete Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        studentService.Delete(studentID);

                        MessageBox.Show("Student deleted successfully.");

                        var listStudents = studentService.GetAll();
                        BindGrid(listStudents);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.chkUnregisterMajor.Checked)
                listStudents = studentService.GetAllHasNoMajor();
            else
                listStudents = studentService.GetAll();
            BindGrid(listStudents);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
                return;
        }
    }
}
