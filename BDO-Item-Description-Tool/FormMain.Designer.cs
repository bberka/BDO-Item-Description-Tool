namespace BDO_Item_Description_Tool
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.ValueRed = new System.Windows.Forms.NumericUpDown();
            this.ValueGreen = new System.Windows.Forms.NumericUpDown();
            this.ValueBlue = new System.Windows.Forms.NumericUpDown();
            this.panelColorView = new System.Windows.Forms.Panel();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.buttonLoadColorValue = new System.Windows.Forms.Button();
            this.textBoxColorValue = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonPurple = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRed
            // 
            this.trackBarRed.LargeChange = 1;
            this.trackBarRed.Location = new System.Drawing.Point(85, 12);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(183, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.LargeChange = 1;
            this.trackBarGreen.Location = new System.Drawing.Point(85, 63);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(183, 45);
            this.trackBarGreen.TabIndex = 1;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.LargeChange = 1;
            this.trackBarBlue.Location = new System.Drawing.Point(85, 114);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(183, 45);
            this.trackBarBlue.TabIndex = 2;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // ValueRed
            // 
            this.ValueRed.Location = new System.Drawing.Point(284, 12);
            this.ValueRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ValueRed.Name = "ValueRed";
            this.ValueRed.Size = new System.Drawing.Size(76, 23);
            this.ValueRed.TabIndex = 3;
            // 
            // ValueGreen
            // 
            this.ValueGreen.Location = new System.Drawing.Point(284, 63);
            this.ValueGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ValueGreen.Name = "ValueGreen";
            this.ValueGreen.Size = new System.Drawing.Size(76, 23);
            this.ValueGreen.TabIndex = 4;
            // 
            // ValueBlue
            // 
            this.ValueBlue.Location = new System.Drawing.Point(284, 114);
            this.ValueBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ValueBlue.Name = "ValueBlue";
            this.ValueBlue.Size = new System.Drawing.Size(76, 23);
            this.ValueBlue.TabIndex = 5;
            // 
            // panelColorView
            // 
            this.panelColorView.BackColor = System.Drawing.Color.Black;
            this.panelColorView.Enabled = false;
            this.panelColorView.Location = new System.Drawing.Point(376, 12);
            this.panelColorView.Name = "panelColorView";
            this.panelColorView.Size = new System.Drawing.Size(115, 125);
            this.panelColorView.TabIndex = 3;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRed.ForeColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(12, 12);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(46, 23);
            this.labelRed.TabIndex = 6;
            this.labelRed.Text = "Red";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGreen.ForeColor = System.Drawing.Color.Green;
            this.labelGreen.Location = new System.Drawing.Point(12, 63);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(67, 23);
            this.labelGreen.TabIndex = 6;
            this.labelGreen.Text = "Green";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBlue.ForeColor = System.Drawing.Color.Blue;
            this.labelBlue.Location = new System.Drawing.Point(12, 114);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(49, 23);
            this.labelBlue.TabIndex = 6;
            this.labelBlue.Text = "Blue";
            // 
            // buttonLoadColorValue
            // 
            this.buttonLoadColorValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadColorValue.BackColor = System.Drawing.Color.DarkGray;
            this.buttonLoadColorValue.FlatAppearance.BorderSize = 0;
            this.buttonLoadColorValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadColorValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoadColorValue.Location = new System.Drawing.Point(376, 152);
            this.buttonLoadColorValue.Name = "buttonLoadColorValue";
            this.buttonLoadColorValue.Size = new System.Drawing.Size(115, 36);
            this.buttonLoadColorValue.TabIndex = 7;
            this.buttonLoadColorValue.Text = "Colorize";
            this.buttonLoadColorValue.UseVisualStyleBackColor = false;
            this.buttonLoadColorValue.Click += new System.EventHandler(this.buttonLoadColorValue_Click);
            // 
            // textBoxColorValue
            // 
            this.textBoxColorValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxColorValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxColorValue.Location = new System.Drawing.Point(12, 204);
            this.textBoxColorValue.Name = "textBoxColorValue";
            this.textBoxColorValue.Size = new System.Drawing.Size(479, 337);
            this.textBoxColorValue.TabIndex = 9;
            this.textBoxColorValue.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(524, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(506, 503);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(524, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // buttonYellow
            // 
            this.buttonYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonYellow.BackColor = System.Drawing.Color.DarkGray;
            this.buttonYellow.FlatAppearance.BorderSize = 0;
            this.buttonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYellow.Location = new System.Drawing.Point(12, 152);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(49, 36);
            this.buttonYellow.TabIndex = 7;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRed.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRed.FlatAppearance.BorderSize = 0;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Location = new System.Drawing.Point(67, 152);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(49, 36);
            this.buttonRed.TabIndex = 7;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGreen.BackColor = System.Drawing.Color.DarkGray;
            this.buttonGreen.FlatAppearance.BorderSize = 0;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGreen.Location = new System.Drawing.Point(122, 152);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(49, 36);
            this.buttonGreen.TabIndex = 7;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBlue.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBlue.FlatAppearance.BorderSize = 0;
            this.buttonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlue.Location = new System.Drawing.Point(177, 152);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(49, 36);
            this.buttonBlue.TabIndex = 7;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonPurple
            // 
            this.buttonPurple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPurple.BackColor = System.Drawing.Color.DarkGray;
            this.buttonPurple.FlatAppearance.BorderSize = 0;
            this.buttonPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurple.Location = new System.Drawing.Point(232, 152);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(49, 36);
            this.buttonPurple.TabIndex = 7;
            this.buttonPurple.UseVisualStyleBackColor = false;
            this.buttonPurple.Click += new System.EventHandler(this.buttonPurple_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1042, 553);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxColorValue);
            this.Controls.Add(this.buttonPurple);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonLoadColorValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.panelColorView);
            this.Controls.Add(this.ValueBlue);
            this.Controls.Add(this.ValueGreen);
            this.Controls.Add(this.ValueRed);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "BDO Item Description Tool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private NumericUpDown ValueRed;
        private NumericUpDown ValueGreen;
        private NumericUpDown ValueBlue;
        private Panel panelColorView;
        private Label labelRed;
        private Label labelGreen;
        private Label labelBlue;
        private Button buttonLoadColorValue;
        private RichTextBox textBoxColorValue;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button buttonYellow;
        private Button buttonRed;
        private Button buttonGreen;
        private Button buttonBlue;
        private Button buttonPurple;
    }
}