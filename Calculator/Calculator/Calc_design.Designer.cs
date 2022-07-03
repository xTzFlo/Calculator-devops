using System.Drawing;
using System.Windows.Forms;
namespace Calculator
{
    partial class Calc_design
    {
        private System.ComponentModel.IContainer components = null;

        void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sept = new System.Windows.Forms.Button();
            this.egal = new System.Windows.Forms.Button();
            this.huit = new System.Windows.Forms.Button();
            this.neuf = new System.Windows.Forms.Button();
            this.quatre = new System.Windows.Forms.Button();
            this.cinq = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.un = new System.Windows.Forms.Button();
            this.deux = new System.Windows.Forms.Button();
            this.trois = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.virgule = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.displayBottom = new System.Windows.Forms.Label();
            this.displayTop = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
             
            // sept
             
            this.sept.Location = new System.Drawing.Point(19, 168);                 // Position du bouton
            this.sept.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);        // Padding (la distance séparant les bords adjacents de deux éléments UI adjacents)
            this.sept.Name = "sept";                                                // Nom du bouton
            this.sept.Size = new System.Drawing.Size(78, 90);                       // Taille du bouton (forme)
            this.sept.TabIndex = 5;                                                 // Index dans la liste de tous les élements UI       
            this.sept.Text = "7";                                                   // Texte sur le bouton
            this.sept.Click += new System.EventHandler(this.sept_Click);            // Evenement lorsqu'on clique sur le bouton
             
            // egal
             
            this.egal.Location = new System.Drawing.Point(371, 372);
            this.egal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.egal.Name = "egal";
            this.egal.Size = new System.Drawing.Size(75, 192);
            this.egal.TabIndex = 3;
            this.egal.Text = "=";
            this.egal.Click += new System.EventHandler(this.egal_Click);
             
            // huit
             
            this.huit.Location = new System.Drawing.Point(107, 168);
            this.huit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.huit.Name = "huit";
            this.huit.Size = new System.Drawing.Size(78, 90);
            this.huit.TabIndex = 4;
            this.huit.Text = "8";
            this.huit.Click += new System.EventHandler(this.huit_Click);
             
            // neuf
             
            this.neuf.Location = new System.Drawing.Point(195, 168);
            this.neuf.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.neuf.Name = "neuf";
            this.neuf.Size = new System.Drawing.Size(78, 90);
            this.neuf.TabIndex = 5;
            this.neuf.Text = "9";
            this.neuf.Click += new System.EventHandler(this.neuf_Click);
             
            // quatre
             
            this.quatre.Location = new System.Drawing.Point(19, 270);
            this.quatre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.quatre.Name = "quatre";
            this.quatre.Size = new System.Drawing.Size(78, 90);
            this.quatre.TabIndex = 6;
            this.quatre.Text = "4";
            this.quatre.Click += new System.EventHandler(this.quatre_Click);
             
            // cinq
             
            this.cinq.Location = new System.Drawing.Point(107, 270);
            this.cinq.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cinq.Name = "cinq";
            this.cinq.Size = new System.Drawing.Size(78, 90);
            this.cinq.TabIndex = 7;
            this.cinq.Text = "5";
            this.cinq.Click += new System.EventHandler(this.cinq_Click);
             
            // six
             
            this.six.Location = new System.Drawing.Point(195, 270);
            this.six.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(78, 90);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.Click += new System.EventHandler(this.six_Click);
             
            // un
             
            this.un.Location = new System.Drawing.Point(19, 372);
            this.un.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(78, 90);
            this.un.TabIndex = 9;
            this.un.Text = "1";
            this.un.Click += new System.EventHandler(this.un_Click);
             
            // deux
             
            this.deux.Location = new System.Drawing.Point(107, 372);
            this.deux.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.deux.Name = "deux";
            this.deux.Size = new System.Drawing.Size(78, 90);
            this.deux.TabIndex = 10;
            this.deux.Text = "2";
            this.deux.Click += new System.EventHandler(this.deux_Click);
             
            // trois
             
            this.trois.Location = new System.Drawing.Point(195, 372);
            this.trois.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.trois.Name = "trois";
            this.trois.Size = new System.Drawing.Size(78, 90);
            this.trois.TabIndex = 11;
            this.trois.Text = "3";
            this.trois.Click += new System.EventHandler(this.trois_Click);
             
            // zero
             
            this.zero.Location = new System.Drawing.Point(19, 474);
            this.zero.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(166, 90);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.Click += new System.EventHandler(this.zero_Click);
             
            // virgule
             
            this.virgule.Location = new System.Drawing.Point(195, 474);
            this.virgule.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.virgule.Name = "virgule";
            this.virgule.Size = new System.Drawing.Size(78, 90);
            this.virgule.TabIndex = 13;
            this.virgule.Text = ",";
            this.virgule.Click += new System.EventHandler(this.virgule_Click);
             
