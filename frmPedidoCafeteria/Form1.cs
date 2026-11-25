using static System.Runtime.InteropServices.JavaScript.JSType;

namespace frmPedidoCafeteria
{
    //Creado por Dylan Haro 
    public partial class Form1 : Form
    {
        public int v = 1;
        public Form1()
        {
            InitializeComponent();
        }

        /* Evento 1: establecemos el valor de txtproductor
         Establecemos condiciones al boton agregar
         Establecemos texcto del lable de estado */
        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCatalogo.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCatalogo.SelectedItems[0];
                txtProducto.Text = item.Text;
                string precio = item.SubItems[1].Text;
                lblEstado.Text = $"Estado: {item.Text} ({precio}) seleccionado.";


                bool cantidadValida = int.TryParse(txtCantidad.Text, out int cant) && cant >= 1;
                btnAgregar.Enabled = cantidadValida;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                lblEstado.Text = "Error: Ingrese el nombre del cliente.";
                txtCliente.Focus();
                return;
            }
            if (lvCatalogo.SelectedItems.Count == 0)
            {
                lblEstado.Text = "Error: Seleccione un producto del catálogo.";
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 1)
            {
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";
                txtCantidad.Focus();
                return;
            }
            ListViewItem seleccionado = lvCatalogo.SelectedItems[0];
            string producto = seleccionado.Text;
            string textoPrecio = seleccionado.SubItems[1].Text.Replace("$", "").Trim();

            decimal precioUnitario = decimal.Parse(textoPrecio, System.Globalization.CultureInfo.InvariantCulture);
            decimal subtotal = cantidad * precioUnitario;
            ListViewItem fila = new ListViewItem(producto);
            fila.SubItems.Add(cantidad.ToString());
            fila.SubItems.Add(subtotal.ToString("$0.00", System.Globalization.CultureInfo.InvariantCulture));
            listView1.Items.Add(fila);
            ActualizarTotal();
            txtCantidad.Text = "1";
            lblEstado.Text = $"Estado: Agregado {cantidad} x {producto} ({subtotal.ToString("$0.00", System.Globalization.CultureInfo.InvariantCulture)}).";
        }

        // Evento 2: Determinacion del estado inicial de la aplicacion.
        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto.";
        }
        //Evento 3: Activacion del boton de quitar solo si esta seleccionada
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnQuitar.Enabled = listView1.SelectedItems.Count > 0;
        }
        /* Evento 4: Se comprueba que la cantidad sea un unidad numerica
        y que sea mayor a 1 ,sino no deja pasar de ese cuadro */
        private void txtCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 1)
            {
                e.Cancel = true;
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";
                txtCantidad.SelectAll();
            }
            else
            {
                e.Cancel = false;
            }
        }
        // Evalua si el valor de producto y cantidad es valido par 
        // habilitar el boton btnAgregar
        private void ActualizarEstadoBtnAgregar()
        {
            bool productoValido = !string.IsNullOrWhiteSpace(txtProducto.Text);
            bool cantidadValida = int.TryParse(txtCantidad.Text, out int cantidad) && cantidad >= 1;

            btnAgregar.Enabled = productoValido && cantidadValida;
        }

        // Evento 5: Utiliza la funcion de ActualizarEstadoBtnAgregar
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBtnAgregar();
        }
        // Evento 6: Utiliza la funcion de ActualizarEstadoBtnAgregar
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBtnAgregar();
        }
        /* Realizamos una transformacion de string a int 
         luego verificamos si estan marcados rbtnEntrega y chkPostre 
         para poder sumarlo al valor total y mostrarlo al usuario*/
        private void ActualizarTotal()
        {
            decimal subtotalProductos = 0m;

            // Suma los subtotales actuales de la tabla del pedido (columna 2 = Subtotal)
            foreach (ListViewItem fila in listView1.Items)
            {
                if (fila.SubItems.Count > 2)
                {
                    string textoSubtotal = fila.SubItems[2].Text.Replace("$", "").Trim();
                    if (decimal.TryParse(textoSubtotal, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out decimal sub))
                    {
                        subtotalProductos += sub;
                    }
                }
            }

            decimal recargoEntrega = rbtnEntrega.Checked ? 0.50m : 0.00m;
            decimal extraPostre = chkPostre.Checked ? 1.00m : 0.00m;

            decimal totalFinal = subtotalProductos + recargoEntrega + extraPostre;

            lblTotal.Text = $"Total: ${totalFinal.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)}";
        }
        /*Evento 7: Se realiza la llamada a la funcion ActualizarTotal
          y cambiar el lblEstado informando al usuario*/
        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (rbtnEntrega.Checked)
            {
                lblEstado.Text = "Opción aplicada: Entrega en aula (+$0.50).";
            }
            else
            {
                lblEstado.Text = "Opción aplicada: Retiro en el mostrador ($0.00).";
            }
        }
        /*Evento 8: Se realiza la llamada a la funcion ActualizarTotal
          y cambiar el lblEstado informando al usuario*/

        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (chkPostre.Checked)
            {
                lblEstado.Text = "Opción aplicada: Postre del día (+$1.00).";
            }
            else
            {
                lblEstado.Text = "Opción removida: Postre del día (-$1.00).";
            }
        }
        /*Evento 8:  cambiar el lblEstado informando al usuario*/
      
        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();

            if (chkServilletas.Checked)
            {
                lblEstado.Text = "Opción aplicada: Servilletas/Cubiertos.";
            }
            else
            {
                lblEstado.Text = "Opción removida: Servilletas/Cubiertos.";
            }
        }
        /*Evento 9: Una ves habilitado el boton y dado click nos permite remover una fila 
         aparte de llamar a la funcion ActualizarTotal*/
        private void btnQuitar_Click(object sender, EventArgs e)
        {

            ListViewItem filaSeleccionada = listView1.SelectedItems[0];
            string productoQuitado = filaSeleccionada.Text;

            listView1.Items.Remove(filaSeleccionada);
            ActualizarTotal();
            lblEstado.Text = $"Estado: Se quitó '{productoQuitado}' del pedido.";
        }
        /* Evento 10: limpiamos todos los productos gruadados y "reseteamos" el programa */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txtCliente.Clear();
            txtProducto.Clear();

            lvCatalogo.SelectedItems.Clear();
            txtCantidad.Text = "1";

            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Pedido reiniciado.";
            txtCantidad.Text = "1";
        }
    }
}
    
