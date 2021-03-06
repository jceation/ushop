﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Presenter.Interface;
using Presenter.InterfaceImplement;

namespace View
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm, IAccountView
    {
        private AccountPresenter preAccount;

        public frmLogin()
        {
            preAccount = new AccountPresenter(this);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            preAccount.verifyAccount(edtID.Text, edtPassword.Text);
        }

        public void loadAccounts(List<Model.ACCOUNT> listObj)
        {
            throw new NotImplementedException();
        }

        public void veryfyAccount(string message)
        {
            if (message == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            else
            {
                frmUShop frm = new frmUShop();
                frm.Show();
                Hide();
            }
        }
    }
}