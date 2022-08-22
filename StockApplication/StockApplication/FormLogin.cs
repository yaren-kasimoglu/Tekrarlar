using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApplication
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        string _DBuserName = "admin";
        string _DBpassword = "1234";

        private void button_Giris_Click(object sender, EventArgs e)
        {
            Login();

        }

        public void Login()
        {
            string userName = txtKullaniciAdi.Text.Trim(); //eğer sağdan soldan boşluklu vs girerse diye kendimizi sağlama almak adına trim kullanıyoruz
            string password = maskedTxtPassword.Text.Trim();

            if (userName == _DBuserName && password == _DBpassword)
            {
                //Kullanıcı girişi
                FormMain formMain = new FormMain();

                this.Hide(); // buluınduğumuz class ı gizleme
                
                //formMain.ShowDialog(); //ShowDialog ile açtığımız formlar veya ekranlar bu ekran kapatılmadığı sürece aşağısındaki hiçbir kod çalışmaz. Açtığım yerde kod bloğu bekler.
               
                formMain.lblUserame.Text = userName;// erişmek istediğimiz özelliklerin Modifiers özelliğini public yapmalıyız
                formMain.UserName = userName;


                formMain.Show(); // form açılır ve işler devam eder aşağıdaki kod bloklarına da girer
                MessageBox.Show("Anaform Açıldı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Stock Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
