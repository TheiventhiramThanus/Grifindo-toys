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
using System.Collections;

namespace programming
{
    public partial class salaryform : Form
    {   // Database connection 

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\thanu\onedrive\documents\visual studio 2013\Projects\programming\programming\Database.mdf;Integrated Security=True");

        public salaryform()
        {
            InitializeComponent();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exitbut_Click(object sender, EventArgs e)
        {
            dashboard mf = new dashboard();
            mf.Show();
            this.Hide();
        }

        private void salaryform_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int employee_id = int.Parse(txtID.Text);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM employeetable  WHERE employee_id LIKE '" + txtID.Text + "'", conn);
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {

                        txtname.Text = sdr["employee_name"].ToString();
                        txtcontact.Text = sdr["contact_num"].ToString();
                        txtbank.Text = sdr["bank_acc"].ToString();
                        txtjobposition.Text = sdr["emp_job_position"].ToString();
                        txtanual.Text = sdr["num_anual_leaves"].ToString();
                        txtcasual.Text = sdr["num_casual_leaves"].ToString();
                        txtmedical.Text = sdr["num_medical_leaves"].ToString();
                        txtsalary.Text = sdr["emp_monthly_salary"].ToString();


                        txtot.Text = sdr["emp_ot_rate"].ToString();
                        txtallowance.Text = sdr["emp_allowance"].ToString();
                        txtsalary.Text = txtsalary.Text;



                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                        txtID.Clear();
                        txtID.Focus();
                    }
                }




                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            txtname.Clear();
            txtcontact.Clear();
            txtbank.Clear();
            txtjobposition.Clear();
            txtanual.Clear();
            txtcasual.Clear();
            txtmedical.Clear();
            txtsalary.Clear();
            txtot.Clear();
            txtallowance.Clear();
            txtID.Clear();
            txtabsent.Clear();
            txttotalwork.Clear();
            txtpay.Clear();
            txtpayslip.Clear();
            empbase.Clear();
            empgross.Clear();
            empnobay.Clear();
            emptax.Clear();
            embase.Clear();
            emcycle.Clear();
            txsalary.Clear();
            emday.Clear();
            emnobay.Clear();
            emot.Clear();
            txtID.Focus();

        }

