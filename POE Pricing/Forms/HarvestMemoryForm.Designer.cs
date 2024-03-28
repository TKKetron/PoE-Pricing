namespace POE_Pricing
{
    partial class HarvestMemoryForm
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
            components = new System.ComponentModel.Container();
            checkBoxVividVulture = new CheckBox();
            checkBoxPrimalCrushclaw = new CheckBox();
            checkBoxPrimalCystcaller = new CheckBox();
            checkBoxPrimalRhexMatriarch = new CheckBox();
            checkBoxWildBrambleback = new CheckBox();
            checkBoxWildHellionAlpha = new CheckBox();
            checkBoxWildBristleMatron = new CheckBox();
            checkBoxVividAbberach = new CheckBox();
            checkBoxVividWatcher = new CheckBox();
            labelHostProfitMem = new Label();
            labelPerPlayerProfitMem = new Label();
            labelHostProfitOutputMem = new Label();
            labelPerPlayerProfitOutputMem = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelHarvest = new Panel();
            labelPerHour = new Label();
            labelPerMem = new Label();
            labelTotalProfitOutputHr = new Label();
            labelTotalProfitHr = new Label();
            labelPlayerProfitOutputHr = new Label();
            labelPlayerProfitHr = new Label();
            labelPerPlayerProfitOutputHr = new Label();
            labelHostProfitOutputHr = new Label();
            labelPerPlayerProfitHr = new Label();
            labelHostProfitHr = new Label();
            panel1 = new Panel();
            checkBoxUseDivine = new CheckBox();
            labelTimePerMemory = new Label();
            numericUpDownTimePerMemory = new NumericUpDown();
            labelExtraPlayers = new Label();
            numericUpDownExtraPlayers = new NumericUpDown();
            labelTotalProfitOutputMem = new Label();
            labelTotalProfitMem = new Label();
            labelPlayerProfitOutputMem = new Label();
            labelPlayerProfitMem = new Label();
            panelHarvest.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimePerMemory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExtraPlayers).BeginInit();
            SuspendLayout();
            // 
            // checkBoxVividVulture
            // 
            checkBoxVividVulture.AutoSize = true;
            checkBoxVividVulture.Location = new Point(31, 23);
            checkBoxVividVulture.Name = "checkBoxVividVulture";
            checkBoxVividVulture.Size = new Size(93, 19);
            checkBoxVividVulture.TabIndex = 0;
            checkBoxVividVulture.Tag = "0";
            checkBoxVividVulture.Text = "Vivid Vulture";
            checkBoxVividVulture.UseVisualStyleBackColor = true;
            checkBoxVividVulture.CheckedChanged += UpdateValues;
            // 
            // checkBoxPrimalCrushclaw
            // 
            checkBoxPrimalCrushclaw.AutoSize = true;
            checkBoxPrimalCrushclaw.Location = new Point(31, 223);
            checkBoxPrimalCrushclaw.Name = "checkBoxPrimalCrushclaw";
            checkBoxPrimalCrushclaw.Size = new Size(118, 19);
            checkBoxPrimalCrushclaw.TabIndex = 1;
            checkBoxPrimalCrushclaw.Tag = "8";
            checkBoxPrimalCrushclaw.Text = "Primal Crushclaw";
            checkBoxPrimalCrushclaw.UseVisualStyleBackColor = true;
            checkBoxPrimalCrushclaw.CheckedChanged += UpdateValues;
            // 
            // checkBoxPrimalCystcaller
            // 
            checkBoxPrimalCystcaller.AutoSize = true;
            checkBoxPrimalCystcaller.Location = new Point(31, 198);
            checkBoxPrimalCystcaller.Name = "checkBoxPrimalCystcaller";
            checkBoxPrimalCystcaller.Size = new Size(114, 19);
            checkBoxPrimalCystcaller.TabIndex = 2;
            checkBoxPrimalCystcaller.Tag = "7";
            checkBoxPrimalCystcaller.Text = "Primal Cystcaller";
            checkBoxPrimalCystcaller.UseVisualStyleBackColor = true;
            checkBoxPrimalCystcaller.CheckedChanged += UpdateValues;
            // 
            // checkBoxPrimalRhexMatriarch
            // 
            checkBoxPrimalRhexMatriarch.AutoSize = true;
            checkBoxPrimalRhexMatriarch.Location = new Point(31, 173);
            checkBoxPrimalRhexMatriarch.Name = "checkBoxPrimalRhexMatriarch";
            checkBoxPrimalRhexMatriarch.Size = new Size(143, 19);
            checkBoxPrimalRhexMatriarch.TabIndex = 3;
            checkBoxPrimalRhexMatriarch.Tag = "6";
            checkBoxPrimalRhexMatriarch.Text = "Primal Rhex Matriarch";
            checkBoxPrimalRhexMatriarch.UseVisualStyleBackColor = true;
            checkBoxPrimalRhexMatriarch.CheckedChanged += UpdateValues;
            // 
            // checkBoxWildBrambleback
            // 
            checkBoxWildBrambleback.AutoSize = true;
            checkBoxWildBrambleback.Location = new Point(31, 148);
            checkBoxWildBrambleback.Name = "checkBoxWildBrambleback";
            checkBoxWildBrambleback.Size = new Size(122, 19);
            checkBoxWildBrambleback.TabIndex = 4;
            checkBoxWildBrambleback.Tag = "5";
            checkBoxWildBrambleback.Text = "Wild Brambleback";
            checkBoxWildBrambleback.UseVisualStyleBackColor = true;
            checkBoxWildBrambleback.CheckedChanged += UpdateValues;
            // 
            // checkBoxWildHellionAlpha
            // 
            checkBoxWildHellionAlpha.AutoSize = true;
            checkBoxWildHellionAlpha.Location = new Point(31, 123);
            checkBoxWildHellionAlpha.Name = "checkBoxWildHellionAlpha";
            checkBoxWildHellionAlpha.Size = new Size(125, 19);
            checkBoxWildHellionAlpha.TabIndex = 5;
            checkBoxWildHellionAlpha.Tag = "4";
            checkBoxWildHellionAlpha.Text = "Wild Hellion Alpha";
            checkBoxWildHellionAlpha.UseVisualStyleBackColor = true;
            checkBoxWildHellionAlpha.CheckedChanged += UpdateValues;
            // 
            // checkBoxWildBristleMatron
            // 
            checkBoxWildBristleMatron.AutoSize = true;
            checkBoxWildBristleMatron.Location = new Point(31, 98);
            checkBoxWildBristleMatron.Name = "checkBoxWildBristleMatron";
            checkBoxWildBristleMatron.Size = new Size(127, 19);
            checkBoxWildBristleMatron.TabIndex = 6;
            checkBoxWildBristleMatron.Tag = "3";
            checkBoxWildBristleMatron.Text = "Wild Bristle Matron";
            checkBoxWildBristleMatron.UseVisualStyleBackColor = true;
            checkBoxWildBristleMatron.CheckedChanged += UpdateValues;
            // 
            // checkBoxVividAbberach
            // 
            checkBoxVividAbberach.AutoSize = true;
            checkBoxVividAbberach.Location = new Point(31, 73);
            checkBoxVividAbberach.Name = "checkBoxVividAbberach";
            checkBoxVividAbberach.Size = new Size(106, 19);
            checkBoxVividAbberach.TabIndex = 7;
            checkBoxVividAbberach.Tag = "2";
            checkBoxVividAbberach.Text = "Vivid Abberach";
            checkBoxVividAbberach.UseVisualStyleBackColor = true;
            checkBoxVividAbberach.CheckedChanged += UpdateValues;
            // 
            // checkBoxVividWatcher
            // 
            checkBoxVividWatcher.AutoSize = true;
            checkBoxVividWatcher.Location = new Point(31, 48);
            checkBoxVividWatcher.Name = "checkBoxVividWatcher";
            checkBoxVividWatcher.Size = new Size(99, 19);
            checkBoxVividWatcher.TabIndex = 8;
            checkBoxVividWatcher.Tag = "1";
            checkBoxVividWatcher.Text = "Vivid Watcher";
            checkBoxVividWatcher.UseVisualStyleBackColor = true;
            checkBoxVividWatcher.CheckedChanged += UpdateValues;
            // 
            // labelHostProfitMem
            // 
            labelHostProfitMem.AutoSize = true;
            labelHostProfitMem.Location = new Point(330, 77);
            labelHostProfitMem.Name = "labelHostProfitMem";
            labelHostProfitMem.Size = new Size(64, 15);
            labelHostProfitMem.TabIndex = 10;
            labelHostProfitMem.Text = "Host Profit";
            // 
            // labelPerPlayerProfitMem
            // 
            labelPerPlayerProfitMem.AutoSize = true;
            labelPerPlayerProfitMem.Location = new Point(330, 152);
            labelPerPlayerProfitMem.Name = "labelPerPlayerProfitMem";
            labelPerPlayerProfitMem.Size = new Size(91, 15);
            labelPerPlayerProfitMem.TabIndex = 11;
            labelPerPlayerProfitMem.Text = "Per Player Profit";
            // 
            // labelHostProfitOutputMem
            // 
            labelHostProfitOutputMem.BackColor = SystemColors.Window;
            labelHostProfitOutputMem.BorderStyle = BorderStyle.FixedSingle;
            labelHostProfitOutputMem.Location = new Point(330, 98);
            labelHostProfitOutputMem.Name = "labelHostProfitOutputMem";
            labelHostProfitOutputMem.Size = new Size(100, 23);
            labelHostProfitOutputMem.TabIndex = 12;
            labelHostProfitOutputMem.Text = "0.00";
            labelHostProfitOutputMem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPerPlayerProfitOutputMem
            // 
            labelPerPlayerProfitOutputMem.BackColor = SystemColors.Window;
            labelPerPlayerProfitOutputMem.BorderStyle = BorderStyle.FixedSingle;
            labelPerPlayerProfitOutputMem.Location = new Point(330, 173);
            labelPerPlayerProfitOutputMem.Margin = new Padding(3);
            labelPerPlayerProfitOutputMem.Name = "labelPerPlayerProfitOutputMem";
            labelPerPlayerProfitOutputMem.Size = new Size(100, 23);
            labelPerPlayerProfitOutputMem.TabIndex = 13;
            labelPerPlayerProfitOutputMem.Text = "0.00";
            labelPerPlayerProfitOutputMem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelHarvest
            // 
            panelHarvest.Controls.Add(labelPerHour);
            panelHarvest.Controls.Add(labelPerMem);
            panelHarvest.Controls.Add(labelTotalProfitOutputHr);
            panelHarvest.Controls.Add(labelTotalProfitHr);
            panelHarvest.Controls.Add(labelPlayerProfitOutputHr);
            panelHarvest.Controls.Add(labelPlayerProfitHr);
            panelHarvest.Controls.Add(labelPerPlayerProfitOutputHr);
            panelHarvest.Controls.Add(labelHostProfitOutputHr);
            panelHarvest.Controls.Add(labelPerPlayerProfitHr);
            panelHarvest.Controls.Add(labelHostProfitHr);
            panelHarvest.Controls.Add(panel1);
            panelHarvest.Controls.Add(labelTimePerMemory);
            panelHarvest.Controls.Add(numericUpDownTimePerMemory);
            panelHarvest.Controls.Add(labelExtraPlayers);
            panelHarvest.Controls.Add(numericUpDownExtraPlayers);
            panelHarvest.Controls.Add(labelTotalProfitOutputMem);
            panelHarvest.Controls.Add(labelTotalProfitMem);
            panelHarvest.Controls.Add(labelPlayerProfitOutputMem);
            panelHarvest.Controls.Add(labelPlayerProfitMem);
            panelHarvest.Controls.Add(checkBoxVividVulture);
            panelHarvest.Controls.Add(checkBoxPrimalCrushclaw);
            panelHarvest.Controls.Add(labelPerPlayerProfitOutputMem);
            panelHarvest.Controls.Add(checkBoxPrimalCystcaller);
            panelHarvest.Controls.Add(labelHostProfitOutputMem);
            panelHarvest.Controls.Add(checkBoxPrimalRhexMatriarch);
            panelHarvest.Controls.Add(labelPerPlayerProfitMem);
            panelHarvest.Controls.Add(checkBoxWildBrambleback);
            panelHarvest.Controls.Add(labelHostProfitMem);
            panelHarvest.Controls.Add(checkBoxWildHellionAlpha);
            panelHarvest.Controls.Add(checkBoxVividWatcher);
            panelHarvest.Controls.Add(checkBoxWildBristleMatron);
            panelHarvest.Controls.Add(checkBoxVividAbberach);
            panelHarvest.Dock = DockStyle.Fill;
            panelHarvest.Location = new Point(0, 0);
            panelHarvest.Name = "panelHarvest";
            panelHarvest.Size = new Size(1405, 877);
            panelHarvest.TabIndex = 14;
            // 
            // labelPerHour
            // 
            labelPerHour.AutoSize = true;
            labelPerHour.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPerHour.Location = new Point(690, 23);
            labelPerHour.Name = "labelPerHour";
            labelPerHour.Size = new Size(66, 20);
            labelPerHour.TabIndex = 35;
            labelPerHour.Text = "Per Hour";
            // 
            // labelPerMem
            // 
            labelPerMem.AutoSize = true;
            labelPerMem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPerMem.Location = new Point(330, 23);
            labelPerMem.Name = "labelPerMem";
            labelPerMem.Size = new Size(88, 20);
            labelPerMem.TabIndex = 34;
            labelPerMem.Text = "Per Memory";
            // 
            // labelTotalProfitOutputHr
            // 
            labelTotalProfitOutputHr.BackColor = SystemColors.Window;
            labelTotalProfitOutputHr.BorderStyle = BorderStyle.FixedSingle;
            labelTotalProfitOutputHr.Location = new Point(690, 323);
            labelTotalProfitOutputHr.Margin = new Padding(3);
            labelTotalProfitOutputHr.Name = "labelTotalProfitOutputHr";
            labelTotalProfitOutputHr.Size = new Size(100, 23);
            labelTotalProfitOutputHr.TabIndex = 33;
            labelTotalProfitOutputHr.Text = "0.00";
            labelTotalProfitOutputHr.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalProfitHr
            // 
            labelTotalProfitHr.AutoSize = true;
            labelTotalProfitHr.Location = new Point(690, 302);
            labelTotalProfitHr.Name = "labelTotalProfitHr";
            labelTotalProfitHr.Size = new Size(64, 15);
            labelTotalProfitHr.TabIndex = 32;
            labelTotalProfitHr.Text = "Total Profit";
            // 
            // labelPlayerProfitOutputHr
            // 
            labelPlayerProfitOutputHr.BackColor = SystemColors.Window;
            labelPlayerProfitOutputHr.BorderStyle = BorderStyle.FixedSingle;
            labelPlayerProfitOutputHr.Location = new Point(690, 248);
            labelPlayerProfitOutputHr.Margin = new Padding(3);
            labelPlayerProfitOutputHr.Name = "labelPlayerProfitOutputHr";
            labelPlayerProfitOutputHr.Size = new Size(100, 23);
            labelPlayerProfitOutputHr.TabIndex = 31;
            labelPlayerProfitOutputHr.Text = "0.00";
            labelPlayerProfitOutputHr.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPlayerProfitHr
            // 
            labelPlayerProfitHr.AutoSize = true;
            labelPlayerProfitHr.Location = new Point(690, 227);
            labelPlayerProfitHr.Name = "labelPlayerProfitHr";
            labelPlayerProfitHr.Size = new Size(71, 15);
            labelPlayerProfitHr.TabIndex = 30;
            labelPlayerProfitHr.Text = "Player Profit";
            // 
            // labelPerPlayerProfitOutputHr
            // 
            labelPerPlayerProfitOutputHr.BackColor = SystemColors.Window;
            labelPerPlayerProfitOutputHr.BorderStyle = BorderStyle.FixedSingle;
            labelPerPlayerProfitOutputHr.Location = new Point(690, 173);
            labelPerPlayerProfitOutputHr.Margin = new Padding(3);
            labelPerPlayerProfitOutputHr.Name = "labelPerPlayerProfitOutputHr";
            labelPerPlayerProfitOutputHr.Size = new Size(100, 23);
            labelPerPlayerProfitOutputHr.TabIndex = 29;
            labelPerPlayerProfitOutputHr.Text = "0.00";
            labelPerPlayerProfitOutputHr.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelHostProfitOutputHr
            // 
            labelHostProfitOutputHr.BackColor = SystemColors.Window;
            labelHostProfitOutputHr.BorderStyle = BorderStyle.FixedSingle;
            labelHostProfitOutputHr.Location = new Point(690, 98);
            labelHostProfitOutputHr.Name = "labelHostProfitOutputHr";
            labelHostProfitOutputHr.Size = new Size(100, 23);
            labelHostProfitOutputHr.TabIndex = 28;
            labelHostProfitOutputHr.Text = "0.00";
            labelHostProfitOutputHr.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPerPlayerProfitHr
            // 
            labelPerPlayerProfitHr.AutoSize = true;
            labelPerPlayerProfitHr.Location = new Point(690, 152);
            labelPerPlayerProfitHr.Name = "labelPerPlayerProfitHr";
            labelPerPlayerProfitHr.Size = new Size(91, 15);
            labelPerPlayerProfitHr.TabIndex = 27;
            labelPerPlayerProfitHr.Text = "Per Player Profit";
            // 
            // labelHostProfitHr
            // 
            labelHostProfitHr.AutoSize = true;
            labelHostProfitHr.Location = new Point(690, 77);
            labelHostProfitHr.Name = "labelHostProfitHr";
            labelHostProfitHr.Size = new Size(64, 15);
            labelHostProfitHr.TabIndex = 26;
            labelHostProfitHr.Text = "Host Profit";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxUseDivine);
            panel1.Location = new Point(1333, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 50);
            panel1.TabIndex = 25;
            // 
            // checkBoxUseDivine
            // 
            checkBoxUseDivine.Appearance = Appearance.Button;
            checkBoxUseDivine.AutoSize = true;
            checkBoxUseDivine.BackColor = Color.Transparent;
            checkBoxUseDivine.Dock = DockStyle.Fill;
            checkBoxUseDivine.ForeColor = Color.Transparent;
            checkBoxUseDivine.Location = new Point(0, 0);
            checkBoxUseDivine.Name = "checkBoxUseDivine";
            checkBoxUseDivine.Size = new Size(50, 50);
            checkBoxUseDivine.TabIndex = 26;
            checkBoxUseDivine.UseVisualStyleBackColor = false;
            checkBoxUseDivine.CheckedChanged += checkBoxUseDivine_CheckedChanged;
            // 
            // labelTimePerMemory
            // 
            labelTimePerMemory.AutoSize = true;
            labelTimePerMemory.Location = new Point(501, 98);
            labelTimePerMemory.Name = "labelTimePerMemory";
            labelTimePerMemory.Size = new Size(101, 15);
            labelTimePerMemory.TabIndex = 21;
            labelTimePerMemory.Text = "Time Per Memory";
            // 
            // numericUpDownTimePerMemory
            // 
            numericUpDownTimePerMemory.DecimalPlaces = 1;
            numericUpDownTimePerMemory.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDownTimePerMemory.Location = new Point(501, 119);
            numericUpDownTimePerMemory.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownTimePerMemory.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDownTimePerMemory.Name = "numericUpDownTimePerMemory";
            numericUpDownTimePerMemory.Size = new Size(120, 23);
            numericUpDownTimePerMemory.TabIndex = 20;
            numericUpDownTimePerMemory.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDownTimePerMemory.ValueChanged += UpdateValues;
            // 
            // labelExtraPlayers
            // 
            labelExtraPlayers.AutoSize = true;
            labelExtraPlayers.Location = new Point(501, 23);
            labelExtraPlayers.Name = "labelExtraPlayers";
            labelExtraPlayers.Size = new Size(73, 15);
            labelExtraPlayers.TabIndex = 19;
            labelExtraPlayers.Text = "Extra Players";
            // 
            // numericUpDownExtraPlayers
            // 
            numericUpDownExtraPlayers.Location = new Point(501, 44);
            numericUpDownExtraPlayers.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownExtraPlayers.Name = "numericUpDownExtraPlayers";
            numericUpDownExtraPlayers.Size = new Size(120, 23);
            numericUpDownExtraPlayers.TabIndex = 18;
            numericUpDownExtraPlayers.ValueChanged += UpdateValues;
            // 
            // labelTotalProfitOutputMem
            // 
            labelTotalProfitOutputMem.BackColor = SystemColors.Window;
            labelTotalProfitOutputMem.BorderStyle = BorderStyle.FixedSingle;
            labelTotalProfitOutputMem.Location = new Point(330, 323);
            labelTotalProfitOutputMem.Margin = new Padding(3);
            labelTotalProfitOutputMem.Name = "labelTotalProfitOutputMem";
            labelTotalProfitOutputMem.Size = new Size(100, 23);
            labelTotalProfitOutputMem.TabIndex = 17;
            labelTotalProfitOutputMem.Text = "0.00";
            labelTotalProfitOutputMem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalProfitMem
            // 
            labelTotalProfitMem.AutoSize = true;
            labelTotalProfitMem.Location = new Point(330, 302);
            labelTotalProfitMem.Name = "labelTotalProfitMem";
            labelTotalProfitMem.Size = new Size(64, 15);
            labelTotalProfitMem.TabIndex = 16;
            labelTotalProfitMem.Text = "Total Profit";
            // 
            // labelPlayerProfitOutputMem
            // 
            labelPlayerProfitOutputMem.BackColor = SystemColors.Window;
            labelPlayerProfitOutputMem.BorderStyle = BorderStyle.FixedSingle;
            labelPlayerProfitOutputMem.Location = new Point(330, 248);
            labelPlayerProfitOutputMem.Margin = new Padding(3);
            labelPlayerProfitOutputMem.Name = "labelPlayerProfitOutputMem";
            labelPlayerProfitOutputMem.Size = new Size(100, 23);
            labelPlayerProfitOutputMem.TabIndex = 15;
            labelPlayerProfitOutputMem.Text = "0.00";
            labelPlayerProfitOutputMem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPlayerProfitMem
            // 
            labelPlayerProfitMem.AutoSize = true;
            labelPlayerProfitMem.Location = new Point(330, 227);
            labelPlayerProfitMem.Name = "labelPlayerProfitMem";
            labelPlayerProfitMem.Size = new Size(71, 15);
            labelPlayerProfitMem.TabIndex = 14;
            labelPlayerProfitMem.Text = "Player Profit";
            // 
            // HarvestMemoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 877);
            Controls.Add(panelHarvest);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HarvestMemoryForm";
            Text = "HarvestMemoryForm";
            Load += HarvestMemoryForm_Load;
            panelHarvest.ResumeLayout(false);
            panelHarvest.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimePerMemory).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExtraPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBoxVividVulture;
        private CheckBox checkBoxPrimalCrushclaw;
        private CheckBox checkBoxPrimalCystcaller;
        private CheckBox checkBoxPrimalRhexMatriarch;
        private CheckBox checkBoxWildBrambleback;
        private CheckBox checkBoxWildHellionAlpha;
        private CheckBox checkBoxWildBristleMatron;
        private CheckBox checkBoxVividAbberach;
        private CheckBox checkBoxVividWatcher;
        private Label labelHostProfitMem;
        private Label labelPerPlayerProfitMem;
        private Label labelHostProfitOutputMem;
        private Label labelPerPlayerProfitOutputMem;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelHarvest;
        private Label labelPlayerProfitOutputMem;
        private Label labelPlayerProfitMem;
        private NumericUpDown numericUpDownExtraPlayers;
        private Label labelTotalProfitOutputMem;
        private Label labelTotalProfitMem;
        private Label labelExtraPlayers;
        private Label labelTimePerMemory;
        private NumericUpDown numericUpDownTimePerMemory;
        private Panel panel1;
        private CheckBox checkBoxUseDivine;
        private Label labelPerHour;
        private Label labelPerMem;
        private Label labelTotalProfitOutputHr;
        private Label labelTotalProfitHr;
        private Label labelPlayerProfitOutputHr;
        private Label labelPlayerProfitHr;
        private Label labelPerPlayerProfitOutputHr;
        private Label labelHostProfitOutputHr;
        private Label labelPerPlayerProfitHr;
        private Label labelHostProfitHr;
    }
}