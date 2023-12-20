using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Globalization;

using Lab05.model;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace Lab05
{
    public partial class Form1 : Form
    {
        List<Laptop> laptops = new List<Laptop>();
        public int loadData = 0;
        static string ProjectPath=Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string excelFilePath = ProjectPath + "//Data//LaptopList2.xls";
        string connectSQL = "Server=DESKTOP-VV85LA6\\TINGHOW;Database=ManagerLaptop;Connection Timeout=60;User Id=sa; PWD=tienhao1234";
        int indexCurrentLaptop = 0;
        DataTable data;
        BindingSource bingding=new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Laptop bi=new Laptop();
            if (indexCurrentLaptop >= 0)
            {
                bi = laptops[indexCurrentLaptop];
            }
            DialogResult result=MessageBox.Show("Do You Want To Delete LapTop"+bi.LaptopID,"Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                this.laptops.RemoveAt(indexCurrentLaptop);
                this.bingding.RemoveAt(indexCurrentLaptop);
                this.data.AcceptChanges();


            }
            MessageBox.Show("finish Delete");

        }
        public int readDataFromFile(List<Laptop> listsp,string  excelFilePath,int colCount)
        {
            Excel.Application xlApp= new Excel.Application();
            Excel.Workbook xlwordbook = xlApp.Workbooks.Open(excelFilePath);
            Excel.Worksheet xlworksheet = xlwordbook.Sheets[1];
            Excel.Range xlrage = xlworksheet.UsedRange;
            xlworksheet.Rows.ClearFormats();
            xlworksheet.Columns.ClearFormats();
            int rowCount=xlworksheet.UsedRange.Rows.Count;
            int numphone = 0;
            string LaptopID = "", LaptopName = "", LaptopType = "", Processor = "", HDD = "", RAM = "", ImageName = "";
            DateTime ProductDate=DateTime.Now;
            double Price = 0;
            for (int i=2; i<=rowCount; i++)
            {
                for(int j=1; j<=colCount; j++)
                {
                    switch (j)
                    {
                        case 1:
                            LaptopID = xlrage.Cells[i, j].Value2.ToString();
                            break;
                        case 2:
                            LaptopName = xlrage.Cells[i,j].Value2.ToString();
                            break;
                        case 3:
                            LaptopType = xlrage.Cells[i,j].Value2.ToString();
                            break;
                        case 4:
                            ProductDate = DateTime.ParseExact(xlrage.Cells[i,j].Value2.ToString(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
                            break;
                        case 5:
                            Processor = xlrage.Cells[i, j].Value2.ToString();
                            break;
                        case 6:
                            HDD = xlrage.Cells[i, j].Value2.ToString();
                            break;
                        case 7:
                            RAM = xlrage.Cells[i, j].Value2.ToString();
                            break;
                        case 8:
                            Price = double.Parse(xlrage.Cells[i, j].Value2.ToString());
                            break;
                        case 9:
                            ImageName= xlrage.Cells[i, j].Value2.ToString();
                            break;
                    }
                }
                listsp.Add(new Laptop(LaptopID,LaptopName,LaptopType,ProductDate, Processor, HDD,RAM,Price,ImageName));
                numphone += 1;
            }
            xlwordbook.Close(false);
            xlApp.Quit();
            MessageBox.Show("Load Data From Excel: " + (rowCount - 1) + "Record");
            return rowCount - 1;
        }
        public string tostring()
        {
            string s = "";
            foreach(var x in this.laptops){
                s += x.ToString() + "\n";
            }
            return s;
        }
        private void btn_LoadExcel(object sender, EventArgs e)
        {
            this.loadData = 1;
            data=new DataTable();
            this.laptops.Clear();
            int NumdataRow = this.readDataFromFile(laptops, excelFilePath, 9);
            data.Columns.Add("LapTopID");
            data.Columns.Add("LapTopName");
            data.Columns.Add("LaptopType");
            data.Columns.Add("ProductDate");
            data.Columns.Add("Processor");
            data.Columns.Add("HDD");
            data.Columns.Add("RAM");
            data.Columns.Add("Price");
            DataRow newrow;
            foreach(var bi in laptops)
            {
                newrow=data.NewRow();
                newrow["LapTopID"] = bi.LaptopID;
                newrow["LapTopName"] = bi.LaptopName;
                newrow["LaptopType"]=bi.LaptopType;
                newrow["ProductDate"] = bi.ProductDate.ToString("dd/MM/yyyy HH:mm:ss");
                newrow["Processor"] = bi.Processor;
                newrow["HDD"] = bi.HDD;
                newrow["RAM"] = bi.RAM;
                newrow["Price"] = bi.Price;
                data.Rows.Add(newrow);
                data.AcceptChanges();
            }
            bingding.AllowNew = true;
            bingding.DataSource = data;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = bingding;
        }

        private void datagridview_selectionchange(object sender, EventArgs e)
        {
            if(this.laptops.Count == 0||this.data.Rows.Count==0) {
                return;
            }
            else if (this.dataGridView1.CurrentRow.Index != null) {
                this.indexCurrentLaptop = this.dataGridView1.CurrentRow.Index;
                if (indexCurrentLaptop >= 0 && indexCurrentLaptop < this.laptops.Count)
                {
                    string filetest = ProjectPath + "\\Data\\" + this.laptops.ElementAt(indexCurrentLaptop).ImageName;
                    if (File.Exists(filetest))
                    {
                        this.pictureBoxLaptop.Image = Image.FromFile(ProjectPath + "\\Data\\" + this.laptops.ElementAt(indexCurrentLaptop).ImageName);
                    }
                    else
                    {
                        this.pictureBoxLaptop.Image = Lab05.Properties.Resources.the_best_lenovo_laptop_for_students;
                    }
                }
            }
        }
        public int readDataFormSQL(List<Laptop>listsp)
        {
            string query = "select* from laptop";
            try {
                using (SqlConnection connection = new SqlConnection(this.connectSQL))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listsp.Add(new Laptop(
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetDateTime(3),
                                reader.GetString(4),
                                reader.GetString(5),
                                reader.GetString(6),
                                reader.GetDouble(7),
                                reader.GetString(8)));
                            }
                        }
                    }
                    MessageBox.Show("Load Data From SQL: " + listsp.Count + "Record");
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Can't Connection with SQL"+ex.Message);
            }
            return listsp.Count;
        }

        private void btn_DataSQL(object sender, EventArgs e)
        {
            this.loadData = 2;
            data = new DataTable();
            this.laptops.Clear();
            int x = this.readDataFormSQL(this.laptops);
            data.Columns.Add("LapTopID");
            data.Columns.Add("LapTopName");
            data.Columns.Add("LaptopType");
            data.Columns.Add("ProductDate");
            data.Columns.Add("Processor");
            data.Columns.Add("HDD");
            data.Columns.Add("RAM");
            data.Columns.Add("Price");
            DataRow newrow;
            foreach (var bi in laptops)
            {
                newrow = data.NewRow();
                newrow["LapTopID"] = bi.LaptopID;
                newrow["LapTopName"] = bi.LaptopName;
                newrow["LaptopType"] = bi.LaptopType;
                newrow["ProductDate"] = bi.ProductDate.ToString("yyyy-MM-dd HH:mm:ss");
                newrow["Processor"] = bi.Processor;
                newrow["HDD"] = bi.HDD;
                newrow["RAM"] = bi.RAM;
                newrow["Price"] = bi.Price;
                data.Rows.Add(newrow);
                data.AcceptChanges();
            }
            bingding.AllowNew = true;
            bingding.DataSource = data;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = bingding;
        }

        private void datagridview_editingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnPrice_Keypess);
            if(this.dataGridView1.CurrentCell.ColumnIndex==8)
            {
                TextBox tb = e.Control as TextBox;
                if(tb!=null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnPrice_Keypess);
                }
            }
        }

        private void ColumnPrice_Keypess(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_add(object sender, EventArgs e)
        {
            Laptop bi=new Laptop("Not Assigned", "Not Assigned", "Not Assigned",DateTime.Now, "Not Assigned", "Not Assigned", "Not Assigned",0, "Not Assigned");
            laptops.Add(bi);
            DataRow newrow;
            newrow = data.NewRow();
            newrow["LapTopID"] = bi.LaptopID;
            newrow["LapTopName"] = bi.LaptopName;
            newrow["LaptopType"] = bi.LaptopType;
            newrow["ProductDate"] = bi.ProductDate;
            newrow["Processor"] = bi.Processor;
            newrow["HDD"] = bi.HDD;
            newrow["RAM"] = bi.RAM;
            newrow["Price"] = bi.Price;
            data.Rows.Add(newrow);
            data.AcceptChanges();
            MessageBox.Show("Finish adding");
        }

        private void btn_update(object sender, EventArgs e)
        {
            DataRow row;
            for(int i=0;i<data.Rows.Count;i++)
            {
                row= data.Rows[i];
                double x = 0;
                bool check = double.TryParse(row["Price"].ToString(), out x);
                if (!check)
                {
                    MessageBox.Show("price row:"+ i +"not Digint");
                    continue;
                    
                }
                else {
                    this.laptops[i].LaptopID = row["LapTopID"].ToString();
                    this.laptops[i].LaptopName = row["LapTopName"].ToString();
                    this.laptops[i].LaptopType = row["LaptopType"].ToString();
                    this.laptops[i].ProductDate = DateTime.ParseExact(row["ProductDate"].ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    this.laptops[i].Processor = row["Processor"].ToString();
                    this.laptops[i].HDD = row["HDD"].ToString();
                    this.laptops[i].RAM = row["RAM"].ToString();
                    this.laptops[i].Price = x;
                }
            }
            MessageBox.Show("finish update");
        }

        private void buttonUpDateData_Click(object sender, EventArgs e)
        {
            if(this.loadData==1)
            {
                this.updateExcel();
            }
            else if(this.loadData==2)
            {
                this.updateSQL();
            }
        }
        public void updateExcel() {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWordbook = xlApp.Workbooks.Open(excelFilePath);
            Excel._Worksheet xlWorksheet = xlWordbook.Sheets[1];
            Excel.Range xlrage;
            int row = 2; // Assuming you want to start writing from the second row (row 1 may contain headers)

            foreach (Laptop sp in this.laptops)
            {
                xlWorksheet.Cells[row, 1].Value = sp.LaptopID.ToString();
                xlWorksheet.Cells[row, 2].Value = sp.LaptopName.ToString();
                xlWorksheet.Cells[row, 3].Value = sp.LaptopType.ToString();
                xlWorksheet.Cells[row, 4].Value = sp.ProductDate.ToString("dd/MM/yyyy");
                xlWorksheet.Cells[row, 5].Value = sp.Processor.ToString();
                xlWorksheet.Cells[row, 6].Value = sp.HDD.ToString();
                xlWorksheet.Cells[row, 7].Value = sp.RAM.ToString();
                xlWorksheet.Cells[row, 8].Value = sp.Price.ToString();
                xlWorksheet.Cells[row, 9].Value = sp.ImageName.ToString();
                row++;
            }

            // Save and close Excel workbook
            xlWordbook.Save();
            xlWordbook.Close();
            xlApp.Quit();
            MessageBox.Show("Update finish");
        }
        public void updateSQL()
        {
            try {
                string query = "truncate table laptop";
                using (SqlConnection connection = new SqlConnection(this.connectSQL))
                {
                    connection.Open();
                    using(SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText= query;
                        command.ExecuteNonQuery();
                        query = @"INSERT INTO Laptop (LapTopID, LapTopName, LaptopType, ProductDate, Processor, HDD, RAM, Price, ImageName) " +
                               @"VALUES (@LapTopID, @LapTopName, @LaptopType, @ProductDate, @Processor, @HDD, @RAM, @Price, @ImageName)";
                        command.CommandText = query;
                        command.Parameters.Add(new SqlParameter("@LapTopID",SqlDbType.NVarChar));
                        command.Parameters.Add(new SqlParameter("@LapTopName", SqlDbType.NVarChar));
                        command.Parameters.Add(new SqlParameter("@LaptopType", SqlDbType.NVarChar));
                        command.Parameters.Add(new SqlParameter("@ProductDate", SqlDbType.DateTime));
                        command.Parameters.Add(new SqlParameter("@Processor", SqlDbType.NVarChar));
                        command.Parameters.Add(new SqlParameter("@HDD", SqlDbType.NVarChar));
                        command.Parameters.Add(new SqlParameter("@RAM", SqlDbType.NVarChar));
                        command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float));
                        command.Parameters.Add(new SqlParameter("@ImageName", SqlDbType.NVarChar));
                        foreach(Laptop x in laptops)
                        {
                            command.Parameters[0].Value = x.LaptopID;
                            command.Parameters[1].Value = x.LaptopName;
                            command.Parameters[2].Value = x.LaptopType;
                            command.Parameters[3].Value = x.ProductDate.ToString("yyyy-MM-dd");
                            command.Parameters[4].Value = x.Processor;
                            command.Parameters[5].Value = x.HDD;
                            command.Parameters[6].Value = x.RAM;
                            command.Parameters[7].Value = x.Price;
                            command.Parameters[8].Value = x.ImageName;
                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
            }catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Update finish");
        }
    }

}
