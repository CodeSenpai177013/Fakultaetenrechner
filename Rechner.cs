using System;
using System.Windows.Forms;

namespace Fakultätenrechner
{
    public partial class Rechner : Form
    {
        public Rechner()
        {
            InitializeComponent();
        }
        //Erstellen der Variablen
        int eingabe, ergebnis;

        //Fakultät berechnen mit einer Zählschleife
        private int zählSchleife(int n)
        {
            int ergebnis = 1;
            for (int i = 1; i <= n; i++)
            {
                ergebnis *= i;
            }
            return ergebnis;
        }
        //Fakultät berechnen mit einer Kopf gesteuerten Schleife
        private int kopfSchleife(int n)
        {
            int ergebnis = 1;
            int i = 1;
            while (i < n)
            {
                i++;
                ergebnis *= i;
            }
            return ergebnis;
        }
        //Fakultät berechnen mit einer Fuß gesteuerten Schleife
        private int fußSchleife(int n)
        {
            int i= 1;
            int ergebnis = 1;
            do
            {
                i++;
                ergebnis *= i;
            }
            while (i < n);
            return ergebnis;
        }

        //Code der beim drücken des MenuStrips "Zählschleife" ausgeführt wird
        private void zählschleifeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Erzeugen einer Boolean Variable zur späteren Überprüfung auf entstandene Fehler
            bool fehler = false;
            try
            {
                //Versuch die Eingabe in die Textbox zu einem Integrer zu formatieren
                eingabe = Convert.ToInt32(txtbxeingabe.Text);
            }
            catch
            {
                fehler = true;
            }

            //Überprüfung ob die Eingabe unter 10 ist und kein Fehler zuvor schon aufgetreten ist
            if ((eingabe <= 10) & (fehler == false))
            {
                //Übergabe der Eingabe zur Berechnung und Ausgabe
                ergebnis = zählSchleife(eingabe);
                lblergebnis.Text = Convert.ToString(ergebnis);
            }
            else
            {
                //Anzeigen durch eine Messagebox das ein Fehler aufgetreten ist
                MessageBox.Show("Nur ganze Zahlen bis 10!", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        //Code der beim drücken des MenuStrips "Kopfchleife" ausgeführt wird
        private void kopfschleifeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Erzeugen einer Boolean Variable zur späteren Überprüfung auf entstandene Fehler
            bool fehler = false;
            try
            {
                //Versuch die Eingabe in die Textbox zu einem Integrer zu formatieren
                eingabe = Convert.ToInt32(txtbxeingabe.Text);
            }
            catch
            {
                fehler = true;
            }

            //Überprüfung ob die Eingabe unter 10 ist und kein Fehler zuvor schon aufgetreten ist
            if ((eingabe <= 10) & (fehler == false))
            {
                //Übergabe der Eingabe zur Berechnung und Ausgabe
                ergebnis = kopfSchleife(eingabe);
                lblergebnis.Text = Convert.ToString(ergebnis);
            }
            else
            {
                //Anzeigen durch eine Messagebox das ein Fehler aufgetreten ist
                MessageBox.Show("Nur ganze Zahlen bis 10!", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Code der beim drücken des MenuStrips "Fußschleife" ausgeführt wird
        private void fußschleifeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Erzeugen einer Boolean Variable zur späteren Überprüfung auf entstandene Fehler
            bool fehler = false;
            try
            {
                //Versuch die Eingabe in die Textbox zu einem Integrer zu formatieren
                eingabe = Convert.ToInt32(txtbxeingabe.Text);
            }
            catch
            {
                fehler = true;
            }

            //Überprüfung ob die Eingabe unter 10 ist und kein Fehler zuvor schon aufgetreten ist
            if ((eingabe <= 10) & (fehler == false))
            {
                //Übergabe der Eingabe zur Berechnung und Ausgabe
                ergebnis = fußSchleife(eingabe);
                lblergebnis.Text = Convert.ToString(ergebnis);
            }
            else
            {
                //Anzeigen durch eine Messagebox das ein Fehler aufgetreten ist
                MessageBox.Show("Nur ganze Zahlen bis 10!", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Code der beim drücken des MenuStrips "Ende" ausgeführt wird
        private void endeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //beenden des Programms
            Close();
        }
    }
}