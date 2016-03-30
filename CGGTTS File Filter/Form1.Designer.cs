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
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToExcelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchSplitButton = new CGGTTS_File_Filter.SplitButton();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchForwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBackwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteStringsButton = new System.Windows.Forms.Button();
            this.changelogLabel = new System.Windows.Forms.Label();
            this.changelogTextBox = new System.Windows.Forms.TextBox();
            this.satComboBox = new System.Windows.Forms.ComboBox();
            this.mjdComboBox = new System.Windows.Forms.ComboBox();
            this.dashLabel = new System.Windows.Forms.Label();
            this.frcComboBox = new System.Windows.Forms.ComboBox();
            this.frcCheckBox = new System.Windows.Forms.CheckBox();
            this.sttimeCheckBox = new System.Windows.Forms.CheckBox();
            this.mjdCheckBox = new System.Windows.Forms.CheckBox();
            this.satCheckBox = new System.Windows.Forms.CheckBox();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.messagesListBox = new System.Windows.Forms.ListBox();
            this.gloSatListBox = new System.Windows.Forms.ListBox();
            this.gpsSatListBox = new System.Windows.Forms.ListBox();
            this.glonassLabel = new System.Windows.Forms.Label();
            this.gpsLabel = new System.Windows.Forms.Label();
            this.previewTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.linesCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastFoundLineNumToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.previewGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sttimePickerTo
            // 
            this.sttimePickerTo.Enabled = false;
            this.sttimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sttimePickerTo.Location = new System.Drawing.Point(293, 20);
            this.sttimePickerTo.Name = "sttimePickerTo";
            this.sttimePickerTo.Size = new System.Drawing.Size(65, 20);
            this.sttimePickerTo.TabIndex = 7;
            this.sttimePickerTo.Value = new System.DateTime(2015, 12, 9, 23, 59, 0, 0);
            // 
            // sttimePickerFrom
            // 
            this.sttimePickerFrom.Enabled = false;
            this.sttimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sttimePickerFrom.Location = new System.Drawing.Point(206, 20);
            this.sttimePickerFrom.Name = "sttimePickerFrom";
            this.sttimePickerFrom.Size = new System.Drawing.Size(68, 20);
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
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.toolStripSeparator3,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator2,
            this.exportToExcelMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openFileMenuItem.Text = "Открыть...";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Enabled = false;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveMenuItem.Text = "Сохранить";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Enabled = false;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveAsMenuItem.Text = "Сохранить как...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // exportToExcelMenuItem
            // 
            this.exportToExcelMenuItem.Name = "exportToExcelMenuItem";
            this.exportToExcelMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportToExcelMenuItem.Text = "Экспорт в Excel";
            this.exportToExcelMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(162, 22);
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
            this.settingsGroupBox.Controls.Add(this.satComboBox);
            this.settingsGroupBox.Controls.Add(this.mjdComboBox);
            this.settingsGroupBox.Controls.Add(this.sttimePickerTo);
            this.settingsGroupBox.Controls.Add(this.sttimePickerFrom);
            this.settingsGroupBox.Controls.Add(this.dashLabel);
            this.settingsGroupBox.Controls.Add(this.frcComboBox);
            this.settingsGroupBox.Controls.Add(this.frcCheckBox);
            this.settingsGroupBox.Controls.Add(this.sttimeCheckBox);
            this.settingsGroupBox.Controls.Add(this.mjdCheckBox);
            this.settingsGroupBox.Controls.Add(this.satCheckBox);
            this.settingsGroupBox.Location = new System.Drawing.Point(3, 24);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(677, 132);
            this.settingsGroupBox.TabIndex = 3;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Критерии";
            // 
            // searchSplitButton
            // 
            this.searchSplitButton.ContextMenuStrip = this.contextMenuStrip;
            this.searchSplitButton.Location = new System.Drawing.Point(16, 95);
            this.searchSplitButton.Name = "searchSplitButton";
            this.searchSplitButton.Size = new System.Drawing.Size(108, 23);
            this.searchSplitButton.TabIndex = 18;
            this.searchSplitButton.Text = "Поиск вперед";
            this.searchSplitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchSplitButton.UseVisualStyleBackColor = true;
            this.searchSplitButton.Click += new System.EventHandler(this.searchSplitButton_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForwardMenuItem,
            this.searchBackwardMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(114, 48);
            // 
            // searchForwardMenuItem
            // 
            this.searchForwardMenuItem.Checked = true;
            this.searchForwardMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchForwardMenuItem.Name = "searchForwardMenuItem";
            this.searchForwardMenuItem.Size = new System.Drawing.Size(113, 22);
            this.searchForwardMenuItem.Text = "Вперед";
            this.searchForwardMenuItem.Click += new System.EventHandler(this.searchForwardMenuItem_Click);
            // 
            // searchBackwardMenuItem
            // 
            this.searchBackwardMenuItem.Name = "searchBackwardMenuItem";
            this.searchBackwardMenuItem.Size = new System.Drawing.Size(113, 22);
            this.searchBackwardMenuItem.Text = "Назад";
            this.searchBackwardMenuItem.Click += new System.EventHandler(this.searchBackwardMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.deleteStringsButton);
            this.groupBox1.Location = new System.Drawing.Point(139, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 46);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(134, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteStringsButton
            // 
            this.deleteStringsButton.Location = new System.Drawing.Point(6, 15);
            this.deleteStringsButton.Name = "deleteStringsButton";
            this.deleteStringsButton.Size = new System.Drawing.Size(77, 23);
            this.deleteStringsButton.TabIndex = 11;
            this.deleteStringsButton.Text = "Удалить";
            this.deleteStringsButton.UseVisualStyleBackColor = true;
            this.deleteStringsButton.Click += new System.EventHandler(this.deleteStringsButton_Click);
            // 
            // changelogLabel
            // 
            this.changelogLabel.AutoSize = true;
            this.changelogLabel.Location = new System.Drawing.Point(366, 11);
            this.changelogLabel.Name = "changelogLabel";
            this.changelogLabel.Size = new System.Drawing.Size(112, 13);
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
            this.changelogTextBox.Location = new System.Drawing.Point(369, 27);
            this.changelogTextBox.Margin = new System.Windows.Forms.Padding(8, 3, 8, 8);
            this.changelogTextBox.Multiline = true;
            this.changelogTextBox.Name = "changelogTextBox";
            this.changelogTextBox.ReadOnly = true;
            this.changelogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.changelogTextBox.Size = new System.Drawing.Size(301, 99);
            this.changelogTextBox.TabIndex = 13;
            this.changelogTextBox.TabStop = false;
            this.changelogTextBox.WordWrap = false;
            // 
            // satComboBox
            // 
            this.satComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.satComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.satComboBox.Enabled = false;
            this.satComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.satComboBox.Location = new System.Drawing.Point(69, 20);
            this.satComboBox.Name = "satComboBox";
            this.satComboBox.Size = new System.Drawing.Size(55, 21);
            this.satComboBox.TabIndex = 11;
            // 
            // mjdComboBox
            // 
            this.mjdComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.mjdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mjdComboBox.Enabled = false;
            this.mjdComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mjdComboBox.Location = new System.Drawing.Point(69, 54);
            this.mjdComboBox.Name = "mjdComboBox";
            this.mjdComboBox.Size = new System.Drawing.Size(55, 21);
            this.mjdComboBox.Sorted = true;
            this.mjdComboBox.TabIndex = 11;
            this.mjdComboBox.ValueMemberChanged += new System.EventHandler(this.mjdComboBox_ValueMemberChanged);
            // 
            // dashLabel
            // 
            this.dashLabel.AutoSize = true;
            this.dashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dashLabel.Location = new System.Drawing.Point(277, 20);
            this.dashLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(13, 17);
            this.dashLabel.TabIndex = 4;
            this.dashLabel.Text = "-";
            // 
            // frcComboBox
            // 
            this.frcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frcComboBox.Enabled = false;
            this.frcComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.frcComboBox.Location = new System.Drawing.Point(202, 54);
            this.frcComboBox.Name = "frcComboBox";
            this.frcComboBox.Size = new System.Drawing.Size(156, 21);
            this.frcComboBox.Sorted = true;
            this.frcComboBox.TabIndex = 2;
            // 
            // frcCheckBox
            // 
            this.frcCheckBox.AutoSize = true;
            this.frcCheckBox.Location = new System.Drawing.Point(139, 56);
            this.frcCheckBox.Name = "frcCheckBox";
            this.frcCheckBox.Size = new System.Drawing.Size(50, 17);
            this.frcCheckBox.TabIndex = 0;
            this.frcCheckBox.Text = "FRC:";
            this.frcCheckBox.UseVisualStyleBackColor = true;
            this.frcCheckBox.CheckedChanged += new System.EventHandler(this.frcCheckBox_CheckedChanged);
            // 
            // sttimeCheckBox
            // 
            this.sttimeCheckBox.AutoSize = true;
            this.sttimeCheckBox.Location = new System.Drawing.Point(139, 23);
            this.sttimeCheckBox.Name = "sttimeCheckBox";
            this.sttimeCheckBox.Size = new System.Drawing.Size(69, 17);
            this.sttimeCheckBox.TabIndex = 0;
            this.sttimeCheckBox.Text = "STTIME:";
            this.sttimeCheckBox.UseVisualStyleBackColor = true;
            this.sttimeCheckBox.CheckedChanged += new System.EventHandler(this.sttimeCheckBox_CheckedChanged);
            // 
            // mjdCheckBox
            // 
            this.mjdCheckBox.AutoSize = true;
            this.mjdCheckBox.Location = new System.Drawing.Point(16, 56);
            this.mjdCheckBox.Name = "mjdCheckBox";
            this.mjdCheckBox.Size = new System.Drawing.Size(51, 17);
            this.mjdCheckBox.TabIndex = 0;
            this.mjdCheckBox.Text = "MJD:";
            this.mjdCheckBox.UseVisualStyleBackColor = true;
            this.mjdCheckBox.CheckedChanged += new System.EventHandler(this.mjdCheckBox_CheckedChanged);
            // 
            // satCheckBox
            // 
            this.satCheckBox.AutoSize = true;
            this.satCheckBox.Location = new System.Drawing.Point(16, 22);
            this.satCheckBox.Name = "satCheckBox";
            this.satCheckBox.Size = new System.Drawing.Size(50, 17);
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
            this.previewGroupBox.Controls.Add(this.messagesListBox);
            this.previewGroupBox.Controls.Add(this.gloSatListBox);
            this.previewGroupBox.Controls.Add(this.gpsSatListBox);
            this.previewGroupBox.Controls.Add(this.glonassLabel);
            this.previewGroupBox.Controls.Add(this.gpsLabel);
            this.previewGroupBox.Controls.Add(this.previewTextBox);
            this.previewGroupBox.Location = new System.Drawing.Point(3, 159);
            this.previewGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(677, 303);
            this.previewGroupBox.TabIndex = 4;
            this.previewGroupBox.TabStop = false;
            // 
            // messagesListBox
            // 
            this.messagesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messagesListBox.FormattingEnabled = true;
            this.messagesListBox.Location = new System.Drawing.Point(6, 241);
            this.messagesListBox.Name = "messagesListBox";
            this.messagesListBox.Size = new System.Drawing.Size(664, 56);
            this.messagesListBox.TabIndex = 15;
            // 
            // gloSatListBox
            // 
            this.gloSatListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gloSatListBox.ColumnWidth = 21;
            this.gloSatListBox.FormattingEnabled = true;
            this.gloSatListBox.Location = new System.Drawing.Point(40, 19);
            this.gloSatListBox.MultiColumn = true;
            this.gloSatListBox.Name = "gloSatListBox";
            this.gloSatListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gloSatListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.gloSatListBox.Size = new System.Drawing.Size(630, 17);
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
            this.gpsSatListBox.Location = new System.Drawing.Point(40, 43);
            this.gpsSatListBox.MultiColumn = true;
            this.gpsSatListBox.Name = "gpsSatListBox";
            this.gpsSatListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.gpsSatListBox.Size = new System.Drawing.Size(630, 17);
            this.gpsSatListBox.TabIndex = 14;
            this.gpsSatListBox.TabStop = false;
            // 
            // glonassLabel
            // 
            this.glonassLabel.AutoSize = true;
            this.glonassLabel.Location = new System.Drawing.Point(8, 21);
            this.glonassLabel.Name = "glonassLabel";
            this.glonassLabel.Size = new System.Drawing.Size(29, 13);
            this.glonassLabel.TabIndex = 13;
            this.glonassLabel.Text = "GLO";
            // 
            // gpsLabel
            // 
            this.gpsLabel.AutoSize = true;
            this.gpsLabel.Location = new System.Drawing.Point(8, 46);
            this.gpsLabel.Name = "gpsLabel";
            this.gpsLabel.Size = new System.Drawing.Size(29, 13);
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
            this.previewTextBox.Location = new System.Drawing.Point(6, 66);
            this.previewTextBox.Multiline = true;
            this.previewTextBox.Name = "previewTextBox";
            this.previewTextBox.ReadOnly = true;
            this.previewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.previewTextBox.Size = new System.Drawing.Size(664, 169);
            this.previewTextBox.TabIndex = 12;
            this.previewTextBox.TabStop = false;
            this.previewTextBox.WordWrap = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.linesCountToolStripStatusLabel,
            this.lastFoundLineNumToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 468);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 24);
            this.statusStrip.TabIndex = 15;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(109, 19);
            this.toolStripStatusLabel.Text = "Файл не загружен.";
            // 
            // linesCountToolStripStatusLabel
            // 
            this.linesCountToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.linesCountToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.linesCountToolStripStatusLabel.Name = "linesCountToolStripStatusLabel";
            this.linesCountToolStripStatusLabel.Size = new System.Drawing.Size(88, 19);
            this.linesCountToolStripStatusLabel.Text = "Всего строк: 0";
            // 
            // lastFoundLineNumToolStripStatusLabel
            // 
            this.lastFoundLineNumToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lastFoundLineNumToolStripStatusLabel.Name = "lastFoundLineNumToolStripStatusLabel";
            this.lastFoundLineNumToolStripStatusLabel.Size = new System.Drawing.Size(178, 19);
            this.lastFoundLineNumToolStripStatusLabel.Text = "Последняя найденная строка: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 492);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "MainForm";
            this.Text = "CGGTTS File Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.CheckBox frcCheckBox;
        private System.Windows.Forms.CheckBox sttimeCheckBox;
        private System.Windows.Forms.CheckBox mjdCheckBox;
        private System.Windows.Forms.CheckBox satCheckBox;
        private System.Windows.Forms.ComboBox frcComboBox;
        private System.Windows.Forms.Label dashLabel;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.TextBox previewTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DateTimePicker sttimePickerTo;
        private System.Windows.Forms.DateTimePicker sttimePickerFrom;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel linesCountToolStripStatusLabel;
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
        private System.Windows.Forms.ToolStripStatusLabel lastFoundLineNumToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ComboBox mjdComboBox;
        private System.Windows.Forms.ListBox messagesListBox;
        private System.Windows.Forms.ComboBox satComboBox;

        public System.EventHandler settingsGroupBox_Enter { get; set; }
    }
}

