namespace Notes
{
    partial class QuickNotes
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
            this.TextSize = new System.Windows.Forms.NumericUpDown();
            this.OptionButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Doc = new System.Windows.Forms.RichTextBox();
            this.ExportGroup = new System.Windows.Forms.GroupBox();
            this.ExportLabel = new System.Windows.Forms.TextBox();
            this.ExportBrowseButton = new System.Windows.Forms.Button();
            this.ExportCancelButton = new System.Windows.Forms.Button();
            this.ExportConfirmButton = new System.Windows.Forms.Button();
            this.ImportGroup = new System.Windows.Forms.GroupBox();
            this.ImportLabel = new System.Windows.Forms.TextBox();
            this.ImportBrowseButton = new System.Windows.Forms.Button();
            this.ImportCancelButton = new System.Windows.Forms.Button();
            this.ImportConfirmButton = new System.Windows.Forms.Button();
            this.ClearConfirmGroup = new System.Windows.Forms.GroupBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ClearConfirmButton = new System.Windows.Forms.Button();
            this.OptionGroup = new System.Windows.Forms.GroupBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ConfirmGroup = new System.Windows.Forms.GroupBox();
            this.DeleteCancelButton = new System.Windows.Forms.Button();
            this.DeleteConfirmButton = new System.Windows.Forms.Button();
            this.DeleteBox = new System.Windows.Forms.ComboBox();
            this.LoadGroup = new System.Windows.Forms.GroupBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.LoadMenu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize)).BeginInit();
            this.ExportGroup.SuspendLayout();
            this.ImportGroup.SuspendLayout();
            this.ClearConfirmGroup.SuspendLayout();
            this.OptionGroup.SuspendLayout();
            this.ConfirmGroup.SuspendLayout();
            this.LoadGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextSize
            // 
            this.TextSize.BackColor = System.Drawing.Color.Black;
            this.TextSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSize.ForeColor = System.Drawing.Color.White;
            this.TextSize.Location = new System.Drawing.Point(303, 13);
            this.TextSize.Name = "TextSize";
            this.TextSize.Size = new System.Drawing.Size(49, 26);
            this.TextSize.TabIndex = 24;
            this.TextSize.ValueChanged += new System.EventHandler(this.TextSize_ValueChanged);
            // 
            // OptionButton
            // 
            this.OptionButton.BackColor = System.Drawing.Color.Black;
            this.OptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionButton.ForeColor = System.Drawing.Color.White;
            this.OptionButton.Location = new System.Drawing.Point(215, 9);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(82, 33);
            this.OptionButton.TabIndex = 23;
            this.OptionButton.TabStop = false;
            this.OptionButton.Text = "Options";
            this.OptionButton.UseVisualStyleBackColor = false;
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.Black;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(12, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(197, 26);
            this.NameBox.TabIndex = 22;
            this.NameBox.TabStop = false;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // Doc
            // 
            this.Doc.AcceptsTab = true;
            this.Doc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Doc.BackColor = System.Drawing.Color.Black;
            this.Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc.ForeColor = System.Drawing.Color.White;
            this.Doc.Location = new System.Drawing.Point(12, 48);
            this.Doc.Name = "Doc";
            this.Doc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Doc.Size = new System.Drawing.Size(340, 175);
            this.Doc.TabIndex = 25;
            this.Doc.Text = "";
            // 
            // ExportGroup
            // 
            this.ExportGroup.Controls.Add(this.ExportLabel);
            this.ExportGroup.Controls.Add(this.ExportBrowseButton);
            this.ExportGroup.Controls.Add(this.ExportCancelButton);
            this.ExportGroup.Controls.Add(this.ExportConfirmButton);
            this.ExportGroup.Location = new System.Drawing.Point(487, 179);
            this.ExportGroup.Name = "ExportGroup";
            this.ExportGroup.Size = new System.Drawing.Size(295, 100);
            this.ExportGroup.TabIndex = 30;
            this.ExportGroup.TabStop = false;
            this.ExportGroup.Text = "groupBox1";
            this.ExportGroup.Visible = false;
            // 
            // ExportLabel
            // 
            this.ExportLabel.BackColor = System.Drawing.Color.Black;
            this.ExportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportLabel.ForeColor = System.Drawing.Color.White;
            this.ExportLabel.Location = new System.Drawing.Point(48, 19);
            this.ExportLabel.Name = "ExportLabel";
            this.ExportLabel.Size = new System.Drawing.Size(197, 26);
            this.ExportLabel.TabIndex = 22;
            this.ExportLabel.TabStop = false;
            this.ExportLabel.TextChanged += new System.EventHandler(this.ExportLabel_TextChanged);
            // 
            // ExportBrowseButton
            // 
            this.ExportBrowseButton.BackColor = System.Drawing.Color.Black;
            this.ExportBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportBrowseButton.ForeColor = System.Drawing.Color.White;
            this.ExportBrowseButton.Location = new System.Drawing.Point(200, 57);
            this.ExportBrowseButton.Name = "ExportBrowseButton";
            this.ExportBrowseButton.Size = new System.Drawing.Size(78, 33);
            this.ExportBrowseButton.TabIndex = 19;
            this.ExportBrowseButton.TabStop = false;
            this.ExportBrowseButton.Text = "Browse";
            this.ExportBrowseButton.UseVisualStyleBackColor = false;
            this.ExportBrowseButton.Click += new System.EventHandler(this.ExportBrowseButton_Click);
            // 
            // ExportCancelButton
            // 
            this.ExportCancelButton.BackColor = System.Drawing.Color.Black;
            this.ExportCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportCancelButton.ForeColor = System.Drawing.Color.White;
            this.ExportCancelButton.Location = new System.Drawing.Point(16, 57);
            this.ExportCancelButton.Name = "ExportCancelButton";
            this.ExportCancelButton.Size = new System.Drawing.Size(75, 33);
            this.ExportCancelButton.TabIndex = 18;
            this.ExportCancelButton.TabStop = false;
            this.ExportCancelButton.Text = "Cancel";
            this.ExportCancelButton.UseVisualStyleBackColor = false;
            this.ExportCancelButton.Click += new System.EventHandler(this.ExportCancelButton_Click);
            // 
            // ExportConfirmButton
            // 
            this.ExportConfirmButton.BackColor = System.Drawing.Color.Black;
            this.ExportConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ExportConfirmButton.Location = new System.Drawing.Point(109, 57);
            this.ExportConfirmButton.Name = "ExportConfirmButton";
            this.ExportConfirmButton.Size = new System.Drawing.Size(75, 33);
            this.ExportConfirmButton.TabIndex = 17;
            this.ExportConfirmButton.TabStop = false;
            this.ExportConfirmButton.Text = "Export";
            this.ExportConfirmButton.UseVisualStyleBackColor = false;
            this.ExportConfirmButton.Click += new System.EventHandler(this.ExportConfirmButton_Click);
            // 
            // ImportGroup
            // 
            this.ImportGroup.Controls.Add(this.ImportLabel);
            this.ImportGroup.Controls.Add(this.ImportBrowseButton);
            this.ImportGroup.Controls.Add(this.ImportCancelButton);
            this.ImportGroup.Controls.Add(this.ImportConfirmButton);
            this.ImportGroup.Location = new System.Drawing.Point(487, 73);
            this.ImportGroup.Name = "ImportGroup";
            this.ImportGroup.Size = new System.Drawing.Size(295, 100);
            this.ImportGroup.TabIndex = 28;
            this.ImportGroup.TabStop = false;
            this.ImportGroup.Text = "groupBox1";
            this.ImportGroup.Visible = false;
            // 
            // ImportLabel
            // 
            this.ImportLabel.BackColor = System.Drawing.Color.Black;
            this.ImportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportLabel.ForeColor = System.Drawing.Color.White;
            this.ImportLabel.Location = new System.Drawing.Point(48, 21);
            this.ImportLabel.Name = "ImportLabel";
            this.ImportLabel.Size = new System.Drawing.Size(197, 26);
            this.ImportLabel.TabIndex = 23;
            this.ImportLabel.TabStop = false;
            this.ImportLabel.TextChanged += new System.EventHandler(this.ImportLabel_TextChanged);
            // 
            // ImportBrowseButton
            // 
            this.ImportBrowseButton.BackColor = System.Drawing.Color.Black;
            this.ImportBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportBrowseButton.ForeColor = System.Drawing.Color.White;
            this.ImportBrowseButton.Location = new System.Drawing.Point(200, 57);
            this.ImportBrowseButton.Name = "ImportBrowseButton";
            this.ImportBrowseButton.Size = new System.Drawing.Size(78, 33);
            this.ImportBrowseButton.TabIndex = 19;
            this.ImportBrowseButton.TabStop = false;
            this.ImportBrowseButton.Text = "Browse";
            this.ImportBrowseButton.UseVisualStyleBackColor = false;
            this.ImportBrowseButton.Click += new System.EventHandler(this.ImportBrowseButton_Click);
            // 
            // ImportCancelButton
            // 
            this.ImportCancelButton.BackColor = System.Drawing.Color.Black;
            this.ImportCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportCancelButton.ForeColor = System.Drawing.Color.White;
            this.ImportCancelButton.Location = new System.Drawing.Point(16, 57);
            this.ImportCancelButton.Name = "ImportCancelButton";
            this.ImportCancelButton.Size = new System.Drawing.Size(75, 33);
            this.ImportCancelButton.TabIndex = 18;
            this.ImportCancelButton.TabStop = false;
            this.ImportCancelButton.Text = "Cancel";
            this.ImportCancelButton.UseVisualStyleBackColor = false;
            this.ImportCancelButton.Click += new System.EventHandler(this.ImportCancelButton_Click);
            // 
            // ImportConfirmButton
            // 
            this.ImportConfirmButton.BackColor = System.Drawing.Color.Black;
            this.ImportConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ImportConfirmButton.Location = new System.Drawing.Point(109, 57);
            this.ImportConfirmButton.Name = "ImportConfirmButton";
            this.ImportConfirmButton.Size = new System.Drawing.Size(75, 33);
            this.ImportConfirmButton.TabIndex = 17;
            this.ImportConfirmButton.TabStop = false;
            this.ImportConfirmButton.Text = "Import";
            this.ImportConfirmButton.UseVisualStyleBackColor = false;
            this.ImportConfirmButton.Click += new System.EventHandler(this.ImportConfirmButton_Click);
            // 
            // ClearConfirmGroup
            // 
            this.ClearConfirmGroup.Controls.Add(this.ConfirmLabel);
            this.ClearConfirmGroup.Controls.Add(this.CancelButton);
            this.ClearConfirmGroup.Controls.Add(this.ClearConfirmButton);
            this.ClearConfirmGroup.Location = new System.Drawing.Point(45, 179);
            this.ClearConfirmGroup.Name = "ClearConfirmGroup";
            this.ClearConfirmGroup.Size = new System.Drawing.Size(200, 100);
            this.ClearConfirmGroup.TabIndex = 31;
            this.ClearConfirmGroup.TabStop = false;
            this.ClearConfirmGroup.Text = "groupBox1";
            this.ClearConfirmGroup.Visible = false;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmLabel.ForeColor = System.Drawing.Color.White;
            this.ConfirmLabel.Location = new System.Drawing.Point(40, 22);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(127, 20);
            this.ConfirmLabel.TabIndex = 21;
            this.ConfirmLabel.Text = "Are You Sure?";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Black;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(16, 58);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 33);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ClearConfirmButton
            // 
            this.ClearConfirmButton.BackColor = System.Drawing.Color.Black;
            this.ClearConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ClearConfirmButton.Location = new System.Drawing.Point(109, 58);
            this.ClearConfirmButton.Name = "ClearConfirmButton";
            this.ClearConfirmButton.Size = new System.Drawing.Size(75, 33);
            this.ClearConfirmButton.TabIndex = 13;
            this.ClearConfirmButton.TabStop = false;
            this.ClearConfirmButton.Text = "Clear";
            this.ClearConfirmButton.UseVisualStyleBackColor = false;
            this.ClearConfirmButton.Click += new System.EventHandler(this.ClearConfirmButton_Click);
            // 
            // OptionGroup
            // 
            this.OptionGroup.Controls.Add(this.ExportButton);
            this.OptionGroup.Controls.Add(this.ImportButton);
            this.OptionGroup.Controls.Add(this.ClearButton);
            this.OptionGroup.Controls.Add(this.SaveButton);
            this.OptionGroup.Controls.Add(this.LoadButton);
            this.OptionGroup.Controls.Add(this.DeleteButton);
            this.OptionGroup.Location = new System.Drawing.Point(266, 179);
            this.OptionGroup.Name = "OptionGroup";
            this.OptionGroup.Size = new System.Drawing.Size(200, 145);
            this.OptionGroup.TabIndex = 29;
            this.OptionGroup.TabStop = false;
            this.OptionGroup.Text = "groupBox1";
            this.OptionGroup.Visible = false;
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.Black;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Location = new System.Drawing.Point(109, 100);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 33);
            this.ExportButton.TabIndex = 16;
            this.ExportButton.TabStop = false;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.Black;
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.ForeColor = System.Drawing.Color.White;
            this.ImportButton.Location = new System.Drawing.Point(16, 100);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 33);
            this.ImportButton.TabIndex = 14;
            this.ImportButton.TabStop = false;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Black;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(109, 58);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 33);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Black;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(16, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 33);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Black;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.Location = new System.Drawing.Point(109, 16);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 33);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.TabStop = false;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Black;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(16, 58);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 33);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ConfirmGroup
            // 
            this.ConfirmGroup.Controls.Add(this.DeleteCancelButton);
            this.ConfirmGroup.Controls.Add(this.DeleteConfirmButton);
            this.ConfirmGroup.Controls.Add(this.DeleteBox);
            this.ConfirmGroup.Location = new System.Drawing.Point(266, 73);
            this.ConfirmGroup.Name = "ConfirmGroup";
            this.ConfirmGroup.Size = new System.Drawing.Size(200, 100);
            this.ConfirmGroup.TabIndex = 27;
            this.ConfirmGroup.TabStop = false;
            this.ConfirmGroup.Text = "ConfirmGroup";
            this.ConfirmGroup.Visible = false;
            // 
            // DeleteCancelButton
            // 
            this.DeleteCancelButton.BackColor = System.Drawing.Color.Black;
            this.DeleteCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCancelButton.ForeColor = System.Drawing.Color.White;
            this.DeleteCancelButton.Location = new System.Drawing.Point(16, 57);
            this.DeleteCancelButton.Name = "DeleteCancelButton";
            this.DeleteCancelButton.Size = new System.Drawing.Size(75, 33);
            this.DeleteCancelButton.TabIndex = 18;
            this.DeleteCancelButton.TabStop = false;
            this.DeleteCancelButton.Text = "Cancel";
            this.DeleteCancelButton.UseVisualStyleBackColor = false;
            this.DeleteCancelButton.Click += new System.EventHandler(this.DeleteCancelButton_Click);
            // 
            // DeleteConfirmButton
            // 
            this.DeleteConfirmButton.BackColor = System.Drawing.Color.Black;
            this.DeleteConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteConfirmButton.ForeColor = System.Drawing.Color.White;
            this.DeleteConfirmButton.Location = new System.Drawing.Point(109, 57);
            this.DeleteConfirmButton.Name = "DeleteConfirmButton";
            this.DeleteConfirmButton.Size = new System.Drawing.Size(75, 33);
            this.DeleteConfirmButton.TabIndex = 17;
            this.DeleteConfirmButton.TabStop = false;
            this.DeleteConfirmButton.Text = "Delete";
            this.DeleteConfirmButton.UseVisualStyleBackColor = false;
            this.DeleteConfirmButton.Click += new System.EventHandler(this.DeleteConfirmButton_Click);
            // 
            // DeleteBox
            // 
            this.DeleteBox.BackColor = System.Drawing.Color.Black;
            this.DeleteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBox.ForeColor = System.Drawing.Color.White;
            this.DeleteBox.FormattingEnabled = true;
            this.DeleteBox.Location = new System.Drawing.Point(16, 23);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(168, 28);
            this.DeleteBox.TabIndex = 13;
            this.DeleteBox.SelectedIndexChanged += new System.EventHandler(this.DeleteBox_SelectedIndexChanged);
            // 
            // LoadGroup
            // 
            this.LoadGroup.Controls.Add(this.DoneButton);
            this.LoadGroup.Controls.Add(this.LoadMenu);
            this.LoadGroup.Location = new System.Drawing.Point(45, 73);
            this.LoadGroup.Name = "LoadGroup";
            this.LoadGroup.Size = new System.Drawing.Size(200, 100);
            this.LoadGroup.TabIndex = 26;
            this.LoadGroup.TabStop = false;
            this.LoadGroup.Text = "LoadGroup";
            this.LoadGroup.Visible = false;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Black;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(60, 18);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 33);
            this.DoneButton.TabIndex = 12;
            this.DoneButton.TabStop = false;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // LoadMenu
            // 
            this.LoadMenu.BackColor = System.Drawing.Color.Black;
            this.LoadMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadMenu.ForeColor = System.Drawing.Color.White;
            this.LoadMenu.FormattingEnabled = true;
            this.LoadMenu.Location = new System.Drawing.Point(16, 57);
            this.LoadMenu.Name = "LoadMenu";
            this.LoadMenu.Size = new System.Drawing.Size(168, 28);
            this.LoadMenu.TabIndex = 10;
            this.LoadMenu.SelectedIndexChanged += new System.EventHandler(this.LoadMenu_SelectedIndexChanged);
            // 
            // QuickNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(364, 235);
            this.Controls.Add(this.ExportGroup);
            this.Controls.Add(this.ImportGroup);
            this.Controls.Add(this.ClearConfirmGroup);
            this.Controls.Add(this.OptionGroup);
            this.Controls.Add(this.ConfirmGroup);
            this.Controls.Add(this.LoadGroup);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.TextSize);
            this.Controls.Add(this.OptionButton);
            this.Controls.Add(this.NameBox);
            this.Name = "QuickNotes";
            this.Text = "Note";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Note_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextSize)).EndInit();
            this.ExportGroup.ResumeLayout(false);
            this.ExportGroup.PerformLayout();
            this.ImportGroup.ResumeLayout(false);
            this.ImportGroup.PerformLayout();
            this.ClearConfirmGroup.ResumeLayout(false);
            this.ClearConfirmGroup.PerformLayout();
            this.OptionGroup.ResumeLayout(false);
            this.ConfirmGroup.ResumeLayout(false);
            this.LoadGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TextSize;
        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.RichTextBox Doc;
        private System.Windows.Forms.GroupBox ExportGroup;
        private System.Windows.Forms.TextBox ExportLabel;
        private System.Windows.Forms.Button ExportBrowseButton;
        private System.Windows.Forms.Button ExportCancelButton;
        private System.Windows.Forms.Button ExportConfirmButton;
        private System.Windows.Forms.GroupBox ImportGroup;
        private System.Windows.Forms.TextBox ImportLabel;
        private System.Windows.Forms.Button ImportBrowseButton;
        private System.Windows.Forms.Button ImportCancelButton;
        private System.Windows.Forms.Button ImportConfirmButton;
        private System.Windows.Forms.GroupBox ClearConfirmGroup;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ClearConfirmButton;
        private System.Windows.Forms.GroupBox OptionGroup;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox ConfirmGroup;
        private System.Windows.Forms.Button DeleteCancelButton;
        private System.Windows.Forms.Button DeleteConfirmButton;
        private System.Windows.Forms.ComboBox DeleteBox;
        private System.Windows.Forms.GroupBox LoadGroup;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.ComboBox LoadMenu;
    }
}

