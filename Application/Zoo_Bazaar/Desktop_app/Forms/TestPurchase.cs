using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicCL;
using LogicCL.Repository;

namespace Desktop_app.Forms
{
    public partial class TestPurchase : Form
    {
        private Payment payment;
        private PaymentRepository paymentRepository;
        private int paymentId;
        public TestPurchase()
        {
            InitializeComponent();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {

            Payment payment = new Payment(paymentId,)
            paymentRepository.AddPayments()
        }
    }
}
