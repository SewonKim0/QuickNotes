using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class QuickNotes : Form
    {
        public QuickNotes()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void TabPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Doc.SelectionBackColor = Color.DarkSlateBlue;
                Doc.SelectionColor = Color.White;
            }
            if (e.KeyChar == '\t')
            {
                if (Doc.SelectionBackColor == Color.DarkSlateBlue)
                {
                    Doc.SelectionBackColor = Color.Black;
                    Doc.SelectionColor = Color.White;
                }
                else
                {
                    Doc.SelectionColor = Color.DarkGray;
                }
            }
        }

        private void Note_Load(object sender, EventArgs e)
        {
            if (!Directory.GetFiles("./../..").Contains("./../..\\LocationData.txt"))
            {
                File.WriteAllText("./../..\\LocationData.txt", "0 0\n12");
            }

            String[] fileData = File.ReadAllLines("./../..\\LocationData.txt");

            String[] locationData = fileData[0].Split(' ');
            this.Location = new Point(int.Parse(locationData[0]), int.Parse(locationData[1]));
            TextSize.Value = int.Parse(fileData[1]);

            Doc.Font = new Font(Doc.Font.FontFamily, (int)TextSize.Value, FontStyle.Bold);

            if (!Directory.Exists("./../../Saves"))
            {
                Directory.CreateDirectory("./../../Saves");
            }

            Doc.KeyPress += TabPress;
            Doc.LinkClicked += GoLink;

            Doc.SelectionBackColor = Color.DarkSlateBlue;
            Doc.SelectionColor = Color.White;

            this.FormClosing += SaveLocation;
            this.FormClosing += ClosingSave;
        }

        private void ClosingSave(object sender, EventArgs e)
        {
            if (NameBox.Text == "" && Doc.Text == "")
            {
                return;
            }
            string filePath = "./../../Saves\\" + NameBox.Text + ".txt";
            if (Directory.GetFiles("./../../Saves").Contains(filePath) && Doc.Text.Equals(File.ReadAllText(filePath)))
            {
                return;
            }

            DialogResult result = MessageBox.Show("Save File?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            if (NameBox.Text == "")
            {
                string[] files = Directory.GetFiles("./../../Saves");
                HashSet<string> names = new HashSet<string>();
                foreach (string file in files)
                {
                    names.Add(file.Substring(file.LastIndexOf("\\") + 1, file.Length - file.LastIndexOf("\\") - 5));
                }

                int x = 0;
                while (names.Contains("Untitled" + x))
                {
                    x++;
                }

                NameBox.Text = "Untitled" + x;
            }

            File.WriteAllText("./../../Saves/" + NameBox.Text + ".txt", Doc.Text);
            LoadMenu.Items.Add(NameBox.Text);
        }

        private void SaveLocation(object sender, EventArgs e)
        {
            File.WriteAllText("./../..\\LocationData.txt", this.Location.X + " " + this.Location.Y + "\n" + TextSize.Value);
        }

        private void GoLink(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadGroup.Visible = true;
            LoadGroup.BringToFront();
            LoadGroup.Location = new Point(75, 75);

            LoadMenu.Items.Clear();
            foreach (String file in Directory.EnumerateFiles("./../../Saves"))
            {
                LoadMenu.Items.Add(file.Substring(14, file.IndexOf(".txt") - 14));
            }

            OptionGroup.Visible = false;
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            LoadGroup.Visible = false;
            OptionGroup.Visible = false;

            if (LoadMenu.Text.Equals(""))
            {
                return;
            }
            if (!Directory.GetFiles("./../../Saves").Contains("./../../Saves\\" + LoadMenu.Text + ".txt"))
            {
                MessageBox.Show("Error: File not found");
                LoadMenu.Text = "";
                return;
            }

            String path = "./../../Saves/" + LoadMenu.Text + ".txt";
            String[] lines = File.ReadAllLines(path);

            Doc.Text = "";
            foreach (String line in lines)
            {
                if (line.Equals(""))
                {
                    Doc.AppendText("\n");
                    continue;
                }

                Doc.SelectionBackColor = Color.DarkSlateBlue;
                Doc.SelectionColor = Color.White;
                if (line.Substring(0, 1).Equals("\t"))
                {
                    Doc.SelectionBackColor = Color.Black;
                    Doc.SelectionColor = Color.White;
                }
                if (line.Length > 1 && line.Substring(1, 1).Equals("\t"))
                {
                    Doc.SelectionColor = Color.DarkGray;
                }

                Doc.AppendText(line + "\n");
            }

            NameBox.Text = LoadMenu.Text;
            LoadMenu.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Equals(""))
            {
                MessageBox.Show("Error: No file name provided");
                return;
            }

            File.WriteAllText("./../../Saves/" + NameBox.Text + ".txt", Doc.Text);
            LoadMenu.Items.Add(NameBox.Text);

            OptionGroup.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ConfirmGroup.Visible = true;
            ConfirmGroup.BringToFront();
            ConfirmGroup.Location = new Point(75, 75);

            DeleteBox.Items.Clear();
            foreach (string file in Directory.GetFiles("./../../Saves"))
            {
                string name = file.Substring(file.LastIndexOf("\\") + 1, file.Length - file.LastIndexOf("\\") - 5);
                DeleteBox.Items.Add(name);
            }

            OptionGroup.Visible = false;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void DeleteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void LoadMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            if (OptionGroup.Visible == false)
            {
                OptionGroup.Visible = true;
                OptionGroup.BringToFront();
                OptionGroup.Location = new Point(75, 75);

                ExportGroup.Visible = false;
                ImportGroup.Visible = false;
                LoadGroup.Visible = false;
                ClearConfirmGroup.Visible = false;
                ConfirmGroup.Visible = false;
            }
            else
            {
                OptionGroup.Visible = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearConfirmGroup.Visible = false;

            OptionGroup.Visible = false;
        }

        private void ClearConfirmButton_Click(object sender, EventArgs e)
        {
            foreach (string file in Directory.GetFiles("./../../Saves"))
            {
                File.Delete(file);
            }
            ClearConfirmGroup.Visible = false;

            OptionGroup.Visible = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearConfirmGroup.Visible = true;
            ClearConfirmGroup.BringToFront();
            ClearConfirmGroup.Location = new Point(75, 75);

            OptionGroup.Visible = false;
        }

        private void DeleteCancelButton_Click(object sender, EventArgs e)
        {
            ConfirmGroup.Visible = false;

            DeleteBox.Text = "";

            OptionGroup.Visible = false;
        }

        private void DeleteConfirmButton_Click(object sender, EventArgs e)
        {
            if (DeleteBox.Text == "")
            {
                ConfirmGroup.Visible = false;
                OptionGroup.Visible = false;
                return;
            }
            if (!Directory.GetFiles("./../../Saves").Contains("./../../Saves\\" + DeleteBox.Text + ".txt"))
            {
                MessageBox.Show("Error: Invalid file name");
                ConfirmGroup.Visible = false;
                OptionGroup.Visible = false;
                return;
            }

            ConfirmGroup.Visible = false;

            File.Delete("./../../Saves\\" + DeleteBox.Text + ".txt");

            DeleteBox.Text = "";

            OptionGroup.Visible = false;
        }

        private void Doc_TextChanged(object sender, EventArgs e)
        {
            if (Doc.Text == "")
            {
                Doc.SelectionBackColor = Color.DarkSlateBlue;
                Doc.ForeColor = Color.White;
            }
        }

        private void TextSize_ValueChanged(object sender, EventArgs e)
        {
            if (TextSize.Value < 1)
            {
                return;
            }
            Doc.Font = new Font(Doc.Font.FontFamily, (int)TextSize.Value, FontStyle.Bold);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportGroup.Visible = true;
            ExportGroup.BringToFront();
            ExportGroup.Location = new Point(75, 75);

            OptionGroup.Visible = false;
        }

        private void ExportConfirmButton_Click(object sender, EventArgs e)
        {
            if (ExportLabel.Text.Equals(""))
            {
                MessageBox.Show("Error: No directory provided");
                return;
            }
            if (!Directory.Exists(ExportLabel.Text))
            {
                MessageBox.Show("Error: Invalid directory path");
                return;
            }
            if (Directory.Exists(ExportLabel.Text + "\\QuickNotesSave"))
            {
                MessageBox.Show("Error: Export already exists in selected directory");
                return;
            }

            Directory.CreateDirectory(ExportLabel.Text + "/QuickNotesSave");

            foreach (string file in Directory.GetFiles("./../../Saves"))
            {
                string name = file.Substring(file.LastIndexOf("\\") + 1);
                File.WriteAllText(ExportLabel.Text + "/QuickNotesSave/" + name, File.ReadAllText(file));
            }

            MessageBox.Show("Export Successful");
            ExportLabel.Text = "";
            ExportGroup.Visible = false;
        }

        private void ExportBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ExportLabel.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ExportCancelButton_Click(object sender, EventArgs e)
        {
            ExportGroup.Visible = false;
        }

        private void ExportLabel_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void ImportLabel_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportGroup.Visible = true;
            ImportGroup.BringToFront();
            ImportGroup.Location = new Point(75, 75);

            OptionGroup.Visible = false;
        }

        private void ImportConfirmButton_Click(object sender, EventArgs e)
        {
            if (ImportLabel.Text.Equals(""))
            {
                MessageBox.Show("Error: No file provided");
                return;
            }
            if (!File.Exists(ImportLabel.Text))
            {
                MessageBox.Show("Error: Invalid file");
                return;
            }

            string path = ImportLabel.Text;
            NameBox.Text = path.Substring(path.LastIndexOf("\\") + 1, path.Length - path.LastIndexOf("\\") - 5);

            Doc.Text = "";
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Doc.SelectionBackColor = Color.DarkSlateBlue;
                Doc.SelectionColor = Color.White;

                if (line.Length >= 1 && line[0] == '\t')
                {
                    Doc.SelectionBackColor = Color.Black;

                    if (line.Length >= 2 && line[1] == '\t')
                    {
                        Doc.SelectionColor = Color.DarkGray;
                    }
                }
                Doc.AppendText(line + "\n");
            }

            MessageBox.Show("Import Successful");
            ImportLabel.Text = "";
            ImportGroup.Visible = false;
        }

        private void ImportCancelButton_Click(object sender, EventArgs e)
        {
            ImportGroup.Visible = false;
        }

        private void ImportBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportLabel.Text = openFileDialog.FileName;
            }
        }

        private void LoadGroup_Enter(object sender, EventArgs e)
        {
            //
        }
    }
}
