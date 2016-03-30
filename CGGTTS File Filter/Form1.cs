
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CGGTTS_File_Filter
{
    public partial class MainForm : Form
    {
        // TODO:
        // - skip to lines on messages list box click
        // - refresh sat listboxes on mjd combobox value change !
        // - add edit menu and undo, redo buttons in there

        // TODO: optimize, reorganize data structures ?

        // options and file snapshots
        private Stack<List<string>> fileHistory = new Stack<List<string>>();
        private Stack<SortedSet<int>> satOptionsHistory = new Stack<SortedSet<int>>();
        private Stack<SortedSet<string>> mjdOptionsHistory = new Stack<SortedSet<string>>();
        private Stack<SortedSet<string>> frcOptionsHistory = new Stack<SortedSet<string>>();

        private Stack<string> changelogStrings = new Stack<string>();

        private List<string> fileWorkingCopy = new List<string>();

        private SortedSet<string> mjdOptions = new SortedSet<string>();
        private SortedSet<string> frcOptions = new SortedSet<string>();
        private SortedSet<int> satOptions = new SortedSet<int>();

        bool fileIsLoaded = false;

        // FIXME: using these is not a robust approach
        const int MEASUREMENTS_DATA_START_LINE_NUMBER = 19;
        const int SAT_FIELD_INDEX = 0;
        const int MJD_FIELD_INDEX = 2;
        const int STTIME_FIELD_INDEX = 3;
        const int FRC_FIELD_INDEX = 22;

        public MainForm()
        {
            InitializeComponent();
        }

        private void clearCriteriaOptions()
        {
            satOptions.Clear();
            mjdOptions.Clear();
            frcOptions.Clear();
        }

        private void openFile(string filename)
        {
            // clear from data of previously opened file
            fileWorkingCopy.Clear();

            clearCriteriaOptions();

            // read file
            StreamReader streamReader = new StreamReader(openFileDialog.FileName);
            
            messagesListBox.Items.Clear();

            string line;
            for (int i = 0; (line = streamReader.ReadLine()) != null; ++i)
            {
                fileWorkingCopy.Add(line);

                // FIXME: not a robust approach (use regular expressions)
                if (i >= MEASUREMENTS_DATA_START_LINE_NUMBER)
                {
                    // NOTE: this is not neccessary
                    if (line == "")
                    {
                        messagesListBox.Items.Add("Предупреждение: строка " + i + " пуста");
                        continue;
                    }
    
                    string[] fields = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

                    // FIXME: remove magic number
                    if (fields.Count() != 24)
                    {
                        messagesListBox.Items.Add("Предупреждение: в строке " + i + " неверное число полей");
                        continue;
                    }

                    try {
                        satOptions.Add(Int32.Parse(fields[SAT_FIELD_INDEX]));
                    } catch (Exception ex) {
                        messagesListBox.Items.Add("Ошибка: строка " + i + " : не могу прочитать номер спутника");
                        continue;
                    }

                    // FIXME: validate, using regexps
                    mjdOptions.Add(fields[MJD_FIELD_INDEX]);
                    frcOptions.Add(fields[FRC_FIELD_INDEX]);   
                }
            }
            streamReader.Dispose();
        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                // read file, form criteria options
                openFile(openFileDialog.FileName);

                updateCriteriaControls();

                // notify that file is loaded
                toolStripStatusLabel.Text = "Файл загружен.";
                this.Text = "CGGTTS File Filter (" + openFileDialog.FileName + ")";
                fileIsLoaded = true;

                // output file content and lines count
                previewTextBox.Lines = fileWorkingCopy.ToArray();
                linesCountToolStripStatusLabel.Text = "Количество строк: " + previewTextBox.Lines.Count();

                Cursor.Current = Cursors.Default;
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Файл не выбран - действие было отменено.", 
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // TODO: try to generalize and join these methods into one
        private void satCheckBox_CheckedChanged(object sender, EventArgs e) {
            satComboBox.Enabled = !satComboBox.Enabled;
        }



        private void mjdCheckBox_CheckedChanged(object sender, EventArgs e) {
            mjdComboBox.Enabled = !mjdComboBox.Enabled;

            if (!mjdCheckBox.Enabled) {
                // restore sat list boxes and combobox values
                updateSatControls(satOptions);
            } else if (mjdComboBox.SelectedIndex > -1) {
                // TODO form satOptions for the mjd value
                //

                //updateSatControls
            }
        }

        private void sttimeCheckBox_CheckedChanged(object sender, EventArgs e) {
            sttimePickerTo.Enabled = sttimePickerFrom.Enabled = !sttimePickerFrom.Enabled;
        }

        private void frcCheckBox_CheckedChanged(object sender, EventArgs e) {
            frcComboBox.Enabled = !frcComboBox.Enabled;
        }

        private bool isStateValidToProcessData() 
        {
            // if file was not loaded, print error message and return
            if (!fileIsLoaded)
            {
                MessageBox.Show("Сначала откройте файл.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // if all checkboxes are unchecked, show error message and return 
            if (!satCheckBox.Checked && !frcCheckBox.Checked && 
                !mjdCheckBox.Checked && !sttimeCheckBox.Checked)
            {
                MessageBox.Show("Не выбрано ни одного критерия.", "Ошибка",  MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return false;
            }

            if (satComboBox.SelectedIndex == -1 && satCheckBox.Checked)
            {
                // this would happen rarely
                MessageBox.Show("Не выбрано значение критерия SAT.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (frcComboBox.SelectedIndex == -1 && frcCheckBox.Checked) {
                // this would happen rarely
                MessageBox.Show("Не выбрано значение критерия FRC.", "Ошибка", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return false;
            }

            if (mjdComboBox.SelectedIndex == -1 && mjdCheckBox.Checked) {
                // this would happen rarely
                MessageBox.Show("Не выбрано значение критерия MJD.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void updateChangeLog()
        {
            string str = DateTime.Now.ToString("HH:mm:ss") + " : Удал ";

            if (satCheckBox.Checked)
                str += "SAT = " + satComboBox.Text;
            if (mjdCheckBox.Checked)
                str += ", MJD = " + mjdComboBox.Text;
            if (frcCheckBox.Checked)
                str += ", FRC = " + frcComboBox.Text;
            if (sttimeCheckBox.Checked)
                str += ", STTIME = " + sttimePickerFrom.Value.ToString("HH:mm:ss") + " - " +
                    sttimePickerTo.Value.ToString("HH:mm:ss");

            changelogStrings.Push(str + " .");

            changelogTextBox.Lines = changelogStrings.ToArray();
        }

        private void pushDataToHistory()
        {
            satOptionsHistory.Push(new SortedSet<int>(satOptions));
            mjdOptionsHistory.Push(new SortedSet<string>(mjdOptions));
            frcOptionsHistory.Push(new SortedSet<string>(frcOptions));
            fileHistory.Push(new List<string>(fileWorkingCopy));
        }

        private void popDataFromHistory()
        {
            satOptionsHistory.Pop();
            mjdOptionsHistory.Pop();
            frcOptionsHistory.Pop();
            fileHistory.Pop();
        }

        private bool onlySatIsChecked() {        
            return satCheckBox.Checked && 
                !frcCheckBox.Checked && !mjdCheckBox.Checked && !sttimeCheckBox.Checked;
        }

        private bool onlyMjdIsChecked() {
            return mjdCheckBox.Checked && 
                            !frcCheckBox.Checked && !satCheckBox.Checked && !sttimeCheckBox.Checked;
        }

        private bool onlyFrcIsChecked() {
            return frcCheckBox.Checked &&
                !satCheckBox.Checked && !mjdCheckBox.Checked && !sttimeCheckBox.Checked;
        }

        // TODO: refactor, split this method into submethods
        // PROPOSAL: may count removed lines and print it in status bar
        private void deleteStringsButton_Click(object sender, EventArgs e)
        {
            // TODO: may be replace this with throwing exceptions
            if (!isStateValidToProcessData())
                return;

            Cursor.Current = Cursors.WaitCursor;

            // this variables shows whether there were any lines removed
            bool fileCopyIsChanged = false;

            pushDataToHistory();

            // iterate through lines and remove those which match criteria
            for (int i = fileWorkingCopy.Count - 1; i >= MEASUREMENTS_DATA_START_LINE_NUMBER; --i)
            {
                // split line into fields
                string[] fields =
                    fileWorkingCopy.ElementAt(i).Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

                if (fields.Count() != 24) // FIXME bad silent skip
                    continue;

                // parse STTIME field
                TimeSpan time =
                    TimeSpan.ParseExact(fields[STTIME_FIELD_INDEX], "hhmmss",
                        System.Globalization.CultureInfo.CurrentCulture);

                bool timeMatches = TimeSpan.Compare(time, sttimePickerFrom.Value.TimeOfDay) >= 0 &&
                    TimeSpan.Compare(time, sttimePickerTo.Value.TimeOfDay) <= 0;
                int satNo = Int32.Parse(fields[SAT_FIELD_INDEX]);
                int mjd = Int32.Parse(fields[MJD_FIELD_INDEX]);
                string frc = fields[FRC_FIELD_INDEX];

                // TODO: refactor
                // if the line satisfies criteria
                if ((!satCheckBox.Checked || satNo == Int32.Parse(satComboBox.Text)) &&
                    (!mjdCheckBox.Checked || mjd == Int32.Parse(mjdComboBox.Text)) &&
                    (!sttimeCheckBox.Checked || timeMatches) &&
                    (!frcCheckBox.Checked || frc == frcComboBox.Text))
                {
                        fileWorkingCopy.RemoveAt(i); // then remove the line
                        fileCopyIsChanged = true;

                        // conditionally, remove corresponding criteria options
                        // - that's not enough, FIXME
                        if (onlySatIsChecked())
                            satOptions.Remove(satNo);
                        if (onlyMjdIsChecked()) 
                            mjdOptions.Remove(mjd.ToString());
                        if (onlyFrcIsChecked())
                            frcOptions.Remove(frc);
                }
            }

            // notify if no strings were removed
            if (!fileCopyIsChanged)
            {
                MessageBox.Show("Не найдено подходящих строк для удаления.",
                   "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                popDataFromHistory();
            } 
            else 
            {
                enableSaveButtons(true);

                updateChangeLog();
                updateCriteriaControls();
             
                previewTextBox.Lines = fileWorkingCopy.ToArray();

                linesCountToolStripStatusLabel.Text = "Количество строк: " + previewTextBox.Lines.Count();

                cancelButton.Enabled = true;
            }

            Cursor.Current = Cursors.Default;
        }

        private void zeroComboBoxSelectedIndex(ComboBox cb) {
            if (cb.Items.Count > 0)
                cb.SelectedIndex = 0;
        }

        private void updateSatControls(SortedSet<int> ssi)
        {
            gloSatListBox.Items.Clear();
            gpsSatListBox.Items.Clear();
            satComboBox.Items.Clear();

            foreach (int satNo in ssi)
            {
                if (satNo > 100)
                    gloSatListBox.Items.Add(satNo - 100);
                else
                    gpsSatListBox.Items.Add(satNo);
                satComboBox.Items.Add(satNo);
            }
            zeroComboBoxSelectedIndex(satComboBox);
        }

        private void updateCriteriaControls() 
        {
            // fill sat list boxes and sat combobox
            updateSatControls(satOptions);

            // fill mjd combobox
            mjdComboBox.Items.Clear();

            foreach (string line in mjdOptions)
                mjdComboBox.Items.Add(line);
            zeroComboBoxSelectedIndex(mjdComboBox);

            // fill frc combobox
            frcComboBox.Items.Clear();

            foreach (string line in frcOptions)
                frcComboBox.Items.Add(line);
            zeroComboBoxSelectedIndex(frcComboBox);
        }

        private void enableSaveButtons(bool enabled) {
            saveAsMenuItem.Enabled = saveMenuItem.Enabled = enabled;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // FIXME: this is not neccessary
            if (!fileIsLoaded)
            {
                MessageBox.Show("Сначала откройте файл.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fileHistory.Count == 0)
            {
                MessageBox.Show("Файл в первоначальном состоянии. Отменять нечего.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            enableSaveButtons(true);

            Cursor.Current = Cursors.WaitCursor;

            fileWorkingCopy = fileHistory.Pop();

            // remove last string from changelog textbox
            changelogStrings.Pop();
            changelogTextBox.Lines = changelogStrings.ToArray();

            if (fileHistory.Count == 0)
                cancelButton.Enabled = false;

            // output file's content in its' initial state
            previewTextBox.Lines = fileWorkingCopy.ToArray();

            // output lines count
            linesCountToolStripStatusLabel.Text = "Количество строк: " + previewTextBox.Lines.Count();

            satOptions = satOptionsHistory.Pop();
            mjdOptions = mjdOptionsHistory.Pop();
            frcOptions = frcOptionsHistory.Pop();

            updateCriteriaControls();
           
            Cursor.Current = Cursors.WaitCursor;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: just disable the button
            if (!fileIsLoaded)
            {
                MessageBox.Show("Сначала откройте файл.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog.FileName, fileWorkingCopy.ToArray());

                toolStripStatusLabel.Text = "Файл сохранен.";
                this.Text = "CGGTTS File Filter (" + saveFileDialog.FileName + ")";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileHistory.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Есть несохраненные изменения. Все равно выйти?",
                    "Выйти?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void searchForwardMenuItem_Click(object sender, EventArgs e)
        {
            searchSplitButton.Text = "Поиск вперед";
            if (searchBackwardMenuItem.Checked)
            {
                searchBackwardMenuItem.Checked = false;
                searchForwardMenuItem.Checked = true;
            }
        }

        private void searchBackwardMenuItem_Click(object sender, EventArgs e)
        {
            searchSplitButton.Text = "Поиск назад";
            if (searchForwardMenuItem.Checked)
            {
                searchForwardMenuItem.Checked = false;
                searchBackwardMenuItem.Checked = true;
            }
        }

        private int searchForward(int startLineIndex)
        {
            for (int i = startLineIndex; i < fileWorkingCopy.Count; ++i)
            {
                if (i < MEASUREMENTS_DATA_START_LINE_NUMBER)
                    continue;

                string str = fileWorkingCopy.ElementAt(i);
                string[] fields = str.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

                TimeSpan time;

                try
                {
                    time =
                        TimeSpan.ParseExact(fields[STTIME_FIELD_INDEX], "hhmmss",
                            System.Globalization.CultureInfo.CurrentCulture);
                }
                catch (Exception ex)
                {
                    continue;
                }

                // TODO: refactor
                if ((!satCheckBox.Checked || satComboBox.Text == fields[SAT_FIELD_INDEX]) &&
                    (!mjdCheckBox.Checked || mjdComboBox.Text == fields[MJD_FIELD_INDEX]) &&
                    (!sttimeCheckBox.Checked || TimeSpan.Compare(time, sttimePickerFrom.Value.TimeOfDay) >= 0 &&
                                                TimeSpan.Compare(time, sttimePickerTo.Value.TimeOfDay) <= 0) &&
                    (!frcCheckBox.Checked || (frcComboBox.Text == fields[FRC_FIELD_INDEX])))
                {
                    return i;
                }
            }

            return -1;
        }
        // merge these two methods into general one
        private int searchBackward(int startLineIndex)
        {
            for (int i = startLineIndex; i >= MEASUREMENTS_DATA_START_LINE_NUMBER; --i)
            {
                string str = fileWorkingCopy.ElementAt(i);
                string[] fields = str.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

                TimeSpan time;

                try
                {
                    time = TimeSpan.ParseExact(fields[STTIME_FIELD_INDEX],
                        "hhmmss", System.Globalization.CultureInfo.CurrentCulture);
                }
                catch (Exception ex)
                {
                    continue;
                }

                // TODO: refactor
                if ((!satCheckBox.Checked || satComboBox.Text == fields[SAT_FIELD_INDEX]) &&
                    (!mjdCheckBox.Checked || mjdComboBox.Text == fields[MJD_FIELD_INDEX]) &&
                    (!sttimeCheckBox.Checked || TimeSpan.Compare(time, sttimePickerFrom.Value.TimeOfDay) >= 0 &&
                                                TimeSpan.Compare(time, sttimePickerTo.Value.TimeOfDay) <= 0) &&
                    (!frcCheckBox.Checked || frcComboBox.Text == fields[FRC_FIELD_INDEX]))
                {
                    return i;
                }
            }

            return -1;
        }

        private void searchSplitButton_Click(object sender, EventArgs e)
        {
            if (!isStateValidToProcessData())
                return;

            // magic starts here :)

            int startCharIndex = previewTextBox.SelectionStart;

            int startLineIndex = previewTextBox.GetLineFromCharIndex(startCharIndex);

            int targetLineNumber = 0;
            bool lastSearchWasForward = false;

            if (searchForwardMenuItem.Checked)
            {
                // search forward from current line
                targetLineNumber = searchForward(startLineIndex + 1);
                lastSearchWasForward = true;
            }
            if (searchBackwardMenuItem.Checked)
            {
                // search backward from current line
                targetLineNumber = searchBackward(startLineIndex - 1);
                lastSearchWasForward = false;
            }

            if (targetLineNumber == -1)
            {
                if (lastSearchWasForward)
                {
                    MessageBox.Show("Строка не найдена ниже. Ищу с начала.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    targetLineNumber = searchForward(0);
                }
                else
                {
                    MessageBox.Show("Строка не найдена выше. Ищу с конца.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    targetLineNumber = searchBackward(fileWorkingCopy.Count - 1);
                }
            }

            if (targetLineNumber == -1)
            {
                MessageBox.Show("Строка не найдена.", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int start = previewTextBox.GetFirstCharIndexFromLine(targetLineNumber);

            lastFoundLineNumToolStripStatusLabel.Text = "Последняя найденная строка: " + targetLineNumber;

            previewTextBox.Focus();

            previewTextBox.Select(start + previewTextBox.Lines[targetLineNumber].Length, 
                -previewTextBox.Lines[targetLineNumber].Length);

            previewTextBox.ScrollToCaret();    
        }
        
        private void exportToExcelMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = null;

            try
            {
                xlApp = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            }
            catch
            {
                // Excel is not running.
                xlApp = new Excel.Application();
            }

            if (xlApp == null) 
            { 
                MessageBox.Show("Excel не установлен или установлен неверно.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }

            object misValue = System.Reflection.Missing.Value;

            Excel.Workbook xlWorkBook;

            xlWorkBook = xlApp.Workbooks.Add(misValue);

            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlApp.Visible = true;

            // fill cells
            for (int i = 0; i < fileWorkingCopy.Count; ++i)
            {
                // split line into fields
                string[] fields =
                    fileWorkingCopy.ElementAt(i).Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

                if (fields.Count() != 24)
                    continue;

                for (int j = 1; j <= 24; ++j)
                {
                    xlWorkSheet.Cells[i, j] = fields[j-1];
                }
            }

            xlWorkSheet.Columns.AutoFit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }
        // FIXME: not used
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception occured while releasing object " + ex.ToString(), "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (!fileIsLoaded)
            {
                MessageBox.Show("Сначала откройте файл.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            System.IO.File.WriteAllLines(openFileDialog.FileName,
                fileWorkingCopy.ToArray());

            // FIXME: too long line
            //toolStripStatusLabel1.Text = "Файл сохранен: " + openFileDialog.FileName;
            toolStripStatusLabel.Text = "Файл сохранен.";

            enableSaveButtons(false);
        }

        //System.Data.Sql.

        private void mjdComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            // TODO: update sat list boxes correspondingly


        }



        // TODO: disable save menu items if file was not modified
    }
}
