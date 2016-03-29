namespace CGGTTS_File_Filter
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.sttimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.sttimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToExcelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchForwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBackwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteStringsButton = new System.Windows.Forms.Button();
            this.changelogLabel = new System.Windows.Forms.Label();
            this.changelogTextBox = new System.Windows.Forms.TextBox();
            this.mjdComboBox = new System.Windows.Forms.ComboBox();
            this.dashLabel = new System.Windows.Forms.Label();
            this.satNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.frcComboBox = new System.Windows.Forms.ComboBox();
            this.frcCheckBox = new System.Windows.Forms.CheckBox();
            this.sttimeCheckBox = new System.Windows.Forms.CheckBox();
            this.mjdCheckBox = new System.Windows.Forms.CheckBox();
            this.satCheckBox = new System.Windows.Forms.CheckBox();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.gloSatListBox = new System.Windows.Forms.ListBox();
            this.gpsSatListBox = new System.Windows.Forms.ListBox();
            this.glonassLabel = new System.Windows.Forms.Label();
            this.gpsLabel = new System.Windows.Forms.Label();
            this.previewTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.searchSplitButton = new CGGTTS_File_Filter.SplitButton();
            this.menuStrip.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satNumericUpDown)).BeginInit();
            this.previewGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sttimePickerTo
            // 
            this.sttimePickerTo.Enabled = false;
            this.sttimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sttimePickerTo.Location = new System.Drawing.Point(361, 27);
            this.sttimePickerTo.Margin = new System.Windows.Forms.Padding(4);
            this.sttimePickerTo.Name = "sttimePickerTo";
            this.sttimePickerTo.Size = new System.Drawing.Size(74, 22);
            this.sttimePickerTo.TabIndex = 7;
            this.sttimePickerTo.Value = new System.DateTime(2015, 12, 9, 23, 59, 0, 0);
            // 
            // sttimePickerFrom
            // 
            this.sttimePickerFrom.Enabled = false;
            this.sttimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sttimePickerFrom.Location = new System.Drawing.Point(269, 26);
            this.sttimePickerFrom.Margin = new System.Windows.Forms.Padding(4);
            this.sttimePickerFrom.Name = "sttimePickerFrom";
            this.sttimePickerFrom.Size = new System.Drawing.Size(72, 22);
            this.sttimePickerFrom.TabIndex = 7;
            this.sttimePickerFrom.Value = new System.DateTime(2015, 12, 9, 0, 0, 0, 0);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(732, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator3,
            this.toolStripMenuItem5,
            this.saveAsMenuItem,
            this.toolStripSeparator2,
            this.exportToExcelMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileMenuItem.Text = "Файл";
            this.fileMenuItem.Click += new System.EventHandler(this.fileMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItem2.Text = "Открыть...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItem5.Text = "Сохранить";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(193, 26);
            this.saveAsMenuItem.Text = "Сохранить как...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // exportToExcelMenuItem
            // 
            this.exportToExcelMenuItem.Name = "exportToExcelMenuItem";
            this.exportToExcelMenuItem.Size = new System.Drawing.Size(193, 26);
            this.exportToExcelMenuItem.Text = "Экспорт в Excel";
            this.exportToExcelMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(193, 26);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.settingsGroupBox.Controls.Add(this.searchSplitButton);
            this.settingsGroupBox.Controls.Add(this.groupBox1);
            this.settingsGroupBox.Controls.Add(this.changelogLabel);
            this.settingsGroupBox.Controls.Add(this.changelogTextBox);
            this.settingsGroupBox.Controls.Add(this.mjdComboBox);
            this.settingsGroupBox.Controls.Add(this.sttimePickerTo);
            this.settingsGroupBox.Controls.Add(this.sttimePickerFrom);
            this.settingsGroupBox.Controls.Add(this.dashLabel);
            this.settingsGroupBox.Controls.Add(this.satNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.frcComboBox);
            this.settingsGroupBox.Controls.Add(this.frcCheckBox);
            this.settingsGroupBox.Controls.Add(this.sttimeCheckBox);
            this.settingsGroupBox.Controls.Add(this.mjdCheckBox);
            this.settingsGroupBox.Controls.Add(this.satCheckBox);
            this.settingsGroupBox.Location = new System.Drawing.Point(4, 30);
            this.settingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.settingsGroupBox.Size = new System.Drawing.Size(724, 162);
            this.settingsGroupBox.TabIndex = 3;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Критерии";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForwardMenuItem,
            this.searchBackwardMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(136, 56);
            // 
            // searchForwardMenuItem
            // 
            this.searchForwardMenuItem.Checked = true;
            this.searchForwardMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchForwardMenuItem.Name = "searchForwardMenuItem";
            this.searchForwardMenuItem.Size = new System.Drawing.Size(135, 26);
            this.searchForwardMenuItem.Text = "Вперед";
            this.searchForwardMenuItem.Click += new System.EventHandler(this.searchForwardMenuItem_Click);
            // 
            // searchBackwardMenuItem
            // 
            this.searchBackwardMenuItem.Name = "searchBackwardMenuItem";
            this.searchBackwardMenuItem.Size = new System.Drawing.Size(135, 26);
            this.searchBackwardMenuItem.Text = "Назад";
            this.searchBackwardMenuItem.Click += new System.EventHandler(this.searchBackwardMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.deleteStringsButton);
            this.groupBox1.Location = new System.Drawing.Point(185, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(259, 57);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(146, 18);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 28);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteStringsButton
            // 
            this.deleteStringsButton.Location = new System.Drawing.Point(8, 18);
            this.deleteStringsButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStringsButton.Name = "deleteStringsButton";
            this.deleteStringsButton.Size = new System.Drawing.Size(103, 28);
            this.deleteStringsButton.TabIndex = 11;
            this.deleteStringsButton.Text = "Удалить";
            this.deleteStringsButton.UseVisualStyleBackColor = true;
            this.deleteStringsButton.Click += new System.EventHandler(this.deleteStringsButton_Click);
            // 
            // changelogLabel
            // 
            this.changelogLabel.AutoSize = true;
            this.changelogLabel.Location = new System.Drawing.Point(455, 12);
            this.changelogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changelogLabel.Name = "changelogLabel";
            this.changelogLabel.Size = new System.Drawing.Size(144, 17);
            this.changelogLabel.TabIndex = 14;
            this.changelogLabel.Text = "История изменений:";
            // 
            // changelogTextBox
            // 
            this.changelogTextBox.AcceptsTab = true;
            this.changelogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changelogTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changelogTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.changelogTextBox.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.changelogTextBox.Location = new System.Drawing.Point(458, 33);
            this.changelogTextBox.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.changelogTextBox.Multiline = true;
            this.changelogTextBox.Name = "changelogTextBox";
            this.changelogTextBox.ReadOnly = true;
            this.changelogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.changelogTextBox.Size = new System.Drawing.Size(256, 121);
            this.changelogTextBox.TabIndex = 13;
            this.changelogTextBox.TabStop = false;
            this.changelogTextBox.WordWrap = false;
            // 
            // mjdComboBox
            // 
            this.mjdComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.mjdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mjdComboBox.Enabled = false;
            this.mjdComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mjdComboBox.Location = new System.Drawing.Point(92, 66);
            this.mjdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.mjdComboBox.Name = "mjdComboBox";
            this.mjdComboBox.Size = new System.Drawing.Size(63, 24);
            this.mjdComboBox.Sorted = true;
            this.mjdComboBox.TabIndex = 11;
            // 
            // dashLabel
            // 
            this.dashLabel.AutoSize = true;
            this.dashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dashLabel.Location = new System.Drawing.Point(343, 27);
            this.dashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(15, 20);
            this.dashLabel.TabIndex = 4;
            this.dashLabel.Text = "-";
            // 
            // satNumericUpDown
            // 
            this.satNumericUpDown.Enabled = false;
            this.satNumericUpDown.Location = new System.Drawing.Point(92, 27);
            this.satNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.satNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.satNumericUpDown.Name = "satNumericUpDown";
            this.satNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.satNumericUpDown.TabIndex = 3;
            this.satNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frcComboBox
            // 
            this.frcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frcComboBox.Enabled = false;
            this.frcComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.frcComboBox.Location = new System.Drawing.Point(269, 66);
            this.frcComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.frcComboBox.Name = "frcComboBox";
            this.frcComboBox.Size = new System.Drawing.Size(167, 24);
            this.frcComboBox.Sorted = true;
            this.frcComboBox.TabIndex = 2;
            // 
            // frcCheckBox
            // 
            this.frcCheckBox.AutoSize = true;
            this.frcCheckBox.Location = new System.Drawing.Point(185, 69);
            this.frcCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.frcCheckBox.Name = "frcCheckBox";
            this.frcCheckBox.Size = new System.Drawing.Size(61, 21);
            this.frcCheckBox.TabIndex = 0;
            this.frcCheckBox.Text = "FRC:";
            this.frcCheckBox.UseVisualStyleBackColor = true;
            this.frcCheckBox.CheckedChanged += new System.EventHandler(this.frcCheckBox_CheckedChanged);
            // 
            // sttimeCheckBox
            // 
            this.sttimeCheckBox.AutoSize = true;
            this.sttimeCheckBox.Location = new System.Drawing.Point(185, 28);
            this.sttimeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.sttimeCheckBox.Name = "sttimeCheckBox";
            this.sttimeCheckBox.Size = new System.Drawing.Size(84, 21);
            this.sttimeCheckBox.TabIndex = 0;
            this.sttimeCheckBox.Text = "STTIME:";
            this.sttimeCheckBox.UseVisualStyleBackColor = true;
            this.sttimeCheckBox.CheckedChanged += new System.EventHandler(this.sttimeCheckBox_CheckedChanged);
            // 
            // mjdCheckBox
            // 
            this.mjdCheckBox.AutoSize = true;
            this.mjdCheckBox.Location = new System.Drawing.Point(22, 69);
            this.mjdCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.mjdCheckBox.Name = "mjdCheckBox";
            this.mjdCheckBox.Size = new System.Drawing.Size(62, 21);
            this.mjdCheckBox.TabIndex = 0;
            this.mjdCheckBox.Text = "MJD:";
            this.mjdCheckBox.UseVisualStyleBackColor = true;
            this.mjdCheckBox.CheckedChanged += new System.EventHandler(this.mjdCheckBox_CheckedChanged);
            // 
            // satCheckBox
            // 
            this.satCheckBox.AutoSize = true;
            this.satCheckBox.Location = new System.Drawing.Point(22, 27);
            this.satCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.satCheckBox.Name = "satCheckBox";
            this.satCheckBox.Size = new System.Drawing.Size(61, 21);
            this.satCheckBox.TabIndex = 0;
            this.satCheckBox.Text = "SAT:";
            this.satCheckBox.UseVisualStyleBackColor = true;
            this.satCheckBox.CheckedChanged += new System.EventHandler(this.satCheckBox_CheckedChanged);
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.previewGroupBox.Controls.Add(this.gloSatListBox);
            this.previewGroupBox.Controls.Add(this.gpsSatListBox);
            this.previewGroupBox.Controls.Add(this.glonassLabel);
            this.previewGroupBox.Controls.Add(this.gpsLabel);
            this.previewGroupBox.Controls.Add(this.previewTextBox);
            this.previewGroupBox.Location = new System.Drawing.Point(4, 196);
            this.previewGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.previewGroupBox.Size = new System.Drawing.Size(724, 229);
            this.previewGroupBox.TabIndex = 4;
            this.previewGroupBox.TabStop = false;
            // 
            // gloSatListBox
            // 
            this.gloSatListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gloSatListBox.ColumnWidth = 21;
            this.gloSatListBox.FormattingEnabled = true;
            this.gloSatListBox.ItemHeight = 16;
            this.gloSatListBox.Location = new System.Drawing.Point(54, 23);
            this.gloSatListBox.Margin = new System.Windows.Forms.Padding(4);
            this.gloSatListBox.MultiColumn = true;
            this.gloSatListBox.Name = "gloSatListBox";
            this.gloSatListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gloSatListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.gloSatListBox.Size = new System.Drawing.Size(660, 20);
            this.gloSatListBox.TabIndex = 14;
            this.gloSatListBox.TabStop = false;
            // 
            // gpsSatListBox
            // 
            this.gpsSatListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpsSatListBox.ColumnWidth = 21;
            this.gpsSatListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gpsSatListBox.FormattingEnabled = true;
            this.gpsSatListBox.ItemHeight = 17;
            this.gpsSatListBox.Location = new System.Drawing.Point(54, 53);
            this.gpsSatListBox.Margin = new System.Windows.Forms.Padding(4);
            this.gpsSatListBox.MultiColumn = true;
            this.gpsSatListBox.Name = "gpsSatListBox";
            this.gpsSatListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.gpsSatListBox.Size = new System.Drawing.Size(660, 21);
            this.gpsSatListBox.TabIndex = 14;
            this.gpsSatListBox.TabStop = false;
            // 
            // glonassLabel
            // 
            this.glonassLabel.AutoSize = true;
            this.glonassLabel.Location = new System.Drawing.Point(11, 26);
            this.glonassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.glonassLabel.Name = "glonassLabel";
            this.glonassLabel.Size = new System.Drawing.Size(38, 17);
            this.glonassLabel.TabIndex = 13;
            this.glonassLabel.Text = "GLO";
            // 
            // gpsLabel
            // 
            this.gpsLabel.AutoSize = true;
            this.gpsLabel.Location = new System.Drawing.Point(11, 57);
            this.gpsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpsLabel.Name = "gpsLabel";
            this.gpsLabel.Size = new System.Drawing.Size(37, 17);
            this.gpsLabel.TabIndex = 13;
            this.gpsLabel.Text = "GPS";
            // 
            // previewTextBox
            // 
            this.previewTextBox.AcceptsTab = true;
            this.previewTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.previewTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.previewTextBox.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.previewTextBox.HideSelection = false;
            this.previewTextBox.Location = new System.Drawing.Point(8, 81);
            this.previewTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.previewTextBox.Multiline = true;
            this.previewTextBox.Name = "previewTextBox";
            this.previewTextBox.ReadOnly = true;
            this.previewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.previewTextBox.Size = new System.Drawing.Size(706, 135);
            this.previewTextBox.TabIndex = 12;
            this.previewTextBox.TabStop = false;
            this.previewTextBox.WordWrap = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(732, 29);
            this.statusStrip.TabIndex = 15;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 24);
            this.toolStripStatusLabel1.Text = "Файл не загружен.";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(226, 24);
            this.toolStripStatusLabel3.Text = "Последняя найденная строка: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 24);
            this.toolStripStatusLabel2.Text = "Всего строк: 0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // searchSplitButton
            // 
            this.searchSplitButton.ContextMenuStrip = this.contextMenuStrip;
            this.searchSplitButton.Location = new System.Drawing.Point(27, 116);
            this.searchSplitButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchSplitButton.Name = "searchSplitButton";
            this.searchSplitButton.Size = new System.Drawing.Size(128, 28);
            this.searchSplitButton.TabIndex = 18;
            this.searchSplitButton.Text = "Поиск вперед";
            this.searchSplitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchSplitButton.UseVisualStyleBackColor = true;
            this.searchSplitButton.Click += new System.EventHandler(this.searchSplitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 455);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "MainForm";
            this.Text = "CGGTTS File Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.satNumericUpDown)).EndInit();
            this.previewGroupBox.ResumeLayout(false);
            this.previewGroupBox.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.CheckBox frcCheckBox;
        private System.Windows.Forms.CheckBox sttimeCheckBox;
        private System.Windows.Forms.CheckBox mjdCheckBox;
        private System.Windows.Forms.CheckBox satCheckBox;
        private System.Windows.Forms.ComboBox frcComboBox;
        private System.Windows.Forms.NumericUpDown satNumericUpDown;
        private System.Windows.Forms.Label dashLabel;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.TextBox previewTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DateTimePicker sttimePickerTo;
        private System.Windows.Forms.DateTimePicker sttimePickerFrom;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ListBox gloSatListBox;
        private System.Windows.Forms.ListBox gpsSatListBox;
        private System.Windows.Forms.Label glonassLabel;
        private System.Windows.Forms.Label gpsLabel;
        private System.Windows.Forms.Label changelogLabel;
        private System.Windows.Forms.TextBox changelogTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem searchForwardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBackwardMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteStringsButton;
        private SplitButton searchSplitButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ComboBox mjdComboBox;

        public System.EventHandler settingsGroupBox_Enter { get; set; }
    }
}

