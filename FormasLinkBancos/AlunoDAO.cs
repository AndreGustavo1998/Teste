using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormasLinkBancos
{
    internal class AlunoDAO
    {

        public DataTable Listar()
        {
            SqlConnection connection = new SqlConnection("Server = DESKTOP-KCRP14J\\SQLEXPRESS; Database = banco_Alunos; Trusted_Connection = True;");
            SqlCommand command = new SqlCommand("Select * from Alunos order by Nome", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }



        public List<Aluno> Listar2()
        {
            SqlConnection connection = new SqlConnection("Server = DESKTOP-KCRP14J\\SQLEXPRESS; Database = banco_Alunos; Trusted_Connection = True;");
            SqlCommand command = new SqlCommand("Select * from Alunos order by Nome", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Aluno> lista = new List<Aluno>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Aluno aluno = new Aluno();
                aluno.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                aluno.Nome = dt.Rows[i]["Nome"].ToString();
               
                lista.Add(aluno);
            }



            return lista;
        }

        public List<Aluno> Listar3()
        {
            SqlConnection connection = new SqlConnection("Server = DESKTOP-KCRP14J\\SQLEXPRESS; Database = banco_Alunos; Trusted_Connection = True;");
            //usando ORM Dapper
            return connection.Query<Aluno>("Select * from Alunos order by Nome").ToList();
            
            }


        }

 }
