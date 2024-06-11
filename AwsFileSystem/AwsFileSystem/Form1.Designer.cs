namespace AwsFileSystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.access_txtbox = new System.Windows.Forms.TextBox();
            this.secret_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.server_connect_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.local_back_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.localBrowser = new System.Windows.Forms.WebBrowser();
            this.label6 = new System.Windows.Forms.Label();
            this.local_site_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.server_back_btn = new System.Windows.Forms.Button();
            this.server_next_btn = new System.Windows.Forms.Button();
            this.serverBrowser = new System.Windows.Forms.WebBrowser();
            this.label7 = new System.Windows.Forms.Label();
            this.server_site_txtbox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.region_combobox = new System.Windows.Forms.ComboBox();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.upload_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dowload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acess Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // access_txtbox
            // 
            this.access_txtbox.Location = new System.Drawing.Point(79, 28);
            this.access_txtbox.Name = "access_txtbox";
            this.access_txtbox.Size = new System.Drawing.Size(113, 20);
            this.access_txtbox.TabIndex = 2;
            // 
            // secret_txtbox
            // 
            this.secret_txtbox.Location = new System.Drawing.Point(268, 27);
            this.secret_txtbox.Name = "secret_txtbox";
            this.secret_txtbox.Size = new System.Drawing.Size(113, 20);
            this.secret_txtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secret Key";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Region";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // server_connect_btn
            // 
            this.server_connect_btn.Location = new System.Drawing.Point(567, 26);
            this.server_connect_btn.Name = "server_connect_btn";
            this.server_connect_btn.Size = new System.Drawing.Size(102, 23);
            this.server_connect_btn.TabIndex = 3;
            this.server_connect_btn.Text = "Connect";
            this.server_connect_btn.UseVisualStyleBackColor = true;
            this.server_connect_btn.EnabledChanged += new System.EventHandler(this.server_connect_btn_EnabledChanged);
            this.server_connect_btn.Click += new System.EventHandler(this.server_connect_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.local_back_btn);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.localBrowser);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.local_site_txtbox);
            this.groupBox1.Location = new System.Drawing.Point(0, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // local_back_btn
            // 
            this.local_back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.local_back_btn.Location = new System.Drawing.Point(414, 18);
            this.local_back_btn.Name = "local_back_btn";
            this.local_back_btn.Size = new System.Drawing.Size(20, 20);
            this.local_back_btn.TabIndex = 3;
            this.local_back_btn.Text = "<";
            this.local_back_btn.UseVisualStyleBackColor = true;
            this.local_back_btn.Click += new System.EventHandler(this.local_back_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(440, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // localBrowser
            // 
            this.localBrowser.Location = new System.Drawing.Point(9, 45);
            this.localBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.localBrowser.Name = "localBrowser";
            this.localBrowser.Size = new System.Drawing.Size(451, 250);
            this.localBrowser.TabIndex = 2;
            this.localBrowser.LocationChanged += new System.EventHandler(this.localBrowser_LocationChanged);
            this.localBrowser.TabIndexChanged += new System.EventHandler(this.localBrowser_TabIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Site";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // local_site_txtbox
            // 
            this.local_site_txtbox.Location = new System.Drawing.Point(42, 19);
            this.local_site_txtbox.Name = "local_site_txtbox";
            this.local_site_txtbox.Size = new System.Drawing.Size(366, 20);
            this.local_site_txtbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.server_back_btn);
            this.groupBox2.Controls.Add(this.server_next_btn);
            this.groupBox2.Controls.Add(this.serverBrowser);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.server_site_txtbox);
            this.groupBox2.Location = new System.Drawing.Point(472, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 319);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // server_back_btn
            // 
            this.server_back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_back_btn.Location = new System.Drawing.Point(418, 18);
            this.server_back_btn.Name = "server_back_btn";
            this.server_back_btn.Size = new System.Drawing.Size(20, 20);
            this.server_back_btn.TabIndex = 3;
            this.server_back_btn.Text = "<";
            this.server_back_btn.UseVisualStyleBackColor = true;
            // 
            // server_next_btn
            // 
            this.server_next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_next_btn.Location = new System.Drawing.Point(444, 18);
            this.server_next_btn.Name = "server_next_btn";
            this.server_next_btn.Size = new System.Drawing.Size(20, 20);
            this.server_next_btn.TabIndex = 3;
            this.server_next_btn.Text = ">";
            this.server_next_btn.UseVisualStyleBackColor = true;
            // 
            // serverBrowser
            // 
            this.serverBrowser.Location = new System.Drawing.Point(13, 45);
            this.serverBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.serverBrowser.Name = "serverBrowser";
            this.serverBrowser.Size = new System.Drawing.Size(451, 250);
            this.serverBrowser.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Site";
            // 
            // server_site_txtbox
            // 
            this.server_site_txtbox.Location = new System.Drawing.Point(42, 19);
            this.server_site_txtbox.Name = "server_site_txtbox";
            this.server_site_txtbox.Size = new System.Drawing.Size(370, 20);
            this.server_site_txtbox.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(942, 97);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Server Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // region_combobox
            // 
            this.region_combobox.FormattingEnabled = true;
            this.region_combobox.Items.AddRange(new object[] {
            "AFSouth1",
            "APEast1",
            "APNortheast1",
            "APNortheast2",
            "APSouth1",
            "APSouth2",
            "APSoutheast1",
            "APSoutheast2",
            "APSoutheast3",
            "APSoutheast4"});
            this.region_combobox.Location = new System.Drawing.Point(440, 27);
            this.region_combobox.Name = "region_combobox";
            this.region_combobox.Size = new System.Drawing.Size(121, 21);
            this.region_combobox.TabIndex = 8;
            this.region_combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Location = new System.Drawing.Point(675, 26);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(102, 23);
            this.disconnect_btn.TabIndex = 9;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.EnabledChanged += new System.EventHandler(this.disconnect_btn_EnabledChanged);
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 494);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "File Name";
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(385, 520);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(75, 23);
            this.upload_button.TabIndex = 12;
            this.upload_button.Text = "Upload";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "File Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(535, 494);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(401, 20);
            this.textBox2.TabIndex = 13;
            // 
            // dowload
            // 
            this.dowload.Location = new System.Drawing.Point(855, 520);
            this.dowload.Name = "dowload";
            this.dowload.Size = new System.Drawing.Size(75, 23);
            this.dowload.TabIndex = 14;
            this.dowload.Text = "Dowload";
            this.dowload.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(942, 550);
            this.Controls.Add(this.dowload);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.disconnect_btn);
            this.Controls.Add(this.region_combobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.server_connect_btn);
            this.Controls.Add(this.secret_txtbox);
            this.Controls.Add(this.access_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "AWS Drive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox access_txtbox;
        private System.Windows.Forms.TextBox secret_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button server_connect_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox local_site_txtbox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox server_site_txtbox;
        private System.Windows.Forms.WebBrowser localBrowser;
        private System.Windows.Forms.WebBrowser serverBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button server_next_btn;
        private System.Windows.Forms.Button local_back_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button server_back_btn;
        private System.Windows.Forms.ComboBox region_combobox;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button dowload;
    }
}

