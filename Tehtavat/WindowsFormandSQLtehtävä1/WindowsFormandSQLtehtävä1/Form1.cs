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

namespace WindowsFormandSQLtehtävä1
{
    public partial class Form1 : Form
    {
        string setON= " SET IDENTITY_INSERT [NimiTable] ON ";
        string setOF = " SET IDENTITY_INSERT [NimiTable] OFF ";
        string setONRyhmä = " SET IDENTITY_INSERT [Ryhmä] ON ";
        string setOFFRyhmä = " SET IDENTITY_INSERT [Ryhmä] OFF ";
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Nimi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        int button = 0;
        int IDDelete = 0;
        int MaxID=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Itse_Click(object sender, EventArgs e)
        {
            button = 1;
            ConectionDataBase();
        
        }
        public void ConectionDataBase()
        {
            SqlConnection MyConection = new SqlConnection();
            MyConection.ConnectionString = connectionString;
            try
            {
                string Text;
                
                Text = this.textBox2.Text;
                MyConection.Open();
                if (button == 99)
                {
                    MessageBox.Show(this.comboBox1.Text);
                }
                if (button == 2)
                {
                    SqlCommand myCommand = new SqlCommand("select max(ID)"+" from [NimiTable]",MyConection);
                    try
                    {
                        MaxID = Convert.ToInt32(myCommand.ExecuteScalar());
                    }
                    catch
                    {
                        MaxID = 0;
                    }
                   
                    MaxID++;

                }
                if (button == 2)
                {
                    try
                    {
                        SqlCommand myCommand = new SqlCommand(setON+" INSERT INTO [NimiTable] (ID,Nimi)" + "Values('" + MaxID + "','" + Text + "');" +setOF+ setONRyhmä+ "INSERT INTO [Ryhmä] (ID,RyhmäNimi)" + "Values('" + MaxID +"','"+this.comboBox1.Text+"'); "+ setOFFRyhmä, MyConection);
                        myCommand.ExecuteNonQuery();


                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                    
                }
                if (button == 3)
                {
                    this.DataBase.Rows.Clear();
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand("select * from [NimiTable]", MyConection);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        DataBase.Rows.Add(myReader["ID"].ToString(), myReader["Nimi"].ToString());
                        
                    }
                }
                if (button == 4)
                {
                    string Convert1 = this.IDdelete.Text;
                    
                    this.DataBase.Rows.Clear();
                    IDDelete = Convert.ToInt32(Convert1);
                    SqlCommand myCommand = new SqlCommand("DELETE FROM [NimiTable]"+"WHERE ID='"+IDDelete+"';DELETE FROM [Ryhmä]"+ "WHERE ID='" + IDDelete + "';", MyConection);
                    myCommand.ExecuteNonQuery();
                }
                try
                {
                    MyConection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button = 2;
            ConectionDataBase();
        }

        private void Itse_Click_1(object sender, EventArgs e)
        {
            button = 3;
            ConectionDataBase();
        }

        private void Poistu_Click(object sender, EventArgs e)
        {
            button = 4;
            ConectionDataBase();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            button = 99;
            ConectionDataBase();
        }
    }
}
