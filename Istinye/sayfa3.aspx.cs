using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Istinye
{
    public partial class sayfa3 : System.Web.UI.Page
    {

        SqlConnection baglanti = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Kullanıcı_girisConnectionString1"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Kullanıcı_girisConnectionString1"].ConnectionString);
            SqlCommand listeleKomutu = new SqlCommand("SELECT * FROM dilek", baglanti);
            baglanti.Open();
            SqlDataReader listele = listeleKomutu.ExecuteReader();
            GridView1.DataSource = listele;
            GridView1.DataBind();
            baglanti.Close();
            listeleKomutu.Dispose();
            baglanti.Dispose();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G1GPA3B;Initial Catalog=Kullanıcı_giris;Integrated Security=True");
            {


                SqlCommand komut = new SqlCommand("insert into dilek (mail,mesaj) values (@mail,@mesaj)", baglanti);
                komut.Parameters.AddWithValue("@mail", TextBox1.Text);
                komut.Parameters.AddWithValue("@mesaj", TextBox2.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();

                baglanti.Close();
                //verilerigoster();
                TextBox1.Text = "";
                TextBox2.Text = "";
                
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            /* SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G1GPA3B;Initial Catalog=Kullanıcı_giris;Integrated Security=True");
             {

 baglanti.Open();
                  SqlCommand komut = new SqlCommand("DELETE FROM Veriler WHERE id"+Convert.ToInt16(TextBox1.Text), baglanti);
                 komut.Parameters.AddWithValue("@mail", OleDbType.Variant).Value =  TextBox1.Text;


                 komut.ExecuteNonQuery();

                 baglanti.Close();

                 TextBox1.Text = "";
                 TextBox2.Text = "";

             }*/
            string silmeSorgusu = "DELETE from musteriler where mail=@mail";
            //musterino parametresine bağlı olarak müşteri kaydını silen sql sorgusu
            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
            silKomutu.Parameters.AddWithValue("@mail", TextBox1.Text);
            silKomutu.ExecuteNonQuery();
            //Sql Bağlantı tanımlamalarımı yapıyorum.


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx?Ad=");
        }
    }
}