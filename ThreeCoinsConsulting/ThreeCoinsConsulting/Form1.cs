using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using YiJingFramework.Casting.ThreeCoins;
using YiJingFramework.Painting.Presenting;
using YiJingFramework.References.Zhouyi;

namespace ThreeCoinsConsulting
{
    public partial class Form1 : Form
    {
        private readonly int positionOfLabelChanged;
        private readonly int positionOfLabelOriginal;
        public Form1()
        {
            this.InitializeComponent();

            this.positionOfLabelChanged = 
                this.labelChangedPainting.Location.Y + this.labelChangedPainting.Size.Height;
            this.positionOfLabelOriginal =
                this.labelOriginalPainting.Location.Y + this.labelOriginalPainting.Size.Height;

            Random random = new Random();
            var coin1 = new Coin(new Random(random.Next()));
            var coin2 = new Coin(new Random(random.Next()));
            var coin3 = new Coin(new Random(random.Next()));

            this.pictureBoxCoin1.Tag = coin1;
            this.pictureBoxCoin2.Tag = coin2;
            this.pictureBoxCoin3.Tag = coin3;

            this.threeCoins = new ThreeCoins(null, coin1, coin2, coin3);
            this.Restart();
        }

        readonly ThreeCoins threeCoins;
        IPaper? paper;

        private void Restart(object? sender = null, EventArgs? e = null)
        {
            paper = new Paper();
            this.threeCoins.Paper = paper;
            this.textBoxResult.Text = string.Empty;
            this.textBoxResult2.Text = string.Empty;
            this.textBoxResult.Enabled = false;
            this.textBoxResult2.Enabled = false;
            this.buttonRecord.Enabled = true;
            this.buttonTossAll.Enabled = true;
            this.labelChangedPainting.Text = string.Empty;
            this.labelOriginalPainting.Text = string.Empty;

            this.labelChangedPainting.Location =
                new Point(this.labelChangedPainting.Location.X,
                this.positionOfLabelChanged - this.labelChangedPainting.Height);
            this.labelOriginalPainting.Location =
                new Point(this.labelOriginalPainting.Location.X,
                this.positionOfLabelOriginal - this.labelOriginalPainting.Height);

            this.TossAll();
        }

        private void TossAll(object? sender = null, EventArgs? e = null)
        {
            this.Toss(this.pictureBoxCoin1);
            this.Toss(this.pictureBoxCoin2);
            this.Toss(this.pictureBoxCoin3);
        }

        private void Toss(object sender, EventArgs? e = null)
        {
            Debug.Assert(sender is PictureBox);
            var pictureBox = (PictureBox)sender;

            Debug.Assert(pictureBox.Tag is ICoin);
            ICoin coin = (ICoin)pictureBox.Tag;

            var isYangSideUp = coin.Toss();
            pictureBox.BackColor = isYangSideUp ? Color.White : Color.Black;
        }

        private readonly IConverterTo<string> converter =
            new YiJingFramework.Painting.Presenting.StringConverter();
        private void Record(object? sender = null, EventArgs? e = null)
        {
            this.threeCoins.CheckAndDraw();
            if (this.paper is null)
                return;
            var paintings = this.paper.GetPaintings();
            this.labelOriginalPainting.Text = converter.ConvertTo(paintings.Original);
            this.labelChangedPainting.Text = converter.ConvertTo(paintings.Changed);

            this.labelChangedPainting.Location =
                new Point(this.labelChangedPainting.Location.X,
                this.positionOfLabelChanged - this.labelChangedPainting.Height);
            this.labelOriginalPainting.Location =
                new Point(this.labelOriginalPainting.Location.X,
                this.positionOfLabelOriginal - this.labelOriginalPainting.Height);

            if (paintings.Original.Count is 6)
                this.StopAndShowResult();
        }

        private readonly Zhouyi zhouyi =
            new Zhouyi("zhouyi.json");
        private void StopAndShowResult()
        {
            if (this.paper is null)
                return;
            var paintings = this.paper.GetPaintings();
            Debug.Assert(paintings.Original.Count is 6);
            Debug.Assert(paintings.Changed.Count is 6);

            var original = zhouyi.GetHexagram(paintings.Original);
            var changed = zhouyi.GetHexagram(paintings.Changed);

            this.textBoxResult.Text = original.ToString();
            this.textBoxResult2.Text = changed.ToString();
            this.textBoxResult.Enabled = true;
            this.textBoxResult2.Enabled = true;
            this.buttonRecord.Enabled = false;
            this.buttonTossAll.Enabled = false;
        }
    }
}
