using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaisieComplete
{
    public partial class FormProduits : Form
    {
        // Collection des fenêtres filles
        public Dictionary<string, Form> ChildForms { get; private set; }
        public FormProduits()
        {
            InitializeComponent();
            btnPlus.Click += (object sender, EventArgs e) => ShowChild("SaisieComplete.FormSaisieProduit");
        }
        protected override void OnLoad(EventArgs e)
        {
            ChildForms = new Dictionary<string, Form>();
            base.OnLoad(e);
        }
        private void ShowChild(string name)
        {
            // Dans la collection des fenêtres filles, on recherche une fenêtre
            // dont le nom correspond à celui passé en paramètre...
            this.SuspendLayout();   // On stope le rafraîchissement du visuel
            Form form;
            if (!ChildForms.TryGetValue(name, out form))
            {
                // Si on n'en a pas trouvé, on crée une instance de cette fenêtre
                Type t = Type.GetType(name);
                form = (Form)Activator.CreateInstance(t);
                form.Name = name;

                form.MdiParent = this;
                form.FormClosed += (object sender, FormClosedEventArgs e) => RemoveChild(form);
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.Show();
            }

            // On maximise la taille de la fenêtre
            form.Select();
            form.WindowState = FormWindowState.Maximized;
            this.ResumeLayout(); // Rafraîchit le visuel
        }

        // Ajoute une fenêtre fille
        private void AddChild(Form f)
        {
            ChildForms.Add(f.Name, f);
        }


        // Supprime une fenêtre fille
        private void RemoveChild(Form f)
        {
            ChildForms.Remove(f.Name);
        }
    }
}
