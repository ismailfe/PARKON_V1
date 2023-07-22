using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Reflection;
using System.Management;
using Microsoft.Win32;
using System.Data;

namespace Parkon
{
   public class NetDataBase
    {



        #region MySql Variable
        MySqlConnection MysqlCon            = new MySqlConnection();
        MySqlConnection MysqlCon_Upd        = new MySqlConnection();
        MySqlConnection MysqlCon_Login      = new MySqlConnection();
        MySqlConnection MysqlCon_cpu        = new MySqlConnection();

        MySqlCommand cmd                    = new MySqlCommand();
        MySqlCommand cmd_Upd                = new MySqlCommand();
        MySqlCommand cmd_cpu                = new MySqlCommand();
        MySqlCommand cmd_Login              = new MySqlCommand();
        MySqlDataReader dr;

        public string ServerName            = "";
        public string DatabaseName          = "";
        public string UserName              = "";
        public string Password = "";

        string UserID;
        string CPU;

        string[] Sql_Read_Qnput0ComText = new string[8];


        string[] Sql_Read_Qnput0 = new string[8];
        string[] Sql_Read_Qnput1 = new string[8];
        string[] Sql_Read_Qnput2 = new string[8];
        string[] Sql_Read_Qnput3 = new string[8];

        //    Thread Th_MysqlRead;
        //    Thread Th_MySqlUpdate;
        //    Thread Th_LoginCheck;

        public bool cpukaydet;
        #endregion



        #region MySQL Prosedür

        public void MySqlConnect()
        {
            MysqlCon.ConnectionString = ("Server=" + ServerName + "Database=" + DatabaseName + "Uid=" + UserName + "Pwd=" + Password);
            //MysqlCon_Upd.ConnectionString = ("Server=" + ServerName + "Database=" + DatabaseName + "Uid=" + UserName + "Pwd=" + Password);
            //MysqlCon_Login.ConnectionString = ("Server=" + ServerName + "Database=" + DatabaseName + "Uid=" + UserName + "Pwd=" + Password);
            //MysqlCon_cpu.ConnectionString = ("Server=" + ServerName + "Database=" + DatabaseName + "Uid=" + UserName + "Pwd=" + Password);
        }

        public void MySqlUpdate()
        {

            //MysqlCon_Upd.Close();
            //for (int i = 0; i < 8; i++)
            //{
            //    cmd_Upd.CommandText = "Update var set Q0" + i + "='" + Output0[i].Checked.ToString() +
            //                                      "', Q1" + i + "='" + Output1[i].Checked.ToString() +
            //                                      "', Q2" + i + "='" + Output2[i].Checked.ToString() +
            //                                      "', Q3" + i + "='" + Output2[i].Checked.ToString() +
            //                                      "' where ID='" + ID + "'";
            //    cmd_Upd.Connection = MysqlCon_Upd;
            //    //  MessageBox.Show("MySQL Connection OK");
            //    MysqlCon_Upd.Open();
            //    cmd_Upd.ExecuteNonQuery();
            //    MysqlCon_Upd.Close();
            //    if (i == 7)
            //    {
            //        Thread.Sleep(2);
            //        i = -1;
            //    }
            //}

        }

        public void MysqlRead()
        {
            //MysqlCon.Close();
            //for (int i = 0; i < 8; i++)
            //{
            //    // mySql tablosunda ID nosuna göre arama yapılır.
            //    // dr içinden istenilen veri okunur.
            //    cmd.CommandText = "Select * From var where ID='" + "1" + "'";
            //    cmd.Connection = MysqlCon;
            //    MysqlCon.Open();
            //    dr = cmd.ExecuteReader();
            //    if (dr.Read() && (i != -1))
            //    {
            //        //SqlInput0[i].Text = dr["I0" + i].ToString();
            //        //SqlInput1[i].Text = dr["I1" + i].ToString();
            //        //SqlInput2[i].Text = dr["I2" + i].ToString();
            //        //SqlInput3[i].Text = dr["I3" + i].ToString();
            //        //     SqlOutput0[i].Text = dr["Q0" + i].ToString();
            //        //     SqlOutput1[i].Text = dr["Q1" + i].ToString();
            //        //     SqlOutput2[i].Text = dr["Q2" + i].ToString();
            //        //     SqlOutput3[i].Text = dr["Q3" + i].ToString();
            //    }
            //    MysqlCon.Close();

            //    if (i == 7)
            //    {
            //        Thread.Sleep(2);
            //        i = -1;
            //    }

            //}

        }

