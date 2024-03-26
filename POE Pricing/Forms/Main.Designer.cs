namespace POE_Pricing
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelMain = new Panel();
            panelChildForm = new Panel();
            pictureBoxLogo = new PictureBox();
            panelMenu = new Panel();
            panelExitBorder = new Panel();
            buttonExit = new Button();
            panelExit = new Panel();
            buttonExitWithoutSaving = new Button();
            buttonSaveAndExit = new Button();
            buttonSave = new Button();
            buttonSettings = new Button();
            buttonHelp = new Button();
            panelMoneyStrats = new Panel();
            buttonHervestMemory = new Button();
            buttonMoneyStrats = new Button();
            panelPriceChecking = new Panel();
            button1 = new Button();
            buttonPriceChecking = new Button();
            panelMain.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMenu.SuspendLayout();
            panelExit.SuspendLayout();
            panelMoneyStrats.SuspendLayout();
            panelPriceChecking.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(75, 0, 0);
            panelMain.Controls.Add(panelChildForm);
            panelMain.Controls.Add(panelMenu);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1677, 877);
            panelMain.TabIndex = 0;
            // 
            // panelChildForm
            // 
            panelChildForm.Controls.Add(pictureBoxLogo);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(272, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1405, 877);
            panelChildForm.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.BackgroundImage = Properties.Resources.Path_of_Exile_Logo;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(550, 318);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(304, 241);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(panelExitBorder);
            panelMenu.Controls.Add(buttonExit);
            panelMenu.Controls.Add(panelExit);
            panelMenu.Controls.Add(buttonSettings);
            panelMenu.Controls.Add(buttonHelp);
            panelMenu.Controls.Add(panelMoneyStrats);
            panelMenu.Controls.Add(buttonMoneyStrats);
            panelMenu.Controls.Add(panelPriceChecking);
            panelMenu.Controls.Add(buttonPriceChecking);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(5);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(272, 877);
            panelMenu.TabIndex = 3;
            // 
            // panelExitBorder
            // 
            panelExitBorder.Dock = DockStyle.Bottom;
            panelExitBorder.Location = new Point(0, 776);
            panelExitBorder.Name = "panelExitBorder";
            panelExitBorder.Size = new Size(255, 2);
            panelExitBorder.TabIndex = 12;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(150, 0, 0);
            buttonExit.Dock = DockStyle.Bottom;
            buttonExit.FlatAppearance.BorderColor = Color.Black;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            buttonExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 0, 0);
            buttonExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 0);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("MrsEavesSmallCaps", 18F);
            buttonExit.ForeColor = Color.LightGray;
            buttonExit.Location = new Point(0, 778);
            buttonExit.Margin = new Padding(5);
            buttonExit.Name = "buttonExit";
            buttonExit.Padding = new Padding(13, 0, 0, 0);
            buttonExit.Size = new Size(255, 70);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Exit";
            buttonExit.TextAlign = ContentAlignment.MiddleLeft;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panelExit
            // 
            panelExit.BackColor = Color.FromArgb(51, 51, 51);
            panelExit.Controls.Add(buttonExitWithoutSaving);
            panelExit.Controls.Add(buttonSaveAndExit);
            panelExit.Controls.Add(buttonSave);
            panelExit.Dock = DockStyle.Bottom;
            panelExit.Location = new Point(0, 848);
            panelExit.Margin = new Padding(5);
            panelExit.Name = "panelExit";
            panelExit.Size = new Size(255, 165);
            panelExit.TabIndex = 10;
            // 
            // buttonExitWithoutSaving
            // 
            buttonExitWithoutSaving.Dock = DockStyle.Top;
            buttonExitWithoutSaving.FlatAppearance.BorderSize = 0;
            buttonExitWithoutSaving.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            buttonExitWithoutSaving.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 11, 11);
            buttonExitWithoutSaving.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 31, 31);
            buttonExitWithoutSaving.FlatStyle = FlatStyle.Flat;
            buttonExitWithoutSaving.Font = new Font("MrsEavesSmallCaps", 12F);
            buttonExitWithoutSaving.ForeColor = Color.LightGray;
            buttonExitWithoutSaving.Location = new Point(0, 110);
            buttonExitWithoutSaving.Margin = new Padding(5);
            buttonExitWithoutSaving.Name = "buttonExitWithoutSaving";
            buttonExitWithoutSaving.Padding = new Padding(47, 0, 0, 0);
            buttonExitWithoutSaving.Size = new Size(255, 55);
            buttonExitWithoutSaving.TabIndex = 6;
            buttonExitWithoutSaving.Text = "Exit Without Saving";
            buttonExitWithoutSaving.TextAlign = ContentAlignment.MiddleLeft;
            buttonExitWithoutSaving.UseVisualStyleBackColor = true;
            buttonExitWithoutSaving.Click += buttonExitWithoutSaving_Click;
            // 
            // buttonSaveAndExit
            // 
            buttonSaveAndExit.Dock = DockStyle.Top;
            buttonSaveAndExit.FlatAppearance.BorderSize = 0;
            buttonSaveAndExit.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            buttonSaveAndExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 11, 11);
            buttonSaveAndExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 31, 31);
            buttonSaveAndExit.FlatStyle = FlatStyle.Flat;
            buttonSaveAndExit.Font = new Font("MrsEavesSmallCaps", 12F);
            buttonSaveAndExit.ForeColor = Color.LightGray;
            buttonSaveAndExit.Location = new Point(0, 55);
            buttonSaveAndExit.Margin = new Padding(5);
            buttonSaveAndExit.Name = "buttonSaveAndExit";
            buttonSaveAndExit.Padding = new Padding(47, 0, 0, 0);
            buttonSaveAndExit.Size = new Size(255, 55);
            buttonSaveAndExit.TabIndex = 5;
            buttonSaveAndExit.Text = "Save And Exit";
            buttonSaveAndExit.TextAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndExit.UseVisualStyleBackColor = true;
            buttonSaveAndExit.Click += buttonSaveAndExit_Click;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Top;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            buttonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 11, 11);
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 31, 31);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("MrsEavesSmallCaps", 12F);
            buttonSave.ForeColor = Color.LightGray;
            buttonSave.Location = new Point(0, 0);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(47, 0, 0, 0);
            buttonSave.Size = new Size(255, 55);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.TextAlign = ContentAlignment.MiddleLeft;
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(150, 0, 0);
            buttonSettings.Dock = DockStyle.Top;
            buttonSettings.FlatAppearance.BorderColor = Color.Black;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            buttonSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 0, 0);
            buttonSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 0);
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("MrsEavesSmallCaps", 18F);
            buttonSettings.ForeColor = Color.LightGray;
            buttonSettings.Location = new Point(0, 706);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(13, 0, 0, 0);
            buttonSettings.Size = new Size(255, 70);
            buttonSettings.TabIndex = 9;
            buttonSettings.Text = "Settings";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(150, 0, 0);
            buttonHelp.Dock = DockStyle.Top;
            buttonHelp.FlatAppearance.BorderColor = Color.Black;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            buttonHelp.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 0, 0);
            buttonHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 0);
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("MrsEavesSmallCaps", 18F);
            buttonHelp.ForeColor = Color.LightGray;
            buttonHelp.Location = new Point(0, 636);
            buttonHelp.Margin = new Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Padding = new Padding(13, 0, 0, 0);
            buttonHelp.Size = new Size(255, 70);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "Help";
            buttonHelp.TextAlign = ContentAlignment.MiddleLeft;
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // panelMoneyStrats
            // 
            panelMoneyStrats.BackColor = Color.FromArgb(51, 51, 51);
            panelMoneyStrats.Controls.Add(buttonHervestMemory);
            panelMoneyStrats.Dock = DockStyle.Top;
            panelMoneyStrats.Location = new Point(0, 359);
            panelMoneyStrats.Margin = new Padding(5);
            panelMoneyStrats.Name = "panelMoneyStrats";
            panelMoneyStrats.Size = new Size(255, 277);
            panelMoneyStrats.TabIndex = 4;
            // 
            // buttonHervestMemory
            // 
            buttonHervestMemory.Dock = DockStyle.Top;
            buttonHervestMemory.FlatAppearance.BorderSize = 0;
            buttonHervestMemory.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            buttonHervestMemory.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 11, 11);
            buttonHervestMemory.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 31, 31);
            buttonHervestMemory.FlatStyle = FlatStyle.Flat;
            buttonHervestMemory.Font = new Font("MrsEavesSmallCaps", 12F);
            buttonHervestMemory.ForeColor = Color.LightGray;
            buttonHervestMemory.Location = new Point(0, 0);
            buttonHervestMemory.Margin = new Padding(5);
            buttonHervestMemory.Name = "buttonHervestMemory";
            buttonHervestMemory.Padding = new Padding(47, 0, 0, 0);
            buttonHervestMemory.Size = new Size(255, 55);
            buttonHervestMemory.TabIndex = 2;
            buttonHervestMemory.Text = "Harvest Memory";
            buttonHervestMemory.TextAlign = ContentAlignment.MiddleLeft;
            buttonHervestMemory.UseVisualStyleBackColor = true;
            buttonHervestMemory.Click += buttonHervestMemory_Click;
            // 
            // buttonMoneyStrats
            // 
            buttonMoneyStrats.BackColor = Color.FromArgb(150, 0, 0);
            buttonMoneyStrats.Dock = DockStyle.Top;
            buttonMoneyStrats.FlatAppearance.BorderColor = Color.Black;
            buttonMoneyStrats.FlatAppearance.BorderSize = 0;
            buttonMoneyStrats.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            buttonMoneyStrats.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 0, 0);
            buttonMoneyStrats.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 0);
            buttonMoneyStrats.FlatStyle = FlatStyle.Flat;
            buttonMoneyStrats.Font = new Font("MrsEavesSmallCaps", 18F);
            buttonMoneyStrats.ForeColor = Color.LightGray;
            buttonMoneyStrats.Location = new Point(0, 289);
            buttonMoneyStrats.Margin = new Padding(5);
            buttonMoneyStrats.Name = "buttonMoneyStrats";
            buttonMoneyStrats.Padding = new Padding(13, 0, 0, 0);
            buttonMoneyStrats.Size = new Size(255, 70);
            buttonMoneyStrats.TabIndex = 3;
            buttonMoneyStrats.Text = "Money Strats";
            buttonMoneyStrats.TextAlign = ContentAlignment.MiddleLeft;
            buttonMoneyStrats.UseVisualStyleBackColor = false;
            buttonMoneyStrats.Click += buttonMoneyStrats_Click;
            // 
            // panelPriceChecking
            // 
            panelPriceChecking.BackColor = Color.FromArgb(51, 51, 51);
            panelPriceChecking.Controls.Add(button1);
            panelPriceChecking.Dock = DockStyle.Top;
            panelPriceChecking.Location = new Point(0, 70);
            panelPriceChecking.Margin = new Padding(5);
            panelPriceChecking.Name = "panelPriceChecking";
            panelPriceChecking.Size = new Size(255, 219);
            panelPriceChecking.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 11, 11);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 31, 31);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MrsEavesSmallCaps", 12F);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Padding = new Padding(47, 0, 0, 0);
            button1.Size = new Size(255, 55);
            button1.TabIndex = 7;
            button1.Text = "Items";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonPriceChecking
            // 
            buttonPriceChecking.BackColor = Color.FromArgb(150, 0, 0);
            buttonPriceChecking.Dock = DockStyle.Top;
            buttonPriceChecking.FlatAppearance.BorderColor = Color.Black;
            buttonPriceChecking.FlatAppearance.BorderSize = 0;
            buttonPriceChecking.FlatAppearance.CheckedBackColor = Color.FromArgb(11, 11, 11);
            buttonPriceChecking.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 0, 0);
            buttonPriceChecking.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 0, 0);
            buttonPriceChecking.FlatStyle = FlatStyle.Flat;
            buttonPriceChecking.Font = new Font("MrsEavesSmallCaps", 18F);
            buttonPriceChecking.ForeColor = Color.LightGray;
            buttonPriceChecking.Location = new Point(0, 0);
            buttonPriceChecking.Margin = new Padding(5);
            buttonPriceChecking.Name = "buttonPriceChecking";
            buttonPriceChecking.Padding = new Padding(13, 0, 0, 0);
            buttonPriceChecking.Size = new Size(255, 70);
            buttonPriceChecking.TabIndex = 1;
            buttonPriceChecking.Text = "Price Checking";
            buttonPriceChecking.TextAlign = ContentAlignment.MiddleLeft;
            buttonPriceChecking.UseVisualStyleBackColor = false;
            buttonPriceChecking.Click += buttonPriceChecking_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1677, 877);
            Controls.Add(panelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 300);
            Name = "Main";
            Text = "Price of Exile";
            Load += Form1_Load;
            panelMain.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMenu.ResumeLayout(false);
            panelExit.ResumeLayout(false);
            panelMoneyStrats.ResumeLayout(false);
            panelPriceChecking.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonItemSearch;
        private Button buttonClassAbilitySearch;
        private Button buttonBackgroundSearch;
        private Button buttonSpellSearch;
        private Button buttonExportCharacter;
        private Button buttonRemoveCharacter;
        private Panel panelNewCharacter;
        private Button buttonLoadCharacter;
        private Button buttonCustomCharacter;
        private Button buttonRandomCharacter;
        private Button buttonNewCharacter;
        private Button buttonSelectCharacter;
        private Panel panelMain;
        private Panel panelChildForm;
        private PictureBox pictureBoxLogo;
        private Panel panelMenu;
        private Panel panelExitBorder;
        private Button buttonExit;
        private Panel panelExit;
        private Button buttonExitWithoutSaving;
        private Button buttonSaveAndExit;
        private Button buttonSave;
        private Button buttonSettings;
        private Button buttonHelp;
        private Panel panelMoneyStrats;
        private Button buttonHervestMemory;
        private Button buttonMoneyStrats;
        private Panel panelPriceChecking;
        private Button button1;
        private Button buttonPriceChecking;
    }
}
