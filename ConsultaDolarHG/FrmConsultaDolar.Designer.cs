namespace ConsultaDolarHG {
    partial class FrmConsultaDolar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSeanch = new System.Windows.Forms.Button();
            this.lblBay = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dólar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venda:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Variação:";
            // 
            // btnSeanch
            // 
            this.btnSeanch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeanch.Location = new System.Drawing.Point(259, 289);
            this.btnSeanch.Name = "btnSeanch";
            this.btnSeanch.Size = new System.Drawing.Size(129, 50);
            this.btnSeanch.TabIndex = 4;
            this.btnSeanch.Text = "Pesquisar";
            this.btnSeanch.UseVisualStyleBackColor = true;
            this.btnSeanch.Click += new System.EventHandler(this.btnSeanch_Click);
            // 
            // lblBay
            // 
            this.lblBay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBay.ForeColor = System.Drawing.Color.Black;
            this.lblBay.Location = new System.Drawing.Point(133, 85);
            this.lblBay.Name = "lblBay";
            this.lblBay.Size = new System.Drawing.Size(255, 45);
            this.lblBay.TabIndex = 5;
            this.lblBay.Text = "0,0";
            this.lblBay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBay.UseMnemonic = false;
            // 
            // lblSell
            // 
            this.lblSell.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.ForeColor = System.Drawing.Color.Black;
            this.lblSell.Location = new System.Drawing.Point(133, 143);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(255, 45);
            this.lblSell.TabIndex = 6;
            this.lblSell.Text = "0,0";
            this.lblSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSell.UseMnemonic = false;
            // 
            // lblVar
            // 
            this.lblVar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVar.ForeColor = System.Drawing.Color.Black;
            this.lblVar.Location = new System.Drawing.Point(133, 209);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(255, 45);
            this.lblVar.TabIndex = 7;
            this.lblVar.Text = "0,0";
            this.lblVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVar.UseMnemonic = false;
            // 
            // FrmConsultaDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 351);
            this.Controls.Add(this.lblVar);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblBay);
            this.Controls.Add(this.btnSeanch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSeanch;
        private System.Windows.Forms.Label lblBay;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblVar;
    }
}

