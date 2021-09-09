﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_HEL.Classes;
using Projet_HEL.Acces;
using Projet_HEL.Gestion;
using System.Configuration;


namespace Alfa_Romeo_Garage.Interfaces
{
    public partial class UserControleEntre : UserControl
    {
        string connexionBD;
        private DataTable dataTableE;
        private DataTable dataTableClients;
        private BindingSource bindingSourcesE;
        private BindingSource bindingSourcesClients;

        private DataTable dataTableV;
        private BindingSource bindingSourcesV;

        string id;

        public UserControleEntre()
        {
            InitializeComponent();
        }

        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
            dataGridViewE.Enabled = dataGridviewV.Enabled = disponibilite;
            buttonAjouter.Visible = buttonEditer.Visible = buttonSupprimer.Visible  = disponibilite;
            buttonAjouterIntervention.Visible = buttonSupprimerIntervention.Visible = buttonEditerIntervention.Visible = disponibilite;

            comboBoxVehicule.Enabled = !disponibilite;
            dateTimePickerDateEntretien.Enabled = !disponibilite;

            comboBoxEntretien.Enabled = !disponibilite;
            comboBoxIntervention.Enabled = !disponibilite;

            buttonConfirmer.Visible = buttonAnnuler.Visible = !disponibilite;
            buttonConfirmerIntervention.Visible = buttonAnnulerIntervention.Visible = !disponibilite;
        }

