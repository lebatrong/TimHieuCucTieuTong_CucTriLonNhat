namespace DoAn
{
    partial class Frmxuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmxuat));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbctong = new System.Windows.Forms.Label();
            this.lbdctong = new System.Windows.Forms.Label();
            this.lbctieu = new System.Windows.Forms.Label();
            this.lbdctieu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(318, 196);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "✦ Ma trận đường đi ngắn nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "✦ Độ lệch tâm";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(12, 246);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(318, 62);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "✦ Tổng các hàng";
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(12, 330);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(318, 68);
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(15, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cực tiểu tổng lớn nhất là:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(15, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tập các đỉnh có cực tiểu tổng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(15, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cực tiểu trị lớn nhất là:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(15, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tập các đỉnh có cực tiểu trị:";
            // 
            // lbctong
            // 
            this.lbctong.AutoSize = true;
            this.lbctong.BackColor = System.Drawing.Color.Aquamarine;
            this.lbctong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbctong.ForeColor = System.Drawing.Color.Red;
            this.lbctong.Location = new System.Drawing.Point(239, 401);
            this.lbctong.Name = "lbctong";
            this.lbctong.Size = new System.Drawing.Size(0, 16);
            this.lbctong.TabIndex = 5;
            this.lbctong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdctong
            // 
            this.lbdctong.AutoSize = true;
            this.lbdctong.BackColor = System.Drawing.Color.Aquamarine;
            this.lbdctong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdctong.ForeColor = System.Drawing.Color.Red;
            this.lbdctong.Location = new System.Drawing.Point(239, 427);
            this.lbdctong.Name = "lbdctong";
            this.lbdctong.Size = new System.Drawing.Size(0, 16);
            this.lbdctong.TabIndex = 5;
            this.lbdctong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbctieu
            // 
            this.lbctieu.AutoSize = true;
            this.lbctieu.BackColor = System.Drawing.Color.Aquamarine;
            this.lbctieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbctieu.ForeColor = System.Drawing.Color.Red;
            this.lbctieu.Location = new System.Drawing.Point(239, 454);
            this.lbctieu.Name = "lbctieu";
            this.lbctieu.Size = new System.Drawing.Size(0, 16);
            this.lbctieu.TabIndex = 5;
            this.lbctieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdctieu
            // 
            this.lbdctieu.AutoSize = true;
            this.lbdctieu.BackColor = System.Drawing.Color.Aquamarine;
            this.lbdctieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdctieu.ForeColor = System.Drawing.Color.Red;
            this.lbdctieu.Location = new System.Drawing.Point(239, 479);
            this.lbdctieu.Name = "lbdctieu";
            this.lbdctieu.Size = new System.Drawing.Size(0, 16);
            this.lbdctieu.TabIndex = 5;
            this.lbdctieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frmxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(342, 518);
            this.Controls.Add(this.lbdctieu);
            this.Controls.Add(this.lbctieu);
            this.Controls.Add(this.lbdctong);
            this.Controls.Add(this.lbctong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kết quả bài toán";
            this.Load += new System.EventHandler(this.Frmxuat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbctong;
        private System.Windows.Forms.Label lbdctong;
        private System.Windows.Forms.Label lbctieu;
        private System.Windows.Forms.Label lbdctieu;
    }
}