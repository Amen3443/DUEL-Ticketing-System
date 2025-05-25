using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUEL_Ticketing_System
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mesfi\OneDrive\Desktop\OOSE\DUEL Ticket tracking system\DUEL Ticketing System\DUEL Ticketing System\DUEL DataBase.mdf; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void patronBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patronBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dUEL_DataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dUEL_DataBaseDataSet.Patron' table. You can move, or remove it, as needed.
            this.patronTableAdapter.Fill(this.dUEL_DataBaseDataSet.Patron);
            SignUppanel.Hide();

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            if (UserNametextBoxL.Text!=""&& PasswordtextBoxL.Text!="")
            {
                try 
                { 
                con.Open();
                String adapter = "select count(*) from Patron where FullName='" + UserNametextBoxL.Text + "'and " + "Password='" + PasswordtextBoxL.Text + "'";
                SqlCommand cmd= new SqlCommand(adapter,con);
                int i = (int)cmd.ExecuteScalar();
                    if (i != 1) 
                    {
                        MessageBox.Show("Error username or password");
                    }
                    else
                    {
                        MessageBox.Show("Wellcome");
                      
                        //WindowState = FormWindowState.Minimized;
                        //ShowInTaskbar = false;
                        //Visible = false;
                        //Shows shows = new Shows();
                        //shows.Show();
                        Shows add= new Shows();
                        add.ShowDialog();
                       
                        this.Close();

                        
                        //Application.Run(new Shows());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the of the form");
            }
           
          con.Close();

        }

        private void PhoneNumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
                if (!String.IsNullOrEmpty(UserNametextBoxS.Text) && !String.IsNullOrEmpty(PasswordtextBoxS.Text) && !String.IsNullOrEmpty(EmailtextBox.Text) && !String.IsNullOrEmpty(AdresstextBox.Text) && !String.IsNullOrEmpty(PhoneNumbertextBox.Text))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Patron values('" + UserNametextBoxS.Text + "','" + EmailtextBox.Text + "','" + PhoneNumbertextBox.Text + "','" + AdresstextBox.Text + "','" + PasswordtextBoxS.Text + "')";
                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Registered Successfully");
                    SignUppanel.Hide();
                    LogInpanel.Show();


                }
                catch (Exception ex)
                    {
                    MessageBox.Show("Wrong Input");
                    PhoneNumbertextBox.Text = "";
                    PhoneNumbertextBox.Focus();
                    }

                }
                else
                    {
                        MessageBox.Show("Please fill out all the of the form");

                    }
            
             con.Close();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUppanel.Show();
        }
    }
}
