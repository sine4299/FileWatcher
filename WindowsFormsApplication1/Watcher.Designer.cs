namespace WindowsFormsApplication1
{
    partial class Watcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Watcher));
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.directoryErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.startWatch = new System.Windows.Forms.Button();
            this.stopWatcher = new System.Windows.Forms.Button();
            this.directorylabel = new System.Windows.Forms.Label();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.extensionlabel = new System.Windows.Forms.Label();
            this.logWindowTextBox = new System.Windows.Forms.RichTextBox();
            this.writeDatabaseButton = new System.Windows.Forms.Button();
            this.writelabel = new System.Windows.Forms.Label();
            this.querybutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTableButton = new System.Windows.Forms.Button();
            this.writeDatabaselabel = new System.Windows.Forms.Label();
            this.queryComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.writeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearDatabaseToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.directoryErrorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(32, 81);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(481, 20);
            this.directoryTextBox.TabIndex = 0;
            this.directoryTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.directoryTextBox_Validating);
            this.directoryTextBox.Validated += new System.EventHandler(this.directoryTextBox_Validated);
            // 
            // directoryErrorProvider
            // 
            this.directoryErrorProvider.ContainerControl = this;
            // 
            // startWatch
            // 
            this.startWatch.Location = new System.Drawing.Point(32, 107);
            this.startWatch.Name = "startWatch";
            this.startWatch.Size = new System.Drawing.Size(75, 23);
            this.startWatch.TabIndex = 1;
            this.startWatch.Text = "Start";
            this.startWatch.UseVisualStyleBackColor = true;
            this.startWatch.Click += new System.EventHandler(this.startWatch_Click);
            // 
            // stopWatcher
            // 
            this.stopWatcher.Enabled = false;
            this.stopWatcher.Location = new System.Drawing.Point(155, 107);
            this.stopWatcher.Name = "stopWatcher";
            this.stopWatcher.Size = new System.Drawing.Size(75, 23);
            this.stopWatcher.TabIndex = 2;
            this.stopWatcher.Text = "Stop";
            this.stopWatcher.UseVisualStyleBackColor = true;
            this.stopWatcher.Click += new System.EventHandler(this.stopWatcher_Click);
            // 
            // directorylabel
            // 
            this.directorylabel.AutoSize = true;
            this.directorylabel.Location = new System.Drawing.Point(29, 65);
            this.directorylabel.Name = "directorylabel";
            this.directorylabel.Size = new System.Drawing.Size(201, 13);
            this.directorylabel.TabIndex = 3;
            this.directorylabel.Text = "Enter a directory you would like to watch.";
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Items.AddRange(new object[] {
            ".txt",
            ".jpg",
            ".tiff",
            ".pdf",
            ".mp3",
            ".mp4"});
            this.extensionComboBox.Location = new System.Drawing.Point(545, 81);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(48, 21);
            this.extensionComboBox.TabIndex = 4;
            // 
            // extensionlabel
            // 
            this.extensionlabel.AutoSize = true;
            this.extensionlabel.Location = new System.Drawing.Point(542, 65);
            this.extensionlabel.Name = "extensionlabel";
            this.extensionlabel.Size = new System.Drawing.Size(97, 13);
            this.extensionlabel.TabIndex = 5;
            this.extensionlabel.Text = "Extension to watch";
            // 
            // logWindowTextBox
            // 
            this.logWindowTextBox.Location = new System.Drawing.Point(32, 201);
            this.logWindowTextBox.Name = "logWindowTextBox";
            this.logWindowTextBox.Size = new System.Drawing.Size(607, 317);
            this.logWindowTextBox.TabIndex = 6;
            this.logWindowTextBox.Text = "";
            // 
            // writeDatabaseButton
            // 
            this.writeDatabaseButton.Location = new System.Drawing.Point(32, 163);
            this.writeDatabaseButton.Name = "writeDatabaseButton";
            this.writeDatabaseButton.Size = new System.Drawing.Size(75, 23);
            this.writeDatabaseButton.TabIndex = 7;
            this.writeDatabaseButton.Text = "Write";
            this.writeDatabaseButton.UseVisualStyleBackColor = true;
            this.writeDatabaseButton.Click += new System.EventHandler(this.writeDatabaseButton_Click);
            // 
            // writelabel
            // 
            this.writelabel.AutoSize = true;
            this.writelabel.Location = new System.Drawing.Point(357, 147);
            this.writelabel.Name = "writelabel";
            this.writelabel.Size = new System.Drawing.Size(156, 13);
            this.writelabel.TabIndex = 8;
            this.writelabel.Text = "Search database by: extension.";
            // 
            // querybutton
            // 
            this.querybutton.Enabled = false;
            this.querybutton.Location = new System.Drawing.Point(438, 163);
            this.querybutton.Name = "querybutton";
            this.querybutton.Size = new System.Drawing.Size(75, 23);
            this.querybutton.TabIndex = 10;
            this.querybutton.Text = "Query";
            this.querybutton.UseVisualStyleBackColor = true;
            this.querybutton.Click += new System.EventHandler(this.querybutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem,
            this.writeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.writeToolStripMenuItem.Text = "Write";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearTableButton
            // 
            this.clearTableButton.Location = new System.Drawing.Point(155, 163);
            this.clearTableButton.Name = "clearTableButton";
            this.clearTableButton.Size = new System.Drawing.Size(75, 23);
            this.clearTableButton.TabIndex = 12;
            this.clearTableButton.Text = "Clear";
            this.clearTableButton.UseVisualStyleBackColor = true;
            this.clearTableButton.Click += new System.EventHandler(this.clearTableButton_Click);
            // 
            // writeDatabaselabel
            // 
            this.writeDatabaselabel.AutoSize = true;
            this.writeDatabaselabel.Location = new System.Drawing.Point(29, 147);
            this.writeDatabaselabel.Name = "writeDatabaselabel";
            this.writeDatabaselabel.Size = new System.Drawing.Size(215, 13);
            this.writeDatabaselabel.TabIndex = 13;
            this.writeDatabaselabel.Text = "Write to a database or clear an existing one.";
            // 
            // queryComboBox
            // 
            this.queryComboBox.FormattingEnabled = true;
            this.queryComboBox.Items.AddRange(new object[] {
            ".txt",
            ".jpg",
            ".tiff",
            ".pdf",
            ".mp3",
            ".mp4"});
            this.queryComboBox.Location = new System.Drawing.Point(360, 165);
            this.queryComboBox.Name = "queryComboBox";
            this.queryComboBox.Size = new System.Drawing.Size(64, 21);
            this.queryComboBox.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripButton,
            this.stopToolStripButton,
            this.writeToolStripButton,
            this.clearDatabaseToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(670, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // startToolStripButton
            // 
            this.startToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("startToolStripButton.Image")));
            this.startToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startToolStripButton.Name = "startToolStripButton";
            this.startToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.startToolStripButton.Text = "startToolStripButton";
            this.startToolStripButton.ToolTipText = "Start file watcher";
            this.startToolStripButton.Click += new System.EventHandler(this.startToolStripButton_Click);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripButton.Image")));
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stopToolStripButton.Text = "stopToolStripButton";
            this.stopToolStripButton.ToolTipText = "Stop file watcher";
            this.stopToolStripButton.Click += new System.EventHandler(this.stopToolStripButton_Click);
            // 
            // writeToolStripButton
            // 
            this.writeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.writeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("writeToolStripButton.Image")));
            this.writeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.writeToolStripButton.Name = "writeToolStripButton";
            this.writeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.writeToolStripButton.Text = "writeToolStripButton";
            this.writeToolStripButton.ToolTipText = "Write to database";
            this.writeToolStripButton.Click += new System.EventHandler(this.writeToolStripButton_Click);
            // 
            // clearDatabaseToolStripButton
            // 
            this.clearDatabaseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearDatabaseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearDatabaseToolStripButton.Image")));
            this.clearDatabaseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearDatabaseToolStripButton.Name = "clearDatabaseToolStripButton";
            this.clearDatabaseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.clearDatabaseToolStripButton.Text = "clearDatabaseToolStripButton";
            this.clearDatabaseToolStripButton.ToolTipText = "Clear database";
            // 
            // Watcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 539);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.queryComboBox);
            this.Controls.Add(this.writeDatabaselabel);
            this.Controls.Add(this.clearTableButton);
            this.Controls.Add(this.querybutton);
            this.Controls.Add(this.writelabel);
            this.Controls.Add(this.writeDatabaseButton);
            this.Controls.Add(this.logWindowTextBox);
            this.Controls.Add(this.extensionlabel);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.directorylabel);
            this.Controls.Add(this.stopWatcher);
            this.Controls.Add(this.startWatch);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Watcher";
            this.Text = "File Watcher";
            this.Load += new System.EventHandler(this.Watcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.directoryErrorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.ErrorProvider directoryErrorProvider;
        private System.Windows.Forms.Button startWatch;
        private System.Windows.Forms.Button stopWatcher;
        private System.Windows.Forms.Label extensionlabel;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.Label directorylabel;
        private System.Windows.Forms.RichTextBox logWindowTextBox;
        private System.Windows.Forms.Button querybutton;
        private System.Windows.Forms.Label writelabel;
        private System.Windows.Forms.Button writeDatabaseButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.Button clearTableButton;
        private System.Windows.Forms.Label writeDatabaselabel;
        private System.Windows.Forms.ComboBox queryComboBox;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton startToolStripButton;
        private System.Windows.Forms.ToolStripButton stopToolStripButton;
        private System.Windows.Forms.ToolStripButton writeToolStripButton;
        private System.Windows.Forms.ToolStripButton clearDatabaseToolStripButton;
    }
}

