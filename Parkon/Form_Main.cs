using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Web;
using ID_DB;
using Microsoft.Win32;

namespace Parkon
{
    public partial class Form_Main : Form
    {

        ID_DB.SQL ConSQL = new ID_DB.SQL();
        const int Adet = 3;
        string[] TableColumnName = new string[Adet];
        string[] DataString = new string[Adet];
        string[] WriteData = new string[Adet];
        string TabloName = "users";
       

        void Variable()
        {
            TableColumnName[0] = "ID";
            TableColumnName[1] = "Name";
            TableColumnName[2] = "Password";

            ConSQL.ConnectionPath = "Data Source=.\\SQLEXPRESS;Initial Catalog=TofasTestTakipV1.0.0;Integrated Security=True";
           
        }

        void SQL_Sogrulama()
        {


            
          int B =  ConSQL.ReadColumnFromSQL("users", "ID", listBox1);
          label3.Text = B.ToString();
          label33.Text = listBox1.Items.Count.ToString();

          int A =  ConSQL.ReadSingleRowFromSQL(TabloName, TableColumnName, DataString, Adet);
          label27.Text = A.ToString();

          int C = ConSQL.ReadTableFromSQL(TabloName, DGV_ProjeKontrol);
          label28.Text = C.ToString();

          if (C > 0)
          {
            //  DGV_ProjeKontrol.
          }

          listBox2.Items.Clear();
          for (int i = 0; i < Adet; i++)
          {
              
              listBox2.Items.Add(DataString[i]);
           
          }


        }

        void SQL_Yeni()
        {
            WriteData[0] = textBox1.Text;
            WriteData[1] = textBox8.Text;
            WriteData[2] = textBox9.Text;

            int D = ConSQL.Write_ToSQL(TabloName, TableColumnName, WriteData);
            label29.Text = D.ToString();

        }

        void SQL_Yeni_Benzersiz()
        {
            WriteData[0] = textBox1.Text;
            WriteData[1] = textBox8.Text;
            WriteData[2] = textBox9.Text;
            
            int D = ConSQL.WriteWithRef_ToSQL(TabloName, TableColumnName, WriteData, textBox1.Text, TableColumnName[0]);
            label29.Text = D.ToString();

        }

        #region PUBLIC_VARIABLE

        Excel.Application XLComm = new Excel.Application();
        public Form_Yeni_Musteri Form_Yeni_Musteri = new Form_Yeni_Musteri();


        public string Anadizin;
        public string ProjeDonemi;

        public string Dizin_Musteri_Firma;
        public string Dizin_Proje;

        public string Dizin_Musteri_Iliskileri          = "\\P1 Musteri Iliskileri";
            public string Dizin_Teklif_Belgeleri        = "\\Teklif ve Ilgili Belgeler";
        public string Dizin_IsZaman_Plani               = "\\P2 Proje Is-Zaman Plani";
        public string Dizin_Elektrik_Projesi            = "\\P3 Elektrik Projesi";

        public string Dizin_Yazilim                     = "\\P4 Yazilim";
            public string Dizin_PLC_Program             = "\\00 PLC";
            public string Dizin_HMI_Program             = "\\01 HMI";
            public string Dizin_SCADA_Program           = "\\02 SCADA";
            public string Dizin_PC_Program              = "\\03 PC";
            public string Dizin_Yardimci_Program        = "\\04 Yardimci Programlar";

       
        public string Dizin_Servis_Egitim_Formlari      = "\\P5 Proje Teslim Egitim Servis Formlari";
        public string Dizin_Dokumanlar                  = "\\P6 Dokumanlar";
            public string Dizin_Cizim                   = "\\Cizim";
            public string Dizin_Malzeme_Listesi         = "\\Malzeme Listesi";
            public string Dizim_Toplanti_Notlari        = "\\Toplanti Notlari";
            public string Dizim_Kullanim_Kilavuzlari    = "\\Cihaz Kullanim Kilavuzlari";
            public string Dizin_Diger_Dokumanlar        = "\\Diger";
            public string Dizin_FotografVideo           = "\\Fotograf Video";




        public string Klasor_PLC_Program;
        public string Klasor_HMI_Program;
        public string Klasor_SCADA_Program;
        public string Klasor_YARD_Program;
        public string Klasor_PC_Program;
        public string Klasor_Malzeme_Listesi;
        public string Klasor_Elektrik_Projesi;
        public string Klasor_Cizimler;
        public string Klasor_Musteri_Iliskileri;
        public string Klasor_Teklif_Belgeleri;
        public string Klasor_Servis_Egitim_Formlari;
        public string Klasor_Dokumanlar;
        public string Klasor_Diger_Dokumanlar;
        public string Klasor_FotografVideo;
        public string Klasor_Tum_Dokumanlar;
        public string Klasor_Is_Zaman_Plani;

        GroupBox Grp_PLC_Program                    = new GroupBox();
        WebBrowser WB_PLC_Program                   = new WebBrowser();
        Button B_PLC_Program_Geri                   = new Button();
        Button B_PLC_Program_Ac                     = new Button();
        Button B_PLC_Program_CopyLink               = new Button();

        GroupBox Grp_HMI_Program                    = new GroupBox();
        WebBrowser WB_HMI_Program                   = new WebBrowser();
        Button B_HMI_Program_Geri                   = new Button();
        Button B_HMI_Program_Ac                     = new Button();
        Button B_HMI_Program_CopyLink               = new Button();

        GroupBox Grp_SCADA_Program                  = new GroupBox();
        WebBrowser WB_SCADA_Program                 = new WebBrowser();
        Button B_SCADA_Program_Geri                 = new Button();
        Button B_SCADA_Program_Ac                   = new Button();
        Button B_SCADA_Program_CopyLink             = new Button();

        GroupBox Grp_YARD_Program                   = new GroupBox();
        WebBrowser WB_YARD_Program                  = new WebBrowser();
        Button B_YARD_Program_Geri                  = new Button();
        Button B_YARD_Program_Ac                    = new Button();
        Button B_YARD_Program_CopyLink              = new Button();


        GroupBox Grp_PC_Program                     = new GroupBox();
        WebBrowser WB_PC_Program                    = new WebBrowser();
        Button B_PC_Program_Geri                    = new Button();
        Button B_PC_Program_Ac                      = new Button();
        Button B_PC_Program_CopyLink                = new Button();

        GroupBox Grp_Malzeme_Listesi                = new GroupBox();
        WebBrowser WB_Malzeme_Listesi               = new WebBrowser();
        Button B_Malzeme_Listesi_Geri               = new Button();
        Button B_Malzeme_Listesi_Ac                 = new Button();
        Button B_Malzeme_Listesi_CopyLink           = new Button();

        GroupBox Grp_Elektrik_Projesi               = new GroupBox();
        WebBrowser WB_Elektrik_Projesi              = new WebBrowser();
        Button B_Elektrik_Projesi_Geri              = new Button();
        Button B_Elektrik_Projesi_Ac                = new Button();
        Button B_Elektrik_Projesi_CopyLink          = new Button();


