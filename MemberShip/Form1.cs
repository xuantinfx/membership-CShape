using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberShip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReadRole readRole = new DefaultReadRole();
            UserMemberShipWithRole user = new UserMemberShipWithRole("tin", "123", readRole);

            bool read = user.allowRead(),
                create = user.allowCreate(),
                update = user.allowUpdate(),
                delete = user.allowDelete(),
                valid = user.validUser();
            
        }
    }
}
