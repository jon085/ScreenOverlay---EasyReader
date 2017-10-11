namespace ScreenOverlay___EasyReader
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.hScroll_R = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScroll_G = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.hScroll_B = new System.Windows.Forms.HScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hScrollAlpha = new System.Windows.Forms.HScrollBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // hScroll_R
            // 
            this.hScroll_R.Location = new System.Drawing.Point(30, 89);
            this.hScroll_R.Maximum = 255;
            this.hScroll_R.Minimum = 1;
            this.hScroll_R.Name = "hScroll_R";
            this.hScroll_R.Size = new System.Drawing.Size(212, 13);
            this.hScroll_R.TabIndex = 1;
            this.hScroll_R.Value = 1;
            this.hScroll_R.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollMaster);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "G";
            // 
            // hScroll_G
            // 
            this.hScroll_G.Location = new System.Drawing.Point(30, 111);
            this.hScroll_G.Maximum = 255;
            this.hScroll_G.Minimum = 1;
            this.hScroll_G.Name = "hScroll_G";
            this.hScroll_G.Size = new System.Drawing.Size(212, 13);
            this.hScroll_G.TabIndex = 2;
            this.hScroll_G.Value = 1;
            this.hScroll_G.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollMaster);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // hScroll_B
            // 
            this.hScroll_B.Location = new System.Drawing.Point(30, 133);
            this.hScroll_B.Maximum = 255;
            this.hScroll_B.Minimum = 1;
            this.hScroll_B.Name = "hScroll_B";
            this.hScroll_B.Size = new System.Drawing.Size(212, 13);
            this.hScroll_B.TabIndex = 3;
            this.hScroll_B.Value = 1;
            this.hScroll_B.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollMaster);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transparency";
            // 
            // hScrollAlpha
            // 
            this.hScrollAlpha.Location = new System.Drawing.Point(87, 57);
            this.hScrollAlpha.Maximum = 200;
            this.hScrollAlpha.Minimum = 50;
            this.hScrollAlpha.Name = "hScrollAlpha";
            this.hScrollAlpha.Size = new System.Drawing.Size(155, 13);
            this.hScrollAlpha.TabIndex = 0;
            this.hScrollAlpha.Value = 50;
            this.hScrollAlpha.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollMaster);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Presets:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 2);
            this.panel1.TabIndex = 11;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 210);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hScrollAlpha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hScroll_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hScroll_G);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScroll_R);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overlay Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.HScrollBar hScroll_R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.HScrollBar hScroll_G;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.HScrollBar hScroll_B;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.HScrollBar hScrollAlpha;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}