        private void RemplirDataGridView()
        {
            dataTableE = new DataTable();
            dataTableE.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableE.Columns.Add(new DataColumn("vehicule"));
            dataTableE.Columns.Add(new DataColumn("date"));

            dataTableV = new DataTable();
            dataTableV.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableV.Columns.Add(new DataColumn("description"));
            dataTableV.Columns.Add(new DataColumn("vehicule"));
            dataTableV.Columns.Add(new DataColumn("client"));
            dataTableV.Columns.Add(new DataColumn("date"));



            dataTableV.Columns.Add(new DataColumn("prix"));
            dataTableV.Columns.Add(new DataColumn("tva"));


            List<C_INVOICE> listEntretiens = new G_INVOICE(connexionBD).Lire("DATE");

            foreach (C_INVOICE entretien in listEntretiens)
            {
                int idVehicule = Convert.ToInt32(entretien.ID_VEHICLE);

                C_VEHICLE vehicule = new G_VEHICLE(connexionBD).Lire_ID(idVehicule);

                dataTableE.Rows.Add
                (
                    entretien.ID,
                    vehicule.REGISTRATION,
                    Convert.ToDateTime(entretien.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(entretien.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(entretien.DATE).Year.ToString("D4")
                );
            }

            List<C_INTERVENTION_INVOICE> list = new G_INTERVENTION_INVOICE(connexionBD).Lire("ID");

            foreach (C_INTERVENTION_INVOICE r in list)
            {
                int idT = Convert.ToInt32(r.ID_INTERVENTION);
                int idF = Convert.ToInt32(r.ID_INVOICE);

                C_INTERVENTION mainO = new G_INTERVENTION(connexionBD).Lire_ID(idT);
                C_INVOICE en = new G_INVOICE(connexionBD).Lire_ID(idF);

                C_VEHICLE v = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(en.ID_VEHICLE));
                C_CUSTOMER c = new G_CUSTOMER(connexionBD).Lire_ID(Convert.ToInt32(v.ID_CUSTOMER));


                dataTableV.Rows.Add
                (
                    en.ID,
                    mainO.DESCRIPTION,
                    v.REGISTRATION,
                    c.FIRST_NAME+" "+c.LAST_NAME,
                    Convert.ToDateTime(en.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(en.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(en.DATE).Year.ToString("D4"),

                    string.Format("{0:0.00}", mainO.PRIC).ToString() + " €",
                    string.Format("{0:0.0}", mainO.TVA).ToString() + " %"
                );
            }

            dataTableClients = new DataTable();
            dataTableClients.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            dataTableClients.Columns.Add(new DataColumn("nomPrenom"));
            dataTableClients.Columns.Add(new DataColumn("dateNaissance"));
            dataTableClients.Columns.Add(new DataColumn("numeroNational"));
            dataTableClients.Columns.Add(new DataColumn("adresse"));
            dataTableClients.Columns.Add(new DataColumn("adresseEmail"));
            dataTableClients.Columns.Add(new DataColumn("numeroTelephone"));
            dataTableClients.Columns.Add(new DataColumn("dateEnregistrement"));

            List<C_CUSTOMER> listClients = new G_CUSTOMER(connexionBD).Lire("LAST_NAME");

            foreach (C_CUSTOMER client in listClients)
            {
                dataTableClients.Rows.Add
                (
                    client.ID,
                    client.LAST_NAME + " " + client.FIRST_NAME,
                    Convert.ToDateTime(client.BIRTH_DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(client.BIRTH_DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(client.BIRTH_DATE).Year.ToString("D4"),
                    client.NATIONAL_NUMBER,
                    client.ADDRESS + " " + client.NUMBER + ", " + client.POSTAL_CODE + " " + client.CITY + " " + client.COUNTRY,
                    client.EMAIL_ADDRESS,
                    client.PHONE_NUMBER,
                    Convert.ToDateTime(client.DATA_REGISTRATION).Day.ToString("D2") + "/" + Convert.ToDateTime(client.DATA_REGISTRATION).Month.ToString("D2") + "/" + Convert.ToDateTime(client.DATA_REGISTRATION).Year.ToString("D4")
                );
            }

            bindingSourcesClients = new BindingSource();
            bindingSourcesClients.DataSource = dataTableClients;
            dataGridViewClients.DataSource = bindingSourcesClients;

            bindingSourcesE = new BindingSource();
            bindingSourcesE.DataSource = dataTableE;
            dataGridViewE.DataSource = bindingSourcesE;

            bindingSourcesV = new BindingSource();
            bindingSourcesV.DataSource = dataTableV;
            dataGridviewV.DataSource = bindingSourcesV;

            comboBoxEntretien.Items.Clear();
            comboBoxIntervention.Items.Clear();
            comboBoxVehicule.Items.Clear();

            List<C_VEHICLE> listV = new G_VEHICLE(connexionBD).Lire("ID");

            foreach (C_VEHICLE v in listV)
            {
                comboBoxVehicule.Items.Add(v.ID + " - " + v.REGISTRATION);
            }



            List<C_INTERVENTION> listB = new G_INTERVENTION(connexionBD).Lire("ID");

            foreach (C_INTERVENTION b in listB)
            {
                comboBoxIntervention.Items.Add(b.ID);
            }

            List<C_INVOICE> listC = new G_INVOICE(connexionBD).Lire("ID");

            foreach (C_INVOICE v in listC)
            {
                comboBoxEntretien.Items.Add(v.ID);
            }

        }

        private void UserControleEntre_Load(object sender, EventArgs e)
        {
            connexionBD = ConfigurationManager.ConnectionStrings["Alfa_Romeo_Garage.Properties.Settings.connexionBD"].ConnectionString;


            RemplirDataGridView();

            if (dataGridViewE.Rows.Count > 0)
            {
                ActiverBoutonsFormulaires(true);
            }

            else
            {
                ActiverBoutonsFormulaires(false);
            } 
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            dateTimePickerDateEntretien.Value = DateTime.Today;
            ActiverBoutonsFormulaires(false);
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
            if (dataGridViewE.SelectedRows.Count > 0)
            {
                id = dataGridViewE.SelectedRows[0].Cells["cID"].Value.ToString();
                C_INVOICE vehiculeModification = new G_INVOICE(connexionBD).Lire_ID(int.Parse(id));
                ActiverBoutonsFormulaires(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
                
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewE.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voullez-vous vraiment supprimer l'entretien ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idClientSuppression = (int)dataGridViewE.SelectedRows[0].Cells["cID"].Value;
                    new G_INVOICE(connexionBD).Supprimer(idClientSuppression);
                    bindingSourcesE.RemoveCurrent();
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulaires(true);
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            string[] vehicule = comboBoxVehicule.SelectedItem.ToString().Trim().Split('-');
 

            if (id == null)
            //Ajout
            {
                int idAjoutEntretien = new G_INVOICE(connexionBD).Ajouter
                (
                    Convert.ToInt32(vehicule[0]),
                    dateTimePickerDateEntretien.Value
                );


                dataTableE.Rows.Add
                (
                   idAjoutEntretien.ToString(),
                   vehicule[1]+"-"+vehicule[2]+"-" + vehicule[3],
                   
                   dateTimePickerDateEntretien.Value.Day.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Month.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Year.ToString("D4")
                ) ;
            }

            else
            //Modification
            {
                int idVehiculeModification = new G_INVOICE(connexionBD).Modifier
                   (
                    int.Parse(id),
                    int.Parse(vehicule[0]),
                    dateTimePickerDateEntretien.Value
                   );

                dataGridViewE.SelectedRows[0].Cells["cID"].Value = int.Parse(id).ToString();
                dataGridViewE.SelectedRows[0].Cells["cVehicule"].Value = vehicule[1] +"-"+ vehicule[2]+ "-" + vehicule[3];
                dataGridViewE.SelectedRows[0].Cells["cDate"].Value = dateTimePickerDateEntretien.Value.Day.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Month.ToString("D2") + "/" + dateTimePickerDateEntretien.Value.Year.ToString("D4");

                bindingSourcesE.EndEdit();
                id = null;
            }
            ActiverBoutonsFormulaires(true);
        }

    

        private void buttonAjouterIntervention_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulaires(false);
        }

        private void buttonEditerIntervention_Click(object sender, EventArgs e)
        {
            if (dataGridviewV.SelectedRows.Count > 0)
            {
                id = dataGridviewV.SelectedRows[0].Cells["cID1"].Value.ToString();

                ActiverBoutonsFormulaires(false);
            }
            else
            {
                MessageBox.Show("Sélectionner l'enregistrement à éditer");
            }
        }

        private void buttonSupprimerIntervention_Click(object sender, EventArgs e)
        {
            if (dataGridviewV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voullez-vous vraiment supprimer l'enregistrement?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idClientSuppression = (int)dataGridviewV.SelectedRows[0].Cells["cID1"].Value;
                    new G_INTERVENTION_INVOICE(connexionBD).Supprimer(idClientSuppression);
                    bindingSourcesV.RemoveCurrent();
                }
            }
        }

        private void buttonConfirmerIntervention_Click(object sender, EventArgs e)
        {
            C_INTERVENTION IN = new G_INTERVENTION(connexionBD).Lire_ID(Convert.ToInt32(comboBoxIntervention.Text));
            C_INVOICE INV = new G_INVOICE(connexionBD).Lire_ID(Convert.ToInt32(comboBoxEntretien.Text));
            C_VEHICLE V = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(INV.ID_VEHICLE));
            C_CUSTOMER c = new G_CUSTOMER(connexionBD).Lire_ID(Convert.ToInt32(V.ID_CUSTOMER));

            if (id==null)
            {
                int idAjouter = new G_INTERVENTION_INVOICE(connexionBD).Ajouter(Convert.ToInt32(comboBoxIntervention.Text.ToString()), Convert.ToInt32(comboBoxEntretien.Text.ToString()), IN.PRICE_HOUR, IN.PRIC, IN.TVA);
                MessageBox.Show(comboBoxIntervention.Text + "+" + comboBoxEntretien.Text);

                dataTableV.Rows.Add
                  (
                      idAjouter.ToString(),
                      IN.DESCRIPTION,
                      V.REGISTRATION,
                      c.FIRST_NAME + " " + c.LAST_NAME,
                      Convert.ToDateTime(INV.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(INV.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(INV.DATE).Year.ToString("D4"),
                      string.Format("{0:0.00}", IN.PRIC).ToString() + " €",
                      string.Format("{0:0.0}", IN.TVA).ToString() + " %"
                  );
            }
            
            else
            //Modification
            {
                IN = new G_INTERVENTION(connexionBD).Lire_ID(Convert.ToInt32(comboBoxIntervention.Text));
                INV = new G_INVOICE(connexionBD).Lire_ID(Convert.ToInt32(comboBoxEntretien.Text));
                V = new G_VEHICLE(connexionBD).Lire_ID(Convert.ToInt32(INV.ID_VEHICLE));
                c = new G_CUSTOMER(connexionBD).Lire_ID(Convert.ToInt32(V.ID_CUSTOMER));

                int idVehiculeModification = new G_INTERVENTION_INVOICE(connexionBD).Modifier
                   (
                    int.Parse(id),
                    Convert.ToInt32(comboBoxIntervention.Text.ToString()),
                    Convert.ToInt32(comboBoxEntretien.Text.ToString()),
                    IN.PRICE_HOUR,
                    IN.PRIC,
                    IN.TVA
                   );

                dataGridviewV.SelectedRows[0].Cells["cID1"].Value = int.Parse(id).ToString();
                dataGridviewV.SelectedRows[0].Cells["cDescription1"].Value = IN.DESCRIPTION;
                dataGridviewV.SelectedRows[0].Cells["cVehicule1"].Value = V.REGISTRATION;
                dataGridviewV.SelectedRows[0].Cells["cClient1"].Value = c.FIRST_NAME + " " + c.LAST_NAME;
                dataGridviewV.SelectedRows[0].Cells["cDate1"].Value = Convert.ToDateTime(INV.DATE).Day.ToString("D2") + "/" + Convert.ToDateTime(INV.DATE).Month.ToString("D2") + "/" + Convert.ToDateTime(INV.DATE).Year.ToString("D4");
                dataGridviewV.SelectedRows[0].Cells["cPrix1"].Value = string.Format("{0:0.00}", IN.PRIC).ToString() + " €";
                dataGridviewV.SelectedRows[0].Cells["cTVA1"].Value = string.Format("{0:0.0}", IN.TVA).ToString() + " %";

                bindingSourcesV.EndEdit();
                id = null;
            }
            ActiverBoutonsFormulaires(true);
        }

        private void buttonAnnulerIntervention_Click(object sender, EventArgs e)
        {
            ActiverBoutonsFormulaires(true);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RemplirDataGridView();
        }
    }
}
