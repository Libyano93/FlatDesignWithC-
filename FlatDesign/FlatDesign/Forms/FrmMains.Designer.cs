
namespace FlatDesign.Forms
{
    partial class FrmMains
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMains));
            this.PnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btnclose = new System.Windows.Forms.Button();
            this.BtnMini = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnCapsulatin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PnlMain.Controls.Add(this.button5);
            this.PnlMain.Controls.Add(this.button4);
            this.PnlMain.Controls.Add(this.button3);
            this.PnlMain.Controls.Add(this.button2);
            this.PnlMain.Controls.Add(this.button7);
            this.PnlMain.Controls.Add(this.button6);
            this.PnlMain.Controls.Add(this.button1);
            this.PnlMain.Controls.Add(this.pictureBox1);
            this.PnlMain.Controls.Add(this.BtnCapsulatin);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlMain.Location = new System.Drawing.Point(720, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(175, 486);
            this.PnlMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnMax);
            this.panel2.Controls.Add(this.BtnMini);
            this.panel2.Controls.Add(this.Btnclose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 45);
            this.panel2.TabIndex = 1;
            // 
            // Btnclose
            // 
            this.Btnclose.FlatAppearance.BorderSize = 0;
            this.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnclose.ImageKey = "delete_sign_64px.png";
            this.Btnclose.ImageList = this.imageList1;
            this.Btnclose.Location = new System.Drawing.Point(3, 3);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(40, 35);
            this.Btnclose.TabIndex = 0;
            this.Btnclose.UseVisualStyleBackColor = true;
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // BtnMini
            // 
            this.BtnMini.FlatAppearance.BorderSize = 0;
            this.BtnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMini.ImageKey = "minimize_window_64px.png";
            this.BtnMini.ImageList = this.imageList1;
            this.BtnMini.Location = new System.Drawing.Point(85, 3);
            this.BtnMini.Name = "BtnMini";
            this.BtnMini.Size = new System.Drawing.Size(40, 35);
            this.BtnMini.TabIndex = 1;
            this.BtnMini.UseVisualStyleBackColor = true;
            this.BtnMini.Click += new System.EventHandler(this.BtnMini_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.ImageKey = "maximize_window_40px.png";
            this.BtnMax.ImageList = this.imageList1;
            this.BtnMax.Location = new System.Drawing.Point(44, 3);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(40, 35);
            this.BtnMax.TabIndex = 2;
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "236831.png");
            this.imageList1.Images.SetKeyName(1, "add_64px.png");
            this.imageList1.Images.SetKeyName(2, "add_100px.png");
            this.imageList1.Images.SetKeyName(3, "books_40px.png");
            this.imageList1.Images.SetKeyName(4, "borrow_book_40px.png");
            this.imageList1.Images.SetKeyName(5, "categorize_40px.png");
            this.imageList1.Images.SetKeyName(6, "collapse_40px.png");
            this.imageList1.Images.SetKeyName(7, "delete_sign_64px.png");
            this.imageList1.Images.SetKeyName(8, "home_filled_40px.png");
            this.imageList1.Images.SetKeyName(9, "info_64px.png");
            this.imageList1.Images.SetKeyName(10, "lock_100px.png");
            this.imageList1.Images.SetKeyName(11, "maximize_window_40px.png");
            this.imageList1.Images.SetKeyName(12, "minimize_window_64px.png");
            this.imageList1.Images.SetKeyName(13, "sell_40px.png");
            this.imageList1.Images.SetKeyName(14, "student_40px.png");
            this.imageList1.Images.SetKeyName(15, "user_filled_40px.png");
            // 
            // BtnCapsulatin
            // 
            this.BtnCapsulatin.FlatAppearance.BorderSize = 0;
            this.BtnCapsulatin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCapsulatin.ImageKey = "collapse_40px.png";
            this.BtnCapsulatin.ImageList = this.imageList1;
            this.BtnCapsulatin.Location = new System.Drawing.Point(12, 12);
            this.BtnCapsulatin.Name = "BtnCapsulatin";
            this.BtnCapsulatin.Size = new System.Drawing.Size(40, 35);
            this.BtnCapsulatin.TabIndex = 2;
            this.BtnCapsulatin.UseVisualStyleBackColor = true;
            this.BtnCapsulatin.Click += new System.EventHandler(this.BtnCapsulatin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlatDesign.Properties.Resources._236831;
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageKey = "add_64px.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(-3, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "المشتريات";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageKey = "borrow_book_40px.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(-3, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "المبيعات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "minimize_window_64px.png";
            this.button3.Location = new System.Drawing.Point(-3, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 45);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.ImageKey = "236831.png";
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(0, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "المخازن";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.ImageKey = "user_filled_40px.png";
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(0, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "المستخدمين";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.ImageKey = "sell_40px.png";
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(0, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 45);
            this.button6.TabIndex = 4;
            this.button6.Text = "الاعدادت";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.ImageKey = "home_filled_40px.png";
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(0, 184);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 45);
            this.button7.TabIndex = 4;
            this.button7.Text = "الرئيسية";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "الشاشة الرئيسية";
            // 
            // FrmMains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlMain);
            this.Font = new System.Drawing.Font("Hacen Saudi Arabia", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmMains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMains";
            this.PnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnMini;
        private System.Windows.Forms.Button Btnclose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCapsulatin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}