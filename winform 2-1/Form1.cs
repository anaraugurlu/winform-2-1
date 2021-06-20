using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nameupdatetxtb.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            List<Human> humans = new List<Human>
            {
                new Human
                {
                    Email ="ZeynebHesenova@gmail.com",
                    Name="zeyneb",
                    Surname ="hesenova",
                    PhoneNumber ="12312323535",

                },

                new Human
                {
Name ="fuad",
Surname ="ugurlu",
Email ="fuad123@gmail.com",
PhoneNumber ="+12235256"
                },
                new Human
                {
                    Name ="nezrin",
                    Surname ="rehimli",
                    Email="nezrin123@gmail.com",
                    PhoneNumber ="+9941312334"
                }



        };
            foreach (var item in humans)
            {

                Humans.Items.Add(item);
            }
            Json.JsonSerialize(humans);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            human.Name = textBox1.Text;
            human.Surname = textBox2.Text;
            human.Email = textBox4.Text;
            human.BirthDate = dateTimePicker1.Text;
            Humans.Items.Add(human);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                nameupdatetxtb.Enabled = true;

                foreach (Human item in Humans.Items)
                {

                    if (item.Name == nameupdatetxtb.Text)
                    {
                        Humans.Items.Remove(item);
                        Human human = new Human();
                        human.Name = textBox1.Text;
                        human.Surname = textBox2.Text;
                        human.Email = textBox4.Text;
                        human.BirthDate = dateTimePicker1.Text;
                        Humans.Items.Add(human);
                    }
                }
            }
            catch (Exception)
            {


            }
                 
                }
            }
            
        }

    

