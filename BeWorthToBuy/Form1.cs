using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeWorthToBuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            this.FirstSelect.Items.Clear();
            if (Decimal.TryParse(this.total.Text, out decimal _total))
            {
                string _total10 = (Convert.ToInt64(_total * 10) / 100).ToString();
                for (int i = 10; i <= 100;)
                {
                    string item = i.ToString() + "%(" + (Convert.ToInt64(_total * i) / 100).ToString() + "万)";
                    this.FirstSelect.Items.Add(item);
                    i += 5;
                }
            }
        }

        private void FirstSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = this.FirstSelect.SelectedItem.ToString();
            if (!string.IsNullOrWhiteSpace(str))
            {
                this.firstCost.Text = str.Substring(str.IndexOf('(') + 1, str.IndexOf(')') - str.IndexOf('(') - 2) + "0000";
                this.LoanCost.Text = (Convert.ToDecimal(this.total.Text) - Convert.ToDecimal(this.firstCost.Text) / 10000 ).ToString();
            }
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.total.Text))
            {
                MessageBox.Show("请输入总价!");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.FirstSelect.Text))
            {
                MessageBox.Show("请选择首付!");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.LoanCost.Text))
            {
                MessageBox.Show("请输入贷款金额!");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.years.Text))
            {
                MessageBox.Show("请输入贷款年限!");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.LoanRate.Text))
            {
                MessageBox.Show("请输入贷款利率!");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.earnRate.Text))
            {
                MessageBox.Show("请输入理财利率!");
                return;
            }
            decimal _loanCost = Convert.ToDecimal(this.LoanCost.Text) * 10000;
            int _years = Convert.ToInt32(this.years.Text);
            decimal _loanRate = Convert.ToDecimal(this.LoanRate.Text) / 100;
            decimal _loanMonthRate = _loanRate / 12;
            decimal _earnRate = Convert.ToDecimal(this.earnRate.Text) / 100;
            decimal _earnMonthRate = _earnRate / 12;
            long _selfrent = Convert.ToInt64(this.selfRent.Text == "" ? "0" : this.selfRent.Text);
            long _houserent = Convert.ToInt64(this.houseRent.Text == "" ? "0" : this.houseRent.Text);
            decimal _lastmonth = 0;
            if (this.self.Checked)//买房自住
            {
                if (this.benjin.Checked)
                {
                    decimal monthBenJin = (decimal)Convert.ToInt64(_loanCost / _years / 12 * 100) / 100;
                    decimal firstMonthLiXi = (decimal)Convert.ToInt64(_loanCost * _loanMonthRate * 100) / 100;
                    this.FirstMonthPay.Text = (monthBenJin + firstMonthLiXi).ToString();
                    this.MonthMinus.Text = ((decimal)Convert.ToInt64(monthBenJin * _loanMonthRate * 100) / 100).ToString();
                    _lastmonth = monthBenJin + Convert.ToDecimal(this.MonthMinus.Text);
                    this.LoanAll.Text = ((decimal)Convert.ToInt64((monthBenJin + firstMonthLiXi + monthBenJin + Convert.ToDecimal(this.MonthMinus.Text)) * _years * 12 / 2 * 100) / 100).ToString();
                    this.LiXiZong.Text = (Convert.ToDecimal(this.LoanAll.Text) - _loanCost).ToString();
                    this.houseCost.Text = (Convert.ToDecimal(this.LoanAll.Text) + Convert.ToDecimal(this.firstCost.Text)).ToString();
                }
                else
                {
                    this.MonthMinus.Text = "0";
                    this.FirstMonthPay.Text = ((decimal)Convert.ToInt64(_loanCost * (_loanMonthRate * Power(1 + _loanMonthRate, _years * 12)) / (Power(1 + _loanMonthRate, _years * 12) - 1) * 100) / 100).ToString();
                    _lastmonth = Convert.ToDecimal(this.FirstMonthPay.Text);
                    this.LoanAll.Text = (Convert.ToDecimal(this.FirstMonthPay.Text) * 12 * _years).ToString();
                    this.LiXiZong.Text = (Convert.ToDecimal(this.LoanAll.Text) - _loanCost).ToString();
                    this.houseCost.Text = (Convert.ToDecimal(this.LoanAll.Text) + Convert.ToDecimal(this.firstCost.Text)).ToString();
                }
                //不贷款，理财的情况
                this.MonthEarn.Text = (Convert.ToDecimal(this.FirstMonthPay.Text) - _selfrent).ToString();
                this.EarnMinus.Text = this.MonthMinus.Text;
                this.EarnAll.Text = (ComputeLiCai(Convert.ToDecimal(this.firstCost.Text), Convert.ToDecimal(this.MonthEarn.Text), _earnMonthRate, _years * 12, Convert.ToDecimal(this.EarnMinus.Text))).ToString();
                _lastmonth = _lastmonth - _selfrent;
                this.LiCaiCost.Text = ((decimal)Convert.ToInt64((Convert.ToDecimal(this.firstCost.Text) + (Convert.ToDecimal(this.MonthEarn.Text) + _lastmonth) * _years * 12 / 2 )* 100) / 100).ToString();
                this.LiCaiZong.Text = ((decimal)Convert.ToInt64((Convert.ToDecimal(this.EarnAll.Text) - Convert.ToDecimal(this.LiCaiCost.Text)) * 100) / 100).ToString();
                this.FangZuCost.Text = (_selfrent * _years * 12).ToString();
                this.CostAll.Text = (Convert.ToDecimal(this.LiCaiCost.Text) + Convert.ToDecimal(this.FangZuCost.Text)).ToString();
                this.HouseValue.Text = (Convert.ToDecimal(this.EarnAll.Text)).ToString();
                this.Notice.Text = $@"该房子{_years}年后需要卖到{this.HouseValue.Text}元，买与不买的收益相当。若高于此价格，值得买，低于此价格，不值得买。";
            }
            else//出租
            {
                if (this.benjin.Checked)
                {
                    decimal monthBenJin = (decimal)Convert.ToInt64(_loanCost / _years / 12 * 100) / 100;
                    decimal firstMonthLiXi = (decimal)Convert.ToInt64(_loanCost * _loanMonthRate * 100) / 100;
                    this.FirstMonthPay.Text = (monthBenJin + firstMonthLiXi + _selfrent - _houserent).ToString();
                    this.MonthMinus.Text = ((decimal)Convert.ToInt64(monthBenJin * _loanMonthRate * 100) / 100).ToString();
                    _lastmonth = monthBenJin + Convert.ToDecimal(this.MonthMinus.Text) + _selfrent - _houserent;
                    this.LoanAll.Text = ((decimal)Convert.ToInt64((monthBenJin + firstMonthLiXi + monthBenJin + Convert.ToDecimal(this.MonthMinus.Text)) * _years * 12 / 2 * 100) / 100).ToString();
                    this.LiXiZong.Text = (Convert.ToDecimal(this.LoanAll.Text) - _loanCost).ToString();
                    this.houseCost.Text = (Convert.ToDecimal(this.LoanAll.Text) + Convert.ToDecimal(this.firstCost.Text)).ToString();
                }
                else
                {
                    this.MonthMinus.Text = "0";
                    this.FirstMonthPay.Text = ((decimal)Convert.ToInt64(_loanCost * (_loanMonthRate * Power(1 + _loanMonthRate, _years * 12)) / (Power(1 + _loanMonthRate, _years * 12) - 1) * 100) / 100 + _selfrent - _houserent).ToString();
                    _lastmonth = Convert.ToDecimal(this.FirstMonthPay.Text);
                    this.LoanAll.Text = ((Convert.ToDecimal(this.FirstMonthPay.Text) + _houserent - _selfrent) * 12 * _years).ToString();
                    this.LiXiZong.Text = (Convert.ToDecimal(this.LoanAll.Text) - _loanCost).ToString();
                    this.houseCost.Text = (Convert.ToDecimal(this.LoanAll.Text) + Convert.ToDecimal(this.firstCost.Text)).ToString();
                }
                //不贷款，理财的情况
                this.MonthEarn.Text = (Convert.ToDecimal(this.FirstMonthPay.Text) - _selfrent).ToString();
                this.EarnMinus.Text = this.MonthMinus.Text;
                this.EarnAll.Text = (ComputeLiCai(Convert.ToDecimal(this.firstCost.Text), Convert.ToDecimal(this.MonthEarn.Text), _earnMonthRate, _years * 12, Convert.ToDecimal(this.EarnMinus.Text))).ToString();
                _lastmonth = _lastmonth - _selfrent;
                this.LiCaiCost.Text = ((decimal)Convert.ToInt64((Convert.ToDecimal(this.firstCost.Text) + (Convert.ToDecimal(this.MonthEarn.Text) + _lastmonth) * _years * 12 / 2) * 100) / 100).ToString();
                this.LiCaiZong.Text = ((decimal)Convert.ToInt64((Convert.ToDecimal(this.EarnAll.Text) - Convert.ToDecimal(this.LiCaiCost.Text)) * 100) / 100).ToString();
                this.FangZuCost.Text = (_selfrent * _years * 12).ToString();
                this.CostAll.Text = (Convert.ToDecimal(this.LiCaiCost.Text) + Convert.ToDecimal(this.FangZuCost.Text)).ToString();
                this.HouseValue.Text = (Convert.ToDecimal(this.EarnAll.Text)).ToString();
                this.Notice.Text = $@"该房子{_years}年后需要卖到{this.HouseValue.Text}元，买与不买的收益相当。若高于此价格，值得买，低于此价格，不值得买。";
            }
        }
        private decimal Power(decimal a, int b)
        {
            decimal res = 1;
            for(int i = 0; i < b; i++)
            {
                res = res * a;
            }
            return res;
        }
        private decimal ComputeLiCai(decimal a, decimal b, decimal c, int d, decimal e)
        {
            if (d < 1)
                return (decimal)Convert.ToInt64(a * 100) / 100;
            d--;
            a = (decimal)Convert.ToInt64((a + b) * (1 + c) * 10000) / 10000;
            b = b - e;
            return ComputeLiCai(a, b, c, d, e);
        }
        private void benjin_CheckedChanged(object sender, EventArgs e)
        {
            if(this.benjin.Checked)
                this.benxi.Checked = false;
        }
        private void benxi_CheckedChanged(object sender, EventArgs e)
        {
            if(this.benxi.Checked)
                this.benjin.Checked = false;
        }

        private void self_CheckedChanged(object sender, EventArgs e)
        {
            if(this.self.Checked)
            {
                this.houseRent.Text = "0";
                this.houseRent.Enabled = false;
                this.sell.Checked = false;
            }
        }

        private void sell_CheckedChanged(object sender, EventArgs e)
        {
            if (this.sell.Checked)
            {
                this.houseRent.Enabled = true;
                this.self.Checked = false;
            }
        }

        private void years_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.years.Text))
            {
                if (Convert.ToDecimal(this.years.Text) > 5)
                    this.LoanRate.Text = "2.6";
                else if (Convert.ToDecimal(this.years.Text) <= 5 && Convert.ToDecimal(this.years.Text) >= 0)
                    this.LoanRate.Text = "2.1";
                else
                {
                    this.years.Text = "30";
                    MessageBox.Show("请输入正确的贷款年限!");
                }

            }
        }
    }
}
