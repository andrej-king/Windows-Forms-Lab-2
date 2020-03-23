﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Lab2
{
    public partial class Form1 : Form
    {
        private bool drawing;
        private GraphicsPath currentPath;
        private Point oldLocation;
        private Pen currentPen;

        public Form1()
        {
            InitializeComponent();
            drawing = false; // переменная отвечает за рисование
            currentPen = new Pen(Color.Black);
        }

        private void CreateNewFile(object sender, EventArgs e)
        {
            if (picDrawingSurface != null) // если пользователь захотел создать новый файл, но что-то уже нарисовано
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка??",
                    "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes:
                        SaveFileAs(sender, e);
                        break;
                    case DialogResult.Cancel: return;
                }
            }

            Bitmap pic = new Bitmap(750, 500);
            picDrawingSurface.Image = pic;
            picDrawingSurface.BackColor = Color.White;
        }

        private void SaveFileAs(object sende, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4; //По умолчанию будет выбрано последнее расширение *.png
            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "") // если введено не пустое имя
            {
                System.IO.FileStream fs = (System.IO.FileStream) SaveDlg.OpenFile();

                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }

        private void FileOpen(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; // По умолчанию выбрано первое расширение *.jpg

            // Когда пользователь укажет нужный путь картинки, ее нужно загрузить в PictureBox
            if (OP.ShowDialog() != DialogResult.Cancel) picDrawingSurface.Load(OP.FileName);
            picDrawingSurface.AutoSize = true;
        }

        private void EndProgramm(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Help button
        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл");
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
        }


        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            try
            {
                currentPath.Dispose();
            }
            catch {};
        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
        }
        
        // eraser
    }
}