# Csharp-codes

Welcome to the Csharp-codes repository! This is a comprehensive collection of C# code snippets, examples, and projects to enhance your understanding and mastery of C# programming.

## Table of Contents
- [Introduction](#introduction)
- [Getting Started](#getting-started)
- [Contents](#contents)
- [csharp code](#csharp-code)
- [Contributing](#contributing)
- [Feedback](#feedback)
- [License](#license)

## Introduction

C# is a powerful and versatile programming language used for building a wide range of applications, from desktop to web and mobile. This repository is designed to serve as a valuable resource for developers of all skill levels, offering practical examples and projects covering various C# concepts.

## Getting Started

To begin exploring the Csharp-codes repository, follow these steps:

1. Clone the repository to your local machine using the following command:

    ```bash
    git clone https://github.com/bhargavtz/Csharp-codes.git
    ```

2. Ensure you have [Visual Studio](https://visualstudio.microsoft.com/) or another C# development environment installed.

3. Navigate through the folders to discover code snippets, projects, and tutorials.

## Contents

### Code Snippets

The [code-snippets](code-snippets/) directory contains short and focused code snippets, each highlighting a specific C# feature or concept. These snippets are perfect for quick reference and learning.

### Projects

Explore the [projects](projects/) directory to find larger C# projects. These projects showcase the implementation of more complex applications, allowing you to delve into real-world scenarios.

### Tutorials

The [tutorials](tutorials/) directory offers step-by-step guides on various C# topics. These tutorials provide in-depth explanations and hands-on exercises to deepen your understanding.

## csharp code

1. Create a console application in C# to print a message “Welcome To C#.NET”. 
```bash
using System;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome To C#.NET");
    }
  }
}
```
1. form 1.
```csharp 
   ﻿using System;
 using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4R9OKP6;Initial Catalog=newsql;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            viewCity();
            viewdetails();
        }

        private void viewCity()
        {
            //throw new NotImplementedException();
            SqlDataAdapter ad;
            DataTable dt = new DataTable();
            con.Close();
            ad = new SqlDataAdapter("select cname from tbl_c;", con);
            con.Open();
            ad.Fill(dt);
            con.Close();


            combocity.ValueMember = "cin";
            combocity.DisplayMember = "cname";
            combocity.DataSource = dt; 
        
        }

        private void viewdetails()
        {
            //throw new NotImplementedException();
            SqlDataAdapter ad;
            DataTable dt = new DataTable();
            con.Close();
            ad = new SqlDataAdapter(" select * from tbl_e ", con);
            con.Open();
            ad.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        public string gender()
        {
            if (rm.Checked)
            {
                return "M";
            }
            else if (rf.Checked)
            {
                return "F";
            }
            else // No radio button selected
            {
                return ""; // Or throw an exception if gender selection is mandatory
            }
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            int city;
            city = Convert.ToInt32(combocity.SelectedIndex);
            city += 1;
            SqlCommand cmd;
            con.Close();
            cmd = new SqlCommand("insert into tbl_e values ('"+txtname.Text+"','"+gender()+"',"+city+");", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted successfully!");
            

            viewCity();
            viewdetails();
        }
    }
 }
```
3. form 3.
```csharp
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        SqlConnection con= new SqlConnection("Data Source=DESKTOP-4R9OKP6;Initial Catalog=Aelis;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            viewCity();
            viewdetails();
        }

        private void viewCity()
        {
            //throw new NotImplementedException();
            SqlDataAdapter ad;
            DataTable dt = new DataTable();
            con.Close();
            ad = new SqlDataAdapter("select distinct cname from tblcity;", con);
            con.Open();
            ad.Fill(dt);
            con.Close();

           
           combocity.ValueMember = "cid";
           combocity.DisplayMember = "cname";
           combocity.DataSource = dt; 
        }
        private void cll() {
            txtfname.Clear();
            txtenro.Clear();
            txtcontact.Clear();
            txtlname.Clear();
            txtcity.Clear();
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtfname.Text) || string.IsNullOrWhiteSpace(txtlname.Text) || string.IsNullOrWhiteSpace(txtcontact.Text))
            {
                MessageBox.Show("Please enter all details before inserting.");
                return;
            }

            try
            {
                SqlCommand cmd;
                con.Close();
                cmd = new SqlCommand("insert into tbl values ('" + txtfname.Text + "','" + txtlname.Text + "'," + txtcontact.Text + ",'"+txtcity.Text+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record inserted successfully!");
                cll();
                
                viewCity();
                viewdetails();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while inserting the record: " + ex.Message);
            }
        }
        public void viewdetails() {
            SqlDataAdapter ad ;
            DataTable dt = new DataTable();
            con.Close();
            ad = new SqlDataAdapter(" select * from tbl_stud ",con);
            con.Open();
            ad.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtenro.Text))
            {
                MessageBox.Show("Please enter Enrollment Number.");
                return;
            }

            try
            {
                con.Close();
                SqlCommand cmd;
                cmd = new SqlCommand("select * from tbl_stud where Enrollmentno = " + txtenro.Text + ";", con);
                SqlDataReader dr;
                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    txtfname.Text = dr.GetValue(1).ToString();
                    txtlname.Text = dr.GetValue(2).ToString();
                    txtcontact.Text = dr.GetValue(3).ToString();
                    txtcity.Text = dr.GetValue(4).ToString();
                }
                else
                {
                    MessageBox.Show("Data is not available for the entered Enrollment Number.");
                    txtfname.Clear();
                    txtlname.Clear();
                    txtcontact.Clear();
                    txtcity.Clear();
                }

                dr.Close();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while retrieving the record: " + ex.Message);
            }
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtenro.Text) || string.IsNullOrWhiteSpace(txtfname.Text) || string.IsNullOrWhiteSpace(txtlname.Text) || string.IsNullOrWhiteSpace(txtcontact.Text) || string.IsNullOrWhiteSpace(txtcity.Text))
            {
                MessageBox.Show("Please enter all details before updating.");
                return;
            }

            try
            {
                SqlCommand cmd;
                con.Close();
                cmd = new SqlCommand("update tbl_stud set Firstname ='" + txtfname.Text + "', Lastname = '" + txtlname.Text + "', Contactno = " + txtcontact.Text + ",City ='"+txtcity.Text+"' where Enrollmentno = " + txtenro.Text + ";", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated successfully!");
                cll();
                
                viewCity();
                viewdetails();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while updating the record: " + ex.Message);
            }
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtenro.Text))
            {
                MessageBox.Show("Please enter Enrollment Number.");
                return;
            }

            try
            {
                SqlCommand cmd;
                con.Close();
                cmd = new SqlCommand("delete from tbl_stud where Enrollmentno = " + txtenro.Text + ";", con);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record Deleted successfully!");
                    cll();
                    
                    viewCity();
                    viewdetails();
                }
                else
                {
                    MessageBox.Show("No record found for the entered Enrollment Number.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while deleting the record: " + ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            txtenro.Enabled = true;
           
            viewCity();
            viewdetails();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtenro.Text))
            {
                MessageBox.Show("Please enter Enrollment Number.");
                return;
            }

            try
            {
                SqlCommand cmd;
                con.Close();
                cmd = new SqlCommand("select * from tbl_stud where Enrollmentno = " + txtenro.Text + ";", con);
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Record not found for the entered Enrollment Number.");
                    dataGridView1.DataSource = null;
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while retrieving the record: " + ex.Message);
            }
        }

        private void combocity_SelectedIndexChanged(object sender, EventArgs e)
        {
                string selectedCity = combocity.Text;

                SqlDataAdapter ad;
                DataTable dt = new DataTable();
                con.Close();
                ad = new SqlDataAdapter("select * from tbl_stud where City = '" + selectedCity + "';", con);
                con.Open();
                ad.Fill(dt);
                con.Close();
                //DataView dv = new DataView(dt);
               // dv.ro
            dataGridView1.DataSource = dt;
            
        }
    }
}
```
4. form3 .
```
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFOnt_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK){
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK){
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btncenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnbold_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Bold);
        }

        private void btnitalic_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Italic);
        }

        private void btnunderline_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Underline);
        }
    }
}
```

## Contributing

We welcome contributions to enhance the content and breadth of this repository. To contribute:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push your changes to your fork.
5. Create a pull request to the `main` branch of the original repository.

Please adhere to the [Code of Conduct](CODE_OF_CONDUCT.md) and the [Contribution Guidelines](CONTRIBUTING.md).

## Feedback

Your feedback is essential! If you have suggestions, find bugs, or want to request specific content, please [open an issue](https://github.com/bhargavtz/Csharp-codes/issues).

## License

This project is licensed under the [MIT License](LICENSE). Feel free to use the code in this repository for your own projects.

Happy coding!
