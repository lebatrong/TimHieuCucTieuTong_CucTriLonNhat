namespace DoAn
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmrsd = new System.Windows.Forms.NumericUpDown();
            this.lsds = new System.Windows.Forms.ListView();
            this.cldd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cldc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLTS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtts = new System.Windows.Forms.TextBox();
            this.txtdd = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsv = new System.Windows.Forms.Button();
            this.btop = new System.Windows.Forms.Button();
            this.btrs = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnsd = new System.Windows.Forms.Button();
            this.gbldt = new System.Windows.Forms.GroupBox();
            this.rbvh = new System.Windows.Forms.RadioButton();
            this.rbch = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrsd)).BeginInit();
            this.gbldt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.nmrsd);
            this.panel1.Controls.Add(this.lsds);
            this.panel1.Controls.Add(this.txtts);
            this.panel1.Controls.Add(this.txtdd);
            this.panel1.Controls.Add(this.txtdc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btxoa);
            this.panel1.Controls.Add(this.btsv);
            this.panel1.Controls.Add(this.btop);
            this.panel1.Controls.Add(this.btrs);
            this.panel1.Controls.Add(this.bttim);
            this.panel1.Controls.Add(this.btnc);
            this.panel1.Controls.Add(this.btnsd);
            this.panel1.Controls.Add(this.gbldt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 549);
            this.panel1.TabIndex = 0;
            // 
            // nmrsd
            // 
            this.nmrsd.Location = new System.Drawing.Point(128, 110);
            this.nmrsd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrsd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrsd.Name = "nmrsd";
            this.nmrsd.Size = new System.Drawing.Size(68, 20);
            this.nmrsd.TabIndex = 3;
            this.nmrsd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lsds
            // 
            this.lsds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cldd,
            this.cldc,
            this.CLTS});
            this.lsds.Location = new System.Drawing.Point(27, 279);
            this.lsds.Name = "lsds";
            this.lsds.Size = new System.Drawing.Size(261, 170);
            this.lsds.TabIndex = 15;
            this.lsds.UseCompatibleStateImageBehavior = false;
            this.lsds.View = System.Windows.Forms.View.Details;
            // 
            // cldd
            // 
            this.cldd.Text = "    Đỉnh đầu";
            this.cldd.Width = 80;
            // 
            // cldc
            // 
            this.cldc.Text = "Đỉnh cuối";
            this.cldc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cldc.Width = 80;
            // 
            // CLTS
            // 
            this.CLTS.Text = "Trọng số";
            this.CLTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CLTS.Width = 80;
            // 
            // txtts
            // 
            this.txtts.Enabled = false;
            this.txtts.Location = new System.Drawing.Point(106, 218);
            this.txtts.Name = "txtts";
            this.txtts.Size = new System.Drawing.Size(91, 20);
            this.txtts.TabIndex = 7;
            this.txtts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtts_KeyPress);
            // 
            // txtdd
            // 
            this.txtdd.Enabled = false;
            this.txtdd.Location = new System.Drawing.Point(106, 157);
            this.txtdd.Name = "txtdd";
            this.txtdd.Size = new System.Drawing.Size(91, 20);
            this.txtdd.TabIndex = 5;
            this.txtdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdd_KeyPress);
            // 
            // txtdc
            // 
            this.txtdc.Enabled = false;
            this.txtdc.Location = new System.Drawing.Point(106, 188);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(91, 20);
            this.txtdc.TabIndex = 6;
            this.txtdc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(25, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trọng số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(25, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đỉnh cuối:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(25, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đỉnh đầu:";
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.Color.MidnightBlue;
            this.btxoa.Enabled = false;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.ForeColor = System.Drawing.Color.Silver;
            this.btxoa.Location = new System.Drawing.Point(213, 211);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 9;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsv
            // 
            this.btsv.BackColor = System.Drawing.Color.MidnightBlue;
            this.btsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsv.ForeColor = System.Drawing.Color.Silver;
            this.btsv.Location = new System.Drawing.Point(27, 514);
            this.btsv.Name = "btsv";
            this.btsv.Size = new System.Drawing.Size(75, 23);
            this.btsv.TabIndex = 11;
            this.btsv.Text = "Save";
            this.btsv.UseVisualStyleBackColor = false;
            this.btsv.Click += new System.EventHandler(this.btsv_Click);
            // 
            // btop
            // 
            this.btop.BackColor = System.Drawing.Color.MidnightBlue;
            this.btop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btop.ForeColor = System.Drawing.Color.Silver;
            this.btop.Location = new System.Drawing.Point(121, 514);
            this.btop.Name = "btop";
            this.btop.Size = new System.Drawing.Size(75, 23);
            this.btop.TabIndex = 12;
            this.btop.Text = "Open";
            this.btop.UseVisualStyleBackColor = false;
            this.btop.Click += new System.EventHandler(this.btop_Click);
            // 
            // btrs
            // 
            this.btrs.BackColor = System.Drawing.Color.MidnightBlue;
            this.btrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btrs.ForeColor = System.Drawing.Color.Silver;
            this.btrs.Location = new System.Drawing.Point(213, 514);
            this.btrs.Name = "btrs";
            this.btrs.Size = new System.Drawing.Size(75, 23);
            this.btrs.TabIndex = 13;
            this.btrs.Text = "Reset";
            this.btrs.UseVisualStyleBackColor = false;
            this.btrs.Click += new System.EventHandler(this.btrs_Click);
            // 
            // bttim
            // 
            this.bttim.BackColor = System.Drawing.Color.MidnightBlue;
            this.bttim.Enabled = false;
            this.bttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttim.ForeColor = System.Drawing.Color.Silver;
            this.bttim.Location = new System.Drawing.Point(28, 466);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(261, 33);
            this.bttim.TabIndex = 10;
            this.bttim.Text = "Tìm cực tiểu tổng, cực tiểu trị lớn nhất";
            this.bttim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnc.Enabled = false;
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnc.ForeColor = System.Drawing.Color.Silver;
            this.btnc.Location = new System.Drawing.Point(213, 166);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 23);
            this.btnc.TabIndex = 8;
            this.btnc.Text = "Thêm";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnsd
            // 
            this.btnsd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsd.ForeColor = System.Drawing.Color.Silver;
            this.btnsd.Location = new System.Drawing.Point(213, 110);
            this.btnsd.Name = "btnsd";
            this.btnsd.Size = new System.Drawing.Size(75, 23);
            this.btnsd.TabIndex = 4;
            this.btnsd.Text = "Nhập";
            this.btnsd.UseVisualStyleBackColor = false;
            this.btnsd.Click += new System.EventHandler(this.btnsd_Click);
            // 
            // gbldt
            // 
            this.gbldt.Controls.Add(this.rbvh);
            this.gbldt.Controls.Add(this.rbch);
            this.gbldt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbldt.ForeColor = System.Drawing.Color.LimeGreen;
            this.gbldt.Location = new System.Drawing.Point(14, 14);
            this.gbldt.Name = "gbldt";
            this.gbldt.Size = new System.Drawing.Size(238, 80);
            this.gbldt.TabIndex = 2;
            this.gbldt.TabStop = false;
            this.gbldt.Text = "Chọn loại đồ thị";
            // 
            // rbvh
            // 
            this.rbvh.AutoSize = true;
            this.rbvh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbvh.ForeColor = System.Drawing.Color.Black;
            this.rbvh.Location = new System.Drawing.Point(130, 40);
            this.rbvh.Name = "rbvh";
            this.rbvh.Size = new System.Drawing.Size(91, 20);
            this.rbvh.TabIndex = 2;
            this.rbvh.TabStop = true;
            this.rbvh.Text = "Vô hướng";
            this.rbvh.UseVisualStyleBackColor = true;
            // 
            // rbch
            // 
            this.rbch.AutoSize = true;
            this.rbch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbch.ForeColor = System.Drawing.Color.Black;
            this.rbch.Location = new System.Drawing.Point(13, 40);
            this.rbch.Name = "rbch";
            this.rbch.Size = new System.Drawing.Size(91, 20);
            this.rbch.TabIndex = 1;
            this.rbch.TabStop = true;
            this.rbch.Text = "Có hướng";
            this.rbch.UseVisualStyleBackColor = true;
            this.rbch.CheckedChanged += new System.EventHandler(this.rbch_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(23, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách các cạnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(23, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số đỉnh:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(309, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 549);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cực Tiểu Tổng, Cực Tiểu Trị Lớn Nhất";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrsd)).EndInit();
            this.gbldt.ResumeLayout(false);
            this.gbldt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbldt;
        private System.Windows.Forms.RadioButton rbvh;
        private System.Windows.Forms.RadioButton rbch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsds;
        private System.Windows.Forms.ColumnHeader cldd;
        private System.Windows.Forms.ColumnHeader cldc;
        private System.Windows.Forms.ColumnHeader CLTS;
        private System.Windows.Forms.TextBox txtts;
        private System.Windows.Forms.TextBox txtdd;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btrs;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnsd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmrsd;
        private System.Windows.Forms.Button btsv;
        private System.Windows.Forms.Button btop;
    }
}

