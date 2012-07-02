using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Del_DBMS_OUTPUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
		    // この呼び出しは、Windows フォーム デザイナで必要です。
		    InitializeComponent();

		    // InitializeComponent() 呼び出しの後で初期化を追加します。

		    this.txt_in.Multiline = true;
		    //垂直、水平両方のスクロールバーを表示
		    this.txt_in.ScrollBars = ScrollBars.Both;
		    //ワードラップを無効にする
		    this.txt_in.WordWrap = false;

		    this.txt_in.MaxLength = 65535;
		    this.txt_in.AcceptsReturn = true;
		    this.txt_in.AcceptsTab = true;

		    this.txt_out.Multiline = true;
		    //垂直、水平両方のスクロールバーを表示
		    this.txt_out.ScrollBars = ScrollBars.Both;
		    //ワードラップを無効にする
		    this.txt_out.WordWrap = false;

		    this.txt_out.MaxLength = 65535;
		    this.txt_out.AcceptsReturn = true;
		    this.txt_out.AcceptsTab = true;

            // サイズ変更不可の直線ウィンドウに変更する
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TextBox1に入力されている文字列から一行ずつ読み込む
            //文字列(TextBox1に入力された文字列)からStringReaderインスタンスを作成
            System.IO.StringReader rs = new System.IO.StringReader(txt_in.Text);
            string tmp = string.Empty;
            string read = string.Empty;
            //ストリームの末端まで繰り返す
            while (rs.Peek() > -1){
                //一行読み込んで表示する
                read = rs.ReadLine();
                if (read.Length > 0){
                    if ((string.IsNullOrEmpty(this.del_dbms_output(read)) == false)){
                        tmp += del_dbms_output(read) + "\r\n";
                    }
                }

            }
            rs.Close();
            txt_out.Text = tmp;
        }
        private string del_dbms_output(string in_str){
            //dbms_output.put_line(hogehoge);の形式を削除する。連続しても削除するよう再帰呼び出し
            if ((this.HasString(in_str.ToUpper(), "DBMS_OUTPUT.PUT_LINE") == true) && (this.HasString(in_str, ";") == true)){
                int start_point = in_str.ToUpper().IndexOf("DBMS_OUTPUT.PUT_LINE");
                int end_point = in_str.Substring(start_point).IndexOf(";");
                in_str = in_str.Substring(0, start_point) + in_str.Substring(start_point + end_point + 1);
                return del_dbms_output(in_str);
            }else{
                return in_str;
            }
        }
        private bool HasString(string target, string word){
            //指定した文字列が存在するかチェック
            if (string.IsNullOrEmpty(word)){
                return false;
            }
            if (target.IndexOf(word) >= 0){
                return true;
            }else{
                return false;
            }
        }

        private void txt_in_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e){
            if (e.KeyCode == Keys.A && e.Control){
                //ctrl+A
                ((TextBox)sender).SelectAll();
            }
        }
        private void txt_out_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e){
            if (e.KeyCode == Keys.A && e.Control){
                //ctrl+A
                ((TextBox)sender).SelectAll();
            }
        }
    }
}