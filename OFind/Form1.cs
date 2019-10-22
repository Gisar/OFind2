using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OFind
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string version = "v2.3";
            verstionLabel.Text = version;
            this.Text = this.Text + " - " + version;
        }

        public bool[] GetBoxes()
        {
            bool[] checkBoxes = new bool[7];
            checkBoxes[0] = procCheck.Checked;
            checkBoxes[1] = FuncCheck.Checked;
            checkBoxes[2] = viewCheck.Checked;
            checkBoxes[3] = triggerCheck.Checked;
            checkBoxes[4] = tableCheck.Checked;
            checkBoxes[5] = indexCheck.Checked;
            checkBoxes[6] = showFolderCheck.Checked;
            return checkBoxes;
        }

        public static List<string> SearchSql(string path, bool[] boxes)
        {
            string[] FileList = SearchFiles(path, "sql");
            List<string> ProcList = new List<string>();
            for (int j = 0; j < FileList.Length; j++)
            {
                ProcList.Add(ParseFiles(FileList[j], "create", "alter", boxes));
            }
            return ProcList;
        }

        public static string[] SearchFiles(string path, string mask)
        {
            string[] files = Directory.GetFiles(path, "*" + mask, SearchOption.AllDirectories);
            return files;
        }
        public static string ParseFiles(string filepath, string stringMask1, string stringMask2, bool[] boxes)
        {
            /*
            0 - PROC
            1 - FUNC
            2 - VIEW
            3 - TRIGGER
            4 - TABLE
            5 - INDEX
            6 - SHOW FOLDER
            */
            int i = 0;
            string pathline = filepath + Environment.NewLine;
            string lines = null;
            foreach (string line in File.ReadAllLines(filepath))
            {
                if (
                        (
                            line.ToUpper().Contains(stringMask1.ToUpper())
                            || line.ToUpper().Contains(stringMask2.ToUpper())
                        )
                        &&
                        (
                            (
                                (line.ToUpper().Contains(" PROC ".ToUpper()) && boxes[0])
                                || (line.ToUpper().Contains(" PROCEDURE ".ToUpper()) && boxes[0])
                            )
                            || (
                                (line.ToUpper().Contains(" FUNC ".ToUpper()) && boxes[1])
                                || (line.ToUpper().Contains(" FUNCTION ".ToUpper()) && boxes[1])
                               )
                            || (line.ToUpper().Contains(" VIEW ".ToUpper()) && boxes[2])
                            || (line.ToUpper().Contains(" TRIGGER ".ToUpper()) && boxes[3])
                            || (
                                line.ToUpper().Contains(" TABLE ".ToUpper())
                                && boxes[4]
                                && !line.ToUpper().Contains(" #".ToUpper()) //Без временных таблиц
                                && (
                                    !line.ToUpper().Contains(" ALTER ".ToUpper()) //Без дополнительных альтеров
                                    || !line.ToUpper().Contains("ALTER TABLE ".ToUpper()) //Без дополнительных альтеров
                                )
                                && !line.ToUpper().Contains(" TYPE ".ToUpper()) //Без типов
                                && !line.ToUpper().Contains(" ADD ".ToUpper()) //Без типов
                            )
                            || (
                                line.ToUpper().Contains(" INDEX ".ToUpper())
                                && boxes[5]
                                && !line.ToUpper().Contains(" #".ToUpper()) //Без временных таблиц
                            )
                        )
                        && !line.ToUpper().Contains("EXEC")
                    )
                {
                    lines += "\t" + ClearString(line.Trim()) + Environment.NewLine;
                    i++;
                }
            }

            
            if (!string.IsNullOrEmpty(lines))
            {
                return pathline + lines;
            }
            else
            {
                return null;
            }
        }

        public static string ClearString(string text)
        {
            string result = text;
            result = Remove(result, "ALTER ");
            result = Remove(result, "CREATE ");
            //result = SearchDir.Remove(result, "PROCEDURE ");
            //result = SearchDir.Remove(result, "PROC ");
            //result = SearchDir.Remove(result, "FUNCTION ");
            //result = SearchDir.Remove(result, "FUNC ");
            //result = SearchDir.Remove(result, "VIEW ");
            //result = SearchDir.Remove(result, " ON");
            result = Remove(result, " AS ");
            result = Remove(result, "[DBO].");
            result = Remove(result, "DBO.");
            result = Remove(result, "[");
            result = Remove(result, "]");
            result = Remove(result, "(");
            result = Remove(result, ")");
            result = Remove(result, "N'");
            if (text.Contains("@"))
            {
                result = result.Remove(result.IndexOf("@"), result.Length - result.IndexOf("@"));
            }
            result = Remove(result, "(");
            return result;
        }

        public static string Remove(string text, string ths)
        {
            string result = text;
            while (result.ToUpper().Contains(ths.ToUpper()))
            {
                result = result.Remove(result.ToUpper().IndexOf(ths.ToUpper()), ths.Length);
            }
            return result;
        }

        public static List<string> UpperFirstWord(List<string> input)
        {
            for (int i = 1; i < input.Count(); i++)
            {
                if (input[i].Contains(" "))
                {
                    //Удаляем табуляцию
                    input[i] = input[i].Replace("\t", "");
                    //Если первый символ пробел - удаляем
                    input[i] = RemoveFirstChar(input[i]);
                    string firstWord;
                    firstWord = input[i].Substring(0, input[i].IndexOf(" "));
                    input[i] = firstWord.ToUpper() + input[i].Substring(firstWord.Length);
                }
            }
            return input;
        }

        public static string RemoveFirstChar(string inputString)
        {
            if (inputString.Substring(0, 1) == " ")
            {
                inputString = inputString.Substring(1);
            }
            return inputString;
        }

        public static List<string> ExpandShortcut(List<string> input)
        {
            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i].Contains("PROC "))
                {
                    input[i] = input[i].Replace("PROC ", "PROCEDURE ");
                }
                if (input[i].Contains("FUNC "))
                {
                    input[i] = input[i].Replace("FUNC ", "FUNCTION ");
                }
            }
            return input;
        }
        public static List<string> RidOfDuplicate (List<string> input)
        {
            for (int i = 0; i < input.Count(); i++)
            {
                List<string> currDock = input[i].Split('\t').ToList();
                currDock = currDock.Distinct().ToList();
                input[i] = string.Join("", currDock);
            }
            return input;
        }
        public static List<string> CompleteParce(string path, bool[] boxes)
        {
            //Ищем процедуры
            List<string> names = SearchSql(path, boxes);
            //Убираем пустые строки
            names = names.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            //Убираем дубли внутри одного документа
            names = RidOfDuplicate(names);
            //Склеиваем все в одну строку и разделяем заново
            names = string.Join(Environment.NewLine, names).Split('\n').ToList();
            //Приводим начало строки в порядок и первое слово пишем капсом
            names = UpperFirstWord(names);
            //Заменяем сокращения на полные имена
            names = ExpandShortcut(names);
            //Возвращаем результат
            return names;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string path = fromFolderTextBox.Text;
            string toFile = toFileTextBox.Text;
            //boxes = GetBoxes();
            bool[] boxes = GetBoxes();

            if (
                !string.IsNullOrEmpty(path)
                && Directory.Exists(path)
                && !string.IsNullOrEmpty(toFile) 
                && File.Exists(toFile)
                )
            {
                List<string> result = CompleteParce(path, boxes);
                string generatedText = string.Join("", result);
                File.WriteAllText(toFile, generatedText);
                MessageBox.Show("Поиск завершен. Результаты записаны в файл:" + Environment.NewLine + toFile, "Внимание");
                if (boxes[6])
                {
                    Process.Start(Path.GetDirectoryName(toFile));
                }
            }
            else if (!string.IsNullOrEmpty(path) && string.IsNullOrEmpty(toFile))
            {
                List<string> result = CompleteParce(path, boxes);
                ViewWindow window = new ViewWindow(result);
                window.Show();
            }
            else
            {
                MessageBox.Show("Поиск запущен не был.", "Внимание");
            }
        }

        private void ClearFolder_Click(object sender, EventArgs e)
        {
            fromFolderTextBox.Text = "";
        }

        private void ClearFile_Click(object sender, EventArgs e)
        {
            toFileTextBox.Text = "";
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                fromFolderTextBox.Text = folderDlg.SelectedPath;
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult fileDialogResult = fileDialog.ShowDialog();
            if (fileDialogResult == DialogResult.OK)
            {
                toFileTextBox.Text = fileDialog.FileName;
            }
        }

        private void ClearCheckBtn_Click(object sender, EventArgs e)
        {
            procCheck.Checked = false;
            FuncCheck.Checked = false;
            viewCheck.Checked = false;
            triggerCheck.Checked = false;
            tableCheck.Checked = false;
            indexCheck.Checked = false;
        }

        private void SetCheckBtn_Click(object sender, EventArgs e)
        {
            procCheck.Checked = true;
            FuncCheck.Checked = true;
            viewCheck.Checked = true;
            triggerCheck.Checked = true;
            tableCheck.Checked = true;
            indexCheck.Checked = true;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O) //Ctrl+O
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fromFolderTextBox.Text = folderDlg.SelectedPath;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
