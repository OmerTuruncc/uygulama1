using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Istinye
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G1GPA3B;Initial Catalog=Kullanıcı_giris;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buton_giris_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Label1.Text = "giris basarılı";
           SqlConnection baglanti =new SqlConnection("Data Source=DESKTOP-G1GPA3B;Initial Catalog=Kullanıcı_giris;Integrated Security=True");
            baglanti.Open();
            string selectsorgusu = string.Format("select * from kullanici where kullanici_adi ='{0}' and kullanici_sifre='{1}' ", admintxt.Text, sifretxt.Text);
            SqlDataAdapter adapter= new SqlDataAdapter(selectsorgusu,baglanti);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);

            if (tablo.Rows.Count==0)
            {
                Response.Write("<script> alert ('Kullanıcı adı veya şifre yanlış');<script/>");
            }
            else
            {
                Session["kullaniciadi"] = admintxt.Text;
                Response.Redirect("sayfa3.aspx");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sayfa2.aspx?Ad=" );
        }
        private void verilerigoster() { 
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From dilek", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            
            baglanti.Close();   
        
        
        
        }
        protected void Button4_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G1GPA3B;Initial Catalog=Kullanıcı_giris;Integrated Security=True");
            {


                //SqlCommand komut = new SqlCommand("Insert into dilek (mail,mesaj) Values ('" + mailtxt.Text.ToString() + "'+'" + mesajtxt.Text.ToString()+"')",baglanti);
                // SqlCommand komut = new SqlCommand("insert into dilek (mail,mesaj) values (@mail,@mesaj)", baglanti);
                /* SqlCommand Command = new SqlCommand("Insert into dilek (mail,mesaj) Values (@mail,@mesaj)");
                 Command.Parameters.Add(new SqlParameter("mail", mailtxt.Text));
                 Command.Parameters.Add(new SqlParameter("mesaj", mesajtxt.Text));*/

                // SqlCommand komut = new SqlCommand("Insert into dilek (mail,mesaj) Values ('" + mailtxt.Text.ToString() + "'+'" + mesajtxt.Text.ToString() + "')", baglanti);
                SqlCommand komut = new SqlCommand("insert into dilek (mail,mesaj) values (@mail,@mesaj)", baglanti);
                komut.Parameters.AddWithValue("@mail", mailtxt.Text);
                komut.Parameters.AddWithValue("@mesaj",mesajtxt.Text);
                baglanti.Open();
            komut.ExecuteNonQuery();
           
            baglanti.Close();
            verilerigoster();
                mailtxt.Text = "";
                mesajtxt.Text = "";
            }
        }

        protected void mesajtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}