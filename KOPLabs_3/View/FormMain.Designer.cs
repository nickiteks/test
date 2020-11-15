
using Var35n6n18n27;

namespace View
{
    partial class FormMain
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
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.userControlListOutput1 = new Var35n6n18n27.UserControlListOutput();
            this.componentWordSummary = new components.ComponentWordSummary(this.components);
            this.backupComponent = new components.BackupComponent(this.components);
            this.wordDiagram = new KDAkop.WordDiagram(this.components);
            this.buttonWordDiagramm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(12, 192);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(87, 35);
            this.buttonWord.TabIndex = 3;
            this.buttonWord.Text = "WordReport";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(144, 192);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(81, 35);
            this.buttonBackup.TabIndex = 4;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // userControlListOutput1
            // 
            this.userControlListOutput1.Location = new System.Drawing.Point(12, 12);
            this.userControlListOutput1.Name = "userControlListOutput1";
            this.userControlListOutput1.Size = new System.Drawing.Size(150, 150);
            this.userControlListOutput1.TabIndex = 2;
            // 
            // buttonWordDiagramm
            // 
            this.buttonWordDiagramm.Location = new System.Drawing.Point(269, 192);
            this.buttonWordDiagramm.Name = "buttonWordDiagramm";
            this.buttonWordDiagramm.Size = new System.Drawing.Size(91, 35);
            this.buttonWordDiagramm.TabIndex = 5;
            this.buttonWordDiagramm.Text = "WordDiagram";
            this.buttonWordDiagramm.UseVisualStyleBackColor = true;
            this.buttonWordDiagramm.Click += new System.EventHandler(this.buttonWordDiagramm_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 431);
            this.Controls.Add(this.buttonWordDiagramm);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.userControlListOutput1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControlListOutput userControlListOutput1;
        private components.ComponentWordSummary componentWordSummary;
        private System.Windows.Forms.Button buttonWord;
        private components.BackupComponent backupComponent;
        private System.Windows.Forms.Button buttonBackup;
        private KDAkop.WordDiagram wordDiagram;
        private System.Windows.Forms.Button buttonWordDiagramm;
    }
}

