using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Prog_Kval : Form
    { 
        const string conStr = "Data Source=DESKTOP-C2SNCN5\\SQLEXPRESS; Initial Catalog=KvalDB; Integrated Security=True";

        SqlConnection con = new SqlConnection(conStr);
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public Prog_Kval()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            con.Open();

            table.Clear();
            DGV.DataSource = table;
            adapter = new SqlDataAdapter("SELECT * FROM dbo.TableDog",con);
            adapter.Fill(table);

            con.Close();

            DGV.Columns[0].HeaderText = "ID";

            DGV.Columns[1].HeaderText = "Name";
            DGV.Columns[2].HeaderText = "Price";
            DGV.Columns[3].HeaderText = "Value";
            DGV.Columns[4].HeaderText = "Unit";


            DGV.MultiSelect = false;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.SelectionChanged += DGV_SelectionChanged;
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try {
                command.CommandText = $"INSERT INTO dbo.TableDog VALUES(" +
                $"'{textBoxNAME.Text}'," +
                $"'{Convert.ToInt32(textBoxVAL.Text)}'," +
                $"'{textBoxUNIT.Text}'," +
                $"'{Convert.ToInt32(textBoxPRICE.Text)}')";

                con.Open();
                command.Connection = con;
                command.ExecuteNonQuery();
                con.Close();

                InitGrid();
            
            }
            catch (Exception ex) { MessageBox.Show("Для добавления записи заполните все поля"); } 
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            try
            {
                var idDel = DGV.SelectedRows[0].Cells[0].Value.ToString();
                command.CommandText = $"DELETE FROM dbo.TableDog WHERE id='{Convert.ToInt32(idDel)}'";

                con.Open();
                command.Connection = con;
                command.ExecuteNonQuery();
                con.Close();

                InitGrid();
            }
            catch(Exception ex) { MessageBox.Show("Запись не хочет удаляться"); }
        }

        private void buttonUPD_Click(object sender, EventArgs e)
        {
            try
            {
                var idUpd = DGV.SelectedRows[0].Cells[0].Value.ToString();
                command.CommandText = $"UPDATE dbo.TableDog SET " +
                    $"Product='{textBoxNAME.Text}'," +
                    $"kolvo='{Convert.ToInt32(textBoxVAL.Text)}'," +
                    $"unit='{textBoxUNIT.Text}'," +
                    $"price='{Convert.ToInt32(textBoxPRICE.Text)}'" +
                    $" WHERE id='{Convert.ToInt32(idUpd)}'";

                con.Open();
                command.Connection = con;
                command.ExecuteNonQuery();
                con.Close();

                InitGrid();
            }
            catch(Exception ex) { MessageBox.Show("Запись не хочет обновляться \n Все поля заполнены?"); }
        }
        
        private void textBoxSEARCH_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = table;
            bs.Filter = "Product" + " like '%" + textBoxSEARCH.Text + "%'";
            DGV.DataSource = bs;
            
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count == 1)
            {
                textBoxNAME.Text = DGV.SelectedRows[0].Cells[1].Value.ToString();
                textBoxVAL.Text = DGV.SelectedRows[0].Cells[2].Value.ToString();
                textBoxUNIT.Text = DGV.SelectedRows[0].Cells[3].Value.ToString();
                textBoxPRICE.Text = DGV.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
        
    }
}
