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
using System.Diagnostics;
using System.IO;


namespace LabRab1SAPRKS
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        SqlConnection myConnection = new SqlConnection("server = DESKTOP-60KJVUB;" +
            "Trusted_Connection = yes;"+
            "database=study2020;"+
            @"User ID=DESKTOP-60KJVUB\Елена;"+
            "connection timeout=30");

        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                MessageBox.Show("server = DESKTOP-60KJVUB подключен!");
            }
            catch (SqlException esql)
            {
                MessageBox.Show("Не подключено!" + esql.Message);
            }
        }

        private void tShow() 
        {
            var table = new DataTable();
            string query = "SELECT * FROM study2020.dbo.Table_1";
            using (var da = new SqlDataAdapter(query, myConnection))
            {
                da.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[2].Visible = false;
            }
        }
        private void ShowTheTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tShow();
        }

        private void AddRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string num = "Нет PDF";
            Random rnd = new Random();
            int rnd_to_base = rnd.Next(100000,999999);
            string tmp = "('" + num + "'" + "," + rnd_to_base.ToString() + ")";
            var table = new DataTable();
            string query = "INSERT INTO study2020.dbo.Table_1(Name, ID) values" + tmp;
            using (var da = new SqlDataAdapter(query,myConnection))
            {
                da.Fill(table);
            }

            tShow();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
        }

        private void DeleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int curr = dataGridView1.CurrentCell.RowIndex;
            string str = dataGridView1.Rows[curr].Cells[1].Value.ToString();

            var table = new DataTable();
            string query = "DELETE from study2020.dbo.Table_1 where ID =" + "'" + str + "'";
            using (var da = new SqlDataAdapter(query, myConnection))
            {
                da.Fill(table);
            }

            tShow();

            if (dataGridView1.RowCount > curr)
                dataGridView1.CurrentCell = dataGridView1.Rows[curr].Cells[0];

        }

        private void CreatePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = ".PDF|*.pdf" }; //Открыть пдф
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = File.OpenRead(ofd.FileName);
                MemoryStream ms = new MemoryStream();
                fs.CopyTo(ms); // Записываем в память пдф из файла
                //получаем имя файла без пути и расширения
                string nameOnly = Path.GetFileNameWithoutExtension(ofd.FileName);
          
                if (nameOnly.Length >= 40)
                    nameOnly = nameOnly.Substring(0, 39);

                //используем случайное число в качестве уникального индекса
                Random rnd = new Random();
                int rnd_to_base = rnd.Next(100000, 999999);
                string query = "INSERT INTO study2020.dbo.Table_1 VALUES ('" + nameOnly+
                    "',"+ rnd_to_base.ToString()+",@pdf_file)";
                
                using (SqlCommand querySavePDF = new SqlCommand(query))
                {
                    querySavePDF.Connection = myConnection;
                    querySavePDF.Parameters.AddWithValue("@pdf_file", SqlDbType.VarBinary).Value=ms.ToArray();
                    //Memory Stream записываем в поле Binary View таблицы Table_1 как двоичное значение
                    querySavePDF.ExecuteNonQuery();
                }

                tShow();
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];

            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var table = new DataTable();
            string filePath = @"F:\List\here.pdf";
            string query = "select * from study2020.dbo.Table_1";

            using (var da = new SqlDataAdapter(query, myConnection))
            {
                da.Fill(table);

                if (table.Rows[dataGridView1.CurrentCell.RowIndex][2].ToString()=="")
                {
                    MessageBox.Show("Нет PDF!");
                    return;
                }

                byte[] bytes = (byte[])table.Rows[dataGridView1.CurrentCell.RowIndex][2];
                File.WriteAllBytes(filePath, bytes); // записываем массив байт в файл filePath
                Process.Start(filePath); //Просматриваем файл
            }

        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            string query = "TRUNCATE TABLE study2020.dbo.Table_1";
            using (var da = new SqlDataAdapter(query, myConnection))
            {
                da.Fill(table);
            }

            tShow();
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
            this.Close();
        }
    }
}