        public void MysqlLoginCheck()
        {
            ////    CpuRead();
            //MysqlCon_Login.Close();
            //try
            //{
            //    // MysqlCon_Login.Close();
            //    cmd_Login.CommandText = "Select * From users where username='" + SimTab.Okuunm + "'"; //SimTab.Okuunm
            //    cmd_Login.Connection = MysqlCon_Login;
            //    MysqlCon_Login.Open();
            //    if (MysqlCon_Login.State != ConnectionState.Closed)
            //    {
            //        dr = cmd_Login.ExecuteReader();
            //        //  label41.Text = "bağlantı ok!";

            //        if (dr.Read())
            //        {

            //            string deneme = dr[3].ToString();
            //            string pas = dr["pass"].ToString();
            //            string no = dr["userno"].ToString();
            //            string ad = dr["name"].ToString();
            //            string id = dr["ID"].ToString();
            //            string cpu1 = dr["cpu1"].ToString();

            //            if (pas == SimTab.Okuups)
            //            {
            //                if (cpu1 != "")
            //                {
            //                    if (cpu1 == CPU)
            //                    {
            //                        SimTab.Yazuno = no;
            //                        SimTab.Yazunm = "ok";
            //                        SimTab.Yazups = "ok";
            //                        SimTab.Yazurst = "true";
            //                        SimTab.Yazad = ad;
            //                        UserID = id;
            //                    }
            //                    else
            //                    {
            //                        SimTab.Yazuno = no;
            //                        SimTab.Yazunm = "ok??";
            //                        SimTab.Yazups = "ok??";
            //                        SimTab.Yazurst = "true";
            //                        SimTab.Yazad = ad;
            //                        SimTab.Yazdif = "true";
            //                        UserID = id;

            //                    }

            //                }
            //                else
            //                {
            //                    // CPU ilk Kayıt
            //                    SimTab.Yazuno = no;
            //                    SimTab.Yazunm = "ok";
            //                    SimTab.Yazups = "ok";
            //                    SimTab.Yazurst = "true";
            //                    SimTab.Yazad = ad;
            //                    UserID = id;
            //                    cpukaydet = true;
            //                }

            //            }
            //            else
            //            {
            //                //şifre hatalı
            //                SimTab.Yazuno = "--";
            //                SimTab.Yazunm = "ok";
            //                SimTab.Yazups = "-h-";
            //                SimTab.Yazurst = "true";
            //                SimTab.Yazad = "--";
            //            }

            //        }
            //        else
            //        {
            //            // "kullanıcı adı hatalı!";
            //            SimTab.Yazuno = "--";
            //            SimTab.Yazunm = "-h-";
            //            SimTab.Yazups = "--";
            //            SimTab.Yazurst = "true";
            //            SimTab.Yazad = "--";
            //        }

            //        MysqlCon_Login.Close();

            //    }
            //    else
            //    {
            //        // label41.Text = "bağlantı sorunu!!!!";
            //    }




            //}
            //catch (Exception)
            //{
            //    ////  MessageBox.Show("server bağlantı problemi");
            //    //  Yazuno = "-??-";
            //    //  Yazunm = "-??-";
            //    //  Yazups = "-??-";
            //    //  Yazurst = "true";
            //    //  Yazad = "-??-";
            //    MysqlLoginCheck();
            //}






        }

        public void MysqlCPUKayit()
        {
            //MysqlCon_cpu.Close();
            //try
            //{

            //    cmd_cpu.CommandText = "Update users set cpu1='" + CPU + "' where id='" + UserID + "'";
            //    cmd_cpu.Connection = MysqlCon_cpu;
            //    //  MessageBox.Show("MySQL Connection OK");
            //    MysqlCon_cpu.Open();
            //    cmd_cpu.ExecuteNonQuery();
            //    MysqlCon_cpu.Close();
            //    cpukaydet = false;

            //    if (MysqlCon_cpu.State != ConnectionState.Closed)
            //    {
            //    }

            //}
            //catch (Exception)
            //{
            //}






        }

        #endregion










    }
}
