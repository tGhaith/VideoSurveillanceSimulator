using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmWorkSpace : Form
    {
        string imgLocation;
        float X, Y;
        float qX=1;
        float qY=1;
        int clique = 0;
        bool verifSelectedImage = false;
        
        public frmWorkSpace()
        {
            InitializeComponent();
        }

        private void frmWorkSpace_Load(object sender, EventArgs e)
        {
            this.control();
            picPlaceCamera.AllowDrop = true;
        }

        
        

        
        public void control()
        {
            PictureBox p1 = new PictureBox();
            p1.AllowDrop = true;
            p1.Height = 90;
            p1.Width = 90;
            p1.SizeMode = PictureBoxSizeMode.Zoom;
            p1.ImageLocation = "C:/Users/DELL/Documents/material_general_free (1)/1.jpg";
            p1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpCameras.Controls.Add(p1);
            p1.MouseDown += new System.Windows.Forms.MouseEventHandler(p1_MouseDown);
            



            PictureBox p2 = new PictureBox();
            p2.AllowDrop = true;
            p2.Height = 90;
            p2.Width = 90;
            p2.SizeMode = PictureBoxSizeMode.Zoom;
            p2.ImageLocation = "C:/Users/DELL/Documents/material_general_free (1)/2.jpg";
            p2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpCameras.Controls.Add(p2);
            p2.MouseDown += new System.Windows.Forms.MouseEventHandler(p1_MouseDown);

            PictureBox p3 = new PictureBox();
            p3.Height = 90;
            p3.Width = 90;
            p3.SizeMode = PictureBoxSizeMode.Zoom;
            p3.ImageLocation = "C:/Users/DELL/Documents/material_general_free (1)/3.jpg";
            p3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpCameras.Controls.Add(p3);
            p3.MouseDown += new System.Windows.Forms.MouseEventHandler(p1_MouseDown);

            PictureBox p4 = new PictureBox();
            p4.Height = 90;
            p4.Width = 90;
            p4.SizeMode = PictureBoxSizeMode.Zoom;
            p4.ImageLocation = "C:/Users/DELL/Documents/material_general_free (1)/4.jpg";
            p4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpCameras.Controls.Add(p4);
            p4.MouseDown += new System.Windows.Forms.MouseEventHandler(p1_MouseDown);

            PictureBox p5 = new PictureBox();
            p5.Height = 90;
            p5.Width = 90;
            p5.SizeMode = PictureBoxSizeMode.Zoom;
            p5.ImageLocation = "C:/Users/DELL/Documents/material_general_free (1)/5.jpg";
            p5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpCameras.Controls.Add(p5);
            p5.MouseDown += new System.Windows.Forms.MouseEventHandler(p1_MouseDown);

        }

        


       /* private void btnTest_Click(object sender, EventArgs e)
        {
            
            setLayer(picPlan);
            PictureBox layer1 = new PictureBox();
            layer1.Size = picPlan.Size;
            layer1.Location = picPlan.Location;
            layer1.Anchor = picPlan.Anchor;
            layer1.SizeMode = picPlan.SizeMode;
            Bitmap img = new Bitmap(imgLocation,true);
            for(int x = 0; x < img.Width; x++)
            {
                for(int y = 0; y < img.Height; y++)
                {
                    Color clr = img.GetPixel(x, y);
                    Color newClr = Color.FromArgb(255, 255 ,255,0);
                    if (clr.R>240 && clr.B>240 && clr.G>240)
                    {
                        img.SetPixel(x, y, newClr);

                    }
                }
            }
            layer1.Image = img;
            layer1.Visible = true;
            layer1.BringToFront();
            getLayer().Controls.Add(layer1);
            setLayer(layer1);

        }*/
        private Control layer;
        
        void setLayer(PictureBox pb)
        {
            this.layer = pb;
        }
        private Control getLayer()
        {
            return layer;
        }
        private void dragDrop(object sender, int X, int Y,IDataObject  Data)
        {
            PictureBox p = new PictureBox();
            p = (PictureBox)sender;
            int x = this.PointToClient(new Point(X, Y)).X;

            int y = this.PointToClient(new Point(X, Y)).Y;

            if (x >= p.Location.X && x <= p.Location.X + p.Width && y >= p.Location.Y && y <= p.Location.Y + p.Height)

            {

                string[] files = (string[])Data.GetData(DataFormats.FileDrop);

                p.Image = Image.FromFile(files[0]);

            }
        }


        private void p1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }


        private void picPlaceCamera_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
                verifSelectedImage = true;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void picPlaceCamera_DragDrop(object sender, DragEventArgs e)
        {

            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picPlan_DoubleClick(object sender, EventArgs e)
        {
            if (verifSelectedImage)
            {
                Bitmap image;
                Graphics g;
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\" + name + "temporary.jpg"))
                {
                    do
                    {
                        toolStrip.Visible = true;
                        toolStripStatusLabel1.Visible = true;
                        if (toolStrip.Value < 100)
                        {
                            toolStrip.Value += 5;
                        }
                        else
                        {
                            toolStrip.Value = 0;
                        }
                        if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\temporary.jpg"))
                        {
                            try
                            {
                                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\temporary.jpg");
                            }
                            catch { }

                        }
                    } while (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\temporary.jpg"));
                    try
                    {
                        File.Copy(imgLocation, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\temporary.jpg");
                        toolStrip.Value = 100;
                    }
                    catch { }

                    image = new Bitmap(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\temporary.jpg", false);
                    g = Graphics.FromImage(image);
                    clique++;
                }
                else
                {
                    try
                    {
                        image = new Bitmap(imgLocation, false);
                    }
                    catch
                    {
                        image = new Bitmap(originalPath, false);

                    }
                    g = Graphics.FromImage(image);
                    clique++;
                }
                g.FillEllipse(Brushes.Red, X, Y, 10 / qX, 10 / qY);
                for (int x=(int)Math.Ceiling(X); x < image.Width; x++)
                {
                    int check = (int)Math.Ceiling(Y);
                    bool obstacle = false;
                    int cnst = x;
                    for (int y = (int)Math.Ceiling(Y); y < image.Height; y++)
                    {
                        check = y;
                        Color clr = image.GetPixel(cnst++, y);
                        Color newClr = Color.FromArgb(255, 255, 255, 0);
                        if (clr.R > 240 && clr.B > 240 && clr.G > 240)
                        {
                            image.SetPixel(cnst, y, newClr);
                        }
                        else
                        {
                            
                            break;

                        }
                    }
                    for (int y = (int)Math.Ceiling(Y); y > 0; y--)
                    {
                        check = y;
                        Color clr = image.GetPixel(cnst++, y);
                        Color newClr = Color.FromArgb(255, 255, 255, 0);
                        if (clr.R > 240 && clr.B > 240 && clr.G > 240)
                        {
                            image.SetPixel(cnst, y, newClr);
                        }
                        else
                        {

                            break;

                        }
                    }
                        for (int y = (int)Math.Ceiling(Y); y < check+1; y++)
                    {
                        Color clr = image.GetPixel(x, y);
                        if ((clr.R < 10 && clr.B <10 && clr.G < 10))
                        {
                            obstacle = true;
                        }
                    }

                    if (obstacle)
                    {
                        break;
                    }
                }
                try
                {
                    image.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\" + name + "temporary.jpg");

                }
                catch
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\" + name + "temporary.jpg");
                    image.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\" + name + "temporary.jpg");
                }
                imgLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\" + name + "temporary.jpg";
                picPlan.ImageLocation = imgLocation;
                toolStrip.Visible = false;
                this.toolStripStatusLabel1.Visible = false;
                //image.Dispose();
            }


            /*string name = Path.GetFileName(picPlan.ImageLocation.Substring(0,picPlan.ImageLocation.Length-4));
            int x = MousePosition.X;
            int y = MousePosition.Y;
            Image img = picPlan.Image;
            Rectangle circle = new Rectangle(x, y, 150, 150);
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"" + name + "temporary.jpg"))
            {
                Graphics g = Graphics.FromImage(img);
                g.DrawEllipse(new Pen(Brushes.Red,0.3f), circle);

            }
            else
            {
                Graphics g = Graphics.FromImage(img);
                g.DrawEllipse(new Pen(Brushes.Red, 0.3f), circle);
                img.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\" + name + "temporary.jpg");
                imgLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\" + name + "temporary.jpg";
                MessageBox.Show(img.Width + "\n error \n" + imgLocation);

    
            }*/
        }

        private void picPlan_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                this.label1.Text = "coordonnées : " + "\n X = " + e.X.ToString() + "\n Y = " + e.Y.ToString() +
                "\n Image Width = " + picPlan.Image.Width + "\n Image Height = " + picPlan.Image.Height
                +"\n Division : \n"+"qX = "+ (float)picPlan.Width / (float)(picPlan.Image.Width) + "\n qY = "+ (float)picPlan.Height / (float)picPlan.Image.Height+"\n Clique = "+clique;

            }
            catch
            {
                this.label1.Text = "coordonnées : " + "\n X = " + e.X.ToString() + "\n Y = " + e.Y.ToString();
            }
            

        }

        private void picPlan_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                qX = ((float)picPlan.Width / (float)(picPlan.Image.Width));
                qY = ((float)picPlan.Height / (float)picPlan.Image.Height);
                X = this.correctionCoordonees(e.X , qX);
                Y = this.correctionCoordonees(e.Y , qY);
            }
            catch { }

        }
        private float correctionCoordonees(int r,float q)
        {
            float res = 0;
            res = r / q;
            return res;
        }
    }
}
