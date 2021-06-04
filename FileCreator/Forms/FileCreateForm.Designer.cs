namespace Tools
{
    partial class FileCreateForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
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

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileCreateForm));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button_SelectFolder = new System.Windows.Forms.Button();
            this.button_createFile = new System.Windows.Forms.Button();
            this.textBoxDestFolder = new System.Windows.Forms.TextBox();
            this.label_folderMessage = new System.Windows.Forms.Label();
            this.label_fileMessage = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.numericUpDownFileSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_unit = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownFileCount = new System.Windows.Forms.NumericUpDown();
            this.labelFileCount = new System.Windows.Forms.Label();
            this.checkBoxOpenExplorer = new System.Windows.Forms.CheckBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFileSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFileCount)).BeginInit();
            this.SuspendLayout();
            // 
            // button_SelectFolder
            // 
            this.button_SelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SelectFolder.Location = new System.Drawing.Point(280, 67);
            this.button_SelectFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_SelectFolder.Name = "button_SelectFolder";
            this.button_SelectFolder.Size = new System.Drawing.Size(36, 25);
            this.button_SelectFolder.TabIndex = 0;
            this.button_SelectFolder.Text = "...";
            this.button_SelectFolder.UseVisualStyleBackColor = true;
            this.button_SelectFolder.Click += new System.EventHandler(this.button_SelectFolder_Click);
            // 
            // button_createFile
            // 
            this.button_createFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_createFile.Location = new System.Drawing.Point(12, 226);
            this.button_createFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_createFile.Name = "button_createFile";
            this.button_createFile.Size = new System.Drawing.Size(190, 36);
            this.button_createFile.TabIndex = 1;
            this.button_createFile.Text = "Create";
            this.button_createFile.UseVisualStyleBackColor = true;
            this.button_createFile.Click += new System.EventHandler(this.button_createFile_Click);
            // 
            // textBoxDestFolder
            // 
            this.textBoxDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestFolder.Location = new System.Drawing.Point(12, 69);
            this.textBoxDestFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDestFolder.Name = "textBoxDestFolder";
            this.textBoxDestFolder.ReadOnly = true;
            this.textBoxDestFolder.Size = new System.Drawing.Size(262, 23);
            this.textBoxDestFolder.TabIndex = 2;
            // 
            // label_folderMessage
            // 
            this.label_folderMessage.AutoSize = true;
            this.label_folderMessage.Location = new System.Drawing.Point(9, 50);
            this.label_folderMessage.Name = "label_folderMessage";
            this.label_folderMessage.Size = new System.Drawing.Size(82, 15);
            this.label_folderMessage.TabIndex = 3;
            this.label_folderMessage.Text = "ファイル作成先:";
            // 
            // label_fileMessage
            // 
            this.label_fileMessage.AutoSize = true;
            this.label_fileMessage.Location = new System.Drawing.Point(9, 102);
            this.label_fileMessage.Name = "label_fileMessage";
            this.label_fileMessage.Size = new System.Drawing.Size(58, 15);
            this.label_fileMessage.TabIndex = 4;
            this.label_fileMessage.Text = "ファイル名:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(12, 121);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(201, 23);
            this.textBoxFileName.TabIndex = 5;
            this.textBoxFileName.Text = "Default.txt";
            // 
            // numericUpDownFileSize
            // 
            this.numericUpDownFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownFileSize.Location = new System.Drawing.Point(12, 182);
            this.numericUpDownFileSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownFileSize.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.numericUpDownFileSize.Name = "numericUpDownFileSize";
            this.numericUpDownFileSize.Size = new System.Drawing.Size(201, 23);
            this.numericUpDownFileSize.TabIndex = 6;
            this.numericUpDownFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownFileSize.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
            "byte",
            "Kbyte",
            "Mbyte"});
            this.comboBoxUnit.Location = new System.Drawing.Point(219, 182);
            this.comboBoxUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(97, 23);
            this.comboBoxUnit.TabIndex = 7;
            this.comboBoxUnit.Text = "byte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ファイルサイズ:";
            // 
            // label_unit
            // 
            this.label_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_unit.AutoSize = true;
            this.label_unit.Location = new System.Drawing.Point(216, 163);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(36, 15);
            this.label_unit.TabIndex = 9;
            this.label_unit.Text = "単位:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(327, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(117, 20);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.終了ToolStripMenuItem.Text = "終了(&E)";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // numericUpDownFileCount
            // 
            this.numericUpDownFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownFileCount.Location = new System.Drawing.Point(219, 122);
            this.numericUpDownFileCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownFileCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFileCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFileCount.Name = "numericUpDownFileCount";
            this.numericUpDownFileCount.Size = new System.Drawing.Size(97, 23);
            this.numericUpDownFileCount.TabIndex = 6;
            this.numericUpDownFileCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownFileCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelFileCount
            // 
            this.labelFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileCount.AutoSize = true;
            this.labelFileCount.Location = new System.Drawing.Point(216, 103);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(82, 15);
            this.labelFileCount.TabIndex = 8;
            this.labelFileCount.Text = "生成ファイル数:";
            // 
            // checkBoxOpenExplorer
            // 
            this.checkBoxOpenExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxOpenExplorer.AutoSize = true;
            this.checkBoxOpenExplorer.Location = new System.Drawing.Point(12, 270);
            this.checkBoxOpenExplorer.Name = "checkBoxOpenExplorer";
            this.checkBoxOpenExplorer.Size = new System.Drawing.Size(133, 19);
            this.checkBoxOpenExplorer.TabIndex = 12;
            this.checkBoxOpenExplorer.Text = "終了時にフォルダを開く";
            this.checkBoxOpenExplorer.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(208, 226);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(108, 36);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // FileCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 324);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.checkBoxOpenExplorer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.labelFileCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.numericUpDownFileCount);
            this.Controls.Add(this.numericUpDownFileSize);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label_fileMessage);
            this.Controls.Add(this.label_folderMessage);
            this.Controls.Add(this.textBoxDestFolder);
            this.Controls.Add(this.button_createFile);
            this.Controls.Add(this.button_SelectFolder);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(343, 362);
            this.Name = "FileCreateForm";
            this.Text = "ファイル作成";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFileSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFileCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button button_SelectFolder;
        private System.Windows.Forms.Button button_createFile;
        private System.Windows.Forms.TextBox textBoxDestFolder;
        private System.Windows.Forms.Label label_folderMessage;
        private System.Windows.Forms.Label label_fileMessage;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.NumericUpDown numericUpDownFileSize;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownFileCount;
        private System.Windows.Forms.Label labelFileCount;
        private System.Windows.Forms.CheckBox checkBoxOpenExplorer;
        private System.Windows.Forms.Button button_Cancel;
    }
}