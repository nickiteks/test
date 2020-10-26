namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backupButton = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonDiagramm = new System.Windows.Forms.Button();
            this.backupComponent = new components.BackupComponent(this.components);
            this.excelComponent = new components.ExcelComponent();
            this.pdfDiagrammComponent = new components.PdfDiagrammComponent(this.components);
            this.SuspendLayout();
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(32, 46);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(75, 23);
            this.backupButton.TabIndex = 0;
            this.backupButton.Text = "сохранить";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(207, 46);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(75, 23);
            this.buttonExcel.TabIndex = 1;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonDiagramm
            // 
            this.buttonDiagramm.Location = new System.Drawing.Point(330, 47);
            this.buttonDiagramm.Name = "buttonDiagramm";
            this.buttonDiagramm.Size = new System.Drawing.Size(86, 21);
            this.buttonDiagramm.TabIndex = 2;
            this.buttonDiagramm.Text = "Диаграмма";
            this.buttonDiagramm.UseVisualStyleBackColor = true;
            this.buttonDiagramm.Click += new System.EventHandler(this.buttonDiagramm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 280);
            this.Controls.Add(this.buttonDiagramm);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.backupButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private components.BackupComponent backupComponent;
        private System.Windows.Forms.Button backupButton;
        private components.ExcelComponent excelComponent;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonDiagramm;
        private components.PdfDiagrammComponent pdfDiagrammComponent;
    }
}

