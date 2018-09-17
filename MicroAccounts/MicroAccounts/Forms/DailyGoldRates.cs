﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroAccounts.Data;

namespace MicroAccounts.Forms
{
    public partial class DailyGoldRates : Form
    {
        string userName;
        MicroAccountsEntities1 _entities;
        int passedId;
        public DailyGoldRates(string loginName, int id)
        {
            InitializeComponent();
            userName = loginName;
            passedId = id;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MainDashboard mm = new MainDashboard(userName);
            mm.Show();
            this.Close();
        }

        private void txt999_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHallMark.Focus();
            }

        }

        private void txt999_FontChanged(object sender, EventArgs e)
        {

        }

        private void txt999_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txt999.Height;
            SidePanel2.Top = txt999.Top;
        }

        private void txtHallMark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBuyBack.Focus();
            }
        }

        private void txtHallMark_Enter(object sender, EventArgs e)
        {

            SidePanel2.Height = txtHallMark.Height;
            SidePanel2.Top = txtHallMark.Top;
        }

        private void txtBuyBack_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txtBuyBack.Height;
            SidePanel2.Top = txtBuyBack.Top;
        }

        private void txtBuyBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt22c.Focus();
            }
        }

        private void txt22c_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txt22c.Height;
            SidePanel2.Top = txt22c.Top;
        }

        private void txt22c_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt23c.Focus();
            }
        }

        private void txt23c_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSilver.Focus();
            }
        }

        private void txt23c_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txt23c.Height;
            SidePanel2.Top = txt23c.Top;
        }

        private void txtSilver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate.Focus();
            }
        }

        private void txtSilver_Enter(object sender, EventArgs e)
        {
            SidePanel2.Height = txtSilver.Height;
            SidePanel2.Top = txtSilver.Top;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            btnCreate.Text = "Create";
            txtSilver.Text = "";
            txtHallMark.Text = "";
            txt22c.Text = "";
            txt23c.Text = "";
            txt999.Text = "";
            txtBuyBack.Text = "";

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt999.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt999, "Enter Value.");
                    txt999.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Value.";
                }
                else if (txtHallMark.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtHallMark, "Enter Value.");
                    txtHallMark.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Value.";
                }
                else if (txtBuyBack.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtBuyBack, "Enter Value.");
                    txtBuyBack.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Value.";
                }
                else if (txt22c.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt22c, "Enter Value.");
                    txt22c.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Value.";
                }
                else if (txt23c.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt23c, "Enter Value.");
                    txt23c.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Value.";
                }
                else if (txtSilver.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtSilver, "Enter Value.");
                    txtSilver.Focus();
                    panel3.Visible = true;
                    lblError.Text = "Enter Value.";
                }
                else
                {
                    if (passedId == 0)
                    {

                        _entities = new MicroAccountsEntities1();

                        DailyRate rates = new DailyRate();

                        rates.fineGold = Convert.ToDecimal(txt999.Text);
                        rates.hallmark = Convert.ToDecimal(txtHallMark.Text);
                        rates.hallmarkBuyBack = Convert.ToDecimal(txtBuyBack.Text);
                        rates.twentyTwoC = Convert.ToDecimal(txt22c.Text);
                        rates.twentyThreeC = Convert.ToDecimal(txt23c.Text);
                        rates.silver = Convert.ToDecimal(txtSilver.Text);

                        rates.date = DateTime.Now.Date;
                        rates.createdDate = DateTime.Now;

                        _entities.DailyRates.Add(rates);
                        _entities.SaveChanges();

                        MessageBox.Show("Record SuccessFully Added!");
                        clear();
                    }

                    else
                    {
                        btnCreate.Text = "Update";
                        _entities = new MicroAccountsEntities1();

                        var rates = _entities.DailyRates.Where(x => x.id == passedId).FirstOrDefault();

                        rates.fineGold = Convert.ToDecimal(txt999.Text);
                        rates.hallmark = Convert.ToDecimal(txtHallMark.Text);
                        rates.hallmarkBuyBack = Convert.ToDecimal(txtBuyBack.Text);
                        rates.twentyTwoC = Convert.ToDecimal(txt22c.Text);
                        rates.twentyThreeC = Convert.ToDecimal(txt23c.Text);
                        rates.silver = Convert.ToDecimal(txtSilver.Text);

                        rates.date = DateTime.Now.Date;
                        rates.createdDate = DateTime.Now;
                         
                        _entities.SaveChanges();

                        MessageBox.Show("Record SuccessFully Updated!");
                        clear();
                    }
                }
            }
            catch (Exception c)
            {

            }
        }

        private void DailyGoldRates_Load(object sender, EventArgs e)
        {
            if (passedId >  0)
            {
                _entities = new MicroAccountsEntities1();

                var data = _entities.DailyRates.Where(x => x.id == passedId).FirstOrDefault();

                txtSilver.Text = data.silver.ToString();
                txtHallMark.Text = data.hallmark.ToString();
                txt22c.Text = data.twentyTwoC.ToString();
                txt23c.Text = data.twentyThreeC.ToString();
                txt999.Text = data.fineGold.ToString();
                txtBuyBack.Text = data.hallmarkBuyBack.ToString();

                btnCreate.Text = "Update";
            }
        }
    }
}
