namespace Vista
{
    partial class Regristro
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
            this.lblNroLista = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.txtNroLista = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnRegrsitrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNroLista
            // 
            this.lblNroLista.AutoSize = true;
            this.lblNroLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroLista.Location = new System.Drawing.Point(87, 61);
            this.lblNroLista.Name = "lblNroLista";
            this.lblNroLista.Size = new System.Drawing.Size(54, 13);
            this.lblNroLista.TabIndex = 0;
            this.lblNroLista.Text = "NroLista";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(87, 106);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(46, 13);
            this.c.TabIndex = 1;
            this.c.Text = "Cedula";
            // 
            // txtNroLista
            // 
            this.txtNroLista.Location = new System.Drawing.Point(170, 54);
            this.txtNroLista.Name = "txtNroLista";
            this.txtNroLista.Size = new System.Drawing.Size(91, 20);
            this.txtNroLista.TabIndex = 2;
            this.txtNroLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroLista_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(170, 103);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(91, 20);
            this.txtCedula.TabIndex = 3;
            // 
            // btnRegrsitrar
            // 
            this.btnRegrsitrar.Location = new System.Drawing.Point(126, 237);
            this.btnRegrsitrar.Name = "btnRegrsitrar";
            this.btnRegrsitrar.Size = new System.Drawing.Size(82, 25);
            this.btnRegrsitrar.TabIndex = 4;
            this.btnRegrsitrar.Text = "Regrsitrar";
            this.btnRegrsitrar.UseVisualStyleBackColor = true;
            this.btnRegrsitrar.Click += new System.EventHandler(this.btnRegrsitrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(170, 150);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(91, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(170, 197);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(91, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(87, 150);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(87, 200);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 13);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // Regristro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegrsitrar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNroLista);
            this.Controls.Add(this.c);
            this.Controls.Add(this.lblNroLista);
            this.Name = "Regristro";
            this.Text = "Regristro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroLista;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox txtNroLista;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnRegrsitrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
    }
}