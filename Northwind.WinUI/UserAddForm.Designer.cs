namespace Northwind.WinUI
{
    partial class UserAddForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txxtPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblLastName = new MaterialSkin.Controls.MaterialLabel();
            this.lblPhone = new MaterialSkin.Controls.MaterialLabel();
            this.lblMail = new MaterialSkin.Controls.MaterialLabel();
            this.lblPasssword = new MaterialSkin.Controls.MaterialLabel();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(117, 138);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(117, 165);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(117, 193);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(117, 219);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 8;
            // 
            // txxtPassword
            // 
            this.txxtPassword.Location = new System.Drawing.Point(117, 248);
            this.txxtPassword.Name = "txxtPassword";
            this.txxtPassword.Size = new System.Drawing.Size(100, 20);
            this.txxtPassword.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(57, 140);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 18);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Ad";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Depth = 0;
            this.lblLastName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLastName.Location = new System.Drawing.Point(31, 166);
            this.lblLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(50, 19);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Soyad";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Depth = 0;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPhone.Location = new System.Drawing.Point(25, 195);
            this.lblPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(57, 18);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Telefon";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Depth = 0;
            this.lblMail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMail.Location = new System.Drawing.Point(31, 220);
            this.lblMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(51, 19);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "E-mail";
            // 
            // lblPasssword
            // 
            this.lblPasssword.AutoSize = true;
            this.lblPasssword.Depth = 0;
            this.lblPasssword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPasssword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPasssword.Location = new System.Drawing.Point(42, 249);
            this.lblPasssword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPasssword.Name = "lblPasssword";
            this.lblPasssword.Size = new System.Drawing.Size(40, 19);
            this.lblPasssword.TabIndex = 15;
            this.lblPasssword.Text = "Şifre";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddUser.Location = new System.Drawing.Point(22, 76);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(195, 20);
            this.lblAddUser.TabIndex = 16;
            this.lblAddUser.Text = "Kullanıcı Ekleme Formu";
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 342);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.lblPasssword);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txxtPassword);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "UserAddForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txxtPassword;
        private System.Windows.Forms.Button btnAdd;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblLastName;
        private MaterialSkin.Controls.MaterialLabel lblPhone;
        private MaterialSkin.Controls.MaterialLabel lblMail;
        private MaterialSkin.Controls.MaterialLabel lblPasssword;
        private System.Windows.Forms.Label lblAddUser;
    }
}

