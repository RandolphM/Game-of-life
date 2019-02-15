namespace Project_and_Potfolio1
{
    partial class options_Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.Height_updown = new System.Windows.Forms.NumericUpDown();
            this.height_lable = new System.Windows.Forms.Label();
            this.width_updown = new System.Windows.Forms.NumericUpDown();
            this.width_label = new System.Windows.Forms.Label();
            this.time_updown = new System.Windows.Forms.NumericUpDown();
            this.Tiime_opt_lable = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_color_btn = new System.Windows.Forms.Button();
            this.nondefault_radioButton1 = new System.Windows.Forms.RadioButton();
            this.red_radioButton = new System.Windows.Forms.RadioButton();
            this.Silver_radioButton = new System.Windows.Forms.RadioButton();
            this.Cyan_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cell_color_btn = new System.Windows.Forms.Button();
            this.nondefault_radioButton = new System.Windows.Forms.RadioButton();
            this.Gold_radioButton = new System.Windows.Forms.RadioButton();
            this.green_radioButton = new System.Windows.Forms.RadioButton();
            this.yellow_radioButton = new System.Windows.Forms.RadioButton();
            this.Advance_tab = new System.Windows.Forms.TabPage();
            this.bounderies_gb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Finite_rbtn = new System.Windows.Forms.RadioButton();
            this.toroidal_rbtn = new System.Windows.Forms.RadioButton();
            this.ok_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Height_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_updown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Advance_tab.SuspendLayout();
            this.bounderies_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GeneralPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Advance_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Controls.Add(this.Height_updown);
            this.GeneralPage.Controls.Add(this.height_lable);
            this.GeneralPage.Controls.Add(this.width_updown);
            this.GeneralPage.Controls.Add(this.width_label);
            this.GeneralPage.Controls.Add(this.time_updown);
            this.GeneralPage.Controls.Add(this.Tiime_opt_lable);
            this.GeneralPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralPage.Size = new System.Drawing.Size(342, 255);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "General";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // Height_updown
            // 
            this.Height_updown.Location = new System.Drawing.Point(108, 87);
            this.Height_updown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Height_updown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Height_updown.Name = "Height_updown";
            this.Height_updown.Size = new System.Drawing.Size(58, 20);
            this.Height_updown.TabIndex = 5;
            this.Height_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // height_lable
            // 
            this.height_lable.AutoSize = true;
            this.height_lable.Location = new System.Drawing.Point(9, 89);
            this.height_lable.Name = "height_lable";
            this.height_lable.Size = new System.Drawing.Size(93, 13);
            this.height_lable.TabIndex = 4;
            this.height_lable.Text = "Height for the Grid";
            // 
            // width_updown
            // 
            this.width_updown.Location = new System.Drawing.Point(105, 56);
            this.width_updown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.width_updown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width_updown.Name = "width_updown";
            this.width_updown.Size = new System.Drawing.Size(61, 20);
            this.width_updown.TabIndex = 3;
            this.width_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Location = new System.Drawing.Point(9, 58);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(87, 13);
            this.width_label.TabIndex = 2;
            this.width_label.Text = "Width of the Grid";
            // 
            // time_updown
            // 
            this.time_updown.Location = new System.Drawing.Point(173, 22);
            this.time_updown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.time_updown.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.time_updown.Name = "time_updown";
            this.time_updown.Size = new System.Drawing.Size(58, 20);
            this.time_updown.TabIndex = 1;
            this.time_updown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // Tiime_opt_lable
            // 
            this.Tiime_opt_lable.AutoSize = true;
            this.Tiime_opt_lable.Location = new System.Drawing.Point(9, 22);
            this.Tiime_opt_lable.Name = "Tiime_opt_lable";
            this.Tiime_opt_lable.Size = new System.Drawing.Size(157, 13);
            this.Tiime_opt_lable.TabIndex = 0;
            this.Tiime_opt_lable.Text = "Time for Timer ( in Milliseconds )";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_color_btn);
            this.groupBox2.Controls.Add(this.nondefault_radioButton1);
            this.groupBox2.Controls.Add(this.red_radioButton);
            this.groupBox2.Controls.Add(this.Silver_radioButton);
            this.groupBox2.Controls.Add(this.Cyan_radioButton);
            this.groupBox2.Location = new System.Drawing.Point(162, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid color";
            // 
            // grid_color_btn
            // 
            this.grid_color_btn.BackColor = System.Drawing.Color.Black;
            this.grid_color_btn.Enabled = false;
            this.grid_color_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grid_color_btn.Location = new System.Drawing.Point(84, 91);
            this.grid_color_btn.Name = "grid_color_btn";
            this.grid_color_btn.Size = new System.Drawing.Size(38, 23);
            this.grid_color_btn.TabIndex = 2;
            this.grid_color_btn.UseVisualStyleBackColor = false;
            this.grid_color_btn.Click += new System.EventHandler(this.grid_color_btn_Click);
            // 
            // nondefault_radioButton1
            // 
            this.nondefault_radioButton1.AutoSize = true;
            this.nondefault_radioButton1.Location = new System.Drawing.Point(7, 91);
            this.nondefault_radioButton1.Name = "nondefault_radioButton1";
            this.nondefault_radioButton1.Size = new System.Drawing.Size(71, 17);
            this.nondefault_radioButton1.TabIndex = 6;
            this.nondefault_radioButton1.Text = "new color";
            this.nondefault_radioButton1.UseVisualStyleBackColor = true;
            this.nondefault_radioButton1.CheckedChanged += new System.EventHandler(this.nondefault_radioButton1_CheckedChanged);
            // 
            // red_radioButton
            // 
            this.red_radioButton.AutoSize = true;
            this.red_radioButton.Checked = true;
            this.red_radioButton.Location = new System.Drawing.Point(7, 20);
            this.red_radioButton.Name = "red_radioButton";
            this.red_radioButton.Size = new System.Drawing.Size(45, 17);
            this.red_radioButton.TabIndex = 0;
            this.red_radioButton.TabStop = true;
            this.red_radioButton.Text = "Red";
            this.red_radioButton.UseVisualStyleBackColor = true;
            // 
            // Silver_radioButton
            // 
            this.Silver_radioButton.AutoSize = true;
            this.Silver_radioButton.Location = new System.Drawing.Point(7, 67);
            this.Silver_radioButton.Name = "Silver_radioButton";
            this.Silver_radioButton.Size = new System.Drawing.Size(51, 17);
            this.Silver_radioButton.TabIndex = 5;
            this.Silver_radioButton.Text = "Silver";
            this.Silver_radioButton.UseVisualStyleBackColor = true;
            // 
            // Cyan_radioButton
            // 
            this.Cyan_radioButton.AutoSize = true;
            this.Cyan_radioButton.Location = new System.Drawing.Point(7, 43);
            this.Cyan_radioButton.Name = "Cyan_radioButton";
            this.Cyan_radioButton.Size = new System.Drawing.Size(49, 17);
            this.Cyan_radioButton.TabIndex = 4;
            this.Cyan_radioButton.Text = "Cyan";
            this.Cyan_radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cell_color_btn);
            this.groupBox1.Controls.Add(this.nondefault_radioButton);
            this.groupBox1.Controls.Add(this.Gold_radioButton);
            this.groupBox1.Controls.Add(this.green_radioButton);
            this.groupBox1.Controls.Add(this.yellow_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cell Color";
            // 
            // cell_color_btn
            // 
            this.cell_color_btn.BackColor = System.Drawing.Color.Blue;
            this.cell_color_btn.Enabled = false;
            this.cell_color_btn.Location = new System.Drawing.Point(82, 91);
            this.cell_color_btn.Name = "cell_color_btn";
            this.cell_color_btn.Size = new System.Drawing.Size(38, 23);
            this.cell_color_btn.TabIndex = 1;
            this.cell_color_btn.UseVisualStyleBackColor = false;
            this.cell_color_btn.Click += new System.EventHandler(this.cell_color_btn_Click);
            // 
            // nondefault_radioButton
            // 
            this.nondefault_radioButton.AutoSize = true;
            this.nondefault_radioButton.Location = new System.Drawing.Point(7, 91);
            this.nondefault_radioButton.Name = "nondefault_radioButton";
            this.nondefault_radioButton.Size = new System.Drawing.Size(71, 17);
            this.nondefault_radioButton.TabIndex = 3;
            this.nondefault_radioButton.Text = "new color";
            this.nondefault_radioButton.UseVisualStyleBackColor = true;
            this.nondefault_radioButton.CheckedChanged += new System.EventHandler(this.nondefault_radioButton_CheckedChanged);
            // 
            // Gold_radioButton
            // 
            this.Gold_radioButton.AutoSize = true;
            this.Gold_radioButton.Location = new System.Drawing.Point(7, 67);
            this.Gold_radioButton.Name = "Gold_radioButton";
            this.Gold_radioButton.Size = new System.Drawing.Size(47, 17);
            this.Gold_radioButton.TabIndex = 2;
            this.Gold_radioButton.Text = "Gold";
            this.Gold_radioButton.UseVisualStyleBackColor = true;
            // 
            // green_radioButton
            // 
            this.green_radioButton.AutoSize = true;
            this.green_radioButton.Location = new System.Drawing.Point(7, 43);
            this.green_radioButton.Name = "green_radioButton";
            this.green_radioButton.Size = new System.Drawing.Size(54, 17);
            this.green_radioButton.TabIndex = 1;
            this.green_radioButton.Text = "Green";
            this.green_radioButton.UseVisualStyleBackColor = true;
            // 
            // yellow_radioButton
            // 
            this.yellow_radioButton.AutoSize = true;
            this.yellow_radioButton.Checked = true;
            this.yellow_radioButton.Location = new System.Drawing.Point(6, 19);
            this.yellow_radioButton.Name = "yellow_radioButton";
            this.yellow_radioButton.Size = new System.Drawing.Size(56, 17);
            this.yellow_radioButton.TabIndex = 0;
            this.yellow_radioButton.TabStop = true;
            this.yellow_radioButton.Text = "Yellow";
            this.yellow_radioButton.UseVisualStyleBackColor = true;
            // 
            // Advance_tab
            // 
            this.Advance_tab.Controls.Add(this.bounderies_gb);
            this.Advance_tab.Location = new System.Drawing.Point(4, 22);
            this.Advance_tab.Name = "Advance_tab";
            this.Advance_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Advance_tab.Size = new System.Drawing.Size(342, 255);
            this.Advance_tab.TabIndex = 2;
            this.Advance_tab.Text = "Advanced";
            this.Advance_tab.UseVisualStyleBackColor = true;
            // 
            // bounderies_gb
            // 
            this.bounderies_gb.Controls.Add(this.label1);
            this.bounderies_gb.Controls.Add(this.Finite_rbtn);
            this.bounderies_gb.Controls.Add(this.toroidal_rbtn);
            this.bounderies_gb.Location = new System.Drawing.Point(9, 15);
            this.bounderies_gb.Name = "bounderies_gb";
            this.bounderies_gb.Size = new System.Drawing.Size(168, 98);
            this.bounderies_gb.TabIndex = 0;
            this.bounderies_gb.TabStop = false;
            this.bounderies_gb.Text = "bounderies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note: whichever one you pick \r\nchanges the boundery of the grid";
            // 
            // Finite_rbtn
            // 
            this.Finite_rbtn.AutoSize = true;
            this.Finite_rbtn.Checked = true;
            this.Finite_rbtn.Location = new System.Drawing.Point(6, 43);
            this.Finite_rbtn.Name = "Finite_rbtn";
            this.Finite_rbtn.Size = new System.Drawing.Size(50, 17);
            this.Finite_rbtn.TabIndex = 1;
            this.Finite_rbtn.TabStop = true;
            this.Finite_rbtn.Text = "Finite";
            this.Finite_rbtn.UseVisualStyleBackColor = true;
            // 
            // toroidal_rbtn
            // 
            this.toroidal_rbtn.AutoSize = true;
            this.toroidal_rbtn.Location = new System.Drawing.Point(7, 20);
            this.toroidal_rbtn.Name = "toroidal_rbtn";
            this.toroidal_rbtn.Size = new System.Drawing.Size(63, 17);
            this.toroidal_rbtn.TabIndex = 0;
            this.toroidal_rbtn.TabStop = true;
            this.toroidal_rbtn.Text = "Toroidal";
            this.toroidal_rbtn.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            this.ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_btn.Location = new System.Drawing.Point(13, 286);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_btn.Location = new System.Drawing.Point(95, 285);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 2;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // options_Form
            // 
            this.AcceptButton = this.ok_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_btn;
            this.ClientSize = new System.Drawing.Size(350, 321);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "options_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options Form";
            this.tabControl1.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Height_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_updown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Advance_tab.ResumeLayout(false);
            this.bounderies_gb.ResumeLayout(false);
            this.bounderies_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label Tiime_opt_lable;
        private System.Windows.Forms.NumericUpDown Height_updown;
        private System.Windows.Forms.Label height_lable;
        private System.Windows.Forms.NumericUpDown width_updown;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.NumericUpDown time_updown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nondefault_radioButton;
        private System.Windows.Forms.RadioButton Gold_radioButton;
        private System.Windows.Forms.RadioButton green_radioButton;
        private System.Windows.Forms.RadioButton yellow_radioButton;
        private System.Windows.Forms.Button cell_color_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button grid_color_btn;
        private System.Windows.Forms.RadioButton nondefault_radioButton1;
        private System.Windows.Forms.RadioButton red_radioButton;
        private System.Windows.Forms.RadioButton Silver_radioButton;
        private System.Windows.Forms.RadioButton Cyan_radioButton;
        private System.Windows.Forms.TabPage Advance_tab;
        private System.Windows.Forms.GroupBox bounderies_gb;
        private System.Windows.Forms.RadioButton Finite_rbtn;
        private System.Windows.Forms.RadioButton toroidal_rbtn;
        private System.Windows.Forms.Label label1;
    }
}