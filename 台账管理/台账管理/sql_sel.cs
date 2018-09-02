  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace 台账管理
{
    class sql_sel
    {
        public string conn_str = "Data Source=192.168.0.24; Initial Catalog=TaiZhang; User Id=test; Password=12345";

        public SqlConnection myconn = new SqlConnection();
        public SqlCommand mycomm = new SqlCommand();
        public SqlDataReader mydata;
        public SqlDataAdapter myadaper;
        public DataSet mydataset;  
        public Binding mybinding;

        public  void conn()
        {
         
            myconn.ConnectionString = conn_str;
            myconn.Open();
        }

        public object select_all(string table, string r)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table;
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            object return1 = mycomm1.ExecuteScalar();
            myconn1.Close();
            return return1;
        }
        public object select_only(string table, string r, string key, string x)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table + " where " + key + "='" + x + "'";
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            object return1 = mycomm1.ExecuteScalar();
            myconn1.Close();
            return return1;
        }
        public object select_only2(string table, string r, string t)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table + " where " + t ;
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            object return1 = mycomm1.ExecuteScalar();
            myconn1.Close();
            return return1;
        }
        //根据条件搜索第一条记录

        public string select_last(string table,string R)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + R + " From dbo." + table + " order by " + R + " desc";
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            string  top1 = mycomm1.ExecuteScalar().ToString();
            myconn1.Close();
            return top1;
        }

        public SqlDataReader select_dataread_only(string table, string r, string key, string x)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table + " where " + key + "='" + x + "'";
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read1 = mycomm1.ExecuteReader();
            //myconn1.Close();
            return read1;
        }
        public ArrayList select_array_most(string table, string r,string t)
        {
            SqlConnection myconn1 = new SqlConnection();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table + " where " + t ;
            SqlCommand mycomm1 = new SqlCommand(sql_str,myconn1);
            SqlDataReader read1 = mycomm1.ExecuteReader();
            ArrayList arry=new ArrayList();
            while (read1.Read())
            {
                string[] reader=new string[read1.FieldCount];
                for (int j = 0; j < read1.FieldCount; j++)
                {
                    reader[j] = read1[j].ToString();
                }
                arry.Add(reader);
            }
            myconn1.Close();
            return arry;
        }

        public ArrayList select_array_little(string table, string r, string key,string x)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table + " where " + key + "='" + x + "'";
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read1 = mycomm1.ExecuteReader();
            ArrayList arry = new ArrayList();
            while (read1.Read())
            {
                string[] reader = new string[read1.FieldCount];
                for (int j = 0; j < read1.FieldCount; j++)
                {
                    reader[j] = read1[j].ToString();
                }
                arry.Add(reader);
            }
            myconn1.Close();
            return arry;
        }

        public ArrayList select_array_byte_little(string table, string r, string key, string x)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table + " where " + key + "='" + x + "'";
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read1 = mycomm1.ExecuteReader();
            ArrayList arry = new ArrayList();
            while (read1.Read())
            {
                byte[] reader=(byte[])read1[0];                
                arry.Add(reader);
            }
            myconn1.Close();
            return arry;
        }
        public ArrayList select_array_all(string table, string r)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table;
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read1 = mycomm1.ExecuteReader();
            ArrayList arry = new ArrayList();
            while (read1.Read())
            {
                string[] reader = new string[read1.FieldCount];
                for (int j = 0; j < read1.FieldCount; j++)
                {
                    reader[j] = read1[j].ToString();
                }
                arry.Add(reader);
            }
            myconn1.Close();
            return arry;
        }
        public ArrayList select_array_all_order(string table, string r,string o,string d)
        {//有排序条件的查找所有信息
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table+" order by "+o+" "+d;
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read1 = mycomm1.ExecuteReader();
            ArrayList arry = new ArrayList();
            while (read1.Read())
            {
                string[] reader = new string[read1.FieldCount];
                for (int j = 0; j < read1.FieldCount; j++)
                {
                    reader[j] = read1[j].ToString();
                }
                arry.Add(reader);
            }
            myconn1.Close();
            return arry;
        }
        public SqlDataReader select_dataread_all(string table, string r)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table ;
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read2 = mycomm1.ExecuteReader();
            //myconn1.Close();
            return read2;
        }
        public string[] select_dataread_all_zu(string table, string r)
        {//第一列
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table;
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read2 = mycomm1.ExecuteReader();
            
            string[] read= new string[int.Parse(select_all(table, "count(*)").ToString())];
            int i = 0;
            while (read2.Read())
            {
                read[i] = read2[0].ToString();
                    i++;
            }
            myconn1.Close();
            return read;
        }
        public string[] select_dataread_all_zu_where(string table, string r, string key, string x)
        {//单个条件，返回单列
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            key = key.Replace(" ", "");
            x = x.Replace(" ", "");
            string sql_str = "select " + r + " From dbo." + table + " where " + key + " = '" + x + "'";
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read2 = mycomm1.ExecuteReader();
            string[] read = new string[int.Parse(select_only(table, "count(*)", key, x).ToString())];
            int i = 0;
            while (read2.Read())
            {
                read[i] = read2[0].ToString();
                i++;
            }
            myconn1.Close();
            return read;
        }
        public string[] select_string_where_t(string table, string r, string t)
        {//多个条件，返回单列
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string sql_str = "select " + r + " From dbo." + table + " where " + t ;
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read2 = mycomm1.ExecuteReader();
            string[] read = new string[int.Parse(select_only2(table, "count(*)", t).ToString())];
            int i = 0;
            while (read2.Read())
            {
                read[i] = read2[0].ToString();
                i++;
            }
            myconn1.Close();
            return read;
        }
       
        public string[] select_dataread_only_zu_where(string table, string r ,string key,string x)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            key = key.Replace(" ", "");
            x = x.Replace(" ", "");
            string sql_str = "select " + r + " From dbo." + table+" where "+ key +" = '"+x+"'";
            mycomm1.CommandText = sql_str;
            mycomm1.Connection = myconn1;
            SqlDataReader read2 = mycomm1.ExecuteReader();
            string[] read =new string[read2.FieldCount];
            while (read2.Read())
            {
               for(int i = 0; i < read2.FieldCount; i++)
                {
                    read[i] = read2[i].ToString();

                }
            }
            myconn1.Close();
            return read;
        }
        
        public int insert_img(string table,string[] r, byte[] b,string[] values)//插入图片数据
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string rn = "";
            for (int i = 0; i < r.Length; i++)
            {
                rn = rn + r[i];
                if (i < r.Length - 1)
                {
                    rn = rn + ",";
                }
            }
            string vn = "";
            for (int i = 0; i < values.Length; i++)
            {
                vn = vn + "'" + values[i] + "'";
                if (i < values.Length - 1)
                {
                    vn = vn + ",";
                }
            }
            string sql1 = "insert into dbo."+table+"("+rn+ ") values (@image," + vn + ")";//插入image类型的数据
            mycomm1 = new SqlCommand(sql1, myconn1);
            mycomm1.Parameters.Add("@image", SqlDbType.Image).Value = b;
            int xxxx = mycomm1.ExecuteNonQuery();
            myconn1.Close();
            return xxxx;
        }
        public int insert_only(string table,string[] r,string[] values)//插入特殊数据
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string rn = "";
            for (int i=0; i<r.Length; i++)
            {
                rn = rn + r[i];
                if (i < r.Length - 1)
                {
                    rn = rn + ",";
                }
            }
            string vn = "";
            for (int i = 0; i < values.Length; i++)
            {
                vn = vn +"'"+ values[i]+"'";
                if (i < values.Length - 1)
                {
                    vn = vn + ",";
                }
            }
            string sql_str = "insert into dbo."+table+"("+rn+") values (" + vn + ")";
            mycomm1 = new SqlCommand(sql_str, myconn1);
            int hang = mycomm1.ExecuteNonQuery();
            myconn1.Close();
            return hang;
        }
        public int update_only(string table, string[] r, string[] values,string key,string x)
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();
            string vn = "";
            for (int i = 0; i < r.Length; i++)
            {
                vn = vn + r[i]+"='"+values[i]+"'";
                if (i < r.Length - 1)
                {
                    vn = vn + ",";
                }
            }
            string sql_str = "update dbo." + table + " set " + vn + " where " + key + "='"+x+"'";
            mycomm1 = new SqlCommand(sql_str, myconn1);
            int hang = mycomm1.ExecuteNonQuery();
            myconn1.Close();
            return hang;
        }
        public int delete_only(string table, string key, string x)//插入特殊数据
        {
            SqlConnection myconn1 = new SqlConnection();
            SqlCommand mycomm1 = new SqlCommand();
            myconn1.ConnectionString = conn_str;
            myconn1.Open();           
            string sql_str = "delete from dbo." + table + " where " + key + "='" + x + "'";
            mycomm1 = new SqlCommand(sql_str, myconn1);
            int hang = mycomm1.ExecuteNonQuery();
            myconn1.Close();
            return hang;
        }

        public int sql_insert(string sql_str,object  b,string teshuleixing)//插入特殊数据
        {
            mycomm = new SqlCommand(sql_str, myconn);

            if (teshuleixing == "@image")
            {
                mycomm.Parameters.Add("@image", SqlDbType.Image).Value =(byte[]) b;
            }
            if (teshuleixing == "@time")
            {
                mycomm.Parameters.Add("@time", SqlDbType.Time).Value = (DateTime) b;
            }

            return mycomm.ExecuteNonQuery();
        }

        public object select(string sql_str)
        {
            mycomm.CommandText = sql_str;
            mycomm.Connection = myconn;
            object cs= mycomm.ExecuteScalar();//返回查询结果的第一行第一列
            return cs;
        }
        public void sql_select(string sql_str)
        {
            mycomm.CommandText = sql_str;
            mycomm.Connection = myconn;
            mydata = mycomm.ExecuteReader();
        }

        public void dataset(string sql_str,string tb_name)//参数是表名和查询语句
        {
            myadaper = new SqlDataAdapter(sql_str, myconn);
            mydataset = new DataSet();
            myadaper.Fill(mydataset, tb_name);
        }

        public void close()
        {
            myconn.Close();
        }
    }
}