            // div
             
            this.div.Location = new System.Drawing.Point(283, 270);
            this.div.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(78, 90);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.Click += new System.EventHandler(this.div_Click);
             
            // mult
             
            this.mult.Location = new System.Drawing.Point(371, 270);
            this.mult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(78, 90);
            this.mult.TabIndex = 17;
            this.mult.Text = "*";
            this.mult.Click += new System.EventHandler(this.mult_Click);
             
            // displayBottom -> Ecran du bas 
             
            this.displayBottom.BackColor = System.Drawing.Color.White;                                                                                                       // Couleur du fond de l'écran du bas
            this.displayBottom.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));         // Couleur, taille, police, ... du texte sur l'écran du bas
            this.displayBottom.Location = new System.Drawing.Point(19, 66);                                                                                                  // Position de l'écran    
            this.displayBottom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);                                                                                        // Padding (la distance séparant les bords adjacents de deux éléments UI adjacents)
            this.displayBottom.Name = "displayBottom";                                                                                                                       // Nom de l'écran du bas
            this.displayBottom.Size = new System.Drawing.Size(427, 72);                                                                                                      // Taille de l'écran du bas
            this.displayBottom.TabIndex = 18;                                                                                                                                // Index dans la liste de tous les éléments UI
            this.displayBottom.Text = "0";                                                                                                                                   // Texte par défaut sur l'écran du bas
            this.displayBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;                                                                                      // Alignement à droite du cadre du texte
             
            // displayTop -> Ecran du haut
             
            this.displayTop.BackColor = System.Drawing.Color.White;
            this.displayTop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTop.Location = new System.Drawing.Point(19, 30);
            this.displayTop.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.displayTop.Name = "displayTop";
            this.displayTop.Size = new System.Drawing.Size(427, 50);
            this.displayTop.TabIndex = 19;
            this.displayTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
             
            // del
             
            this.del.Location = new System.Drawing.Point(283, 168);
            this.del.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(78, 90);
            this.del.TabIndex = 20;
            this.del.Text = "Delete";
            this.del.Click += new System.EventHandler(this.del_Click);
             
            // clr
             
            this.clr.Location = new System.Drawing.Point(371, 168);
            this.clr.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(78, 90);
            this.clr.TabIndex = 21;
            this.clr.Text = "Reset";
            this.clr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;      // Spécifie que le texte s'affiche verticalement au-dessus de l'image d'un contrôle
            this.clr.Click += new System.EventHandler(this.clr_Click);
             
            // add
             
            this.add.Location = new System.Drawing.Point(283, 474);
            this.add.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(78, 90);
            this.add.TabIndex = 22;
            this.add.Text = "+";
            this.add.Click += new System.EventHandler(this.add_Click);
             
            // sub
             
            this.sub.Location = new System.Drawing.Point(283, 372);
            this.sub.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(78, 90);
            this.sub.TabIndex = 23;
            this.sub.Text = "-";
            this.sub.Click += new System.EventHandler(this.sub_Click);
             
            // Calc_design
             
            this.AcceptButton = this.egal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);           // Taille fenêtre de l'application
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;           // Gestion du scale (pour que la fenêtre reste petite)
            this.ClientSize = new System.Drawing.Size(469, 592);                    // Emplacement de la calculatrice sur la fenêtre
            this.Controls.Add(this.sub);                                            
            this.Controls.Add(this.add);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.del);
            this.Controls.Add(this.displayTop);
            this.Controls.Add(this.displayBottom);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);                                             // Ajout de chaque bouton
            this.Controls.Add(this.virgule);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.trois);
            this.Controls.Add(this.deux);
            this.Controls.Add(this.un);
            this.Controls.Add(this.six);
            this.Controls.Add(this.cinq);
            this.Controls.Add(this.quatre);
            this.Controls.Add(this.neuf);
            this.Controls.Add(this.huit);
            this.Controls.Add(this.egal);
            this.Controls.Add(this.sept);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);              // Gestion du padding
            this.Name = "Calc_design";                                               // Nom donné au tout
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;                  // N'autorise pas à afficher les éléments de gauche à droite
            this.Text = "Calculator";                                                // Nom de l'application en haut à gauche de la fenêtre
            this.ResumeLayout(false);                                                // Force une mise en page immédiate s'il existe des demandes de mise en page en attente
        }
             

        private System.Windows.Forms.Button sept;
        private System.Windows.Forms.Button egal;
        private System.Windows.Forms.Button huit;
        private System.Windows.Forms.Button neuf;
        private System.Windows.Forms.Button quatre;
        private System.Windows.Forms.Button cinq;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button un;
        private System.Windows.Forms.Button deux;
        private System.Windows.Forms.Button trois;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button virgule;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Label displayBottom;
        private System.Windows.Forms.Label displayTop;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
    }
}

