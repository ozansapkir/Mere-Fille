namespace Tp_frnêtre_Mere_et_Fille
{
    partial class FFille
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
            this.lblChangeNom = new System.Windows.Forms.Label();
            this.btnChanger = new System.Windows.Forms.Button();
            this.tbChanger = new System.Windows.Forms.TextBox();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangeNom
            // 
            this.lblChangeNom.AutoSize = true;
            this.lblChangeNom.Location = new System.Drawing.Point(9, 63);
            this.lblChangeNom.Name = "lblChangeNom";
            this.lblChangeNom.Size = new System.Drawing.Size(101, 13);
            this.lblChangeNom.TabIndex = 0;
            this.lblChangeNom.Text = "Je change de nom :";
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(211, 60);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 1;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // tbChanger
            // 
            this.tbChanger.Location = new System.Drawing.Point(107, 60);
            this.tbChanger.Name = "tbChanger";
            this.tbChanger.Size = new System.Drawing.Size(98, 20);
            this.tbChanger.TabIndex = 2;
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(107, 166);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnMaMere.TabIndex = 3;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            this.btnMaMere.Click += new System.EventHandler(this.btnMaMere_Click);
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.tbChanger);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.lblChangeNom);
            this.Name = "FFille";
            this.Text = "FFille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangeNom;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.TextBox tbChanger;
        private System.Windows.Forms.Button btnMaMere;
    }
}