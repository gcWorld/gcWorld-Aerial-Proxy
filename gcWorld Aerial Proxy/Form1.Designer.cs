namespace gcWorld_Aerial_Proxy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.googlebtn = new System.Windows.Forms.RadioButton();
            this.bingbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.googlekey_save = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.googlekey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bingkey_save = new System.Windows.Forms.Button();
            this.bingkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tilenr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // googlebtn
            // 
            this.googlebtn.AutoSize = true;
            this.googlebtn.Checked = true;
            this.googlebtn.Location = new System.Drawing.Point(14, 35);
            this.googlebtn.Margin = new System.Windows.Forms.Padding(2);
            this.googlebtn.Name = "googlebtn";
            this.googlebtn.Size = new System.Drawing.Size(86, 24);
            this.googlebtn.TabIndex = 0;
            this.googlebtn.TabStop = true;
            this.googlebtn.Text = "Google";
            this.googlebtn.UseVisualStyleBackColor = true;
            this.googlebtn.CheckedChanged += new System.EventHandler(this.googlebtn_CheckedChanged);
            // 
            // bingbtn
            // 
            this.bingbtn.AutoSize = true;
            this.bingbtn.Location = new System.Drawing.Point(14, 104);
            this.bingbtn.Margin = new System.Windows.Forms.Padding(2);
            this.bingbtn.Name = "bingbtn";
            this.bingbtn.Size = new System.Drawing.Size(66, 24);
            this.bingbtn.TabIndex = 1;
            this.bingbtn.TabStop = true;
            this.bingbtn.Text = "Bing";
            this.bingbtn.UseVisualStyleBackColor = true;
            this.bingbtn.CheckedChanged += new System.EventHandler(this.bingbtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.googlekey_save);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.googlekey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(223, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(172, 284);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Google Settings";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 244);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(109, 20);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Get Maps Key";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // googlekey_save
            // 
            this.googlekey_save.Location = new System.Drawing.Point(7, 200);
            this.googlekey_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.googlekey_save.Name = "googlekey_save";
            this.googlekey_save.Size = new System.Drawing.Size(156, 40);
            this.googlekey_save.TabIndex = 13;
            this.googlekey_save.Text = "Save Key";
            this.googlekey_save.UseVisualStyleBackColor = true;
            this.googlekey_save.Click += new System.EventHandler(this.googlekey_save_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 104);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 24);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hybrid";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // googlekey
            // 
            this.googlekey.Location = new System.Drawing.Point(7, 165);
            this.googlekey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.googlekey.Name = "googlekey";
            this.googlekey.Size = new System.Drawing.Size(156, 26);
            this.googlekey.TabIndex = 12;
            this.googlekey.TextChanged += new System.EventHandler(this.googlekey_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Google API Key";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 69);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Street";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 34);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Satellite";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.googlebtn);
            this.groupBox2.Controls.Add(this.bingbtn);
            this.groupBox2.Location = new System.Drawing.Point(19, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(188, 246);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pick Image Provider";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(10, 64);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(112, 20);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Licence Terms";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.bingkey_save);
            this.groupBox3.Controls.Add(this.bingkey);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(420, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(172, 284);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bing Settings";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 244);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get Maps Key";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bingkey_save
            // 
            this.bingkey_save.Location = new System.Drawing.Point(10, 200);
            this.bingkey_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bingkey_save.Name = "bingkey_save";
            this.bingkey_save.Size = new System.Drawing.Size(156, 40);
            this.bingkey_save.TabIndex = 9;
            this.bingkey_save.Text = "Save Key";
            this.bingkey_save.UseVisualStyleBackColor = true;
            this.bingkey_save.Click += new System.EventHandler(this.bingkey_save_Click);
            // 
            // bingkey
            // 
            this.bingkey.Location = new System.Drawing.Point(10, 165);
            this.bingkey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bingkey.Name = "bingkey";
            this.bingkey.Size = new System.Drawing.Size(156, 26);
            this.bingkey.TabIndex = 8;
            this.bingkey.TextChanged += new System.EventHandler(this.bingkey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bing Maps Key";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 104);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(79, 24);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Hybrid";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 69);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 24);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Street";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 34);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(91, 24);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Satellite";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tilenr);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(19, 319);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(573, 74);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistics";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiles";
            // 
            // tilenr
            // 
            this.tilenr.AutoSize = true;
            this.tilenr.Location = new System.Drawing.Point(61, 25);
            this.tilenr.Name = "tilenr";
            this.tilenr.Size = new System.Drawing.Size(18, 20);
            this.tilenr.TabIndex = 1;
            this.tilenr.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 404);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "gcWorld Aerial Proxy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton googlebtn;
        private System.Windows.Forms.RadioButton bingbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button bingkey_save;
        private System.Windows.Forms.TextBox bingkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button googlekey_save;
        private System.Windows.Forms.TextBox googlekey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label tilenr;
        private System.Windows.Forms.Label label4;
    }
}

