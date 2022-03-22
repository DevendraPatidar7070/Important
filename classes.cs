using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace Allforms
{
    public class classes
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager. ConnectionStrings["shiv"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        public string datetime = "yyyy-MM-dd HH:mm:ss:fff";
        public void ExecuteQuery(string sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //da.SelectCommand = cmd;
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public DataTable SelectQuery(string sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            da.SelectCommand = cmd;
            cmd.Connection = con;
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return (dt);
        }
        public int updateimage(string query, byte[] barcode)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res;
            cmd.CommandText = query;
            cmd.Parameters.Add("@barcode", SqlDbType.Image).Value = barcode;
            cmd.Connection = con;
            res = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
            return res;
        }
        public int insertscalar(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res;
            cmd.CommandText = query;
            cmd.Connection = con;
            res = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return res;
        }

        public int deletewithpopup(string query)
        {
            cmd.CommandText = query;
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public int insert(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res;
            cmd.CommandText = query;
            cmd.Connection = con;
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int delete(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = query;
            cmd.Connection = con;
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public DataTable select(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = query;
            cmd.Connection = con;
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public Bitmap selectimage(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = query;
            cmd.Connection = con;
            da.SelectCommand = cmd;
            byte[] img = (byte[])cmd.ExecuteScalar();
            MemoryStream str = new MemoryStream();
            str.Write(img, 0, img.Length);
            Bitmap bit = new Bitmap(str);
            con.Close();
            return bit;
        }
        public int update(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = query;
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int insertimage(string query, byte[] qrcode, byte[] barcode)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res;
            cmd.CommandText = query;
            cmd.Parameters.Add("@qrcode", SqlDbType.Image).Value = qrcode;
            cmd.Parameters.Add("@barcode", SqlDbType.Image).Value = barcode;
            cmd.Connection = con;
            res = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
            return res;
        }
        public int insertstaff(string query, byte[] photo, byte[] sign, byte[] qrcode, byte[] barcode)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res;
            cmd.CommandText = query;
            cmd.Parameters.Add("@qrcode", SqlDbType.Image).Value = qrcode;
            cmd.Parameters.Add("@barcode", SqlDbType.Image).Value = barcode;
            cmd.Parameters.Add("@photo", SqlDbType.Image).Value = photo;
            cmd.Parameters.Add("@sign", SqlDbType.Image).Value = sign;
            cmd.Connection = con;
            res = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
            return res;
        }
        public int updatestaffPhoto(string query, byte[] photo)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res;
            cmd.CommandText = query;
            cmd.Parameters.Add("@photo", SqlDbType.Image).Value = photo;
            cmd.Connection = con;
            res = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
            return res;
        }
        public int updatestaffsign(string query, byte[] sign)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res;
            cmd.CommandText = query;
            cmd.Parameters.Add("@sign", SqlDbType.Image).Value = sign;
            cmd.Connection = con;
            res = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
            return res;
        }
        public int updateimagebarcode(string query, byte[] barcode)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res;
            cmd.CommandText = query;
            cmd.Parameters.Add("@barcode", SqlDbType.Image).Value = barcode;
            cmd.Connection = con;
            res = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
            return res;
        }
        public int updateimageqrcode(string query, byte[] qrcode)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int res;
            cmd.CommandText = query;
            cmd.Parameters.Add("@qrcode", SqlDbType.Image).Value = qrcode;
            cmd.Connection = con;
            res = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
            return res;
        }
        public string getmonthname(int num)
        {
            if (num == 1)
            {
                return "January";
            }
            else if (num == 2)
            {
                return "February";
            }
            else if (num == 3)
            {
                return "March";
            }
            else if (num == 4)
            {
                return "April";
            }
            else if (num == 5)
            {
                return "May";
            }
            else if (num == 6)
            {
                return "June";
            }
            else if (num == 7)
            {
                return "July";
            }
            else if (num == 8)
            {
                return "August";
            }
            else if (num == 9)
            {
                return "September";
            }
            else if (num == 10)
            {
                return "October";
            }
            else if (num == 11)
            {
                return "November";
            }
            else if (num == 12)
            {
                return "December";
            }
            else
            {
                return "value out of index";
            }
        }
        public string NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += " ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}