
namespace FinalLab
{
    partial class PrimerPagina
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
            this.botonRolEmpleado = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonRolEmpleado
            // 
            this.botonRolEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.botonRolEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.botonRolEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRolEmpleado.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRolEmpleado.Location = new System.Drawing.Point(12, 59);
            this.botonRolEmpleado.Name = "botonRolEmpleado";
            this.botonRolEmpleado.Size = new System.Drawing.Size(127, 58);
            this.botonRolEmpleado.TabIndex = 0;
            this.botonRolEmpleado.Text = "Empleado";
            this.botonRolEmpleado.UseVisualStyleBackColor = false;
            this.botonRolEmpleado.Click += new System.EventHandler(this.botonRolEmpleado_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(145, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cliente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(66, 23);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(155, 17);
            this.lb.TabIndex = 2;
            this.lb.Text = "¿Qué rol desea tomar?";
            // 
            // PrimerPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(282, 150);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botonRolEmpleado);
            this.Font = new System.Drawing.Font("Helvetica Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "PrimerPagina";
            this.ShowIcon = false;
            this.Text = "Ferreteria Los Hermanos";
            this.Load += new System.EventHandler(this.PrimerPagina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRolEmpleado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb;
    }
}