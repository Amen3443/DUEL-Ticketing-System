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
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        private void addShowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddShows addShows = new AddShows();
            addShows.ShowDialog();
        }
    }
}
