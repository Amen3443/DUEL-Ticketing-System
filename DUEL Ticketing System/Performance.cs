using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUEL_Ticketing_System
{
    internal class Performance
    {
        int performanceID{  get; set; }
        int eventID {  get; set; }
        DateTime performanceDate {  get; set; }
        String Time { get; set; }
        double price {  get; set; }

        SqlConnection con = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mesfi\OneDrive\Desktop\OOSE\DUEL Ticket tracking system\DUEL Ticketing System\DUEL Ticketing System\DUEL DataBase.mdf; Integrated Security = True");


        public void addPerformance(int ID,DateTime Date,string time,double price)
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            sqlCommand.CommandType= System.Data.CommandType.Text;
            sqlCommand.CommandText = "insert into Performance(eventID,performanceDate,time,seatPrice values('" + ID + "','" + Date.ToString("MM/dd/yyyy") + "','" + time + "','" + price + "')";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Select SCOPE_IDENTITY()";
            int identity=(int)sqlCommand.ExecuteScalar();
            con.Close();
            assignSeats(identity);
        }
        public void assignSeats(int i)
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            sqlCommand.CommandType= System.Data.CommandType.Text;
            for (int j = 0; j < 8; j++)
            {
                char row= (char)(j+64);
                for (global::System.Int32 k = 0; k < 18; k++)
                {
                 sqlCommand.CommandText="insert into Seat(seatRow,seatNumber,performanceID,available,bookingID) values('"+row+"','"+k+"','"+performanceID+"','"+"0"+"','"+"0" + "')";
                    sqlCommand.ExecuteNonQuery();
                }
            }
            con.Close() ;
        }

    }
}
