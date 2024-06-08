using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_ventas_Libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        double recaudacion = 0;
        void refrescarTextBox() 
        {
            txtPrecio.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCodBarra.Text = string.Empty;
        }
        void refrescarlabelRecaudacion() 
        {
            lblRecaudacion.Text = $"Recaudación total : {recaudacion}";
        }


        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                double _precio;

                //string.IsNullOrWhiteSpace(txtPrecio.Text)
                if (txtPrecio.Text == string.Empty || txtNombre.Text == string.Empty || txtCodBarra.Text == string.Empty )
                    throw new Exception("Formato incorrecto!");

                if (!double.TryParse(txtPrecio.Text, out _precio))
                    throw new Exception($"{txtPrecio.Text} tiene qué ser un valor numerico.");

                if (!double.TryParse(txtCodBarra.Text, out _precio))
                    throw new Exception($"{txtCodBarra.Text} tiene qué ser un valor numerico.");

                Articulo art = new Articulo(txtNombre.Text, txtCodBarra.Text, double.Parse(txtPrecio.Text));
                
                listBox1.Items.Add(art);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;

                refrescarTextBox();
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message,"Error",MessageBoxButtons.OK); }

        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count == 0)
                    throw new Exception("No Hay Articulos en Stock por el momento!");

                

                Articulo Art = (Articulo)listBox1.SelectedItem;


                Venta venta = new Venta(Art, (int)numericUpDown1.Value);

                listBox2.Items.Add(venta);

                recaudacion += venta.totalVenta();



                refrescarlabelRecaudacion();

                numericUpDown1.Value = 1;
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refrescarlabelRecaudacion();
        }
    }
}
