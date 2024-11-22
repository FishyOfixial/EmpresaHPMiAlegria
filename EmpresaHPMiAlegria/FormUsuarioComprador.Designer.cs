namespace EmpresaHPMiAlegria
{
    partial class FormUsuarioComprador
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
            this.btnUnselect = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnGenerateCSV = new System.Windows.Forms.Button();
            this.lblShowCant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnselect
            // 
            this.btnUnselect.Enabled = false;
            this.btnUnselect.Font = new System.Drawing.Font("Fira Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselect.Location = new System.Drawing.Point(31, 548);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(127, 42);
            this.btnUnselect.TabIndex = 17;
            this.btnUnselect.Text = "Deseleccionar";
            this.btnUnselect.UseVisualStyleBackColor = true;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Fira Code Retina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(389, 500);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(449, 507);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 83);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtQuan
            // 
            this.txtQuan.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuan.Location = new System.Drawing.Point(643, 169);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(325, 43);
            this.txtQuan.TabIndex = 22;
            // 
            // txtProd
            // 
            this.txtProd.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Location = new System.Drawing.Point(643, 42);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(325, 43);
            this.txtProd.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 44);
            this.label1.TabIndex = 20;
            this.label1.Text = "Agregar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 44);
            this.label2.TabIndex = 19;
            this.label2.Text = "Producto:";
            // 
            // btnAddSave
            // 
            this.btnAddSave.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.Location = new System.Drawing.Point(828, 507);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(140, 83);
            this.btnAddSave.TabIndex = 23;
            this.btnAddSave.Text = "Guardar";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnGenerateCSV
            // 
            this.btnGenerateCSV.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCSV.Location = new System.Drawing.Point(643, 507);
            this.btnGenerateCSV.Name = "btnGenerateCSV";
            this.btnGenerateCSV.Size = new System.Drawing.Size(140, 83);
            this.btnGenerateCSV.TabIndex = 24;
            this.btnGenerateCSV.Text = "Generar CSV";
            this.btnGenerateCSV.UseVisualStyleBackColor = true;
            this.btnGenerateCSV.Click += new System.EventHandler(this.btnGenerateCSV_Click);
            // 
            // lblShowCant
            // 
            this.lblShowCant.AutoSize = true;
            this.lblShowCant.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCant.Location = new System.Drawing.Point(441, 290);
            this.lblShowCant.Name = "lblShowCant";
            this.lblShowCant.Size = new System.Drawing.Size(359, 44);
            this.lblShowCant.TabIndex = 25;
            this.lblShowCant.Text = "Cantidad disponible:";
            this.lblShowCant.Visible = false;
            // 
            // FormUsuarioComprador
            // 
            this.AcceptButton = this.btnAddSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1002, 625);
            this.ControlBox = false;
            this.Controls.Add(this.lblShowCant);
            this.Controls.Add(this.btnGenerateCSV);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUnselect);
            this.Controls.Add(this.listView1);
            this.Name = "FormUsuarioComprador";
            this.Text = "Comprador/a";
            this.Load += new System.EventHandler(this.FormUsuarioComprador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnGenerateCSV;
        private System.Windows.Forms.Label lblShowCant;
    }
}