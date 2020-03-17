namespace ADONETDEMO
{
    partial class update
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.cbbgender = new System.Windows.Forms.ComboBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txteno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtempno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnextract = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdeptno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(298, 376);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dtpdob
            // 
            this.dtpdob.Enabled = false;
            this.dtpdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(392, 261);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(200, 23);
            this.dtpdob.TabIndex = 17;
            // 
            // cbbgender
            // 
            this.cbbgender.Enabled = false;
            this.cbbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbgender.FormattingEnabled = true;
            this.cbbgender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cbbgender.Location = new System.Drawing.Point(392, 198);
            this.cbbgender.Name = "cbbgender";
            this.cbbgender.Size = new System.Drawing.Size(121, 25);
            this.cbbgender.TabIndex = 16;
            // 
            // txtename
            // 
            this.txtename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtename.Location = new System.Drawing.Point(392, 131);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(100, 23);
            this.txtename.TabIndex = 15;
            // 
            // txteno
            // 
            this.txteno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteno.Location = new System.Drawing.Point(392, 90);
            this.txteno.Name = "txteno";
            this.txteno.Size = new System.Drawing.Size(100, 23);
            this.txteno.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dob";
            // 
            // txtempno
            // 
            this.txtempno.AutoSize = true;
            this.txtempno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempno.Location = new System.Drawing.Point(208, 201);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(53, 17);
            this.txtempno.TabIndex = 12;
            this.txtempno.Text = "gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ename";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "empno";
            // 
            // btnextract
            // 
            this.btnextract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnextract.Location = new System.Drawing.Point(453, 376);
            this.btnextract.Name = "btnextract";
            this.btnextract.Size = new System.Drawing.Size(75, 23);
            this.btnextract.TabIndex = 19;
            this.btnextract.Text = "extract";
            this.btnextract.UseVisualStyleBackColor = true;
            this.btnextract.Click += new System.EventHandler(this.btnextract_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 20;
            // 
            // txtdeptno
            // 
            this.txtdeptno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeptno.Location = new System.Drawing.Point(392, 307);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(100, 23);
            this.txtdeptno.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "deptno";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(580, 376);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(77, 23);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdeptno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnextract);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.cbbgender);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txteno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtempno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.ComboBox cbbgender;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txteno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtempno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnextract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdeptno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndelete;
    }
}