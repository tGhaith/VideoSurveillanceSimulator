using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmWorkSpace 
    {
        string name;
        string originalPath;
        private void picMinimize_Click(object sender, EventArgs e)
        {
            picMaximize.Visible = true;
            picMinimize.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            picMaximize.Visible = false;
            picMinimize.Visible = true;
            this.WindowState = FormWindowState.Maximized;

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.Show();
            this.Hide();
        }

        private void picImport_Click(object sender, EventArgs e)
        {
            if (imgLocation == null)
            {


                try
                {
                    OpenFileDialog opfPlan = new OpenFileDialog();
                    opfPlan.Filter = "jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
                    if (opfPlan.ShowDialog() == DialogResult.OK)
                    {
                        imgLocation = opfPlan.FileName;
                        int n = opfPlan.ToString().Length;
                        if (opfPlan.ToString().Substring(n - 4) != ".jpg")
                        {
                            imgLocation = null;
                            MessageBox.Show("You  must select an image!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.picPlan.ImageLocation = imgLocation;
                            this.btnTest.Enabled = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("Want you to save your work ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    try
                    {
                        OpenFileDialog opfPlan = new OpenFileDialog();
                        opfPlan.Filter = "jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
                        if (opfPlan.ShowDialog() == DialogResult.OK)
                        {
                            imgLocation = opfPlan.FileName;
                            int n = opfPlan.ToString().Length;
                            if (opfPlan.ToString().Substring(n - 4) != ".jpg")
                            {
                                imgLocation = null;
                                MessageBox.Show("You  must select an image!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                picDelete_Click(sender, e);
                                this.picPlan.ImageLocation = imgLocation;
                                this.btnTest.Enabled = true;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            name = Path.GetFileName(picPlan.ImageLocation.Substring(0, picPlan.ImageLocation.Length - 4));
            originalPath = imgLocation;

        }

        private void picDelete_Click(object sender, EventArgs e)
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
            do
            {
                try
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\temporary.jpg");
                } catch { }
                try
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\" + name + "temporary.jpg");
                }
                catch { }

            } while (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\temporary.jpg") || File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\" + name + "temporary.jpg"));
            toolStrip.Visible = false;
            this.toolStripStatusLabel1.Visible = false;
            Controls.Clear();
            InitializeComponent();
            this.frmWorkSpace_Load(sender, e);
            this.picPlan.ImageLocation = originalPath;
            this.btnTest.Enabled = true;
           }

        private void picSave_Click(object sender, EventArgs e)
        {

        }

        private void picReport_Click(object sender, EventArgs e)
        {

        }
    }
}