        private void txttotalwork_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                txtabsent.Focus();
        }

        private void txttotalwork_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtabsent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtpay.Focus();
        }

        private void txtpay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (txtID.Text == "" || txttotalwork.Text == "" || txtabsent.Text == "")
                {
                    MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                    emot.Focus();
        }

        private void emsalary_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void emcycle_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void emday_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void emnobay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                emot.Focus();
        }

        private void emot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (txtID.Text == "" || emot.Text == "")
                {
                    MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else

                    emptax.Focus();
        }

        private void embase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                emptax.FindForm();
        }

        private void emptax_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                if (txtID.Text == "" || emptax.Text == "")
                {
                    MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else


                    empgross.Focus();
        }

        private void emday_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpayslip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txsalary.Focus();
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)

                if (txtID.Text == "")
                {
                    MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int employee_id = int.Parse(txtID.Text);
                        SqlCommand cmd = new SqlCommand("SELECT * FROM employeetable  WHERE employee_id LIKE '" + txtID.Text + "'", conn);
                        conn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {

                            txtname.Text = sdr["employee_name"].ToString();
                            txtcontact.Text = sdr["contact_num"].ToString();
                            txtbank.Text = sdr["bank_acc"].ToString();
                            txtjobposition.Text = sdr["emp_job_position"].ToString();
                            txtanual.Text = sdr["num_anual_leaves"].ToString();
                            txtcasual.Text = sdr["num_casual_leaves"].ToString();
                            txtmedical.Text = sdr["num_medical_leaves"].ToString();
                            txtsalary.Text = sdr["emp_monthly_salary"].ToString();
                            txtot.Text = sdr["emp_ot_rate"].ToString();
                            txtallowance.Text = sdr["emp_allowance"].ToString();

                            txttotalwork.Focus();

                        }
                        else
                        {
                            MessageBox.Show("Data Not Found");
                            txtID.Clear();
                            txtID.Focus();
                        }
                    }




                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    finally
                    {
                        conn.Close();
                    }
                }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (empnobay.Text == "" || empbase.Text == "" || emptax.Text == "") 
                {
                    MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int basepay;
                    basepay = int.Parse(empbase.Text);

                    int nopay;
                    nopay = int.Parse(empnobay.Text);

                    int tax;
                    tax = int.Parse(emptax.Text);



                    int grosepayamount = (basepay) - (nopay + basepay * tax / 100);
                    empgross.Text = grosepayamount.ToString();

                }
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void empgross_TextChanged(object sender, EventArgs e)
        {

        }

        private void emot_TextChanged(object sender, EventArgs e)
        {

        }

        private void emsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (txttotalwork.Text == "" || txtabsent.Text == "" || txtpay.Text == "")  
                {
                    MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int nopay;
                    nopay = int.Parse(txtpay.Text);
                    emday.Text = nopay.ToString();

                    int salary;
                    salary = int.Parse(txtsalary.Text);
                    txsalary.Text = salary.ToString();


                    DateTime date2 = dateTimePicker2.Value.Date;
                    DateTime date3 = dateTimePicker3.Value.Date;

                    int cycledate = ((TimeSpan)(date3 - date2)).Days;
                    emcycle.Text = cycledate.ToString();

                    int absent;
                    absent = int.Parse(txtabsent.Text);

                    int nopayamount = (salary / cycledate) * absent;
                    emnobay.Text = nopayamount.ToString();
                    empnobay.Text = nopayamount.ToString();




                }
            }
        }

        private void dateTimePicker3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                txttotalwork.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (emot.Text == "") 
            {
                MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int emsalary;
                emsalary = int.Parse(txtsalary.Text);
                int emallowance;
                emallowance = int.Parse(txtallowance.Text);
                int emotrate;
                emotrate = int.Parse(txtot.Text);
                int emothours;
                emothours = int.Parse(emot.Text);

                int basepayamount = (emsalary + emallowance) + (emotrate * emothours);
                embase.Text = basepayamount.ToString();
                empbase.Text = basepayamount.ToString();

            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtpayslip.Text == "" || txtabsent.Text == "" || txttotalwork.Text == "" || empnobay.Text == "" || emcycle.Text == "" || emot.Text == "" || txtpay.Text == "" || empbase.Text == "" || empgross.Text == "" || emptax.Text == "")
            {
                MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    int payslip_ID = int.Parse(txtpayslip.Text);
                    int working_days = int.Parse(txttotalwork.Text);
                    int absent_days = int.Parse(txtabsent.Text);
                    int pay_days = int.Parse(txtpay.Text);
                    int cycle_days = int.Parse(emcycle.Text);
                    int ot_hours = int.Parse(emot.Text);
                    int no_pay = int.Parse(empnobay.Text);
                    int base_pay = int.Parse(empbase.Text);
                    int grose_pay = int.Parse(empgross.Text);
                    int tax = int.Parse(emptax.Text);
                    string employee_name = txtname.Text;
                    string contact_num = txtcontact.Text;
                    int num_anual_leaves = int.Parse(txtanual.Text);
                    int num_medical_leaves = int.Parse(txtmedical.Text);
                    float emp_monthly_salary = float.Parse(txtsalary.Text);
                    int num_casual_leaves = int.Parse(txtcasual.Text);
                    float emp_ot_rate = float.Parse(txtot.Text);
                    float emp_allowance = float.Parse(txtallowance.Text);
                    int employee_id = int.Parse(txtID.Text);
                    string emp_job_position = txtjobposition.Text;
                    string bank_acc = txtbank.Text;
                    SqlCommand command = new SqlCommand("INSERT INTO salarytable VALUES(" + payslip_ID + "," + working_days + "," + absent_days + "," + pay_days + "," + cycle_days + "," + ot_hours + "," + no_pay + "," + base_pay + "," + grose_pay + "," + tax + ",'" + employee_name + "','" + contact_num + "'," + num_anual_leaves + "," + num_casual_leaves + "," + num_medical_leaves + "," + emp_monthly_salary + "," + emp_ot_rate + "," + emp_allowance + "," + employee_id + ",'" + emp_job_position + "','" + bank_acc + "')", conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("saved successfully!");
                    txtname.Clear();
                    txtcontact.Clear();
                    txtbank.Clear();
                    txtjobposition.Clear();
                    txtanual.Clear();
                    txtcasual.Clear();
                    txtmedical.Clear();
                    txtsalary.Clear();
                    txtot.Clear();
                    txtallowance.Clear();
                    txtID.Clear();
                    txtabsent.Clear();
                    txttotalwork.Clear();
                    txtpay.Clear();
                    txtpayslip.Clear();
                    empbase.Clear();
                    empgross.Clear();
                    empnobay.Clear();
                    emptax.Clear();
                    embase.Clear();
                    emcycle.Clear();
                    txsalary.Clear();
                    emday.Clear();
                    emnobay.Clear();
                    emot.Clear();
                    txtpayslip.Focus();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtpayslip.Text == "")
            {
                MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int payslip_ID = int.Parse(txtpayslip.Text);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM salarytable  WHERE payslip_ID LIKE '" + txtpayslip.Text + "'", conn);
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        txtpayslip.Text = sdr["payslip_ID"].ToString();
                        txttotalwork.Text = sdr["working_days"].ToString();
                        txtabsent.Text = sdr["absent_days"].ToString();
                        empnobay.Text = sdr["no_pay"].ToString();
                        emcycle.Text = sdr["cycle_days"].ToString();
                        emot.Text = sdr["ot_hours"].ToString();

                        empbase.Text = sdr["base_pay"].ToString();
                        empgross.Text = sdr["grose_pay"].ToString();
                        emptax.Text = sdr["tax"].ToString();
                        emday.Text = sdr["pay_days"].ToString();
                        txtpay.Text = sdr["pay_days"].ToString();
                        emnobay.Text = sdr["no_pay"].ToString();
                        embase.Text = sdr["base_pay"].ToString();
                        txtID.Text = sdr["employee_id"].ToString();
                        txtname.Text = sdr["employee_name"].ToString();
                        txtcontact.Text = sdr["contact_num"].ToString();
                        txtbank.Text = sdr["bank_acc"].ToString();

                        txtanual.Text = sdr["num_anual_leaves"].ToString();
                        txtmedical.Text = sdr["num_medical_leaves"].ToString();
                        txtsalary.Text = sdr["emp_monthly_salary"].ToString();
                        txsalary.Text = sdr["emp_monthly_salary"].ToString();

                        txtot.Text = sdr["em_ot_rate"].ToString();
                        txtallowance.Text = sdr["emp_allowance"].ToString();
                        txtjobposition.Text = sdr["emp_job_position "].ToString();
                        txtcasual.Text = sdr["num_casual_leaves "].ToString();

                        txtsalary.Text = txtsalary.Text;



                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                        txtpayslip.Clear();
                        txtpayslip.Focus();
                    }
                }




                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtpayslip.Text == "" || txtabsent.Text == "" || txttotalwork.Text == "" || empnobay.Text == "" || emcycle.Text == "" || emot.Text == "" || txtpay.Text == "" || empbase.Text == "" || empgross.Text == "" || emptax.Text == "")
            {
                MessageBox.Show("Please fill the values..!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    int payslip_ID = int.Parse(txtpayslip.Text);
                    int working_days = int.Parse(txttotalwork.Text);
                    int absent_days = int.Parse(txtabsent.Text);
                    int pay_days = int.Parse(txtpay.Text);
                    int cycle_days = int.Parse(emcycle.Text);
                    int ot_hours = int.Parse(emot.Text);
                    int no_pay = int.Parse(empnobay.Text);
                    int base_pay = int.Parse(empbase.Text);
                    int grose_pay = int.Parse(empgross.Text);
                    int tax = int.Parse(emptax.Text);
                    SqlCommand command = new SqlCommand("UPDATE salarytable SET  working_days=" + working_days + " , absent_days=" + absent_days + ", pay_days=" + pay_days + ",cycle_days=" + cycle_days + ",ot_hours=" + ot_hours + ", no_pay= " + no_pay + ",base_pay=" + base_pay + ",grose_pay=" + grose_pay + ",tax=" + tax + "", conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("UPDATE successfully!");
                    txtname.Clear();
                    txtcontact.Clear();
                    txtbank.Clear();
                    txtjobposition.Clear();
                    txtanual.Clear();
                    txtcasual.Clear();
                    txtmedical.Clear();
                    txtsalary.Clear();
                    txtot.Clear();
                    txtallowance.Clear();
                    txtID.Clear();
                    txtabsent.Clear();
                    txttotalwork.Clear();
                    txtpay.Clear();
                    txtpayslip.Clear();
                    empbase.Clear();
                    empgross.Clear();
                    empnobay.Clear();
                    emptax.Clear();
                    embase.Clear();
                    emcycle.Clear();
                    txsalary.Clear();
                    emday.Clear();
                    emnobay.Clear();
                    emot.Clear();
                    txtpayslip.Focus();






                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to delete?", "Confirmation..!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                try
                {

                    conn.Open();
                    int payslip_ID = int.Parse(txtpayslip.Text);

                    SqlCommand command = new SqlCommand("DELETE FROM salarytable WHERE payslip_ID ='" + txtpayslip.Text + "'", conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully!");
                    txtname.Clear();
                    txtcontact.Clear();
                    txtbank.Clear();
                    txtjobposition.Clear();
                    txtanual.Clear();
                    txtcasual.Clear();
                    txtmedical.Clear();
                    txtsalary.Clear();
                    txtot.Clear();
                    txtallowance.Clear();
                    txtID.Clear();
                    txtabsent.Clear();
                    txttotalwork.Clear();
                    txtpay.Clear();
                    txtpayslip.Clear();
                    empbase.Clear();
                    empgross.Clear();
                    empnobay.Clear();
                    emptax.Clear();
                    embase.Clear();
                    emcycle.Clear();
                    txsalary.Clear();
                    emday.Clear();
                    emnobay.Clear();
                    emot.Clear();
                    txtpayslip.Focus();

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
            }
        }

        private void emptax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtallowance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtot_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtpayslip_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
       


        
    


        

                
    


        

        
        
        
    

