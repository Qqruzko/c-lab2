﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberlist.Items.Add(peopleList.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            while (memberlist.CheckedIndices.Count > 0)
                memberlist.Items.RemoveAt(memberlist.CheckedIndices[0]);
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            memberlist.Sorted = true;
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            peopleList.Items.Clear();
            FileStream fStream =
            new FileStream("C:\\Users\\Lenovo\\Desktop\\WindowsForms\\Lab2\\ex2\\ex2\\XMLFile1.xml", FileMode.Open,
            FileAccess.Read, FileShare.ReadWrite);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fStream);

            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            }

            fStream.Close();
        }
    }
}
