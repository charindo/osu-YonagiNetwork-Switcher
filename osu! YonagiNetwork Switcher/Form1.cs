using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace osu__YonagiNetwork_Switcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            remove_hosts_data();
            add_hosts_data();
            MessageBox.Show("Changed the server to YonagiNetwork!\r\nPlease restart osu!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remove_hosts_data();
            MessageBox.Show("Changed the server to osu!\r\nPlease restart osu!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void add_hosts_data()
        {
            string path = @"c:/Windows/System32/drivers/etc/hosts";

            //ファイルの内容を読み込む
            StreamReader sr = new StreamReader(path, Encoding.GetEncoding("Shift_JIS"));

            //内容をすべて読み込む
            string s = sr.ReadToEnd();

            //閉じる
            sr.Close();

            // 文字列置換
            string host = "121.107.10.216";
            s += "\r\n" + host + " osu.ppy.sh";
            s += "\r\n" + host + " c.ppy.sh";
            s += "\r\n" + host + " c1.ppy.sh";
            s += "\r\n" + host + " c2.ppy.sh";
            s += "\r\n" + host + " c3.ppy.sh";
            s += "\r\n" + host + " c4.ppy.sh";
            s += "\r\n" + host + " c5.ppy.sh";
            s += "\r\n" + host + " c6.ppy.sh";
            s += "\r\n" + host + " ce.ppy.sh";
            s += "\r\n" + host + " a.ppy.sh";
            s += "\r\n" + host + " i.ppy.sh";
            s += "\r\n" + host + " i-need-to.click";
            s += "\r\n" + host + " c.i-need-to.click";
            s += "\r\n" + host + " i.i-need-to.click";
            s += "\r\n" + host + " a.i-need-to.click";
            s += "\r\n" + host + " old.i-need-to.click";

            //Shift JISで書き込む
            //書き込むファイルが既に存在している場合は、上書きする
            StreamWriter sw = new StreamWriter(
                path,
                false,
                Encoding.GetEncoding("Shift_JIS"));
            //TextBox1.Textの内容を書き込む
            sw.Write(s);
            //閉じる
            sw.Close();
        }

        private void remove_hosts_data()
        {
            string path = @"c:/Windows/System32/drivers/etc/hosts";

            //ファイルの内容を読み込む
            StreamReader sr = new StreamReader(path, Encoding.GetEncoding("Shift_JIS"));

            //内容をすべて読み込む
            string s = sr.ReadToEnd();

            //閉じる
            sr.Close();

            // 文字列置換
            string host = "121.107.10.216";
            s = s.Replace("\r\n"+host+" osu.ppy.sh", "");
            s = s.Replace("\r\n"+host+" c.ppy.sh", "");
            s = s.Replace("\r\n"+host+" c1.ppy.sh", "");
            s = s.Replace("\r\n"+host+" c2.ppy.sh", "");
            s = s.Replace("\r\n"+host+" c3.ppy.sh", "");
            s = s.Replace("\r\n"+host+" c4.ppy.sh", "");
            s = s.Replace("\r\n"+host+" c5.ppy.sh", "");
            s = s.Replace("\r\n"+host+" c6.ppy.sh", "");
            s = s.Replace("\r\n"+host+" ce.ppy.sh", "");
            s = s.Replace("\r\n"+host+" a.ppy.sh", "");
            s = s.Replace("\r\n"+host+" i.ppy.sh", "");
            s = s.Replace("\r\n" + host + " i-need-to.click", "");
            s = s.Replace("\r\n" + host + " c.i-need-to.click", "");
            s = s.Replace("\r\n" + host + " i.i-need-to.click", "");
            s = s.Replace("\r\n" + host + " a.i-need-to.click", "");
            s = s.Replace("\r\n" + host + " old.i-need-to.click", "");

            //Shift JISで書き込む
            //書き込むファイルが既に存在している場合は、上書きする
            StreamWriter sw = new StreamWriter(
                path,
                false,
                Encoding.GetEncoding("Shift_JIS"));
            //TextBox1.Textの内容を書き込む
            sw.Write(s);
            //閉じる
            sw.Close();
        }
    }
}
