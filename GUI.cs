using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intel8086;

namespace Intel8086
{
    public partial class Intel8086 : Form
    {
    public enum LowerKeys
    {
        a = 'a',
        b = 'b',
        c = 'c',
        d = 'd',
        e = 'e',
        f = 'f'
    }
        public Intel8086()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void AHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.A && e.KeyChar != (char)Keys.B && e.KeyChar != (char)Keys.C && e.KeyChar != (char)Keys.D && e.KeyChar != (char)Keys.E && e.KeyChar != (char)Keys.F && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)LowerKeys.a && e.KeyChar != (char)LowerKeys.b && e.KeyChar != (char)LowerKeys.c && e.KeyChar != (char)LowerKeys.d && e.KeyChar != (char)LowerKeys.e && e.KeyChar != (char)LowerKeys.f && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AHTextBox_TextChanged(object sender, EventArgs e)
        {
            AHTextBox.MaxLength = 2;
        }

        private void ALTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.A && e.KeyChar != (char)Keys.B && e.KeyChar != (char)Keys.C && e.KeyChar != (char)Keys.D && e.KeyChar != (char)Keys.E && e.KeyChar != (char)Keys.F && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)LowerKeys.a && e.KeyChar != (char)LowerKeys.b && e.KeyChar != (char)LowerKeys.c && e.KeyChar != (char)LowerKeys.d && e.KeyChar != (char)LowerKeys.e && e.KeyChar != (char)LowerKeys.f && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ALTextBox_TextChanged(object sender, EventArgs e)
        {
            ALTextBox.MaxLength = 2;
        }
        private void BHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.A && e.KeyChar != (char)Keys.B && e.KeyChar != (char)Keys.C && e.KeyChar != (char)Keys.D && e.KeyChar != (char)Keys.E && e.KeyChar != (char)Keys.F && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)LowerKeys.a && e.KeyChar != (char)LowerKeys.b && e.KeyChar != (char)LowerKeys.c && e.KeyChar != (char)LowerKeys.d && e.KeyChar != (char)LowerKeys.e && e.KeyChar != (char)LowerKeys.f && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void BHTextBox_TextChanged(object sender, EventArgs e)
        {
            BHTextBox.MaxLength = 2;
        }
        private void BLTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.A && e.KeyChar != (char)Keys.B && e.KeyChar != (char)Keys.C && e.KeyChar != (char)Keys.D && e.KeyChar != (char)Keys.E && e.KeyChar != (char)Keys.F && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)LowerKeys.a && e.KeyChar != (char)LowerKeys.b && e.KeyChar != (char)LowerKeys.c && e.KeyChar != (char)LowerKeys.d && e.KeyChar != (char)LowerKeys.e && e.KeyChar != (char)LowerKeys.f && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void BLTextBox_TextChanged(object sender, EventArgs e)
        {
            BLTextBox.MaxLength = 2;
        }
        private void CHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.A && e.KeyChar != (char)Keys.B && e.KeyChar != (char)Keys.C && e.KeyChar != (char)Keys.D && e.KeyChar != (char)Keys.E && e.KeyChar != (char)Keys.F && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)LowerKeys.a && e.KeyChar != (char)LowerKeys.b && e.KeyChar != (char)LowerKeys.c && e.KeyChar != (char)LowerKeys.d && e.KeyChar != (char)LowerKeys.e && e.KeyChar != (char)LowerKeys.f && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CHTextBox_TextChanged(object sender, EventArgs e)
        {
            CHTextBox.MaxLength = 2;
        }
        private void CLTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.A && e.KeyChar != (char)Keys.B && e.KeyChar != (char)Keys.C && e.KeyChar != (char)Keys.D && e.KeyChar != (char)Keys.E && e.KeyChar != (char)Keys.F && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)LowerKeys.a && e.KeyChar != (char)LowerKeys.b && e.KeyChar != (char)LowerKeys.c && e.KeyChar != (char)LowerKeys.d && e.KeyChar != (char)LowerKeys.e && e.KeyChar != (char)LowerKeys.f && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CLTextBox_TextChanged(object sender, EventArgs e)
        {
            CLTextBox.MaxLength = 2;
        }
        private void DHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.A && e.KeyChar != (char)Keys.B && e.KeyChar != (char)Keys.C && e.KeyChar != (char)Keys.D && e.KeyChar != (char)Keys.E && e.KeyChar != (char)Keys.F && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)LowerKeys.a && e.KeyChar != (char)LowerKeys.b && e.KeyChar != (char)LowerKeys.c && e.KeyChar != (char)LowerKeys.d && e.KeyChar != (char)LowerKeys.e && e.KeyChar != (char)LowerKeys.f && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void DHTextBox_TextChanged(object sender, EventArgs e)
        {
            DHTextBox.MaxLength = 2;
        }
        private void DLTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.A && e.KeyChar != (char)Keys.B && e.KeyChar != (char)Keys.C && e.KeyChar != (char)Keys.D && e.KeyChar != (char)Keys.E && e.KeyChar != (char)Keys.F && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)LowerKeys.a && e.KeyChar != (char)LowerKeys.b && e.KeyChar != (char)LowerKeys.c && e.KeyChar != (char)LowerKeys.d && e.KeyChar != (char)LowerKeys.e && e.KeyChar != (char)LowerKeys.f && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void DLTextBox_TextChanged(object sender, EventArgs e)
        {
            DLTextBox.MaxLength = 2;
        }
        private void Xchange_Click(object sender, EventArgs e)
        {
            string temp1;
            string temp2;
            if (ComboBoxTo.SelectedIndex == 0)
            {
                //AX
                temp1 = AHTextBox.Text;
                temp2 = ALTextBox.Text;
                if (ComboBoxFrom.SelectedIndex != 3 && ComboBoxFrom.SelectedIndex != 6 && ComboBoxFrom.SelectedIndex != 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 3)
                {
                    AHTextBox.Text = BHTextBox.Text;
                    ALTextBox.Text = BLTextBox.Text;
                    BHTextBox.Text = temp1;
                    BLTextBox.Text = temp2;
                }
                else if (ComboBoxFrom.SelectedIndex == 6)
                {
                    AHTextBox.Text = CHTextBox.Text;
                    ALTextBox.Text = CLTextBox.Text;
                    CHTextBox.Text = temp1;
                    CLTextBox.Text = temp2;
                }
                else if (ComboBoxFrom.SelectedIndex == 9)
                {
                    AHTextBox.Text = DHTextBox.Text;
                    ALTextBox.Text = DLTextBox.Text;
                    DHTextBox.Text = temp1;
                    DLTextBox.Text = temp2;
                }
            }
            if (ComboBoxTo.SelectedIndex == 1)
            {
                //AH
                temp1 = AHTextBox.Text;
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 1 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    AHTextBox.Text = ALTextBox.Text;
                    ALTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    AHTextBox.Text = BHTextBox.Text;
                    BHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    AHTextBox.Text = BLTextBox.Text;
                    BLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    AHTextBox.Text = CHTextBox.Text;
                    CHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    AHTextBox.Text = CLTextBox.Text;
                    CLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    AHTextBox.Text = DHTextBox.Text;
                    DHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    AHTextBox.Text = DLTextBox.Text;
                    DLTextBox.Text = temp1;
                }

            }
            if (ComboBoxTo.SelectedIndex == 2)
            {
                //AL
                temp1 = ALTextBox.Text;
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 2 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    ALTextBox.Text = AHTextBox.Text;
                    AHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    ALTextBox.Text = BHTextBox.Text;
                    BHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    ALTextBox.Text = BLTextBox.Text;
                    BLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    ALTextBox.Text = CHTextBox.Text;
                    CHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    ALTextBox.Text = CLTextBox.Text;
                    CLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    ALTextBox.Text = DHTextBox.Text;
                    DHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    ALTextBox.Text = DLTextBox.Text;
                    DLTextBox.Text = temp1;
                }
            }
            if (ComboBoxTo.SelectedIndex == 3)
            {
                //BX
                temp1 = BHTextBox.Text;
                temp2 = BLTextBox.Text;
                if (ComboBoxFrom.SelectedIndex != 0 && ComboBoxFrom.SelectedIndex != 6 && ComboBoxFrom.SelectedIndex != 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 0)
                {
                    BHTextBox.Text = AHTextBox.Text;
                    BLTextBox.Text = ALTextBox.Text;
                    AHTextBox.Text = temp1;
                    ALTextBox.Text = temp2;
                }
                else if (ComboBoxFrom.SelectedIndex == 6)
                {
                    BHTextBox.Text = CHTextBox.Text;
                    BLTextBox.Text = CLTextBox.Text;
                    CHTextBox.Text = temp1;
                    CLTextBox.Text = temp2;
                }
                else if (ComboBoxFrom.SelectedIndex == 9)
                {
                    BHTextBox.Text = DHTextBox.Text;
                    BLTextBox.Text = DLTextBox.Text;
                    DHTextBox.Text = temp1;
                    DLTextBox.Text = temp2;
                }
            }
            if (ComboBoxTo.SelectedIndex == 4)
            {
                //BH
                temp1 = BHTextBox.Text;
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 4 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    BHTextBox.Text = AHTextBox.Text;
                    AHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    BHTextBox.Text = ALTextBox.Text;
                    ALTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    BHTextBox.Text = BLTextBox.Text;
                    BLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    BHTextBox.Text = CHTextBox.Text;
                    CHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    BHTextBox.Text = CLTextBox.Text;
                    CLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    BHTextBox.Text = DHTextBox.Text;
                    DHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    BHTextBox.Text = DLTextBox.Text;
                    DLTextBox.Text = temp1;
                }
            }
            if (ComboBoxTo.SelectedIndex == 5)
            {
                //BL
                temp1 = BLTextBox.Text;
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 5 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    BLTextBox.Text = AHTextBox.Text;
                    AHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    BLTextBox.Text = ALTextBox.Text;
                    ALTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    BLTextBox.Text = BHTextBox.Text;
                    BHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    BLTextBox.Text = CHTextBox.Text;
                    CHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    BLTextBox.Text = CLTextBox.Text;
                    CLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    BLTextBox.Text = DHTextBox.Text;
                    DHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    BLTextBox.Text = DLTextBox.Text;
                    DLTextBox.Text = temp1;
                }
            }
            if (ComboBoxTo.SelectedIndex == 6)
            {
                //CX
                temp1 = CHTextBox.Text;
                temp2 = CLTextBox.Text;
                if (ComboBoxFrom.SelectedIndex != 0 && ComboBoxFrom.SelectedIndex != 3 && ComboBoxFrom.SelectedIndex != 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 0)
                {
                    CHTextBox.Text = AHTextBox.Text;
                    CLTextBox.Text = ALTextBox.Text;
                    AHTextBox.Text = temp1;
                    ALTextBox.Text = temp2;
                }
                else if (ComboBoxFrom.SelectedIndex == 3)
                {
                    CHTextBox.Text = BHTextBox.Text;
                    CLTextBox.Text = BLTextBox.Text;
                    BHTextBox.Text = temp1;
                    BLTextBox.Text = temp2;
                }
                else if (ComboBoxFrom.SelectedIndex == 9)
                {
                    CHTextBox.Text = DHTextBox.Text;
                    CLTextBox.Text = DLTextBox.Text;
                    DHTextBox.Text = temp1;
                    DLTextBox.Text = temp2;
                }
            }
            if (ComboBoxTo.SelectedIndex == 7)
            {
                //CH
                temp1 = CHTextBox.Text;
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 7 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    CHTextBox.Text = AHTextBox.Text;
                    AHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    CHTextBox.Text = ALTextBox.Text;
                    ALTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    CHTextBox.Text = BHTextBox.Text;
                    BHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    CHTextBox.Text = BLTextBox.Text;
                    BLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    CHTextBox.Text = CLTextBox.Text;
                    CLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    CHTextBox.Text = DHTextBox.Text;
                    DHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    CHTextBox.Text = DLTextBox.Text;
                    DLTextBox.Text = temp1;
                }
            }
            if (ComboBoxTo.SelectedIndex == 8)
            {
                //CL
                temp1 = CLTextBox.Text;
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 8 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    CLTextBox.Text = AHTextBox.Text;
                    AHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    CLTextBox.Text = ALTextBox.Text;
                    ALTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    CLTextBox.Text = BHTextBox.Text;
                    BHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    CLTextBox.Text = BLTextBox.Text;
                    BLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    CLTextBox.Text = CHTextBox.Text;
                    CHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    CLTextBox.Text = DHTextBox.Text;
                    DHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    CLTextBox.Text = DLTextBox.Text;
                    DLTextBox.Text = temp1;
                }
            }
            if (ComboBoxTo.SelectedIndex == 9)
            {
                //DX
                temp1 = DHTextBox.Text;
                temp2 = DLTextBox.Text;
                if (ComboBoxFrom.SelectedIndex != 0 && ComboBoxFrom.SelectedIndex != 3 && ComboBoxFrom.SelectedIndex != 6)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 0)
                {
                    DHTextBox.Text = AHTextBox.Text;
                    DLTextBox.Text = ALTextBox.Text;
                    AHTextBox.Text = temp1;
                    ALTextBox.Text = temp2;
                }
                else if (ComboBoxFrom.SelectedIndex == 3)
                {
                    DHTextBox.Text = BHTextBox.Text;
                    DLTextBox.Text = BLTextBox.Text;
                    BHTextBox.Text = temp1;
                    BLTextBox.Text = temp2;
                }
                else if (ComboBoxFrom.SelectedIndex == 6)
                {
                    DHTextBox.Text = CHTextBox.Text;
                    DLTextBox.Text = CLTextBox.Text;
                    CHTextBox.Text = temp1;
                    CLTextBox.Text = temp2;
                }
            }
            if (ComboBoxTo.SelectedIndex == 10)
            {
                //DH
                temp1 = DHTextBox.Text;
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9 || ComboBoxFrom.SelectedIndex == 10)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    DHTextBox.Text = AHTextBox.Text;
                    AHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    DHTextBox.Text = ALTextBox.Text;
                    ALTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    DHTextBox.Text = BHTextBox.Text;
                    BHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    DHTextBox.Text = BLTextBox.Text;
                    BLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    DHTextBox.Text = CHTextBox.Text;
                    CHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    DHTextBox.Text = CLTextBox.Text;
                    CLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    DHTextBox.Text = DLTextBox.Text;
                    DLTextBox.Text = temp1;
                }
            }
            if (ComboBoxTo.SelectedIndex == 11)
            {
                //DL
                temp1 = DLTextBox.Text;
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9 || ComboBoxFrom.SelectedIndex == 11)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    DLTextBox.Text = AHTextBox.Text;
                    AHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    DLTextBox.Text = ALTextBox.Text;
                    ALTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    DLTextBox.Text = BHTextBox.Text;
                    BHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    DLTextBox.Text = BLTextBox.Text;
                    BLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    DLTextBox.Text = CHTextBox.Text;
                    CHTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    DLTextBox.Text = CLTextBox.Text;
                    CLTextBox.Text = temp1;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    DLTextBox.Text = DHTextBox.Text;
                    DHTextBox.Text = temp1;
                }
            }
        }

        private void Mov_Click(object sender, EventArgs e)
        {
            if (ComboBoxTo.SelectedIndex == 0)
            {
                //AX
                if (ComboBoxFrom.SelectedIndex != 3 && ComboBoxFrom.SelectedIndex != 6 && ComboBoxFrom.SelectedIndex != 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 3)
                {
                    AHTextBox.Text = BHTextBox.Text;
                    ALTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 6)
                {
                    AHTextBox.Text = CHTextBox.Text;
                    ALTextBox.Text = CLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 9)
                {
                    AHTextBox.Text = DHTextBox.Text;
                    ALTextBox.Text = DLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 1)
            {
                //AH
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 1 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    AHTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    AHTextBox.Text = BHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    AHTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    AHTextBox.Text = CHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    AHTextBox.Text = CLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    AHTextBox.Text = DHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    AHTextBox.Text = DLTextBox.Text;
                }

            }
            if (ComboBoxTo.SelectedIndex == 2)
            {
                //AL
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 2 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    ALTextBox.Text = AHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    ALTextBox.Text = BHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    ALTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    ALTextBox.Text = CHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    ALTextBox.Text = CLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    ALTextBox.Text = DHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    ALTextBox.Text = DLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 3)
            {
                //BX
                if (ComboBoxFrom.SelectedIndex != 0 && ComboBoxFrom.SelectedIndex != 6 && ComboBoxFrom.SelectedIndex != 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 0)
                {
                    BHTextBox.Text = AHTextBox.Text;
                    BLTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 6)
                {
                    BHTextBox.Text = CHTextBox.Text;
                    BLTextBox.Text = CLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 9)
                {
                    BHTextBox.Text = DHTextBox.Text;
                    BLTextBox.Text = DLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 4)
            {
                //BH
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 4 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    BHTextBox.Text = AHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    BHTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    BHTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    BHTextBox.Text = CHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    BHTextBox.Text = CLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    BHTextBox.Text = DHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    BHTextBox.Text = DLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 5)
            {
                //BL
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 5 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    BLTextBox.Text = AHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    BLTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    BLTextBox.Text = BHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    BLTextBox.Text = CHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    BLTextBox.Text = CLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    BLTextBox.Text = DHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    BLTextBox.Text = DLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 6)
            {
                //CX
                if (ComboBoxFrom.SelectedIndex != 0 && ComboBoxFrom.SelectedIndex != 3 && ComboBoxFrom.SelectedIndex != 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 0)
                {
                    CHTextBox.Text = AHTextBox.Text;
                    CLTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 3)
                {
                    CHTextBox.Text = BHTextBox.Text;
                    CLTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 9)
                {
                    CHTextBox.Text = DHTextBox.Text;
                    CLTextBox.Text = DLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 7)
            {
                //CH
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 7 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    CHTextBox.Text = AHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    CHTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    CHTextBox.Text = BHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    CHTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    CHTextBox.Text = CLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    CHTextBox.Text = DHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    CHTextBox.Text = DLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 8)
            {
                //CL
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 8 || ComboBoxFrom.SelectedIndex == 9)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    CLTextBox.Text = AHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    CLTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    CLTextBox.Text = BHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    CLTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    CLTextBox.Text = CHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    CLTextBox.Text = DHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    CLTextBox.Text = DLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 9)
            {
                //DX
                if (ComboBoxFrom.SelectedIndex != 0 && ComboBoxFrom.SelectedIndex != 3 && ComboBoxFrom.SelectedIndex != 6)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 0)
                {
                    DHTextBox.Text = AHTextBox.Text;
                    DLTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 3)
                {
                    DHTextBox.Text = BHTextBox.Text;
                    DLTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 6)
                {
                    DHTextBox.Text = CHTextBox.Text;
                    DLTextBox.Text = CLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 10)
            {
                //DH
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9 || ComboBoxFrom.SelectedIndex == 10)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    DHTextBox.Text = AHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    DHTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    DHTextBox.Text = BHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    DHTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    DHTextBox.Text = CHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    DHTextBox.Text = CLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 11)
                {
                    DHTextBox.Text = DLTextBox.Text;
                }
            }
            if (ComboBoxTo.SelectedIndex == 11)
            {
                //DL
                if (ComboBoxFrom.SelectedIndex == 0 || ComboBoxFrom.SelectedIndex == 3 || ComboBoxFrom.SelectedIndex == 6 || ComboBoxFrom.SelectedIndex == 9 || ComboBoxFrom.SelectedIndex == 11)
                {
                    MessageBox.Show("Nie można wykonać tej instrukcji");
                }
                else if (ComboBoxFrom.SelectedIndex == 1)
                {
                    DLTextBox.Text = AHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 2)
                {
                    DLTextBox.Text = ALTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 4)
                {
                    DLTextBox.Text = BHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 5)
                {
                    DLTextBox.Text = BLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 7)
                {
                    DLTextBox.Text = CHTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 8)
                {
                    DLTextBox.Text = CLTextBox.Text;
                }
                else if (ComboBoxFrom.SelectedIndex == 10)
                {
                    DLTextBox.Text = DHTextBox.Text;
                }
            }
        }
    }
}