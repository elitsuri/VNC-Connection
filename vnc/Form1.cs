using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vnc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string branch = textBox1.Text.TrimStart().TrimEnd();
            string position = "10" + textBox2.Text.TrimStart().TrimEnd();
            if (branch == "1") branch = "74";
            else if (branch == "2") branch = "22";
            else if(branch == "3") branch = "20";
            else if (branch == "5") branch = "237";
            else if (branch == "7") branch = "47";
            else if (branch == "8") branch = "23";
            else if (branch == "9") branch = "80";
            else if (branch == "10") branch = "24";
            else if (branch == "14") branch = "49";
            else if (branch == "16") branch = "49";
            else if (branch == "22") branch = "83";
            else if (branch == "23") branch = "61";
            else if (branch == "24") branch = "84";
            else if (branch == "25") branch = "60";
            else if (branch == "26") branch = "116";
            else if (branch == "27") branch = "81";
            else if (branch == "28") branch = "33";
            else if (branch == "29") branch = "82";
            else if (branch == "30") branch = "45";
            else if (branch == "32") branch = "58";
            else if (branch == "34") branch = "50";
            else if (branch == "38") branch = "89";
            else if (branch == "41") branch = "55";
            else if (branch == "44") branch = "44";
            else if (branch == "45") branch = "71";
            else if (branch == "46") branch = "66";
            else if (branch == "47") branch = "67";
            else if (branch == "48") branch = "90";
            else if (branch == "50") branch = "72";
            else if (branch == "51") branch = "40";
            else if (branch == "52") branch = "29";
            else if (branch == "53") branch = "69";
            else if (branch == "54") branch = "28";
            else if (branch == "55") branch = "25";
            else if (branch == "56") branch = "87";
            else if (branch == "58") branch = "85";
            else if (branch == "59") branch = "59";
            else if (branch == "61") branch = "53";
            else if (branch == "65") branch = "57";
            else if (branch == "68") branch = "52";
            else if (branch == "69") branch = "70";
            else if (branch == "70") branch = "51";
            else if (branch == "71") branch = "68";
            else if (branch == "73") branch = "65";
            else if (branch == "74") branch = "77";
            else if (branch == "77") branch = "18";
            else if (branch == "78") branch = "38";
            else if (branch == "79") branch = "79";
            else if (branch == "81") branch = "65";
            else if (branch == "83") branch = "88";
            else if (branch == "86") branch = "54";
            else if (branch == "87") branch = "93";
            else if (branch == "88") branch = "91";
            else if (branch == "89") branch = "92";
            else if (branch == "90") branch = "239";
            else if (branch == "91") branch = "73";
            else if (branch == "92") branch = "86";
            else if (branch == "95") branch = "62";
            else if (branch == "96") branch = "75";


            ProcessStartInfo procStartInfo = new ProcessStartInfo("C:\\Program Files (x86)\\UltraVNC\\vncviewer.exe", "172.31."+ branch + "." + position);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;


            using (Process process = new Process())
            {
                process.StartInfo = procStartInfo;
                process.Start();
                // Add this: wait until process does its work
                process.WaitForExit();
            }
        }
    }
}