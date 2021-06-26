﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VaccinationManagement.Context;
using VaccinationManagement.Models;


namespace VaccinationManagement.Views
{
    public partial class AppointmentProcess : Form
    {
        private TextBox txtb_name;
        private TextBox txtbx_addres;
        private System.Windows.Forms.TextBox txtbx_email;
        private System.Windows.Forms.TextBox txtbx_disease;
        private System.Windows.Forms.ComboBox cbx_institution;
        private System.Windows.Forms.TextBox txtbx_phone;
        private System.Windows.Forms.ComboBox cbx_pgroup;

        public AppointmentProcess()
        {
            InitializeComponent();
        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var employee = db.Employees.ToList();

                Citizen cyudadano = new Citizen(
    
                Convert.ToInt32(Txbx_DUI.Text),
                txtb_name.Text,
                txtbx_addres.Text,
                Convert.ToInt32(txtbx_phone.Text),
                txtbx_email.Text,
                txtb_ICode.Text,
                //ID employee
                Convert.ToInt32(cbx_institution.SelectedItem),
                Convert.ToInt32(cbx_pgroup.SelectedItem)
                
                
            );
                        
            
            db.Add(cyudadano);
            db.SaveChanges();
            MessageBox.Show("Información guardada con exito", "Guardado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_disease_Click(object sender, EventArgs e)
        {
            int n = 0;
            Disease disease = new Disease(
                Id: n++,
                txtbx_disease.Text,
                Convert.ToInt32(Txbx_DUI.Text));
            var db = new VaccinationContext();
            db.Add(disease);
            db.SaveChanges();
        }

        private void AppointmentProcess_Load(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var priority_groups = db.PriorityGroups.ToList();
            cbx_pgroup.DataSource = priority_groups;
            cbx_pgroup.DisplayMember = "PriorityGroup1";

            var institutions = db.SpecialInstitutions.ToList();
            cbx_institution.DataSource = institutions;
            cbx_institution.DisplayMember = "InstName";
            
        }
    }
}