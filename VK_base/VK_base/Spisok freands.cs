﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Spisok_freands : Form
    {
<<<<<<< HEAD
        public string id;
=======
        string id;
>>>>>>> origin/master
        public string access_token;
        public Spisok_freands()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            string ttg = "https://api.vk.com/method/friends.getRequests.xml?&access_token=" + access_token + "&v=5.62";
            doc.Load(ttg);
            foreach (XmlNode level1 in doc.SelectNodes("response"))
            {

                foreach (XmlNode level2 in level1.SelectNodes("items"))
                {
                    foreach (XmlNode level3 in level2.SelectNodes("user_id"))
                    {
                         id = level3.InnerText;
                        
                        listView1.Items.Add(id);
                        XmlDocument doc1 = new XmlDocument();
                        string ttg1 = "https://api.vk.com/method/friends.add.xml?&access_token=" + access_token + "&user_id=" + id + "&v=5.62";
                        doc1.Load(ttg1);
                    }
                }

                
            }
<<<<<<< HEAD

            string add = "https://api.vk.com/method/friends.add.xml?&access_token=" + access_token + "&user_id="+ id + "&v=5.62";
         
=======
           
>>>>>>> origin/master
        }
    }
}

