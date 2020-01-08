using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.beans
{
    class Plan
    {
        private int idPlan;
        private int largeur;
        private int hauteur;
        private float echelle;
        private float calculerSurface()
        {
            float res = 0;
            res = largeur * hauteur;
            return res;
        }
        private void ajouterPlan()
        {

        }

        public Plan(int idPlan, int largeur, int hauteur, float echelle)
        {
            this.idPlan = idPlan;
            this.largeur = largeur;
            this.hauteur = hauteur;
            this.echelle = echelle;
        }
    }
}
