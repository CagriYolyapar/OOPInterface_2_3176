using OOPInterface_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPInterface_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<IGorunmezlik> gorunmezAraclar = new List<IGorunmezlik>()
            {
                new S100(), new F22(), new F117()
            };


            List<IGorunmezHavaAraci> gorunmezHavaAraclari = new List<IGorunmezHavaAraci>
            {
                new F22() ,new F117()
            };

            List<IGorunmezDenizAraci> gorunmezDenizAraclari = new List<IGorunmezDenizAraci>()
            {
                new S100()
            };


            //foreach (IGorunmezlik item in gorunmezAraclar)
            //{
            //    item.Gorunmezlik();
            //}

            
        }
    }
}
