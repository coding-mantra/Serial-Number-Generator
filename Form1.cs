using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLE
{
    public partial class Form1 : Form
    {
        long i = 0;
        

       string ss = Properties.Settings.Default.idss;

        string umiko;

         public Form1()
        {
            
            InitializeComponent();
        MaximizeBox= false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
     
            comboBox1.DropDownHeight = 200;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.ActiveControl = comboBox3;
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            comboBox5.Hide();
            button10.Hide();
            dataGridView1.Hide();
            listView1.Hide();
            label15.Visible=false;
            textBox8.Visible = false;
            save.Visible = false;


            // string frmware1 = Properties.Settings.Default.firmware1;
            //  string frmware2 = Properties.Settings.Default.firmware2;
            string frmware3 = Properties.Settings.Default.firmware3;

            string rev1 = Properties.Settings.Default.revision1;
            string rev2 = Properties.Settings.Default.revision2;
            string rev3 = Properties.Settings.Default.revision3;

           

            if (Properties.Settings.Default.combobox2 != null)
            {
                foreach (object items in Properties.Settings.Default.combobox2)
                {
                    comboBox2.Items.Add(items);
                }
            }
            if (Properties.Settings.Default.combobox1 != null)
            {
                foreach (object items in Properties.Settings.Default.combobox1)
                {
                    comboBox1.Items.Add(items);
                }
            }


            if (Properties.Settings.Default.module != null)
            {
                foreach (object items in Properties.Settings.Default.module)
                {
                    comboBox3.Items.Add(items);
                }
            }
            if (Properties.Settings.Default.customer != null)
            {

                foreach (object items in Properties.Settings.Default.customer)
                {
                    comboBox4.Items.Add(items);
                }
            }

            if (Properties.Settings.Default.firmware2 != null)
            {
                foreach (object items in Properties.Settings.Default.firmware2)
                {

                        listView1.Items.Add(items.ToString());
                        umiko = items.ToString();

                    


                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        static Random random = new Random();
        private IEnumerable<object> listObj;

        private void button2_Click(object sender, EventArgs e)
        {

             if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || textBox1.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                //if (ss.Contains(comboBox1.SelectedItem.ToString()))
                //{
                //    String firmware = comboBox1.Text;
                //    String revision = comboBox2.Text;
                //    String count = textBox1.Text;

                //    Console.WriteLine("Enter Date");
                //    string date = Console.ReadLine();
                //    DateTime inputDate = DateTime.Now;
                //    var d = inputDate;
                //    CultureInfo cul = CultureInfo.CurrentCulture;

                //    int weekNum = cul.Calendar.GetWeekOfYear(
                //        d,
                //        CalendarWeekRule.FirstFourDayWeek,
                //        DayOfWeek.Monday);

                //    int year = weekNum == 52 && d.Month == 1 ? d.Year - 1 : d.Year;





                //    List<string> list = new List<string>();


                //    string io = ss.Substring(12, 10);

                //    long dd = long.Parse(io) + 1;
                //    long yy = Convert.ToInt32(count) + dd;

                //    for (i = dd; i < yy; i++)
                //    {

                //        int j = 1;
                //        string s = i.ToString().PadLeft(10, '0');


                //        long dates = long.Parse(year.ToString() + weekNum.ToString());
                //        double firm_rev = double.Parse(firmware.ToString() + revision.ToString());

                //        //  aa = long.Parse(String.Format("{0}",dates,firm_rev,s.ToString()));
                //        string aja = string.Format("{0}{1}{2}", dates, firm_rev, s);

                //        list.Add(aja.ToString());
                //        //   MessageBox.Show(Convert.ToString(random.Next(10, 20)));
                //        //  MessageBox.Show(Convert.ToString(aa));
                //    }

                //    var combinedString = string.Join(",", list.ToList());
                //    Properties.Settings.Default.idss = list.Last();

                //    Properties.Settings.Default.Save();
                //    //if (list != null)
                //    //{

                //    //    for (var j = u; j <Convert.ToInt32(count); u++)
                //    //    {
                //    //        var str = String.Format("{0:000000000}", i);
                //    //        long y = long.Parse(str);
                //    //        long xx = long.Parse(year.ToString() + weekNum.ToString());
                //    //        aa = long.Parse(String.Format("{0}{1}{2}{3}", xx, firmware, revision, y));

                //    //        list.Add(aa.ToString());
                //    //        //   MessageBox.Show(Convert.ToString(random.Next(10, 20)));
                //    //        //  MessageBox.Show(Convert.ToString(aa));
                //    //    }
                //    //    var combinedString = string.Join(",", list.ToList());
                //    //}







                //    dataGridView1.DataSource = list.Select(x => new { Value = x }).ToList();


                //    //  MessageBox.Show(Convert.ToString(combinedString));


                //    //textBox1.Text = i.ToString();

                //    SaveFileDialog saveFileDialog = new SaveFileDialog();
                //    saveFileDialog.Title = "Save as .csv File";
                //    saveFileDialog.Filter = "csv files (*.csv)|*.csv";
                //    saveFileDialog.FilterIndex = 2;

                //    saveFileDialog.FileName = "ExportData.csv";


                //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                //    {

                //        if (saveFileDialog.FileName != "")
                //        {

                //            string filePath = saveFileDialog.FileName;

                //            StreamWriter sw2 = new StreamWriter(filePath);

                //            //sw2.WriteLine("\"GEnerated Id's\"");

                //            StringBuilder builder = new StringBuilder();
                //            //  listObj is model list having Data
                //            foreach (var v in list)
                //            {

                //                sw2.WriteLine(string.Join(", ", v));

                //            }

                //            sw2.Close();

                //        }
                //    }










                //    string module = comboBox3.SelectedItem.ToString();

                //    string cust = comboBox4.SelectedItem.ToString();


                //    SaveFileDialog saveFileDialogs = new SaveFileDialog();
                //    saveFileDialogs.Title = "Save as .csv File";
                //    saveFileDialogs.Filter = "csv files (*.csv)|*.csv";
                //    saveFileDialogs.FilterIndex = 2;

                //    saveFileDialogs.FileName = "ExportDataModule.csv";


                //    if (saveFileDialogs.ShowDialog() == DialogResult.OK)
                //    {

                //        if (saveFileDialogs.FileName != "")
                //        {

                //            string filePath = saveFileDialogs.FileName;

                //            StreamWriter sw2 = new StreamWriter(filePath);

                //            sw2.WriteLine("\"Module Number\",\"Generated Id's\",\"Customer Name\"");

                //            StringBuilder builder = new StringBuilder();
                //            //  listObj is model list having Data

                //            foreach (var v in list)
                //            {
                //                sw2.WriteLine(string.Join(", ", module, v, cust));

                //            }

                //            sw2.Close();

                //        }
                //    }


                //}

                //else
                //{

                    String firmware = comboBox1.Text;
                    String revision = comboBox2.Text;
                    String count = textBox1.Text;
                       Console.WriteLine("Enter Date");
                    string date = DateTime.Now.ToString();
                    DateTime inputDate = DateTime.Now;
                    var d = inputDate;
                    CultureInfo cul = CultureInfo.CurrentCulture;

                    int weekNum = cul.Calendar.GetWeekOfYear(
                        d,
                        CalendarWeekRule.FirstFourDayWeek,
                        DayOfWeek.Monday);

                    int year = weekNum == 52 && d.Month == 1 ? d.Year - 1 : d.Year;

                    List<string> list = new List<string>();
                    var followerList = new List<string>();


                //foreach (object k in Properties.Settings.Default.firmware2)
                //{
                //    string mn = k.ToString();
                //    if (mn.Contains(firmware))
                //    {

                //            Properties.Settings.Default.firmware2.Remove(firmware);

                //        }
                //        //string klp = mn.Substring(12, 10);
                //        //long dda = long.Parse(klp) + 1;
                //        //long yya = Convert.ToInt32(count) + dda;
                //        //if (k.ToString().Contains(firmware))
                //        //{

                //        //    if (k.ToString().Contains(umiko))
                //        //    {
                //        //        string gubachii = klp;
                //        //    }
                //        //}
                //    }
              //  List<string> listd = new List<string>();
              
              //  for (int u = 0; u < listView1.Items.Count; u++)
              //  {
              //      string[] item = new string[] { listView1.Items[u].Text };
              //      listd.AddRange(item);  
              //  }
              //  string[] items = listd.ToArray();
                     
              //  if (!items.Contains("0000000000000000000000"))
              //  {
              //      MessageBox.Show(String.Join(", ", items));
              //  }
              //else
              //  {
              //      MessageBox.Show(String.Join(", ", items));
              //  }





                foreach (object k in Properties.Settings.Default.firmware2)
                    {
                          string mn = k.ToString();
                        if (mn.Contains(firmware))
                        {

                            Properties.Settings.Default.firmware2.Remove(mn);
                        


                            string gubachi = mn;
                            string io = gubachi.Substring(12, 10);
                            int decValue = int.Parse(io, System.Globalization.NumberStyles.HexNumber);
                            long dd = Convert.ToInt64(decValue) + 1;
                            long yy = Convert.ToInt32(count) + dd;


                            // if (listView1.ToString().Contains(firmware))
                            //   {


                            for (i = dd; i < yy; i++)
                            {

                                int j = 1;
                                // string s = i.ToString().PadLeft(10, '0');


                                string ss = i.ToString().PadLeft(10, '0');

                                string outputHex = int.Parse(ss).ToString("X");
                                string s = outputHex.PadLeft(10, '0');

                                long dates = long.Parse(year.ToString() + weekNum.ToString());
                                string firm_rev = firmware.ToString() + revision.ToString();

                                //  aa = long.Parse(String.Format("{0}",dates,firm_rev,s.ToString()));
                                string number = string.Format("{0}{1}{2}", dates, firm_rev, s);

                                list.Add(number.ToString());



                                //   MessageBox.Show(Convert.ToString(random.Next(10, 20)));
                                //  MessageBox.Show(Convert.ToString(aa));
                            }

                            //  Properties.Settings.Default.firmware2.Clear();





                            //   Properties.Settings.Default.firmware2.Clear();
                            comboBox5.Items.Add(list.Last());

                            listView1.Items.Add(list.Last());
                           
                                Properties.Settings.Default.firmware2.Add(list.Last());

                                Properties.Settings.Default.Save();


                            break;
                        }
                        //      listView1.Items.Add(k.ToString());


                        //listView1.Items.Add(list.Last());
                        //Properties.Settings.Default.firmware1.Add(list.Last());
                        //Properties.Settings.Default.Save();


                      


        }





                textBox1.Text = "";


                    var combinedString = string.Join(",", list.ToList());
                  
                    //if (list != null)
                    //{

                    //    for (var j = u; j <Convert.ToInt32(count); u++)
                    //    {
                    //        var str = String.Format("{0:000000000}", i);
                    //        long y = long.Parse(str);
                    //        long xx = long.Parse(year.ToString() + weekNum.ToString());
                    //        aa = long.Parse(String.Format("{0}{1}{2}{3}", xx, firmware, revision, y));

                    //        list.Add(aa.ToString());
                    //        //   MessageBox.Show(Convert.ToString(random.Next(10, 20)));
                    //        //  MessageBox.Show(Convert.ToString(aa));
                    //    }
                    //    var combinedString = string.Join(",", list.ToList());
                    //}







                    dataGridView1.DataSource = list.Select(x => new { Value = x }).ToList();


                    //  MessageBox.Show(Convert.ToString(combinedString));


                    //textBox1.Text = i.ToString();

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Save as .csv File";
                    saveFileDialog.Filter = "csv files (*.csv)|*.csv";
                    saveFileDialog.FilterIndex = 2;

                    saveFileDialog.FileName = "ExportData.csv";


                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        if (saveFileDialog.FileName != "")
                        {

                            string filePath = saveFileDialog.FileName;

                            StreamWriter sw2 = new StreamWriter(filePath);

                            //sw2.WriteLine("\"GEnerated Id's\"");

                        //    StringBuilder builder = new StringBuilder();
                            //  listObj is model list having Data
                            foreach (var v in list)
                            {

                                sw2.WriteLine(string.Join(", ", v));

                            }

                            sw2.Close();

                        }
                    }










                    string module = comboBox3.SelectedItem.ToString();

                    string cust = comboBox4.SelectedItem.ToString();


                    SaveFileDialog saveFileDialogs = new SaveFileDialog();
                    saveFileDialogs.Title = "Save as .csv File";
                    saveFileDialogs.Filter = "csv files (*.csv)|*.csv";
                    saveFileDialogs.FilterIndex = 2;

                    saveFileDialogs.FileName = "ExportDataModule.csv";


                    if (saveFileDialogs.ShowDialog() == DialogResult.OK)
                    {

                        if (saveFileDialogs.FileName != "")
                        {

                            string filePath = saveFileDialogs.FileName;

                            StreamWriter sw2 = new StreamWriter(filePath);

                            sw2.WriteLine(" \'Date\',    \'Time\',    \'Module Number\', \'Generated Id's\',       \'Customer Name\'");

                            StringBuilder builder = new StringBuilder();
                            //  listObj is model list having Data

                            foreach (var v in list)
                            {
                                sw2.WriteLine(string.Join(", ",label5.Text, " "+module, "   "+ v, "    "+cust));

                            }

                            sw2.Close();

                        }
                    }


              //  }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 10)
                    e.Handled = true;
            }
        }
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button14_Click(this, new EventArgs());
            }
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button12_Click(this, new EventArgs());
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, new EventArgs());
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsLetterOrDigit) >= 15)
                    e.Handled = true;
            }
        }



        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

          //  only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsLetterOrDigit) >= 15)
                    e.Handled = true;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //  textBox1.Text = "";
            //    MessageBox.Show(Properties.Settings.Default.id, "saved data");
            Application.Exit();

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox1.Visible = false;
            groupBox6.Visible = false;
            groupBox4.Hide();
            groupBox3.Show();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != ""){

                if (comboBox1.Items.Contains(textBox2.Text))
                {
                    MessageBox.Show("Duplicate entry : Already number is saved");
                }
                if (textBox2.Text.Length < 4)
                {
                    MessageBox.Show("Invalid Firware Order");
                }
                else
                {


                    Properties.Settings.Default.combobox1.Clear();
                    comboBox1.Items.Add(textBox2.Text);

                    String firmware = textBox2.Text;
                    String revision = "00";
                    String count = "0";
                    Console.WriteLine("Enter Date");
                    string date = Console.ReadLine();
                    DateTime inputDate = DateTime.Now;
                    var d = inputDate;
                    CultureInfo cul = CultureInfo.CurrentCulture;

                    int weekNum = cul.Calendar.GetWeekOfYear(
                        d,
                        CalendarWeekRule.FirstFourDayWeek,
                        DayOfWeek.Monday);

                    int year = weekNum == 52 && d.Month == 1 ? d.Year - 1 : d.Year;

                    List<string> list = new List<string>();
                    string ioo = "0000000000000000000000";
                    long ddd = long.Parse(ioo);
                    long yyy = Convert.ToInt32(count);

                    for (i = ddd; i <= yyy; i++)
                    {

                        int j = 1;
                        string s = i.ToString().PadLeft(10, '0');


                        long dates = long.Parse(year.ToString() + weekNum.ToString());

                        string firm_rev = firmware.ToString() + revision.ToString();

                        //  aa = long.Parse(String.Format("{0}",dates,firm_rev,s.ToString()));
                        string number = string.Format("{0}{1}{2}", dates, firm_rev, s);

                        list.Add(number.ToString());
                        //   MessageBox.Show(Convert.ToString(random.Next(10, 20)));
                        //  MessageBox.Show(Convert.ToString(aa));

                    }

                    //  Properties.Settings.Default.firmware2.Clear();





                    //   Properties.Settings.Default.firmware2.Clear();
                    comboBox5.Items.Add(list.Last());

                    listView1.Items.Add(list.Last());

                    Properties.Settings.Default.firmware2.Add(list.Last());

                    Properties.Settings.Default.Save();

                    foreach (object itemd in comboBox1.Items)
                    {

                        Properties.Settings.Default.combobox1.Add(itemd.ToString());
                        Properties.Settings.Default.Save();

                    }
                    textBox2.Text = "";
                    MessageBox.Show("Firmware Added Successfully");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Firmware to Add");
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox3.Hide();
            groupBox4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
         groupBox2.Visible = false;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            label15.Hide();
            textBox8.Hide();
            save.Hide();
           
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedItem = null;
            groupBox1.Visible = false;
            groupBox2.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                if (comboBox2.Items.Contains(textBox3.Text))
                {
                    MessageBox.Show("Duplicate entry : Already number is saved");
                }
                if (textBox3.Text.Length < 2)
                {
                    MessageBox.Show("Revision should contains 2 numbers ");
                }
                else
                {
                    Properties.Settings.Default.combobox2.Clear();
                    comboBox2.Items.Add(textBox3.Text);
                    foreach (object item in comboBox2.Items)
                    {

                        Properties.Settings.Default.combobox2.Add(item.ToString());
                        Properties.Settings.Default.Save();
                    }
                    MessageBox.Show("Revision Added Successfully");
                    textBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please Enter Revision");
            }
            //string setting = Properties.Settings.Default.combobox2;
            //string[] comboRows = setting.Split('|');
            //Properties.Settings.Default.combobox2 = setting;
            //Properties.Settings.Default.Save();
            //ArrayList arraylist = new ArrayList(this.comboBox2.Items);
            //Properties.Settings.Default.combobox2 = arraylist;
            //Properties.Settings.Default.Save();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.idss);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                if (textBox4.Text == "no_passwordmspl")
                {
                    groupBox1.Show();
                    groupBox3.Hide();
                    groupBox2.Hide();
                    groupBox4.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
          else  {
                MessageBox.Show("Please Enter Password");
            }

              
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox3.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            textBox4.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "no_passwordmspl")
            {
                groupBox2.Show();
                groupBox4.Hide();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupBox4.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Properties.Settings.Default.combobox1.Clear();
                comboBox1.SelectedItem = textBox2.Text; 
                comboBox1.Items.Remove(textBox2.Text);
            

                foreach (object itemd in comboBox1.Items)
                {
                       Properties.Settings.Default.combobox1.Add(itemd.ToString());
                        Properties.Settings.Default.Save();
                                      
                    }
                textBox2.Text = "";
             

            }
            else
            {
                MessageBox.Show("Please Enter Firmware to Remove");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                Properties.Settings.Default.combobox2.Clear();
                comboBox2.SelectedItem = textBox3.Text;
                comboBox2.Items.Remove(textBox3.Text);


                foreach (object itemd in comboBox2.Items)
                {
                    Properties.Settings.Default.combobox2.Add(itemd.ToString());
                    Properties.Settings.Default.Save();

                }
                MessageBox.Show("Firmware Number Removed Successfully");
                textBox3.Text = "";


            }
            else
            {
                MessageBox.Show("Please Enter Firmware to Remove");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if(textBox5.Text != "")
            {
                if (textBox5.Text == "no_passwordmspl")
                {
                    groupBox2.Show();
                    groupBox1.Hide();
                    groupBox3.Hide();
                    groupBox4.Hide();
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
         else   {
                MessageBox.Show("Please Enter Password");
            }
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            groupBox4.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            groupBox5.Show();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox6.Hide();
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            groupBox5.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (comboBox3.Items.Contains(textBox6.Text))
                {
                    MessageBox.Show("Duplicate entry : Already Module number is saved");
                }
                else
                {
                    Regex r = new Regex("^[a-zA-Z0-9]*$");
                    if (!string.IsNullOrWhiteSpace(textBox6.Text) && textBox6.Text.Any(char.IsLetter) && textBox6.Text.Any(char.IsDigit) && textBox6.Text.Length >=8)
                    {
                        Properties.Settings.Default.module.Clear();
                        comboBox3.Items.Add(textBox6.Text);
                        foreach (object item in comboBox3.Items)
                        {

                            Properties.Settings.Default.module.Add(item.ToString());
                            Properties.Settings.Default.Save();
                        }
                        MessageBox.Show("Module Number Added Successfully");
                        textBox6.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Module number is not in correct format");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter Module Number");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                Properties.Settings.Default.module.Clear();
                textBox6.Text = comboBox3.SelectedItem.ToString();
                comboBox3.Items.Remove(textBox6.Text);


                foreach (object itemd in comboBox3.Items)
                {
                    Properties.Settings.Default.module.Add(itemd.ToString());
                    Properties.Settings.Default.Save();

                }
                MessageBox.Show("Module Number Removed Successfully");
                textBox6.Text = "";


            }
            else
            {
                MessageBox.Show("Please Enter Module Number to Remove");
            }
        }

      

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                if (comboBox4.Items.Contains(textBox7.Text))
                {
                    MessageBox.Show("Duplicate entry : Already Customer number is saved");
                }
                else
                {                
                   
                        Properties.Settings.Default.customer.Clear();
                        comboBox4.Items.Add(textBox7.Text);
                        foreach (object item in comboBox4.Items)
                        {

                            Properties.Settings.Default.customer.Add(item.ToString());
                            Properties.Settings.Default.Save();
                        }
                        MessageBox.Show("Customer Number Added Successfully");
                        textBox7.Text = "";
                  
                }
            }
            else
            {
                MessageBox.Show("Please Enter Customer Number");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            groupBox6.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            groupBox6.Show();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                Properties.Settings.Default.customer.Clear();
                textBox7.Text = comboBox4.SelectedItem.ToString();
                comboBox4.Items.Remove(textBox7.Text);


                foreach (object itemd in comboBox4.Items)
                {
                    Properties.Settings.Default.customer.Add(itemd.ToString());
                    Properties.Settings.Default.Save();

                }
                MessageBox.Show("Customer Number Removed Successfully");
                textBox7.Text = "";


            }
            else
            {
                MessageBox.Show("Please Enter Customer Number to Remove");
            }
        }

          
      
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

            textBox3.Text = comboBox2.SelectedItem.ToString();
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox7.Text = comboBox4.SelectedItem.ToString();
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox6.Text = comboBox3.SelectedItem.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
        }

   

      

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            label15.Visible = true;
            textBox8.Visible = true;
            save.Visible = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 15)
                    e.Handled = true;
            }
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsLetterOrDigit) >= 15 )
                    e.Handled = true;
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 15)
                    e.Handled = true;
            }
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsLetterOrDigit) >= 15)
                    e.Handled = true;
            }
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 4)
                    e.Handled = true;
            }
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsLetterOrDigit) >= 4)
                    e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 2)
                    e.Handled = true;
            }
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsLetterOrDigit) >= 2)
                    e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 4 )
                    e.Handled = true;
            }
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                //Count the digits already in the text.  I'm using linq:
                if ((sender as TextBox).Text.Count(Char.IsLetterOrDigit) >= 4)
                    e.Handled = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

            if (textBox8.Text != "")
            {

                if (comboBox1.Items.Contains(textBox8.Text))
                {
                    MessageBox.Show("Duplicate entry : Already number is saved");
                }
                else
                {
                    
                    foreach(object yu in Properties.Settings.Default.firmware2)
                    {
                        string jk = yu.ToString();
                        if (jk.Contains(comboBox1.SelectedItem.ToString()))
                        {
                            Properties.Settings.Default.firmware2.Remove(jk);
                            Properties.Settings.Default.combobox1.Clear();
                            comboBox1.Items.Add(textBox8.Text);

                            string firmware = textBox8.Text;
                            String count = "0";
                            string oi = jk.Substring(10, 2);
                            string io = jk.Substring(12, 10);
                            int decValue = int.Parse(io, System.Globalization.NumberStyles.HexNumber);
                            long dd = Convert.ToInt64(decValue) ;
                            long yy = Convert.ToInt32(count) + dd;


                            DateTime inputDate = DateTime.Now;
                            var d = inputDate;
                            CultureInfo cul = CultureInfo.CurrentCulture;

                            int weekNum = cul.Calendar.GetWeekOfYear(
                                d,
                                CalendarWeekRule.FirstFourDayWeek,
                                DayOfWeek.Monday);

                            int year = weekNum == 52 && d.Month == 1 ? d.Year - 1 : d.Year;

                            List<string> list = new List<string>();
                            

                            for (i = dd; i <= yy; i++)
                            {

                                int j = 1;
                                // string s = i.ToString().PadLeft(10, '0');


                                string ss = i.ToString().PadLeft(10, '0');

                                string outputHex = int.Parse(ss).ToString("X");
                                string s = outputHex.PadLeft(10, '0');

                                long dates = long.Parse(year.ToString() + weekNum.ToString());
                                string firm_rev = firmware.ToString() + oi.ToString();

                                //  aa = long.Parse(String.Format("{0}",dates,firm_rev,s.ToString()));
                                string number = string.Format("{0}{1}{2}", dates, firm_rev, s);

                                list.Add(number.ToString());






                                //   Properties.Settings.Default.firmware2.Clear();
                                comboBox5.Items.Add(list.Last());

                                listView1.Items.Add(list.Last());

                                Properties.Settings.Default.firmware2.Add(list.Last());

                                Properties.Settings.Default.Save();
                                comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
                                

                            }
                            foreach (object itemd in comboBox1.Items)
                            {

                                Properties.Settings.Default.combobox1.Add(itemd.ToString());
                                Properties.Settings.Default.Save();

                            }
                            textBox8.Text = "";
                            save.Visible = false;
                            label15.Visible = false;
                            textBox8.Visible = false;
                            break;

                        }
                    }
                                       


                   
                }
            }
            else
            {
                MessageBox.Show("Please Enter New Firmware to Add");
            }

        }
    }
}
