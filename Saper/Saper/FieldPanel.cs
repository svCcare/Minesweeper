using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class FieldPanel : UserControl
    {
        public int FieldStatus { get; set; }
        public int FieldValue { get; set; }
        public Point Coordinates { get; set; }
        private MainForm mainForm;

        public FieldPanel(MainForm parent)
        {
            InitializeComponent();
            this.mainForm = parent;
            FieldStatus = (int)Static.MinesweeperEnum.FieldStatus.Unknown;
            this.pictureBox1.Image = Static.ImageHelper.GetImageByID(FieldStatus);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right) SetFlag();
            else RevealField();
        }

        public void RevealField()
        {
            if (this.FieldStatus == (int)Static.MinesweeperEnum.FieldStatus.Unknown)
            {

                if (this.FieldValue == (int)Static.MinesweeperEnum.FieldStatus.Mine)
                {
                    this.pictureBox1.Image = Static.ImageHelper.GetImageByID(FieldValue);
                    MessageBox.Show("You lost");
                }
                else
                {
                    this.FieldStatus = this.FieldValue;
                    int bombsAround = mainForm.CheckConnectedFields(this.Coordinates);
                    if (bombsAround > 5) bombsAround = 5;

                    this.pictureBox1.Image = bombsAround == 0 ? this.pictureBox1.Image = Static.ImageHelper.GetImageByID(FieldValue) : this.pictureBox1.Image = Static.ImageHelper.GetImageByID(bombsAround + 3);

                }

            }
        }

        private void SetFlag()
        {
            if (this.FieldStatus == (int)Static.MinesweeperEnum.FieldStatus.Flag)
            {
                Static.StaticMain.FlagsQuntity++;
                Static.StaticMain.BombQuantity++;
                this.FieldStatus = (int)Static.MinesweeperEnum.FieldStatus.Unknown;
                this.pictureBox1.Image = Static.ImageHelper.GetImageByID((int)Static.MinesweeperEnum.FieldStatus.Unknown);
            }
            else if (this.FieldStatus == (int)Static.MinesweeperEnum.FieldStatus.Unknown)
            {
                Static.StaticMain.FlagsQuntity--;
                Static.StaticMain.BombQuantity--;
                this.FieldStatus = (int)Static.MinesweeperEnum.FieldStatus.Flag;
                this.pictureBox1.Image = Static.ImageHelper.GetImageByID((int)Static.MinesweeperEnum.FieldStatus.Flag);
                mainForm.CheckIfEveryBombIsTagged();
            }
            mainForm.SetLabels();
        }
    }
}
