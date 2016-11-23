using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
namespace adel_saboor_project
{
    public partial class CUSTMOR : Form
    {
        Customor cus = new Customor();
        public CUSTMOR()
        {
            InitializeComponent();
         
        }
        public void clearTEXTS()
        {
            Cus_id.Clear();
            Cus_name.Clear();
            phone.Clear();
            Address.Clear();
        }

        public void loadData()
        {
            cus.cust_ID = Cus_id.Text;
            cus.Cust_name = Cus_name.Text;
            cus.phone = phone.Text;
            cus.address = Address.Text;
            if (radioButton1.Checked == true)
                cus.Gender = "M";
            else
                cus.Gender = "F";
           
        }
        public void showData()
        {
             Cus_id.Text=cus.cust_ID ;
            Cus_name.Text =cus.Cust_name ;
          phone.Text  = cus.phone ;
         Address.Text  =  cus.address ;
         if (cus.Gender == "M")
             radioButton1.Checked = true;
         else
             radioButton2.Checked = true;
         BtnPOS.Text = cus.current_postion();

        }
        private void Form1_Load(object sender, EventArgs e)

        {
          
            dataGridView1.DataSource = cus.ALLData();
            BtnPOS.Text = cus.current_postion();
            cus.move_first();
            showData();
          
           
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cus.move_last();
            showData();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadData();
            string se = cus.Add_new();
            MessageBox.Show(se);
            Form1_Load(null, null);
            clearTEXTS();
            showresult.Text = "added";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cus.cust_ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string se = cus.Delete();
            MessageBox.Show(se);
            
            dataGridView1.DataSource = cus.ALLData();
            clearTEXTS();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadData();
            string se = cus.Add_new();
            MessageBox.Show(se);
            dataGridView1.DataSource = cus.ALLData();
            clearTEXTS();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cus.move_first();
            showData(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cus.Move_PRior();
            showData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cus.move_next();
            showData();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            button5_Click(sender, e);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            button8_Click(sender, e);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            button7_Click(sender, e);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
            clearTEXTS();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
            clearTEXTS();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            clearTEXTS();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cus.find(Cus_id.Text))
            {
                showData();
            }
            else
                showresult.Text = "the ID not found";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            showresult.Text = "";
        }
        
       
       
    }
}
