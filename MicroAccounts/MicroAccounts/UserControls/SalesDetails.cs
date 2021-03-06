﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroAccounts.Forms;
using MicroAccounts.Data;
using MicroAccounts.ViewModel;
using System.Windows.Forms;
using MicroAccounts.AccountsModuleClasses;

namespace MicroAccounts.UserControls
{

    public partial class SalesDetails : UserControl
    {
        MicroAccountsEntities1 _entities;
        AmtFormatting amtFormat = new AmtFormatting();
        public SalesDetails()
        {
            InitializeComponent();
        }

        private void dgSalesDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSalesDetails.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult myResult;
                myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    _entities = new MicroAccountsEntities1();

                    var cellId = Convert.ToInt32(dgSalesDetails.CurrentRow.Cells[0].Value);

                    #region delete From TransactionTable

                    var selectedData3 = _entities.tbl_TransactionMaster.Where(x => x.voucherRefNo == cellId).ToList();

                    foreach (var item1 in selectedData3)
                    {
                        _entities.tbl_TransactionMaster.Remove(item1);
                    }
                    #endregion

                    var selectedData1 = _entities.tbl_SalesDetails.Where(x => x.salesId == cellId).FirstOrDefault();
                    var selectedData2 = _entities.tbl_SalesMaster.Where(x => x.sId == cellId).FirstOrDefault();

                    _entities.tbl_SalesDetails.Remove(selectedData1);
                    _entities.tbl_SalesMaster.Remove(selectedData2);

                    _entities.SaveChanges();
                    MessageBox.Show("Record deleted ");
                    dataGridBind();
                }
                else
                {
                    //No delete
                }

            }
        }

        void dataGridBind()
        {
            try
            {
                int rowNo = 1;
                dgSalesDetails.AutoGenerateColumns = false;
                _entities = new MicroAccountsEntities1();

                List<SalesMasterVM> modelList = new List<SalesMasterVM>();

                var data = _entities.tbl_SalesMaster.OrderByDescending(x => x.sId);

                foreach (var item in data)
                {
                    SalesMasterVM model = new SalesMasterVM();
                    model.rowNo = rowNo;
                    model.sId = item.sId;
                    model.billNo = item.billNo;
                    model.ledgerName = _entities.tbl_AccLedger.Where(x => x.Id == item.ledgerId).FirstOrDefault().ledgerName;
                    model.date = model.date = Convert.ToDateTime(item.date).ToString("dd-MM-yyyy"); ;
                    model.totalWeight = item.totalWeight;
                    model.totalAmt = Convert.ToDecimal(amtFormat.comma(item.totalAmt));

                    model.createdDate = Convert.ToDateTime(item.createdDate).ToString("dd-MM-yyyy  hh:mm tt");
                    model.updateDate = Convert.ToDateTime(item.updateDate).ToString("dd-MM-yyyy  hh:mm tt");


                    modelList.Add(model);

                    rowNo++;
                }

                dgSalesDetails.DataSource = modelList;
                lblTotalRows.Text = modelList.Count.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void SalesDetails_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";

            dataGridBind();
        }

        private void btnPurchaseEntry_Click(object sender, EventArgs e)
        {
            SalesMaster pm = new SalesMaster(0);
            pm.ShowDialog();
            dataGridBind();
        }

        private void dgSalesDetails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgSalesDetails.CurrentRow.Index != -1 && dgSalesDetails.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgSalesDetails.CurrentRow.Cells[0].Value);

                    SalesMaster acc = new SalesMaster(lID);
                    acc.ShowDialog();
                    dataGridBind();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        string s = "";
        private void txtLedgerName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLedgerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLedgerName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int rowNo = 1;
                dgSalesDetails.AutoGenerateColumns = false;
                _entities = new MicroAccountsEntities1();

                List<SalesMasterVM> modelList = new List<SalesMasterVM>();

                var data = _entities.tbl_SalesMaster.Where(x => x.billNo.Contains(txtSearch.Text) || x.tbl_AccLedger.ledgerName.Contains(txtSearch.Text)).OrderByDescending(x => x.sId);

                foreach (var item in data)
                {
                    SalesMasterVM model = new SalesMasterVM();
                    model.rowNo = rowNo;
                    model.sId = item.sId;
                    model.billNo = item.billNo;
                    model.ledgerName = _entities.tbl_AccLedger.Where(x => x.Id == item.ledgerId).FirstOrDefault().ledgerName;
                    model.date = Convert.ToDateTime(item.date).ToString("dd-MM-yyyy");
                    model.totalWeight = item.totalWeight;
                    model.totalAmt = Convert.ToDecimal(amtFormat.comma(item.totalAmt));

                    model.createdDate = Convert.ToDateTime(item.createdDate).ToString("dd-MM-yyyy  hh:mm tt");
                    model.updateDate = Convert.ToDateTime(item.updateDate).ToString("dd-MM-yyyy  hh:mm tt");


                    modelList.Add(model);

                    rowNo++;
                }

                dgSalesDetails.DataSource = modelList;
                lblTotalRows.Text = modelList.Count.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Text = DateTime.Now.Date.ToString();
            dateTimePicker2.Text = DateTime.Now.Date.ToString();
            txtSearch.Text = "";
            dataGridBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNo = 1;

                List<SalesMasterVM> modelList = new List<SalesMasterVM>();

                DateTime fromdate = DateTime.ParseExact(dateTimePicker1.Text, "dd-MM-yyyy", null);
                DateTime todate = DateTime.ParseExact(dateTimePicker2.Text, "dd-MM-yyyy", null);

                if (fromdate > todate)
                {
                    MessageBox.Show("Invalid date entered. Select valid dates");
                    return;
                }
                else
                {
                    var data = _entities.tbl_SalesMaster.Where(x => x.date >= fromdate && x.date <= todate).OrderByDescending(x => x.sId);

                    foreach (var item in data)
                    {
                        SalesMasterVM model = new SalesMasterVM();
                        model.rowNo = rowNo;
                        model.sId = item.sId;
                        model.billNo = item.billNo;
                        model.ledgerName = _entities.tbl_AccLedger.Where(x => x.Id == item.ledgerId).FirstOrDefault().ledgerName;
                        model.date = Convert.ToDateTime(item.date).ToString("dd-MM-yyyy");
                        model.totalWeight = item.totalWeight;
                        model.totalAmt = Convert.ToDecimal(amtFormat.comma(item.totalAmt));

                        model.createdDate = Convert.ToDateTime(item.createdDate).ToString("dd-MM-yyyy  hh:mm tt");
                        model.updateDate = Convert.ToDateTime(item.updateDate).ToString("dd-MM-yyyy  hh:mm tt");


                        modelList.Add(model);

                        rowNo++;
                    }

                    dgSalesDetails.DataSource = modelList;
                    lblTotalRows.Text = modelList.Count.ToString();
                }
            }
            catch (Exception x)
            {
            }
        }
    }
}
