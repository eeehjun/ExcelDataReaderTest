using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelDataReaderTest
{
    public partial class MainForm : Form
    {
        private DataSet dataSet;

        public MainForm()
        {
            dataSet = new DataSet();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_SelectFile_Click(object sender, EventArgs e)
        {
            var result = openFileDialog_SelectFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_Path.Text = openFileDialog_SelectFile.FileName;
            }
        }

        private void button_TableLoad_Click(object sender, EventArgs e)
        {
            if(checkBox_FastReader.CheckState == CheckState.Checked)
            {
                ExportFastExcel();
            }
            else
            {
                ExportExcel();
            }
        }

        private void ExportFastExcel()
        {
            try
            {
                using var stream = new FileStream(textBox_Path.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                var sw = new Stopwatch();
                sw.Start();

                using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

                var openTiming = sw.ElapsedMilliseconds;

                //reader.IsFirstRowAsColumnNames = firstRowNamesCheckBox.Checked;
                dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    UseColumnDataType = false,
                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                    {
                        //UseHeaderRow = firstRowNamesCheckBox.Checked
                    }
                });

                sw.Stop();
                toolStripStatusLabel_ToolTip.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";

                var tablenames = GetTablenames(dataSet.Tables);
                sheetCombo.DataSource = tablenames;

                if (tablenames.Count > 0)
                    sheetCombo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportExcel()
        {
            try
            {
                dataSet = new DataSet();
                Excel.Application application = new Excel.Application();

                string connectionString = string.Empty;

                switch (Path.GetExtension(textBox_Path.Text).ToUpperInvariant())
                {
                    case ".XLS":
                        connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}; Extended Properties=Excel 8.0;", textBox_Path.Text);
                        break;

                    case ".XLSX":
                        connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties=Excel 12.0;", textBox_Path.Text);
                        break;
                }

                var sw = new Stopwatch();
                sw.Start();

                Workbook workbook = application.Workbooks.Open(textBox_Path.Text);

                var openTiming = sw.ElapsedMilliseconds;

                for (int i = 1; i <= workbook.Worksheets.Count; i++)
                {
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[i];

                    string selectStatement = string.Format("SELECT * FROM [{0}$]", worksheet.Name);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectStatement, connectionString))
                    {
                        adapter.Fill(dataSet, worksheet.Name);
                    }
                }

                object misValue = System.Reflection.Missing.Value;
                workbook.Close(false, misValue, misValue);

                application.Application.Quit();
                application.Quit();

                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(application);

                GC.Collect();
                GC.WaitForPendingFinalizers();

                workbook = null;
                application = null;

                sw.Stop();
                toolStripStatusLabel_ToolTip.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";


                var tablenames = GetTablenames(dataSet.Tables);
                sheetCombo.DataSource = tablenames;

                if (tablenames.Count > 0)
                    sheetCombo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sheetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tablename = sheetCombo.SelectedItem.ToString();

            dataGridView_Table.AutoGenerateColumns = true;
            dataGridView_Table.DataSource = dataSet; // dataset
            dataGridView_Table.DataMember = tablename;
        }

        private static IList<string> GetTablenames(DataTableCollection tables)
        {
            var tableList = new List<string>();
            foreach (var table in tables)
            {
                tableList.Add(table.ToString());
            }

            return tableList;
        }
    }
}