        GroupBox Grp_Cizimler                       = new GroupBox();
        WebBrowser WB_Cizimler                      = new WebBrowser();
        Button B_Cizimler_Geri                      = new Button();
        Button B_Cizimler_Ac                        = new Button();
        Button B_Cizimler_CopyLink                  = new Button();


        GroupBox Grp_Musteri_Iliskileri             = new GroupBox();
        WebBrowser WB_Musteri_Iliskileri            = new WebBrowser();
        Button B_Musteri_Iliskileri_Geri            = new Button();
        Button B_Musteri_Iliskileri_Ac              = new Button();
        Button B_Musteri_Iliskileri_CopyLink        = new Button();


        GroupBox Grp_Teklif_Belgeleri               = new GroupBox();
        WebBrowser WB_Teklif_Belgeleri              = new WebBrowser();
        Button B_Teklif_Belgeleri_Geri              = new Button();
        Button B_Teklif_Belgeleri_Ac                = new Button();
        Button B_Teklif_Belgeleri_CopyLink          = new Button();

        GroupBox Grp_Servis_Egitim_Formlari         = new GroupBox();
        WebBrowser WB_Servis_Egitim_Formlari        = new WebBrowser();
        Button B_Servis_Egitim_Formlari_Geri        = new Button();
        Button B_Servis_Egitim_Formlari_Ac          = new Button();
        Button B_Servis_Egitim_Formlari_CopyLink    = new Button();

        GroupBox Grp_Dokumanlar                     = new GroupBox();
        WebBrowser WB_Dokumanlar                    = new WebBrowser();
        Button B_Dokumanlar_Geri                    = new Button();
        Button B_Dokumanlar_Ac                      = new Button();
        Button B_Dokumanlar_CopyLink                = new Button();

        GroupBox Grp_Diger_Dokumanlar               = new GroupBox();
        WebBrowser WB_Diger_Dokumanlar              = new WebBrowser();
        Button B_Diger_Dokumanlar_Geri              = new Button();
        Button B_Diger_Dokumanlar_Ac                = new Button();
        Button B_Diger_Dokumanlar_CopyLink          = new Button();

        GroupBox Grp_FotografVideo                  = new GroupBox();
        WebBrowser WB_FotografVideo                 = new WebBrowser();
        Button B_FotografVideo_Geri                 = new Button();
        Button B_FotografVideo_Ac                   = new Button();
        Button B_FotografVideo_CopyLink             = new Button();



        GroupBox Grp_Tum_Dokumanlar                 = new GroupBox();
        WebBrowser WB_Tum_Dokumanlar                = new WebBrowser();
        Button B_Tum_Dokumanlar_Geri                = new Button();
        Button B_Tum_Dokumanlar_Ac                  = new Button();
        Button B_Tum_Dokumanlar_CopyLink            = new Button();

        GroupBox Grp_Is_Zaman_Plani                 = new GroupBox();
        WebBrowser WB_Is_Zaman_Plani                = new WebBrowser();
        Button B_Is_Zaman_Plani_Geri                = new Button();
        Button B_Is_Zaman_Plani_Ac                  = new Button();
        Button B_Is_Zaman_Plani_CopyLink            = new Button();

        #endregion

        #region FORM_FUNCTIONS

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage8);
            string VERSION = "1.0.1";
            this.Text               = "Proje Arşivleme ve Kontrol V" + VERSION;
            ToolTip_Verison.Text = "Version: " + VERSION; // +DateTime.Now.ToShortTimeString();

