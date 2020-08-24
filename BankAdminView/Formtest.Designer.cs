﻿using System;

namespace BankAdminView
{
    partial class Formtest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.UpdateDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshOrderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарезервированныеДеньгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоВыполненнымСделкамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СоздатьБекапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.создатьБекапXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateDataToolStripMenuItem,
            this.CreateOrderToolStripMenuItem,
            this.RefreshOrderListToolStripMenuItem,
            this.зарезервированныеДеньгиToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.отчетПоВыполненнымСделкамToolStripMenuItem,
            this.СоздатьБекапToolStripMenuItem,
            this.создатьБекапXMLToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1135, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // UpdateDataToolStripMenuItem
            // 
            this.UpdateDataToolStripMenuItem.Name = "UpdateDataToolStripMenuItem";
            this.UpdateDataToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.UpdateDataToolStripMenuItem.Text = "Изменить данные";
            this.UpdateDataToolStripMenuItem.Click += new System.EventHandler(this.UpdateDataToolStripMenuItem_Click);
            // 
            // CreateOrderToolStripMenuItem
            // 
            this.CreateOrderToolStripMenuItem.Name = "CreateOrderToolStripMenuItem";
            this.CreateOrderToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.CreateOrderToolStripMenuItem.Text = "Создать заказ";
            this.CreateOrderToolStripMenuItem.Click += new System.EventHandler(this.CreateOrderToolStripMenuItem_Click);
            // 
            // RefreshOrderListToolStripMenuItem
            // 
            this.RefreshOrderListToolStripMenuItem.Name = "RefreshOrderListToolStripMenuItem";
            this.RefreshOrderListToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.RefreshOrderListToolStripMenuItem.Text = "Обновить список заказов";
            this.RefreshOrderListToolStripMenuItem.Click += new System.EventHandler(this.RefreshOrderListToolStripMenuItem_Click);
            // 
            // зарезервированныеДеньгиToolStripMenuItem
            // 
            this.зарезервированныеДеньгиToolStripMenuItem.Name = "зарезервированныеДеньгиToolStripMenuItem";
            this.зарезервированныеДеньгиToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.зарезервированныеДеньгиToolStripMenuItem.Text = "Зарезервировать деньги";
            this.зарезервированныеДеньгиToolStripMenuItem.Click += new System.EventHandler(this.зарезервироватьДеньгиToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // отчетПоВыполненнымСделкамToolStripMenuItem
            // 
            this.отчетПоВыполненнымСделкамToolStripMenuItem.Name = "отчетПоВыполненнымСделкамToolStripMenuItem";
            this.отчетПоВыполненнымСделкамToolStripMenuItem.Size = new System.Drawing.Size(201, 20);
            this.отчетПоВыполненнымСделкамToolStripMenuItem.Text = "Отчет по выполненным сделкам";
            this.отчетПоВыполненнымСделкамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоВыполненнымСделкамToolStripMenuItem_Click);
            // 
            // СоздатьБекапToolStripMenuItem
            // 
            this.СоздатьБекапToolStripMenuItem.Name = "СоздатьБекапToolStripMenuItem";
            this.СоздатьБекапToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.СоздатьБекапToolStripMenuItem.Text = "Создать Бекап JSON";
            this.СоздатьБекапToolStripMenuItem.Click += new System.EventHandler(this.СоздатьБекапToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 24);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1135, 350);
            this.dataGridView.TabIndex = 1;
            // 
            // создатьБекапXMLToolStripMenuItem
            // 
            this.создатьБекапXMLToolStripMenuItem.Name = "создатьБекапXMLToolStripMenuItem";
            this.создатьБекапXMLToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.создатьБекапXMLToolStripMenuItem.Text = "Создать Бекап XML";
            this.создатьБекапXMLToolStripMenuItem.Click += new System.EventHandler(this.создатьБекапXMLToolStripMenuItem_Click);
            // 
            // Formtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 374);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Formtest";
            this.Text = "Форма заказов";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UpdateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CreateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RefreshOrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void СоздатьБекапToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void отчетПоВыполненнымСделкамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void зарезервироватьДеньгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem UpdateDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshOrderListToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem зарезервированныеДеньгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоВыполненнымСделкамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СоздатьБекапToolStripMenuItem;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private void buttonOk_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonOkExcel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.ToolStripMenuItem создатьБекапXMLToolStripMenuItem;
    }
}