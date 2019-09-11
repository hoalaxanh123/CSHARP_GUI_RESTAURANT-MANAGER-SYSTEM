namespace QLCaPheProject
{
    partial class frm_FormPhu_NhapSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FormPhu_NhapSo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_THem = new System.Windows.Forms.Button();
            this.txt_SoBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_THem);
            this.groupBox1.Controls.Add(this.txt_SoBan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(192, 65);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Hủy";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_THem
            // 
            this.btn_THem.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_THem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THem.ForeColor = System.Drawing.Color.Black;
            this.btn_THem.Location = new System.Drawing.Point(92, 65);
            this.btn_THem.Name = "btn_THem";
            this.btn_THem.Size = new System.Drawing.Size(75, 23);
            this.btn_THem.TabIndex = 2;
            this.btn_THem.Text = "Thêm";
            this.btn_THem.UseVisualStyleBackColor = false;
            this.btn_THem.Click += new System.EventHandler(this.btn_THem_Click);
            // 
            // txt_SoBan
            // 
            this.txt_SoBan.Location = new System.Drawing.Point(92, 28);
            this.txt_SoBan.Name = "txt_SoBan";
            this.txt_SoBan.Size = new System.Drawing.Size(184, 21);
            this.txt_SoBan.TabIndex = 1;
            this.txt_SoBan.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số :";
            // 
            // frm_FormPhu_NhapSo
            // 
            this.AcceptButton = this.btn_THem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(348, 119);
            this.Controls.Add(this.groupBox1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_FormPhu_NhapSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_FormPhu_NhapSoBan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_THem;
        private System.Windows.Forms.TextBox txt_SoBan;
        private System.Windows.Forms.Label label1;
    }
}