            Form_Yeni_Musteri.Form_Main = this;
            FirstStart();

        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(XLComm);
                XLComm = null;
            }
            catch (Exception ex)
            {
                XLComm = null;
                MessageBox.Show("Hata " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public void FirstStart()
        {
            
            LB_AnaDizin.Text = Properties.Settings.Default.AnaDizin;
            TB_Kullanici.Text = Properties.Settings.Default.UserName;
            TreeView_Duzeni();
            Anadizin = LB_AnaDizin.Text;
            toolStripKullanici.Text = "  Kullanıcı : " + TB_Kullanici.Text;

            InternetKontrol();
            Notify();
            Variable();
            AcilistaCalistir();

        }

        void AcilistaCalistir()
        {
            string ProgramAdi = "PARKON";
            if (Properties.Settings.Default.acililstaBaslat)
            { //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue(ProgramAdi, "\"" + Application.ExecutablePath + "\"");
                CB_Acilista_Calistir.Checked = true;
            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(ProgramAdi);
                CB_Acilista_Calistir.Checked = false;
            }
        }

        public void InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                LB_Internet_Knt.Text = "İnternet Bağlantısı Var!"; LB_Internet_Knt.ForeColor = Color.DarkGreen;
                B_Proje_Olustur.Enabled = true;
                B_Yeni_Musteri_Ekle_Prj_Olusturma.Enabled = true;
            }
            catch (Exception e)
            {
            LB_Internet_Knt.Text = "İnternet Bağlantısı Yok!"; LB_Internet_Knt.ForeColor = Color.Red;
            B_Proje_Olustur.Enabled = false;
            B_Yeni_Musteri_Ekle_Prj_Olusturma.Enabled = false;
            }
        }

        #region KLAVYE DINLEME
        //globalKeyboardHook klavyeDinleyicisi = new globalKeyboardHook();
        //public void DinlenecekTuslariAyarla()
        //{
        //    // hangi tuşları dinlemek istiyorsak burada ekliyoruz
        //    // Ben burada F,K ve M harflerine basılınca tetiklenecek şekilde ayarladım
        //    klavyeDinleyicisi.HookedKeys.Add(Keys.F9);

        //    //basıldığında ilk burası çalışır
        //    klavyeDinleyicisi.KeyDown += new KeyEventHandler(islem1);
        //    //basıldıktan sonra ikinci olarak burası çalışır
        //    klavyeDinleyicisi.KeyUp += new KeyEventHandler(islem2);
        //}

        //  void islem1(object sender, KeyEventArgs e)
        //  {
        ////Yapılmasını istediğiniz kodlar burada yer alacak
        ////Burası tuşa basıldığı an çalışır
 
 
 
        ////Eğer buraya gelecek olan tuşa basıldığında
        ////o tuşun normal işlevi yine çalışsın istiyorsanız
        ////e.Handled değeri false olmalı
        ////eğer ilgili tuşa basıldığında burada yakalansın
        //// ve devamında tuş başka bir işlev gerçekleştirmesin
        ////istiyorsanız bu değeri true yapmalısınız
        //e.Handled = false;
        //}
 
        // void islem2(object sender, KeyEventArgs e)
        // {
        ////Yapılmasını istediğiniz kodlar burada yer alacak
        //// Burası ilgili tuşlara basılıp çekildikten sonra çalışır
        //     if (WindowState == FormWindowState.Minimized)
        //     {
        //         WindowState = FormWindowState.Normal;
        //     }
             
 
        ////Eğer buraya gelecek olan tuşa basıldığında
        ////o tuşun normal işlevi yine çalışsın istiyorsanız
        ////e.Handled değeri false olmalı
        ////eğer ilgili tuşa basıldığında burada yakalansın
        //// ve devamında tuş başka bir işlev gerçekleştirmesin
        ////istiyorsanız bu değeri true yapmalısınız
        //e.Handled = true;
        //}
        #endregion

        #region NOTIFY CONTROL

        void Notify()
        {

            //// Backround Work
            Notify_Parkon.BalloonTipText = "Hi! Parkon is running. Have a nice day!";
            Notify_Parkon.BalloonTipTitle = "Parkon - Proje Arşivleme ve Kontrol";
            // this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Notify_Parkon.Visible = true;
            Notify_Parkon.ShowBalloonTip(800);
            ////**********************
            ////**********************
        }

        private void Notify_Parkon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            Notify_Parkon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //// Backround Work
                Notify_Parkon.BalloonTipText = "Parkon is still running";
                Notify_Parkon.BalloonTipTitle = "Parkon - Proje Arşivleme ve Kontrol";
                // this.WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(800);
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(1000);
            }
        }

        private void Notify_Bilgi_Uyari()
        {
            if (DateTime.Now.ToLongTimeString() == "14:30:02")
            {
                //// Backround Work
                Notify_Parkon.BalloonTipText = "Bir fincan kahve içmenin tam zamanı...";
                Notify_Parkon.BalloonTipTitle = "Parkon - Proje Arşivleme ve Kontrol";
                // this.WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(800);
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(1000);
            }

            if (DateTime.Now.ToLongTimeString() == "17:00:02" )
            {
                //// Backround Work
                Notify_Parkon.BalloonTipText = "Sıcak bir fincan kahve daha? ";
                Notify_Parkon.BalloonTipTitle = "Parkon - Proje Arşivleme ve Kontrol";
                // this.WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(800);
                ShowInTaskbar = false;
                Notify_Parkon.Visible = true;
                Notify_Parkon.ShowBalloonTip(1000);
            }



        }

        #endregion

        #endregion

        #region DIZIN_AGACI

        private void dirsTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        private void TreeView_Duzeni()
        {

            //get a list of the drives
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 27;
                        break;
                    case DriveType.Network:
                        driveImage = 24;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 18;
                        break;
                    case DriveType.Unknown:
                        driveImage = 30;
                        break;
                    default:
                        driveImage = 26;
                        break;
                }

                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                dirsTreeView.Nodes.Add(node);
            }
        }

        string TreeView_SeciliDizin;
        private void dirsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode CurrentNode = e.Node;
            TreeView_SeciliDizin = CurrentNode.Tag.ToString();
            TB_TreeView_SeciliDizin.Text = TreeView_SeciliDizin;
        }

        private void B_Dizin_Open_Click(object sender, EventArgs e)
        {
            string myDocspath = TreeView_SeciliDizin; // Buraya istediğimiz dosyanın yolunu yazıyorz
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = myDocspath;
            prc.Start();
        }


        #endregion

        #region PROJE_OLUSTURMA

        private void CB_MusteriFirma_PrjOlusturma_MouseDown(object sender, MouseEventArgs e)
        {
      
            CB_Proje_Olustur_Musteri_Firma.Items.Clear();

            string[] dosya = Directory.GetDirectories(Anadizin);
            for (int a = 0; a < dosya.Length; a++)
            {
                string MusteriFirma_Klasorleri = dosya[a];
                MusteriFirma_Klasorleri = MusteriFirma_Klasorleri.Replace(Anadizin, "");
                CB_Proje_Olustur_Musteri_Firma.Items.Add(MusteriFirma_Klasorleri);
            }
        }

        private void B_Yeni_Musteri_Ekle_Prj_Olusturma_Click(object sender, EventArgs e)
        {
            Form_Yeni_Musteri.ShowDialog();
        }

        private void B_Proje_Olustur_Click(object sender, EventArgs e)
        {
            if (CB_Proje_Olustur_Musteri_Firma.Text == "")
            {
                DialogResult result = MessageBox.Show("Müşteri Firma seçimi yapılmadı! Lütfen seçim yapınız. " +
                     "Eğer listede aradığınız müşteri firmayı bulamadıysanız yöneticinize danışarak yeni "     +
                     "'Müşteri Firma Klasörü' oluşturabilirsiniz.", 
                     "Uyarı! Eksik Parametre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Karakter_TRtoENG();
                CreateFolder();
            }

            
        }

        private void B_Proje_Olustur_Temizle_Click(object sender, EventArgs e)
        {
            TB_Proje_Olustur_Proje_Adi.Text = "";
            TB_Proje_Olustur_Proje_Donemi.Text = "";
            TB_Proje_Olustur_Proje_Kodu.Text = "";
            CHB_Proje_Olustur_Proje_Donemi_Degistir.Checked = false;
            CHB_Proje_Olustur_Proje_Kodu_Degistir.Checked = false;
            CB_Proje_Olustur_Musteri_Firma.Text = "";
            Lb_Uyari.Text = "";
        }

        public void CreateFolder()
        {

            Dizin_Musteri_Firma = Anadizin + CB_Proje_Olustur_Musteri_Firma.Text;

            string Proje_Olustur_Bolum_Knt;
            if (TB_Proje_Olustur_Bölüm.Text != "")
            {       Proje_Olustur_Bolum_Knt = TB_Proje_Olustur_Bölüm.Text + " " ; }
            else {  Proje_Olustur_Bolum_Knt = TB_Proje_Olustur_Bölüm.Text; }

            Dizin_Proje = Dizin_Musteri_Firma + "\\P" + TB_Proje_Olustur_Proje_Donemi.Text + " " + CB_Proje_Olustur_Musteri_Firma.Text + " - " + Proje_Olustur_Bolum_Knt + TB_Proje_Olustur_Proje_Adi.Text;

            if (!Directory.Exists(Dizin_Proje))
            {
                Excel.Application XLComm = new Excel.Application();
                Directory.CreateDirectory(Dizin_Proje);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri); //P1 Musteriden Gelenler
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\E-Mailler");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\Musteri Talebi ve Degisiklikleri");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\Musteriden Gelen Belgeler");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + "\\Musteriden Gelen Belgeler");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri + "\\Musteriden Alinan Teklif Onayi");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri + "\\Musteriye Verilen Teklifler");

                Directory.CreateDirectory(Dizin_Proje + Dizin_IsZaman_Plani);

                Directory.CreateDirectory(Dizin_Proje + Dizin_Elektrik_Projesi);

                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program + "\\00 Guncel");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program + "\\01 Yedek");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PLC_Program + "\\02 IO Listesi");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program);       
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program + "\\00 Guncel");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program + "\\01 Yedek");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_HMI_Program + "\\02 Inport-Export");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program + "\\00 Guncel");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program + "\\01 Yedek");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_SCADA_Program + "\\02 Inport-Export");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program + "\\00 Guncel");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program + "\\01 Yedek");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_PC_Program + "\\02 Dokumanlar Ornekler");
                Directory.CreateDirectory(Dizin_Proje + Dizin_Yazilim + Dizin_Yardimci_Program);

                Directory.CreateDirectory(Dizin_Proje + Dizin_Servis_Egitim_Formlari);

                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizim_Kullanim_Kilavuzlari);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_Cizim);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_Diger_Dokumanlar);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_FotografVideo);
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizin_Malzeme_Listesi); 
                Directory.CreateDirectory(Dizin_Proje + Dizin_Dokumanlar + Dizim_Toplanti_Notlari);


                Lb_Uyari.Text = "Oluşturulan Yeni Proje Dizini: " + Dizin_Proje;

                
               if (XLComm == null)
               {
                   MessageBox.Show("Excel yüklü değil! Proje Künyesi 'Excel' dosyasına kaydedilir. Bilgisayarınıza 'Excel' yükledikten sonra işlemi tekrar deneyiniz.");
                   return;
               }

               Excel.Workbook xlWorkBook;
               Excel.Worksheet xlWorkSheet;
               object misValue = System.Reflection.Missing.Value;

               xlWorkBook = XLComm.Workbooks.Add(misValue);
               xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
               xlWorkSheet.Cells[1, 1] = "NO";              xlWorkSheet.Cells[2, 1] = "1";
               xlWorkSheet.Cells[1, 2] = "TARİH";           xlWorkSheet.Cells[2, 2] = DateTime.Now.ToLongDateString();
               xlWorkSheet.Cells[1, 3] = "YETKİLİ";         xlWorkSheet.Cells[2, 3] = TB_Kullanici.Text;
               xlWorkSheet.Cells[1, 4] = "İŞLEM";           xlWorkSheet.Cells[2, 4] = "Yeni Proje Oluşturma";
               xlWorkSheet.Cells[1, 5] = "AÇIKLAMA";        xlWorkSheet.Cells[2, 5] = "Yeni Proje Oluşturuldu. Proje için gereken klasörler hazırlandı.";

               xlWorkBook.SaveAs(Dizin_Proje + "\\" + "PROJE KUNYESI - " + "P" + TB_Proje_Olustur_Proje_Donemi.Text + " " + TB_Proje_Olustur_Proje_Adi.Text + ".xls",  
                                Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, 
                                Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
               xlWorkBook.Close(true, misValue, misValue);
               XLComm.Quit();

               try
               {
                   System.Runtime.InteropServices.Marshal.ReleaseComObject(XLComm);
                   XLComm = null;
               }
               catch (Exception ex)
               {
                   XLComm = null;
                   MessageBox.Show("Hata " + ex.ToString());
               }
               finally
               {
                   GC.Collect();
               }
            }
            else
            {
                Lb_Uyari.Text = "Yazdığınız Proje adı kullanılıyor. \nLütfen kontrol ederek tekrar deneyiniz.";
            }

        }

        public string ingilizcelestir(string kelimecik)
        {
            kelimecik = kelimecik.Replace('ö', 'o');
            kelimecik = kelimecik.Replace('ü', 'u');
            kelimecik = kelimecik.Replace('ğ', 'g');
            kelimecik = kelimecik.Replace('ş', 's');
            kelimecik = kelimecik.Replace('ı', 'i');
            kelimecik = kelimecik.Replace('ç', 'c');
            kelimecik = kelimecik.Replace('Ö', 'O');
            kelimecik = kelimecik.Replace('Ü', 'U');
            kelimecik = kelimecik.Replace('Ğ', 'G');
            kelimecik = kelimecik.Replace('Ş', 'S');
            kelimecik = kelimecik.Replace('İ', 'I');
            kelimecik = kelimecik.Replace('Ç', 'C');

            return kelimecik;
        }
        private void TB_Proje_Olustur_Bölüm_TextChanged(object sender, EventArgs e)
        {
            TB_Proje_Olustur_Bölüm.CharacterCasing = CharacterCasing.Upper;

        }

        private void TB_Proje_Olustur_Proje_Adi_TextChanged(object sender, EventArgs e)
        {
            TB_Proje_Olustur_Proje_Adi.CharacterCasing = CharacterCasing.Upper;

            
            if (CHB_Proje_Olustur_Proje_Donemi_Degistir.Checked == false)
            {
                if (DateTime.Now.Month.ToString().Length < 2)
                { TB_Proje_Olustur_Proje_Donemi.Text = DateTime.Now.Year.ToString().Substring(2) + ".0" + DateTime.Now.Month.ToString(); }
                else
                { TB_Proje_Olustur_Proje_Donemi.Text = DateTime.Now.Year.ToString().Substring(2) + "." + DateTime.Now.Month.ToString(); }
            }
            
        }

        void Karakter_TRtoENG()
        {
            TB_Proje_Olustur_Bölüm.Text = ingilizcelestir(TB_Proje_Olustur_Bölüm.Text);
            TB_Proje_Olustur_Proje_Adi.Text = ingilizcelestir(TB_Proje_Olustur_Proje_Adi.Text);
        }

        private void CHB_Proje_Olustur_Proje_Donemi_Degistir_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_Proje_Olustur_Proje_Donemi_Degistir.Checked == true)
            {
                TB_Proje_Olustur_Proje_Donemi.ReadOnly = false;
            }
            else
            {
                TB_Proje_Olustur_Proje_Donemi.ReadOnly = true;
            }
        }


        #endregion

        #region PROJE_SORGULAMA

        private void CB_MusteriFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Proje.Text = "";
            CB_Proje.Items.Clear();

        }

        private void CB_MusteriFirma_MouseDown(object sender, MouseEventArgs e)
        {
            CB_MusteriFirma.Items.Clear();

            try
            {
                string[] dosya = Directory.GetDirectories(Anadizin);
                for (int a = 0; a < dosya.Length; a++)
                {
                    string MusteriFirma_Klasorleri = dosya[a];
                    string TemizAnaDizin = Anadizin;
                    MusteriFirma_Klasorleri = MusteriFirma_Klasorleri.Replace(TemizAnaDizin, "");
                    CB_MusteriFirma.Items.Add(MusteriFirma_Klasorleri);
                }
            }
            catch 
            {
                
                
            }

        }

        private void CB_Proje_MouseDown(object sender, MouseEventArgs e)
        {
            CB_Proje.Items.Clear();
            if (CB_MusteriFirma.Text != "")
            {
                string[] dosya = Directory.GetDirectories(Anadizin + CB_MusteriFirma.Text);
                for (int a = 0; a < dosya.Length; a++)
                {
                    string Proje_Klasorleri = dosya[a];
                    string KaldirilacakBolum = Anadizin + CB_MusteriFirma.Text + "\\";
                    Proje_Klasorleri = Proje_Klasorleri.Replace(KaldirilacakBolum, "");

                    CB_Proje.Items.Add(Proje_Klasorleri);
                }
            }
        }

        public void ReadDirectory()
        {
          //  listView1.Items.Clear();
          //  //GetFiles metodu dosyaları temsil eder. Belirtilen Dizindeki Dosyaları Dizi olarak döndürür
          ////  string[] dosyalar = System.IO.Directory.GetFiles("C:\\");

          //  string[] dosyalar = Directory.GetFiles(@"e:\", "*.txt", SearchOption.AllDirectories);

          //  for (int j = 0; j < dosyalar.Length; j++)
          //  {
          //      //klasörler dizisinin i. elemanı listboxa ekle
          //      listBox1.Items.Add(dosyalar[j]);
          //  //    listView1.Items.Add(dosyalar[j]);
          //  }

        }

        public void OpenFolder()
        {
            string myDocspath = "DosyaYolunu yazıyoruz"; // Buraya istediğimiz dosyanın yolunu yazıyorz
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = myDocspath;
            prc.Start();
        }


        private void B_Ara_Click(object sender, EventArgs e)
        {
            LB_Sorgu_Hata_Bildirimi.Text = "";
            if (CB_MusteriFirma.Text != "" && CB_Proje.Text != "")
            {
                ReadDirectory();

                Sorgulama();

            }



        if (ChB_PrjSorgu_PLC_Program.Checked            ||  ChB_PrjSorgu_HMI_Program.Checked            || ChB_PrjSorgu_SCADA_Program.Checked ||
             ChB_PrjSorgu_YARD_Program.Checked          || ChB_PrjSorgu_Malzeme_Listesi.Checked         || ChB_PrjSorgu_Elektrik_Projesi.Checked ||
             ChB_PrjSorgu_Cizimler.Checked              || ChB_PrjSorgu_PC_Program.Checked              || ChB_PrjSorgu_Musteri_Iliskileri.Checked ||
             ChB_PrjSorgu_Teklif_Belgeleri.Checked      || ChB_PrjSorgu_Servis_Egitim_Formlari.Checked  || ChB_PrjSorgu_Dokumanlar.Checked ||
             ChB_PrjSorgu_FotografVideo.Checked         || ChB_PrjSorgu_Is_Zaman_Plani.Checked)
        {
            LB_Dosya_NitelikSecilmedi.Visible = false;

        }
        else
        {
            LB_Dosya_NitelikSecilmedi.Visible = true;
            LB_Sorgu_Hata_Bildirimi.Text = "Arama Kriteri Seçilmedi. Dosyalar neye göre getirilecek? Lütfen 'Dosya Niteliği' bölümünden bir seçim yapınız.";
        }

        if (CB_Proje.Text == "") { LB_PrjSorgu_Proje.ForeColor = Color.Red; LB_Sorgu_Hata_Bildirimi.Text = "Proje Seçilmedi! Lütfen 'Proje' seçimi yapınız."; } 
        else { LB_PrjSorgu_Proje.ForeColor = Color.Black; }
        if (CB_MusteriFirma.Text == "") { LB_PrjSorgu_MusteriFirma.ForeColor = Color.Red; LB_Sorgu_Hata_Bildirimi.Text ="Müşteri Firma Seçilmedi! Lütfen ilk önce 'Müşteri Firma' seçimini yapınız."; } 
        else { LB_PrjSorgu_MusteriFirma.ForeColor = Color.Black; }


  
        }


        public static long KlasorBoyutKontrol(DirectoryInfo yol)
        {
                return yol.GetFiles().Sum(fi => fi.Length) +
                yol.GetDirectories().Sum(di => KlasorBoyutKontrol(di));

        }



        public void Sorgulama()
        {
            FLayoutPanel.Controls.Clear();

            Klasor_Musteri_Iliskileri       = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Musteri_Iliskileri;
            Klasor_Teklif_Belgeleri         = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Musteri_Iliskileri + Dizin_Teklif_Belgeleri;
            Klasor_Servis_Egitim_Formlari   = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Servis_Egitim_Formlari;

            Klasor_PLC_Program              = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_PLC_Program;
            Klasor_HMI_Program              = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_HMI_Program;
            Klasor_SCADA_Program            = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_SCADA_Program;
            Klasor_YARD_Program             = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_Yardimci_Program;
            Klasor_PC_Program               = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Yazilim + Dizin_PC_Program;
 
            Klasor_Elektrik_Projesi         = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Elektrik_Projesi;

            Klasor_Malzeme_Listesi          = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar + Dizin_Malzeme_Listesi; 

            Klasor_Dokumanlar               = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar;
            Klasor_Cizimler                 = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar + Dizin_Cizim;
            Klasor_Diger_Dokumanlar         = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar + Dizin_Diger_Dokumanlar;
            Klasor_FotografVideo                 = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_Dokumanlar + Dizin_FotografVideo;
            Klasor_Is_Zaman_Plani           = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text + Dizin_IsZaman_Plani; ;
            Klasor_Tum_Dokumanlar           = Anadizin + CB_MusteriFirma.Text + "\\" + CB_Proje.Text;

            try
            {
            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_PLC_Program.Checked)
            {
                DirectoryInfo klasoryolu    = new DirectoryInfo(Klasor_PLC_Program);
                long boyutyol               = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " PLC Programı - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " PLC Programı "; }

                    NesneTextleri[1] = Klasor_PLC_Program;
                    NesneTextleri[2] = "B_Geri_PLC_Program";
                    NesneTextleri[3] = "B_Ac_PLC_Program";
                    NesneTextleri[4] = "B_LinkCopy_PLC_Program";
                    NesneTextleri[5] = "WB_PLC_Program";
                    NesneTextleri[6] = "";
                    NesneTextleri[7] = "";
                    NesneTextleri[8] = "";
                    NesneTextleri[9] = "";
                    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                    {
                        KlasorSorguCevabiListele(Grp_PLC_Program, WB_PLC_Program, B_PLC_Program_Geri, B_PLC_Program_Ac, B_PLC_Program_CopyLink, NesneTextleri);
                    }
            }

            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_HMI_Program.Checked)
            {
                DirectoryInfo klasoryolu    = new DirectoryInfo(Klasor_HMI_Program);
                long boyutyol               = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " HMI Programı - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " HMI Programı "; }
                    NesneTextleri[1] = Klasor_HMI_Program;
                    NesneTextleri[2] = "B_Geri_HMI_Program";
                    NesneTextleri[3] = "B_Ac_HMI_Program";
                    NesneTextleri[4] = "B_LinkCopy_HMI_Program";
                    NesneTextleri[5] = "WB_HMI_Program";
                    NesneTextleri[6] = "";
                    NesneTextleri[7] = "";
                    NesneTextleri[8] = "";
                    NesneTextleri[9] = "";
                    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                    {
                        KlasorSorguCevabiListele(Grp_HMI_Program, WB_HMI_Program, B_HMI_Program_Geri, B_HMI_Program_Ac, B_HMI_Program_CopyLink, NesneTextleri);
                    }
            }

            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_SCADA_Program.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_SCADA_Program);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " SCADA Programı - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " SCADA Programı "; }
                    NesneTextleri[1] = Klasor_SCADA_Program;
                    NesneTextleri[2] = "B_Geri_SCADA_Program";
                    NesneTextleri[3] = "B_Ac_SCADA_Program";
                    NesneTextleri[4] = "B_LinkCopy_SCADA_Program";
                    NesneTextleri[5] = "WB_SCADA_Program";
                    NesneTextleri[6] = "";
                    NesneTextleri[7] = "";
                    NesneTextleri[8] = "";
                    NesneTextleri[9] = "";
                    if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                    {
                        KlasorSorguCevabiListele(Grp_SCADA_Program, WB_SCADA_Program, B_SCADA_Program_Geri, B_SCADA_Program_Ac, B_SCADA_Program_CopyLink, NesneTextleri);
                    }
            }


            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_YARD_Program.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_YARD_Program);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " Yardımcı Programlar - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " Yardımcı Programlar "; }
                NesneTextleri[1] = Klasor_YARD_Program;
                NesneTextleri[2] = "B_Geri_YARD_Program";
                NesneTextleri[3] = "B_Ac_YARD_Program";
                NesneTextleri[4] = "B_LinkCopy_YARD_Program";
                NesneTextleri[5] = "WB_YARD_Program";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_YARD_Program, WB_YARD_Program, B_YARD_Program_Geri, B_YARD_Program_Ac, B_YARD_Program_CopyLink, NesneTextleri);
                }
            }

            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_PC_Program.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_PC_Program);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " PC Programları - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " PC Programları "; }
                NesneTextleri[1] = Klasor_PC_Program;
                NesneTextleri[2] = "B_Geri_PC_Program";
                NesneTextleri[3] = "B_Ac_PC_Program";
                NesneTextleri[4] = "B_LinkCopy_PC_Program";
                NesneTextleri[5] = "WB_PC_Program";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_PC_Program, WB_PC_Program, B_PC_Program_Geri, B_PC_Program_Ac, B_PC_Program_CopyLink, NesneTextleri);
                }
            }

            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_Malzeme_Listesi.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Malzeme_Listesi);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " Malzeme Listesi - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " Malzeme Listesi "; }
                NesneTextleri[1] = Klasor_Malzeme_Listesi;
                NesneTextleri[2] = "B_Geri_Malzeme_Listesi";
                NesneTextleri[3] = "B_Ac_Malzeme_Listesi";
                NesneTextleri[4] = "B_LinkCopy_Malzeme_Listesi";
                NesneTextleri[5] = "WB_Malzeme_Listesi";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_Malzeme_Listesi, WB_Malzeme_Listesi, B_Malzeme_Listesi_Geri, B_Malzeme_Listesi_Ac, B_Malzeme_Listesi_CopyLink, NesneTextleri);
                }
            }


            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_Elektrik_Projesi.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Elektrik_Projesi);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " Elektrik Projesi - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " Elektrik Projesi "; }
                NesneTextleri[1] = Klasor_Elektrik_Projesi;
                NesneTextleri[2] = "B_Geri_Elektrik_Projesi";
                NesneTextleri[3] = "B_Ac_Elektrik_Projesi";
                NesneTextleri[4] = "B_LinkCopy_Elektrik_Projesi";
                NesneTextleri[5] = "WB_Elektrik_Projesi";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_Elektrik_Projesi, WB_Elektrik_Projesi, B_Elektrik_Projesi_Geri, B_Elektrik_Projesi_Ac, B_Elektrik_Projesi_CopyLink, NesneTextleri);
                }
            }

            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_Cizimler.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Cizimler);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " Çizimler - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " Çizimler "; }
                NesneTextleri[1] = Klasor_Cizimler;
                NesneTextleri[2] = "B_Geri_Cizimler";
                NesneTextleri[3] = "B_Ac_Cizimler";
                NesneTextleri[4] = "B_LinkCopy_Cizimler";
                NesneTextleri[5] = "WB_Cizimler";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_Cizimler, WB_Cizimler, B_Cizimler_Geri, B_Cizimler_Ac, B_Cizimler_CopyLink, NesneTextleri);
                }
            }


            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_Musteri_Iliskileri.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Musteri_Iliskileri);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " Müşteri İlişkileri - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " Müşteri İlişkileri "; }
                NesneTextleri[1] = Klasor_Musteri_Iliskileri;
                NesneTextleri[2] = "B_Geri_Musteri_Iliskileri";
                NesneTextleri[3] = "B_Ac_Musteri_Iliskileri";
                NesneTextleri[4] = "B_LinkCopy_Musteri_Iliskileri";
                NesneTextleri[5] = "WB_Musteri_Iliskileri";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_Musteri_Iliskileri, WB_Musteri_Iliskileri, B_Musteri_Iliskileri_Geri, B_Musteri_Iliskileri_Ac, B_Musteri_Iliskileri_CopyLink, NesneTextleri);
                }
            }


            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_Teklif_Belgeleri.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Teklif_Belgeleri);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " Teklif Belgeleri - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " Teklif Belgeleri "; }
                NesneTextleri[1] = Klasor_Teklif_Belgeleri;
                NesneTextleri[2] = "B_Geri_Teklif_Belgeleri";
                NesneTextleri[3] = "B_Ac_Teklif_Belgeleri";
                NesneTextleri[4] = "B_LinkCopy_Teklif_Belgeleri";
                NesneTextleri[5] = "WB_Teklif_Belgeleri";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_Teklif_Belgeleri, WB_Teklif_Belgeleri, B_Teklif_Belgeleri_Geri, B_Teklif_Belgeleri_Ac, B_Teklif_Belgeleri_CopyLink, NesneTextleri);
                }
            }

            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_Servis_Egitim_Formlari.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Servis_Egitim_Formlari);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " Servis Eğitim Formları - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " Servis Eğitim Formları "; }
                NesneTextleri[1] = Klasor_Servis_Egitim_Formlari;
                NesneTextleri[2] = "B_Geri_Servis_Egitim_Formlari";
                NesneTextleri[3] = "B_Ac_Servis_Egitim_Formlari";
                NesneTextleri[4] = "B_LinkCopy_Servis_Egitim_Formlari";
                NesneTextleri[5] = "WB_Servis_Egitim_Formlari";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_Servis_Egitim_Formlari, WB_Servis_Egitim_Formlari, B_Servis_Egitim_Formlari_Geri, B_Servis_Egitim_Formlari_Ac, B_Servis_Egitim_Formlari_CopyLink, NesneTextleri);
                }
            }

            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_Dokumanlar.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Dokumanlar);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " Dökümanlar - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " Dökümanlar "; }
                NesneTextleri[1] = Klasor_Dokumanlar;
                NesneTextleri[2] = "B_Geri_Dokumanlar";
                NesneTextleri[3] = "B_Ac_Dokumanlar";
                NesneTextleri[4] = "B_LinkCopy_Dokumanlar";
                NesneTextleri[5] = "WB_Dokumanlar";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_Dokumanlar, WB_Dokumanlar, B_Dokumanlar_Geri, B_Dokumanlar_Ac, B_Dokumanlar_CopyLink, NesneTextleri);
                }
            }

            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_FotografVideo.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_FotografVideo);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " Fotoğraf ve Video - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " Fotoğraflar "; }
                NesneTextleri[1] = Klasor_FotografVideo;
                NesneTextleri[2] = "B_Geri_FotografVideo";
                NesneTextleri[3] = "B_Ac_FotografVideo";
                NesneTextleri[4] = "B_LinkCopy_FotografVideo";
                NesneTextleri[5] = "WB_FotografVideo";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_FotografVideo, WB_FotografVideo, B_FotografVideo_Geri, B_FotografVideo_Ac, B_FotografVideo_CopyLink, NesneTextleri);
                }
            }

            //=================================================================
            //=================================================================
            if (ChB_PrjSorgu_Is_Zaman_Plani.Checked)
            {
                DirectoryInfo klasoryolu = new DirectoryInfo(Klasor_Is_Zaman_Plani);
                long boyutyol = KlasorBoyutKontrol(klasoryolu);
                string[] NesneTextleri = new string[10];
                if (boyutyol == 0)
                { NesneTextleri[0] = " İş - Zaman Planı - HERHANGİ BİR DOSYA BULUNAMADI! "; }
                else
                { NesneTextleri[0] = " İş - Zaman Planı "; }
                NesneTextleri[1] = Klasor_Is_Zaman_Plani;
                NesneTextleri[2] = "B_Geri_Is_Zaman_Plani";
                NesneTextleri[3] = "B_Ac_Is_Zaman_Plani";
                NesneTextleri[4] = "B_LinkCopy_Is_Zaman_Plani";
                NesneTextleri[5] = "WB_Is_Zaman_Plani";
                NesneTextleri[6] = "";
                NesneTextleri[7] = "";
                NesneTextleri[8] = "";
                NesneTextleri[9] = "";
                if (boyutyol != 0 || (boyutyol == 0 && ChB_PrjSorgu_SadeceDolu.Checked == false))
                {
                    KlasorSorguCevabiListele(Grp_Is_Zaman_Plani, WB_Is_Zaman_Plani, B_Is_Zaman_Plani_Geri, B_Is_Zaman_Plani_Ac, B_Is_Zaman_Plani_CopyLink, NesneTextleri);
                }
            }

            }
            catch
            {
                LB_Sorgu_Hata_Bildirimi.Text = " Hay Aksi! Arama yapılan dizinde bir problem var gibi gözüküyor. Kontrol edilmesi gerekir." +
                    "Bir klasör silinmiş, taşınmış olabilir ya da bir klasör adı standart dışı.";
            }
        
        }


        public void KlasorSorguCevabiListele(GroupBox Grup, WebBrowser WBrowser, Button BGeri, Button BAc, Button LinkCpy, string[] Textler) //  string URL, string GrupAdi,  )
        {
            //Textler[0] Grup ADI
            //Textler[1] Klasör URL
            //Textler[2] Buton Geri Name
            //Textler[3] Buton Ac Name
            //Textler[4] Buton Link Copy Name
            //Textler[5] Web Browser Name
            //Textler[6] 
            //Textler[7] 
            //Textler[8] 
            //Textler[9] 

            // GRUP
            System.Windows.Forms.GroupBox g = new System.Windows.Forms.GroupBox();
            Grup.Text = Textler[0];
            Grup.Size = new Size(422, 160);

            // BROWSER
            System.Windows.Forms.WebBrowser Wb = new System.Windows.Forms.WebBrowser();
            WBrowser.Name = Textler[5];
            WBrowser.Location = new Point(2, 20);
            WBrowser.Size = new Size(381, 138);
            WBrowser.Url = new Uri(Textler[1]);
            Grup.Controls.Add(WBrowser);

            // BUTON - GERİ
            System.Windows.Forms.Button BtnGeri = new System.Windows.Forms.Button();
            BGeri.Name = Textler[2];
            BGeri.Text = "Geri";
            BGeri.Location = new Point(383, 100);
            BGeri.Size = new Size(40, 22);
            BGeri.Click += new EventHandler(ButonGeri); // dinamik olarak oluşturulan butonu kontrol etmek için her oluşturulan butonun clik olayına atıyoruz.
            Grup.Controls.Add(BGeri);

            // BUTON - LİNK COPY
            System.Windows.Forms.Button BLinkCpy = new System.Windows.Forms.Button();
            LinkCpy.Name = Textler[4];
            LinkCpy.Text = " Link\nCopy";
            LinkCpy.Location = new Point(383, 123);
            LinkCpy.Size = new Size(40, 36);
            LinkCpy.Click += new EventHandler(ButonLinkCopy); // dinamik olarak oluşturulan butonu kontrol etmek için her oluşturulan butonun clik olayına atıyoruz.
            Grup.Controls.Add(LinkCpy);

            FLayoutPanel.Controls.Add(Grup);

        }


       

        protected void ButonGeri(object sender, EventArgs e)
        {
            Button DinamikButon = (sender as Button);
            if (DinamikButon.Name == "B_Geri_PLC_Program" && WB_PLC_Program.CanGoBack == true)                          { WB_PLC_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_HMI_Program" && WB_HMI_Program.CanGoBack == true)                          { WB_HMI_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_SCADA_Program" && WB_SCADA_Program.CanGoBack == true)                      { WB_SCADA_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_YARD_Program" && WB_YARD_Program.CanGoBack == true)                        { WB_YARD_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_PC_Program" && WB_PC_Program.CanGoBack == true)                            { WB_PC_Program.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Malzeme_Listesi" && WB_Malzeme_Listesi.CanGoBack == true)                  { WB_Malzeme_Listesi.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Elektrik_Projesi" && WB_Elektrik_Projesi.CanGoBack == true)                { WB_Elektrik_Projesi.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Cizimler" && WB_Cizimler.CanGoBack == true)                                { WB_Cizimler.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Musteri_Iliskileri" && WB_Musteri_Iliskileri.CanGoBack == true)            { WB_Musteri_Iliskileri.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Teklif_Belgeleri" && WB_Teklif_Belgeleri.CanGoBack == true)                { WB_Teklif_Belgeleri.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Servis_Egitim_Formlari" && WB_Servis_Egitim_Formlari.CanGoBack == true)    { WB_Servis_Egitim_Formlari.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Dokumanlar" && WB_Dokumanlar.CanGoBack == true)                            { WB_Dokumanlar.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Diger_Dokumanlar" && WB_Diger_Dokumanlar.CanGoBack == true)                { WB_Diger_Dokumanlar.GoBack(); }
            if (DinamikButon.Name == "B_Geri_FotografVideo" && WB_FotografVideo.CanGoBack == true)                      { WB_FotografVideo.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Tum_Dokumanlar" && WB_Tum_Dokumanlar.CanGoBack == true)                    { WB_Tum_Dokumanlar.GoBack(); }
            if (DinamikButon.Name == "B_Geri_Is_Zaman_Plani" && WB_Is_Zaman_Plani.CanGoBack == true)                    { WB_Is_Zaman_Plani.GoBack(); }
        }

        protected void ButonLinkCopy(object sender, EventArgs e)
        {
            Button DinamikButon = (sender as Button);
            if (DinamikButon.Name == "B_LinkCopy_PLC_Program")              { Clipboard.SetText(Klasor_PLC_Program); }
            if (DinamikButon.Name == "B_LinkCopy_HMI_Program")              { Clipboard.SetText(Klasor_HMI_Program); }
            if (DinamikButon.Name == "B_LinkCopy_SCADA_Program")            { Clipboard.SetText(Klasor_SCADA_Program); }
            if (DinamikButon.Name == "B_LinkCopy_YARD_Program")             { Clipboard.SetText(Klasor_YARD_Program); }
            if (DinamikButon.Name == "B_LinkCopy_PC_Program")               { Clipboard.SetText(Klasor_PC_Program); }
            if (DinamikButon.Name == "B_LinkCopy_Malzeme_Listesi")          { Clipboard.SetText(Klasor_Malzeme_Listesi); }
            if (DinamikButon.Name == "B_LinkCopy_Elektrik_Projesi")         { Clipboard.SetText(Klasor_Elektrik_Projesi); }
            if (DinamikButon.Name == "B_LinkCopy_Cizimler")                 { Clipboard.SetText(Klasor_Cizimler); }

            if (DinamikButon.Name == "B_LinkCopy_Musteri_Iliskileri")           { Clipboard.SetText(Klasor_Musteri_Iliskileri); }
            if (DinamikButon.Name == "B_LinkCopy_Teklif_Belgeleri")             { Clipboard.SetText(Klasor_Teklif_Belgeleri); }
            if (DinamikButon.Name == "B_LinkCopy_Servis_Egitim_Formlari")       { Clipboard.SetText(Klasor_Servis_Egitim_Formlari); }
            if (DinamikButon.Name == "B_LinkCopy_Dokumanlar")                   { Clipboard.SetText(Klasor_Dokumanlar); }
            if (DinamikButon.Name == "B_LinkCopy_Diger_Dokumanlar")             { Clipboard.SetText(Klasor_Diger_Dokumanlar); }
            if (DinamikButon.Name == "B_LinkCopy_FotografVideo")                { Clipboard.SetText(Klasor_FotografVideo); }
            if (DinamikButon.Name == "B_LinkCopy_Tum_Dokumanlar")               { Clipboard.SetText(Klasor_Tum_Dokumanlar); }
            if (DinamikButon.Name == "B_LinkCopy_Is_Zaman_Plani")               { Clipboard.SetText(Klasor_Is_Zaman_Plani); }
        }

        private void B_NitelikSecimTemizle_Click(object sender, EventArgs e)
        {
            ChB_PrjSorgu_PLC_Program.Checked            = false;
            ChB_PrjSorgu_HMI_Program.Checked            = false;
            ChB_PrjSorgu_SCADA_Program.Checked          = false;
            ChB_PrjSorgu_YARD_Program.Checked           = false;
            ChB_PrjSorgu_Malzeme_Listesi.Checked        = false;
            ChB_PrjSorgu_Elektrik_Projesi.Checked       = false;
            ChB_PrjSorgu_Cizimler.Checked               = false;
            ChB_PrjSorgu_PC_Program.Checked             = false;
            ChB_PrjSorgu_Musteri_Iliskileri.Checked     = false;
            ChB_PrjSorgu_Teklif_Belgeleri.Checked       = false;
            ChB_PrjSorgu_Servis_Egitim_Formlari.Checked = false;
            ChB_PrjSorgu_Dokumanlar.Checked             = false;
            ChB_PrjSorgu_FotografVideo.Checked          = false;
            ChB_PrjSorgu_Is_Zaman_Plani.Checked         = false;
        }

        private void B_NitelikSecimHepsiniSec_Click(object sender, EventArgs e)
        {
            ChB_PrjSorgu_PLC_Program.Checked            = true;
            ChB_PrjSorgu_HMI_Program.Checked            = true;
            ChB_PrjSorgu_SCADA_Program.Checked          = true;
            ChB_PrjSorgu_YARD_Program.Checked           = true;
            ChB_PrjSorgu_Malzeme_Listesi.Checked        = true;
            ChB_PrjSorgu_Elektrik_Projesi.Checked       = true;
            ChB_PrjSorgu_Cizimler.Checked               = true;
            ChB_PrjSorgu_PC_Program.Checked             = true;
            ChB_PrjSorgu_Musteri_Iliskileri.Checked     = true;
            ChB_PrjSorgu_Teklif_Belgeleri.Checked       = true;
            ChB_PrjSorgu_Servis_Egitim_Formlari.Checked = true;
            ChB_PrjSorgu_Dokumanlar.Checked             = true;
            ChB_PrjSorgu_FotografVideo.Checked          = true;
            ChB_PrjSorgu_Is_Zaman_Plani.Checked         = true;
        }
        #endregion
     

  //      private void B_UzantiSecimTemizle_Click(object sender, EventArgs e)
  //      {

  //      }

  //      private void B_PLC_Program_DizinGeri_Click(object sender, EventArgs e)
  //      {
  ////          if (WB_PLC_Program.CanGoBack) { WB_PLC_Program.GoBack(); }
  //      }

        //private void B_PLC_Program_DizinLinkCopy_Click(object sender, EventArgs e)
        //{
        //    Clipboard.SetText(Klasor_PLC_Program);
        //}

        //private void B_HMI_Program_DizinGeri_Click(object sender, EventArgs e)
        //{
        //    if (WB_HMI_Program.CanGoBack) { WB_HMI_Program.GoBack(); }
        //}
        
        private void B_Dizin_Gizle_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            B_Dizin_Ac.Visible = true;
        }

        private void B_Dizin_Ac_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            B_Dizin_Ac.Visible = false;
        }

        private void Timer_1sec_Tick(object sender, EventArgs e)
        {
            LB_Time.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            Notify_Bilgi_Uyari();
        }

        private void Timer_1min_Tick(object sender, EventArgs e)
        {
            InternetKontrol();
            
        }

        private void B_Proje_Olustur_Internet_Knt_Click(object sender, EventArgs e)
        {
            InternetKontrol();
        }

        private void B_AnaDizinSec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FbWDialog = new FolderBrowserDialog();
            FbWDialog.ShowDialog();
            LB_AnaDizin.Text = FbWDialog.SelectedPath + "\\";
            Properties.Settings.Default.AnaDizin = LB_AnaDizin.Text;
            Properties.Settings.Default.Save();
            Anadizin = LB_AnaDizin.Text;
        }

        private void TB_Kullanici_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = TB_Kullanici.Text;
            Properties.Settings.Default.Save();
            toolStripKullanici.Text = "  Kullanıcı : " + TB_Kullanici.Text;
        }

        //private void CB_Proje_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            SQL_Sogrulama();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SQL_Yeni_Benzersiz();
            SQL_Sogrulama();
        }

        private void CB_Acilista_Calistir_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Acilista_Calistir.Checked)
            {
                Properties.Settings.Default.acililstaBaslat = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.acililstaBaslat = false;
                Properties.Settings.Default.Save();
            }
            AcilistaCalistir();
        }

      





















    }
}
