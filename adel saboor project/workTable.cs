using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace adel_saboor_project
{
    public class workTable
    {
        private SqlConnection cn=new SqlConnection() ;
        private SqlCommand cmd=new SqlCommand();
        protected DataTable DT = new DataTable(); //هو الي بيفضل محتفظ بالسجلات الجدول هنا بيفضل ثابت 
        private DataTable Dtwrk = new DataTable();// بسخدمه ف عمليات البحث وكدا ف الجدواول الي فيه بتتغير 
        protected int postion;

        public workTable()
        {
            cn.ConnectionString = @"Data Source=USERFILES\SQLEXPRESS;Initial Catalog=Ader_sapor;Integrated Security=True";
            cmd.Connection = cn;
        }

        public string RunDml(string Stml)
        {
            try
            {
                cmd.CommandText = Stml;
                cn.Open();
                cmd.ExecuteNonQuery();
                 
                return "OK";
            }
            catch (SqlException ex)
            {
                return "Error" + ex.Message;
                 
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable Runquary(string selects)
        {
            try {
                   cmd.CommandText = selects;
                   cn.Open();
                  DT.Load(cmd.ExecuteReader() );
                 
                   return DT;
              }
           catch
               {
                
                  return new DataTable();
            }
         finally
        {
                cn.Close();
             }
         
        }

        public void move_next()
        {
            if (postion < DT.Rows.Count -1)
            
                postion++;
                setData();//هنا هيجب البيانات من الجدول وهيديها للخصائص لعرضها 
            
        }

        public void Move_PRior()
        {
            if (postion > 0)

                postion--;
            setData();//هنا هيجب البيانات من الجدول وهيديها للخصائص لعرضها 
            
        }

        public void move_last()
        {
            postion = DT.Rows.Count - 1;
            setData();
        }

        public string  current_postion()
        {
            return   ((postion+1 ).ToString()) + "  of   " + (DT.Rows.Count.ToString()) ;
        }

        protected virtual void setData()
        {
            
        }

        public bool find(string pk)
        {
            int num = DT.Rows.IndexOf(DT.Rows.Find(pk));
            if (num != -1)
            {
                postion = num;
                setData();
                return true;
            }
            else
                return false;
        }

        public void move_first()
        {
            postion = 0;
           setData();
        }
    }
}
