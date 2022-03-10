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
            branch = convertBranchVictory(branch);
            ProcessStartInfo procStartInfo = new ProcessStartInfo("C:\\Program Files (x86)\\UltraVNC\\vncviewer.exe", "172.31." + branch + "." + position);

            using (Process process = new Process())
            {
                process.StartInfo = procStartInfo;
                process.Start();
                process.WaitForExit();
            }
        }
        private string convertBranchVictory(string branch)
        {
            if (branch == "1") branch = "74";
            else if (branch == "2") branch = "22";
            else if (branch == "3") branch = "20";
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

            return branch;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string branch = textBox1.Text.TrimStart().TrimEnd();
            string position = "10" + textBox2.Text.TrimStart().TrimEnd();
            branch = convertBranchMshuk(branch);
            ProcessStartInfo procStartInfo = new ProcessStartInfo("C:\\Program Files (x86)\\UltraVNC\\vncviewer.exe", "172.30." + branch + "." + position);

            using (Process process = new Process())
            {
                process.StartInfo = procStartInfo;
                process.Start();
                process.WaitForExit();
            }
        }
        private string convertBranchMshuk(string branch)
        {
            if (branch == "1") branch = "24";
            else if (branch == "11") branch = "51";
            else if (branch == "15") branch = "143";
            else if (branch == "20") branch = "20";
            else if (branch == "26") branch = "28";
            else if (branch == "30") branch = "150";
            else if (branch == "35") branch = "35";
            else if (branch == "40") branch = "19";
            else if (branch == "45") branch = "29";
            else if (branch == "50") branch = "18";
            else if (branch == "51") branch = "5";
            else if (branch == "52") branch = "4";
            else if (branch == "55") branch = "144";
            else if (branch == "56") branch = "56";
            else if (branch == "58") branch = "6";
            else if (branch == "59") branch = "7";
            else if (branch == "60") branch = "22";
            else if (branch == "65") branch = "158";
            else if (branch == "66") branch = "140";
            else if (branch == "71") branch = "149";
            else if (branch == "72") branch = "81";
            else if (branch == "75") branch = "148";
            else if (branch == "76") branch = "151";
            else if (branch == "77") branch = "162";
            else if (branch == "80") branch = "27";
            else if (branch == "81") branch = "142";
            else if (branch == "91") branch = "80";
            else if (branch == "97") branch = "1";
            else if (branch == "98") branch = "159";
            else if (branch == "99") branch = "16";
            else if (branch == "202") branch = "100";
            else if (branch == "203") branch = "101";
            else if (branch == "205") branch = "103";
            else if (branch == "207") branch = "104";
            else if (branch == "208") branch = "105";
            else if (branch == "211") branch = "106";
            else if (branch == "212") branch = "107";
            else if (branch == "217") branch = "108";
            else if (branch == "218") branch = "109";
            else if (branch == "220") branch = "110";
            else if (branch == "222") branch = "111";
            else if (branch == "223") branch = "112";
            else if (branch == "230") branch = "113";
            else if (branch == "238") branch = "114";
            else if (branch == "239") branch = "115";
            else if (branch == "241") branch = "116";
            else if (branch == "242") branch = "117";
            else if (branch == "244") branch = "119";
            else if (branch == "245") branch = "120";
            else if (branch == "246") branch = "121";
            else if (branch == "247") branch = "122";
            else if (branch == "248") branch = "123";
            else if (branch == "250") branch = "124";
            else if (branch == "254") branch = "125";
            else if (branch == "260") branch = "126";
            else if (branch == "261") branch = "127";
            else if (branch == "262") branch = "128";
            else if (branch == "263") branch = "129";
            else if (branch == "264") branch = "130";
            else if (branch == "265") branch = "131";
            else if (branch == "266") branch = "132";
            else if (branch == "267") branch = "133";
            else if (branch == "268") branch = "134";
            else if (branch == "274") branch = "135";
            else if (branch == "277") branch = "136";
            else if (branch == "289") branch = "137";
            else if (branch == "290") branch = "138";
            return branch;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string branch = textBox1.Text.TrimStart().TrimEnd();
            string position = "10" + textBox2.Text.TrimStart().TrimEnd();
            branch = convertBranchBareket(branch);
            ProcessStartInfo procStartInfo = new ProcessStartInfo("C:\\Program Files (x86)\\UltraVNC\\vncviewer.exe", "172.15." + branch + "." + position);

            using (Process process = new Process())
            {
                process.StartInfo = procStartInfo;
                process.Start();
                process.WaitForExit();
            }
        }
        private string convertBranchBareket(string branch)
        {
            if (branch == "2") branch = "2";
            else if (branch == "11") branch = "51";
            else if (branch == "5") branch = "60";
            else if (branch == "6") branch = "1";
            else if (branch == "7") branch = "7";
            else if (branch == "8") branch = "8";
            else if (branch == "9") branch = "9";
            else if (branch == "10") branch = "10";
            else if (branch == "60") branch = "5";
            else if (branch == "61") branch = "61";
            else if (branch == "62") branch = "70";
            else if (branch == "63") branch = "55";

            return branch;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string branch = textBox1.Text.TrimStart().TrimEnd();
            string position = "10" + textBox2.Text.TrimStart().TrimEnd();
            branch = convertBranchHCohen(branch);
            ProcessStartInfo procStartInfo = new ProcessStartInfo("C:\\Program Files (x86)\\UltraVNC\\vncviewer.exe", "172.30." + branch + "." + position);
            using (Process process = new Process())
            {
                process.StartInfo = procStartInfo;
                process.Start();
                process.WaitForExit();
            }
        }
        private string convertBranchHCohen(string branch)
        {
            if (branch == "1") branch = "14";
            else if (branch == "45") branch = "50";
            else if (branch == "65") branch = "65";
            else if (branch == "75") branch = "40";
            return branch;
        }
    }
}