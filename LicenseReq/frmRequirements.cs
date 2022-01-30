using System;
using System.Text;
using System.Windows.Forms;

namespace LicenseReq
{
    public partial class frmRequirements : Form
    {
        public frmRequirements()
        {
            InitializeComponent();
        }

        private void GetInfo()
        {

            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("HARDWARE ID = " + License.Status.GetHardwareID(true,true,true,true));


            stringBuilder.AppendLine();


            if (License.Status.Licensed)
            {
                for (int i = 0; i < License.Status.KeyValueList.Count; i++)
                {
                    stringBuilder.AppendLine("   License key: " + License.Status.KeyValueList.GetKey(i).ToString() + "; Value: " + License.Status.KeyValueList.GetByIndex(i).ToString());
                }
            }

            this.textBox1.Text = stringBuilder.ToString();
           
        }


        private void frmRequirements_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            GetInfo();
        }
    }
}
