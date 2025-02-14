﻿using APP_MU.Database;
using APP_MU.DataBase;
using APP_MU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_MU.Forms.Administrator
{
    public partial class Admin_main : Form
    {
        public Admin_main()
        {
            InitializeComponent();
        }

        private void Admin_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Main main = new();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Accounts admin_Accounts = new();
            admin_Accounts.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Characters admin_Characters = new();
            admin_Characters.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NPC_Shop_Editor npc_show = new();
            npc_show.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Server_Settings server_Settings = new();
            server_Settings.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EventsEditor eventsEditor = new();
            eventsEditor.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Guild guild = new();
            guild.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Working"); ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Working"); ;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Working");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Working");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Shop_Create shop_Create = new();
            shop_Create.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            TeleportGateCreator teleportGateCreator = new();
            teleportGateCreator.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Monster monster = new();
            monster.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ServerCreator serverCreator = new();
            serverCreator.Show();
        }

        private void Admin_main_Load(object sender, EventArgs e)
        {
            config.database = "mu_online_characters";
            Sql_Querys sql_Querys = new();
            if (Connect.loadData(sql_Querys.countPlayer).Rows.Count > 0)
            {
                label2.Text = Connect.loadData(sql_Querys.countPlayer).Rows[0].ItemArray[0].ToString();
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            MiniMap_Editor miniMap_Editor = new();
            miniMap_Editor.Show();
        }
    }
}