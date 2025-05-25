using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUEL_Ticketing_System
{
    public partial class AddShows : Form
    {
        Show sh = new Show();
       

        public AddShows()
        {
            InitializeComponent();
        }

        private void SaveShowbutton_Click(object sender, EventArgs e)
        {
         
            Show show = new Show();
            if (ConcertradioButton.Checked)
            {
                show.Addshows(AddShowTitle.Text, ConcertradioButton.Text);
            }
            else
            {
                show.Addshows(AddShowTitle.Text, PlayradioButton.Text);
            }
            MessageBox.Show("Saved succesfully");
           
            //DataSet shows= sh.DisplayShows();
            //dataGridViewAdd.DataSource = shows;
            //DataTable dt = new DataTable();
            //dt= shows.Tables[0];
            //for (int i = 0; i < shows.Tables[0].Rows.Count; i++)
            //{
            //    dataGridViewAdd.Rows.Add(dt.Rows[0], dt.Rows[1], dt.Rows[2]);
            //}
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddShows_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dUEL_DataBaseDataSet1.Show' table. You can move, or remove it, as needed.
          //  this.showTableAdapter.Fill(this.dUEL_DataBaseDataSet1.Show);

            sh.DisplayShows();
            //for (int i = 0; i < shows.Length; i++)
            //{
            //    dataGridViewAdd.Rows.Add(shows[i].Id, shows[i].Show_Title, shows[i].Show_Type);
            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dUEL_DataBaseDataSet1);

        }
    }
}
