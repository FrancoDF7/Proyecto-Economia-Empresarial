using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaSoporte.Extras
{
    public class ClaseMoverForm
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void MoverForm(IntPtr intPtr)
        {
            ReleaseCapture();
            SendMessage(intPtr, 0x112, 0xf012, 0);
        }

    }
}
