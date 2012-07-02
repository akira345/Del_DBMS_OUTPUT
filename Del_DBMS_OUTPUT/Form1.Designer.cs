namespace Del_DBMS_OUTPUT
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_in = new System.Windows.Forms.TextBox();
            this.txt_out = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_in
            // 
            this.txt_in.Location = new System.Drawing.Point(13, 33);
            this.txt_in.Multiline = true;
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(398, 113);
            this.txt_in.TabIndex = 0;
            this.txt_in.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_in_KeyDown);
            // 
            // txt_out
            // 
            this.txt_out.Location = new System.Drawing.Point(13, 198);
            this.txt_out.Multiline = true;
            this.txt_out.Name = "txt_out";
            this.txt_out.Size = new System.Drawing.Size(398, 126);
            this.txt_out.TabIndex = 1;
            this.txt_out.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_out_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "除去！";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 12);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "SQL";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 149);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 12);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "DBMSを除去します";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 336);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_out);
            this.Controls.Add(this.txt_in);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.TextBox txt_out;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
    }
}

