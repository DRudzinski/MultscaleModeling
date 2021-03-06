﻿namespace MultiscaleModeling
{
    partial class mainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rule4_chance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GBC_checkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.int_radius_num_max = new System.Windows.Forms.NumericUpDown();
            this.int_radius_num_min = new System.Windows.Forms.NumericUpDown();
            this.intr_radius_label = new System.Windows.Forms.Label();
            this.intrusion_button = new System.Windows.Forms.Button();
            this.intrusion_num = new System.Windows.Forms.NumericUpDown();
            this.intrusion_label = new System.Windows.Forms.Label();
            this.import_cond_button = new System.Windows.Forms.Button();
            this.export_txt_button = new System.Windows.Forms.Button();
            this.export_jpg_button = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.Animation_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NonP_check = new System.Windows.Forms.RadioButton();
            this.p_check = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hexrand = new System.Windows.Forms.RadioButton();
            this.hexright = new System.Windows.Forms.RadioButton();
            this.hexleft = new System.Windows.Forms.RadioButton();
            this.neuman_check = new System.Windows.Forms.RadioButton();
            this.more_check = new System.Windows.Forms.RadioButton();
            this.matrixpanel = new System.Windows.Forms.Panel();
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.heigh_label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.heigh_txt = new System.Windows.Forms.TextBox();
            this.bcond_label = new System.Windows.Forms.Label();
            this.neigh_label = new System.Windows.Forms.Label();
            this.nexts_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.seed_num = new System.Windows.Forms.NumericUpDown();
            this.seed_button = new System.Windows.Forms.Button();
            this.seed_label = new System.Windows.Forms.Label();
            this.size_button = new System.Windows.Forms.Button();
            this.size_label = new System.Windows.Forms.Label();
            this.width_txt = new System.Windows.Forms.TextBox();
            this.SecondPhase = new System.Windows.Forms.Button();
            this.SecGrainGrowthPanel = new System.Windows.Forms.Panel();
            this.ShowPhase = new System.Windows.Forms.CheckBox();
            this.NextPhaseBut = new System.Windows.Forms.Button();
            this.Clearlist = new System.Windows.Forms.Button();
            this.DelGrains = new System.Windows.Forms.Button();
            this.GrainToDelete = new System.Windows.Forms.ListBox();
            this.MathPanelButt = new System.Windows.Forms.Button();
            this.MathPanel = new System.Windows.Forms.Panel();
            this.ShowBoundCheck = new System.Windows.Forms.CheckBox();
            this.CalcSizeButt = new System.Windows.Forms.Button();
            this.AVGvalueBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rule4_chance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_radius_num_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_radius_num_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrusion_num)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.matrixpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_num)).BeginInit();
            this.SecGrainGrowthPanel.SuspendLayout();
            this.MathPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.rule4_chance);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.GBC_checkbox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.int_radius_num_max);
            this.mainPanel.Controls.Add(this.int_radius_num_min);
            this.mainPanel.Controls.Add(this.intr_radius_label);
            this.mainPanel.Controls.Add(this.intrusion_button);
            this.mainPanel.Controls.Add(this.intrusion_num);
            this.mainPanel.Controls.Add(this.intrusion_label);
            this.mainPanel.Controls.Add(this.import_cond_button);
            this.mainPanel.Controls.Add(this.export_txt_button);
            this.mainPanel.Controls.Add(this.export_jpg_button);
            this.mainPanel.Controls.Add(this.import_button);
            this.mainPanel.Controls.Add(this.Animation_button);
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.matrixpanel);
            this.mainPanel.Controls.Add(this.heigh_label);
            this.mainPanel.Controls.Add(this.width_label);
            this.mainPanel.Controls.Add(this.heigh_txt);
            this.mainPanel.Controls.Add(this.bcond_label);
            this.mainPanel.Controls.Add(this.neigh_label);
            this.mainPanel.Controls.Add(this.nexts_button);
            this.mainPanel.Controls.Add(this.reset_button);
            this.mainPanel.Controls.Add(this.pause_button);
            this.mainPanel.Controls.Add(this.start_button);
            this.mainPanel.Controls.Add(this.seed_num);
            this.mainPanel.Controls.Add(this.seed_button);
            this.mainPanel.Controls.Add(this.seed_label);
            this.mainPanel.Controls.Add(this.size_button);
            this.mainPanel.Controls.Add(this.size_label);
            this.mainPanel.Controls.Add(this.width_txt);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(980, 650);
            this.mainPanel.TabIndex = 0;
            // 
            // rule4_chance
            // 
            this.rule4_chance.Location = new System.Drawing.Point(842, 128);
            this.rule4_chance.Name = "rule4_chance";
            this.rule4_chance.Size = new System.Drawing.Size(52, 20);
            this.rule4_chance.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(743, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Rule 4 chance:";
            // 
            // GBC_checkbox
            // 
            this.GBC_checkbox.AutoSize = true;
            this.GBC_checkbox.Location = new System.Drawing.Point(666, 131);
            this.GBC_checkbox.Name = "GBC_checkbox";
            this.GBC_checkbox.Size = new System.Drawing.Size(48, 17);
            this.GBC_checkbox.TabIndex = 35;
            this.GBC_checkbox.Text = "GBC";
            this.GBC_checkbox.UseVisualStyleBackColor = true;
            this.GBC_checkbox.CheckedChanged += new System.EventHandler(this.GBC_checkbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(135, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "-";
            // 
            // int_radius_num_max
            // 
            this.int_radius_num_max.Location = new System.Drawing.Point(148, 160);
            this.int_radius_num_max.Name = "int_radius_num_max";
            this.int_radius_num_max.Size = new System.Drawing.Size(72, 20);
            this.int_radius_num_max.TabIndex = 33;
            // 
            // int_radius_num_min
            // 
            this.int_radius_num_min.Location = new System.Drawing.Point(60, 160);
            this.int_radius_num_min.Name = "int_radius_num_min";
            this.int_radius_num_min.Size = new System.Drawing.Size(72, 20);
            this.int_radius_num_min.TabIndex = 32;
            // 
            // intr_radius_label
            // 
            this.intr_radius_label.AutoSize = true;
            this.intr_radius_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.intr_radius_label.Location = new System.Drawing.Point(4, 160);
            this.intr_radius_label.Name = "intr_radius_label";
            this.intr_radius_label.Size = new System.Drawing.Size(52, 18);
            this.intr_radius_label.TabIndex = 31;
            this.intr_radius_label.Text = "radius:";
            // 
            // intrusion_button
            // 
            this.intrusion_button.Location = new System.Drawing.Point(294, 130);
            this.intrusion_button.Name = "intrusion_button";
            this.intrusion_button.Size = new System.Drawing.Size(75, 23);
            this.intrusion_button.TabIndex = 30;
            this.intrusion_button.Text = "OK";
            this.intrusion_button.UseVisualStyleBackColor = true;
            this.intrusion_button.Click += new System.EventHandler(this.intrusion_button_Click);
            // 
            // intrusion_num
            // 
            this.intrusion_num.Location = new System.Drawing.Point(198, 130);
            this.intrusion_num.Name = "intrusion_num";
            this.intrusion_num.Size = new System.Drawing.Size(72, 20);
            this.intrusion_num.TabIndex = 29;
            // 
            // intrusion_label
            // 
            this.intrusion_label.AutoSize = true;
            this.intrusion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.intrusion_label.Location = new System.Drawing.Point(3, 128);
            this.intrusion_label.Name = "intrusion_label";
            this.intrusion_label.Size = new System.Drawing.Size(193, 24);
            this.intrusion_label.TabIndex = 28;
            this.intrusion_label.Text = "Set inclusion number:";
            // 
            // import_cond_button
            // 
            this.import_cond_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.import_cond_button.Location = new System.Drawing.Point(7, 203);
            this.import_cond_button.Name = "import_cond_button";
            this.import_cond_button.Size = new System.Drawing.Size(135, 30);
            this.import_cond_button.TabIndex = 27;
            this.import_cond_button.Text = "Set conditions";
            this.import_cond_button.UseVisualStyleBackColor = true;
            this.import_cond_button.Click += new System.EventHandler(this.import_cond_button_Click);
            // 
            // export_txt_button
            // 
            this.export_txt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.export_txt_button.Location = new System.Drawing.Point(193, 0);
            this.export_txt_button.Name = "export_txt_button";
            this.export_txt_button.Size = new System.Drawing.Size(95, 27);
            this.export_txt_button.TabIndex = 26;
            this.export_txt_button.Text = "export to txt";
            this.export_txt_button.UseVisualStyleBackColor = true;
            this.export_txt_button.Click += new System.EventHandler(this.export_txt_button_Click);
            // 
            // export_jpg_button
            // 
            this.export_jpg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.export_jpg_button.Location = new System.Drawing.Point(92, 0);
            this.export_jpg_button.Name = "export_jpg_button";
            this.export_jpg_button.Size = new System.Drawing.Size(102, 27);
            this.export_jpg_button.TabIndex = 25;
            this.export_jpg_button.Text = "export to jpg";
            this.export_jpg_button.UseVisualStyleBackColor = true;
            this.export_jpg_button.Click += new System.EventHandler(this.export_jpg_button_Click);
            // 
            // import_button
            // 
            this.import_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.import_button.Location = new System.Drawing.Point(0, 0);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(95, 27);
            this.import_button.TabIndex = 24;
            this.import_button.Text = "Import data";
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            // 
            // Animation_button
            // 
            this.Animation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Animation_button.Location = new System.Drawing.Point(342, 170);
            this.Animation_button.Name = "Animation_button";
            this.Animation_button.Size = new System.Drawing.Size(135, 63);
            this.Animation_button.TabIndex = 23;
            this.Animation_button.Text = "Start";
            this.Animation_button.UseVisualStyleBackColor = true;
            this.Animation_button.Click += new System.EventHandler(this.Animation_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NonP_check);
            this.groupBox2.Controls.Add(this.p_check);
            this.groupBox2.Location = new System.Drawing.Point(666, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // NonP_check
            // 
            this.NonP_check.AutoSize = true;
            this.NonP_check.Location = new System.Drawing.Point(20, 42);
            this.NonP_check.Name = "NonP_check";
            this.NonP_check.Size = new System.Drawing.Size(86, 17);
            this.NonP_check.TabIndex = 3;
            this.NonP_check.TabStop = true;
            this.NonP_check.Text = "Non Periodic";
            this.NonP_check.UseVisualStyleBackColor = true;
            // 
            // p_check
            // 
            this.p_check.AutoSize = true;
            this.p_check.Checked = true;
            this.p_check.Location = new System.Drawing.Point(20, 19);
            this.p_check.Name = "p_check";
            this.p_check.Size = new System.Drawing.Size(63, 17);
            this.p_check.TabIndex = 2;
            this.p_check.TabStop = true;
            this.p_check.Text = "Periodic";
            this.p_check.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hexrand);
            this.groupBox1.Controls.Add(this.hexright);
            this.groupBox1.Controls.Add(this.hexleft);
            this.groupBox1.Controls.Add(this.neuman_check);
            this.groupBox1.Controls.Add(this.more_check);
            this.groupBox1.Location = new System.Drawing.Point(397, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // hexrand
            // 
            this.hexrand.AutoSize = true;
            this.hexrand.Location = new System.Drawing.Point(0, 101);
            this.hexrand.Name = "hexrand";
            this.hexrand.Size = new System.Drawing.Size(112, 17);
            this.hexrand.TabIndex = 4;
            this.hexrand.TabStop = true;
            this.hexrand.Text = "hexagonal random";
            this.hexrand.UseVisualStyleBackColor = true;
            // 
            // hexright
            // 
            this.hexright.AutoSize = true;
            this.hexright.Location = new System.Drawing.Point(0, 78);
            this.hexright.Name = "hexright";
            this.hexright.Size = new System.Drawing.Size(97, 17);
            this.hexright.TabIndex = 3;
            this.hexright.TabStop = true;
            this.hexright.Text = "hexagonal right";
            this.hexright.UseVisualStyleBackColor = true;
            // 
            // hexleft
            // 
            this.hexleft.AutoSize = true;
            this.hexleft.Location = new System.Drawing.Point(0, 55);
            this.hexleft.Name = "hexleft";
            this.hexleft.Size = new System.Drawing.Size(91, 17);
            this.hexleft.TabIndex = 2;
            this.hexleft.TabStop = true;
            this.hexleft.Text = "hexagonal left";
            this.hexleft.UseVisualStyleBackColor = true;
            // 
            // neuman_check
            // 
            this.neuman_check.AutoSize = true;
            this.neuman_check.Location = new System.Drawing.Point(0, 32);
            this.neuman_check.Name = "neuman_check";
            this.neuman_check.Size = new System.Drawing.Size(88, 17);
            this.neuman_check.TabIndex = 1;
            this.neuman_check.TabStop = true;
            this.neuman_check.Text = "Von Meuman";
            this.neuman_check.UseVisualStyleBackColor = true;
            // 
            // more_check
            // 
            this.more_check.AutoSize = true;
            this.more_check.Checked = true;
            this.more_check.Location = new System.Drawing.Point(0, 9);
            this.more_check.Name = "more_check";
            this.more_check.Size = new System.Drawing.Size(57, 17);
            this.more_check.TabIndex = 0;
            this.more_check.TabStop = true;
            this.more_check.Text = "Moor\'a";
            this.more_check.UseVisualStyleBackColor = true;
            // 
            // matrixpanel
            // 
            this.matrixpanel.AutoScroll = true;
            this.matrixpanel.Controls.Add(this.pic_box);
            this.matrixpanel.Location = new System.Drawing.Point(2, 240);
            this.matrixpanel.Name = "matrixpanel";
            this.matrixpanel.Size = new System.Drawing.Size(950, 407);
            this.matrixpanel.TabIndex = 21;
            // 
            // pic_box
            // 
            this.pic_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pic_box.Location = new System.Drawing.Point(233, 20);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(537, 350);
            this.pic_box.TabIndex = 0;
            this.pic_box.TabStop = false;
            this.pic_box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_box_MouseUp);
            // 
            // heigh_label
            // 
            this.heigh_label.AutoSize = true;
            this.heigh_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heigh_label.Location = new System.Drawing.Point(231, 32);
            this.heigh_label.Name = "heigh_label";
            this.heigh_label.Size = new System.Drawing.Size(44, 16);
            this.heigh_label.TabIndex = 20;
            this.heigh_label.Text = "height";
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.width_label.Location = new System.Drawing.Point(156, 32);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(38, 16);
            this.width_label.TabIndex = 19;
            this.width_label.Text = "width";
            // 
            // heigh_txt
            // 
            this.heigh_txt.Location = new System.Drawing.Point(216, 51);
            this.heigh_txt.Name = "heigh_txt";
            this.heigh_txt.Size = new System.Drawing.Size(72, 20);
            this.heigh_txt.TabIndex = 18;
            // 
            // bcond_label
            // 
            this.bcond_label.AutoSize = true;
            this.bcond_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bcond_label.Location = new System.Drawing.Point(662, 9);
            this.bcond_label.Name = "bcond_label";
            this.bcond_label.Size = new System.Drawing.Size(294, 24);
            this.bcond_label.TabIndex = 14;
            this.bcond_label.Text = "Select type of boundary condition:";
            // 
            // neigh_label
            // 
            this.neigh_label.AutoSize = true;
            this.neigh_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.neigh_label.Location = new System.Drawing.Point(393, 9);
            this.neigh_label.Name = "neigh_label";
            this.neigh_label.Size = new System.Drawing.Size(263, 24);
            this.neigh_label.TabIndex = 13;
            this.neigh_label.Text = "Select type of neighbourhood:";
            // 
            // nexts_button
            // 
            this.nexts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nexts_button.Location = new System.Drawing.Point(660, 170);
            this.nexts_button.Name = "nexts_button";
            this.nexts_button.Size = new System.Drawing.Size(135, 63);
            this.nexts_button.TabIndex = 10;
            this.nexts_button.Text = "Next Step";
            this.nexts_button.UseVisualStyleBackColor = true;
            this.nexts_button.Click += new System.EventHandler(this.nexts_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset_button.Location = new System.Drawing.Point(817, 171);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(135, 63);
            this.reset_button.TabIndex = 9;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // pause_button
            // 
            this.pause_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pause_button.Location = new System.Drawing.Point(504, 170);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(135, 63);
            this.pause_button.TabIndex = 8;
            this.pause_button.Text = "Pause";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.Location = new System.Drawing.Point(148, 203);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(135, 30);
            this.start_button.TabIndex = 7;
            this.start_button.Text = "Generate";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // seed_num
            // 
            this.seed_num.Location = new System.Drawing.Point(178, 91);
            this.seed_num.Name = "seed_num";
            this.seed_num.Size = new System.Drawing.Size(72, 20);
            this.seed_num.TabIndex = 6;
            // 
            // seed_button
            // 
            this.seed_button.Location = new System.Drawing.Point(294, 92);
            this.seed_button.Name = "seed_button";
            this.seed_button.Size = new System.Drawing.Size(75, 23);
            this.seed_button.TabIndex = 5;
            this.seed_button.Text = "OK";
            this.seed_button.UseVisualStyleBackColor = true;
            this.seed_button.Click += new System.EventHandler(this.seed_button_Click);
            // 
            // seed_label
            // 
            this.seed_label.AutoSize = true;
            this.seed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seed_label.Location = new System.Drawing.Point(3, 88);
            this.seed_label.Name = "seed_label";
            this.seed_label.Size = new System.Drawing.Size(169, 24);
            this.seed_label.TabIndex = 3;
            this.seed_label.Text = "Set seeds number:";
            // 
            // size_button
            // 
            this.size_button.Location = new System.Drawing.Point(294, 51);
            this.size_button.Name = "size_button";
            this.size_button.Size = new System.Drawing.Size(75, 23);
            this.size_button.TabIndex = 2;
            this.size_button.Text = "OK";
            this.size_button.UseVisualStyleBackColor = true;
            this.size_button.Click += new System.EventHandler(this.size_button_Click);
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.size_label.Location = new System.Drawing.Point(3, 48);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(129, 24);
            this.size_label.TabIndex = 1;
            this.size_label.Text = "Set CA space:";
            // 
            // width_txt
            // 
            this.width_txt.Location = new System.Drawing.Point(138, 51);
            this.width_txt.Name = "width_txt";
            this.width_txt.Size = new System.Drawing.Size(72, 20);
            this.width_txt.TabIndex = 0;
            // 
            // SecondPhase
            // 
            this.SecondPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SecondPhase.Location = new System.Drawing.Point(998, 6);
            this.SecondPhase.Name = "SecondPhase";
            this.SecondPhase.Size = new System.Drawing.Size(165, 35);
            this.SecondPhase.TabIndex = 1;
            this.SecondPhase.Text = "Second Grain Growth";
            this.SecondPhase.UseVisualStyleBackColor = true;
            this.SecondPhase.Click += new System.EventHandler(this.SecondPhase_Click);
            // 
            // SecGrainGrowthPanel
            // 
            this.SecGrainGrowthPanel.Controls.Add(this.ShowPhase);
            this.SecGrainGrowthPanel.Controls.Add(this.NextPhaseBut);
            this.SecGrainGrowthPanel.Controls.Add(this.Clearlist);
            this.SecGrainGrowthPanel.Controls.Add(this.DelGrains);
            this.SecGrainGrowthPanel.Controls.Add(this.GrainToDelete);
            this.SecGrainGrowthPanel.Location = new System.Drawing.Point(986, 47);
            this.SecGrainGrowthPanel.Name = "SecGrainGrowthPanel";
            this.SecGrainGrowthPanel.Size = new System.Drawing.Size(186, 186);
            this.SecGrainGrowthPanel.TabIndex = 2;
            // 
            // ShowPhase
            // 
            this.ShowPhase.AutoSize = true;
            this.ShowPhase.Location = new System.Drawing.Point(12, 142);
            this.ShowPhase.Name = "ShowPhase";
            this.ShowPhase.Size = new System.Drawing.Size(133, 17);
            this.ShowPhase.TabIndex = 4;
            this.ShowPhase.Text = "Show pravious phases";
            this.ShowPhase.UseVisualStyleBackColor = true;
            this.ShowPhase.CheckedChanged += new System.EventHandler(this.ShowPhase_CheckedChanged);
            // 
            // NextPhaseBut
            // 
            this.NextPhaseBut.Location = new System.Drawing.Point(12, 94);
            this.NextPhaseBut.Name = "NextPhaseBut";
            this.NextPhaseBut.Size = new System.Drawing.Size(75, 23);
            this.NextPhaseBut.TabIndex = 3;
            this.NextPhaseBut.Text = "Next Phase";
            this.NextPhaseBut.UseVisualStyleBackColor = true;
            this.NextPhaseBut.Click += new System.EventHandler(this.NextPhaseBut_Click);
            // 
            // Clearlist
            // 
            this.Clearlist.Location = new System.Drawing.Point(102, 44);
            this.Clearlist.Name = "Clearlist";
            this.Clearlist.Size = new System.Drawing.Size(75, 23);
            this.Clearlist.TabIndex = 2;
            this.Clearlist.Text = "Clear";
            this.Clearlist.UseVisualStyleBackColor = true;
            this.Clearlist.Click += new System.EventHandler(this.Clearlist_Click);
            // 
            // DelGrains
            // 
            this.DelGrains.Location = new System.Drawing.Point(102, 11);
            this.DelGrains.Name = "DelGrains";
            this.DelGrains.Size = new System.Drawing.Size(75, 23);
            this.DelGrains.TabIndex = 1;
            this.DelGrains.Text = "Delete";
            this.DelGrains.UseVisualStyleBackColor = true;
            this.DelGrains.Click += new System.EventHandler(this.DelGrains_Click);
            // 
            // GrainToDelete
            // 
            this.GrainToDelete.FormattingEnabled = true;
            this.GrainToDelete.Location = new System.Drawing.Point(12, 10);
            this.GrainToDelete.Name = "GrainToDelete";
            this.GrainToDelete.Size = new System.Drawing.Size(86, 56);
            this.GrainToDelete.TabIndex = 0;
            // 
            // MathPanelButt
            // 
            this.MathPanelButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MathPanelButt.Location = new System.Drawing.Point(998, 260);
            this.MathPanelButt.Name = "MathPanelButt";
            this.MathPanelButt.Size = new System.Drawing.Size(165, 35);
            this.MathPanelButt.TabIndex = 4;
            this.MathPanelButt.Text = "Math Panel";
            this.MathPanelButt.UseVisualStyleBackColor = true;
            this.MathPanelButt.Click += new System.EventHandler(this.MathPanelButt_Click);
            // 
            // MathPanel
            // 
            this.MathPanel.Controls.Add(this.AVGvalueBox);
            this.MathPanel.Controls.Add(this.CalcSizeButt);
            this.MathPanel.Controls.Add(this.ShowBoundCheck);
            this.MathPanel.Location = new System.Drawing.Point(986, 317);
            this.MathPanel.Name = "MathPanel";
            this.MathPanel.Size = new System.Drawing.Size(186, 123);
            this.MathPanel.TabIndex = 5;
            // 
            // ShowBoundCheck
            // 
            this.ShowBoundCheck.AutoSize = true;
            this.ShowBoundCheck.Location = new System.Drawing.Point(12, 18);
            this.ShowBoundCheck.Name = "ShowBoundCheck";
            this.ShowBoundCheck.Size = new System.Drawing.Size(100, 17);
            this.ShowBoundCheck.TabIndex = 0;
            this.ShowBoundCheck.Text = "Show boundary";
            this.ShowBoundCheck.UseVisualStyleBackColor = true;
            this.ShowBoundCheck.CheckedChanged += new System.EventHandler(this.ShowBoundCheck_CheckedChanged);
            // 
            // CalcSizeButt
            // 
            this.CalcSizeButt.Location = new System.Drawing.Point(58, 55);
            this.CalcSizeButt.Name = "CalcSizeButt";
            this.CalcSizeButt.Size = new System.Drawing.Size(75, 23);
            this.CalcSizeButt.TabIndex = 1;
            this.CalcSizeButt.Text = "AVG size";
            this.CalcSizeButt.UseVisualStyleBackColor = true;
            this.CalcSizeButt.Click += new System.EventHandler(this.CalcSizeButt_Click);
            // 
            // AVGvalueBox
            // 
            this.AVGvalueBox.Location = new System.Drawing.Point(45, 84);
            this.AVGvalueBox.Name = "AVGvalueBox";
            this.AVGvalueBox.Size = new System.Drawing.Size(100, 20);
            this.AVGvalueBox.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.MathPanel);
            this.Controls.Add(this.MathPanelButt);
            this.Controls.Add(this.SecGrainGrowthPanel);
            this.Controls.Add(this.SecondPhase);
            this.Controls.Add(this.mainPanel);
            this.Name = "mainForm";
            this.Text = "MultiscaleModeling Damian Rudziński";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rule4_chance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_radius_num_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_radius_num_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrusion_num)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.matrixpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed_num)).EndInit();
            this.SecGrainGrowthPanel.ResumeLayout(false);
            this.SecGrainGrowthPanel.PerformLayout();
            this.MathPanel.ResumeLayout(false);
            this.MathPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox width_txt;
        private System.Windows.Forms.NumericUpDown seed_num;
        private System.Windows.Forms.Button seed_button;
        private System.Windows.Forms.Label seed_label;
        private System.Windows.Forms.Button size_button;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Button nexts_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label bcond_label;
        private System.Windows.Forms.Label neigh_label;
        private System.Windows.Forms.Label heigh_label;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.TextBox heigh_txt;
        private System.Windows.Forms.Panel matrixpanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NonP_check;
        private System.Windows.Forms.RadioButton p_check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton neuman_check;
        private System.Windows.Forms.RadioButton more_check;
        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Button Animation_button;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button export_txt_button;
        private System.Windows.Forms.Button export_jpg_button;
        private System.Windows.Forms.Button import_cond_button;
        private System.Windows.Forms.RadioButton hexright;
        private System.Windows.Forms.RadioButton hexleft;
        private System.Windows.Forms.RadioButton hexrand;
        private System.Windows.Forms.Button intrusion_button;
        private System.Windows.Forms.NumericUpDown intrusion_num;
        private System.Windows.Forms.Label intrusion_label;
        private System.Windows.Forms.NumericUpDown int_radius_num_min;
        private System.Windows.Forms.Label intr_radius_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown int_radius_num_max;
        private System.Windows.Forms.CheckBox GBC_checkbox;
        private System.Windows.Forms.NumericUpDown rule4_chance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SecondPhase;
        private System.Windows.Forms.Panel SecGrainGrowthPanel;
        private System.Windows.Forms.Button DelGrains;
        private System.Windows.Forms.ListBox GrainToDelete;
        private System.Windows.Forms.Button Clearlist;
        private System.Windows.Forms.Button NextPhaseBut;
        private System.Windows.Forms.CheckBox ShowPhase;
        private System.Windows.Forms.Button MathPanelButt;
        private System.Windows.Forms.Panel MathPanel;
        private System.Windows.Forms.TextBox AVGvalueBox;
        private System.Windows.Forms.Button CalcSizeButt;
        private System.Windows.Forms.CheckBox ShowBoundCheck;
    }
}

