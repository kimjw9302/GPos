using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmMail : Form
    {

        string title = null;
        string msg = null;
        string email = null;

        public frmMail()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //메일 제목, 메일 내용
            title = tboxTitle.Text;
            msg = tboxTitle.Text;
            if (Check())         //유효성검사
            {
                try
                {
                    email = tboxID.Text + "@" + cboxEmail.SelectedItem;
                    //메일전송
                    MailAddress fromAddr = new MailAddress("rlawodnd9302@naver.com", email, Encoding.UTF8);
                    MailAddress toAddr = new MailAddress("rlawodnd9302@naver.com");
                    SmtpClient client = new SmtpClient("smtp.naver.com", 587);

                    MailMessage sendmsg = new MailMessage(fromAddr, toAddr);

                    sendmsg.Subject = title;
                    sendmsg.Body = msg;
                    sendmsg.SubjectEncoding = sendmsg.BodyEncoding = Encoding.UTF8;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new NetworkCredential("rlawodnd9302@naver.com", "sa450!@!@");
                    client.Send(sendmsg);
                    this.Visible = false;
                    MessageBox.Show("관리자에게 메일이 전송 되었습니다");
                    this.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("연결에러");
                    this.Dispose();
                }
            }
        }
        public bool Check()
        {
            if (title == "" || title == null)
            {
                MessageBox.Show("제목을 입력해주세요");
                return false;
            }
            else if (!cboxEmail.Visible)
            {
                if (tboxInput.Text=="")
                {
                    MessageBox.Show("이메일을 입력해주세요");
                    return false;
                }

            }
            else if (tboxID.Text == "")
            {
                MessageBox.Show("이메일을 입력해주세요");
                return false;
            }
            else if (cboxEmail.SelectedIndex==-1)
            {
                MessageBox.Show("이메일을 입력해주세요");
                return false;
            }
            return true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxEmail.SelectedIndex == 0)
            {
                this.cboxEmail.Visible = false;
                tboxInput.Focus();

            }
        }

        private void frmMail_Load(object sender, EventArgs e)
        {

        }
    }
}
