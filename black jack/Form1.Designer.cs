namespace black_jack
{
    partial class blackjack
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blackjack));
            this.more_card = new System.Windows.Forms.Button();
            this.useless001 = new System.Windows.Forms.PictureBox();
            this.opponents_cards = new System.Windows.Forms.Label();
            this.my_cards = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.useless001)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // more_card
            // 
            this.more_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.more_card.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.more_card.Location = new System.Drawing.Point(318, 322);
            this.more_card.Name = "more_card";
            this.more_card.Size = new System.Drawing.Size(136, 76);
            this.more_card.TabIndex = 0;
            this.more_card.Text = "发牌";
            this.more_card.UseVisualStyleBackColor = true;
            this.more_card.Click += new System.EventHandler(this.button1_Click);
            // 
            // useless001
            // 
            this.useless001.Image = global::black_jack.Properties.Resources.black_jack;
            this.useless001.Location = new System.Drawing.Point(650, 351);
            this.useless001.Name = "useless001";
            this.useless001.Size = new System.Drawing.Size(120, 112);
            this.useless001.TabIndex = 1;
            this.useless001.TabStop = false;
            // 
            // opponents_cards
            // 
            this.opponents_cards.AutoSize = true;
            this.opponents_cards.Location = new System.Drawing.Point(62, 64);
            this.opponents_cards.Name = "opponents_cards";
            this.opponents_cards.Size = new System.Drawing.Size(67, 15);
            this.opponents_cards.TabIndex = 2;
            this.opponents_cards.Text = "敌方卡牌";
            // 
            // my_cards
            // 
            this.my_cards.AutoSize = true;
            this.my_cards.Location = new System.Drawing.Point(62, 187);
            this.my_cards.Name = "my_cards";
            this.my_cards.Size = new System.Drawing.Size(67, 15);
            this.my_cards.TabIndex = 3;
            this.my_cards.Text = "我方卡牌";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(415, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(318, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(512, 120);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 475);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.my_cards);
            this.Controls.Add(this.opponents_cards);
            this.Controls.Add(this.useless001);
            this.Controls.Add(this.more_card);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "blackjack";
            this.Text = "Black Jack";
            ((System.ComponentModel.ISupportInitialize)(this.useless001)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button more_card;
        private System.Windows.Forms.PictureBox useless001;
        private System.Windows.Forms.Label opponents_cards;
        private System.Windows.Forms.Label my_cards;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

