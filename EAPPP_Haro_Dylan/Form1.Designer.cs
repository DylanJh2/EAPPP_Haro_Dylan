namespace frmPedidoCafeteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Empanada de queso", "$1.25" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Sánduche de pollo", "$2.50" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Bolón de verde mixto $", "$2.25" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Humita tradicional", "$1.50" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { " Tostada con queso", "$1.00" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Café pasado", "$0.85" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Jugo natural (naranja/mora)", "$1.50" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "Batido de fruta", "$2.00" }, -1);
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "Botella de agua", "$0.75" }, -1);
            lvCatalogo = new ListView();
            Producto = new ColumnHeader();
            Precio = new ColumnHeader();
            lblcliente = new Label();
            txtCliente = new TextBox();
            lblproducto = new Label();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            lblcantidad = new Label();
            gbatencion = new GroupBox();
            rbtnEntrega = new RadioButton();
            rbtnMostrador = new RadioButton();
            gbextras = new GroupBox();
            chkServilletas = new CheckBox();
            chkPostre = new CheckBox();
            listView1 = new ListView();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            lblTotal = new Label();
            ProducD = new ColumnHeader();
            CantD = new ColumnHeader();
            Subtotal = new ColumnHeader();
            gbatencion.SuspendLayout();
            gbextras.SuspendLayout();
            SuspendLayout();
            // 
            // lvCatalogo
            // 
            lvCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvCatalogo.Columns.AddRange(new ColumnHeader[] { Producto, Precio });
            lvCatalogo.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            lvCatalogo.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            listViewItem1.Tag = "Empanada de queso";
            lvCatalogo.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9 });
            lvCatalogo.Location = new Point(25, 35);
            lvCatalogo.Name = "lvCatalogo";
            lvCatalogo.Size = new Size(221, 259);
            lvCatalogo.TabIndex = 0;
            lvCatalogo.UseCompatibleStateImageBehavior = false;
            lvCatalogo.View = View.Details;
            lvCatalogo.SelectedIndexChanged += lvCatalogo_SelectedIndexChanged;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 150;
            // 
            // Precio
            // 
            Precio.Tag = "hola";
            Precio.Text = "Precio";
            // 
            // lblcliente
            // 
            lblcliente.AutoSize = true;
            lblcliente.Location = new Point(311, 52);
            lblcliente.Name = "lblcliente";
            lblcliente.Size = new Size(47, 15);
            lblcliente.TabIndex = 1;
            lblcliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(364, 49);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 2;
            // 
            // lblproducto
            // 
            lblproducto.AutoSize = true;
            lblproducto.Location = new Point(299, 86);
            lblproducto.Name = "lblproducto";
            lblproducto.Size = new Size(59, 15);
            lblproducto.TabIndex = 3;
            lblproducto.Text = "Producto:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(364, 83);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(524, 83);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 5;
            txtCantidad.Text = "1";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(488, 87);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(32, 15);
            lblcantidad.TabIndex = 6;
            lblcantidad.Text = "Cant";
            // 
            // gbatencion
            // 
            gbatencion.Controls.Add(rbtnEntrega);
            gbatencion.Controls.Add(rbtnMostrador);
            gbatencion.Location = new Point(308, 130);
            gbatencion.Name = "gbatencion";
            gbatencion.Size = new Size(325, 74);
            gbatencion.TabIndex = 7;
            gbatencion.TabStop = false;
            gbatencion.Text = "Modalidad de atencion ";
            // 
            // rbtnEntrega
            // 
            rbtnEntrega.AutoSize = true;
            rbtnEntrega.Location = new Point(168, 31);
            rbtnEntrega.Name = "rbtnEntrega";
            rbtnEntrega.RightToLeft = RightToLeft.No;
            rbtnEntrega.Size = new Size(152, 19);
            rbtnEntrega.TabIndex = 1;
            rbtnEntrega.TabStop = true;
            rbtnEntrega.Text = "Entraga en aula (+$0.50)";
            rbtnEntrega.UseVisualStyleBackColor = true;
            // 
            // rbtnMostrador
            // 
            rbtnMostrador.AutoSize = true;
            rbtnMostrador.Location = new Point(20, 31);
            rbtnMostrador.Name = "rbtnMostrador";
            rbtnMostrador.Size = new Size(142, 19);
            rbtnMostrador.TabIndex = 0;
            rbtnMostrador.TabStop = true;
            rbtnMostrador.Text = "Retiro en el mostrador";
            rbtnMostrador.UseVisualStyleBackColor = true;
            // 
            // gbextras
            // 
            gbextras.Controls.Add(chkServilletas);
            gbextras.Controls.Add(chkPostre);
            gbextras.Location = new Point(308, 210);
            gbextras.Name = "gbextras";
            gbextras.Size = new Size(306, 76);
            gbextras.TabIndex = 8;
            gbextras.TabStop = false;
            gbextras.Text = "Extras del pedido";
            // 
            // chkServilletas
            // 
            chkServilletas.AutoSize = true;
            chkServilletas.Location = new Point(168, 41);
            chkServilletas.Name = "chkServilletas";
            chkServilletas.Size = new Size(134, 19);
            chkServilletas.TabIndex = 1;
            chkServilletas.Text = "Servilletas/Cubiertos";
            chkServilletas.UseVisualStyleBackColor = true;
            // 
            // chkPostre
            // 
            chkPostre.AutoSize = true;
            chkPostre.Location = new Point(21, 41);
            chkPostre.Name = "chkPostre";
            chkPostre.Size = new Size(146, 19);
            chkPostre.TabIndex = 0;
            chkPostre.Text = "Postre del dia (+ $1.00)";
            chkPostre.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ProducD, CantD, Subtotal });
            listView1.Location = new Point(61, 335);
            listView1.Name = "listView1";
            listView1.Size = new Size(496, 88);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(311, 292);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(400, 292);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(75, 23);
            btnQuitar.TabIndex = 11;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(488, 292);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(61, 426);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(38, 15);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "label1";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(134, 426);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "label1";
            // 
            // ProducD
            // 
            ProducD.Text = "Producto";
            ProducD.Width = 150;
            // 
            // CantD
            // 
            CantD.Text = "Cantidad";
            // 
            // Subtotal
            // 
            Subtotal.Text = "Subtotal";
            Subtotal.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(listView1);
            Controls.Add(gbextras);
            Controls.Add(gbatencion);
            Controls.Add(lblcantidad);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(lblproducto);
            Controls.Add(txtCliente);
            Controls.Add(lblcliente);
            Controls.Add(lvCatalogo);
            Name = "Form1";
            Text = "Form1";
            gbatencion.ResumeLayout(false);
            gbatencion.PerformLayout();
            gbextras.ResumeLayout(false);
            gbextras.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvCatalogo;
        private ColumnHeader Producto;
        private ColumnHeader Precio;
        private Label lblcliente;
        private TextBox txtCliente;
        private Label lblproducto;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private Label lblcantidad;
        private GroupBox gbatencion;
        private RadioButton rbtnEntrega;
        private RadioButton rbtnMostrador;
        private GroupBox gbextras;
        private CheckBox chkServilletas;
        private CheckBox chkPostre;
        private ListView listView1;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnLimpiar;
        private Label lblEstado;
        private Label lblTotal;
        private ColumnHeader ProducD;
        private ColumnHeader CantD;
        private ColumnHeader Subtotal;
    }
}
