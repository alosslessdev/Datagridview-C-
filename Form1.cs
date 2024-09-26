using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datagridview_C_
{
    public partial class Form1 : Form
    {
       int cantidad;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cantidad; i++)
            {
                try
                {
                    // Obtener y validar los datos
                    string nombre = dgvPersonas.Rows[i].Cells["Nombre"].Value?.ToString();
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        MessageBox.Show($"Ingrese un nombre válido en la fila {i + 1}.");
                        continue;
                    }

                    string sexo = dgvPersonas.Rows[i].Cells["Sexo"].Value?.ToString();
                    if (sexo != "M" && sexo != "F")
                    {
                        MessageBox.Show($"Ingrese 'M' o 'F' para el sexo en la fila {i + 1}.");
                        continue;
                    }

                    if (!int.TryParse(dgvPersonas.Rows[i].Cells["Edad"].Value?.ToString(), out int edad) || edad <= 0)
                    {
                        MessageBox.Show($"Ingrese una edad válida en la fila {i + 1}.");
                        continue;
                    }

                    if (!decimal.TryParse(dgvPersonas.Rows[i].Cells["Altura (m)"].Value?.ToString(), out decimal altura) || altura <= 0)
                    {
                        MessageBox.Show($"Ingrese una altura válida en la fila {i + 1}.");
                        continue;
                    }

                    if (!decimal.TryParse(dgvPersonas.Rows[i].Cells["Peso (kg)"].Value?.ToString(), out decimal peso) || peso <= 0)
                    {
                        MessageBox.Show($"Ingrese un peso válido en la fila {i + 1}.");
                        continue;
                    }

                    // Calcular el IMC
                    decimal imc = peso / (altura * altura);
                    imc = Math.Round(imc, 2);

                    // Categorizar el IMC
                    string categoriaIMC = "";
                    if (imc < 18.5m) categoriaIMC = "Bajo peso";
                    else if (imc < 25) categoriaIMC = "Normal";
                    else if (imc < 30) categoriaIMC = "Sobrepeso";
                    else categoriaIMC = "Obesidad";

                    // Asignar valores calculados al DataGridView
                    dgvPersonas.Rows[i].Cells["IMC"].Value = imc;
                    dgvPersonas.Rows[i].Cells["Categoría"].Value = categoriaIMC;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error en la fila {i + 1}: {ex.Message}");
                }
            }
            ContarCategoriasIMC();
        }
        private void ContarCategoriasIMC()
        {
            int cantidadObesidad = 0;
            int cantidadSobrepeso = 0;
            int cantidadPesoNormal = 0;
            int cantidadBajoPeso = 0;

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgvPersonas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    string categoriaIMC = fila.Cells["Categoría"].Value?.ToString();

                    switch (categoriaIMC)
                    {
                        case "Obesidad":
                            cantidadObesidad++;
                            break;
                        case "Sobrepeso":
                            cantidadSobrepeso++;
                            break;
                        case "Normal":
                            cantidadPesoNormal++;
                            break;
                        case "Bajo peso":
                            cantidadBajoPeso++;
                            break;
                    }
                }
            }

            // Mostrar los resultados en etiquetas o MessageBox
            lbObesidad.Text = "Pacientes con obesidad: " + cantidadObesidad;
            lbSobrepeso.Text = "Pacientes con sobrepeso: " + cantidadSobrepeso;
            lbPesoNormal.Text = "Pacientes con peso normal: " + cantidadPesoNormal;
            lbBajoPeso.Text = "Pacientes con bajo peso: " + cantidadBajoPeso;
        }
        private void btGenerar_Click(object sender, EventArgs e)
        {
            ObtenerCantidadPersonas();
            // Asegurarse de que se ha ingresado un valor válido en "cantidad"
            if (cantidad == 0)
            {
                return;
            }

            // Remover todas las columnas actuales para evitar duplicados al generar varias veces
            dgvPersonas.Columns.Clear();

            string[] nombresColumnas = { "Nombre", "Sexo", "Edad", "Altura (m)", "Peso (kg)", "IMC", "Categoría" };
            int[] anchosColumnas = { 150, 80, 60, 80, 80, 80, 120 };

            // Configurar la columna "Nombre"
            DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                Name = "Nombre",
                Width = anchosColumnas[0]
            };
            dgvPersonas.Columns.Add(columnaNombre);

            // Configurar la columna "Sexo" como ComboBox
            DataGridViewComboBoxColumn columnaSexo = new DataGridViewComboBoxColumn
            {
                HeaderText = "Sexo",
                Name = "Sexo",
                Items = { "M", "F" },
                Width = anchosColumnas[1]
            };
            dgvPersonas.Columns.Add(columnaSexo);

            // Configurar las demás columnas
            for (int idx = 2; idx < nombresColumnas.Length; idx++)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn
                {
                    HeaderText = nombresColumnas[idx],
                    Name = nombresColumnas[idx],
                    Width = anchosColumnas[idx]
                };

                // Las columnas "IMC" y "Categoría" son de solo lectura
                if (columna.Name == "IMC" || columna.Name == "Categoría")
                {
                    columna.ReadOnly = true;

                    columna.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }

                dgvPersonas.Columns.Add(columna);
            }

            // Establecer la cantidad de filas
            dgvPersonas.RowCount = cantidad;

            // Alineación y estilos
            dgvPersonas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPersonas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPersonas.RowsDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);

            // Configurar los encabezados de fila
            for (int i = 0; i < cantidad; i++)
            {
                dgvPersonas.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

        }
        void ObtenerCantidadPersonas()
        {
            if (int.TryParse(txtCantidad.Text, out cantidad) && cantidad > 0)
            {
                // Cantidad válida
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida de personas.");
                cantidad = 0;
            }
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
