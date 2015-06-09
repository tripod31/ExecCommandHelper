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
            this.label1 = new System.Windows.Forms.Label();
            this.button_exec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_load = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_save = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "コマンドライン（実行時に改行をスペースに変換）";
            // 
            // button_exec
            // 
            this.button_exec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_exec.Location = new System.Drawing.Point(22, 393);
            this.button_exec.Name = "button_exec";
            this.button_exec.Size = new System.Drawing.Size(75, 23);
            this.button_exec.TabIndex = 3;
            this.button_exec.Text = "実行";
            this.button_exec.UseVisualStyleBackColor = true;
            this.button_exec.Click += new System.EventHandler(this.button_exec_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "実行ディレクトリ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_load,
            this.ToolStripMenuItem_save});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 23);
            this.toolStripMenuItem1.Text = "ファイル";
            // 
            // ToolStripMenuItem_load
            // 
            this.ToolStripMenuItem_load.Name = "ToolStripMenuItem_load";
            this.ToolStripMenuItem_load.Size = new System.Drawing.Size(108, 24);
            this.ToolStripMenuItem_load.Text = "読込";
            this.ToolStripMenuItem_load.Click += new System.EventHandler(this.ToolStripMenuItem_load_Click);
            // 
            // ToolStripMenuItem_save
            // 
            this.ToolStripMenuItem_save.Name = "ToolStripMenuItem_save";
            this.ToolStripMenuItem_save.Size = new System.Drawing.Size(108, 24);
            this.ToolStripMenuItem_save.Text = "保存";
            this.ToolStripMenuItem_save.Click += new System.EventHandler(this.ToolStripMenuItem_save_Click);
            // 
            // button_exec_dir
            // 
            this.button_exec_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exec_dir.Location = new System.Drawing.Point(754, 355);
            this.button_exec_dir.Name = "button_exec_dir";
            this.button_exec_dir.Size = new System.Drawing.Size(23, 23);
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
            this.textBox_exec_dir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ExecCommandHelper.Properties.Settings.Default, "exec_dir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_exec_dir.Location = new System.Drawing.Point(129, 355);
            this.textBox_exec_dir.Name = "textBox_exec_dir";
            this.textBox_exec_dir.Size = new System.Drawing.Size(619, 21);
            this.textBox_exec_dir.TabIndex = 5;
            this.textBox_exec_dir.Text = global::ExecCommandHelper.Properties.Settings.Default.exec_dir;
            // 
            // textBox_commandLine
            // 
            this.textBox_commandLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_commandLine.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ExecCommandHelper.Properties.Settings.Default, "CommandLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_commandLine.Location = new System.Drawing.Point(22, 62);
            this.textBox_commandLine.Multiline = true;
            this.textBox_commandLine.Name = "textBox_commandLine";
            this.textBox_commandLine.Size = new System.Drawing.Size(752, 231);
            this.textBox_commandLine.TabIndex = 1;
            this.textBox_commandLine.Text = global::ExecCommandHelper.Properties.Settings.Default.CommandLine;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button_folder);
            this.groupBox1.Controls.Add(this.radioButton_fullpath);
            this.groupBox1.Controls.Add(this.button_file);
            this.groupBox1.Controls.Add(this.radioButton_relativepath);
            this.groupBox1.Location = new System.Drawing.Point(25, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 50);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "パス入力";
            // 
            // button_folder
            // 
            this.button_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_folder.Location = new System.Drawing.Point(6, 18);
            this.button_folder.Name = "button_folder";
            this.button_folder.Size = new System.Drawing.Size(75, 23);
            this.button_folder.TabIndex = 1;
            this.button_folder.Text = "フォルダ";
            this.button_folder.UseVisualStyleBackColor = true;
            this.button_folder.Click += new System.EventHandler(this.button_folder_Click);
            // 
            // radioButton_fullpath
            // 
            this.radioButton_fullpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_fullpath.AutoSize = true;
            this.radioButton_fullpath.Location = new System.Drawing.Point(252, 23);
            this.radioButton_fullpath.Name = "radioButton_fullpath";
            this.radioButton_fullpath.Size = new System.Drawing.Size(70, 19);
            this.radioButton_fullpath.TabIndex = 4;
            this.radioButton_fullpath.TabStop = true;
            this.radioButton_fullpath.Text = "フルパス";
            this.radioButton_fullpath.UseVisualStyleBackColor = true;
            // 
            // button_file
            // 
            this.button_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_file.Location = new System.Drawing.Point(87, 20);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(75, 23);
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
            this.radioButton_relativepath.Location = new System.Drawing.Point(168, 22);
            this.radioButton_relativepath.Name = "radioButton_relativepath";
            this.radioButton_relativepath.Size = new System.Drawing.Size(78, 19);
            this.radioButton_relativepath.TabIndex = 3;
            this.radioButton_relativepath.TabStop = true;
            this.radioButton_relativepath.Text = "相対パス";
            this.radioButton_relativepath.UseVisualStyleBackColor = true;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = global::ExecCommandHelper.Properties.Settings.Default.main_size;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_exec_dir);
            this.Controls.Add(this.textBox_exec_dir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_exec);
            this.Controls.Add(this.textBox_commandLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::ExecCommandHelper.Properties.Settings.Default, "main_location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::ExecCommandHelper.Properties.Settings.Default, "main_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::ExecCommandHelper.Properties.Settings.Default.main_location;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_load;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_save;
        private System.Windows.Forms.Button button_exec_dir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_folder;
        private System.Windows.Forms.RadioButton radioButton_fullpath;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.RadioButton radioButton_relativepath;
    }
}

