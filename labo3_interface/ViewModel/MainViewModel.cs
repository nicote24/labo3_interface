using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using labo3_interface.Command;
using labo3_interface.Model;
using labo3_interface.View;

namespace labo3_interface.ViewModel
{
    class MainViewModel
    {

        private Produit produit;

        public MainViewModel()
        {
            produit = new Produit(100, 100, "", 0, "");
            OpenCommand = new OpenCommand(this);
        }

        public bool CanUpdate
        {
            get
            {
                if (produit == null)
                    return false;
                else return true;
            }
        }

        public Produit Produit
        {
            get { return produit; }
        }

        public ICommand OpenCommand
        {
            get;
            private set;
        }

        public void OpenWindow(object objet)
        {
            Window fenetre = new Page2();
            fenetre.Show();
            fenetre.DataContext = this;
            
        }
    }
}
