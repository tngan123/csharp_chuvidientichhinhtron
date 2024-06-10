namespace csharp_chuvidientichhinhtron
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btntinhl1 = new System.Windows.Forms.Button();
            this.rdbdientich1 = new System.Windows.Forms.RadioButton();
            this.rdbchuvi1 = new System.Windows.Forms.RadioButton();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lblketqua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.btndientich = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntinhl2 = new System.Windows.Forms.Button();
            this.chkcv = new System.Windows.Forms.CheckBox();
            this.chkdientich = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntinhl1
            // 
            this.btntinhl1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhl1.Location = new System.Drawing.Point(427, 262);
            this.btntinhl1.Name = "btntinhl1";
            this.btntinhl1.Size = new System.Drawing.Size(82, 28);
            this.btntinhl1.TabIndex = 1;
            this.btntinhl1.Text = "tính l1";
            this.btntinhl1.UseVisualStyleBackColor = true;
            this.btntinhl1.Click += new System.EventHandler(this.btntinhn1_Click);
            // 
            // rdbdientich1
            // 
            this.rdbdientich1.AutoSize = true;
            this.rdbdientich1.Location = new System.Drawing.Point(54, 112);
            this.rdbdientich1.Name = "rdbdientich1";
            this.rdbdientich1.Size = new System.Drawing.Size(143, 27);
            this.rdbdientich1.TabIndex = 0;
            this.rdbdientich1.TabStop = true;
            this.rdbdientich1.Text = "Tính diện tích";
            this.rdbdientich1.UseVisualStyleBackColor = true;
            // 
            // rdbchuvi1
            // 
            this.rdbchuvi1.AutoSize = true;
            this.rdbchuvi1.Location = new System.Drawing.Point(54, 43);
            this.rdbchuvi1.Name = "rdbchuvi1";
            this.rdbchuvi1.Size = new System.Drawing.Size(121, 27);
            this.rdbchuvi1.TabIndex = 0;
            this.rdbchuvi1.TabStop = true;
            this.rdbchuvi1.Text = "Tính chu vi";
            this.rdbchuvi1.UseVisualStyleBackColor = true;
            this.rdbchuvi1.CheckedChanged += new System.EventHandler(this.rdbchuvi_CheckedChanged);
            // 
            // txtbankinh
            // 
            this.txtbankinh.BackColor = System.Drawing.Color.LightCoral;
            this.txtbankinh.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankinh.Location = new System.Drawing.Point(117, 83);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(121, 33);
            this.txtbankinh.TabIndex = 1;
            this.txtbankinh.Text = "6.4";
            this.txtbankinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.LightCoral;
            this.txtKQ.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(117, 179);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(169, 33);
            this.txtKQ.TabIndex = 1;
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketqua.Location = new System.Drawing.Point(12, 187);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(89, 25);
            this.lblketqua.TabIndex = 2;
            this.lblketqua.Text = "kết quả ";
            this.lblketqua.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "bán kính ";
            // 
            // btnchuvi
            // 
            this.btnchuvi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnchuvi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuvi.Location = new System.Drawing.Point(35, 242);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(86, 34);
            this.btnchuvi.TabIndex = 3;
            this.btnchuvi.Text = "Chu vi";
            this.btnchuvi.UseVisualStyleBackColor = false;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // btndientich
            // 
            this.btndientich.BackColor = System.Drawing.Color.PowderBlue;
            this.btndientich.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndientich.Location = new System.Drawing.Point(186, 242);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(114, 34);
            this.btndientich.TabIndex = 3;
            this.btndientich.Text = "Diện tích";
            this.btndientich.UseVisualStyleBackColor = false;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.rdbchuvi1);
            this.groupBox1.Controls.Add(this.rdbdientich1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(373, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại 1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.chkdientich);
            this.groupBox2.Controls.Add(this.chkcv);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(636, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 208);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại 2";
            // 
            // btntinhl2
            // 
            this.btntinhl2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhl2.Location = new System.Drawing.Point(699, 262);
            this.btntinhl2.Name = "btntinhl2";
            this.btntinhl2.Size = new System.Drawing.Size(82, 28);
            this.btntinhl2.TabIndex = 1;
            this.btntinhl2.Text = "tính l2";
            this.btntinhl2.UseVisualStyleBackColor = true;
            this.btntinhl2.Click += new System.EventHandler(this.btntinhl2_Click);
            // 
            // chkcv
            // 
            this.chkcv.AutoSize = true;
            this.chkcv.Location = new System.Drawing.Point(32, 52);
            this.chkcv.Name = "chkcv";
            this.chkcv.Size = new System.Drawing.Size(122, 27);
            this.chkcv.TabIndex = 0;
            this.chkcv.Text = "Tính chu vi";
            this.chkcv.UseVisualStyleBackColor = true;
            // 
            // chkdientich
            // 
            this.chkdientich.AutoSize = true;
            this.chkdientich.Location = new System.Drawing.Point(32, 112);
            this.chkdientich.Name = "chkdientich";
            this.chkdientich.Size = new System.Drawing.Size(144, 27);
            this.chkdientich.TabIndex = 0;
            this.chkdientich.Text = "Tính diện tích";
            this.chkdientich.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(782, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(872, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.btntinhl2);
            this.Controls.Add(this.btntinhl1);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbankinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btntinhl1;
        private System.Windows.Forms.RadioButton rdbdientich1;
        private System.Windows.Forms.RadioButton rdbchuvi1;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntinhl2;
        private System.Windows.Forms.CheckBox chkdientich;
        private System.Windows.Forms.CheckBox chkcv;
        private System.Windows.Forms.Button button1;
    }
}

