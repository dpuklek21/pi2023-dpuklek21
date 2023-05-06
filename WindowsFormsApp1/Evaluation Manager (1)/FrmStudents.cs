using Evaluation_Manager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class dgvStudents : Form
    {
        public dgvStudents()
        {
            InitializeComponent();
        }

        private void dgvStudents_Load(object sender, EventArgs e) {
            ShowStudents();
        }
        private void ShowStudents() {
            List<Student> students = StudentRepository.GetStudents();
            dgvStudents.DataSource = students;

        }
    }
}
