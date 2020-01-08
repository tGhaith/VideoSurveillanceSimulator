using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.beans
{
    class Rapport
    {
        private int idRapport;
        private List<Camera> listCamera;
        private float zoneCouverture;

        public int IdRapport { get => idRapport; set => idRapport = value; }
        internal List<Camera> ListCamera { get => listCamera; set => listCamera = value; }
        public float ZoneCouverture { get => zoneCouverture; set => zoneCouverture = value; }

        private void calculerZoneCouverture()
        {

        }
        private void genererRapport()
        {

        }

        public Rapport(int idRapport, List<Camera> listCamera)
        {
            this.idRapport = idRapport;
            this.listCamera = listCamera;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
