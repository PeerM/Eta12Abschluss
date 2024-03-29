﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sollKreisGezeichnetWerden = false;//eine variable um zu prüfen ob ein kreis gezeichnet werden soll
        Color farbeVomKreis = Color.Black;// so declariert das wir vom gesamten code drauf zugreifen können
        private void buttonZumKreisMalen_Click(object sender, EventArgs e)//das ereignis das ausgelöst wird wenn der button gedrückt wird. sender wird selten verwendet. 
                                                                          //mit e kann man sich mehr information holle zu was passiert ist hier selten benutzt 
        {
            sollKreisGezeichnetWerden = true; //wenn der button gedrück wurde soll wo anders der kreis gezeichnet werden
            farbeVomKreis = randomFarbe(); // dem kreis eine zufällige farbe geben
            panelZumReinzeichnen.Refresh();//mit Refresh bringen wir panelzumreinzeichen dazu sich neu zu zeichen und damit ist der kreis gleich sichtbar
        }
        //in EnventArgs und auch PaintEventArgs sind informationen zu dem eregniss. uns fehlt das wissen um sie allgemein zu nutzten, also werd ich es explizit erwähen wie wir sie in ein paar fällen butzten können

        /// <summary>
        /// panelZumReinzeichnen_Paint: das ereignis welches ausgelöst wird wenn das pannel neu gezeichet wird
        /// </summary>
        /// <param name="sender">haben wir noch nicht benutzt</param>
        /// <param name="e">aus dem kann man das Graphics objekt hollen </param>
        private void panelZumReinzeichnen_Paint(object sender, PaintEventArgs e)//das ereigniss 
        {
            Graphics grafikDieWirJetztBenutzten = e.Graphics; // das grafik objekt aus dem PaintEventArgs e hollen um leichter dran zu kommen; optional
            //region ist nur für übersichtlichkeit da. braucht ihr nicht wissen
            #region kreis zeichnen 
            if (sollKreisGezeichnetWerden) //prüfen ob wir den kreis zeichnen sollen
            {
                //ALT: Pen kreisStift = Pens.Black; // einen stift aus der stifftesammlung Pens hollen; optional
                Pen kreisStift = new Pen(farbeVomKreis); // den konstruktor von Pen aufrufen um einen neuen stift mit farbeVomKreis zu erstellen
                int durchmesserKreis = 30; //den durchmeser vom kreis für übersicht in eingene variable;optional
                int xKoordinateKreis=30;//zur übersicht;oprional
                int yKoordinateKreis=30;//zur übersicht;optional
                //es gibt keine methode um einen um direkt einen kreis zu malen also übergeben wir für länge und breite einfach den durchmesserKreis
                grafikDieWirJetztBenutzten.DrawEllipse(kreisStift, xKoordinateKreis, yKoordinateKreis, durchmesserKreis, durchmesserKreis);
                //wenn man alle optionalen schritte überspringt braucht man folgeneden code:
                //e.Graphics.DrawEllipse(Pens.Black, 30, 30, 30, 30);

            }
            #endregion
        }
        private Color randomFarbe()
        {
            int rot;
            int gruen;
            int blau;
            int aktuelleMilliSekunde = DateTime.Now.Millisecond;// die aktuelle uhrzeit in millisekunden hollen
            Random zahlGenerator = new Random(aktuelleMilliSekunde);// startpunkt für den zuffalsgenerator festlegen das nicht jedesmal,wenn das programm gestartet wird, die selben farben kommen
            rot = zahlGenerator.Next(0,256); // eine zufallszahl zwischen 0 und ausgeschlossen 256 gennerieren.
            gruen = zahlGenerator.Next(0, 256);// das selbe für grün
            blau = zahlGenerator.Next(0, 256);// das selbe für blau
            Color returnColor;
            returnColor = Color.FromArgb(rot, gruen, blau);
            return returnColor;
        }

    }
}
