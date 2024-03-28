using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1_061
{
    public partial class pr4_5 : Form
    {
        public pr4_5()
        {
            InitializeComponent();
        }

      
        private void pr4_5_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Employee ID",100);
            listView1.Columns.Add("First Name",50);
            listView1.Columns.Add("Last Name",50);
            listView1.Columns.Add("City",50);
            listView1.Columns.Add("Contact No.",100);
            listView1.Columns.Add("Date of Joining",100);
            listView1.Columns.Add("Salary",50);
            String[] arr = new String[10];
            ListViewItem i;
            arr[0] = "101";
            arr[1] = "Siya";
            arr[2] = "Vora";
            arr[3] = "Surat";
            arr[4] = "9909867543";
            arr[5] = "09-02-2020";
            arr[6] = "50000";
            i = new ListViewItem(arr);
            listView1.Items.Add(i);

            arr[0] = "102";
            arr[1] = "Riya";
            arr[2] = "Siroya";
            arr[3] = "Bardoli";
            arr[4] = "9809856443";
            arr[5] = "01-01-2020";
            arr[6] = "70000";
            i = new ListViewItem(arr);
            listView1.Items.Add(i);

            arr[0] = "103";
            arr[1] = "Tiya";
            arr[2] = "Maniya";
            arr[3] = "Surat";
            arr[4] = "7809867543";
            arr[5] = "01-12-2020";
            arr[6] = "80000";
            i = new ListViewItem(arr);
            listView1.Items.Add(i);

           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show(listView1.SelectedItems.);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strID = listView1.SelectedItems[0].SubItems[0].Text;
            string strname = listView1.SelectedItems[0].SubItems[1].Text;
            string strLName = listView1.SelectedItems[0].SubItems[2].Text;
            string strCity = listView1.SelectedItems[0].SubItems[3].Text;
            string strContactNo = listView1.SelectedItems[0].SubItems[4].Text;
            string strdate = listView1.SelectedItems[0].SubItems[5].Text;
            string strsal = listView1.SelectedItems[0].SubItems[6].Text;
            MessageBox.Show(strID + " , " + strname + " , " + strLName + " , " + strCity + " , " + strContactNo + " , " + strdate + " , " + strsal);
        }
    }
}
