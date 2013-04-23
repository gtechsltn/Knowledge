using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace StringOperation
{
    /// <summary>
    /// Index ��ժҪ˵����
    /// </summary>
    public partial class Index : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.Button Button13;
        protected System.Web.UI.WebControls.Button Button14;
        protected System.Web.UI.WebControls.Button Button15;
        protected System.Web.UI.WebControls.Button Button16;
        protected System.Web.UI.WebControls.Button Button17;
        protected System.Web.UI.WebControls.Button Button18;

        //protected StringOperation so = new StringOperation();

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
        }

        #region Web ������������ɵĴ���
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: �õ����� ASP.NET Web ���������������ġ�
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
        /// �˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {

        }
        #endregion

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.Encode(TextBox1.Text);
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.Decode(TextBox1.Text);
        }

        protected void Button3_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.Encrypt(TextBox1.Text);
        }

        protected void Button4_Click(object sender, System.EventArgs e)
        {





            TextBox1.Text = StringOperation.Encrypt(TextBox1.Text, 0);
        }

        protected void Button5_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.Encrypt(TextBox1.Text, 1);
        }

        protected void Button6_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.Decrypt(TextBox1.Text);
        }

        protected void Button7_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.DeTransform1(TextBox1.Text);
        }

        protected void Button8_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.Transform1(TextBox1.Text);
        }

        protected void Button10_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.DeTransform3(TextBox1.Text);
        }

        protected void Button11_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.Transform3(TextBox1.Text);
        }

        protected void Button12_Click(object sender, System.EventArgs e)
        {
            TextBox1.Text = StringOperation.Reverse(TextBox1.Text);
        }
    }
}
