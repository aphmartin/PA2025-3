using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;

namespace POS
{
    public partial class frmCorteCaja : Form
    {
        public frmCorteCaja()
        {
            InitializeComponent();
        }

        private void btnGenerarCorte_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Archivo de texto|*.txt";
                dialog.FileName = $"corte_{dtpFechaCorte.Value:dd_MM_yyyy}.txt";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    {
                        writer.WriteLine("Sistema POS");
                        writer.WriteLine("=====================================================");
                        writer.WriteLine($"Fecha: {dtpFechaCorte.Value:dd/MM/yyyy}");
                        writer.WriteLine("Corte de Caja");
                        writer.WriteLine("=====================================================");
                        writer.WriteLine("Cantidad | Clave Producto | Nombre Producto | Importe");
                        writer.WriteLine("=====================================================");

                        foreach (DataGridViewRow row in dgvVentasDelDia.Rows)
                        {
                            writer.WriteLine($"{row.Cells[0].Value} | {row.Cells[1].Value} | {row.Cells[2].Value} | {Convert.ToDecimal(row.Cells[3].Value):C2}");
                        }

                        writer.WriteLine("====================================================");
                        writer.WriteLine($"Importe total del {dtpFechaCorte.Value:dd/MM/yyyy} \t {txtTotalVendido.Text}");
                    }

                    MessageBox.Show("Corte generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el corte de caja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSeleccionada = dtpFechaCorte.Value.Date;
                Ventas ventas= new Ventas();

                DataTable DatosVentas = ventas.ObtenerVentasDelDia(fechaSeleccionada);
                dgvVentasDelDia.Rows.Clear();

                decimal total = 0;

                foreach (DataRow row in DatosVentas.Rows)
                {
                    int cantidad = Convert.ToInt32(row["cantidad"]);
                    string clave = row["clave"].ToString();
                    string nombre = row["nombre"].ToString();
                    decimal importe = Convert.ToDecimal(row["importe"]);

                    dgvVentasDelDia.Rows.Add(cantidad, clave, nombre, importe);
                    total += importe;
                }

                txtTotalVendido.Text = total.ToString("C2");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
    }
}
