﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinCopy
{
    public partial class Request : Form
    {
        private string marketPrice;
        private string coinName;
        public balance userBalance;
        mainForm mForm;
        public Request(string coinName, string mPrice, balance uBalance, mainForm mF)
        {
            InitializeComponent();
            cmbRequest.Items.Add("매수");
            cmbRequest.Items.Add("매도");
            userBalance = uBalance;
            marketPrice = mPrice;
            this.coinName = coinName;
            mForm = mF;
        }

        private void stockNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자와 백스페이스, . 만 입력 받도록 하는 코드
            if ( char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || ( e.KeyChar == '.' ) ) {
                e.Handled = false;
            } else
                e.Handled = true;            
        }
        /*
         * selection == 0 : 매수 , selection == 1 : 매도         
         *
         */
        private void btnOK_Click(object sender, EventArgs e)
        {
            int selection = cmbRequest.SelectedIndex;

           if (selection == 0)
            {
                double howMany = Double.Parse(stockNumberTextBox.Text);
               
                if ( rdoMarketPrice.Checked == true )
                {
                    double marketPriceDouble = Double.Parse(marketPrice);
                    double totalCost = howMany * marketPriceDouble;
                    
                    if (userBalance.getCash() < totalCost)
                    {
                        MessageBox.Show("금액 부족\n" + "소유 현금 : " + userBalance.getCash() +"\n" + "가격 총합 : " + totalCost ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    mForm.buy_data.buyQuantity = howMany;
                    mForm.calculation();

                    MessageBox.Show("매수 채결");                    
                    this.Close();
                }
            }
        }

        private void rdoCustomPrice_MouseClick(object sender, MouseEventArgs e)
        {
            priceTextBox.Enabled = true;
        }

        private void rdoMarketPrice_CheckedChanged(object sender, EventArgs e)
        {
            priceTextBox.Enabled = false;
            priceTextBox.Text = marketPrice;
        }
    }
}
