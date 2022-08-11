
namespace multiFormsApp
{
    partial class AppointmentInfoForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.apolymanshTB = new multiFormsApp.customControls.customTB();
            this.myoktoniaTB = new multiFormsApp.customControls.customTB();
            this.entomoktoniaTB = new multiFormsApp.customControls.customTB();
            this.visitComms2TB = new multiFormsApp.customControls.customTB();
            this.visitComms1TB = new multiFormsApp.customControls.customTB();
            this.visitDateTB = new multiFormsApp.customControls.customTB();
            this.visitPriceTB = new multiFormsApp.customControls.customTB();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.pictureBox1.Image = global::multiFormsApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 52);
            this.panel1.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::multiFormsApp.Properties.Resources.exitAppPNG;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(300, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(58, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 75;
            this.label8.Text = "ΑΠΟΛΥΜΑΝΣΗ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(58, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 74;
            this.label7.Text = "ΜΥΟΚΤΟΝΙΑ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(58, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "ΕΝΤΟΜΟΚΤΟΝΙΑ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(254, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 72;
            this.label4.Text = "ΣΧΟΛΙΑ 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(251, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 71;
            this.label3.Text = "ΣΧΟΛΙΑ 1 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(224, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 70;
            this.label2.Text = "ΗΜΕΡΟΜΗΝΙΑ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(275, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 69;
            this.label1.Text = "ΤΙΜΗ :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::multiFormsApp.Properties.Resources.Appointment;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(360, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 83);
            this.button1.TabIndex = 76;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // apolymanshTB
            // 
            this.apolymanshTB.BackColor = System.Drawing.SystemColors.Window;
            this.apolymanshTB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.apolymanshTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.apolymanshTB.BorderSize = 2;
            this.apolymanshTB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.apolymanshTB.ForeColor = System.Drawing.Color.DimGray;
            this.apolymanshTB.Location = new System.Drawing.Point(61, 352);
            this.apolymanshTB.Multiline = false;
            this.apolymanshTB.Name = "apolymanshTB";
            this.apolymanshTB.Padding = new System.Windows.Forms.Padding(7);
            this.apolymanshTB.PasswordChar = false;
            this.apolymanshTB.Size = new System.Drawing.Size(78, 30);
            this.apolymanshTB.TabIndex = 64;
            this.apolymanshTB.Texts = "";
            this.apolymanshTB.UnderlinedStyle = true;
            // 
            // myoktoniaTB
            // 
            this.myoktoniaTB.BackColor = System.Drawing.SystemColors.Window;
            this.myoktoniaTB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.myoktoniaTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.myoktoniaTB.BorderSize = 2;
            this.myoktoniaTB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.myoktoniaTB.ForeColor = System.Drawing.Color.DimGray;
            this.myoktoniaTB.Location = new System.Drawing.Point(61, 278);
            this.myoktoniaTB.Multiline = false;
            this.myoktoniaTB.Name = "myoktoniaTB";
            this.myoktoniaTB.Padding = new System.Windows.Forms.Padding(7);
            this.myoktoniaTB.PasswordChar = false;
            this.myoktoniaTB.Size = new System.Drawing.Size(78, 30);
            this.myoktoniaTB.TabIndex = 63;
            this.myoktoniaTB.Texts = "";
            this.myoktoniaTB.UnderlinedStyle = true;
            // 
            // entomoktoniaTB
            // 
            this.entomoktoniaTB.BackColor = System.Drawing.SystemColors.Window;
            this.entomoktoniaTB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.entomoktoniaTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.entomoktoniaTB.BorderSize = 2;
            this.entomoktoniaTB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.entomoktoniaTB.ForeColor = System.Drawing.Color.DimGray;
            this.entomoktoniaTB.Location = new System.Drawing.Point(61, 207);
            this.entomoktoniaTB.Multiline = false;
            this.entomoktoniaTB.Name = "entomoktoniaTB";
            this.entomoktoniaTB.Padding = new System.Windows.Forms.Padding(7);
            this.entomoktoniaTB.PasswordChar = false;
            this.entomoktoniaTB.Size = new System.Drawing.Size(78, 30);
            this.entomoktoniaTB.TabIndex = 62;
            this.entomoktoniaTB.Texts = "";
            this.entomoktoniaTB.UnderlinedStyle = true;
            // 
            // visitComms2TB
            // 
            this.visitComms2TB.BackColor = System.Drawing.SystemColors.Window;
            this.visitComms2TB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.visitComms2TB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.visitComms2TB.BorderSize = 2;
            this.visitComms2TB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.visitComms2TB.ForeColor = System.Drawing.Color.DimGray;
            this.visitComms2TB.Location = new System.Drawing.Point(322, 348);
            this.visitComms2TB.Multiline = false;
            this.visitComms2TB.Name = "visitComms2TB";
            this.visitComms2TB.Padding = new System.Windows.Forms.Padding(7);
            this.visitComms2TB.PasswordChar = false;
            this.visitComms2TB.Size = new System.Drawing.Size(78, 30);
            this.visitComms2TB.TabIndex = 68;
            this.visitComms2TB.Texts = "";
            this.visitComms2TB.UnderlinedStyle = true;
            // 
            // visitComms1TB
            // 
            this.visitComms1TB.BackColor = System.Drawing.SystemColors.Window;
            this.visitComms1TB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.visitComms1TB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.visitComms1TB.BorderSize = 2;
            this.visitComms1TB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.visitComms1TB.ForeColor = System.Drawing.Color.DimGray;
            this.visitComms1TB.Location = new System.Drawing.Point(322, 280);
            this.visitComms1TB.Multiline = false;
            this.visitComms1TB.Name = "visitComms1TB";
            this.visitComms1TB.Padding = new System.Windows.Forms.Padding(7);
            this.visitComms1TB.PasswordChar = false;
            this.visitComms1TB.Size = new System.Drawing.Size(78, 30);
            this.visitComms1TB.TabIndex = 67;
            this.visitComms1TB.Texts = "";
            this.visitComms1TB.UnderlinedStyle = true;
            // 
            // visitDateTB
            // 
            this.visitDateTB.BackColor = System.Drawing.SystemColors.Window;
            this.visitDateTB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.visitDateTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.visitDateTB.BorderSize = 2;
            this.visitDateTB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.visitDateTB.ForeColor = System.Drawing.Color.DimGray;
            this.visitDateTB.Location = new System.Drawing.Point(322, 212);
            this.visitDateTB.Multiline = false;
            this.visitDateTB.Name = "visitDateTB";
            this.visitDateTB.Padding = new System.Windows.Forms.Padding(7);
            this.visitDateTB.PasswordChar = false;
            this.visitDateTB.Size = new System.Drawing.Size(78, 30);
            this.visitDateTB.TabIndex = 66;
            this.visitDateTB.Texts = "";
            this.visitDateTB.UnderlinedStyle = true;
            // 
            // visitPriceTB
            // 
            this.visitPriceTB.BackColor = System.Drawing.SystemColors.Window;
            this.visitPriceTB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.visitPriceTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.visitPriceTB.BorderSize = 2;
            this.visitPriceTB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.visitPriceTB.ForeColor = System.Drawing.Color.DimGray;
            this.visitPriceTB.Location = new System.Drawing.Point(322, 144);
            this.visitPriceTB.Multiline = false;
            this.visitPriceTB.Name = "visitPriceTB";
            this.visitPriceTB.Padding = new System.Windows.Forms.Padding(7);
            this.visitPriceTB.PasswordChar = false;
            this.visitPriceTB.Size = new System.Drawing.Size(78, 30);
            this.visitPriceTB.TabIndex = 65;
            this.visitPriceTB.Texts = "";
            this.visitPriceTB.UnderlinedStyle = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label15.Location = new System.Drawing.Point(114, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(243, 24);
            this.label15.TabIndex = 77;
            this.label15.Text = "ΣΤΟΙΧΕΙΑ ΕΦΑΡΜΟΓΗΣ";
            // 
            // AppointmentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.apolymanshTB);
            this.Controls.Add(this.myoktoniaTB);
            this.Controls.Add(this.entomoktoniaTB);
            this.Controls.Add(this.visitComms2TB);
            this.Controls.Add(this.visitComms1TB);
            this.Controls.Add(this.visitDateTB);
            this.Controls.Add(this.visitPriceTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentInfoForm";
            this.Load += new System.EventHandler(this.AppointmentInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private customControls.customTB apolymanshTB;
        private customControls.customTB myoktoniaTB;
        private customControls.customTB entomoktoniaTB;
        private customControls.customTB visitComms2TB;
        private customControls.customTB visitComms1TB;
        private customControls.customTB visitDateTB;
        private customControls.customTB visitPriceTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
    }
}