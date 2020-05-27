﻿using System;
using System;
using System.Windows.Forms;
using Unity;
using System.Collections.Generic;
using BankAdminView;
using BankBusinessLogic.BusnessLogic;
using BankBusinessLogic.InterFaces;
using BankBusinessLogic.BindingModels;

namespace BankAdminView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly MainLogic logic;
        private readonly IDealLogic orderLogic;
        public FormMain(MainLogic logic, IDealLogic orderLogic)
        {
            InitializeComponent();
            this.logic = logic;
            this.orderLogic = orderLogic;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = orderLogic.Read(null);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = true;
                    dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[3].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void компонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormComponents>();
            form.ShowDialog();
        }
        private void изделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormFurniture>();
            form.ShowDialog();
        }
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormDeal>();
            form.ShowDialog();
            LoadData();
        }
        private void buttonTakeOrderInWork_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                try
                {
                    logic.TakeOrderInWork(new ChangeStatusBindingModel { DealId = id });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void списокИзделийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormFurnitures>();
            form.ShowDialog();
        }

        private void СкладыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStorage>();
            form.ShowDialog();
        }

        private void ButtonStorageAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStorageComonent>();
            form.ShowDialog();
        }

        private void добавитьНаСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStorageComonent>();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormDeal>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
