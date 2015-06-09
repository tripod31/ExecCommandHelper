namespace ExecCommandHelper
{
    partial class Form_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_edit));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_folder = new System.Windows.Forms.Button();
            this.button_file = new System.Windows.Forms.Button();
            this.radioButton_relative = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_del = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_clear = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // radioButton_relative
            // 
            this.radioButton_relative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_relative.AutoSize = true;
            this.radioButton_relative.Checked = global::ExecCommandHelper.Properties.Settings.Default.relative_path;
            this.radioButton_relative.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ExecCommandHelper.Properties.Settings.Default, "relative_path", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton_relative.Location = new System.Drawing.Point(168, 22);
            this.radioButton_relative.Name = "radioButton_relative";
            this.radioButton_relative.Size = new System.Drawing.Size(78, 19);
            this.radioButton_relative.TabIndex = 3;
            this.radioButton_relative.TabStop = true;
            this.radioButton_relative.Text = "相対パス";
            this.radioButton_relative.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(252, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "フルパス";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button_folder);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.button_file);
            this.groupBox1.Controls.Add(this.radioButton_relative);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "パス入力";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_add,
            this.toolStripButton_del,
            this.toolStripButton_clear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 26);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_add
            // 
            this.toolStripButton_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_add.Image")));
            this.toolStripButton_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_add.Name = "toolStripButton_add";
            this.toolStripButton_add.Size = new System.Drawing.Size(43, 23);
            this.toolStripButton_add.Text = "追加";
            this.toolStripButton_add.Click += new System.EventHandler(this.toolStripButton_add_Click);
            // 
            // toolStripButton_del
            // 
            this.toolStripButton_del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_del.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_del.Image")));
            this.toolStripButton_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_del.Name = "toolStripButton_del";
            this.toolStripButton_del.Size = new System.Drawing.Size(43, 23);
            this.toolStripButton_del.Text = "削除";
            this.toolStripButton_del.Click += new System.EventHandler(this.toolStripButton_del_Click);
            // 
            // toolStripButton_clear
            // 
            this.toolStripButton_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_clear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_clear.Image")));
            this.toolStripButton_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_clear.Name = "toolStripButton_clear";
            this.toolStripButton_clear.Size = new System.Drawing.Size(43, 23);
            this.toolStripButton_clear.Text = "クリア";
            this.toolStripButton_clear.Click += new System.EventHandler(this.toolStripButton_clear_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(12, 29);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 300);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "引数";
            this.columnHeader1.Width = 709;
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(18, 402);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 8;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Form_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = global::ExecCommandHelper.Properties.Settings.Default.edit_size;
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::ExecCommandHelper.Properties.Settings.Default, "edit_size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "Form_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_edit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_folder;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.RadioButton radioButton_relative;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_add;
        private System.Windows.Forms.ToolStripButton toolStripButton_del;
        private System.Windows.Forms.ToolStripButton toolStripButton_clear;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button_ok;
    }
}