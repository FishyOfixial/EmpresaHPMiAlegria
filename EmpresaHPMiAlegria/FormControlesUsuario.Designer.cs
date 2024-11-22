namespace EmpresaHPMiAlegria
{
    partial class FormControlesUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlesUsuario));
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnBuyer = new System.Windows.Forms.Button();
            this.btnOperator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChangeUser.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUser.Location = new System.Drawing.Point(7, 411);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(197, 83);
            this.btnChangeUser.TabIndex = 3;
            this.btnChangeUser.Text = "Cambiar Usuario";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSystem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSystem.BackgroundImage")));
            this.btnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSystem.Enabled = false;
            this.btnSystem.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSystem.Location = new System.Drawing.Point(605, 14);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(290, 378);
            this.btnSystem.TabIndex = 2;
            this.btnSystem.Text = "&Sistema";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSystem.UseVisualStyleBackColor = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnBuyer
            // 
            this.btnBuyer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuyer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuyer.BackgroundImage")));
            this.btnBuyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuyer.Enabled = false;
            this.btnBuyer.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuyer.Location = new System.Drawing.Point(309, 14);
            this.btnBuyer.Name = "btnBuyer";
            this.btnBuyer.Size = new System.Drawing.Size(290, 378);
            this.btnBuyer.TabIndex = 1;
            this.btnBuyer.Text = "&Comprador/a";
            this.btnBuyer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuyer.UseVisualStyleBackColor = false;
            this.btnBuyer.Click += new System.EventHandler(this.btnBuyer_Click);
            // 
            // btnOperator
            // 
            this.btnOperator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOperator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOperator.BackgroundImage")));
            this.btnOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOperator.Enabled = false;
            this.btnOperator.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOperator.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOperator.Location = new System.Drawing.Point(7, 14);
            this.btnOperator.Name = "btnOperator";
            this.btnOperator.Size = new System.Drawing.Size(290, 378);
            this.btnOperator.TabIndex = 0;
            this.btnOperator.Text = "&Operador/a";
            this.btnOperator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOperator.UseVisualStyleBackColor = false;
            this.btnOperator.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // FormControlesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnChangeUser;
            this.ClientSize = new System.Drawing.Size(907, 504);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangeUser);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.btnBuyer);
            this.Controls.Add(this.btnOperator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(925, 551);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(925, 551);
            this.Name = "FormControlesUsuario";
            this.Text = "Controles de Usuario";
            this.Load += new System.EventHandler(this.FormControlesUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperator;
        private System.Windows.Forms.Button btnBuyer;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.Label label2;
    }
}