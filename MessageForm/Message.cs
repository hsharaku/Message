using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message
{
    public partial class MessageForm : Form
    {
        /// <summary>
        /// オプションの確認
        /// </summary>
        /// <param name="args">引数の配列</param>
        /// <param name="option">オプションの文字列</param>
        /// <returns>引数が存在するインデックス</returns>
        int findOption(string[] args, string option)
        {
            for (int i = 0; i < args.Length; i++)
            {
                // 文字列を小文字にする
                if (args[i].ToLower() == option.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        public MessageForm(string[] args)
        {
            InitializeComponent();
            int _idx = 0;
            this.Text = args[0];
            lb_message.Text = args[1].Replace("\\r\\n", "\r\n");

            // フォントサイズの変更
            _idx = findOption(args, "/fs");
            if (_idx != -1)
            {
                Font _f = new Font(lb_message.Font.FontFamily, int.Parse(args[_idx + 1]));
                lb_message.Font = _f;
            }

            // フォントカラーの変更
            _idx = findOption(args, "/fc");
            if (_idx != -1)
            {
                lb_message.ForeColor = Color.FromName(args[_idx + 1]);
            }

            // 背景色の変更
            _idx = findOption(args, "/bc");
            if (_idx != -1)
            {
                this.BackColor = Color.FromName(args[_idx + 1]);
            }
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
