using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.beans
{
    class Projet
    {
        private int idProjet;
        private String nomProjet;
        private Plan plan;
        private List<Camera> listCamera;
        private Rapport rapport;

        public int IdProjet { get => idProjet; set => idProjet = value; }
        public string NomProjet { get => nomProjet; set => nomProjet = value; }
        internal Plan Plan { get => plan; set => plan = value; }
        internal List<Camera> ListCamera { get => listCamera; set => listCamera = value; }
        internal Rapport Rapport { get => rapport; set => rapport = value; }

        private void creerProjet()
        {

        }
        private void ouvrirProjet()
        {

        }
        protected static void sauvegarder()
        {

        }

        public Projet(int idProjet, string nomProjet)
        {
            this.idProjet = idProjet;
            this.nomProjet = nomProjet;
        }
    }
}
