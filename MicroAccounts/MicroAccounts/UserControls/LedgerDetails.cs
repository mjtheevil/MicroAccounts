using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroAccounts.Data;
using MicroAccounts.ViewModel;

namespace MicroAccounts.UserControls
{
    public partial class LedgerDetails : UserControl
    {

        MicroAccountsEntities1 _entities;

        public LedgerDetails()
        {
            InitializeComponent();
        }

        private void LedgerDetails_Load(object sender, EventArgs e)
        {
            dataGridBind();
        }

        void dataGridBind()
        {
            try
            {
                int rowNo = 1;
                dgLedgerDetails.AutoGenerateColumns = false;
                _entities = new MicroAccountsEntities1();

                List<AccLedgerVm> modelList = new List<AccLedgerVm>();

                var data = _entities.tbl_AccLedger.OrderByDescending(x => x.Id);

                foreach (var item in data)
                {
                    AccLedgerVm model = new AccLedgerVm();
                    model.rowNo = rowNo;
                    model.Id = item.Id;
                    model.ledgerName = item.ledgerName;
                    model.groupName = _entities.tbl_AccGroup.Where(x => x.groupId == item.groupId).FirstOrDefault().groupName;

                    if (item.opBalanceDC == "D")
                    {
                        model.opBalanceDC = "Dr " + item.opBalance;
                    }
                    else
                    {
                        model.opBalanceDC = "Cr " + item.opBalance;
                    }

                    if (item.createdDate == null)
                        model.createdDate = "--";
                    else
                        model.createdDate = Convert.ToDateTime(item.createdDate).ToString("dd-MM-yyyy  hh:mm tt");

                    if (item.updatedDate == null)
                        model.updateDate = "--";
                    else
                        model.updateDate = Convert.ToDateTime(item.updatedDate).ToString("dd-MM-yyyy  hh:mm tt");

                    modelList.Add(model);

                    rowNo++;
                }

                dgLedgerDetails.DataSource = modelList;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnNewLedger_Click(object sender, EventArgs e)
        {
            AccountLedger acc = new AccountLedger(0, "");
            acc.ShowDialog();
            dataGridBind();
        }

        private void dgLedgerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgLedgerDetails.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {
                        _entities = new MicroAccountsEntities1();

                        var cellId = Convert.ToInt32(dgLedgerDetails.CurrentRow.Cells[0].Value);

                        var selectedData1 = _entities.tbl_LedgerDetails.Where(x => x.ledgerId == cellId).FirstOrDefault();
                        var selectedData2 = _entities.tbl_AccLedger.Where(x => x.Id == cellId).FirstOrDefault();

                        _entities.tbl_LedgerDetails.Remove(selectedData1);
                        _entities.tbl_AccLedger.Remove(selectedData2);

                        _entities.SaveChanges();
                        MessageBox.Show("Record deleted ");
                        dataGridBind();
                    }

                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Record Cannot be deleted. Reference of this record is present in other entries");
            }
        }

        private void dgLedgerDetails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgLedgerDetails.CurrentRow.Index != -1 && dgLedgerDetails.CurrentRow.Cells[1].Value != null)
                {
                    var lID = Convert.ToInt32(dgLedgerDetails.CurrentRow.Cells[0].Value);

                    AccountLedger acc = new AccountLedger(lID, "");
                    acc.ShowDialog();
                    dataGridBind();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
