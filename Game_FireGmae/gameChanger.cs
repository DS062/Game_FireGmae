using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_FireGmae
{
    public class gameChanger : FireTask
    {
        public void loadBtn(PictureBox pb) {
            pb.Image = Game_FireGmae.Properties.Resources.rotate_Gun1;
        }

        public void spinBtn(PictureBox pb)
        {
            pb.Image = Game_FireGmae.Properties.Resources.rot_gun2;
        }

        public void fireBtn(PictureBox pb)
        {
            pb.Image = Game_FireGmae.Properties.Resources.rot_gun6;
        }

        public void fireAwayBtn(PictureBox pb)
        {
            pb.Image = Game_FireGmae.Properties.Resources.roatate_gun3;
        }



    }
}
