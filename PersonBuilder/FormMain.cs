using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonBuilder
{
    public partial class FormMain : Form
    {
        private readonly PersonDirector _director = new PersonDirector();

        public FormMain()
        {
            InitializeComponent();
        }

        private void pic00_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Lime);
            PersonBuilder builder = new PersonThinBuilder(e.Graphics, pen);
            _director.CreatePerson(builder);
        }

        private void pic01_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Yellow);
            PersonBuilder builder = new PersonFatBuilder(e.Graphics, pen);
            _director.CreatePerson(builder);
        }

        private void pic10_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red);
            PersonBuilder builder = new PersonFatBuilder(e.Graphics, pen);
            _director.CreatePerson(builder);
        }

        private void pic11_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Cyan);
            PersonBuilder builder = new PersonThinBuilder(e.Graphics, pen);
            _director.CreatePerson(builder);
        }
    }
}
