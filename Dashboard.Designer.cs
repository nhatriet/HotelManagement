﻿namespace HotelManagement
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinisize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_CustomerRes1 = new HotelManagement.All_User_Control.UC_CustomerRes();
            this.uC_AddRoom1 = new HotelManagement.All_User_Control.UC_AddRoom();
            this.PanelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.SlateBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(3, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinisize
            // 
            this.btnMinisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinisize.FillColor = System.Drawing.Color.SlateBlue;
            this.btnMinisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinisize.Image")));
            this.btnMinisize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinisize.Location = new System.Drawing.Point(3, 53);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(34, 35);
            this.btnMinisize.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerDetail);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnCustomerRes);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(46, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 130);
            this.panel1.TabIndex = 3;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 18;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(1452, 7);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(284, 116);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Nhân viên";
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.BorderRadius = 18;
            this.btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetail.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.Location = new System.Drawing.Point(1083, 7);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(284, 116);
            this.btnCustomerDetail.TabIndex = 3;
            this.btnCustomerDetail.Text = "Chi tiết khách hàng";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BorderRadius = 18;
            this.btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(739, 7);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(284, 116);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Thanh toán";
            // 
            // btnCustomerRes
            // 
            this.btnCustomerRes.BorderRadius = 18;
            this.btnCustomerRes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRes.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCustomerRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCustomerRes.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRes.Location = new System.Drawing.Point(384, 7);
            this.btnCustomerRes.Name = "btnCustomerRes";
            this.btnCustomerRes.Size = new System.Drawing.Size(284, 116);
            this.btnCustomerRes.TabIndex = 1;
            this.btnCustomerRes.Text = "Đăng ký khách hàng";
            this.btnCustomerRes.Click += new System.EventHandler(this.btnCustomerRes_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 18;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(22, 7);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(284, 116);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_CustomerRes1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(22, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1882, 852);
            this.panel2.TabIndex = 4;
            // 
            // uC_CustomerRes1
            // 
            this.uC_CustomerRes1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRes1.Location = new System.Drawing.Point(-1, -1);
            this.uC_CustomerRes1.Name = "uC_CustomerRes1";
            this.uC_CustomerRes1.Size = new System.Drawing.Size(1882, 852);
            this.uC_CustomerRes1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.Location = new System.Drawing.Point(-1, -1);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1882, 852);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PanelMoving.Location = new System.Drawing.Point(70, 148);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(300, 7);
            this.PanelMoving.TabIndex = 5;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.PanelMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMinisize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRes;
        private Guna.UI2.WinForms.Guna2Panel PanelMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_CustomerRes uC_CustomerRes1;
    }
}