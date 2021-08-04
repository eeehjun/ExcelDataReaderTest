
namespace ExcelDataReaderTest
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip_ToolTip = new System.Windows.Forms.StatusStrip();
            this.dataGridView_Table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_SelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sheetCombo = new System.Windows.Forms.ComboBox();
            this.button_TableLoad = new System.Windows.Forms.Button();
            this.openFileDialog_SelectFile = new System.Windows.Forms.OpenFileDialog();
            this.checkBox_FastReader = new System.Windows.Forms.CheckBox();
            this.toolStripStatusLabel_ToolTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_ToolTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip_ToolTip
            // 
            this.statusStrip_ToolTip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_ToolTip});
            this.statusStrip_ToolTip.Location = new System.Drawing.Point(0, 526);
            this.statusStrip_ToolTip.Name = "statusStrip_ToolTip";
            this.statusStrip_ToolTip.Size = new System.Drawing.Size(1011, 22);
            this.statusStrip_ToolTip.TabIndex = 0;
            this.statusStrip_ToolTip.Text = "statusStrip1";
            // 
            // dataGridView_Table
            // 
            this.dataGridView_Table.AllowUserToAddRows = false;
            this.dataGridView_Table.AllowUserToDeleteRows = false;
            this.dataGridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Table.Location = new System.Drawing.Point(0, 140);
            this.dataGridView_Table.Name = "dataGridView_Table";
            this.dataGridView_Table.ReadOnly = true;
            this.dataGridView_Table.RowTemplate.Height = 25;
            this.dataGridView_Table.Size = new System.Drawing.Size(1011, 386);
            this.dataGridView_Table.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(61, 19);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.Size = new System.Drawing.Size(518, 23);
            this.textBox_Path.TabIndex = 3;
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.Location = new System.Drawing.Point(585, 18);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(116, 23);
            this.button_SelectFile.TabIndex = 4;
            this.button_SelectFile.Text = "Select file";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheets";
            // 
            // sheetCombo
            // 
            this.sheetCombo.FormattingEnabled = true;
            this.sheetCombo.Location = new System.Drawing.Point(61, 109);
            this.sheetCombo.Name = "sheetCombo";
            this.sheetCombo.Size = new System.Drawing.Size(247, 23);
            this.sheetCombo.TabIndex = 6;
            this.sheetCombo.SelectedIndexChanged += new System.EventHandler(this.sheetCombo_SelectedIndexChanged);
            // 
            // button_TableLoad
            // 
            this.button_TableLoad.Location = new System.Drawing.Point(585, 47);
            this.button_TableLoad.Name = "button_TableLoad";
            this.button_TableLoad.Size = new System.Drawing.Size(116, 23);
            this.button_TableLoad.TabIndex = 7;
            this.button_TableLoad.Text = "Table Load";
            this.button_TableLoad.UseVisualStyleBackColor = true;
            this.button_TableLoad.Click += new System.EventHandler(this.button_TableLoad_Click);
            // 
            // openFileDialog_SelectFile
            // 
            this.openFileDialog_SelectFile.FileName = "openFileDialog1";
            this.openFileDialog_SelectFile.Filter = "Supported files|*.xlsx";
            // 
            // checkBox_FastReader
            // 
            this.checkBox_FastReader.AutoSize = true;
            this.checkBox_FastReader.Location = new System.Drawing.Point(469, 51);
            this.checkBox_FastReader.Name = "checkBox_FastReader";
            this.checkBox_FastReader.Size = new System.Drawing.Size(110, 19);
            this.checkBox_FastReader.TabIndex = 8;
            this.checkBox_FastReader.Text = "Use Fast Reader";
            this.checkBox_FastReader.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel_ToolTip
            // 
            this.toolStripStatusLabel_ToolTip.Name = "toolStripStatusLabel_ToolTip";
            this.toolStripStatusLabel_ToolTip.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 548);
            this.Controls.Add(this.checkBox_FastReader);
            this.Controls.Add(this.button_TableLoad);
            this.Controls.Add(this.sheetCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_SelectFile);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Table);
            this.Controls.Add(this.statusStrip_ToolTip);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip_ToolTip.ResumeLayout(false);
            this.statusStrip_ToolTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_ToolTip;
        private System.Windows.Forms.DataGridView dataGridView_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_SelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sheetCombo;
        private System.Windows.Forms.Button button_TableLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SelectFile;
        private System.Windows.Forms.CheckBox checkBox_FastReader;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ToolTip;
    }
}

