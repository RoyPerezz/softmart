﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Configuration;

namespace appSugerencias
{
    class BDConexicon
    {
        //MySqlConnection con;
        //MySqlConnection conVallarta;
        //MySqlConnection conRena;
        //MySqlConnection conVelazquez;
        //MySqlConnection conColoso;
        //MySqlConnection conBodega;



        static string IP= ConfigurationManager.AppSettings["IP"];
        static string BD=ConfigurationManager.AppSettings["BD"];
        static string Estacion= ConfigurationManager.AppSettings["ESTACION"];
        static string User = ConfigurationManager.AppSettings["user"];
        static string Pass = ConfigurationManager.AppSettings["pass"];
        static string Port = ConfigurationManager.AppSettings["port"];

        static string IPVallarta = ConfigurationManager.AppSettings["IpVallarta"];
        static string IPRena = ConfigurationManager.AppSettings["IpRena"];
        static string IPVelazquez = ConfigurationManager.AppSettings["IpVelazquez"];
        static string IPColoso = ConfigurationManager.AppSettings["IpColoso"];
        static string IPCEDIS = ConfigurationManager.AppSettings["IpCEDIS"];
        public static string sucursal()
        {
            string sucursal = "";
            string query = "select EMPRESA from econfig";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sucursal = dr["EMPRESA"].ToString();
            }
            dr.Close();
            con.Close();

            return sucursal;
        }

        public static string optieneIp()
        {
            //TextReader IP;
            //IP = new StreamReader("IP.txt");
            //string ipn = IP.ReadLine();
            //IP.Close();
            //return ipn;
            string Ip = ConfigurationManager.AppSettings["IP"];
            return Ip;
        }

        public static string optieneIPPregot()
        {
            TextReader Ip;
            Ip = new StreamReader("IPPregot.txt");
            string ipn = Ip.ReadLine();
            Ip.Close();
            return ipn;
        }
        public static string optieneBd()
        {
            //TextReader BD;
            //BD = new StreamReader("BD.txt");
            //string bdn = BD.ReadLine();
            //BD.Close();
            //return bdn;
            string BD = ConfigurationManager.AppSettings["BD"];
            return BD;

        }

        public static string optieneEstacion()
        {
            //TextReader leer;
            //leer = new StreamReader("Estacion.txt");
            //string Estacion = leer.ReadLine();
            //leer.Close();
            //return Estacion;
            string Estacion = ConfigurationManager.AppSettings["ESTACION"];
            return Estacion;
        }


        public static MySqlConnection ConexionSucursal(string sucursal)
        {
            MySqlConnection conexion = null;

            if (sucursal.Equals("BODEGA")|| sucursal.Equals("CEDIS") || sucursal.Equals("FINANZAS"))
            {
                conexion = BDConexicon.BodegaOpen();
            }

            if (sucursal.Equals("VALLARTA"))
            {
                conexion = BDConexicon.VallartaOpen();
            }

            if (sucursal.Equals("RENA"))
            {
                conexion = BDConexicon.RenaOpen();
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                conexion = BDConexicon.VelazquezOpen();
            }

            if (sucursal.Equals("COLOSO"))
            {
                conexion = BDConexicon.ColosoOpen();
            }

           
            return conexion;
        }

