using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using black_jack.Properties;
2323232
namespace black_jack
{
    public partial class blackjack : Form
    {
        public blackjack()
        {
            InitializeComponent();
        }
        int sum=0;
        string cards = "";
        public void button1_Click(object sender, EventArgs e)
        {
            Random randomcard=new Random();
            int card=randomcard.Next(13);
            string card_picture_name="c"+card;
                //"c"+handle_with_cards.change_card_into_name(card);
            pictureBox1.Image = Resources.ResourceManager.GetObject(card_picture_name);
                
            sum += handle_with_cards.count_the_number(card);
            cards+=" "+handle_with_cards.change_card_into_name(card);
            opponents_cards.Text = "总和为" + sum+"     "+cards;
        }
    }
}
