using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace network_final_project_client
{
    public static class MsgBoxHelper
    {
        public static DialogResult Warn(string s, MessageBoxButtons buttons = MessageBoxButtons.OK, params object[] args)
        {
            return MessageBox.Show(f(s, args), "경고", buttons, MessageBoxIcon.Exclamation);
        }

        public static DialogResult Error(string s, MessageBoxButtons buttons = MessageBoxButtons.OK, params object[] args)
        {
            return MessageBox.Show(f(s, args), "오류", buttons, MessageBoxIcon.Error);
        }

        public static DialogResult Info(string s,
MessageBoxButtons buttons = MessageBoxButtons.OK,
params object[] args)
        {
            return MessageBox.Show(f(s, args), "알림", buttons,
            MessageBoxIcon.Information);
        }
        public static DialogResult Show(string s,
        MessageBoxButtons buttons = MessageBoxButtons.OK,
        params object[] args)
        {
            return MessageBox.Show(f(s, args), "알림", buttons, 0);
        }

        static string f(string s, params object[] args)
        {
            if (args == null) return s;
            return string.Format(s, args);
        }
    }
}
