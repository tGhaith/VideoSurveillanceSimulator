using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.beans
{
    class Camera
    {
        private int idCamera;
        private String typeCamera;
        private String modeleCamera;
        private int angleVision;
        private int champVisionMeter;
        private int coordonneeX;
        private int coordonneeY;
        private int rotation;

        public int IdCamera { get => idCamera; set => idCamera = value; }
        public string TypeCamera { get => typeCamera; set => typeCamera = value; }
        public string ModeleCamera { get => modeleCamera; set => modeleCamera = value; }
        public int AngleVision { get => angleVision; set => angleVision = value; }
        public int ChampVisionMeter { get => champVisionMeter; set => champVisionMeter = value; }
        public int CoordonneeX { get => coordonneeX; set => coordonneeX = value; }
        public int CoordonneeY { get => coordonneeY; set => coordonneeY = value; }
        public int Rotation { get => rotation; set => rotation = value; }

        public void positionner(float X,float Y,float qX,float qY)
        {
            Bitmap image;
            Graphics g;
            image = new Bitmap(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VideoSurveillanceSimulator\temporary.jpg", false);
            g = Graphics.FromImage(image);
            g.FillEllipse(Brushes.Red, X, Y, 10 / qX, 10 / qY);
        }
        public void tourner()
        {

        }
        public void supprimer()
        {

        }

        public Camera(int idCamera, string typeCamera, string modeleCamera, int angleVision, int champVisionMeter)
        {
            this.idCamera = idCamera;
            this.typeCamera = typeCamera;
            this.modeleCamera = modeleCamera;
            this.angleVision = angleVision;
            this.champVisionMeter = champVisionMeter;
        }

        public Camera(int idCamera, string typeCamera, string modeleCamera, int angleVision, int champVisionMeter, int coordonneeX, int coordonneeY, int rotation) : this(idCamera, typeCamera, modeleCamera, angleVision, champVisionMeter)
        {
            this.coordonneeX = coordonneeX;
            this.coordonneeY = coordonneeY;
            this.rotation = rotation;
        }
    }
}
