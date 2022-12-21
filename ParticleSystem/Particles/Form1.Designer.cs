namespace Particles {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.pbMain = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.trackBar4 = new System.Windows.Forms.TrackBar();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
			this.SuspendLayout();
			// 
			// pbMain
			// 
			this.pbMain.BackColor = System.Drawing.SystemColors.Control;
			this.pbMain.Location = new System.Drawing.Point(0, 0);
			this.pbMain.Margin = new System.Windows.Forms.Padding(0);
			this.pbMain.Name = "pbMain";
			this.pbMain.Size = new System.Drawing.Size(1128, 626);
			this.pbMain.TabIndex = 0;
			this.pbMain.TabStop = false;
			this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
			this.pbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseClick);
			this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseDown);
			this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
			this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseUp);
			this.pbMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseWheel);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(932, 626);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "Кол-во частиц: ";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 665);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(58, 18);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Пауза";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(678, 665);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(104, 45);
			this.trackBar1.TabIndex = 3;
			this.trackBar1.Value = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(668, 699);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "Гравитация частиц";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(171, 699);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "Скорость вращения эмиттера";
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(208, 665);
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(104, 45);
			this.trackBar2.TabIndex = 5;
			this.trackBar2.Value = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(379, 699);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 14);
			this.label4.TabIndex = 8;
			this.label4.Text = "Радиус эмиттера";
			// 
			// trackBar3
			// 
			this.trackBar3.Location = new System.Drawing.Point(379, 665);
			this.trackBar3.Maximum = 150;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(104, 45);
			this.trackBar3.TabIndex = 7;
			this.trackBar3.Value = 25;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(12, 638);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(60, 18);
			this.checkBox2.TabIndex = 9;
			this.checkBox2.Text = "Debug";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(521, 699);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 14);
			this.label5.TabIndex = 11;
			this.label5.Text = "Скорость частиц";
			// 
			// trackBar4
			// 
			this.trackBar4.LargeChange = 1;
			this.trackBar4.Location = new System.Drawing.Point(522, 665);
			this.trackBar4.Maximum = 100;
			this.trackBar4.Minimum = 1;
			this.trackBar4.Name = "trackBar4";
			this.trackBar4.Size = new System.Drawing.Size(104, 45);
			this.trackBar4.TabIndex = 10;
			this.trackBar4.Value = 50;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 690);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Шаг";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(876, 662);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(178, 24);
			this.button2.TabIndex = 13;
			this.button2.Text = "Выбрать цвет эмиттера";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(948, 690);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(33, 24);
			this.panel1.TabIndex = 14;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(84, 638);
			this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(114, 18);
			this.checkBox3.TabIndex = 15;
			this.checkBox3.Text = "Счётчик частиц";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(470, 633);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(156, 23);
			this.button3.TabIndex = 16;
			this.button3.Text = "Нарисовать пейзаж";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(668, 635);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 21);
			this.button4.TabIndex = 17;
			this.button4.Text = "Очистка холста";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(84, 661);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(75, 18);
			this.checkBox4.TabIndex = 18;
			this.checkBox4.Text = "Порталы";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1128, 722);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.trackBar4);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.trackBar3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbMain);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Частицы";
			((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pbMain;
		private System.Windows.Forms.Timer timer1;
		private Label label1;
		private CheckBox checkBox1;
		private TrackBar trackBar1;
		private Label label2;
		private Label label3;
		private TrackBar trackBar2;
		private Label label4;
		private TrackBar trackBar3;
		private CheckBox checkBox2;
		private Label label5;
		private TrackBar trackBar4;
		private Button button1;
		private Button button2;
		private ColorDialog colorDialog1;
		private Panel panel1;
		private CheckBox checkBox3;
		private Button button3;
		private Button button4;
		private CheckBox checkBox4;
	}
}