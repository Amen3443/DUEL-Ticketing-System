using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUEL_Ticketing_System
{
    internal class Show
    {
        public int Id { get; set; }
        public string Show_Title { get ;  set ; }
        public string Show_Type { get ;  set ; }
        
        public void setID(int id)
        {
            this.Id = id;
        }
        public void setShowTitle(String title)
        {
            this.Show_Type=title;
        }
        public void setshowtype(String type)
        {
            this.Show_Type = type;
        }

        SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mesfi\OneDrive\Desktop\OOSE\DUEL Ticket tracking system\DUEL Ticketing System\DUEL Ticketing System\DUEL DataBase.mdf; Integrated Security = True");
         
        List<Show> showlist=new List<Show>();
        Show[]shows = new Show[89];
        public void Addshows(string  title,string type)
            {
                try { 
                con.Open();
                string query = "Insert into Show(ShowTitle,ShowType) " + "Values('" + title + "','" + type + "')";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        public DataSet DisplayShows()
        {
           
            con.Open();
            string query = " SELECT * FROM Show";
            SqlCommand cmd= new SqlCommand();
            cmd.Connection=con;
            cmd.CommandType=CommandType.Text;
            cmd.CommandText=query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet1 = new DataSet();
            adapter.Fill(dataSet1);
            con.Close();


            int shownum = 0;
            DataTable dt = new DataTable();
            dt = dataSet1.Tables[0];
             shownum= dt.Rows.Count;


            for (int i = 0; i < shownum; i++)
            {

                shows[i] = new Show() ;
                DataRow dr = dt.Rows[i];



                //showlist[i].Id=(int)dr[0];
                //showlist[i].Show_Title= dr[0].ToString();
                //showlist[i].Show_Type= dr[0].ToString();

                shows[i].setID((int)dr[0]);
                shows[i].setShowTitle((string)dr[1]);
                shows[i].setshowtype((string)dr[2]);


            }
            return dataSet1;
           

        }
        

    }
    


}
