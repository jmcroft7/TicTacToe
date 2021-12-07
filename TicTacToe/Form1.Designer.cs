namespace TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xwins = new System.Windows.Forms.Label();
            this.drawwins = new System.Windows.Forms.Label();
            this.owins = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a1.Location = new System.Drawing.Point(24, 40);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 75);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.buttonClick);
            this.a1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.a1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(24, 121);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 2;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.buttonClick);
            this.b1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.b1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c1.Location = new System.Drawing.Point(24, 202);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 75);
            this.c1.TabIndex = 3;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.buttonClick);
            this.c1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.c1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c2.Location = new System.Drawing.Point(105, 202);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 75);
            this.c2.TabIndex = 6;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.buttonClick);
            this.c2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.c2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b2.Location = new System.Drawing.Point(105, 121);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 5;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.buttonClick);
            this.b2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.b2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a2.Location = new System.Drawing.Point(105, 40);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 75);
            this.a2.TabIndex = 4;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.buttonClick);
            this.a2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.a2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c3.Location = new System.Drawing.Point(186, 202);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 75);
            this.c3.TabIndex = 9;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.buttonClick);
            this.c3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.c3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b3.Location = new System.Drawing.Point(186, 121);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 8;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.buttonClick);
            this.b3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.b3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a3.Location = new System.Drawing.Point(186, 40);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 75);
            this.a3.TabIndex = 7;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.buttonClick);
            this.a3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.a3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "X Wincount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Drawcount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(186, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "O Wincount";
            // 
            // xwins
            // 
            this.xwins.AutoSize = true;
            this.xwins.Location = new System.Drawing.Point(55, 316);
            this.xwins.Name = "xwins";
            this.xwins.Size = new System.Drawing.Size(13, 15);
            this.xwins.TabIndex = 15;
            this.xwins.Text = "0";
            // 
            // drawwins
            // 
            this.drawwins.AutoSize = true;
            this.drawwins.Location = new System.Drawing.Point(133, 316);
            this.drawwins.Name = "drawwins";
            this.drawwins.Size = new System.Drawing.Size(13, 15);
            this.drawwins.TabIndex = 16;
            this.drawwins.Text = "0";
            // 
            // owins
            // 
            this.owins.AutoSize = true;
            this.owins.Location = new System.Drawing.Point(219, 316);
            this.owins.Name = "owins";
            this.owins.Size = new System.Drawing.Size(13, 15);
            this.owins.TabIndex = 17;
            this.owins.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 340);
            this.Controls.Add(this.owins);
            this.Controls.Add(this.drawwins);
            this.Controls.Add(this.xwins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button a1;
        private Button b1;
        private Button c1;
        private Button c2;
        private Button b2;
        private Button a2;
        private Button c3;
        private Button b3;
        private Button a3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label xwins;
        private Label drawwins;
        private Label owins;
        private ToolStripMenuItem resetToolStripMenuItem;
    }
}