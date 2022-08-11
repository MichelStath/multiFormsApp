
namespace multiFormsApp
{
    partial class MapForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.customTB1 = new multiFormsApp.customControls.customTB();
            this.label2 = new System.Windows.Forms.Label();
            this.customTB2 = new multiFormsApp.customControls.customTB();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customTB2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.customTB1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 50);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(325, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ΔΙΕΥΘΥΝΣΗ :";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::multiFormsApp.Properties.Resources.exitAppPNG;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(1183, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 45);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1230, 897);
            this.webBrowser1.TabIndex = 2;
            // 
            // customTB1
            // 
            this.customTB1.BackColor = System.Drawing.SystemColors.Window;
            this.customTB1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTB1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTB1.BorderSize = 2;
            this.customTB1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customTB1.ForeColor = System.Drawing.Color.DimGray;
            this.customTB1.Location = new System.Drawing.Point(409, 14);
            this.customTB1.Multiline = false;
            this.customTB1.Name = "customTB1";
            this.customTB1.Padding = new System.Windows.Forms.Padding(7);
            this.customTB1.PasswordChar = false;
            this.customTB1.Size = new System.Drawing.Size(198, 30);
            this.customTB1.TabIndex = 0;
            this.customTB1.Texts = "";
            this.customTB1.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(637, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ΔΗΜΟΣ :";
            // 
            // customTB2
            // 
            this.customTB2.BackColor = System.Drawing.SystemColors.Window;
            this.customTB2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTB2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTB2.BorderSize = 2;
            this.customTB2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customTB2.ForeColor = System.Drawing.Color.DimGray;
            this.customTB2.Location = new System.Drawing.Point(697, 14);
            this.customTB2.Multiline = false;
            this.customTB2.Name = "customTB2";
            this.customTB2.Padding = new System.Windows.Forms.Padding(7);
            this.customTB2.PasswordChar = false;
            this.customTB2.Size = new System.Drawing.Size(198, 30);
            this.customTB2.TabIndex = 4;
            this.customTB2.Texts = "";
            this.customTB2.UnderlinedStyle = false;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 947);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapForm";
            this.Load += new System.EventHandler(this.MapForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private customControls.customTB customTB1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
        private customControls.customTB customTB2;
    }
}