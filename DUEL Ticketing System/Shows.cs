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
    public partial class Shows : Form
    {
        SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mesfi\OneDrive\Desktop\OOSE\DUEL Ticket tracking system\DUEL Ticketing System\DUEL Ticketing System\DUEL DataBase.mdf; Integrated Security = True");

        public Shows()
        {
            InitializeComponent();
        }

        private void Shows_Load(object sender, EventArgs e)
        {
           ;// TODO: This line of code loads data into the 'dUEL_DataBaseDataSet1.Show' table. You can move, or remove it, as needed.
           // this.showTableAdapter.Fill(this.dUEL_DataBaseDataSet1.Show);

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void Selectbutton_Click(object sender, EventArgs e)
        {
             
        }

        private void ConcertradioButton_CheckedChanged(object sender, EventArgs e)
        {
           DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            String showtitle;
            da.SelectCommand = new SqlCommand("select Distinct data from from show where ShowTitle");
          
            string query = "select * from Show where ShowType=concert'";
           



        }

        private void showBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dUEL_DataBaseDataSet1);

        }

        private void pictureBox2_Click(object sender, EventArgs e) 
            
        { 
        
            if (pictureBox1.BackColor == Color.Red)
            {
                pictureBox1.BackColor = Color.RoyalBlue;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }
           

        }
    public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AddShows shows
                           = new AddShows();
            shows.Show();
        }
    }
}
