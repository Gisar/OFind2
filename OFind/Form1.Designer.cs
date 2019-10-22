using System;
using System.Windows.Forms;

namespace OFind
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FolderLabel = new System.Windows.Forms.Label();
            this.fromFolderTextBox = new System.Windows.Forms.TextBox();
            this.toFileTextBox = new System.Windows.Forms.TextBox();
            this.toFileLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.procCheck = new System.Windows.Forms.CheckBox();
            this.FuncCheck = new System.Windows.Forms.CheckBox();
            this.viewCheck = new System.Windows.Forms.CheckBox();
            this.triggerCheck = new System.Windows.Forms.CheckBox();
            this.tableCheck = new System.Windows.Forms.CheckBox();
            this.indexCheck = new System.Windows.Forms.CheckBox();
            this.clearCheckBtn = new System.Windows.Forms.Button();
            this.setCheckBtn = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.verstionLabel = new System.Windows.Forms.Label();
            this.clearFile = new System.Windows.Forms.Button();
            this.clearFolder = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.showFolderCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FolderLabel
            // 
            this.FolderLabel.AutoSize = true;
            this.FolderLabel.Location = new System.Drawing.Point(7, 11);
            this.FolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FolderLabel.Name = "FolderLabel";
            this.FolderLabel.Size = new System.Drawing.Size(42, 13);
            this.FolderLabel.TabIndex = 0;
            this.FolderLabel.Text = "Папка:";
            this.FolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fromFolderTextBox
            // 
            this.fromFolderTextBox.Location = new System.Drawing.Point(48, 10);
            this.fromFolderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fromFolderTextBox.Name = "fromFolderTextBox";
            this.fromFolderTextBox.Size = new System.Drawing.Size(451, 20);
            this.fromFolderTextBox.TabIndex = 1;
            // 
            // toFileTextBox
            // 
            this.toFileTextBox.Location = new System.Drawing.Point(48, 32);
            this.toFileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.toFileTextBox.Name = "toFileTextBox";
            this.toFileTextBox.Size = new System.Drawing.Size(451, 20);
            this.toFileTextBox.TabIndex = 2;
            // 
            // toFileLabel
            // 
            this.toFileLabel.AutoSize = true;
            this.toFileLabel.Location = new System.Drawing.Point(2, 35);
            this.toFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toFileLabel.Name = "toFileLabel";
            this.toFileLabel.Size = new System.Drawing.Size(46, 13);
            this.toFileLabel.TabIndex = 3;
            this.toFileLabel.Text = "В файл:";
            this.toFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(1, 55);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(47, 13);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Искать:";
            // 
            // procCheck
            // 
            this.procCheck.AutoSize = true;
            this.procCheck.Checked = true;
            this.procCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.procCheck.Location = new System.Drawing.Point(48, 55);
            this.procCheck.Margin = new System.Windows.Forms.Padding(2);
            this.procCheck.Name = "procCheck";
            this.procCheck.Size = new System.Drawing.Size(83, 17);
            this.procCheck.TabIndex = 8;
            this.procCheck.Text = "Процедуры";
            this.procCheck.UseVisualStyleBackColor = true;
            // 
            // FuncCheck
            // 
            this.FuncCheck.AutoSize = true;
            this.FuncCheck.Checked = true;
            this.FuncCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FuncCheck.Location = new System.Drawing.Point(48, 79);
            this.FuncCheck.Margin = new System.Windows.Forms.Padding(2);
            this.FuncCheck.Name = "FuncCheck";
            this.FuncCheck.Size = new System.Drawing.Size(72, 17);
            this.FuncCheck.TabIndex = 9;
            this.FuncCheck.Text = "Функции";
            this.FuncCheck.UseVisualStyleBackColor = true;
            // 
            // viewCheck
            // 
            this.viewCheck.AutoSize = true;
            this.viewCheck.Checked = true;
            this.viewCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewCheck.Location = new System.Drawing.Point(48, 102);
            this.viewCheck.Margin = new System.Windows.Forms.Padding(2);
            this.viewCheck.Name = "viewCheck";
            this.viewCheck.Size = new System.Drawing.Size(47, 17);
            this.viewCheck.TabIndex = 10;
            this.viewCheck.Text = "Вью";
            this.viewCheck.UseVisualStyleBackColor = true;
            // 
            // triggerCheck
            // 
            this.triggerCheck.AutoSize = true;
            this.triggerCheck.Checked = true;
            this.triggerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.triggerCheck.Location = new System.Drawing.Point(135, 54);
            this.triggerCheck.Margin = new System.Windows.Forms.Padding(2);
            this.triggerCheck.Name = "triggerCheck";
            this.triggerCheck.Size = new System.Drawing.Size(75, 17);
            this.triggerCheck.TabIndex = 11;
            this.triggerCheck.Text = "Триггеры";
            this.triggerCheck.UseVisualStyleBackColor = true;
            // 
            // tableCheck
            // 
            this.tableCheck.AutoSize = true;
            this.tableCheck.Checked = true;
            this.tableCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableCheck.Location = new System.Drawing.Point(135, 77);
            this.tableCheck.Margin = new System.Windows.Forms.Padding(2);
            this.tableCheck.Name = "tableCheck";
            this.tableCheck.Size = new System.Drawing.Size(71, 17);
            this.tableCheck.TabIndex = 12;
            this.tableCheck.Text = "Таблицы";
            this.tableCheck.UseVisualStyleBackColor = true;
            // 
            // indexCheck
            // 
            this.indexCheck.AutoSize = true;
            this.indexCheck.Checked = true;
            this.indexCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.indexCheck.Location = new System.Drawing.Point(135, 100);
            this.indexCheck.Margin = new System.Windows.Forms.Padding(2);
            this.indexCheck.Name = "indexCheck";
            this.indexCheck.Size = new System.Drawing.Size(72, 17);
            this.indexCheck.TabIndex = 13;
            this.indexCheck.Text = "Индексы";
            this.indexCheck.UseVisualStyleBackColor = true;
            // 
            // clearCheckBtn
            // 
            this.clearCheckBtn.Location = new System.Drawing.Point(211, 53);
            this.clearCheckBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearCheckBtn.Name = "clearCheckBtn";
            this.clearCheckBtn.Size = new System.Drawing.Size(82, 22);
            this.clearCheckBtn.TabIndex = 14;
            this.clearCheckBtn.Text = "Снять все";
            this.clearCheckBtn.UseVisualStyleBackColor = true;
            this.clearCheckBtn.Click += new System.EventHandler(this.ClearCheckBtn_Click);
            // 
            // setCheckBtn
            // 
            this.setCheckBtn.Location = new System.Drawing.Point(211, 79);
            this.setCheckBtn.Margin = new System.Windows.Forms.Padding(2);
            this.setCheckBtn.Name = "setCheckBtn";
            this.setCheckBtn.Size = new System.Drawing.Size(82, 22);
            this.setCheckBtn.TabIndex = 15;
            this.setCheckBtn.Text = "Выбрать все";
            this.setCheckBtn.UseVisualStyleBackColor = true;
            this.setCheckBtn.Click += new System.EventHandler(this.SetCheckBtn_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(457, 55);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(82, 22);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // verstionLabel
            // 
            this.verstionLabel.AutoSize = true;
            this.verstionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verstionLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.verstionLabel.Location = new System.Drawing.Point(514, 176);
            this.verstionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.verstionLabel.Name = "verstionLabel";
            this.verstionLabel.Size = new System.Drawing.Size(9, 9);
            this.verstionLabel.TabIndex = 19;
            this.verstionLabel.Text = "v";
            this.verstionLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // clearFile
            // 
            this.clearFile.Image = global::OFind.Properties.Resources.Close_16x;
            this.clearFile.Location = new System.Drawing.Point(495, 31);
            this.clearFile.Margin = new System.Windows.Forms.Padding(2);
            this.clearFile.Name = "clearFile";
            this.clearFile.Size = new System.Drawing.Size(22, 22);
            this.clearFile.TabIndex = 17;
            this.clearFile.UseVisualStyleBackColor = true;
            this.clearFile.Click += new System.EventHandler(this.ClearFile_Click);
            // 
            // clearFolder
            // 
            this.clearFolder.Image = global::OFind.Properties.Resources.Close_16x;
            this.clearFolder.Location = new System.Drawing.Point(495, 9);
            this.clearFolder.Margin = new System.Windows.Forms.Padding(2);
            this.clearFolder.Name = "clearFolder";
            this.clearFolder.Size = new System.Drawing.Size(22, 22);
            this.clearFolder.TabIndex = 16;
            this.clearFolder.UseVisualStyleBackColor = true;
            this.clearFolder.Click += new System.EventHandler(this.ClearFolder_Click);
            // 
            // fileButton
            // 
            this.fileButton.Image = global::OFind.Properties.Resources.Document_16x;
            this.fileButton.Location = new System.Drawing.Point(517, 31);
            this.fileButton.Margin = new System.Windows.Forms.Padding(2);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(22, 22);
            this.fileButton.TabIndex = 5;
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Image = global::OFind.Properties.Resources.Folder_16x;
            this.folderButton.Location = new System.Drawing.Point(517, 9);
            this.folderButton.Margin = new System.Windows.Forms.Padding(2);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(22, 22);
            this.folderButton.TabIndex = 4;
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // showFolderCheck
            // 
            this.showFolderCheck.AutoSize = true;
            this.showFolderCheck.Checked = true;
            this.showFolderCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFolderCheck.Location = new System.Drawing.Point(344, 57);
            this.showFolderCheck.Name = "showFolderCheck";
            this.showFolderCheck.Size = new System.Drawing.Size(108, 17);
            this.showFolderCheck.TabIndex = 20;
            this.showFolderCheck.Text = "Открыть папку?";
            this.showFolderCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 124);
            this.Controls.Add(this.showFolderCheck);
            this.Controls.Add(this.verstionLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.clearFile);
            this.Controls.Add(this.clearFolder);
            this.Controls.Add(this.setCheckBtn);
            this.Controls.Add(this.clearCheckBtn);
            this.Controls.Add(this.indexCheck);
            this.Controls.Add(this.tableCheck);
            this.Controls.Add(this.triggerCheck);
            this.Controls.Add(this.viewCheck);
            this.Controls.Add(this.FuncCheck);
            this.Controls.Add(this.procCheck);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.toFileLabel);
            this.Controls.Add(this.toFileTextBox);
            this.Controls.Add(this.fromFolderTextBox);
            this.Controls.Add(this.FolderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OFind";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FolderLabel;
        private System.Windows.Forms.TextBox fromFolderTextBox;
        private System.Windows.Forms.TextBox toFileTextBox;
        private System.Windows.Forms.Label toFileLabel;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.CheckBox procCheck;
        private System.Windows.Forms.CheckBox FuncCheck;
        private System.Windows.Forms.CheckBox viewCheck;
        private System.Windows.Forms.CheckBox triggerCheck;
        private System.Windows.Forms.CheckBox tableCheck;
        private System.Windows.Forms.CheckBox indexCheck;
        private System.Windows.Forms.Button clearCheckBtn;
        private System.Windows.Forms.Button setCheckBtn;
        private System.Windows.Forms.Button clearFolder;
        private System.Windows.Forms.Button clearFile;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label verstionLabel;
        private ToolTip toolTip1;
        private CheckBox showFolderCheck;
    }
}

