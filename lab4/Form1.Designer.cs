namespace lab4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            scretchImageToolStripMenuItem = new ToolStripMenuItem();
            centerImageToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            autosizeToolStripMenuItem = new ToolStripMenuItem();
            loadImageToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(93, 22);
            loadToolStripMenuItem.Text = "exit";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageToolStripMenuItem, loadImageToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, scretchImageToolStripMenuItem, centerImageToolStripMenuItem, zoomToolStripMenuItem, autosizeToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(180, 22);
            imageToolStripMenuItem.Text = "image";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(180, 22);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // scretchImageToolStripMenuItem
            // 
            scretchImageToolStripMenuItem.Name = "scretchImageToolStripMenuItem";
            scretchImageToolStripMenuItem.Size = new Size(180, 22);
            scretchImageToolStripMenuItem.Text = "ScretchImage";
            scretchImageToolStripMenuItem.Click += scretchImageToolStripMenuItem_Click;
            // 
            // centerImageToolStripMenuItem
            // 
            centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            centerImageToolStripMenuItem.Size = new Size(180, 22);
            centerImageToolStripMenuItem.Text = "CenterImage";
            centerImageToolStripMenuItem.Click += centerImageToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(180, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            zoomToolStripMenuItem.Click += zoomToolStripMenuItem_Click;
            // 
            // autosizeToolStripMenuItem
            // 
            autosizeToolStripMenuItem.Name = "autosizeToolStripMenuItem";
            autosizeToolStripMenuItem.Size = new Size(180, 22);
            autosizeToolStripMenuItem.Text = "Autosize";
            autosizeToolStripMenuItem.Click += autosizeToolStripMenuItem_Click;
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new Size(180, 22);
            loadImageToolStripMenuItem.Text = "load image";
            loadImageToolStripMenuItem.Click += loadImageToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 346);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem scretchImageToolStripMenuItem;
        private ToolStripMenuItem centerImageToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private ToolStripMenuItem autosizeToolStripMenuItem;
    }
}