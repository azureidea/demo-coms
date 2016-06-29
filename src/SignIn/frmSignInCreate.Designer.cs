﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.SignIn
{
    public partial class frmSignInCreate : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmSignInCreate()
            : base()
        {

            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]

        private void InitializeComponent()
        {
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.btntype = new Smobiler.Core.Controls.Button();
            this.btntype2 = new Smobiler.Core.Controls.Button();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.btnPunchCardType = new Smobiler.Core.Controls.Button();
            this.btnPunchCardType2 = new Smobiler.Core.Controls.Button();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.lblAddress = new Smobiler.Core.Controls.Label();
            this.SignIn = new Smobiler.Core.Controls.ToolbarItem();
            this.Gps1 = new Smobiler.Core.Controls.GPS();
            this.PopList1 = new Smobiler.Core.Controls.PopList();
            this.btnAddress = new Smobiler.Core.Controls.Button();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "类型";
            this.Label1.ZIndex = 1;
            // 
            // btntype
            // 
            this.btntype.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btntype.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btntype.Location = new Smobiler.Core.PointS(35F, 0F);
            this.btntype.Name = "btntype";
            this.btntype.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btntype.Size = new System.Drawing.SizeF(75F, 14F);
            this.btntype.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype.TabIndex = 3;
            this.btntype.Text = "选择（必填）";
            this.btntype.ZIndex = 2;
            this.btntype.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype2_Click);
            // 
            // btntype2
            // 
            this.btntype2.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btntype2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntype2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btntype2.Location = new Smobiler.Core.PointS(110F, 0F);
            this.btntype2.Name = "btntype2";
            this.btntype2.Size = new System.Drawing.SizeF(10F, 14F);
            this.btntype2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btntype2.TabIndex = 4;
            this.btntype2.Text = ">";
            this.btntype2.ZIndex = 3;
            this.btntype2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype2_Click);
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new Smobiler.Core.PointS(0F, 17F);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "时间";
            this.Label2.ZIndex = 4;
            // 
            // Label3
            // 
            this.Label3.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new Smobiler.Core.PointS(0F, 31F);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Padding(2F, 5F, 0F, 0F);
            this.Label3.Size = new System.Drawing.SizeF(35F, 34F);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "地点";
            this.Label3.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.Label3.ZIndex = 6;
            // 
            // Label4
            // 
            this.Label4.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new Smobiler.Core.PointS(0F, 68F);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Padding(2F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.SizeF(35F, 14F);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "打卡类型";
            // 
            // btnPunchCardType
            // 
            this.btnPunchCardType.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnPunchCardType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPunchCardType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnPunchCardType.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.btnPunchCardType.Location = new Smobiler.Core.PointS(35F, 68F);
            this.btnPunchCardType.Name = "btnPunchCardType";
            this.btnPunchCardType.Padding = new Smobiler.Core.Padding(0F, 0F, 2F, 0F);
            this.btnPunchCardType.Size = new System.Drawing.SizeF(75F, 14F);
            this.btnPunchCardType.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnPunchCardType.TabIndex = 8;
            this.btnPunchCardType.Text = "选择（必填）";
            this.btnPunchCardType.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype2_Click);
            // 
            // btnPunchCardType2
            // 
            this.btnPunchCardType2.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.btnPunchCardType2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPunchCardType2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnPunchCardType2.Location = new Smobiler.Core.PointS(110F, 68F);
            this.btnPunchCardType2.Name = "btnPunchCardType2";
            this.btnPunchCardType2.Size = new System.Drawing.SizeF(10F, 14F);
            this.btnPunchCardType2.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnPunchCardType2.TabIndex = 9;
            this.btnPunchCardType2.Text = ">";
            this.btnPunchCardType2.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btntype2_Click);
            // 
            // lblDate
            // 
            this.lblDate.Border = new Smobiler.Core.Border(0, 1, 0, 1);
            this.lblDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblDate.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Right;
            this.lblDate.Location = new Smobiler.Core.PointS(35F, 17F);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Padding(0F, 0F, 12F, 0F);
            this.lblDate.Size = new System.Drawing.SizeF(85F, 14F);
            this.lblDate.TabIndex = 10;
            this.lblDate.ZIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblAddress.Location = new Smobiler.Core.PointS(35F, 31F);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new Smobiler.Core.Padding(0F, 5F, 12F, 0F);
            this.lblAddress.Size = new System.Drawing.SizeF(85F, 24F);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "正在定位...";
            this.lblAddress.VerticalAlignment = Smobiler.Core.VerticalAlignment.Top;
            this.lblAddress.ZIndex = 7;
            // 
            // SignIn
            // 
            this.SignIn.IconID = "!\\ue161043146223";
            this.SignIn.Name = "SignIn";
            this.SignIn.Text = "签到";
            // 
            // Gps1
            // 
            this.Gps1.Name = "Gps1";
            this.Gps1.GotLocation += new Smobiler.Core.GpsCallBackHandler(this.Gps1_GotLocation);
            // 
            // PopList1
            // 
            this.PopList1.Name = "PopList1";
            this.PopList1.Selected += new System.EventHandler(this.PopList1_Selected);
            // 
            // btnAddress
            // 
            this.btnAddress.Border = new Smobiler.Core.Border(0, 0, 0, 1);
            this.btnAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAddress.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Left;
            this.btnAddress.HoverBackColor = System.Drawing.Color.White;
            this.btnAddress.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAddress.Location = new Smobiler.Core.PointS(35F, 55F);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.SizeF(85F, 10F);
            this.btnAddress.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.btnAddress.TabIndex = 12;
            this.btnAddress.Text = "地点微调";
            this.btnAddress.ZIndex = 8;
            this.btnAddress.Click += new Smobiler.Core.Controls.ButtonBase.ClickEventHandler(this.btnAddress_Click);
            // 
            // frmSignInCreate
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.Gps1,
            this.PopList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.btnPunchCardType,
            this.btnPunchCardType2,
            this.Label1,
            this.btntype,
            this.btntype2,
            this.Label2,
            this.lblDate,
            this.Label3,
            this.lblAddress,
            this.btnAddress});
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "签到录入";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.SignIn});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmSignInCreate_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmSignInCreate_ToolbarItemClick);
            this.TitleImageClick += new System.EventHandler(this.frmSignInCreate_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Button btntype;
        internal Smobiler.Core.Controls.Button btntype2;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Button btnPunchCardType;
        internal Smobiler.Core.Controls.Button btnPunchCardType2;
        internal Smobiler.Core.Controls.Label lblDate;
        internal Smobiler.Core.Controls.Label lblAddress;
        internal Smobiler.Core.Controls.ToolbarItem SignIn;
        internal Smobiler.Core.Controls.GPS Gps1;
        internal Smobiler.Core.Controls.PopList PopList1;
        internal Smobiler.Core.Controls.Button btnAddress;
        #endregion

    }


}