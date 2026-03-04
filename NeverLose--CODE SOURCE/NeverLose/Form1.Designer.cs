namespace NeverLose
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Inject;
            System.Windows.Forms.Button Kill_Roblox;
            this.Execute = new System.Windows.Forms.Button();
            this.ScriptTextBox = new System.Windows.Forms.RichTextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.OpenDecompiler = new System.Windows.Forms.Button();
            this.FixRobloxVersion = new System.Windows.Forms.Button();
            this.Spoofer = new System.Windows.Forms.Button();
            this.Dex = new System.Windows.Forms.Button();
            this.InfiniteYield = new System.Windows.Forms.Button();
            this.RemoteSpy = new System.Windows.Forms.Button();
            this.NeverLose = new System.Windows.Forms.Button();
            Inject = new System.Windows.Forms.Button();
            Kill_Roblox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inject
            // 
            Inject.BackColor = System.Drawing.SystemColors.Control;
            Inject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            Inject.Location = new System.Drawing.Point(597, 30);
            Inject.Name = "Inject";
            Inject.Size = new System.Drawing.Size(191, 49);
            Inject.TabIndex = 0;
            Inject.Text = "Inject the .dll";
            Inject.UseVisualStyleBackColor = false;
            Inject.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kill_Roblox
            // 
            Kill_Roblox.BackColor = System.Drawing.SystemColors.Control;
            Kill_Roblox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            Kill_Roblox.Location = new System.Drawing.Point(597, 195);
            Kill_Roblox.Name = "Kill_Roblox";
            Kill_Roblox.Size = new System.Drawing.Size(191, 49);
            Kill_Roblox.TabIndex = 3;
            Kill_Roblox.Text = "Kill Roblox";
            Kill_Roblox.UseVisualStyleBackColor = false;
            Kill_Roblox.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.SystemColors.Control;
            this.Execute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Execute.Location = new System.Drawing.Point(597, 85);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(191, 49);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Execute ";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(12, 30);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Size = new System.Drawing.Size(552, 291);
            this.ScriptTextBox.TabIndex = 5;
            this.ScriptTextBox.Text = "";
            this.ScriptTextBox.TextChanged += new System.EventHandler(this.richTextBox1);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Control;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Clear.Location = new System.Drawing.Point(597, 140);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(191, 49);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // OpenDecompiler
            // 
            this.OpenDecompiler.BackColor = System.Drawing.SystemColors.Control;
            this.OpenDecompiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenDecompiler.Location = new System.Drawing.Point(597, 250);
            this.OpenDecompiler.Name = "OpenDecompiler";
            this.OpenDecompiler.Size = new System.Drawing.Size(191, 49);
            this.OpenDecompiler.TabIndex = 6;
            this.OpenDecompiler.Text = "Open Decompiler";
            this.OpenDecompiler.UseVisualStyleBackColor = false;
            this.OpenDecompiler.Click += new System.EventHandler(this.OpenDecompiler_Click);
            // 
            // FixRobloxVersion
            // 
            this.FixRobloxVersion.BackColor = System.Drawing.SystemColors.Control;
            this.FixRobloxVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FixRobloxVersion.Location = new System.Drawing.Point(597, 305);
            this.FixRobloxVersion.Name = "FixRobloxVersion";
            this.FixRobloxVersion.Size = new System.Drawing.Size(191, 49);
            this.FixRobloxVersion.TabIndex = 7;
            this.FixRobloxVersion.Text = "Fix \"Version mismatch\" error";
            this.FixRobloxVersion.UseVisualStyleBackColor = false;
            this.FixRobloxVersion.Click += new System.EventHandler(this.FixRobloxVersion_Click);
            // 
            // Spoofer
            // 
            this.Spoofer.BackColor = System.Drawing.SystemColors.Control;
            this.Spoofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Spoofer.Location = new System.Drawing.Point(597, 360);
            this.Spoofer.Name = "Spoofer";
            this.Spoofer.Size = new System.Drawing.Size(191, 49);
            this.Spoofer.TabIndex = 8;
            this.Spoofer.Text = "Open Spoofer";
            this.Spoofer.UseVisualStyleBackColor = false;
            this.Spoofer.Click += new System.EventHandler(this.Spoofer_Click);
            // 
            // Dex
            // 
            this.Dex.BackColor = System.Drawing.SystemColors.Control;
            this.Dex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dex.Location = new System.Drawing.Point(12, 327);
            this.Dex.Name = "Dex";
            this.Dex.Size = new System.Drawing.Size(191, 49);
            this.Dex.TabIndex = 9;
            this.Dex.Text = "Dex";
            this.Dex.UseVisualStyleBackColor = false;
            this.Dex.Click += new System.EventHandler(this.Dex_Click);
            // 
            // InfiniteYield
            // 
            this.InfiniteYield.BackColor = System.Drawing.SystemColors.Control;
            this.InfiniteYield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InfiniteYield.Location = new System.Drawing.Point(209, 327);
            this.InfiniteYield.Name = "InfiniteYield";
            this.InfiniteYield.Size = new System.Drawing.Size(191, 49);
            this.InfiniteYield.TabIndex = 10;
            this.InfiniteYield.Text = "Infinite Yield";
            this.InfiniteYield.UseVisualStyleBackColor = false;
            this.InfiniteYield.Click += new System.EventHandler(this.InfiniteYield_Click);
            // 
            // RemoteSpy
            // 
            this.RemoteSpy.BackColor = System.Drawing.SystemColors.Control;
            this.RemoteSpy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoteSpy.Location = new System.Drawing.Point(12, 382);
            this.RemoteSpy.Name = "RemoteSpy";
            this.RemoteSpy.Size = new System.Drawing.Size(191, 41);
            this.RemoteSpy.TabIndex = 11;
            this.RemoteSpy.Text = "Remote Spy(Cobalt)";
            this.RemoteSpy.UseVisualStyleBackColor = false;
            this.RemoteSpy.Click += new System.EventHandler(this.RemoteSpy_Click);
            // 
            // NeverLose
            // 
            this.NeverLose.BackColor = System.Drawing.SystemColors.Control;
            this.NeverLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NeverLose.Location = new System.Drawing.Point(209, 382);
            this.NeverLose.Name = "NeverLose";
            this.NeverLose.Size = new System.Drawing.Size(191, 41);
            this.NeverLose.TabIndex = 12;
            this.NeverLose.Text = "Never Lose Script";
            this.NeverLose.UseVisualStyleBackColor = false;
            this.NeverLose.Click += new System.EventHandler(this.NeverLose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.NeverLose);
            this.Controls.Add(this.RemoteSpy);
            this.Controls.Add(this.InfiniteYield);
            this.Controls.Add(this.Dex);
            this.Controls.Add(this.Spoofer);
            this.Controls.Add(this.FixRobloxVersion);
            this.Controls.Add(this.OpenDecompiler);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.Clear);
            this.Controls.Add(Kill_Roblox);
            this.Controls.Add(this.Execute);
            this.Controls.Add(Inject);
            this.Name = "Form1";
            this.Text = "NEVER LOSE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.RichTextBox ScriptTextBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button OpenDecompiler;
        private System.Windows.Forms.Button FixRobloxVersion;
        private System.Windows.Forms.Button Spoofer;
        private System.Windows.Forms.Button Dex;
        private System.Windows.Forms.Button InfiniteYield;
        private System.Windows.Forms.Button RemoteSpy;
        private System.Windows.Forms.Button NeverLose;
    }
}

