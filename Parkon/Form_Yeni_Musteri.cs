using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Parkon
{
    public partial class Form_Yeni_Musteri : Form
    {

        #region PUBLIC_VARIABLE

        public Form_Main Form_Main;

        #endregion



        public Form_Yeni_Musteri()
        {
            InitializeComponent();

  //        Tb_Yeni_Musteri_Adi.Text =  Form_Main.Anadizin;
        }





        private void B_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {

            CreateFolder();
           
        }




        public void CreateFolder()
        {
        string MüsteriDizini =  Form_Main.Anadizin + "/" + Tb_Yeni_Musteri_Adi.Text;   //@"c:\folders\newfolder";   
        
        if (!Directory.Exists(MüsteriDizini))
        {
            Directory.CreateDirectory(MüsteriDizini);
            Lb_Uyari.Text = "Oluşturulan Yeni Müşteri Firma Dizini: " + Form_Main.Anadizin + Tb_Yeni_Musteri_Adi.Text;
            this.Close();
        }
        else
        {
            Lb_Uyari.Text = "Yazdığınız Müşteri Firma adı kullanılıyor. \nLütfen kontrol ederek tekrar deneyiniz.";
        }

        
        }

        private void Form_Yeni_Musteri_Load(object sender, EventArgs e)
        {
            Lb_Uyari.Text = "";
        }
    


    }
}
