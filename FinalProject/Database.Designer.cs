namespace FinalProject
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkInnDataSet = new FinalProject.CheckInnDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkInnDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableTableAdapter = new FinalProject.CheckInnDataSetTableAdapters.bookingTableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.fNameTextbox = new System.Windows.Forms.TextBox();
            this.lNameTextbox = new System.Windows.Forms.TextBox();
            this.addTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.adultsTextbox = new System.Windows.Forms.TextBox();
            this.childrenTextbox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkinDate = new System.Windows.Forms.DateTimePicker();
            this.checkoutDate = new System.Windows.Forms.DateTimePicker();
            this.singleRoom = new System.Windows.Forms.RadioButton();
            this.twinRoom = new System.Windows.Forms.RadioButton();
            this.familyRoom = new System.Windows.Forms.RadioButton();
            this.drcrcard = new System.Windows.Forms.RadioButton();
            this.gcash = new System.Windows.Forms.RadioButton();
            this.totalAmountText = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInnDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dataGridView1.DataSource = this.checkInnDataSetBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(64, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 492);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Address";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "E-mail Address";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Check-in Date";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Check-out Date";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Room";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 150;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Adults";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 150;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Children";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 150;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Payment Option";
            this.Column16.MinimumWidth = 8;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 150;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Total";
            this.Column17.MinimumWidth = 8;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 150;
            // 
            // checkInnDataSetBindingSource
            // 
            this.checkInnDataSetBindingSource.DataSource = this.checkInnDataSet;
            this.checkInnDataSetBindingSource.Position = 0;
            // 
            // checkInnDataSet
            // 
            this.checkInnDataSet.DataSetName = "CheckInnDataSet";
            this.checkInnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Booking Database";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(542, 636);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Check Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(325, 636);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancel Booking";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(194, 636);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2088, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1264, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(405, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // checkInnDataSetBindingSource1
            // 
            this.checkInnDataSetBindingSource1.DataSource = this.checkInnDataSet;
            this.checkInnDataSetBindingSource1.Position = 0;
            // 
            // bookingTableBindingSource
            // 
            this.bookingTableBindingSource.DataMember = "bookingTable";
            this.bookingTableBindingSource.DataSource = this.checkInnDataSet;
            // 
            // bookingTableTableAdapter
            // 
            this.bookingTableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(64, 637);
            this.edit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(108, 48);
            this.edit_button.TabIndex = 14;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(1264, 184);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(405, 26);
            this.idTextbox.TabIndex = 16;
            // 
            // fNameTextbox
            // 
            this.fNameTextbox.Location = new System.Drawing.Point(1264, 216);
            this.fNameTextbox.Name = "fNameTextbox";
            this.fNameTextbox.Size = new System.Drawing.Size(405, 26);
            this.fNameTextbox.TabIndex = 17;
            // 
            // lNameTextbox
            // 
            this.lNameTextbox.Location = new System.Drawing.Point(1264, 248);
            this.lNameTextbox.Name = "lNameTextbox";
            this.lNameTextbox.Size = new System.Drawing.Size(405, 26);
            this.lNameTextbox.TabIndex = 18;
            // 
            // addTextbox
            // 
            this.addTextbox.Location = new System.Drawing.Point(1264, 279);
            this.addTextbox.Name = "addTextbox";
            this.addTextbox.Size = new System.Drawing.Size(405, 26);
            this.addTextbox.TabIndex = 19;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(1264, 340);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(405, 26);
            this.emailTextbox.TabIndex = 20;
            // 
            // adultsTextbox
            // 
            this.adultsTextbox.Location = new System.Drawing.Point(1264, 484);
            this.adultsTextbox.Name = "adultsTextbox";
            this.adultsTextbox.Size = new System.Drawing.Size(405, 26);
            this.adultsTextbox.TabIndex = 22;
            // 
            // childrenTextbox
            // 
            this.childrenTextbox.Location = new System.Drawing.Point(1264, 516);
            this.childrenTextbox.Name = "childrenTextbox";
            this.childrenTextbox.Size = new System.Drawing.Size(405, 26);
            this.childrenTextbox.TabIndex = 23;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(1264, 308);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(405, 26);
            this.phoneTextbox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1076, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1075, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1075, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1075, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1076, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1076, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Email Address";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1075, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "Check-in Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1076, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = "Check-out Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1076, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 29);
            this.label11.TabIndex = 37;
            this.label11.Text = "Room";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1075, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 29);
            this.label12.TabIndex = 38;
            this.label12.Text = "Adults";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1075, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 29);
            this.label13.TabIndex = 39;
            this.label13.Text = "Children";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1075, 545);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 29);
            this.label14.TabIndex = 40;
            this.label14.Text = "Payment Option";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1076, 601);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 29);
            this.label15.TabIndex = 41;
            this.label15.Text = "Total";
            // 
            // checkinDate
            // 
            this.checkinDate.Location = new System.Drawing.Point(1264, 380);
            this.checkinDate.Name = "checkinDate";
            this.checkinDate.Size = new System.Drawing.Size(405, 26);
            this.checkinDate.TabIndex = 42;
            // 
            // checkoutDate
            // 
            this.checkoutDate.Location = new System.Drawing.Point(1264, 417);
            this.checkoutDate.Name = "checkoutDate";
            this.checkoutDate.Size = new System.Drawing.Size(405, 26);
            this.checkoutDate.TabIndex = 43;
            // 
            // singleRoom
            // 
            this.singleRoom.AutoSize = true;
            this.singleRoom.Location = new System.Drawing.Point(5, 6);
            this.singleRoom.Name = "singleRoom";
            this.singleRoom.Size = new System.Drawing.Size(125, 24);
            this.singleRoom.TabIndex = 44;
            this.singleRoom.TabStop = true;
            this.singleRoom.Text = "Single Room";
            this.singleRoom.UseVisualStyleBackColor = true;
            // 
            // twinRoom
            // 
            this.twinRoom.AutoSize = true;
            this.twinRoom.Location = new System.Drawing.Point(145, 6);
            this.twinRoom.Name = "twinRoom";
            this.twinRoom.Size = new System.Drawing.Size(113, 24);
            this.twinRoom.TabIndex = 45;
            this.twinRoom.TabStop = true;
            this.twinRoom.Text = "Twin Room";
            this.twinRoom.UseVisualStyleBackColor = true;
            // 
            // familyRoom
            // 
            this.familyRoom.AutoSize = true;
            this.familyRoom.Location = new System.Drawing.Point(274, 6);
            this.familyRoom.Name = "familyRoom";
            this.familyRoom.Size = new System.Drawing.Size(126, 24);
            this.familyRoom.TabIndex = 46;
            this.familyRoom.TabStop = true;
            this.familyRoom.Text = "Family Room";
            this.familyRoom.UseVisualStyleBackColor = true;
            // 
            // drcrcard
            // 
            this.drcrcard.AutoSize = true;
            this.drcrcard.Location = new System.Drawing.Point(9, 4);
            this.drcrcard.Name = "drcrcard";
            this.drcrcard.Size = new System.Drawing.Size(156, 24);
            this.drcrcard.TabIndex = 47;
            this.drcrcard.TabStop = true;
            this.drcrcard.Text = "Debit/Credit Card";
            this.drcrcard.UseVisualStyleBackColor = true;
            // 
            // gcash
            // 
            this.gcash.AutoSize = true;
            this.gcash.Location = new System.Drawing.Point(171, 4);
            this.gcash.Name = "gcash";
            this.gcash.Size = new System.Drawing.Size(84, 24);
            this.gcash.TabIndex = 48;
            this.gcash.TabStop = true;
            this.gcash.Text = "GCash";
            this.gcash.UseVisualStyleBackColor = true;
            // 
            // totalAmountText
            // 
            this.totalAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountText.Location = new System.Drawing.Point(1269, 601);
            this.totalAmountText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalAmountText.Name = "totalAmountText";
            this.totalAmountText.ReadOnly = true;
            this.totalAmountText.Size = new System.Drawing.Size(163, 35);
            this.totalAmountText.TabIndex = 49;
            this.totalAmountText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(1452, 601);
            this.total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(68, 35);
            this.total.TabIndex = 50;
            this.total.Text = "Total";
            this.total.UseVisualStyleBackColor = true;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.familyRoom);
            this.panel1.Controls.Add(this.twinRoom);
            this.panel1.Controls.Add(this.singleRoom);
            this.panel1.Location = new System.Drawing.Point(1264, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 33);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcash);
            this.panel2.Controls.Add(this.drcrcard);
            this.panel2.Location = new System.Drawing.Point(1265, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 42);
            this.panel2.TabIndex = 52;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1681, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalAmountText);
            this.Controls.Add(this.checkoutDate);
            this.Controls.Add(this.checkinDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.childrenTextbox);
            this.Controls.Add(this.adultsTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.addTextbox);
            this.Controls.Add(this.lNameTextbox);
            this.Controls.Add(this.fNameTextbox);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Database";
            this.Text = "Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Database_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInnDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInnDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource checkInnDataSetBindingSource;
        private CheckInnDataSet checkInnDataSet;
        private System.Windows.Forms.BindingSource checkInnDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bookingTableBindingSource;
        private CheckInnDataSetTableAdapters.bookingTableTableAdapter bookingTableTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox fNameTextbox;
        private System.Windows.Forms.TextBox lNameTextbox;
        private System.Windows.Forms.TextBox addTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox adultsTextbox;
        private System.Windows.Forms.TextBox childrenTextbox;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker checkinDate;
        private System.Windows.Forms.DateTimePicker checkoutDate;
        private System.Windows.Forms.RadioButton singleRoom;
        private System.Windows.Forms.RadioButton twinRoom;
        private System.Windows.Forms.RadioButton familyRoom;
        private System.Windows.Forms.RadioButton drcrcard;
        private System.Windows.Forms.RadioButton gcash;
        private System.Windows.Forms.TextBox totalAmountText;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}