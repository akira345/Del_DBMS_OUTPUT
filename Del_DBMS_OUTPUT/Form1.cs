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
		    // ���̌Ăяo���́AWindows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
		    InitializeComponent();

		    // InitializeComponent() �Ăяo���̌�ŏ�������ǉ����܂��B

		    this.txt_in.Multiline = true;
		    //�����A���������̃X�N���[���o�[��\��
		    this.txt_in.ScrollBars = ScrollBars.Both;
		    //���[�h���b�v�𖳌��ɂ���
		    this.txt_in.WordWrap = false;

		    this.txt_in.MaxLength = 65535;
		    this.txt_in.AcceptsReturn = true;
		    this.txt_in.AcceptsTab = true;

		    this.txt_out.Multiline = true;
		    //�����A���������̃X�N���[���o�[��\��
		    this.txt_out.ScrollBars = ScrollBars.Both;
		    //���[�h���b�v�𖳌��ɂ���
		    this.txt_out.WordWrap = false;

		    this.txt_out.MaxLength = 65535;
		    this.txt_out.AcceptsReturn = true;
		    this.txt_out.AcceptsTab = true;

            // �T�C�Y�ύX�s�̒����E�B���h�E�ɕύX����
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TextBox1�ɓ��͂���Ă��镶���񂩂��s���ǂݍ���
            //������(TextBox1�ɓ��͂��ꂽ������)����StringReader�C���X�^���X���쐬
            System.IO.StringReader rs = new System.IO.StringReader(txt_in.Text);
            string tmp = string.Empty;
            string read = string.Empty;
            //�X�g���[���̖��[�܂ŌJ��Ԃ�
            while (rs.Peek() > -1){
                //��s�ǂݍ���ŕ\������
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
            //dbms_output.put_line(hogehoge);�̌`�����폜����B�A�����Ă��폜����悤�ċA�Ăяo��
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
            //�w�肵�������񂪑��݂��邩�`�F�b�N
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