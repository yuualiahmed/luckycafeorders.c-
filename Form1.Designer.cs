namespace luckycafeorders
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbcoffe = new System.Windows.Forms.RadioButton();
            this.rdbjuice = new System.Windows.Forms.RadioButton();
            this.rdbtea = new System.Windows.Forms.RadioButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.ckbstudent = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.orderedlist = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbllucky = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 402);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer information";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Custumer Name";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbcoffe);
            this.groupBox1.Controls.Add(this.rdbjuice);
            this.groupBox1.Controls.Add(this.rdbtea);
            this.groupBox1.Location = new System.Drawing.Point(16, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drink type:";
            // 
            // rdbcoffe
            // 
            this.rdbcoffe.AutoSize = true;
            this.rdbcoffe.Location = new System.Drawing.Point(28, 89);
            this.rdbcoffe.Name = "rdbcoffe";
            this.rdbcoffe.Size = new System.Drawing.Size(111, 24);
            this.rdbcoffe.TabIndex = 0;
            this.rdbcoffe.TabStop = true;
            this.rdbcoffe.Text = "coffee ($2)";
            this.rdbcoffe.UseVisualStyleBackColor = true;
            // 
            // rdbjuice
            // 
            this.rdbjuice.AutoSize = true;
            this.rdbjuice.Location = new System.Drawing.Point(28, 142);
            this.rdbjuice.Name = "rdbjuice";
            this.rdbjuice.Size = new System.Drawing.Size(98, 24);
            this.rdbjuice.TabIndex = 0;
            this.rdbjuice.TabStop = true;
            this.rdbjuice.Text = "juice ($3)";
            this.rdbjuice.UseVisualStyleBackColor = true;
            // 
            // rdbtea
            // 
            this.rdbtea.AutoSize = true;
            this.rdbtea.Location = new System.Drawing.Point(28, 42);
            this.rdbtea.Name = "rdbtea";
            this.rdbtea.Size = new System.Drawing.Size(93, 24);
            this.rdbtea.TabIndex = 0;
            this.rdbtea.TabStop = true;
            this.rdbtea.Text = "Tea ($1)";
            this.rdbtea.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(27, 126);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(353, 26);
            this.txtname.TabIndex = 2;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(101, 379);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(91, 26);
            this.txtquantity.TabIndex = 2;
            // 
            // ckbstudent
            // 
            this.ckbstudent.AutoSize = true;
            this.ckbstudent.Location = new System.Drawing.Point(219, 381);
            this.ckbstudent.Name = "ckbstudent";
            this.ckbstudent.Size = new System.Drawing.Size(223, 24);
            this.ckbstudent.TabIndex = 3;
            this.ckbstudent.Text = "Student member (%10 off)";
            this.ckbstudent.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(22, 466);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(169, 46);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "Calculate order";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(219, 466);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(169, 46);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "save to file";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(415, 466);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(169, 46);
            this.btnload.TabIndex = 4;
            this.btnload.Text = "load from file";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(626, 466);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(169, 46);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button4_Click);
            // 
            // orderedlist
            // 
            this.orderedlist.FormattingEnabled = true;
            this.orderedlist.ItemHeight = 20;
            this.orderedlist.Location = new System.Drawing.Point(477, 40);
            this.orderedlist.Name = "orderedlist";
            this.orderedlist.Size = new System.Drawing.Size(317, 384);
            this.orderedlist.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(772, 126);
            this.label5.TabIndex = 0;
            // 
            // lbltotal
            // 
            this.lbltotal.Location = new System.Drawing.Point(47, 561);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(216, 33);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllucky
            // 
            this.lbllucky.Location = new System.Drawing.Point(47, 612);
            this.lbllucky.Name = "lbllucky";
            this.lbllucky.Size = new System.Drawing.Size(216, 33);
            this.lbllucky.TabIndex = 6;
            this.lbllucky.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 674);
            this.Controls.Add(this.lbllucky);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.orderedlist);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.ckbstudent);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbcoffe;
        private System.Windows.Forms.RadioButton rdbjuice;
        private System.Windows.Forms.RadioButton rdbtea;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.CheckBox ckbstudent;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox orderedlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbllucky;
    }
}

