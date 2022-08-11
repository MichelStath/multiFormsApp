
namespace multiFormsApp
{
    partial class AppointmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entomoktoniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myoktoniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apolymanshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appComments1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appComments2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.multiFormsDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.multiFormsDBDataSet1 = new multiFormsApp.multiFormsDBDataSet1();
            this.cusAppointmentTableAdapter = new multiFormsApp.multiFormsDBDataSet1TableAdapters.cusAppointmentTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.customTB4 = new multiFormsApp.customControls.customTB();
            this.customTB3 = new multiFormsApp.customControls.customTB();
            this.customTB2 = new multiFormsApp.customControls.customTB();
            this.customTB1 = new multiFormsApp.customControls.customTB();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiFormsDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiFormsDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::multiFormsApp.Properties.Resources.exitAppPNG;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(753, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 45);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(335, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "ΕΠΩΝΥΜΟ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(125, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "ΟΝΟΜΑ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(563, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "ΔΙΕΥΘΥΝΣΗ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(827, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "ID :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::multiFormsApp.Properties.Resources.New;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(821, 718);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))));
            this.pictureBox1.Image = global::multiFormsApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cusIDDataGridViewTextBoxColumn,
            this.entomoktoniaDataGridViewTextBoxColumn,
            this.myoktoniaDataGridViewTextBoxColumn,
            this.apolymanshDataGridViewTextBoxColumn,
            this.visitDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.appComments1DataGridViewTextBoxColumn,
            this.appComments2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cusAppointmentBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(875, 567);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "cusID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "cID";
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // entomoktoniaDataGridViewTextBoxColumn
            // 
            this.entomoktoniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.entomoktoniaDataGridViewTextBoxColumn.DataPropertyName = "entomoktonia";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.entomoktoniaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.entomoktoniaDataGridViewTextBoxColumn.FillWeight = 68F;
            this.entomoktoniaDataGridViewTextBoxColumn.HeaderText = "ΕΝΤΟΜΟΚΤΟΝΙΑ";
            this.entomoktoniaDataGridViewTextBoxColumn.Name = "entomoktoniaDataGridViewTextBoxColumn";
            this.entomoktoniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // myoktoniaDataGridViewTextBoxColumn
            // 
            this.myoktoniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.myoktoniaDataGridViewTextBoxColumn.DataPropertyName = "myoktonia";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.myoktoniaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.myoktoniaDataGridViewTextBoxColumn.FillWeight = 68F;
            this.myoktoniaDataGridViewTextBoxColumn.HeaderText = "ΜΥΟΚΤΟΝΙΑ";
            this.myoktoniaDataGridViewTextBoxColumn.Name = "myoktoniaDataGridViewTextBoxColumn";
            this.myoktoniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apolymanshDataGridViewTextBoxColumn
            // 
            this.apolymanshDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apolymanshDataGridViewTextBoxColumn.DataPropertyName = "apolymansh";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.apolymanshDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.apolymanshDataGridViewTextBoxColumn.FillWeight = 68.4353F;
            this.apolymanshDataGridViewTextBoxColumn.HeaderText = "ΑΠΟΛΥΜΑΝΣΗ";
            this.apolymanshDataGridViewTextBoxColumn.Name = "apolymanshDataGridViewTextBoxColumn";
            this.apolymanshDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitDateDataGridViewTextBoxColumn
            // 
            this.visitDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.visitDateDataGridViewTextBoxColumn.DataPropertyName = "visitDate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.visitDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.visitDateDataGridViewTextBoxColumn.FillWeight = 68.4353F;
            this.visitDateDataGridViewTextBoxColumn.HeaderText = "ΗΜ/ΝΙΑ";
            this.visitDateDataGridViewTextBoxColumn.Name = "visitDateDataGridViewTextBoxColumn";
            this.visitDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.priceDataGridViewTextBoxColumn.FillWeight = 68.4353F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "ΤΙΜΗ";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appComments1DataGridViewTextBoxColumn
            // 
            this.appComments1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appComments1DataGridViewTextBoxColumn.DataPropertyName = "appComments1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.appComments1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.appComments1DataGridViewTextBoxColumn.FillWeight = 68.4353F;
            this.appComments1DataGridViewTextBoxColumn.HeaderText = "ΣΧΟΛΙΑ";
            this.appComments1DataGridViewTextBoxColumn.Name = "appComments1DataGridViewTextBoxColumn";
            this.appComments1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appComments2DataGridViewTextBoxColumn
            // 
            this.appComments2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appComments2DataGridViewTextBoxColumn.DataPropertyName = "appComments2";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.appComments2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.appComments2DataGridViewTextBoxColumn.FillWeight = 68.4353F;
            this.appComments2DataGridViewTextBoxColumn.HeaderText = "ΕΞΤΡΑ";
            this.appComments2DataGridViewTextBoxColumn.Name = "appComments2DataGridViewTextBoxColumn";
            this.appComments2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusAppointmentBindingSource
            // 
            this.cusAppointmentBindingSource.DataMember = "cusAppointment";
            this.cusAppointmentBindingSource.DataSource = this.multiFormsDBDataSet1BindingSource;
            // 
            // multiFormsDBDataSet1BindingSource
            // 
            this.multiFormsDBDataSet1BindingSource.DataSource = this.multiFormsDBDataSet1;
            this.multiFormsDBDataSet1BindingSource.Position = 0;
            // 
            // multiFormsDBDataSet1
            // 
            this.multiFormsDBDataSet1.DataSetName = "multiFormsDBDataSet1";
            this.multiFormsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cusAppointmentTableAdapter
            // 
            this.cusAppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::multiFormsApp.Properties.Resources.Reload;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 718);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 55;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customTB4
            // 
            this.customTB4.BackColor = System.Drawing.SystemColors.Window;
            this.customTB4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTB4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTB4.BorderSize = 2;
            this.customTB4.Enabled = false;
            this.customTB4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customTB4.ForeColor = System.Drawing.Color.DimGray;
            this.customTB4.Location = new System.Drawing.Point(858, 84);
            this.customTB4.Multiline = false;
            this.customTB4.Name = "customTB4";
            this.customTB4.Padding = new System.Windows.Forms.Padding(8);
            this.customTB4.PasswordChar = false;
            this.customTB4.Size = new System.Drawing.Size(30, 33);
            this.customTB4.TabIndex = 53;
            this.customTB4.Texts = "";
            this.customTB4.UnderlinedStyle = true;
            // 
            // customTB3
            // 
            this.customTB3.BackColor = System.Drawing.SystemColors.Window;
            this.customTB3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTB3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTB3.BorderSize = 2;
            this.customTB3.Enabled = false;
            this.customTB3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customTB3.ForeColor = System.Drawing.Color.DimGray;
            this.customTB3.Location = new System.Drawing.Point(647, 84);
            this.customTB3.Multiline = false;
            this.customTB3.Name = "customTB3";
            this.customTB3.Padding = new System.Windows.Forms.Padding(8);
            this.customTB3.PasswordChar = false;
            this.customTB3.Size = new System.Drawing.Size(141, 33);
            this.customTB3.TabIndex = 51;
            this.customTB3.Texts = "";
            this.customTB3.UnderlinedStyle = true;
            // 
            // customTB2
            // 
            this.customTB2.BackColor = System.Drawing.SystemColors.Window;
            this.customTB2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTB2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTB2.BorderSize = 2;
            this.customTB2.Enabled = false;
            this.customTB2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customTB2.ForeColor = System.Drawing.Color.DimGray;
            this.customTB2.Location = new System.Drawing.Point(414, 84);
            this.customTB2.Multiline = false;
            this.customTB2.Name = "customTB2";
            this.customTB2.Padding = new System.Windows.Forms.Padding(8);
            this.customTB2.PasswordChar = false;
            this.customTB2.Size = new System.Drawing.Size(141, 33);
            this.customTB2.TabIndex = 49;
            this.customTB2.Texts = "";
            this.customTB2.UnderlinedStyle = true;
            // 
            // customTB1
            // 
            this.customTB1.BackColor = System.Drawing.SystemColors.Window;
            this.customTB1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTB1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTB1.BorderSize = 2;
            this.customTB1.Enabled = false;
            this.customTB1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customTB1.ForeColor = System.Drawing.Color.DimGray;
            this.customTB1.Location = new System.Drawing.Point(186, 84);
            this.customTB1.Multiline = false;
            this.customTB1.Name = "customTB1";
            this.customTB1.Padding = new System.Windows.Forms.Padding(8);
            this.customTB1.PasswordChar = false;
            this.customTB1.Size = new System.Drawing.Size(141, 33);
            this.customTB1.TabIndex = 48;
            this.customTB1.Texts = "";
            this.customTB1.UnderlinedStyle = true;
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.customTB4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customTB3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customTB2);
            this.Controls.Add(this.customTB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentsForm";
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiFormsDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiFormsDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private customControls.customTB customTB2;
        private customControls.customTB customTB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private customControls.customTB customTB3;
        private System.Windows.Forms.Label label3;
        private customControls.customTB customTB4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource multiFormsDBDataSet1BindingSource;
        private multiFormsDBDataSet1 multiFormsDBDataSet1;
        private System.Windows.Forms.BindingSource cusAppointmentBindingSource;
        private multiFormsDBDataSet1TableAdapters.cusAppointmentTableAdapter cusAppointmentTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entomoktoniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn myoktoniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apolymanshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appComments1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appComments2DataGridViewTextBoxColumn;
    }
}