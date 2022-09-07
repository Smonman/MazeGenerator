namespace MazeGenerator1 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_output = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox_drawEveryStep = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar_progessbar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_timeelapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker_worker = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_output, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1115, 738);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox_output
            // 
            this.pictureBox_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_output.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_output.Name = "pictureBox_output";
            this.pictureBox_output.Size = new System.Drawing.Size(909, 702);
            this.pictureBox_output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_output.TabIndex = 0;
            this.pictureBox_output.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(918, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 702);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox_drawEveryStep);
            this.groupBox7.Location = new System.Drawing.Point(6, 180);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(179, 46);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Options";
            // 
            // checkBox_drawEveryStep
            // 
            this.checkBox_drawEveryStep.AutoSize = true;
            this.checkBox_drawEveryStep.Location = new System.Drawing.Point(6, 19);
            this.checkBox_drawEveryStep.Name = "checkBox_drawEveryStep";
            this.checkBox_drawEveryStep.Size = new System.Drawing.Size(106, 17);
            this.checkBox_drawEveryStep.TabIndex = 0;
            this.checkBox_drawEveryStep.Text = "Draw Every Step";
            this.toolTip1.SetToolTip(this.checkBox_drawEveryStep, "If this is checked, the programm will draw every step of\r\nthe process of compilin" +
        "g the maze. This will drasticly\r\nslow down the process. Only check if the amount" +
        "\r\nof collums and rows are small.");
            this.checkBox_drawEveryStep.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericUpDown_size);
            this.groupBox6.Location = new System.Drawing.Point(6, 127);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(179, 47);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tile size (px)";
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_size.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(167, 20);
            this.numericUpDown_size.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numericUpDown_size, "This is the size of every tile in the maze. It ranges from\r\n10 to 100.");
            this.numericUpDown_size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_save);
            this.groupBox5.Location = new System.Drawing.Point(9, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 53);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Save";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(6, 19);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(167, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.toolTip1.SetToolTip(this.button_save, "Saves the maze as an image.");
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_stop);
            this.groupBox4.Controls.Add(this.button_generate);
            this.groupBox4.Location = new System.Drawing.Point(6, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 81);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(6, 48);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(167, 23);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "Stop";
            this.toolTip1.SetToolTip(this.button_stop, "This will stop generating the maze");
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(6, 19);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(167, 23);
            this.button_generate.TabIndex = 0;
            this.button_generate.Text = "Generate";
            this.toolTip1.SetToolTip(this.button_generate, "This will start generating the maze.");
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown_height);
            this.groupBox3.Location = new System.Drawing.Point(6, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 47);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Height (px)";
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_height.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_height.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Size = new System.Drawing.Size(167, 20);
            this.numericUpDown_height.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numericUpDown_height, "This is the amount of rows of the image of the maze. Make sure\r\nit is divideable " +
        "through the size to keep the dimensions\r\nof the image.");
            this.numericUpDown_height.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numericUpDown_width);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Width (px)";
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_width.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_width.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.Size = new System.Drawing.Size(167, 20);
            this.numericUpDown_width.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numericUpDown_width, "This is the amount of collums of the image of the maze. Make sure\r\nit is divideab" +
        "le through the size to keep the dimensions\r\nof the image.");
            this.numericUpDown_width.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar_progessbar,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_timeelapsed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(915, 30);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar_progessbar
            // 
            this.toolStripProgressBar_progessbar.Name = "toolStripProgressBar_progessbar";
            this.toolStripProgressBar_progessbar.Size = new System.Drawing.Size(100, 24);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 25);
            this.toolStripStatusLabel1.Text = "Time elapsed:";
            // 
            // toolStripStatusLabel_timeelapsed
            // 
            this.toolStripStatusLabel_timeelapsed.Name = "toolStripStatusLabel_timeelapsed";
            this.toolStripStatusLabel_timeelapsed.Size = new System.Drawing.Size(83, 25);
            this.toolStripStatusLabel_timeelapsed.Text = "TIME ELAPSED";
            // 
            // backgroundWorker_worker
            // 
            this.backgroundWorker_worker.WorkerReportsProgress = true;
            this.backgroundWorker_worker.WorkerSupportsCancellation = true;
            this.backgroundWorker_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_worker_DoWork);
            this.backgroundWorker_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_worker_ProgressChanged);
            this.backgroundWorker_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_worker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 738);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Maze Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox_output;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.NumericUpDown numericUpDown_width;
		private System.Windows.Forms.NumericUpDown numericUpDown_height;
		private System.Windows.Forms.Button button_generate;
		private System.Windows.Forms.Button button_stop;
		private System.Windows.Forms.Button button_save;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.NumericUpDown numericUpDown_size;
		private System.ComponentModel.BackgroundWorker backgroundWorker_worker;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.CheckBox checkBox_drawEveryStep;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_progessbar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_timeelapsed;
	}
}

