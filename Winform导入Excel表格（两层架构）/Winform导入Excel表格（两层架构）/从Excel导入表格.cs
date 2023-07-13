using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using Models;

namespace Winform导入Excel表格_两层架构_
{
    public partial class 从Excel导入表格 : Form
    {
        public 从Excel导入表格()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //打开excel
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Application.StartupPath;
            DialogResult = openFile.ShowDialog();

            if (DialogResult == System.Windows.Forms.DialogResult.OK) //成功打开
            {
                string path = openFile.FileName;    //这个就是文件的路径

                StudentClassService stuClassService = new StudentClassService();
                List<StudentClass> list = stuClassService.GetAllClass(path);
                this.dataGridView1.DataSource = list;
                
            }
            
        }

        private void 从Excel导入表格_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
