using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIMS
{
    class DataQueries
    {
        public static string[] CheckIDPassWord(string ID,string Password )
        {
            string[] array = new string[2];
            string query = "select * from paitent where id=" +ID  + " and Password="+Password;
            try
            {
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                if (dt.Rows.Count == 1)
                {
                    array[0] = "paitent";
                    array[1] = dt.Rows[0]["name"].ToString();
                    return array;
                }

                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public static string[] CheckIDPassWordDoctor(string ID, string Password)
        {
            string query = "select * from worker where id=" + ID + " and Password=" + Password;
            string[] array=new string[2];
            try
            {
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                if (dt.Rows.Count == 1)
                {
                    array[0]=dt.Rows[0]["job"].ToString() ;
                    array[1]=dt.Rows[0]["name"].ToString() ;
                    return array;
                    
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        
        }



        public static DataTable GetDoctors(string field)
        {
            string query = "select distinct doctor.name from worker, doctor where worker.id=doctor.id and doctor.specialization='" + field + "'";
            try
            {
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable Getappointment(string id)
        {
            string query = "select docname as doctor, day,hour,clinic from appointment where paitentid='" + id + "'";
            try
            {
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable Getfields()
        {
            string query = "select distinct specialization from doctor";// where specialization<>'nurse'";
            try
            {
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable GetClinic(string docname)
        {
            string query = "select distinct clinic from doctor where name='" + docname + "'";
            try
            {
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable Getday(string docname,string clinic)
        {
            string query = "select distinct day from doctor where name='" + docname + "' and clinic='" + clinic + "'";
            try
            {
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                return dt;
            }
            catch
            {
                return null;
            }
        }
      

        public static DataTable Gethours(string docname,string day)
        {
            string query = "select distinct hour from hours where hour not in (select distinct hour from appointment where docname='"+docname+"' and day='"+day+"')";
            try
            {
                DataTable dt = AdoHelper.ExecuteDataTable(query);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static void insertrequest(string content, string ID, string subject, string name,string phone)
        {
            string query1 = "select * from requests";
              DataTable dt = AdoHelper.ExecuteDataTable(query1);
              int i = 0;
              for (int j = 0; j < dt.Rows.Count; j++)
                  if (Int32.Parse(dt.Rows[j]["idrow"].ToString()) > i)
                      i = Int32.Parse(dt.Rows[j]["idrow"].ToString());
              i++;
            string query = "Insert into requests values("+i+" , '" + content + "' , '" + ID + " ', '" + subject + "' , '" + name +"','" + DateTime.Now + "','"+ phone + "')";
        AdoHelper.ExecuteNonQuery(query);
        }

        public static void insertappointment(string id, string docname, string day, string hour, string clinic)
        {
            string query1 = "select * from appointment";
            DataTable dt = AdoHelper.ExecuteDataTable(query1);
            int i=0;
            for (int j = 0; j < dt.Rows.Count; j++)
                if (Int32.Parse( dt.Rows[j]["ident"].ToString()) > i)
                    i = Int32.Parse( dt.Rows[j]["ident"].ToString());
            i++;
            string query = "Insert into appointment values(" + i + " , '" + id + "' , '" + docname + " ', '" + day + "' , '" + hour + "','" + clinic + "')";
            AdoHelper.ExecuteNonQuery(query);
        }

        public static void deleteappointment(string id, string docname, string day, string hour, string clinic)
        {
            string query = "Delete from appointment where paitentid='" + id + "' and docname='" + docname + "' and day='" + day + "' and hour='" + hour + "' and clinic='" + clinic + "'";
            AdoHelper.ExecuteNonQuery(query);
        }
       
    }
}
