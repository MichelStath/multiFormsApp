
namespace multiFormsApp
{
    partial class NewAppointmentForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.apolymanshTB = new multiFormsApp.customControls.customTB();
            this.myoktoniaTB = new multiFormsApp.customControls.customTB();
            this.entomoktoniaTB = new multiFormsApp.customControls.customTB();
            this.customTB4 = new multiFormsApp.customControls.customTB();
            this.visitComms2TB = new multiFormsApp.customControls.customTB();
            this.visitComms1TB = new multiFormsApp.customControls.customTB();
            this.visitDateTB = new multiFormsApp.customControls.customTB();
            this.visitPriceTB = new multiFormsApp.customControls.customTB();
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
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 52);
            this.panel1.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::multiFormsApp.Properties.Resources.exitAppPNG;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(356, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 45);
            this.button3.TabIndex = 0;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::multiFormsApp.Properties.Resources.User_Add;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(395, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 92);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(271, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "ΤΙΜΗ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(220, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "ΗΜΕΡΟΜΗΝΙΑ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(247, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "ΣΧΟΛΙΑ 1 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(250, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "ΣΧΟΛΙΑ 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(54, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "ΕΝΤΟΜΟΚΤΟΝΙΑ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(54, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 60;
            this.label7.Text = "ΜΥΟΚΤΟΝΙΑ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(54, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 61;
            this.label8.Text = "ΑΠΟΛΥΜΑΝΣΗ :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label15.Location = new System.Drawing.Point(144, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(252, 24);
            this.label15.TabIndex = 78;
            this.label15.Text = "ΕΙΣΑΓΩΓΗ ΕΦΑΡΜΟΓΗΣ";
            // 
            // apolymanshTB
            // 
            this.apolymanshTB.BackColor = System.Drawing.SystemColors.Window;
            this.apolymanshTB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.apolymanshTB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.apolymanshTB.BorderSize = 2;
            this.apolymanshTB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.apolymanshTB.ForeColor = System.Drawing.Color.DimGray;
            this.apolymanshTB.Location = new System.Drawing.Point(57, 349);
            this.apolymanshTB.Multiline = false;
            this.apolymanshTB.Name = "apolymanshTB";
            this.apolymanshTB.Padding = new System.Windows.Forms.Padding(7);
            this.apolymanshTB.PasswordChar = false;
            this.apolymanshTB.Size = new System.Drawing.Size(78, 30);
            this.apolymanshTB.TabIndex = 3;
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
            this.myoktoniaTB.Location = new System.Drawing.Point(57, 275);
            this.myoktoniaTB.Multiline = false;
            this.myoktoniaTB.Name = "myoktoniaTB";
            this.myoktoniaTB.Padding = new System.Windows.Forms.Padding(7);
            this.myoktoniaTB.PasswordChar = false;
            this.myoktoniaTB.Size = new System.Drawing.Size(78, 30);
            this.myoktoniaTB.TabIndex = 2;
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
            this.entomoktoniaTB.Location = new System.Drawing.Point(57, 204);
            this.entomoktoniaTB.Multiline = false;
            this.entomoktoniaTB.Name = "entomoktoniaTB";
            this.entomoktoniaTB.Padding = new System.Windows.Forms.Padding(7);
            this.entomoktoniaTB.PasswordChar = false;
            this.entomoktoniaTB.Size = new System.Drawing.Size(78, 30);
            this.entomoktoniaTB.TabIndex = 1;
            this.entomoktoniaTB.Texts = "";
            this.entomoktoniaTB.UnderlinedStyle = true;
            // 
            // customTB4
            // 
            this.customTB4.BackColor = System.Drawing.SystemColors.Window;
            this.customTB4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTB4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTB4.BorderSize = 2;
            this.customTB4.Enabled = false;
            this.customTB4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customTB4.ForeColor = System.Drawing.Color.DimGray;
            this.customTB4.Location = new System.Drawing.Point(38, 107);
            this.customTB4.Multiline = false;
            this.customTB4.Name = "customTB4";
            this.customTB4.Padding = new System.Windows.Forms.Padding(8);
            this.customTB4.PasswordChar = false;
            this.customTB4.Size = new System.Drawing.Size(32, 32);
            this.customTB4.TabIndex = 55;
            this.customTB4.Texts = "";
            this.customTB4.UnderlinedStyle = true;
            // 
            // visitComms2TB
            // 
            this.visitComms2TB.BackColor = System.Drawing.SystemColors.Window;
            this.visitComms2TB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.visitComms2TB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.visitComms2TB.BorderSize = 2;
            this.visitComms2TB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.visitComms2TB.ForeColor = System.Drawing.Color.DimGray;
            this.visitComms2TB.Location = new System.Drawing.Point(318, 345);
            this.visitComms2TB.Multiline = false;
            this.visitComms2TB.Name = "visitComms2TB";
            this.visitComms2TB.Padding = new System.Windows.Forms.Padding(7);
            this.visitComms2TB.PasswordChar = false;
            this.visitComms2TB.Size = new System.Drawing.Size(78, 30);
            this.visitComms2TB.TabIndex = 7;
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
            this.visitComms1TB.Location = new System.Drawing.Point(318, 277);
            this.visitComms1TB.Multiline = false;
            this.visitComms1TB.Name = "visitComms1TB";
            this.visitComms1TB.Padding = new System.Windows.Forms.Padding(7);
            this.visitComms1TB.PasswordChar = false;
            this.visitComms1TB.Size = new System.Drawing.Size(78, 30);
            this.visitComms1TB.TabIndex = 6;
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
            this.visitDateTB.Location = new System.Drawing.Point(318, 209);
            this.visitDateTB.Multiline = false;
            this.visitDateTB.Name = "visitDateTB";
            this.visitDateTB.Padding = new System.Windows.Forms.Padding(7);
            this.visitDateTB.PasswordChar = false;
            this.visitDateTB.Size = new System.Drawing.Size(78, 30);
            this.visitDateTB.TabIndex = 5;
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
            this.visitPriceTB.Location = new System.Drawing.Point(318, 141);
            this.visitPriceTB.Multiline = false;
            this.visitPriceTB.Name = "visitPriceTB";
            this.visitPriceTB.Padding = new System.Windows.Forms.Padding(7);
            this.visitPriceTB.PasswordChar = false;
            this.visitPriceTB.Size = new System.Drawing.Size(78, 30);
            this.visitPriceTB.TabIndex = 4;
            this.visitPriceTB.Texts = "";
            this.visitPriceTB.UnderlinedStyle = true;
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 583);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.apolymanshTB);
            this.Controls.Add(this.myoktoniaTB);
            this.Controls.Add(this.entomoktoniaTB);
            this.Controls.Add(this.customTB4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.visitComms2TB);
            this.Controls.Add(this.visitComms1TB);
            this.Controls.Add(this.visitDateTB);
            this.Controls.Add(this.visitPriceTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAppointmentForm";
            this.Load += new System.EventHandler(this.NewAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private customControls.customTB visitPriceTB;
        private customControls.customTB visitDateTB;
        private customControls.customTB visitComms1TB;
        private customControls.customTB visitComms2TB;
        private customControls.customTB customTB4;
        private System.Windows.Forms.Label label5;
        private customControls.customTB entomoktoniaTB;
        private customControls.customTB myoktoniaTB;
        private customControls.customTB apolymanshTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
    }
}