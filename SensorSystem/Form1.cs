using System;
using System.Collections.Generic
;
using System.Windows.Forms
;
using SensorSystem.Classes
;
namespace SensorSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillSensorTypeComboBox();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void FillSensorTypeComboBox()
        {
            SensorType sensorType = new SensorType();
            List<SensorType> sensorTypeList = new List<SensorType>();
            sensorTypeList = sensorType.GetSensorTypes();
            foreach (SensorType sensorTypeItem in sensorTypeList
            )
            {
                comboSensorType.Items.Add
                (sensorTypeItem.SensorTypeName);
            }
        }
        private void SaveData()
        {
            string sensorName = txtSensorName.Text
            ;
            string sensorType = comboSensorType.SelectedItem.ToString();
            Sensor sensor = new Sensor();
            sensor.SaveSensorData
            (sensorName, sensorType);
        }
    }
}