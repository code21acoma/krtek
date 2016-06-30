using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace RSA_test
{
    public partial class Form1 : Form
    {
        const int keySize = 1024;
        string publicAndPrivateKey;
        string publicKey;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsymmetricEncryption.GenerateKeys(keySize, out publicKey, out publicAndPrivateKey);
            textBox1.Text = publicKey;
            textBox2.Text = publicAndPrivateKey;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = AsymmetricEncryption.EncryptText(textBox3.Text, keySize, publicKey);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = AsymmetricEncryption.DecryptText(textBox4.Text, keySize, publicAndPrivateKey);
        }
    }
}
