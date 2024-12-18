using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enity.Models;

namespace Enity
{
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFaculties = context.Faculty.ToList(); // Lấy danh sách khoa
                List<Student> listStudents = context.Student.ToList(); // Lấy danh sách sinh viên
                FillFalcultyCombobox(listFaculties);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var student in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = student.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = student.FullName;
                dgvStudent.Rows[index].Cells[2].Value = student.Faculty?.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = student.AverageScore;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                if (context.Student.Any(s => s.StudentID == txtStudentId.Text))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newStudent = new Student
                {
                    StudentID = txtStudentId.Text.Trim(),
                    FullName = txtFullname.Text.Trim(),
                    AverageScore = double.Parse(txtAverageScore.Text.Trim()),
                    FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString())
                };

                context.Student.Add(newStudent);
                context.SaveChanges();

                BindGrid(context.Student.ToList());
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudent.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string studentID = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
                StudentContextDB context = new StudentContextDB();
                var studentToUpdate = context.Student.FirstOrDefault(s => s.StudentID == studentID);

                if (studentToUpdate != null)
                {
                    studentToUpdate.FullName = txtFullname.Text.Trim();
                    studentToUpdate.AverageScore = double.Parse(txtAverageScore.Text.Trim());
                    studentToUpdate.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());

                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindGrid(context.Student.ToList());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudent.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string studentID = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
                StudentContextDB context = new StudentContextDB();
                var studentToDelete = context.Student.FirstOrDefault(s => s.StudentID == studentID);

                if (studentToDelete != null)
                {
                    context.Student.Remove(studentToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindGrid(context.Student.ToList());
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ClearInputFields()
        {
            txtStudentId.Clear();
            txtFullname.Clear();
            txtAverageScore.Clear();
            cmbFaculty.SelectedIndex = -1;
        }
    }
}
