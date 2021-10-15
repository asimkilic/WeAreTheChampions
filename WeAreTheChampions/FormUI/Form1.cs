using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Form1 : Form
    {
        private IColorService _colorService;
        public Form1()
        {
            InitializeComponent();
            _colorService = InstanceFactory.GetInstance<IColorService>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = _colorService.GetAll();
            foreach (var item in result)
            {
                MessageBox.Show(item.ColorName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            color.Blue = 5;
            color.ColorName = textBox1.Text;
            _colorService.Add(color);
        }
    }
}
