﻿using AW.DataAccess;
using AW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AW.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            var da = new EmployeeDA();
            //var listado = da.GetEmployeesWithParam(txtFiltro.Text);
            //dgvLista.DataSource = listado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var da = new EmployeeDA();
            var person = new Person();
            person.PersonType = "EM";
            person.NameStyle = true;
            person.Title = "Mr.";
            person.FirstName = "ssss";
            person.MiddleName = "fsdf";
            person.LastName = "fssdfs";
            person.Suffix = "Jr.";
            person.EmailPromotion = 0;
            person.rowguid = Guid.NewGuid();
            person.ModifiedDate = DateTime.Now;

            var emp = new Employee();
            //da.InsertEmployee(emp,person);
        }
    }
}
