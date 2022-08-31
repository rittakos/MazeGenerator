namespace MazeGenerator
{
    partial class Form1
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
            this.settings_menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generate_button = new System.Windows.Forms.Button();
            this.algoritmRandom_radioButton = new System.Windows.Forms.RadioButton();
            this.kruskal_radioButton = new System.Windows.Forms.RadioButton();
            this.settings_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_menuStrip
            // 
            this.settings_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.settings_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.settings_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.settings_menuStrip.Name = "settings_menuStrip";
            this.settings_menuStrip.Size = new System.Drawing.Size(800, 29);
            this.settings_menuStrip.TabIndex = 0;
            this.settings_menuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(61, 46);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(114, 44);
            this.generate_button.TabIndex = 1;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            // 
            // algoritmRandom_radioButton
            // 
            this.algoritmRandom_radioButton.AutoSize = true;
            this.algoritmRandom_radioButton.Location = new System.Drawing.Point(20, 96);
            this.algoritmRandom_radioButton.Name = "algoritmRandom_radioButton";
            this.algoritmRandom_radioButton.Size = new System.Drawing.Size(90, 25);
            this.algoritmRandom_radioButton.TabIndex = 2;
            this.algoritmRandom_radioButton.TabStop = true;
            this.algoritmRandom_radioButton.Text = "Random";
            this.algoritmRandom_radioButton.UseVisualStyleBackColor = true;
            // 
            // kruskal_radioButton
            // 
            this.kruskal_radioButton.AutoSize = true;
            this.kruskal_radioButton.Location = new System.Drawing.Point(128, 96);
            this.kruskal_radioButton.Name = "kruskal_radioButton";
            this.kruskal_radioButton.Size = new System.Drawing.Size(82, 25);
            this.kruskal_radioButton.TabIndex = 3;
            this.kruskal_radioButton.TabStop = true;
            this.kruskal_radioButton.Text = "Kruskal";
            this.kruskal_radioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kruskal_radioButton);
            this.Controls.Add(this.algoritmRandom_radioButton);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.settings_menuStrip);
            this.MainMenuStrip = this.settings_menuStrip;
            this.Name = "Form1";
            this.Text = "Maze Generator";
            this.settings_menuStrip.ResumeLayout(false);
            this.settings_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip settings_menuStrip;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private Button generate_button;
        private RadioButton algoritmRandom_radioButton;
        private RadioButton kruskal_radioButton;
    }
}