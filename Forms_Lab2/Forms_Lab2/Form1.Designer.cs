namespace Forms_Lab2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openF3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savaF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renoCtrlShiftNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.picDrawingSurface = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picDrawingSurface)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.fileToolStripMenuItem, this.editToolStripMenuItem, this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.newToolStripMenuItem, this.openF3ToolStripMenuItem, this.savaF2ToolStripMenuItem,
                this.exitAltXToolStripMenuItem
            });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.undoCtrlZToolStripMenuItem, this.renoCtrlShiftNToolStripMenuItem, this.penToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Forms_Lab2.Properties.Resources._new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.CreateNewFile);
            // 
            // openF3ToolStripMenuItem
            // 
            this.openF3ToolStripMenuItem.Image = global::Forms_Lab2.Properties.Resources.open;
            this.openF3ToolStripMenuItem.Name = "openF3ToolStripMenuItem";
            this.openF3ToolStripMenuItem.ShortcutKeyDisplayString = "F3";
            this.openF3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openF3ToolStripMenuItem.Text = "Open";
            this.openF3ToolStripMenuItem.Click += new System.EventHandler(this.FileOpen);
            // 
            // savaF2ToolStripMenuItem
            // 
            this.savaF2ToolStripMenuItem.Image = global::Forms_Lab2.Properties.Resources.save;
            this.savaF2ToolStripMenuItem.Name = "savaF2ToolStripMenuItem";
            this.savaF2ToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.savaF2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.savaF2ToolStripMenuItem.Text = "Save";
            this.savaF2ToolStripMenuItem.Click += new System.EventHandler(this.SaveFileAs);
            // 
            // exitAltXToolStripMenuItem
            // 
            this.exitAltXToolStripMenuItem.Image = global::Forms_Lab2.Properties.Resources.close;
            this.exitAltXToolStripMenuItem.Name = "exitAltXToolStripMenuItem";
            this.exitAltXToolStripMenuItem.ShortcutKeyDisplayString = "Alt+X";
            this.exitAltXToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitAltXToolStripMenuItem.Text = "Exit";
            this.exitAltXToolStripMenuItem.Click += new System.EventHandler(this.EndProgramm);
            // 
            // undoCtrlZToolStripMenuItem
            // 
            this.undoCtrlZToolStripMenuItem.Image = global::Forms_Lab2.Properties.Resources.arrow_back;
            this.undoCtrlZToolStripMenuItem.Name = "undoCtrlZToolStripMenuItem";
            this.undoCtrlZToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.undoCtrlZToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.undoCtrlZToolStripMenuItem.Text = "Undo";
            // 
            // renoCtrlShiftNToolStripMenuItem
            // 
            this.renoCtrlShiftNToolStripMenuItem.Image = global::Forms_Lab2.Properties.Resources.arrow_forward;
            this.renoCtrlShiftNToolStripMenuItem.Name = "renoCtrlShiftNToolStripMenuItem";
            this.renoCtrlShiftNToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+Z";
            this.renoCtrlShiftNToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.renoCtrlShiftNToolStripMenuItem.Text = "Reno";
            // 
            // penToolStripMenuItem
            // 
            this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.styleToolStripMenuItem, this.colorToolStripMenuItem});
            this.penToolStripMenuItem.Image = global::Forms_Lab2.Properties.Resources.pencil1;
            this.penToolStripMenuItem.Name = "penToolStripMenuItem";
            this.penToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.penToolStripMenuItem.Text = "Pen";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.solidToolStripMenuItem, this.dotToolStripMenuItem, this.dashDotDotToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = global::Forms_Lab2.Properties.Resources.color1;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Checked = true;
            this.solidToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dotToolStripMenuItem.Text = "Dot";
            // 
            // dashDotDotToolStripMenuItem
            // 
            this.dashDotDotToolStripMenuItem.Name = "dashDotDotToolStripMenuItem";
            this.dashDotDotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dashDotDotToolStripMenuItem.Text = "DashDotDot";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripButton1, this.toolStripButton2, this.toolStripButton3, this.toolStripButton4,
                this.toolStripButton5
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(55, 588);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Forms_Lab2.Properties.Resources._new;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 54);
            this.toolStripButton1.Text = "New";
            this.toolStripButton1.Click += new System.EventHandler(this.CreateNewFile);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Forms_Lab2.Properties.Resources.open;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 54);
            this.toolStripButton2.Text = "Open";
            this.toolStripButton2.Click += new System.EventHandler(this.FileOpen);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Forms_Lab2.Properties.Resources.save;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 54);
            this.toolStripButton3.Text = "Save";
            this.toolStripButton3.Click += new System.EventHandler(this.SaveFileAs);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Forms_Lab2.Properties.Resources.color1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(52, 54);
            this.toolStripButton4.Text = "Color";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Forms_Lab2.Properties.Resources.close;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 54);
            this.toolStripButton5.Text = "Exit";
            this.toolStripButton5.Click += new System.EventHandler(this.EndProgramm);
            // 
            // picDrawingSurface
            // 
            this.picDrawingSurface.BackColor = System.Drawing.Color.Transparent;
            this.picDrawingSurface.Location = new System.Drawing.Point(0, 0);
            this.picDrawingSurface.Name = "picDrawingSurface";
            this.picDrawingSurface.Size = new System.Drawing.Size(750, 500);
            this.picDrawingSurface.TabIndex = 2;
            this.picDrawingSurface.TabStop = false;
            this.picDrawingSurface.MouseDown +=
                new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseDown);
            this.picDrawingSurface.MouseMove +=
                new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseMove);
            this.picDrawingSurface.MouseUp +=
                new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(143, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 51);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(502, 3);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(199, 37);
            this.trackBar1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picDrawingSurface);
            this.panel2.Location = new System.Drawing.Point(143, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 525);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picDrawingSurface)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashDotDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renoCtrlShiftNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoCtrlZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAltXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savaF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openF3ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox picDrawingSurface;
        private System.Windows.Forms.Panel panel2;
    }
}