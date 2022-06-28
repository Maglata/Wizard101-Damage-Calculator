
namespace KursovaRabota
{
    partial class ListForm
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
            this.listBoxDMs = new System.Windows.Forms.ListBox();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonRemoveBlades = new System.Windows.Forms.Button();
            this.buttonRemoveWeakness = new System.Windows.Forms.Button();
            this.buttonRemoveTraps = new System.Windows.Forms.Button();
            this.buttonRemoveShields = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDMs
            // 
            this.listBoxDMs.FormattingEnabled = true;
            this.listBoxDMs.ItemHeight = 15;
            this.listBoxDMs.Location = new System.Drawing.Point(0, -4);
            this.listBoxDMs.Name = "listBoxDMs";
            this.listBoxDMs.Size = new System.Drawing.Size(214, 604);
            this.listBoxDMs.TabIndex = 0;
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(220, 12);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(94, 43);
            this.buttonRemoveSelected.TabIndex = 1;
            this.buttonRemoveSelected.Text = "Remove Selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonRemoveBlades
            // 
            this.buttonRemoveBlades.Location = new System.Drawing.Point(220, 61);
            this.buttonRemoveBlades.Name = "buttonRemoveBlades";
            this.buttonRemoveBlades.Size = new System.Drawing.Size(94, 43);
            this.buttonRemoveBlades.TabIndex = 2;
            this.buttonRemoveBlades.Text = "Remove All Blades";
            this.buttonRemoveBlades.UseVisualStyleBackColor = true;
            this.buttonRemoveBlades.Click += new System.EventHandler(this.buttonRemoveBlades_Click);
            // 
            // buttonRemoveWeakness
            // 
            this.buttonRemoveWeakness.Location = new System.Drawing.Point(220, 110);
            this.buttonRemoveWeakness.Name = "buttonRemoveWeakness";
            this.buttonRemoveWeakness.Size = new System.Drawing.Size(94, 43);
            this.buttonRemoveWeakness.TabIndex = 3;
            this.buttonRemoveWeakness.Text = "Remove All Weaknesses";
            this.buttonRemoveWeakness.UseVisualStyleBackColor = true;
            this.buttonRemoveWeakness.Click += new System.EventHandler(this.buttonRemoveWeakness_Click);
            // 
            // buttonRemoveTraps
            // 
            this.buttonRemoveTraps.Location = new System.Drawing.Point(220, 159);
            this.buttonRemoveTraps.Name = "buttonRemoveTraps";
            this.buttonRemoveTraps.Size = new System.Drawing.Size(94, 43);
            this.buttonRemoveTraps.TabIndex = 4;
            this.buttonRemoveTraps.Text = "Remove All Traps";
            this.buttonRemoveTraps.UseVisualStyleBackColor = true;
            this.buttonRemoveTraps.Click += new System.EventHandler(this.buttonRemoveTraps_Click);
            // 
            // buttonRemoveShields
            // 
            this.buttonRemoveShields.Location = new System.Drawing.Point(220, 208);
            this.buttonRemoveShields.Name = "buttonRemoveShields";
            this.buttonRemoveShields.Size = new System.Drawing.Size(94, 43);
            this.buttonRemoveShields.TabIndex = 5;
            this.buttonRemoveShields.Text = "Remove All Shields";
            this.buttonRemoveShields.UseVisualStyleBackColor = true;
            this.buttonRemoveShields.Click += new System.EventHandler(this.buttonRemoveShields_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(220, 548);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 43);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(220, 499);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 43);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 603);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRemoveShields);
            this.Controls.Add(this.buttonRemoveTraps);
            this.Controls.Add(this.buttonRemoveWeakness);
            this.Controls.Add(this.buttonRemoveBlades);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.listBoxDMs);
            this.MaximizeBox = false;
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "All Modificators";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDMs;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonRemoveBlades;
        private System.Windows.Forms.Button buttonRemoveWeakness;
        private System.Windows.Forms.Button buttonRemoveTraps;
        private System.Windows.Forms.Button buttonRemoveShields;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}