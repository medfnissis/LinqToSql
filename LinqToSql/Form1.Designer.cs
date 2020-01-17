namespace LinqToSql
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtprenom = new MetroFramework.Controls.MetroTextBox();
            this.txtnom = new MetroFramework.Controls.MetroTextBox();
            this.txtcin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butrechercher = new System.Windows.Forms.Button();
            this.rech = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aproposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txrrecin = new MetroFramework.Controls.MetroLabel();
            this.txtrenom = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.recin = new MetroFramework.Controls.MetroTextBox();
            this.renom = new MetroFramework.Controls.MetroTextBox();
            this.reprenom = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(27, 74);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1013, 471);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.button3);
            this.metroTabPage1.Controls.Add(this.txtprenom);
            this.metroTabPage1.Controls.Add(this.txtnom);
            this.metroTabPage1.Controls.Add(this.txtcin);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1005, 432);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Ajouter Un Stagiaire";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 362);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtprenom
            // 
            this.txtprenom.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtprenom.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtprenom.Location = new System.Drawing.Point(377, 278);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(351, 28);
            this.txtprenom.TabIndex = 3;
            // 
            // txtnom
            // 
            this.txtnom.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtnom.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtnom.Location = new System.Drawing.Point(377, 177);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(351, 28);
            this.txtnom.TabIndex = 3;
            // 
            // txtcin
            // 
            this.txtcin.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtcin.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtcin.Location = new System.Drawing.Point(377, 66);
            this.txtcin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcin.Name = "txtcin";
            this.txtcin.Size = new System.Drawing.Size(351, 28);
            this.txtcin.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(195, 278);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 50);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "PRENOM :\r\n";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(229, 177);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 50);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "NOM :\r\n";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(243, 66);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 50);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "CIN :\r\n";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.butrechercher);
            this.metroTabPage2.Controls.Add(this.rech);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.menuStrip1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarSize = 12;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1005, 432);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Rechercher Un Stagiaire";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarSize = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reprenom);
            this.groupBox1.Controls.Add(this.renom);
            this.groupBox1.Controls.Add(this.recin);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtrenom);
            this.groupBox1.Controls.Add(this.txrrecin);
            this.groupBox1.Location = new System.Drawing.Point(52, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(879, 227);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // butrechercher
            // 
            this.butrechercher.Location = new System.Drawing.Point(605, 76);
            this.butrechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butrechercher.Name = "butrechercher";
            this.butrechercher.Size = new System.Drawing.Size(127, 28);
            this.butrechercher.TabIndex = 5;
            this.butrechercher.Text = "Rechercher";
            this.butrechercher.UseVisualStyleBackColor = true;
            this.butrechercher.Click += new System.EventHandler(this.butrechercher_Click);
            // 
            // rech
            // 
            this.rech.Location = new System.Drawing.Point(391, 76);
            this.rech.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(180, 28);
            this.rech.TabIndex = 4;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(273, 79);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "CIN :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stagiaireToolStripMenuItem,
            this.aproposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stagiaireToolStripMenuItem
            // 
            this.stagiaireToolStripMenuItem.Name = "stagiaireToolStripMenuItem";
            this.stagiaireToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.stagiaireToolStripMenuItem.Text = "Stagiaire";
            // 
            // aproposToolStripMenuItem
            // 
            this.aproposToolStripMenuItem.Name = "aproposToolStripMenuItem";
            this.aproposToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.aproposToolStripMenuItem.Text = "A propos";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroButton1);
            this.metroTabPage3.Controls.Add(this.dataGridView1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarSize = 12;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1005, 432);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Liste Des Stagiaire";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarSize = 13;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(387, 76);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(207, 28);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "List des stagiaire";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 260);
            this.dataGridView1.TabIndex = 2;
            // 
            // txrrecin
            // 
            this.txrrecin.AutoSize = true;
            this.txrrecin.Location = new System.Drawing.Point(143, 43);
            this.txrrecin.Name = "txrrecin";
            this.txrrecin.Size = new System.Drawing.Size(39, 20);
            this.txrrecin.TabIndex = 0;
            this.txrrecin.Text = "CIN :";
            // 
            // txtrenom
            // 
            this.txtrenom.AutoSize = true;
            this.txtrenom.Location = new System.Drawing.Point(143, 103);
            this.txtrenom.Name = "txtrenom";
            this.txtrenom.Size = new System.Drawing.Size(43, 20);
            this.txtrenom.TabIndex = 0;
            this.txtrenom.Text = "Nom:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(143, 165);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 20);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Prenom :";
            // 
            // recin
            // 
            this.recin.Location = new System.Drawing.Point(272, 39);
            this.recin.Name = "recin";
            this.recin.Size = new System.Drawing.Size(281, 23);
            this.recin.TabIndex = 1;
            // 
            // renom
            // 
            this.renom.Location = new System.Drawing.Point(272, 103);
            this.renom.Name = "renom";
            this.renom.Size = new System.Drawing.Size(281, 23);
            this.renom.TabIndex = 1;
            // 
            // reprenom
            // 
            this.reprenom.Location = new System.Drawing.Point(272, 165);
            this.reprenom.Name = "reprenom";
            this.reprenom.Size = new System.Drawing.Size(281, 23);
            this.reprenom.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 570);
            this.Controls.Add(this.metroTabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Gestion Stagiaire";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox txtprenom;
        private MetroFramework.Controls.MetroTextBox txtnom;
        private MetroFramework.Controls.MetroTextBox txtcin;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butrechercher;
        private MetroFramework.Controls.MetroTextBox rech;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aproposToolStripMenuItem;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox reprenom;
        private MetroFramework.Controls.MetroTextBox renom;
        private MetroFramework.Controls.MetroTextBox recin;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel txtrenom;
        private MetroFramework.Controls.MetroLabel txrrecin;
    }
}

