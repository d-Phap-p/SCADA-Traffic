using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using MySql.Data.MySqlClient;

namespace SCADAdengiaothong
{
    public partial class Form1 : Form
    {
        MySqlConnection Conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Database = time_value; UId = root; Pwd = 123456; Pooling=false;Character Set=utf8";
        string query_select = "SELECT * FROM timevalue_datetime";
        public Form1()
        {
            InitializeComponent();
        }
        Plc PLCcomm = new Plc(CpuType.S71200, "192.168.1.150", 0, 1);// khoi tao PLC
        byte[] Q = new byte[1];
        byte[] M = new byte[3];

        private void Form1_Load(object sender, EventArgs e)
        {
            PLCcomm.Open();
            CHANGE.Visible = false;
            if (PLCcomm.IsConnected == true)
            {
                MessageBox.Show("Connect Successful", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = true;
                timer1.Interval = 1000;
            }
            else
                MessageBox.Show("Connect Failure", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DateTimetxt.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                adap = new MySqlDataAdapter(query_select, Conn);
                cmd = new MySqlCommandBuilder(adap);
                mytable = new DataTable();
                adap.Fill(mytable);
                Conn.Close();
                dataGridView1.DataSource = mytable;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Connect failure MySQL", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRUN_Click(object sender, EventArgs e)
        {
            PLCcomm.Write("M10.0", 1);
            PLCcomm.Write("M10.0", 0);
        }

        private void buttonSTOP_Click(object sender, EventArgs e)
        {
            PLCcomm.Write("M10.2", 1);
            PLCcomm.Write("M10.2", 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PLCcomm.IsConnected == true)
            {
                Q = PLCcomm.ReadBytes(DataType.Output, 0, 0, 1);
                if (Q[0].SelectBit(6) == true)
                {
                    RunSystem.DiscreteValue1 = true;
                    RunSystem.DiscreteValue2 = false;
                }
                else
                {
                    RunSystem.DiscreteValue2 = true;
                    RunSystem.DiscreteValue1 = false;
                }

                if (Q[0].SelectBit(0) == true)
                {
                    Agreen.DiscreteValue1 = true;
                    Agreen.DiscreteValue2 = false;
                    AgIO.Visible = true;
                }
                else
                {
                    Agreen.DiscreteValue2 = true;
                    Agreen.DiscreteValue1 = false;
                    AgIO.Visible = false;
                }

                if (Q[0].SelectBit(2) == true)
                {
                    Ayellow.DiscreteValue1 = true;
                    Ayellow.DiscreteValue2 = false;
                    AyIO.Visible = true;
                }
                else
                {
                    Ayellow.DiscreteValue2 = true;
                    Ayellow.DiscreteValue1 = false;
                    AyIO.Visible = false;
                }

                if (Q[0].SelectBit(1) == true)
                {
                    Ared.DiscreteValue1 = true;
                    Ared.DiscreteValue2 = false;
                    ArIO.Visible = true;
                }
                else
                {
                    Ared.DiscreteValue2 = true;
                    Ared.DiscreteValue1 = false;
                    ArIO.Visible = false;
                }

                if (Q[0].SelectBit(3) == true)
                {
                    Bgreen.DiscreteValue1 = true;
                    Bgreen.DiscreteValue2 = false;
                    BgIO.Visible = true;
                }
                else
                {
                    Bgreen.DiscreteValue2 = true;
                    Bgreen.DiscreteValue1 = false;
                    BgIO.Visible = false;
                }

                if (Q[0].SelectBit(4) == true)
                {
                    Bred.DiscreteValue1 = true;
                    Bred.DiscreteValue2 = false;
                    BrIO.Visible = true;
                }
                else
                {
                    Bred.DiscreteValue2 = true;
                    Bred.DiscreteValue1 = false;
                    BrIO.Visible = false;
                }

                if (Q[0].SelectBit(5) == true)
                {
                    Byellow.DiscreteValue1 = true;
                    Byellow.DiscreteValue2 = false;
                    ByIO.Visible = true;
                }
                else
                {
                    Byellow.DiscreteValue2 = true;
                    Byellow.DiscreteValue1 = false;
                    ByIO.Visible = false;
                }

                AgIO.Text = PLCcomm.Read("MW118").ToString();
                AyIO.Text = PLCcomm.Read("MW122").ToString();
                ArIO.Text = PLCcomm.Read("MW120").ToString();
                BgIO.Text = PLCcomm.Read("MW124").ToString();
                ByIO.Text = PLCcomm.Read("MW128").ToString();
                BrIO.Text = PLCcomm.Read("MW126").ToString();
                
                M = PLCcomm.ReadBytes(DataType.Memory, 0, 0, 3);
                if (M[2].SelectBit(1) == true)
                {
                    GettoHMI.DiscreteValue1 = true;
                    GettoHMI.DiscreteValue2 = false;

                    GREENtext.Text = PLCcomm.Read("MW100").ToString();
                    REDtext.Text = PLCcomm.Read("MW102").ToString();
                    YELLOWtext.Text = PLCcomm.Read("MW104").ToString();

                    Conn.Open();
                    PLCcomm.Write("MW104", null);
                    string query_insert = "INSERT INTO timevalue_datetime (`NHANH A&B_RED`, `NHANH A&B_GREEN`, `NHANH A&B_YELLOW`, `DATE_TIME`) VALUES ('" + REDtext.Text + "','" + GREENtext.Text + "','" + YELLOWtext.Text + "','" + DateTimetxt.Text + "')";
                    MySqlCommand command = new MySqlCommand(query_insert, Conn);
                    command.ExecuteNonQuery();
                    Conn.Close();
                    Read_Data();

                }
                else
                {
                    GettoHMI.DiscreteValue2 = true;
                    GettoHMI.DiscreteValue1 = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHANGE.Visible = true;
            PLCcomm.Write("MW104", null);
            GREENtext.Text = PLCcomm.Read("MW100").ToString();
            REDtext.Text = PLCcomm.Read("MW102").ToString();
            YELLOWtext.Text = PLCcomm.Read("MW104").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CHANGE.Visible = false;
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            PLCcomm.Write("MW104", null);
            PLCcomm.Write("MW100", int.Parse(GREENtext.Text));
            PLCcomm.Write("MW102", int.Parse(REDtext.Text));
            YELLOWtext.Text = PLCcomm.Read("MW104").ToString();

            GREENtext.Text = PLCcomm.Read("MW100").ToString();
            REDtext.Text = PLCcomm.Read("MW102").ToString();
            YELLOWtext.Text = PLCcomm.Read("MW104").ToString();

            Conn.Open();
            PLCcomm.Write("MW104", null);
            string query_insert = "INSERT INTO timevalue_datetime (`NHANH A&B_RED`, `NHANH A&B_GREEN`, `NHANH A&B_YELLOW`, `DATE_TIME`) VALUES ('" + REDtext.Text + "','" + GREENtext.Text + "','" + YELLOWtext.Text + "','" + DateTimetxt.Text + "')";
            MySqlCommand command = new MySqlCommand(query_insert, Conn);
            command.ExecuteNonQuery();
            Conn.Close();
            Read_Data();
        }
        private void Read_Data()
        {
            Conn.Open();
            PLCcomm.Write("MW104", null);
            adap = new MySqlDataAdapter(query_select, Conn);
            cmd = new MySqlCommandBuilder(adap);
            mytable = new DataTable();
            adap.Fill(mytable);
            Conn.Close();
            dataGridView1.DataSource = mytable;
        }
    }
}