        public static MySqlConnection conectar()
        {




            //string IP = optieneIp();
            //string BD = optieneBd();
            MySqlConnection con = new MySqlConnection($"server={IP}; database={BD}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            con.Open();



            return con;

        }

        public static MySqlConnection VallartaOpen()
        {


            //string IP = ConfigurationManager.AppSettings["IpVallarta"];
            //string BD = optieneBd();
            MySqlConnection conVallarta = new MySqlConnection($"server={IPVallarta}; database={BD}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            conVallarta.Open();



            return conVallarta;

        }


        public static MySqlConnection RenaOpen()
        {
            //string IP = ConfigurationManager.AppSettings["IpRena"];
            //string BD = optieneBd();
            MySqlConnection conRena = new MySqlConnection($"server={IPRena}; database={BD}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            conRena.Open();



            return conRena;

        }

        public static MySqlConnection VelazquezOpen()
        {
            //string IP = ConfigurationManager.AppSettings["IpVelazquez"];
            //string BD = optieneBd();
            MySqlConnection conVelazquez = new MySqlConnection($"server={IPVelazquez}; database={BD}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            conVelazquez.Open();



            return conVelazquez;

        }



        public static MySqlConnection ColosoOpen()
        {
            //string IP = ConfigurationManager.AppSettings["IpColoso"];
            //string BD = optieneBd();
            MySqlConnection conColoso = new MySqlConnection($"server={IPColoso}; database={BD}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            conColoso.Open();

            return conColoso;


        }

        public static MySqlConnection BodegaOpen()
        {
            //string IP = ConfigurationManager.AppSettings["IpCEDIS"];
            //string BD = optieneBd();
                MySqlConnection conBodega = new MySqlConnection($"server={IPCEDIS}; database={BD}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
                conBodega.Open();
           



            return conBodega;

        }


        public static MySqlConnection VallartaClose()
        {
            //string IP = ConfigurationManager.AppSettings["IpVallarta"];
            //string BD = optieneBd();
            MySqlConnection conVallarta = new MySqlConnection($"server={IPVallarta}; database={BD}; Uid={User}; pwd={Pass};");
            conVallarta.Close();



            return conVallarta;

        }



        public static MySqlConnection RenaClose()
        {
            //string IP = ConfigurationManager.AppSettings["IpRena"];
            //string BD = optieneBd();
            MySqlConnection conRena = new MySqlConnection($"server={IPRena}; database={BD}; Uid={User}; pwd={Pass};");
            conRena.Close();



            return conRena;

        }

        public static MySqlConnection VelazquezClose()
        {

            //string IP = ConfigurationManager.AppSettings["IpVelazquez"];
            //string BD = optieneBd();
            MySqlConnection conVelazquez = new MySqlConnection($"server={IPVelazquez}; database={BD}; Uid={User}; pwd={Pass};");
            conVelazquez.Close();



            return conVelazquez;

        }

        public static MySqlConnection ColosoClose()
        {
            //string IP = ConfigurationManager.AppSettings["IpColoso"];
            //string BD = optieneBd();
            MySqlConnection conColoso = new MySqlConnection($"server={IPColoso}; database={BD}; Uid={User}; pwd={Pass};");
            conColoso.Close();



            return conColoso;

        }

        public static MySqlConnection BodegaClose()
        {
            //string IP = ConfigurationManager.AppSettings["IpCEDIS"];
            //string BD = optieneBd();
            MySqlConnection conBodega = new MySqlConnection($"server={IP}; database={BD}; Uid={User}; pwd={Pass};");
            conBodega.Close();



            return conBodega;

        }

        public static MySqlConnection ConectarClose()
        {
            //string IP = optieneIp();
            //string BD = optieneBd();
            MySqlConnection con = new MySqlConnection($"server={IP}; database={BD}; Uid={User}; pwd={Pass};");
            con.Close();



            return con;

        }



        //###################################### METODOS DE CONEXION A LAS VITRINAS ########################################################

        public static MySqlConnection V_vallarta()
        {


            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection Vvallarta = new MySqlConnection("server=192.168.1.196; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            Vvallarta.Open();



            return Vvallarta;

        }

        public static MySqlConnection V_rena()
        {


            //string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection Vrena = new MySqlConnection("server=192.168.2.3; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            Vrena.Open();



            return Vrena;

        }

        public static MySqlConnection V_coloso()
        {


            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection Vcoloso = new MySqlConnection("server=192.168.3.3; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            Vcoloso.Open();



            return Vcoloso;

        }

        public static MySqlConnection V_velazquez()
        {


            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection Vvelazquez = new MySqlConnection("server=192.168.4.3; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            Vvelazquez.Open();



            return Vvelazquez;

        }

        public static MySqlConnection V_pregot()
        {


            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection Vpregot = new MySqlConnection("server=192.168.6.10; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            Vpregot.Open();



            return Vpregot;

        }


        //#################################################### PAPELERIA ##################################################################//

        public static MySqlConnection Papeleria1Open()
        {
            string BD = optieneBd();
            string IPP = optieneIPPregot();
            MySqlConnection conPapeleria1 = new MySqlConnection("server="+IPP+"; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            conPapeleria1.Open();



            return conPapeleria1;

        }

        //################################## METODOS DE CONEXION A RESPALDOS ########################################################
 

        public static MySqlConnection RespaldoVA(string mes,int año)
        {
            //string IP = ConfigurationManager.AppSettings["IpVallarta"];
            string bd = "VALLARTA " + mes + " " + año;
            string IP = IPVallarta;
            MySqlConnection conVallarta = new MySqlConnection($"server={IP}; database={bd}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");

            //MySqlConnection conVallarta = new MySqlConnection("server=192.168.1.2; database=" + bd + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            conVallarta.Open();

            return conVallarta;

        }

        public static MySqlConnection RespaldoRE(string mes,int año)
        {
            //string IP = ConfigurationManager.AppSettings["IpRena"];
            string bd = "RENA " + mes + " " + año;
            string IP = IPRena;
            MySqlConnection conRena = new MySqlConnection($"server={IP}; database={bd}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            conRena.Open();

            return conRena;

        }

        public static MySqlConnection RespaldoCO(string mes,int año)
        {
            //string IP = ConfigurationManager.AppSettings["IpColoso"];
            string bd = "COLOSO " + mes + " " + año;
            string IP = IPColoso;
            MySqlConnection conColoso = new MySqlConnection($"server={IP}; database={bd}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            conColoso.Open();

            return conColoso;

        }

        public static MySqlConnection RespaldoVE(string mes, int año)
        {
            string bd = "DIEZ " + mes + " " + año;
            string IP = IPVelazquez;
            MySqlConnection conVelazquez = new MySqlConnection($"server={IP}; database={bd}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            conVelazquez.Open();

            return conVelazquez;

        }

        public static MySqlConnection RespaldoPRE(string mes,int año)
        {
            string IPP = optieneIPPregot();
            string bd = "PREGOT " + mes + " " + año;
            MySqlConnection conPregot = new MySqlConnection($"server={IPP}; database={bd}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            conPregot.Open();

            return conPregot;

        }

        public static MySqlConnection RespaldoBO(string mes, int año)
        {
            string bd = "BODEGA " + mes + " " + año;
            MySqlConnection conPregot = new MySqlConnection($"server={IPCEDIS}; database={bd}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            conPregot.Open();

            return conPregot;

        }
        public static MySqlConnection Respconectar(string sucursal,string mes,int año)
        {




            //string IP = optieneIp();
            //string BD = optieneBd();
            MySqlConnection con = new MySqlConnection($"server={IP}; database={sucursal} {mes} {año}; Uid={User}; pwd={Pass};pooling = false; convert zero datetime=True;");
            con.Open();



            return con;

        }

        public static MySqlConnection RespMultiSuc(string sucursal, string mes, int año)
        {

            string dirIP = "";

            if (sucursal.Equals("BODEGA"))
            {
                dirIP = IPCEDIS;
            }

            if (sucursal.Equals("VALLARTA"))
            {
                dirIP = IPVallarta;
            }

            if (sucursal.Equals("RENA"))
            {
                dirIP = IPRena;
            }

            if (sucursal.Equals("COLOSO"))
            {
                dirIP = IPColoso;
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                sucursal = "DIEZ";
                dirIP = IPVelazquez;
            }

            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection con = new MySqlConnection("server=" + dirIP + "; database=" + sucursal + " " + mes + " " + año + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            con.Open();



            return con;

        }

        //****************************Catalogos  BD SAT
        public static MySqlConnection ConectarSat()
        {
            string BD = "sat";
            string IP = optieneIp();
            MySqlConnection ConSat = new MySqlConnection($"server={IP}; database={BD}; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            ConSat.Open();



            return ConSat;

        }

    }
}
