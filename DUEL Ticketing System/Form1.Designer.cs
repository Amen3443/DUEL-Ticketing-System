namespace DUEL_Ticketing_System
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
            this.components = new System.ComponentModel.Container();
            this.dUEL_DataBaseDataSet = new DUEL_Ticketing_System.DUEL_DataBaseDataSet();
            this.patronBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronTableAdapter = new DUEL_Ticketing_System.DUEL_DataBaseDataSetTableAdapters.PatronTableAdapter();
            this.tableAdapterManager = new DUEL_Ticketing_System.DUEL_DataBaseDataSetTableAdapters.TableAdapterManager();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameS = new System.Windows.Forms.Label();
            this.UserNametextBoxL = new System.Windows.Forms.TextBox();
            this.PasswordtextBoxL = new System.Windows.Forms.TextBox();
            this.PasswordtextBoxS = new System.Windows.Forms.TextBox();
            this.UserNametextBoxS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdressLable = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.PhoneNumberlabel = new System.Windows.Forms.Label();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.PhoneNumbertextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.AdresstextBox = new System.Windows.Forms.TextBox();
            this.SignUppanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LogInpanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dUEL_DataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronBindingSource)).BeginInit();
            this.SignUppanel.SuspendLayout();
            this.LogInpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dUEL_DataBaseDataSet
            // 
            this.dUEL_DataBaseDataSet.DataSetName = "DUEL_DataBaseDataSet";
            this.dUEL_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patronBindingSource
            // 
            this.patronBindingSource.DataMember = "Patron";
            this.patronBindingSource.DataSource = this.dUEL_DataBaseDataSet;
            // 
            // patronTableAdapter
            // 
            this.patronTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatronTableAdapter = this.patronTableAdapter;
            this.tableAdapterManager.UpdateOrder = DUEL_Ticketing_System.DUEL_DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LogInbutton
            // 
            this.LogInbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInbutton.Location = new System.Drawing.Point(132, 233);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(102, 38);
            this.LogInbutton.TabIndex = 0;
            this.LogInbutton.Text = "Log In";
            this.LogInbutton.UseVisualStyleBackColor = true;
            this.LogInbutton.Click += new System.EventHandler(this.LogInbutton_Click);
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.Location = new System.Drawing.Point(29, 117);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(63, 13);
            this.U.TabIndex = 1;
            this.U.Text = "User Name:";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Location = new System.Drawing.Point(29, 157);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(56, 13);
            this.Passwordlabel.TabIndex = 2;
            this.Passwordlabel.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(16, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "If you don\'t have anaccount:";
            // 
            // UserNameS
            // 
            this.UserNameS.AutoSize = true;
            this.UserNameS.Location = new System.Drawing.Point(63, 89);
            this.UserNameS.Name = "UserNameS";
            this.UserNameS.Size = new System.Drawing.Size(63, 13);
            this.UserNameS.TabIndex = 4;
            this.UserNameS.Text = "User Name:";
            // 
            // UserNametextBoxL
            // 
            this.UserNametextBoxL.Location = new System.Drawing.Point(104, 114);
            this.UserNametextBoxL.Name = "UserNametextBoxL";
            this.UserNametextBoxL.Size = new System.Drawing.Size(130, 20);
            this.UserNametextBoxL.TabIndex = 5;
            // 
            // PasswordtextBoxL
            // 
            this.PasswordtextBoxL.Location = new System.Drawing.Point(104, 154);
            this.PasswordtextBoxL.Name = "PasswordtextBoxL";
            this.PasswordtextBoxL.PasswordChar = '*';
            this.PasswordtextBoxL.Size = new System.Drawing.Size(130, 20);
            this.PasswordtextBoxL.TabIndex = 6;
            // 
            // PasswordtextBoxS
            // 
            this.PasswordtextBoxS.Location = new System.Drawing.Point(139, 108);
            this.PasswordtextBoxS.Name = "PasswordtextBoxS";
            this.PasswordtextBoxS.PasswordChar = '*';
            this.PasswordtextBoxS.Size = new System.Drawing.Size(156, 20);
            this.PasswordtextBoxS.TabIndex = 10;
            // 
            // UserNametextBoxS
            // 
            this.UserNametextBoxS.Location = new System.Drawing.Point(139, 82);
            this.UserNametextBoxS.Name = "UserNametextBoxS";
            this.UserNametextBoxS.Size = new System.Drawing.Size(156, 20);
            this.UserNametextBoxS.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password:";
            // 
            // AdressLable
            // 
            this.AdressLable.AutoSize = true;
            this.AdressLable.Location = new System.Drawing.Point(91, 192);
            this.AdressLable.Name = "AdressLable";
            this.AdressLable.Size = new System.Drawing.Size(42, 13);
            this.AdressLable.TabIndex = 7;
            this.AdressLable.Text = "Adress:";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(91, 167);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(35, 13);
            this.Emaillabel.TabIndex = 11;
            this.Emaillabel.Text = "Email:";
            // 
            // PhoneNumberlabel
            // 
            this.PhoneNumberlabel.AutoSize = true;
            this.PhoneNumberlabel.Location = new System.Drawing.Point(48, 141);
            this.PhoneNumberlabel.Name = "PhoneNumberlabel";
            this.PhoneNumberlabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberlabel.TabIndex = 12;
            this.PhoneNumberlabel.Text = "PhoneNumber:";
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbutton.Location = new System.Drawing.Point(193, 246);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(102, 38);
            this.SignUpbutton.TabIndex = 13;
            this.SignUpbutton.Text = "Sign Up";
            this.SignUpbutton.UseVisualStyleBackColor = true;
            this.SignUpbutton.Click += new System.EventHandler(this.SignUpbutton_Click);
            // 
            // PhoneNumbertextBox
            // 
            this.PhoneNumbertextBox.Location = new System.Drawing.Point(139, 134);
            this.PhoneNumbertextBox.Name = "PhoneNumbertextBox";
            this.PhoneNumbertextBox.Size = new System.Drawing.Size(156, 20);
            this.PhoneNumbertextBox.TabIndex = 14;
            this.PhoneNumbertextBox.TextChanged += new System.EventHandler(this.PhoneNumbertextBox_TextChanged);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(139, 160);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(156, 20);
            this.EmailtextBox.TabIndex = 15;
            // 
            // AdresstextBox
            // 
            this.AdresstextBox.Location = new System.Drawing.Point(139, 186);
            this.AdresstextBox.Name = "AdresstextBox";
            this.AdresstextBox.Size = new System.Drawing.Size(158, 20);
            this.AdresstextBox.TabIndex = 16;
            // 
            // SignUppanel
            // 
            this.SignUppanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SignUppanel.Controls.Add(this.label4);
            this.SignUppanel.Controls.Add(this.PhoneNumberlabel);
            this.SignUppanel.Controls.Add(this.AdresstextBox);
            this.SignUppanel.Controls.Add(this.UserNameS);
            this.SignUppanel.Controls.Add(this.EmailtextBox);
            this.SignUppanel.Controls.Add(this.AdressLable);
            this.SignUppanel.Controls.Add(this.PhoneNumbertextBox);
            this.SignUppanel.Controls.Add(this.label1);
            this.SignUppanel.Controls.Add(this.SignUpbutton);
            this.SignUppanel.Controls.Add(this.UserNametextBoxS);
            this.SignUppanel.Controls.Add(this.PasswordtextBoxS);
            this.SignUppanel.Controls.Add(this.Emaillabel);
            this.SignUppanel.Location = new System.Drawing.Point(383, 59);
            this.SignUppanel.Name = "SignUppanel";
            this.SignUppanel.Size = new System.Drawing.Size(326, 314);
            this.SignUppanel.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "SIGN UP";
            // 
            // LogInpanel
            // 
            this.LogInpanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogInpanel.Controls.Add(this.label5);
            this.LogInpanel.Controls.Add(this.linkLabel1);
            this.LogInpanel.Controls.Add(this.label2);
            this.LogInpanel.Controls.Add(this.LogInbutton);
            this.LogInpanel.Controls.Add(this.U);
            this.LogInpanel.Controls.Add(this.PasswordtextBoxL);
            this.LogInpanel.Controls.Add(this.Passwordlabel);
            this.LogInpanel.Controls.Add(this.UserNametextBoxL);
            this.LogInpanel.Controls.Add(this.label3);
            this.LogInpanel.Location = new System.Drawing.Point(61, 59);
            this.LogInpanel.Name = "LogInpanel";
            this.LogInpanel.Size = new System.Drawing.Size(258, 314);
            this.LogInpanel.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Don\'t have an Account: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(164, 186);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "LOG IN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.LogInpanel);
            this.Controls.Add(this.SignUppanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dUEL_DataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronBindingSource)).EndInit();
            this.SignUppanel.ResumeLayout(false);
            this.SignUppanel.PerformLayout();
            this.LogInpanel.ResumeLayout(false);
            this.LogInpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DUEL_DataBaseDataSet dUEL_DataBaseDataSet;
        private System.Windows.Forms.BindingSource patronBindingSource;
        private DUEL_DataBaseDataSetTableAdapters.PatronTableAdapter patronTableAdapter;
        private DUEL_DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button LogInbutton;
        private System.Windows.Forms.Label U;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UserNameS;
        private System.Windows.Forms.TextBox UserNametextBoxL;
        private System.Windows.Forms.TextBox PasswordtextBoxL;
        private System.Windows.Forms.TextBox PasswordtextBoxS;
        private System.Windows.Forms.TextBox UserNametextBoxS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdressLable;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label PhoneNumberlabel;
        private System.Windows.Forms.Button SignUpbutton;
        private System.Windows.Forms.TextBox PhoneNumbertextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox AdresstextBox;
        private System.Windows.Forms.Panel SignUppanel;
        private System.Windows.Forms.Panel LogInpanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

