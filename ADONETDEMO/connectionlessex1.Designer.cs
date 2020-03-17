namespace ADONETDEMO
{
    partial class connectionlessex1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnextract = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.cmbdeptno = new System.Windows.Forms.ComboBox();
            this.txtdetno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter deptno";
            // 
            // btnextract
            // 
            this.btnextract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnextract.Location = new System.Drawing.Point(545, 72);
            this.btnextract.Name = "btnextract";
            this.btnextract.Size = new System.Drawing.Size(75, 46);
            this.btnextract.TabIndex = 2;
            this.btnextract.Text = "extract";
            this.btnextract.UseVisualStyleBackColor = true;
            this.btnextract.Click += new System.EventHandler(this.btnextract_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(102, 168);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(598, 229);
            this.dgvdata.TabIndex = 3;
            // 
            // cmbdeptno
            // 
            this.cmbdeptno.FormattingEnabled = true;
            this.cmbdeptno.Location = new System.Drawing.Point(307, 117);
            this.cmbdeptno.Name = "cmbdeptno";
            this.cmbdeptno.Size = new System.Drawing.Size(121, 21);
            this.cmbdeptno.TabIndex = 4;
            this.cmbdeptno.SelectedIndexChanged += new System.EventHandler(this.cmbdeptno_SelectedIndexChanged);
            // 
            // txtdetno
            // 
            this.txtdetno.Location = new System.Drawing.Point(307, 72);
            this.txtdetno.Name = "txtdetno";
            this.txtdetno.Size = new System.Drawing.Size(100, 20);
            this.txtdetno.TabIndex = 5;
            // 
            // connectionlessex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdetno);
            this.Controls.Add(this.cmbdeptno);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnextract);
            this.Controls.Add(this.label1);
            this.Name = "connectionlessex1";
            this.Text = "connectionlessex1";
            this.Load += new System.EventHandler(this.connectionlessex1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnextract;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.ComboBox cmbdeptno;
        private System.Windows.Forms.TextBox txtdetno;
    }
}