using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetSimu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 300;
        }

        private Random Randomizer
        {
            get
            {
                if (null == this._Randomizer)
                {
                    this._Randomizer = new Random(Environment.TickCount);
                }
                return this._Randomizer;
            }
        }
        private Random _Randomizer;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            BetGameSimulator bgs = new BetGameSimulator(this.Randomizer);
            bgs.Start = this.nudStartValue.Value;
            bgs.BetLimit = this.nudLimit.Value;

            //勝つ、または掛け金上限まで倍プッシュするゲームをN回行う(上限額を設けたマーチンゲール法)
            bgs.TryMartingale(this.nudTryTime.Value);

            this.lblTotal.Text = string.Format("{0}", bgs.TotalBet);
            this.lblGet.Text = string.Format("{0}", bgs.TotalGet);
            this.lblRate.Text = string.Format("{0:N2}%", bgs.Rate);

            this.grdResult.DataSource = bgs.GameLogs;
        }

        private void btnLogToggle_Click(object sender, EventArgs e)
        {
            if (this.Width.Equals(300))
            {
                this.Width = 1000;
                this.btnLogToggle.Text = "経過非表示";
            }
            else
            {
                this.Width = 300;
                this.btnLogToggle.Text = "経過表示";
            }
        }
    }

    public class BetGameSimulator
    {
        /// <summary>
        /// ゲーム開始金額
        /// </summary>
        public decimal Start { get; set; }

        /// <summary>
        /// ゲーム掛け金
        /// </summary>
        public decimal Bet { get; set; }

        /// <summary>
        /// 掛け金上限
        /// </summary>
        public decimal BetLimit { get; set; }

        /// <summary>
        /// 掛け金総額
        /// </summary>
        public decimal TotalBet { get; private set; }

        /// <summary>
        /// 獲得総額
        /// </summary>
        public decimal TotalGet { get; private set; }

        /// <summary>
        /// 回収率
        /// </summary>
        public decimal Rate
        {
            get
            {
                return this.TotalGet / this.TotalBet * 100;
            }
        }

        /// <summary>
        /// ゲームログ
        /// </summary>
        public List<GameLogInfo> GameLogs { get; private set; }

        /// <summary>
        /// 乱数生成器
        /// </summary>
        private Random randomizer;

        public BetGameSimulator(Random randomizer)
        {
            this.randomizer = randomizer;
            this.GameLogs = new List<GameLogInfo>();
        }

        /// <summary>
        /// 勝率50%
        /// </summary>
        private bool isGameWinPer50
        {
            get
            {
                return (this.randomizer.Next(1, 10000) % 2).Equals(0);
            }
        }

        public void TryMartingale(decimal round)
        {
            this.GameLogs.Clear();

            for (decimal gameRound = 1; gameRound <= round; gameRound++)
            {
                decimal pushRound = 0;
                decimal betSum = 0;
                this.Bet = this.Start;
                while (this.Bet <= this.BetLimit)
                {
                    var log = new GameLogInfo();
                    log.GameRound = gameRound;
                    log.PushRound = ++pushRound;
                    log.Bet = this.Bet;
                    betSum += this.Bet;
                    log.BetSum = betSum;

                    this.TotalBet += this.Bet;
                    //win
                    if (this.isGameWinPer50)
                    {
                        log.Win = true;
                        log.Return = this.Bet * 2;

                        this.TotalGet += this.Bet * 2;
                    }
                    //lose
                    else
                    {
                        log.Win = false;
                        log.Return = 0;

                        this.Bet *= 2;
                    }
                    this.GameLogs.Add(log);

                    //勝ったら最初から
                    if (log.Win)
                    {
                        break;
                    }
                }
            }
        }
    }

    public class GameLogInfo
    {
        /// <summary>
        /// ゲーム回数
        /// </summary>
        public decimal GameRound { get; set; }

        /// <summary>
        /// 倍プッシュ回数
        /// </summary>
        public decimal PushRound { get; set; }

        /// <summary>
        /// 勝敗
        /// </summary>
        public bool Win { get; set; }

        /// <summary>
        /// 掛け金
        /// </summary>
        public decimal Bet { get; set; }

        /// <summary>
        /// 投入金額
        /// </summary>
        public decimal BetSum { get; set; }

        /// <summary>
        /// 獲得額
        /// </summary>
        public decimal Return { get; set; }
    }
}
