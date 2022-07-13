using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timezone_Plus
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            if (txtJson.Text.Contains("cvvToken"))
            {
                JObject json = JObject.Parse(txtJson.Text);
                json["details"]["cvvToken"] = string.Empty;
                txtJson.Text = JsonConvert.SerializeObject(json);
                Clipboard.SetText(txtJson.Text);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtJson.Clear();
        }
    }
}
