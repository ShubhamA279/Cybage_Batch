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

namespace FileIODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Cybage\test.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter br = new BinaryWriter(fs);
                br.Write(Convert.ToInt32(txtId.Text));
                br.Write(txtName.Text);
                br.Write(txtLocation.Text);
                br.Close();
                fs.Close();
                MessageBox.Show("data added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Cybage\test.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\Cybage\test.txt";
            if (File.Exists(path))
            {
                MessageBox.Show("File is alrady exists");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("File Created");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            string path = @"D:\Cybage";
            if (Directory.Exists(path))
            {
                MessageBox.Show("Directory is already exists");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Created");
            }

        }
    }
}
