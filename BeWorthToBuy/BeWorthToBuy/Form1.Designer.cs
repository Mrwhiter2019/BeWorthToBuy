
namespace BeWorthToBuy
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Compute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoanCost = new System.Windows.Forms.TextBox();
            this.FirstSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.TextBox();
            this.LoanRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.firstCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FirstMonthPay = new System.Windows.Forms.Label();
            this.labe2 = new System.Windows.Forms.Label();
            this.selfRent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LoanAll = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LiXiZong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.houseCost = new System.Windows.Forms.Label();
            this.benjin = new System.Windows.Forms.RadioButton();
            this.benxi = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.MonthMinus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.earnRate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.MonthEarn = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.EarnMinus = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LiCaiZong = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.EarnAll = new System.Windows.Forms.Label();
            this.self = new System.Windows.Forms.RadioButton();
            this.labe1 = new System.Windows.Forms.Label();
            this.houseRent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sell = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.LiCaiCost = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.FangZuCost = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.CostAll = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.HouseValue = new System.Windows.Forms.Label();
            this.Notice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(300, 288);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(75, 23);
            this.Compute.TabIndex = 0;
            this.Compute.Text = "开始计算";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "总价";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(75, 15);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 21);
            this.total.TabIndex = 2;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "首付选择";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "贷款金额";
            // 
            // LoanCost
            // 
            this.LoanCost.Enabled = false;
            this.LoanCost.Location = new System.Drawing.Point(75, 65);
            this.LoanCost.Name = "LoanCost";
            this.LoanCost.Size = new System.Drawing.Size(100, 21);
            this.LoanCost.TabIndex = 6;
            // 
            // FirstSelect
            // 
            this.FirstSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstSelect.FormattingEnabled = true;
            this.FirstSelect.Location = new System.Drawing.Point(75, 40);
            this.FirstSelect.Name = "FirstSelect";
            this.FirstSelect.Size = new System.Drawing.Size(99, 20);
            this.FirstSelect.TabIndex = 7;
            this.FirstSelect.SelectedIndexChanged += new System.EventHandler(this.FirstSelect_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "万";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "贷款年限";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "贷款利率";
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(75, 90);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(100, 21);
            this.years.TabIndex = 11;
            this.years.Text = "30";
            // 
            // LoanRate
            // 
            this.LoanRate.Location = new System.Drawing.Point(75, 115);
            this.LoanRate.Name = "LoanRate";
            this.LoanRate.Size = new System.Drawing.Size(100, 21);
            this.LoanRate.TabIndex = 12;
            this.LoanRate.Text = "2.85";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "首付金额：";
            // 
            // firstCost
            // 
            this.firstCost.AutoSize = true;
            this.firstCost.Location = new System.Drawing.Point(280, 20);
            this.firstCost.Name = "firstCost";
            this.firstCost.Size = new System.Drawing.Size(11, 12);
            this.firstCost.TabIndex = 14;
            this.firstCost.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "首月还贷：";
            // 
            // FirstMonthPay
            // 
            this.FirstMonthPay.AutoSize = true;
            this.FirstMonthPay.Location = new System.Drawing.Point(280, 45);
            this.FirstMonthPay.Name = "FirstMonthPay";
            this.FirstMonthPay.Size = new System.Drawing.Size(11, 12);
            this.FirstMonthPay.TabIndex = 16;
            this.FirstMonthPay.Text = "0";
            // 
            // labe2
            // 
            this.labe2.AutoSize = true;
            this.labe2.Location = new System.Drawing.Point(20, 170);
            this.labe2.Name = "labe2";
            this.labe2.Size = new System.Drawing.Size(53, 12);
            this.labe2.TabIndex = 17;
            this.labe2.Text = "自住房租";
            // 
            // selfRent
            // 
            this.selfRent.Location = new System.Drawing.Point(75, 165);
            this.selfRent.Name = "selfRent";
            this.selfRent.Size = new System.Drawing.Size(100, 21);
            this.selfRent.TabIndex = 18;
            this.selfRent.Text = "1500";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "贷款共计：";
            // 
            // LoanAll
            // 
            this.LoanAll.AutoSize = true;
            this.LoanAll.Location = new System.Drawing.Point(280, 120);
            this.LoanAll.Name = "LoanAll";
            this.LoanAll.Size = new System.Drawing.Size(11, 12);
            this.LoanAll.TabIndex = 20;
            this.LoanAll.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 22;
            this.label15.Text = "万";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(180, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "年";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(180, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 24;
            this.label17.Text = "%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(180, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 25;
            this.label18.Text = "元";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "利息总额：";
            // 
            // LiXiZong
            // 
            this.LiXiZong.AutoSize = true;
            this.LiXiZong.Location = new System.Drawing.Point(280, 95);
            this.LiXiZong.Name = "LiXiZong";
            this.LiXiZong.Size = new System.Drawing.Size(11, 12);
            this.LiXiZong.TabIndex = 27;
            this.LiXiZong.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "房屋花费：";
            // 
            // houseCost
            // 
            this.houseCost.AutoSize = true;
            this.houseCost.Location = new System.Drawing.Point(280, 145);
            this.houseCost.Name = "houseCost";
            this.houseCost.Size = new System.Drawing.Size(11, 12);
            this.houseCost.TabIndex = 29;
            this.houseCost.Text = "0";
            // 
            // benjin
            // 
            this.benjin.AutoSize = true;
            this.benjin.Checked = true;
            this.benjin.Location = new System.Drawing.Point(15, 13);
            this.benjin.Name = "benjin";
            this.benjin.Size = new System.Drawing.Size(71, 16);
            this.benjin.TabIndex = 30;
            this.benjin.TabStop = true;
            this.benjin.Text = "等额本金";
            this.benjin.UseVisualStyleBackColor = true;
            this.benjin.CheckedChanged += new System.EventHandler(this.benjin_CheckedChanged);
            // 
            // benxi
            // 
            this.benxi.AutoSize = true;
            this.benxi.Location = new System.Drawing.Point(100, 13);
            this.benxi.Name = "benxi";
            this.benxi.Size = new System.Drawing.Size(71, 16);
            this.benxi.TabIndex = 31;
            this.benxi.TabStop = true;
            this.benxi.Text = "等额本息";
            this.benxi.UseVisualStyleBackColor = true;
            this.benxi.CheckedChanged += new System.EventHandler(this.benxi_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "每月递减：";
            // 
            // MonthMinus
            // 
            this.MonthMinus.AutoSize = true;
            this.MonthMinus.Location = new System.Drawing.Point(280, 70);
            this.MonthMinus.Name = "MonthMinus";
            this.MonthMinus.Size = new System.Drawing.Size(11, 12);
            this.MonthMinus.TabIndex = 33;
            this.MonthMinus.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 34;
            this.label14.Text = "理财利率";
            // 
            // earnRate
            // 
            this.earnRate.Location = new System.Drawing.Point(75, 190);
            this.earnRate.Name = "earnRate";
            this.earnRate.Size = new System.Drawing.Size(100, 21);
            this.earnRate.TabIndex = 35;
            this.earnRate.Text = "2.5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(350, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 36;
            this.label19.Text = "理财首月：";
            // 
            // MonthEarn
            // 
            this.MonthEarn.AutoSize = true;
            this.MonthEarn.Location = new System.Drawing.Point(420, 20);
            this.MonthEarn.Name = "MonthEarn";
            this.MonthEarn.Size = new System.Drawing.Size(11, 12);
            this.MonthEarn.TabIndex = 37;
            this.MonthEarn.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(350, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 38;
            this.label20.Text = "每月递减：";
            // 
            // EarnMinus
            // 
            this.EarnMinus.AutoSize = true;
            this.EarnMinus.Location = new System.Drawing.Point(420, 45);
            this.EarnMinus.Name = "EarnMinus";
            this.EarnMinus.Size = new System.Drawing.Size(11, 12);
            this.EarnMinus.TabIndex = 39;
            this.EarnMinus.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(350, 70);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 40;
            this.label22.Text = "理财利息：";
            // 
            // LiCaiZong
            // 
            this.LiCaiZong.AutoSize = true;
            this.LiCaiZong.Location = new System.Drawing.Point(420, 70);
            this.LiCaiZong.Name = "LiCaiZong";
            this.LiCaiZong.Size = new System.Drawing.Size(11, 12);
            this.LiCaiZong.TabIndex = 41;
            this.LiCaiZong.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(350, 95);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 42;
            this.label24.Text = "理财共计：";
            // 
            // EarnAll
            // 
            this.EarnAll.AutoSize = true;
            this.EarnAll.Location = new System.Drawing.Point(420, 95);
            this.EarnAll.Name = "EarnAll";
            this.EarnAll.Size = new System.Drawing.Size(11, 12);
            this.EarnAll.TabIndex = 43;
            this.EarnAll.Text = "0";
            // 
            // self
            // 
            this.self.AutoSize = true;
            this.self.Checked = true;
            this.self.Location = new System.Drawing.Point(15, 13);
            this.self.Name = "self";
            this.self.Size = new System.Drawing.Size(47, 16);
            this.self.TabIndex = 44;
            this.self.TabStop = true;
            this.self.Text = "自住";
            this.self.UseVisualStyleBackColor = true;
            this.self.CheckedChanged += new System.EventHandler(this.self_CheckedChanged);
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(20, 145);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(53, 12);
            this.labe1.TabIndex = 45;
            this.labe1.Text = "房屋房租";
            // 
            // houseRent
            // 
            this.houseRent.Enabled = false;
            this.houseRent.Location = new System.Drawing.Point(75, 140);
            this.houseRent.Name = "houseRent";
            this.houseRent.Size = new System.Drawing.Size(100, 21);
            this.houseRent.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 47;
            this.label11.Text = "元";
            // 
            // sell
            // 
            this.sell.AutoSize = true;
            this.sell.Location = new System.Drawing.Point(100, 13);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(47, 16);
            this.sell.TabIndex = 48;
            this.sell.TabStop = true;
            this.sell.Text = "出租";
            this.sell.UseVisualStyleBackColor = true;
            this.sell.CheckedChanged += new System.EventHandler(this.sell_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(180, 195);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 49;
            this.label21.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.benxi);
            this.groupBox1.Controls.Add(this.benjin);
            this.groupBox1.Location = new System.Drawing.Point(10, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 35);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.self);
            this.groupBox2.Controls.Add(this.sell);
            this.groupBox2.Location = new System.Drawing.Point(10, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 35);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(350, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 52;
            this.label23.Text = "理财支出：";
            // 
            // LiCaiCost
            // 
            this.LiCaiCost.AutoSize = true;
            this.LiCaiCost.Location = new System.Drawing.Point(422, 120);
            this.LiCaiCost.Name = "LiCaiCost";
            this.LiCaiCost.Size = new System.Drawing.Size(11, 12);
            this.LiCaiCost.TabIndex = 53;
            this.LiCaiCost.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(350, 145);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 54;
            this.label25.Text = "房租支出：";
            // 
            // FangZuCost
            // 
            this.FangZuCost.AutoSize = true;
            this.FangZuCost.Location = new System.Drawing.Point(420, 145);
            this.FangZuCost.Name = "FangZuCost";
            this.FangZuCost.Size = new System.Drawing.Size(11, 12);
            this.FangZuCost.TabIndex = 55;
            this.FangZuCost.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(350, 170);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 56;
            this.label26.Text = "支出合计：";
            // 
            // CostAll
            // 
            this.CostAll.AutoSize = true;
            this.CostAll.Location = new System.Drawing.Point(420, 170);
            this.CostAll.Name = "CostAll";
            this.CostAll.Size = new System.Drawing.Size(11, 12);
            this.CostAll.TabIndex = 57;
            this.CostAll.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(210, 170);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 58;
            this.label27.Text = "房屋价值：";
            // 
            // HouseValue
            // 
            this.HouseValue.AutoSize = true;
            this.HouseValue.Location = new System.Drawing.Point(280, 170);
            this.HouseValue.Name = "HouseValue";
            this.HouseValue.Size = new System.Drawing.Size(11, 12);
            this.HouseValue.TabIndex = 59;
            this.HouseValue.Text = "0";
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Notice.Location = new System.Drawing.Point(210, 225);
            this.Notice.MaximumSize = new System.Drawing.Size(280, 999);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(273, 14);
            this.Notice.TabIndex = 60;
            this.Notice.Text = "输入价格及利率，选择计算方式后开始计算";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 339);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.HouseValue);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.CostAll);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.FangZuCost);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.LiCaiCost);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.houseRent);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.EarnAll);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.LiCaiZong);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.EarnMinus);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.MonthEarn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.earnRate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.MonthMinus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.houseCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LiXiZong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LoanAll);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.selfRent);
            this.Controls.Add(this.labe2);
            this.Controls.Add(this.FirstMonthPay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.firstCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LoanRate);
            this.Controls.Add(this.years);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstSelect);
            this.Controls.Add(this.LoanCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Compute);
            this.Name = "Form1";
            this.Text = "值得买吗？";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoanCost;
        private System.Windows.Forms.ComboBox FirstSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox years;
        private System.Windows.Forms.TextBox LoanRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label firstCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label FirstMonthPay;
        private System.Windows.Forms.Label labe2;
        private System.Windows.Forms.TextBox selfRent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LoanAll;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LiXiZong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label houseCost;
        private System.Windows.Forms.RadioButton benjin;
        private System.Windows.Forms.RadioButton benxi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label MonthMinus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox earnRate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label MonthEarn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label EarnMinus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LiCaiZong;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label EarnAll;
        private System.Windows.Forms.RadioButton self;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.TextBox houseRent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton sell;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label LiCaiCost;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label FangZuCost;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label CostAll;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label HouseValue;
        private System.Windows.Forms.Label Notice;
    }
}

