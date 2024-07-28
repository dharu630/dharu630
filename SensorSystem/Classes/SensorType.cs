using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Configuration;
namespace SensorSystem.Classes
{
    class SensorType
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public int SensorTypeId { get; set; }
        public string SensorTypeName { get; set; }
        public List<SensorType> GetSensorTypes()
        {
            List<SensorType> sensorTypeList = new List<SensorType>();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sqlQuery = "select SensorTypeId, SensorType from SENSOR_TYPE order by SensorType";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    SensorType sensorType = new SensorType();
                    sensorType.SensorTypeId = Convert.ToInt32(dr["SensorTypeId"]);
                    sensorType.SensorTypeName = dr["SensorType"].ToString();
                    sensorTypeList.Add(sensorType);
                }
            }
            con.Close();
            return sensorTypeList;
        }
    }
}