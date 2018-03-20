namespace ExecCommandHelper
{
    partial class Form_main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.label1 = new System.Windows.Forms.Label();
            this.button_exec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_font = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_selline = new System.Windows.Forms.ToolStripMenuItem();
            this.button_exec_dir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_exec_dir = new System.Windows.Forms.TextBox();
            this.textBox_commandLine = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_folder = new System.Windows.Forms.Button();
            this.radioButton_fullpath = new System.Windows.Forms.RadioButton();
            this.button_file = new System.Windows.Forms.Button();
            this.radioButton_relativepath = new System.Windows.Forms.RadioButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.text_command = new System.Windows.Forms.ToolStripTextBox();
            this.button_list = new System.Windows.Forms.ToolStripButton();
            this.button_read_info = new System.Windows.Forms.ToolStripButton();
            this.button_save_info = new System.Windows.Forms.ToolStripButton();
            this.button_delete_info = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button_multiline = new System.Windows.Forms.ToolStripButton();
            this.button_oneline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.comboBox_encoding = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "コマンドライン（実行時に改行をスペースに変換）";
            // 
            // button_exec
            // 
            this.button_exec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_exec.Location = new System.Drawing.Point(19, 368);
            this.button_exec.Name = "button_exec";
            this.button_exec.Size = new System.Drawing.Size(64, 20);
            this.button_exec.TabIndex = 3;
            this.button_exec.Text = "実行";
            this.button_exec.UseVisualStyleBackColor = true;
            this.button_exec.Click += new System.EventHandler(this.button_exec_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "実行ディレクトリ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(729, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_font,
            this.menuitem_selline});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // ToolStripMenuItem_font
            // 
            this.ToolStripMenuItem_font.Name = "ToolStripMenuItem_font";
            this.ToolStripMenuItem_font.Size = new System.Drawing.Size(213, 24);
            this.ToolStripMenuItem_font.Text = "フォント";
            this.ToolStripMenuItem_font.Click += new System.EventHandler(this.ToolStripMenuItem_font_Click);
            // 
            // menuitem_selline
            // 
            this.menuitem_selline.Checked = global::ExecCommandHelper.Properties.Settings.Default.selline;
            this.menuitem_selline.CheckOnClick = true;
            this.menuitem_selline.Name = "menuitem_selline";
            this.menuitem_selline.Size = new System.Drawing.Size(213, 24);
            this.menuitem_selline.Text = "ダブルクリックで行選択";
            // 
            // button_exec_dir
            // 
            this.button_exec_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exec_dir.Location = new System.Drawing.Point(667, 335);
            this.button_exec_dir.Name = "button_exec_dir";
            this.button_exec_dir.Size = new System.Drawing.Size(20, 20);
            this.button_exec_dir.TabIndex = 7;
            this.button_exec_dir.Text = "…";
            this.button_exec_dir.UseVisualStyleBackColor = true;
            this.button_exec_dir.Click += new System.EventHandler(this.button_exec_dir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_exec_dir
            // 
            this.textBox_exec_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_exec_dir.Location = new System.Drawing.Point(111, 336);
            this.textBox_exec_dir.Name = "textBox_exec_dir";
            this.textBox_exec_dir.Size = new System.Drawing.Size(552, 19);
            this.textBox_exec_dir.TabIndex = 5;
            // 
            // textBox_commandLine
            // 
            this.textBox_commandLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_commandLine.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::ExecCommandHelper.Properties.Settings.Default, "font_commadline", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_commandLine.Font = global::ExecCommandHelper.Properties.Settings.Default.font_commadline;
            this.textBox_commandLine.Location = new System.Drawing.Point(18, 89);
            this.textBox_commandLine.Multiline = true;
            this.textBox_commandLine.Name = "textBox_commandLine";
            this.textBox_commandLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_commandLine.Size = new System.Drawing.Size(666, 193);
            this.textBox_commandLine.TabIndex = 1;
            this.textBox_commandLine.DoubleClick += new System.EventHandler(this.textBox_commandLine_DoubleClick);
            this.textBox_commandLine.Enter += new System.EventHandler(this.textBox_commandLine_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button_folder);
            this.groupBox1.Controls.Add(this.radioButton_fullpath);
            this.groupBox1.Controls.Add(this.button_file);
            this.groupBox1.Controls.Add(this.radioButton_relativepath);
            this.groupBox1.Location = new System.Drawing.Point(21, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 43);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "パス入力";
            // 
            // button_folder
            // 
            this.button_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_folder.Location = new System.Drawing.Point(5, 18);
            this.button_folder.Name = "button_folder";
            this.button_folder.Size = new System.Drawing.Size(64, 20);
            this.button_folder.TabIndex = 1;
            this.button_folder.Text = "フォルダ";
            this.button_folder.UseVisualStyleBackColor = true;
            this.button_folder.Click += new System.EventHandler(this.button_folder_Click);
            // 
            // radioButton_fullpath
            // 
            this.radioButton_fullpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_fullpath.AutoSize = true;
            this.radioButton_fullpath.Location = new System.Drawing.Point(216, 20);
            this.radioButton_fullpath.Name = "radioButton_fullpath";
            this.radioButton_fullpath.Size = new System.Drawing.Size(60, 16);
            this.radioButton_fullpath.TabIndex = 4;
            this.radioButton_fullpath.TabStop = true;
            this.radioButton_fullpath.Text = "フルパス";
            this.radioButton_fullpath.UseVisualStyleBackColor = true;
            // 
            // button_file
            // 
            this.button_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_file.Location = new System.Drawing.Point(75, 18);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(64, 20);
            this.button_file.TabIndex = 2;
            this.button_file.Text = "ファイル";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // radioButton_relativepath
            // 
            this.radioButton_relativepath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_relativepath.AutoSize = true;
            this.radioButton_relativepath.Checked = global::ExecCommandHelper.Properties.Settings.Default.relative_path;
            this.radioButton_relativepath.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ExecCommandHelper.Properties.Settings.Default, "relative_path", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton_relativepath.Location = new System.Drawing.Point(144, 20);
            this.radioButton_relativepath.Name = "radioButton_relativepath";
            this.radioButton_relativepath.Size = new System.Drawing.Size(66, 16);
            this.radioButton_relativepath.TabIndex = 3;
            this.radioButton_relativepath.TabStop = true;
            this.radioButton_relativepath.Text = "相対パス";
            this.radioButton_relativepath.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.text_command,
            this.button_list,
            this.button_read_info,
            this.button_save_info,
            this.button_delete_info,
            this.toolStripSeparator1,
            this.button_multiline,
            this.button_oneline,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.comboBox_encoding});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(729, 28);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 25);
            this.toolStripLabel1.Text = "実行設定";
            // 
            // text_command
            // 
            this.text_command.AutoSize = false;
            this.text_command.Name = "text_command";
            this.text_command.Size = new System.Drawing.Size(150, 25);
            // 
            // button_list
            // 
            this.button_list.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_list.Image = ((System.Drawing.Image)(resources.GetObject("button_list.Image")));
            this.button_list.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(24, 25);
            this.button_list.Text = "…";
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_read_info
            // 
            this.button_read_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_read_info.Image = ((System.Drawing.Image)(resources.GetObject("button_read_info.Image")));
            this.button_read_info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_read_info.Name = "button_read_info";
            this.button_read_info.Size = new System.Drawing.Size(43, 25);
            this.button_read_info.Text = "読込";
            this.button_read_info.Click += new System.EventHandler(this.button_read_info_Click);
            // 
            // button_save_info
            // 
            this.button_save_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_save_info.Image = ((System.Drawing.Image)(resources.GetObject("button_save_info.Image")));
            this.button_save_info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_save_info.Name = "button_save_info";
            this.button_save_info.Size = new System.Drawing.Size(43, 25);
            this.button_save_info.Text = "保存";
            this.button_save_info.Click += new System.EventHandler(this.button_save_info_Click);
            // 
            // button_delete_info
            // 
            this.button_delete_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_delete_info.Image = ((System.Drawing.Image)(resources.GetObject("button_delete_info.Image")));
            this.button_delete_info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_delete_info.Name = "button_delete_info";
            this.button_delete_info.Size = new System.Drawing.Size(43, 25);
            this.button_delete_info.Text = "削除";
            this.button_delete_info.Click += new System.EventHandler(this.button_delete_info_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // button_multiline
            // 
            this.button_multiline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_multiline.Image = ((System.Drawing.Image)(resources.GetObject("button_multiline.Image")));
            this.button_multiline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_multiline.Name = "button_multiline";
            this.button_multiline.Size = new System.Drawing.Size(43, 25);
            this.button_multiline.Text = "改行";
            this.button_multiline.Click += new System.EventHandler(this.button_multiline_Click);
            // 
            // button_oneline
            // 
            this.button_oneline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_oneline.Image = ((System.Drawing.Image)(resources.GetObject("button_oneline.Image")));
            this.button_oneline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_oneline.Name = "button_oneline";
            this.button_oneline.Size = new System.Drawing.Size(43, 25);
            this.button_oneline.Text = "一行";
            this.button_oneline.Click += new System.EventHandler(this.button_oneline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 25);
            this.toolStripLabel2.Text = "出力文字コード";
            this.toolStripLabel2.ToolTipText = "実行するコマンドが出力する文字コード";
            // 
            // comboBox_encoding
            // 
            this.comboBox_encoding.Items.AddRange(new object[] {
            "Shift_JIS",
            "UTF-8",
            "EUC"});
            this.comboBox_encoding.Name = "comboBox_encoding";
            this.comboBox_encoding.Size = new System.Drawing.Size(104, 28);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 418);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_exec_dir);
            this.Controls.Add(this.textBox_exec_dir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_exec);
            this.Controls.Add(this.textBox_commandLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::ExecCommandHelper.Properties.Settings.Default, "main_location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::ExecCommandHelper.Properties.Settings.Default.main_location;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "ExecCommandHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_commandLine;
        private System.Windows.Forms.Button button_exec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_exec_dir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button_exec_dir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_folder;
        private System.Windows.Forms.RadioButton radioButton_fullpath;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.RadioButton radioButton_relativepath;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_font;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton button_save_info;
        private System.Windows.Forms.ToolStripButton button_delete_info;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton button_multiline;
        private System.Windows.Forms.ToolStripButton button_oneline;
        private System.Windows.Forms.ToolStripButton button_read_info;
        private System.Windows.Forms.ToolStripMenuItem menuitem_selline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox comboBox_encoding;
        private System.Windows.Forms.ToolStripTextBox text_command;
        private System.Windows.Forms.ToolStripButton button_list;
    }
}

