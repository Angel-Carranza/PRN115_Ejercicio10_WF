namespace CL19037Guia9Ejercicio10
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFrasCod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrasOri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsPhr = new System.Windows.Forms.Button();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(344, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 52);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "LIMPIAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFrasCod
            // 
            this.lblFrasCod.AutoSize = true;
            this.lblFrasCod.Location = new System.Drawing.Point(236, 114);
            this.lblFrasCod.Name = "lblFrasCod";
            this.lblFrasCod.Size = new System.Drawing.Size(13, 17);
            this.lblFrasCod.TabIndex = 10;
            this.lblFrasCod.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "FRASE O PALABRA EN CODIGO:";
            // 
            // lblFrasOri
            // 
            this.lblFrasOri.AutoSize = true;
            this.lblFrasOri.Location = new System.Drawing.Point(156, 74);
            this.lblFrasOri.Name = "lblFrasOri";
            this.lblFrasOri.Size = new System.Drawing.Size(13, 17);
            this.lblFrasOri.TabIndex = 8;
            this.lblFrasOri.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "FRASE O PALABRA:";
            // 
            // btnInsPhr
            // 
            this.btnInsPhr.Location = new System.Drawing.Point(12, 12);
            this.btnInsPhr.Name = "btnInsPhr";
            this.btnInsPhr.Size = new System.Drawing.Size(138, 52);
            this.btnInsPhr.TabIndex = 6;
            this.btnInsPhr.Text = "INSERTE FRASE O PALABRA";
            this.btnInsPhr.UseVisualStyleBackColor = true;
            this.btnInsPhr.Click += new System.EventHandler(this.btnInsPhr_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(344, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 52);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "CERRAR";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 203);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblFrasCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFrasOri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsPhr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFrasCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFrasOri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsPhr;
        private System.Windows.Forms.ToolTip ttAyuda;
        private System.Windows.Forms.Button btnClose;
    }
}

