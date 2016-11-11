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
    partial class frmContacts : Smobiler.Core.MobileForm
    {

        public string toolBarName;
        public IM im;
     
        /// <summary>
        /// ��ʼ������
        /// </summary>
        /// <remarks></remarks>

        private void InitialIM()
        {
            im.LoadGroupInfoHandler = (new IMLoadGroupInfoHandler(id =>
            {
                IMGroupEntry group = new IMGroupEntry();
                COMSSmobilerDemo.common.frmGroup frmGroup = new COMSSmobilerDemo.common.frmGroup();
                group.GroupID = id;
                group.GroupName = "Smobiler����Ⱥ";
                // group.PortraitUri = "http://www.rongcloud.cn/images/logo.png"
                return group;
            }));
            im.LoadUserInfoHandler = (new IMLoadUserInfoHandler(id =>
            {
                IMUserEntry user = new IMUserEntry();
                user.UserID = id;
                user.UserName = id;
                user.PortraitUri = ".\\Image\\" + id + ".PNG";
                return user;
            }));
            im.LoadGroupMembersHandler = (new IMLoadGroupMembersHandler(id =>
            {

                return new string[] { "Demo", "A", "B" };
            }));
            im.TokenExpiredHandler = (new IMTokenExpiredHandler(id =>
            {
                string userid = Client .Session ["UserID"].ToString ();
                if (im != null && System.String.IsNullOrEmpty(userid) == false)
                {
                    //���õ�ǰ���û�Token

                    im.Token = im.GetUserToken(userid, userid, ".\\Image\\" + userid + ".PNG");
                    //����Token
                    return im.Token;
                }
                else
                {
                    return "";
                }
            }));

        }
      
        private void Bind()
        {
            DataTable table = new DataTable();
            switch (imageTabBar1.SelectItemIndex)
            {
                case 0:
                    GridView1.Layout = "frmContentLayout";
                    COMSSmobilerDemo.common.frmContact frmConcat = new COMSSmobilerDemo.common.frmContact();
                    table = frmConcat.GetContactData();
                    break;
                case 1:
                    GridView1.Layout = "frmGroupLayout";
                    COMSSmobilerDemo.common.frmGroup frmGroup = new COMSSmobilerDemo.common.frmGroup();
                    table = frmGroup.GetGroupData ();
                    break;
            }
            if (table.Rows.Count > 0)
            {               
                GridView1.DataSource = table;
                GridView1.DataBind();
            }
            else
            {
                GridView1.Rows.Clear();
            }

        }


        /// <summary>
        /// GridView����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void GridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            switch (imageTabBar1.SelectItemIndex)
            {
                case 0:
                    //�û�����
                    if (im != null)
                    {
                        im.StartPrivateChat(e.Cell.Items["lblUSER_ID"].Text, e.Cell.Items["lblUSER_ID"].Text);
                    }
                    break;
                case 1:
                    //Ⱥ������
                    if (im != null)
                    {
                        im.StartGroupChat(e.Cell.Items["lblGroupID"].Value.ToString (), e.Cell.Items["lblGroupID"].Text);
                    }
                    break;
            }
        }

        private void imageTabBar1_ItemClick(object sender, TabBarItemClickEventArgs e)
        {
            switch (imageTabBar1.SelectItemIndex)
            {
                case 2:
                    frmAddContact frm = new frmAddContact();
                    frm.im = im;
                    frm.isGroup = false;
                    frm.TitleText = "�����ϵ��";
                    this.Redirect(frm, (MobileForm sender1, object args) =>
                    {
                        imageTabBar1.SelectItemIndex = 0;
                        Bind();
                    });
                    break;

                case 3:
                    frmAddContact frm1 = new frmAddContact();
                    frm1.im = im;
                    frm1.isGroup = true;
                    frm1.TitleText = "���Ⱥ��";
                    this.Redirect(frm1, (MobileForm sender1, object args) =>
                    {
                        imageTabBar1.SelectItemIndex = 1;
                        Bind();
                    });
                    break;


                default:
                    Bind();
                    break;
            }
        }

        private void frmContacts_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "Work":
                    toolBarName = e.Name;
                    Close();
                    break;
                case "Mes":
                    im.StartConversationList();
                    break;
            }
        }
        /// <summary>
        /// ��������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmContacts_LeftLayoutItemClick(object sender, MobileFormLayoutItemEventArgs e)
        {
            ProcessLeftMenuFormName(e.CellItem.Name);
        }
        /// <summary>
        /// ����ί�з���
        /// </summary>
        /// <param name="leftLayoutActionName"></param>
        private void ProcessLeftMenuFormName(string leftLayoutActionName)
        {
            try
            {
                switch (leftLayoutActionName)
                {
                    case "":
                        this.Close();
                        break;
                    case "imginfo":
                    case "btninfo":
                        frmInfo frm = new frmInfo();
                        this.Redirect(frm, (MobileForm sender1, object args) => ProcessLeftMenuFormName(frm.LeftLayoutAction));
                        break;
                    case "imgtz":
                    case "btntz":
                        frmMessage frmMessage = new frmMessage();
                        this.Redirect(frmMessage, (MobileForm sender1, object args) => ProcessLeftMenuFormName(frmMessage.LeftLayoutAction));
                        break;
                    case "imgbz":
                    case "btnbz":
                        frmHelp frmHelp = new frmHelp();
                        this.Redirect(frmHelp, (MobileForm sender1, object args) => ProcessLeftMenuFormName(frmHelp.LeftLayoutAction));
                        break;
                    case "imgtc":
                    case "btnExit":
                        MessageBox.Show("�Ƿ�ȷ���˳�ϵͳ��", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                        {
                            if (args.Result == Smobiler.Core.ShowResult.Yes)
                            {
                                this.Close();
                            }
                        }
                     );
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmContacts_TitleImageClick(object sender, EventArgs e)
        {
            ShowSlider(Slider.Left);
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            InitialIM();
            Bind();
            imageTabBar1.SelectItemIndex = 0;
        }
    }
}