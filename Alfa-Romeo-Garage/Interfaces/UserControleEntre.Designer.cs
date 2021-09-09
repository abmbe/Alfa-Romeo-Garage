﻿
namespace Alfa_Romeo_Garage.Interfaces
{
    partial class UserControleEntre
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonEditer = new System.Windows.Forms.Button();
            this.dataGridViewE = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelVehicule = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxVehicule = new System.Windows.Forms.ComboBox();
            this.buttonConfirmerIntervention = new System.Windows.Forms.Button();
            this.buttonAnnulerIntervention = new System.Windows.Forms.Button();
            this.buttonEditerIntervention = new System.Windows.Forms.Button();
            this.buttonAjouterIntervention = new System.Windows.Forms.Button();
            this.buttonSupprimerIntervention = new System.Windows.Forms.Button();
            this.Entretien = new System.Windows.Forms.Label();
            this.labelIntervention = new System.Windows.Forms.Label();
            this.comboBoxEntretien = new System.Windows.Forms.ComboBox();
            this.comboBoxIntervention = new System.Windows.Forms.ComboBox();
            this.dataGridviewV = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDateEntretien = new CustomControls.RJControls.RJDatePicker();
            this.cID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVehicule1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClient1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrix1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTVA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNomPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroNational = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdresseEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateEnregistrement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditer
            // 
            this.buttonEditer.BackColor = System.Drawing.Color.Crimson;
            this.buttonEditer.FlatAppearance.BorderSize = 0;
            this.buttonEditer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditer.Location = new System.Drawing.Point(22, 257);
            this.buttonEditer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditer.Name = "buttonEditer";
            this.buttonEditer.Size = new System.Drawing.Size(290, 39);
            this.buttonEditer.TabIndex = 109;
            this.buttonEditer.Text = "Editer un entretien";
            this.buttonEditer.UseVisualStyleBackColor = false;
            this.buttonEditer.Click += new System.EventHandler(this.buttonEditer_Click);
            // 
            // dataGridViewE
            // 
            this.dataGridViewE.AllowUserToAddRows = false;
            this.dataGridViewE.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewE.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewE.ColumnHeadersHeight = 29;
            this.dataGridViewE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cVehicule,
            this.cDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewE.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewE.GridColor = System.Drawing.Color.White;
            this.dataGridViewE.Location = new System.Drawing.Point(21, 377);
            this.dataGridViewE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewE.Name = "dataGridViewE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewE.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewE.RowHeadersVisible = false;
            this.dataGridViewE.RowHeadersWidth = 51;
            this.dataGridViewE.RowTemplate.Height = 24;
            this.dataGridViewE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewE.Size = new System.Drawing.Size(538, 188);
            this.dataGridViewE.TabIndex = 110;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "id";
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 50;
            // 
            // cVehicule
            // 
            this.cVehicule.DataPropertyName = "vehicule";
            this.cVehicule.HeaderText = "Véhicule";
            this.cVehicule.MinimumWidth = 6;
            this.cVehicule.Name = "cVehicule";
            this.cVehicule.ReadOnly = true;
            this.cVehicule.Width = 180;
            // 
            // cDate
            // 
            this.cDate.DataPropertyName = "date";
            this.cDate.HeaderText = "Date d\'entretien";
            this.cDate.MinimumWidth = 6;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 125;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Crimson;
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouter.Location = new System.Drawing.Point(22, 214);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(290, 39);
            this.buttonAjouter.TabIndex = 108;
            this.buttonAjouter.Text = "Ajouter un entretien";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.BackColor = System.Drawing.Color.Crimson;
            this.buttonConfirmer.FlatAppearance.BorderSize = 0;
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmer.Location = new System.Drawing.Point(22, 214);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(290, 39);
            this.buttonConfirmer.TabIndex = 105;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = false;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Crimson;
            this.buttonAnnuler.FlatAppearance.BorderSize = 0;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(22, 257);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(289, 39);
            this.buttonAnnuler.TabIndex = 104;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Crimson;
            this.labelDate.Location = new System.Drawing.Point(18, 113);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(122, 19);
            this.labelDate.TabIndex = 107;
            this.labelDate.Text = "Date d\'entretien";
            // 
            // labelVehicule
            // 
            this.labelVehicule.AutoSize = true;
            this.labelVehicule.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicule.ForeColor = System.Drawing.Color.Crimson;
            this.labelVehicule.Location = new System.Drawing.Point(18, 60);
            this.labelVehicule.Name = "labelVehicule";
            this.labelVehicule.Size = new System.Drawing.Size(69, 19);
            this.labelVehicule.TabIndex = 106;
            this.labelVehicule.Text = "Véhicule";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Crimson;
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimer.Location = new System.Drawing.Point(22, 300);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(290, 39);
            this.buttonSupprimer.TabIndex = 103;
            this.buttonSupprimer.Text = "Supprimer un entretien";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Crimson;
            this.labelTitle.Location = new System.Drawing.Point(16, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(225, 30);
            this.labelTitle.TabIndex = 102;
            this.labelTitle.Text = "TABLEAU DE BORD";
            // 
            // comboBoxVehicule
            // 
            this.comboBoxVehicule.BackColor = System.Drawing.Color.Black;
            this.comboBoxVehicule.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVehicule.ForeColor = System.Drawing.Color.White;
            this.comboBoxVehicule.FormattingEnabled = true;
            this.comboBoxVehicule.Location = new System.Drawing.Point(21, 82);
            this.comboBoxVehicule.Name = "comboBoxVehicule";
            this.comboBoxVehicule.Size = new System.Drawing.Size(290, 25);
            this.comboBoxVehicule.TabIndex = 113;
            // 
            // buttonConfirmerIntervention
            // 
            this.buttonConfirmerIntervention.BackColor = System.Drawing.Color.Crimson;
            this.buttonConfirmerIntervention.FlatAppearance.BorderSize = 0;
            this.buttonConfirmerIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmerIntervention.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmerIntervention.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmerIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmerIntervention.Location = new System.Drawing.Point(411, 214);
            this.buttonConfirmerIntervention.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmerIntervention.Name = "buttonConfirmerIntervention";
            this.buttonConfirmerIntervention.Size = new System.Drawing.Size(290, 39);
            this.buttonConfirmerIntervention.TabIndex = 127;
            this.buttonConfirmerIntervention.Text = "Confirmer";
            this.buttonConfirmerIntervention.UseVisualStyleBackColor = false;
            this.buttonConfirmerIntervention.Click += new System.EventHandler(this.buttonConfirmerIntervention_Click);
            // 
            // buttonAnnulerIntervention
            // 
            this.buttonAnnulerIntervention.BackColor = System.Drawing.Color.Crimson;
            this.buttonAnnulerIntervention.FlatAppearance.BorderSize = 0;
            this.buttonAnnulerIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerIntervention.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnulerIntervention.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnnulerIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnulerIntervention.Location = new System.Drawing.Point(411, 257);
            this.buttonAnnulerIntervention.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnnulerIntervention.Name = "buttonAnnulerIntervention";
            this.buttonAnnulerIntervention.Size = new System.Drawing.Size(290, 39);
            this.buttonAnnulerIntervention.TabIndex = 126;
            this.buttonAnnulerIntervention.Text = "Annuler";
            this.buttonAnnulerIntervention.UseVisualStyleBackColor = false;
            this.buttonAnnulerIntervention.Click += new System.EventHandler(this.buttonAnnulerIntervention_Click);
            // 
            // buttonEditerIntervention
            // 
            this.buttonEditerIntervention.BackColor = System.Drawing.Color.Crimson;
            this.buttonEditerIntervention.FlatAppearance.BorderSize = 0;
            this.buttonEditerIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditerIntervention.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditerIntervention.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditerIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditerIntervention.Location = new System.Drawing.Point(411, 257);
            this.buttonEditerIntervention.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditerIntervention.Name = "buttonEditerIntervention";
            this.buttonEditerIntervention.Size = new System.Drawing.Size(290, 39);
            this.buttonEditerIntervention.TabIndex = 125;
            this.buttonEditerIntervention.Text = "Editer";
            this.buttonEditerIntervention.UseVisualStyleBackColor = false;
            this.buttonEditerIntervention.Click += new System.EventHandler(this.buttonEditerIntervention_Click);
            // 
            // buttonAjouterIntervention
            // 
            this.buttonAjouterIntervention.BackColor = System.Drawing.Color.Crimson;
            this.buttonAjouterIntervention.FlatAppearance.BorderSize = 0;
            this.buttonAjouterIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterIntervention.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterIntervention.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAjouterIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterIntervention.Location = new System.Drawing.Point(411, 214);
            this.buttonAjouterIntervention.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjouterIntervention.Name = "buttonAjouterIntervention";
            this.buttonAjouterIntervention.Size = new System.Drawing.Size(290, 39);
            this.buttonAjouterIntervention.TabIndex = 124;
            this.buttonAjouterIntervention.Text = "Ajouter";
            this.buttonAjouterIntervention.UseVisualStyleBackColor = false;
            this.buttonAjouterIntervention.Click += new System.EventHandler(this.buttonAjouterIntervention_Click);
            // 
            // buttonSupprimerIntervention
            // 
            this.buttonSupprimerIntervention.BackColor = System.Drawing.Color.Crimson;
            this.buttonSupprimerIntervention.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerIntervention.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerIntervention.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupprimerIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerIntervention.Location = new System.Drawing.Point(411, 300);
            this.buttonSupprimerIntervention.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSupprimerIntervention.Name = "buttonSupprimerIntervention";
            this.buttonSupprimerIntervention.Size = new System.Drawing.Size(290, 39);
            this.buttonSupprimerIntervention.TabIndex = 123;
            this.buttonSupprimerIntervention.Text = "Supprimer ";
            this.buttonSupprimerIntervention.UseVisualStyleBackColor = false;
            this.buttonSupprimerIntervention.Click += new System.EventHandler(this.buttonSupprimerIntervention_Click);
            // 
            // Entretien
            // 
            this.Entretien.AutoSize = true;
            this.Entretien.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entretien.ForeColor = System.Drawing.Color.Crimson;
            this.Entretien.Location = new System.Drawing.Point(407, 122);
            this.Entretien.Name = "Entretien";
            this.Entretien.Size = new System.Drawing.Size(70, 19);
            this.Entretien.TabIndex = 122;
            this.Entretien.Text = "Entretien";
            // 
            // labelIntervention
            // 
            this.labelIntervention.AutoSize = true;
            this.labelIntervention.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntervention.ForeColor = System.Drawing.Color.Crimson;
            this.labelIntervention.Location = new System.Drawing.Point(407, 58);
            this.labelIntervention.Name = "labelIntervention";
            this.labelIntervention.Size = new System.Drawing.Size(91, 19);
            this.labelIntervention.TabIndex = 121;
            this.labelIntervention.Text = "Intervention";
            // 
            // comboBoxEntretien
            // 
            this.comboBoxEntretien.BackColor = System.Drawing.Color.Black;
            this.comboBoxEntretien.ForeColor = System.Drawing.Color.White;
            this.comboBoxEntretien.FormattingEnabled = true;
            this.comboBoxEntretien.Location = new System.Drawing.Point(411, 145);
            this.comboBoxEntretien.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEntretien.Name = "comboBoxEntretien";
            this.comboBoxEntretien.Size = new System.Drawing.Size(290, 24);
            this.comboBoxEntretien.TabIndex = 120;
            // 
            // comboBoxIntervention
            // 
            this.comboBoxIntervention.BackColor = System.Drawing.Color.Black;
            this.comboBoxIntervention.ForeColor = System.Drawing.Color.White;
            this.comboBoxIntervention.FormattingEnabled = true;
            this.comboBoxIntervention.Location = new System.Drawing.Point(411, 81);
            this.comboBoxIntervention.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIntervention.Name = "comboBoxIntervention";
            this.comboBoxIntervention.Size = new System.Drawing.Size(290, 24);
            this.comboBoxIntervention.TabIndex = 119;
            // 
            // dataGridviewV
            // 
            this.dataGridviewV.AllowUserToAddRows = false;
            this.dataGridviewV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridviewV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridviewV.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridviewV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridviewV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridviewV.ColumnHeadersHeight = 29;
            this.dataGridviewV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID1,
            this.cDescription1,
            this.cVehicule1,
            this.cClient1,
            this.cDate1,
            this.cPrix1,
            this.cTVA1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridviewV.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridviewV.GridColor = System.Drawing.Color.White;
            this.dataGridviewV.Location = new System.Drawing.Point(656, 377);
            this.dataGridviewV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridviewV.Name = "dataGridviewV";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridviewV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridviewV.RowHeadersVisible = false;
            this.dataGridviewV.RowHeadersWidth = 51;
            this.dataGridviewV.RowTemplate.Height = 24;
            this.dataGridviewV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridviewV.Size = new System.Drawing.Size(551, 188);
            this.dataGridviewV.TabIndex = 118;
            // 
            // dateTimePickerDateEntretien
            // 
            this.dateTimePickerDateEntretien.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePickerDateEntretien.BorderSize = 1;
            this.dateTimePickerDateEntretien.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateEntretien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateEntretien.Location = new System.Drawing.Point(21, 135);
            this.dateTimePickerDateEntretien.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePickerDateEntretien.Name = "dateTimePickerDateEntretien";
            this.dateTimePickerDateEntretien.Size = new System.Drawing.Size(290, 35);
            this.dateTimePickerDateEntretien.SkinColor = System.Drawing.Color.Black;
            this.dateTimePickerDateEntretien.TabIndex = 111;
            this.dateTimePickerDateEntretien.TextColor = System.Drawing.Color.White;
            // 
            // cID1
            // 
            this.cID1.DataPropertyName = "id";
            this.cID1.HeaderText = "ID";
            this.cID1.MinimumWidth = 6;
            this.cID1.Name = "cID1";
            this.cID1.ReadOnly = true;
            this.cID1.Width = 50;
            // 
            // cDescription1
            // 
            this.cDescription1.DataPropertyName = "description";
            this.cDescription1.HeaderText = "Description";
            this.cDescription1.MinimumWidth = 6;
            this.cDescription1.Name = "cDescription1";
            this.cDescription1.ReadOnly = true;
            this.cDescription1.Width = 125;
            // 
            // cVehicule1
            // 
            this.cVehicule1.DataPropertyName = "vehicule";
            this.cVehicule1.HeaderText = "Vehicule";
            this.cVehicule1.MinimumWidth = 6;
            this.cVehicule1.Name = "cVehicule1";
            this.cVehicule1.ReadOnly = true;
            this.cVehicule1.Width = 125;
            // 
            // cClient1
            // 
            this.cClient1.DataPropertyName = "client";
            this.cClient1.HeaderText = "Client";
            this.cClient1.MinimumWidth = 6;
            this.cClient1.Name = "cClient1";
            this.cClient1.Width = 125;
            // 
            // cDate1
            // 
            this.cDate1.DataPropertyName = "date";
            this.cDate1.HeaderText = "Date";
            this.cDate1.MinimumWidth = 6;
            this.cDate1.Name = "cDate1";
            this.cDate1.ReadOnly = true;
            this.cDate1.Width = 150;
            // 
            // cPrix1
            // 
            this.cPrix1.DataPropertyName = "prix";
            this.cPrix1.HeaderText = "Prix";
            this.cPrix1.MinimumWidth = 6;
            this.cPrix1.Name = "cPrix1";
            this.cPrix1.ReadOnly = true;
            this.cPrix1.Width = 180;
            // 
            // cTVA1
            // 
            this.cTVA1.DataPropertyName = "tva";
            this.cTVA1.HeaderText = "TVA";
            this.cTVA1.MinimumWidth = 6;
            this.cTVA1.Name = "cTVA1";
            this.cTVA1.ReadOnly = true;
            this.cTVA1.Width = 125;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewClients.ColumnHeadersHeight = 29;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cNomPrenom,
            this.cDateNaissance,
            this.cNumeroNational,
            this.cAdresse,
            this.cAdresseEmail,
            this.cNumeroTelephone,
            this.cDateEnregistrement});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClients.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewClients.GridColor = System.Drawing.Color.White;
            this.dataGridViewClients.Location = new System.Drawing.Point(656, 587);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(551, 201);
            this.dataGridViewClients.TabIndex = 128;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // cNomPrenom
            // 
            this.cNomPrenom.DataPropertyName = "nomPrenom";
            this.cNomPrenom.HeaderText = "Nom complet";
            this.cNomPrenom.MinimumWidth = 6;
            this.cNomPrenom.Name = "cNomPrenom";
            this.cNomPrenom.ReadOnly = true;
            this.cNomPrenom.Width = 180;
            // 
            // cDateNaissance
            // 
            this.cDateNaissance.DataPropertyName = "dateNaissance";
            this.cDateNaissance.HeaderText = "Date de naissance";
            this.cDateNaissance.MinimumWidth = 6;
            this.cDateNaissance.Name = "cDateNaissance";
            this.cDateNaissance.ReadOnly = true;
            this.cDateNaissance.Width = 150;
            // 
            // cNumeroNational
            // 
            this.cNumeroNational.DataPropertyName = "numeroNational";
            this.cNumeroNational.HeaderText = "Numéro du registre national";
            this.cNumeroNational.MinimumWidth = 6;
            this.cNumeroNational.Name = "cNumeroNational";
            this.cNumeroNational.ReadOnly = true;
            this.cNumeroNational.Width = 150;
            // 
            // cAdresse
            // 
            this.cAdresse.DataPropertyName = "adresse";
            this.cAdresse.HeaderText = "Adresse";
            this.cAdresse.MinimumWidth = 6;
            this.cAdresse.Name = "cAdresse";
            this.cAdresse.ReadOnly = true;
            this.cAdresse.Width = 280;
            // 
            // cAdresseEmail
            // 
            this.cAdresseEmail.DataPropertyName = "adresseEmail";
            this.cAdresseEmail.HeaderText = "Adresse e-mail";
            this.cAdresseEmail.MinimumWidth = 6;
            this.cAdresseEmail.Name = "cAdresseEmail";
            this.cAdresseEmail.ReadOnly = true;
            this.cAdresseEmail.Width = 190;
            // 
            // cNumeroTelephone
            // 
            this.cNumeroTelephone.DataPropertyName = "numeroTelephone";
            this.cNumeroTelephone.HeaderText = "Numéro de télephone";
            this.cNumeroTelephone.MinimumWidth = 6;
            this.cNumeroTelephone.Name = "cNumeroTelephone";
            this.cNumeroTelephone.ReadOnly = true;
            this.cNumeroTelephone.Width = 150;
            // 
            // cDateEnregistrement
            // 
            this.cDateEnregistrement.DataPropertyName = "dateEnregistrement";
            this.cDateEnregistrement.HeaderText = "Date de dernière modification";
            this.cDateEnregistrement.MinimumWidth = 6;
            this.cDateEnregistrement.Name = "cDateEnregistrement";
            this.cDateEnregistrement.ReadOnly = true;
            this.cDateEnregistrement.Width = 150;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Crimson;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(1115, 20);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(92, 40);
            this.buttonRefresh.TabIndex = 130;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // UserControleEntre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.buttonConfirmerIntervention);
            this.Controls.Add(this.buttonAnnulerIntervention);
            this.Controls.Add(this.buttonEditerIntervention);
            this.Controls.Add(this.buttonAjouterIntervention);
            this.Controls.Add(this.buttonSupprimerIntervention);
            this.Controls.Add(this.Entretien);
            this.Controls.Add(this.labelIntervention);
            this.Controls.Add(this.comboBoxEntretien);
            this.Controls.Add(this.comboBoxIntervention);
            this.Controls.Add(this.dataGridviewV);
            this.Controls.Add(this.comboBoxVehicule);
            this.Controls.Add(this.dateTimePickerDateEntretien);
            this.Controls.Add(this.buttonEditer);
            this.Controls.Add(this.dataGridViewE);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelVehicule);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelTitle);
            this.Name = "UserControleEntre";
            this.Size = new System.Drawing.Size(1260, 805);
            this.Load += new System.EventHandler(this.UserControleEntre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.DataGridView dataGridViewE;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelVehicule;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label labelTitle;
        private CustomControls.RJControls.RJDatePicker dateTimePickerDateEntretien;
        private System.Windows.Forms.ComboBox comboBoxVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.Button buttonConfirmerIntervention;
        private System.Windows.Forms.Button buttonAnnulerIntervention;
        private System.Windows.Forms.Button buttonEditerIntervention;
        private System.Windows.Forms.Button buttonAjouterIntervention;
        private System.Windows.Forms.Button buttonSupprimerIntervention;
        private System.Windows.Forms.Label Entretien;
        private System.Windows.Forms.Label labelIntervention;
        private System.Windows.Forms.ComboBox comboBoxEntretien;
        private System.Windows.Forms.ComboBox comboBoxIntervention;
        private System.Windows.Forms.DataGridView dataGridviewV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehicule1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClient1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrix1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTVA1;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroNational;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresseEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateEnregistrement;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
