﻿namespace AccountSystem
{
    partial class AddAccount
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
            this.txtFamilyCall = new System.Windows.Forms.TextBox();
            this.txtTrueName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbFamilyCall = new System.Windows.Forms.Label();
            this.lbTrueName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbNickname = new System.Windows.Forms.Label();
            this.lbAccountStyle = new System.Windows.Forms.Label();
            this.AccountStyle = new System.Windows.Forms.ComboBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbNecessary = new System.Windows.Forms.Label();
            this.lbNecessary2 = new System.Windows.Forms.Label();
            this.lbNecessary3 = new System.Windows.Forms.Label();
            this.lbNecessary4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFamilyCall
            // 
            this.txtFamilyCall.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFamilyCall.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtFamilyCall.Location = new System.Drawing.Point(159, 260);
            this.txtFamilyCall.Name = "txtFamilyCall";
            this.txtFamilyCall.Size = new System.Drawing.Size(183, 33);
            this.txtFamilyCall.TabIndex = 25;
            // 
            // txtTrueName
            // 
            this.txtTrueName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTrueName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTrueName.Location = new System.Drawing.Point(159, 200);
            this.txtTrueName.Name = "txtTrueName";
            this.txtTrueName.Size = new System.Drawing.Size(183, 33);
            this.txtTrueName.TabIndex = 24;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPassword.Location = new System.Drawing.Point(159, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(183, 33);
            this.txtPassword.TabIndex = 23;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(159, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 33);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbFamilyCall
            // 
            this.lbFamilyCall.AutoSize = true;
            this.lbFamilyCall.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFamilyCall.ForeColor = System.Drawing.Color.White;
            this.lbFamilyCall.Location = new System.Drawing.Point(47, 262);
            this.lbFamilyCall.Name = "lbFamilyCall";
            this.lbFamilyCall.Size = new System.Drawing.Size(106, 24);
            this.lbFamilyCall.TabIndex = 21;
            this.lbFamilyCall.Text = "家庭称呼";
            // 
            // lbTrueName
            // 
            this.lbTrueName.AutoSize = true;
            this.lbTrueName.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTrueName.ForeColor = System.Drawing.Color.White;
            this.lbTrueName.Location = new System.Drawing.Point(47, 202);
            this.lbTrueName.Name = "lbTrueName";
            this.lbTrueName.Size = new System.Drawing.Size(106, 24);
            this.lbTrueName.TabIndex = 20;
            this.lbTrueName.Text = "真实姓名";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(47, 142);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(58, 24);
            this.lbPassword.TabIndex = 19;
            this.lbPassword.Text = "密码";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(47, 22);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(82, 24);
            this.lbUsername.TabIndex = 18;
            this.lbUsername.Text = "用户名";
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNickname.ForeColor = System.Drawing.Color.White;
            this.lbNickname.Location = new System.Drawing.Point(47, 82);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(58, 24);
            this.lbNickname.TabIndex = 17;
            this.lbNickname.Text = "昵称";
            // 
            // lbAccountStyle
            // 
            this.lbAccountStyle.AutoSize = true;
            this.lbAccountStyle.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAccountStyle.ForeColor = System.Drawing.Color.White;
            this.lbAccountStyle.Location = new System.Drawing.Point(47, 324);
            this.lbAccountStyle.Name = "lbAccountStyle";
            this.lbAccountStyle.Size = new System.Drawing.Size(106, 24);
            this.lbAccountStyle.TabIndex = 28;
            this.lbAccountStyle.Text = "账户类型";
            // 
            // AccountStyle
            // 
            this.AccountStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountStyle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountStyle.FormattingEnabled = true;
            this.AccountStyle.ItemHeight = 25;
            this.AccountStyle.Items.AddRange(new object[] {
            "普通",
            "管理员"});
            this.AccountStyle.Location = new System.Drawing.Point(159, 324);
            this.AccountStyle.Name = "AccountStyle";
            this.AccountStyle.Size = new System.Drawing.Size(183, 33);
            this.AccountStyle.TabIndex = 29;
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNickname.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtNickname.Location = new System.Drawing.Point(159, 82);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(183, 33);
            this.txtNickname.TabIndex = 30;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUsername.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtUsername.Location = new System.Drawing.Point(159, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(183, 33);
            this.txtUsername.TabIndex = 31;
            // 
            // lbNecessary
            // 
            this.lbNecessary.AutoSize = true;
            this.lbNecessary.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNecessary.ForeColor = System.Drawing.Color.Red;
            this.lbNecessary.Location = new System.Drawing.Point(348, 27);
            this.lbNecessary.Name = "lbNecessary";
            this.lbNecessary.Size = new System.Drawing.Size(22, 21);
            this.lbNecessary.TabIndex = 32;
            this.lbNecessary.Text = "*";
            // 
            // lbNecessary2
            // 
            this.lbNecessary2.AutoSize = true;
            this.lbNecessary2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNecessary2.ForeColor = System.Drawing.Color.Red;
            this.lbNecessary2.Location = new System.Drawing.Point(348, 87);
            this.lbNecessary2.Name = "lbNecessary2";
            this.lbNecessary2.Size = new System.Drawing.Size(22, 21);
            this.lbNecessary2.TabIndex = 33;
            this.lbNecessary2.Text = "*";
            // 
            // lbNecessary3
            // 
            this.lbNecessary3.AutoSize = true;
            this.lbNecessary3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNecessary3.ForeColor = System.Drawing.Color.Red;
            this.lbNecessary3.Location = new System.Drawing.Point(348, 145);
            this.lbNecessary3.Name = "lbNecessary3";
            this.lbNecessary3.Size = new System.Drawing.Size(22, 21);
            this.lbNecessary3.TabIndex = 34;
            this.lbNecessary3.Text = "*";
            // 
            // lbNecessary4
            // 
            this.lbNecessary4.AutoSize = true;
            this.lbNecessary4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNecessary4.ForeColor = System.Drawing.Color.Red;
            this.lbNecessary4.Location = new System.Drawing.Point(348, 329);
            this.lbNecessary4.Name = "lbNecessary4";
            this.lbNecessary4.Size = new System.Drawing.Size(22, 21);
            this.lbNecessary4.TabIndex = 35;
            this.lbNecessary4.Text = "*";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(398, 413);
            this.Controls.Add(this.lbNecessary4);
            this.Controls.Add(this.lbNecessary3);
            this.Controls.Add(this.lbNecessary2);
            this.Controls.Add(this.lbNecessary);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.AccountStyle);
            this.Controls.Add(this.lbAccountStyle);
            this.Controls.Add(this.txtFamilyCall);
            this.Controls.Add(this.txtTrueName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbFamilyCall);
            this.Controls.Add(this.lbTrueName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加账号";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFamilyCall;
        private System.Windows.Forms.TextBox txtTrueName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbFamilyCall;
        private System.Windows.Forms.Label lbTrueName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label lbAccountStyle;
        private System.Windows.Forms.ComboBox AccountStyle;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbNecessary;
        private System.Windows.Forms.Label lbNecessary2;
        private System.Windows.Forms.Label lbNecessary3;
        private System.Windows.Forms.Label lbNecessary4;
    }
}