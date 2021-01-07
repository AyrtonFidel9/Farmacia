using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class Form1 : Form
    {
        Conexion conexion;
        public Form1()
        {
            InitializeComponent();
            conexion = new Conexion();
            conexion.conectarBD();
        }
    }
}
