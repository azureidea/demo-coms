using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using Smobiler.Core.Plugin.RongIM;

namespace COMSSmobilerDemo
{
    partial class frmAddContact : Smobiler.Core.MobileForm
    {

        public IM im;
        public bool isGroup;

        private int groupuserCount = 0;

        private void Bind()
        {
            COMSSmobilerDemo.common.frmContact user = new COMSSmobilerDemo.common.frmContact();
            DataTable table = new DataTable();
            if (isGroup == true)
            {
                table = user.GetContactData();
            }
            else
            {
                table = user.GetContactData1();
            }
            if (table.Rows.Count > 0)
            {
              
                this.GridView1.DataSource = table;
                this.GridView1.DataBind();
                if (isGroup == true)
                {
                    foreach (GridViewRow ROW in GridView1.Rows)
                    {
                        if (ROW.Cell.Items["lblUSER_ID"].DefaultValue.ToString().ToUpper() == Client.Session["UserID"].ToString().ToUpper())
                        {
                            ROW.Cell.Items["Check"].DefaultValue = true;
                            ROW.Cell.Items["Check"].Enabled = false;
                        }
                    }
                }
                else
                {
                    foreach (GridViewRow ROW in GridView1.Rows)
                    {
                        if (Convert .ToBoolean (ROW.Cell.Items["btnAddUser"].Value) == true)
                        {
                            ROW.Cell.Items["btnAddUser"].Text = "�����";
                            ROW.Cell.Items["btnAddUser"].BackColor = System.Drawing.Color.White;
                            ROW.Cell.Items["btnAddUser"].ForeColor = System.Drawing.Color.Gray;
                            ROW.Cell.Items["btnAddUser"].Enabled = false;
                        }
                    }
                }
            }
            else
            {
                this.GridView1.Rows.Clear();
            }
        }

        private void GridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            if (isGroup == true)
            {
                getGroupuserCount();
            }
            else
            {
                string userid = e.Cell.Items["lblUSER_ID"].Text;
                if (string.IsNullOrEmpty(userid) == false)
                { 
                    //����û�
                    string token = im.CreateUser(userid, userid, ".\\Image\\" + e.Cell.Items["imgPortraitUri"].DefaultValue + ".PNG");
                    if (im != null)
                    {
                         //�����ϵ�˵����ݿ�

                        MessageBox.Show("��ϵ�������", (Object s, MessageBoxHandlerArgs args) => Bind());
                    }
                    else
                    {
                        Toast("��ϵ�����ʧ��");
                    }
                }
            }
        }
        /// <summary>
        ///����Ⱥ���Ա��
        /// </summary>
        /// <remarks></remarks>
        public void getGroupuserCount()
        {
            try
            {
                groupuserCount = 0;
                foreach (GridViewRow ROW in GridView1.Rows)
                {
                    if (Convert .ToBoolean (ROW.Cell.Items["Check"].DefaultValue) == true)
                    {
                        if (ROW.Cell.Items["lblUSER_ID"].DefaultValue.ToString().ToUpper() != this.Client.UserSessionID.ToUpper())
                        {
                            groupuserCount += 1;
                        }
                    }
                }
                FooterBarLayoutData.Items["lblUserCount"].DefaultValue = groupuserCount.ToString() + "��";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmAddContent_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmAddContent_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddContent_FooterBarLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            try
            {
                if (txtGroup.Text.Trim().Length <= 0)
                {
                    throw new Exception("������Ⱥ������");
                }
                if (groupuserCount < 0)
                {
                    throw new Exception("��ѡ��Ⱥ���Ա");
                }
                string[] users = new string[groupuserCount + 1];
                string guser = "";
                int n = 0;
                foreach (GridViewRow ROW in GridView1.Rows)
                {
                    if (Convert .ToBoolean (ROW.Cell.Items["Check"].DefaultValue) == true)
                    {
                        if (string.IsNullOrWhiteSpace(guser) == false)
                        {
                            guser += "," + ROW.Cell.Items["lblUSER_ID"].DefaultValue;
                        }
                        else
                        {
                            guser = ROW.Cell.Items["lblUSER_ID"].DefaultValue.ToString ();
                        }

                        users[n] = ROW.Cell.Items["lblUSER_ID"].DefaultValue.ToString();
                        n += 1;
                    }
                }
                 //���Ⱥ�鵽���ݿ�
                //....
                //
                im.CreateGroup(users, "G0001", txtGroup.Text.Trim());
                MessageBox.Show("Ⱥ�������", (Object s, MessageBoxHandlerArgs args) => Close());

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        private void frmAddContact_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddContact_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmAddContact_Load(object sender, EventArgs e)
        {
            if (isGroup == true)
            {
                lblGroup.Visible = true;
                txtGroup.Visible = true;
                GridView1.Top = 35;
                GridView1.Layout = "frmJoinGUserLayout";
                FooterBarLayout = "frmJoinGUserFootbarLayout";
            }
            else
            {
                lblGroup.Visible = false;
                txtGroup.Visible = false;
                GridView1.Top = 0;
                GridView1.Layout = "frmAddUserLayout";
                FooterBarLayout = " ";
            }
            Bind();
        }

    }
}