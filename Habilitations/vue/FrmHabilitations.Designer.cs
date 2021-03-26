namespace Habilitations.vue
{
    partial class FrmHabilitations
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
            this.components = new System.ComponentModel.Container();
            this.grbLesDeveloppeurs = new System.Windows.Forms.GroupBox();
            this.btnChangerPwd = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvLesDeveloppeurs = new System.Windows.Forms.DataGridView();
            this.habilitationsDataSet = new Habilitations.habilitationsDataSet();
            this.developpeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developpeurTableAdapter = new Habilitations.habilitationsDataSetTableAdapters.developpeurTableAdapter();
            this.grbAjouterModifier = new System.Windows.Forms.GroupBox();
            this.btnDevAnnuler = new System.Windows.Forms.Button();
            this.btnDevEnregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProfil = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grbMdp = new System.Windows.Forms.GroupBox();
            this.btnMdpAnnuler = new System.Windows.Forms.Button();
            this.btnMdpEnregistrer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mdp2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mdp1 = new System.Windows.Forms.TextBox();
            this.grbLesDeveloppeurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesDeveloppeurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilitationsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developpeurBindingSource)).BeginInit();
            this.grbAjouterModifier.SuspendLayout();
            this.grbMdp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLesDeveloppeurs
            // 
            this.grbLesDeveloppeurs.Controls.Add(this.btnChangerPwd);
            this.grbLesDeveloppeurs.Controls.Add(this.btnSupprimer);
            this.grbLesDeveloppeurs.Controls.Add(this.btnModifier);
            this.grbLesDeveloppeurs.Controls.Add(this.dgvLesDeveloppeurs);
            this.grbLesDeveloppeurs.Location = new System.Drawing.Point(12, 12);
            this.grbLesDeveloppeurs.Name = "grbLesDeveloppeurs";
            this.grbLesDeveloppeurs.Size = new System.Drawing.Size(975, 418);
            this.grbLesDeveloppeurs.TabIndex = 0;
            this.grbLesDeveloppeurs.TabStop = false;
            this.grbLesDeveloppeurs.Text = "Les développeurs";
            // 
            // btnChangerPwd
            // 
            this.btnChangerPwd.Location = new System.Drawing.Point(331, 361);
            this.btnChangerPwd.Name = "btnChangerPwd";
            this.btnChangerPwd.Size = new System.Drawing.Size(156, 43);
            this.btnChangerPwd.TabIndex = 3;
            this.btnChangerPwd.Text = "Changer mdp";
            this.btnChangerPwd.UseVisualStyleBackColor = true;
            this.btnChangerPwd.Click += new System.EventHandler(this.btnChangerPwd_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(169, 361);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(156, 43);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(7, 361);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(156, 43);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvLesDeveloppeurs
            // 
            this.dgvLesDeveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesDeveloppeurs.Location = new System.Drawing.Point(7, 26);
            this.dgvLesDeveloppeurs.Name = "dgvLesDeveloppeurs";
            this.dgvLesDeveloppeurs.RowHeadersWidth = 62;
            this.dgvLesDeveloppeurs.RowTemplate.Height = 28;
            this.dgvLesDeveloppeurs.Size = new System.Drawing.Size(962, 329);
            this.dgvLesDeveloppeurs.TabIndex = 0;
            // 
            // habilitationsDataSet
            // 
            this.habilitationsDataSet.DataSetName = "habilitationsDataSet";
            this.habilitationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // developpeurBindingSource
            // 
            this.developpeurBindingSource.DataMember = "developpeur";
            this.developpeurBindingSource.DataSource = this.habilitationsDataSet;
            // 
            // developpeurTableAdapter
            // 
            this.developpeurTableAdapter.ClearBeforeFill = true;
            // 
            // grbAjouterModifier
            // 
            this.grbAjouterModifier.Controls.Add(this.btnDevAnnuler);
            this.grbAjouterModifier.Controls.Add(this.btnDevEnregistrer);
            this.grbAjouterModifier.Controls.Add(this.label5);
            this.grbAjouterModifier.Controls.Add(this.cboProfil);
            this.grbAjouterModifier.Controls.Add(this.txtTel);
            this.grbAjouterModifier.Controls.Add(this.txtMail);
            this.grbAjouterModifier.Controls.Add(this.label4);
            this.grbAjouterModifier.Controls.Add(this.label3);
            this.grbAjouterModifier.Controls.Add(this.txtPrenom);
            this.grbAjouterModifier.Controls.Add(this.label2);
            this.grbAjouterModifier.Controls.Add(this.label1);
            this.grbAjouterModifier.Controls.Add(this.txtNom);
            this.grbAjouterModifier.Location = new System.Drawing.Point(12, 436);
            this.grbAjouterModifier.Name = "grbAjouterModifier";
            this.grbAjouterModifier.Size = new System.Drawing.Size(975, 166);
            this.grbAjouterModifier.TabIndex = 1;
            this.grbAjouterModifier.TabStop = false;
            this.grbAjouterModifier.Text = "Ajouter un développeur";
            // 
            // btnDevAnnuler
            // 
            this.btnDevAnnuler.Location = new System.Drawing.Point(169, 118);
            this.btnDevAnnuler.Name = "btnDevAnnuler";
            this.btnDevAnnuler.Size = new System.Drawing.Size(156, 38);
            this.btnDevAnnuler.TabIndex = 11;
            this.btnDevAnnuler.Text = "Annuler";
            this.btnDevAnnuler.UseVisualStyleBackColor = true;
            this.btnDevAnnuler.Click += new System.EventHandler(this.btnDevAnnuler_Click);
            // 
            // btnDevEnregistrer
            // 
            this.btnDevEnregistrer.Location = new System.Drawing.Point(7, 118);
            this.btnDevEnregistrer.Name = "btnDevEnregistrer";
            this.btnDevEnregistrer.Size = new System.Drawing.Size(156, 38);
            this.btnDevEnregistrer.TabIndex = 10;
            this.btnDevEnregistrer.Text = "Enregistrer";
            this.btnDevEnregistrer.UseVisualStyleBackColor = true;
            this.btnDevEnregistrer.Click += new System.EventHandler(this.btnDevEnregistrer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "profil";
            // 
            // cboProfil
            // 
            this.cboProfil.FormattingEnabled = true;
            this.cboProfil.Location = new System.Drawing.Point(515, 101);
            this.cboProfil.Name = "cboProfil";
            this.cboProfil.Size = new System.Drawing.Size(360, 28);
            this.cboProfil.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(515, 68);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(360, 26);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(515, 33);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(454, 26);
            this.txtMail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "mail";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(81, 66);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(347, 26);
            this.txtPrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(81, 34);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(347, 26);
            this.txtNom.TabIndex = 0;
            // 
            // grbMdp
            // 
            this.grbMdp.Controls.Add(this.btnMdpAnnuler);
            this.grbMdp.Controls.Add(this.btnMdpEnregistrer);
            this.grbMdp.Controls.Add(this.label7);
            this.grbMdp.Controls.Add(this.mdp2);
            this.grbMdp.Controls.Add(this.label6);
            this.grbMdp.Controls.Add(this.mdp1);
            this.grbMdp.Location = new System.Drawing.Point(12, 608);
            this.grbMdp.Name = "grbMdp";
            this.grbMdp.Size = new System.Drawing.Size(975, 131);
            this.grbMdp.TabIndex = 2;
            this.grbMdp.TabStop = false;
            this.grbMdp.Text = "Changer le mot de passe";
            // 
            // btnMdpAnnuler
            // 
            this.btnMdpAnnuler.Location = new System.Drawing.Point(169, 80);
            this.btnMdpAnnuler.Name = "btnMdpAnnuler";
            this.btnMdpAnnuler.Size = new System.Drawing.Size(156, 42);
            this.btnMdpAnnuler.TabIndex = 5;
            this.btnMdpAnnuler.Text = "Annuler";
            this.btnMdpAnnuler.UseVisualStyleBackColor = true;
            this.btnMdpAnnuler.Click += new System.EventHandler(this.btnMdpAnnuler_Click);
            // 
            // btnMdpEnregistrer
            // 
            this.btnMdpEnregistrer.Location = new System.Drawing.Point(7, 80);
            this.btnMdpEnregistrer.Name = "btnMdpEnregistrer";
            this.btnMdpEnregistrer.Size = new System.Drawing.Size(156, 42);
            this.btnMdpEnregistrer.TabIndex = 4;
            this.btnMdpEnregistrer.Text = "Enregistrer";
            this.btnMdpEnregistrer.UseVisualStyleBackColor = true;
            this.btnMdpEnregistrer.Click += new System.EventHandler(this.btnMdpEnregistrer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "encore";
            // 
            // mdp2
            // 
            this.mdp2.Location = new System.Drawing.Point(515, 35);
            this.mdp2.Name = "mdp2";
            this.mdp2.PasswordChar = '*';
            this.mdp2.Size = new System.Drawing.Size(360, 26);
            this.mdp2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "mdp";
            // 
            // mdp1
            // 
            this.mdp1.Location = new System.Drawing.Point(81, 35);
            this.mdp1.Name = "mdp1";
            this.mdp1.PasswordChar = '*';
            this.mdp1.Size = new System.Drawing.Size(347, 26);
            this.mdp1.TabIndex = 0;
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 759);
            this.Controls.Add(this.grbMdp);
            this.Controls.Add(this.grbAjouterModifier);
            this.Controls.Add(this.grbLesDeveloppeurs);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations";
            this.grbLesDeveloppeurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesDeveloppeurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilitationsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developpeurBindingSource)).EndInit();
            this.grbAjouterModifier.ResumeLayout(false);
            this.grbAjouterModifier.PerformLayout();
            this.grbMdp.ResumeLayout(false);
            this.grbMdp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLesDeveloppeurs;
        private habilitationsDataSet habilitationsDataSet;
        private System.Windows.Forms.BindingSource developpeurBindingSource;
        private habilitationsDataSetTableAdapters.developpeurTableAdapter developpeurTableAdapter;
        private System.Windows.Forms.Button btnChangerPwd;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvLesDeveloppeurs;
        private System.Windows.Forms.GroupBox grbAjouterModifier;
        private System.Windows.Forms.Button btnDevAnnuler;
        private System.Windows.Forms.Button btnDevEnregistrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboProfil;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grbMdp;
        private System.Windows.Forms.Button btnMdpAnnuler;
        private System.Windows.Forms.Button btnMdpEnregistrer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mdp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mdp1;
    }
}

