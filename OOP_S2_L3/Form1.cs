using System.ComponentModel;
using System.Data.Common;

namespace OOP_S2_L3
{
    public partial class MailingAdressesDemo : Form
    {
        List<MailingAdress> mailingAdresses = new List<MailingAdress>();
        
        public MailingAdressesDemo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             var bindingList = new BindingList<MailingAdress>(mailingAdresses);

             mailingAdresses.Add(new MailingAdress());
             mailingAdresses.Add(new MailingAdress("Ukraine", 79069, "Kyivskya", "Kyiv", "Bankova", 43, "Dead Inside Inc."));
             mailingAdresses.Add(new MailingAdress("Ukraine", 79012, "Lvivskya", "Lviv", "Sadova", 2, "SoftServe"));
             mailingAdresses.Add(new MailingAdress("Ukraine", 79012, "Kharkivska", "Kharkiv", "V. Velykogo", 5, "NIX"));
            
             dataGridView1.DataSource = bindingList;

             dataGridView1.AllowUserToAddRows = true;
             dataGridView1.AllowUserToDeleteRows = true;

             dataGridView1.Columns[0].HeaderText = "Country";
             dataGridView1.Columns[1].HeaderText = "Postal code";
             dataGridView1.Columns[2].HeaderText = "Area";
             dataGridView1.Columns[3].HeaderText = "City";
             dataGridView1.Columns[4].HeaderText = "Street name";
             dataGridView1.Columns[5].HeaderText = "Street number";
             dataGridView1.Columns[6].HeaderText = "Company name";

             dataGridView1.Columns[1].Width = 140;
             dataGridView1.Columns[4].Width = 140;
             dataGridView1.Columns[5].Width = 140;
             dataGridView1.Columns[6].Width = 140;

             dataGridView1.Columns[1].ValueType = typeof(int);
             dataGridView1.Columns[5].ValueType = typeof(int);

             dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
             dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

             dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
             dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is ArgumentNullException)
            {
                MessageBox.Show("String value cannot be empty consist of only blank spaces!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.Exception is ArgumentOutOfRangeException)
            {
                MessageBox.Show("Number cannot be less than or equal to zero!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.Exception is System.FormatException)
            {
                MessageBox.Show("Input must be integer value, not string or (blank spaces)!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}