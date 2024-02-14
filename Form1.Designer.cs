namespace Password_vault_GUI
{
    partial class PasswordVault
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
            connectionPanel = new Panel();
            accessContext = new Label();
            pswdField = new TextBox();
            connectionBtn = new Button();
            optionPanel = new Panel();
            displayVault = new Panel();
            vaultContext = new Label();
            cancelBtn = new Button();
            confirmBtn = new Button();
            keyWordLabel = new Label();
            keyWordTextBox = new TextBox();
            passwordTextBox = new TextBox();
            userIDTextBox = new TextBox();
            passwordLabel = new Label();
            userIDLabel = new Label();
            deleteBtn = new Button();
            saveBtn = new Button();
            CreateBtn = new Button();
            selectOption = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            fileSystemWatcher1 = new FileSystemWatcher();
            connectionPanel.SuspendLayout();
            optionPanel.SuspendLayout();
            displayVault.SuspendLayout();
            selectOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // connectionPanel
            // 
            connectionPanel.AutoSize = true;
            connectionPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            connectionPanel.BackColor = SystemColors.Highlight;
            connectionPanel.Controls.Add(accessContext);
            connectionPanel.Controls.Add(pswdField);
            connectionPanel.Controls.Add(connectionBtn);
            connectionPanel.Dock = DockStyle.Fill;
            connectionPanel.Location = new Point(0, 0);
            connectionPanel.Name = "connectionPanel";
            connectionPanel.Size = new Size(802, 519);
            connectionPanel.TabIndex = 2;
            // 
            // accessContext
            // 
            accessContext.Location = new Point(247, 298);
            accessContext.Name = "accessContext";
            accessContext.Size = new Size(338, 60);
            accessContext.TabIndex = 2;
            accessContext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pswdField
            // 
            pswdField.Location = new Point(277, 157);
            pswdField.Name = "pswdField";
            pswdField.Size = new Size(278, 23);
            pswdField.TabIndex = 1;
            // 
            // connectionBtn
            // 
            connectionBtn.Location = new Point(375, 224);
            connectionBtn.Name = "connectionBtn";
            connectionBtn.Size = new Size(75, 23);
            connectionBtn.TabIndex = 0;
            connectionBtn.Text = "login";
            connectionBtn.UseVisualStyleBackColor = true;
            connectionBtn.Click += button1_Click;
            // 
            // optionPanel
            // 
            optionPanel.BackColor = Color.Transparent;
            optionPanel.Controls.Add(displayVault);
            optionPanel.Controls.Add(selectOption);
            optionPanel.Dock = DockStyle.Fill;
            optionPanel.Location = new Point(0, 0);
            optionPanel.Name = "optionPanel";
            optionPanel.Size = new Size(802, 519);
            optionPanel.TabIndex = 2;
            // 
            // displayVault
            // 
            displayVault.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            displayVault.BackColor = Color.White;
            displayVault.Controls.Add(vaultContext);
            displayVault.Controls.Add(cancelBtn);
            displayVault.Controls.Add(confirmBtn);
            displayVault.Controls.Add(keyWordLabel);
            displayVault.Controls.Add(keyWordTextBox);
            displayVault.Controls.Add(passwordTextBox);
            displayVault.Controls.Add(userIDTextBox);
            displayVault.Controls.Add(passwordLabel);
            displayVault.Controls.Add(userIDLabel);
            displayVault.Controls.Add(deleteBtn);
            displayVault.Controls.Add(saveBtn);
            displayVault.Controls.Add(CreateBtn);
            displayVault.Dock = DockStyle.Right;
            displayVault.Location = new Point(273, 0);
            displayVault.Name = "displayVault";
            displayVault.Size = new Size(529, 519);
            displayVault.TabIndex = 0;
            // 
            // vaultContext
            // 
            vaultContext.Location = new Point(3, 345);
            vaultContext.Name = "vaultContext";
            vaultContext.Size = new Size(529, 28);
            vaultContext.TabIndex = 11;
            vaultContext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(347, 57);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Visible = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(134, 57);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 23);
            confirmBtn.TabIndex = 9;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Visible = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // keyWordLabel
            // 
            keyWordLabel.AutoSize = true;
            keyWordLabel.Location = new Point(152, 151);
            keyWordLabel.Name = "keyWordLabel";
            keyWordLabel.Size = new Size(18, 15);
            keyWordLabel.TabIndex = 8;
            keyWordLabel.Text = "ID";
            keyWordLabel.Visible = false;
            // 
            // keyWordTextBox
            // 
            keyWordTextBox.Location = new Point(176, 148);
            keyWordTextBox.Name = "keyWordTextBox";
            keyWordTextBox.Size = new Size(220, 23);
            keyWordTextBox.TabIndex = 7;
            keyWordTextBox.Visible = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(176, 280);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(220, 23);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.Visible = false;
            // 
            // userIDTextBox
            // 
            userIDTextBox.Location = new Point(176, 211);
            userIDTextBox.Name = "userIDTextBox";
            userIDTextBox.Size = new Size(220, 23);
            userIDTextBox.TabIndex = 5;
            userIDTextBox.Visible = false;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(113, 283);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            passwordLabel.Visible = false;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new Point(76, 214);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(94, 15);
            userIDLabel.TabIndex = 3;
            userIDLabel.Text = "Username/Email";
            userIDLabel.Visible = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(347, 415);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Visible = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(134, 415);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Visible = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(242, 12);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(75, 23);
            CreateBtn.TabIndex = 0;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // selectOption
            // 
            selectOption.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            selectOption.BackColor = Color.Lime;
            selectOption.Controls.Add(tableLayoutPanel1);
            selectOption.Dock = DockStyle.Left;
            selectOption.Location = new Point(0, 0);
            selectOption.Name = "selectOption";
            selectOption.Size = new Size(267, 519);
            selectOption.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(192, 192, 255);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(267, 519);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PasswordVault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(802, 519);
            Controls.Add(connectionPanel);
            Controls.Add(optionPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PasswordVault";
            Text = "Form1";
            connectionPanel.ResumeLayout(false);
            connectionPanel.PerformLayout();
            optionPanel.ResumeLayout(false);
            displayVault.ResumeLayout(false);
            displayVault.PerformLayout();
            selectOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel connectionPanel;
        private TextBox pswdField;
        private Button connectionBtn;
        private Panel optionPanel;
        private Panel selectOption;
        private Panel displayVault;
        private FileSystemWatcher fileSystemWatcher1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button deleteBtn;
        private Button saveBtn;
        private Button CreateBtn;
        private TextBox passwordTextBox;
        private TextBox userIDTextBox;
        private Label passwordLabel;
        private Label userIDLabel;
        private Label keyWordLabel;
        private TextBox keyWordTextBox;
        private Button cancelBtn;
        private Button confirmBtn;
        private Label vaultContext;
        private Label accessContext;
    }
}
