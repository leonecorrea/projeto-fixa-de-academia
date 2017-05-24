﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution
{
    public class Instance
    {
        //Leone Notebook
       // SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=DESKTOP-3NL4KDR\\SQLEXPRESS");

        //Una Lab
        SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=BRRLI0201");

        //Una lab Gladson
        SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution1;Data Source=BRRLI0203");


        //Robert PC
        //SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=ROBERT-PC\\SQLEXPRESS");
        
        //Robert UNA
        //SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=BRRLI0202");

        //Gladson PC
        //SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=PC-PC\\INSTANCIA_SQL");

        public SqlConnection instancia()
        {
            return sqlCon;
        }

        public void NovaConexao()
        {
            instancia().Open();
        }

        public void FechaConexao()
        {
            instancia().Close();
        }

        public SqlCommand NovoComando(string query)
        {
            SqlCommand comando = new SqlCommand(query,instancia());
            
            return comando;
        }

        public SqlDataReader LerDados(string query)
        {
            //NovaConexao();
            SqlDataReader leituras = NovoComando(query).ExecuteReader();
            return leituras;
        }
    }
}
