using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 그리드 뷰에 필요한것들 http://m.blog.daum.net/jabapos/16819171?tp_nil_a=2 여기서보기
/// </summary>
namespace Pos
{
    public partial class frmSalesinquiry : Form,ISearch,IDelete,IAlter
    {
        public frmSalesinquiry()
        {
            InitializeComponent();
        }


    }
}
