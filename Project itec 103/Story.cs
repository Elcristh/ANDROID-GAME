using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Project_itec_103
{
    public partial class Story : Form
    {
        public Story()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dialouge = {"Narration \n It was cold weather for the day, the wind was blowing and people were bustling around the quiet town.",
                                 "MC \n So cold… Thank goodness I got the newest chapter update to keep me company today.",
                                 "Narration \n The girl holds her phone looking at the latest novel that she was reading. She smiles, looking at the art book of the cover title \n The Witch of Dawn.",
                                 "A story about a wandering witch charming everyone and having the grandest adventures one could have. Getting glory, helping people, and overcoming her rivalry with the famed most powerful fairy there was[The Fairy Queen]. ",
                                 "MC  \n  I can’t wait for the chapter today! It’s almost the witch’s and fairy’s dispute with one another being fixed by a simple favor!",
                                 "Narration  \n  A fairy duel, challenging the Queen herself would be suicidal! ",
                                 "MC  \n  A few more left… why did they have to leave it into the climax where the witch was about to have the finishing blow-?! Now I have to wait for another week and see what’s going to happen by then?",
                                 "Narration  \n  To conduct a fairy duel, whoever wins will have the loser conduct a favor that they can’t refuse. It gave the girl excitement, waiting for the new chapter of the book and decided to leave a comment while crossing the road.",
                                 "MC  \n  Props to the author and visual artist… Can’t wait for the next chapter to update… Props to the author for working so hard…",
                                 "Narration \n However, a sudden tragic accident has killed the MC leaving her in a horrible state but her soul has resided elsewhere."     };
            int i = Array.IndexOf(dialouge, label1.Text);
            if (i >= 0 && i <= 8)
            {
                label1.Text = dialouge[i + 1];
            }
            else
            {
                label1.Text = dialouge[0];
                if (i >= 9)
                {
                    this.Close();
                    Chapterone form = new Chapterone();
                    form.Show();
                }
            }
        }

        private void Story_Load(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\storyline.wav");
            splayer.Play();
        }
    }
}
