
namespace A5_Menu_while_CG
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOp1 = new System.Windows.Forms.Button();
            this.btnOp2 = new System.Windows.Forms.Button();
            this.btnOp3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija una opcion";
            // 
            // btnOp1
            // 
            this.btnOp1.Location = new System.Drawing.Point(30, 51);
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.Size = new System.Drawing.Size(123, 47);
            this.btnOp1.TabIndex = 1;
            this.btnOp1.Text = "Repetir Texto";
            this.btnOp1.UseVisualStyleBackColor = true;
            this.btnOp1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOp2
            // 
            this.btnOp2.Location = new System.Drawing.Point(30, 104);
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.Size = new System.Drawing.Size(123, 57);
            this.btnOp2.TabIndex = 2;
            this.btnOp2.Text = "pares e impares";
            this.btnOp2.UseVisualStyleBackColor = true;
            this.btnOp2.Click += new System.EventHandler(this.btnOp2_Click);
            // 
            // btnOp3
            // 
            this.btnOp3.Location = new System.Drawing.Point(30, 167);
            this.btnOp3.Name = "btnOp3";
            this.btnOp3.Size = new System.Drawing.Size(123, 60);
            this.btnOp3.TabIndex = 3;
            this.btnOp3.Text = "Sumatoria ";
            this.btnOp3.UseVisualStyleBackColor = true;
            this.btnOp3.Click += new System.EventHandler(this.btnOp3_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 292);
            this.Controls.Add(this.btnOp3);
            this.Controls.Add(this.btnOp2);
            this.Controls.Add(this.btnOp1);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOp1;
        private System.Windows.Forms.Button btnOp2;
        private System.Windows.Forms.Button btnOp3;
    }
}

