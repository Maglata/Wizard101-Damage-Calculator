
namespace KursovaRabota.Forms
{
    partial class FormCustomCharacterCreation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStat1 = new System.Windows.Forms.TextBox();
            this.labelStat1 = new System.Windows.Forms.Label();
            this.textBoxStat2 = new System.Windows.Forms.TextBox();
            this.labelStat2 = new System.Windows.Forms.Label();
            this.textBoxStat3 = new System.Windows.Forms.TextBox();
            this.labelStat3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(168, 265);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(87, 265);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(231, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxStat1
            // 
            this.textBoxStat1.Location = new System.Drawing.Point(12, 78);
            this.textBoxStat1.Name = "textBoxStat1";
            this.textBoxStat1.Size = new System.Drawing.Size(231, 23);
            this.textBoxStat1.TabIndex = 8;
            // 
            // labelStat1
            // 
            this.labelStat1.AutoSize = true;
            this.labelStat1.Location = new System.Drawing.Point(12, 60);
            this.labelStat1.Name = "labelStat1";
            this.labelStat1.Size = new System.Drawing.Size(38, 15);
            this.labelStat1.TabIndex = 7;
            this.labelStat1.Text = "label2";
            // 
            // textBoxStat2
            // 
            this.textBoxStat2.Location = new System.Drawing.Point(12, 133);
            this.textBoxStat2.Name = "textBoxStat2";
            this.textBoxStat2.Size = new System.Drawing.Size(231, 23);
            this.textBoxStat2.TabIndex = 10;
            // 
            // labelStat2
            // 
            this.labelStat2.AutoSize = true;
            this.labelStat2.Location = new System.Drawing.Point(12, 115);
            this.labelStat2.Name = "labelStat2";
            this.labelStat2.Size = new System.Drawing.Size(38, 15);
            this.labelStat2.TabIndex = 9;
            this.labelStat2.Text = "label3";
            // 
            // textBoxStat3
            // 
            this.textBoxStat3.Location = new System.Drawing.Point(12, 191);
            this.textBoxStat3.Name = "textBoxStat3";
            this.textBoxStat3.Size = new System.Drawing.Size(231, 23);
            this.textBoxStat3.TabIndex = 12;
            // 
            // labelStat3
            // 
            this.labelStat3.AutoSize = true;
            this.labelStat3.Location = new System.Drawing.Point(12, 173);
            this.labelStat3.Name = "labelStat3";
            this.labelStat3.Size = new System.Drawing.Size(38, 15);
            this.labelStat3.TabIndex = 11;
            this.labelStat3.Text = "label4";
            // 
            // FormCustomCharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 300);
            this.Controls.Add(this.textBoxStat3);
            this.Controls.Add(this.labelStat3);
            this.Controls.Add(this.textBoxStat2);
            this.Controls.Add(this.labelStat2);
            this.Controls.Add(this.textBoxStat1);
            this.Controls.Add(this.labelStat1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormCustomCharacterCreation";
            this.Text = "Custom Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStat1;
        private System.Windows.Forms.Label labelStat1;
        private System.Windows.Forms.TextBox textBoxStat2;
        private System.Windows.Forms.Label labelStat2;
        private System.Windows.Forms.TextBox textBoxStat3;
        private System.Windows.Forms.Label labelStat3;
    }
}