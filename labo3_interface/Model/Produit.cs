using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo3_interface.Model
{
    class Produit : INotifyPropertyChanged
    {

        private string nom;
        private int largeurImg;
        private int longeurImg;
        private string couleurFond;
        private int prix;
        string image;
        public Produit(int largeurImg, int longeurImg,string nom, int prix,string couleurFond)
        {
            this.nom = nom;
            this.prix = prix;
            this.largeurImg = largeurImg;
            this.longeurImg = longeurImg;
            this.couleurFond = couleurFond;
            image = "pack://application:,,,/labo3_interface;component\\Images\\baby-390555_960_720.jpg";
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; OnpropertyChanged("Nom"); }
        }
        public string CouleurFond
        {
            get { return couleurFond; }
            set { couleurFond = value; OnpropertyChanged("CouleurFond"); }
        }

        public int Prix
        {
            get { return prix; }
            set { prix = value; OnpropertyChanged("Prix"); }
        }

        public int LargeurImg
        {
            get { return largeurImg; }
            set { largeurImg = value; OnpropertyChanged("LargeurImg"); }
        }
        public int LongeurImg
        {
            get { return longeurImg; }
            set { longeurImg = value; OnpropertyChanged("LongeurImg"); }
        }
        public string Image
        {
            get { return image; }
            set { image = value; OnpropertyChanged("Image"); }
        }

        #region 
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnpropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}