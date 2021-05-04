using System.Windows.Forms;

namespace Fakult‰tenrechner
{
    partial class Rechner 
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelˆscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode f¸r die Designerunterst¸tzung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor ge‰ndert werden.
        /// </summary>
        public void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.z‰hlschleifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopfschleifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuﬂschleifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtbxeingabe = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblergebnis = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.z‰hlschleifeToolStripMenuItem,
            this.kopfschleifeToolStripMenuItem,
            this.fuﬂschleifeToolStripMenuItem,
            this.endeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // z‰hlschleifeToolStripMenuItem
            // 
            this.z‰hlschleifeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z‰hlschleifeToolStripMenuItem.Name = "z‰hlschleifeToolStripMenuItem";
            this.z‰hlschleifeToolStripMenuItem.Size = new System.Drawing.Size(135, 34);
            this.z‰hlschleifeToolStripMenuItem.Text = "Z‰hlschleife";
            this.z‰hlschleifeToolStripMenuItem.Click += new System.EventHandler(this.z‰hlschleifeToolStripMenuItem_Click);
            // 
            // kopfschleifeToolStripMenuItem
            // 
            this.kopfschleifeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kopfschleifeToolStripMenuItem.Name = "kopfschleifeToolStripMenuItem";
            this.kopfschleifeToolStripMenuItem.Size = new System.Drawing.Size(137, 34);
            this.kopfschleifeToolStripMenuItem.Text = "Kopfschleife";
            this.kopfschleifeToolStripMenuItem.Click += new System.EventHandler(this.kopfschleifeToolStripMenuItem_Click);
            // 
            // fuﬂschleifeToolStripMenuItem
            // 
            this.fuﬂschleifeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuﬂschleifeToolStripMenuItem.Name = "fuﬂschleifeToolStripMenuItem";
            this.fuﬂschleifeToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.fuﬂschleifeToolStripMenuItem.Text = "Fuﬂschleife";
            this.fuﬂschleifeToolStripMenuItem.Click += new System.EventHandler(this.fuﬂschleifeToolStripMenuItem_Click);
            // 
            // endeToolStripMenuItem
            // 
            this.endeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endeToolStripMenuItem.Name = "endeToolStripMenuItem";
            this.endeToolStripMenuItem.Size = new System.Drawing.Size(71, 34);
            this.endeToolStripMenuItem.Text = "Ende";
            this.endeToolStripMenuItem.Click += new System.EventHandler(this.endeToolStripMenuItem_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(22, 99);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(143, 24);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Die Fakult‰t von";
            // 
            // txtbxeingabe
            // 
            this.txtbxeingabe.Location = new System.Drawing.Point(171, 104);
            this.txtbxeingabe.Name = "txtbxeingabe";
            this.txtbxeingabe.ShortcutsEnabled = false;
            this.txtbxeingabe.Size = new System.Drawing.Size(48, 20);
            this.txtbxeingabe.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(225, 99);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(27, 24);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "ist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 4;
            // 
            // lblergebnis
            // 
            this.lblergebnis.AutoSize = true;
            this.lblergebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblergebnis.Location = new System.Drawing.Point(258, 99);
            this.lblergebnis.Name = "lblergebnis";
            this.lblergebnis.Size = new System.Drawing.Size(40, 24);
            this.lblergebnis.TabIndex = 5;
            this.lblergebnis.Text = "      ";
            // 
            // Rechner
            // 
            this.ClientSize = new System.Drawing.Size(502, 203);
            this.Controls.Add(this.lblergebnis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtbxeingabe);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Rechner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem z‰hlschleifeToolStripMenuItem;
        private ToolStripMenuItem kopfschleifeToolStripMenuItem;
        private ToolStripMenuItem fuﬂschleifeToolStripMenuItem;
        private ToolStripMenuItem endeToolStripMenuItem;
        private Label lbl1;
        private TextBox txtbxeingabe;
        private Label lbl2;
        private Label label3;
        private Label lblergebnis;
    }
}