namespace ADONETDEMO
{
    partial class Insert
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtempno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txteno = new System.Windows.Forms.TextBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.cbbgender = new System.Windows.Forms.ComboBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.btninsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "empno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ename";
            // 
            // txtempno
            // 
            this.txtempno.AutoSize = true;
            this.txtempno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempno.Location = new System.Drawing.Point(112, 151);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(53, 17);
            this.txtempno.TabIndex = 2;
            this.txtempno.Text = "gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dob";
            // 
            // txteno
            // 
            this.txteno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteno.Location = new System.Drawing.Point(296, 40);
            this.txteno.Name = "txteno";
            this.txteno.Size = new System.Drawing.Size(100, 23);
            this.txteno.TabIndex = 4;
            // 
            // txtename
            // 
            this.txtename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtename.Location = new System.Drawing.Point(296, 81);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(100, 23);
            this.txtename.TabIndex = 5;
            // 
            // cbbgender
            // 
            this.cbbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbgender.FormattingEnabled = true;
            this.cbbgender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cbbgender.Location = new System.Drawing.Point(296, 148);
            this.cbbgender.Name = "cbbgender";
            this.cbbgender.Size = new System.Drawing.Size(121, 25);
            this.cbbgender.TabIndex = 7;
            // 
            // dtpdob
            // 
            this.dtpdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(296, 211);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(200, 23);
            this.dtpdob.TabIndex = 8;
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(224, 288);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 9;
            this.btninsert.Text = "insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.cbbgender);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txteno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtempno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Insert";
            this.Text = "Insert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtempno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txteno;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.ComboBox cbbgender;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Button btninsert;
    }
}