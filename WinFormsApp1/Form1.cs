using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            List<double> dataList = new List<double>();
            if (!string.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str.Split("\n"))
                {
                    dataList.Add(Convert.ToDouble(item));
                }
                //count_v2_lb.Text = dataList.Count().ToString();
                //max_v2_lb.Text = dataList.Max().ToString();
                //min_v2_lb.Text = dataList.Min().ToString();
                //agv_v2_lb.Text = dataList.Average().ToString();
            }

        }
        public string getvalue(StreamReader streamReader, string type,out Dictionary<string,double> keyValuePairs)
        {
            string txt = "";
            while (!streamReader.EndOfStream)
            {
                string str = streamReader.ReadLine();
                txt += str + "\n";
            }
            streamReader.Close();
            Console.Write(txt);
            Console.Read();
            string studyinstanceuid = "";
            keyValuePairs = new Dictionary<string, double>();
            foreach (var item in txt.Split("\n"))
            {
                if (item.Contains("/mnt/dicom_dir/"))
                {
                    if (type == "v3")
                    {
                        string str = item.Split("/mnt/dicom_dir/")[1];
                        string str2 = str.Split(",")[0];
                        studyinstanceuid = str2.Substring(9, str2.Length - 10);
                    }
                    else if (type == "v2")
                    {
                        string str = item.Split("/mnt/dicom_dir/")[1];
                        studyinstanceuid = str.Split("/")[1];
                    }
                    if (!keyValuePairs.ContainsKey(studyinstanceuid))
                    {
                        keyValuePairs.Add(studyinstanceuid, 0);
                    }
                }
                if (item.Contains("succeeded in"))
                {
                    string str_time = item.Split(" in ")[1];
                    double time = Convert.ToDouble(str_time.Substring(0, str_time.Length - 7));
                    keyValuePairs[studyinstanceuid] = time;
                }
            }
            string ss = "";
            foreach (var item in keyValuePairs)
            {
                ss += (item.Key + ":" + item.Value.ToString() + "\n");
            }
            return ss;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, double> keyValuePairs_v2 = new Dictionary<string, double>();
            Dictionary<string, double> keyValuePairs_v3 = new Dictionary<string, double>();
            Dictionary<string, double> keyValuePairs_v2_v3 = new Dictionary<string, double>();
            string txt = "v3:\n";
            StreamReader sr = new StreamReader(@"C:\Work\Learn\Net\NetSample\files\v3-1-result_comsumer.log");
            StreamReader sr_v2 = new StreamReader(@"C:\Work\Learn\Net\NetSample\files\v2-1_task_consumer.log");
            txt += getvalue(sr, "v3",out keyValuePairs_v3);
            txt += "\nv2:\n";
            txt += getvalue(sr_v2, "v2",out keyValuePairs_v2);
            List<double> v2List = new List<double>();
            List<double> v3List = new List<double>();
            List<double> v2v3List = new List<double>();
            foreach (var item in keyValuePairs_v2)
            {
                v2List.Add(item.Value);
               
                double v2 = item.Value;
                double v3 = 0;
                if (keyValuePairs_v3.ContainsKey(item.Key))
                {
                    v3 = keyValuePairs_v3[item.Key];
                    keyValuePairs_v2_v3.Add(item.Key,v2+v3);
                }
            }
            foreach (var item in keyValuePairs_v3)
            {
                v3List.Add(item.Value);
            }
            foreach (var item in keyValuePairs_v2_v3)
            {
                v2v3List.Add(item.Value);
            }
            richTextBox1.Text = txt;
            count_v2_tb.Text = v2List.Count().ToString();
            max_v2_tb.Text = v2List.Max().ToString();
            min_v2_tb.Text = v2List.Min().ToString();
            agv_v2_tb.Text = v2List.Average().ToString();

            count_v3_tb.Text = v3List.Count().ToString();
            max_v3_tb.Text = v3List.Max().ToString();
            min_v3_tb.Text = v3List.Min().ToString();
            agv_v3_tb.Text = v3List.Average().ToString();

            count_v2v3_tb.Text = v2v3List.Count().ToString();
            max_v2v3_tb.Text = v2v3List.Max().ToString();
            min_v2v3_tb.Text = v2v3List.Min().ToString();
            agv_v2v3_tb.Text = v2v3List.Average().ToString();
        }
    }
}
