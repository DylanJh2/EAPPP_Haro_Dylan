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
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "Empanada de queso", "$1.25" }, -1);
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "Sánduche de pollo", "$2.50" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "Bolón de verde mixto $", "$2.25" }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "Humita tradicional", "$1.50" }, -1);
            ListViewItem listViewItem14 = new ListViewItem(new string[] { " Tostada con queso", "$1.00" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "Café pasado", "$0.85" }, -1);
            ListViewItem listViewItem16 = new ListViewItem(new string[] { "Jugo natural (naranja/mora)", "$1.50" }, -1);
            ListViewItem listViewItem17 = new ListViewItem(new string[] { "Batido de fruta", "$2.00" }, -1);
            ListViewItem listViewItem18 = new ListViewItem(new string[] { "Botella de agua", "$0.75" }, -1);
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
            ProducD = new ColumnHeader();
            CantD = new ColumnHeader();
            Subtotal = new ColumnHeader();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            lblTotal = new Label();
            gbatencion.SuspendLayout();
            gbextras.SuspendLayout();
            SuspendLayout();
            // 
            // lvCatalogo
            // 
            lvCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvCatalogo.Columns.AddRange(new ColumnHeader[] { Producto, Precio });
            lvCatalogo.FullRowSelect = true;
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            lvCatalogo.Groups.AddRange(new ListViewGroup[] { listViewGroup2 });
            listViewItem10.Tag = "Empanada de queso";
            lvCatalogo.Items.AddRange(new ListViewItem[] { listViewItem10, listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18 });
            lvCatalogo.Location = new Point(29, 47);
            lvCatalogo.Margin = new Padding(3, 4, 3, 4);
            lvCatalogo.Name = "lvCatalogo";
            lvCatalogo.Size = new Size(252, 344);
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
            lblcliente.Location = new Point(355, 69);
            lblcliente.Name = "lblcliente";
            lblcliente.Size = new Size(58, 20);
            lblcliente.TabIndex = 1;
            lblcliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(416, 65);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(114, 27);
            txtCliente.TabIndex = 2;
            // 
            // lblproducto
            // 
            lblproducto.AutoSize = true;
            lblproducto.Location = new Point(342, 115);
            lblproducto.Name = "lblproducto";
            lblproducto.Size = new Size(72, 20);
            lblproducto.TabIndex = 3;
            lblproducto.Text = "Producto:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(416, 111);
            txtProducto.Margin = new Padding(3, 4, 3, 4);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(114, 27);
            txtProducto.TabIndex = 4;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(599, 111);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 5;
            txtCantidad.Text = "1";
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.Validating += txtCantidad_Validating;
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(558, 116);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(39, 20);
            lblcantidad.TabIndex = 6;
            lblcantidad.Text = "Cant";
            // 
            // gbatencion
            // 
            gbatencion.Controls.Add(rbtnEntrega);
            gbatencion.Controls.Add(rbtnMostrador);
            gbatencion.Location = new Point(352, 231);
            gbatencion.Margin = new Padding(3, 4, 3, 4);
            gbatencion.Name = "gbatencion";
            gbatencion.Padding = new Padding(3, 4, 3, 4);
            gbatencion.Size = new Size(432, 99);
            gbatencion.TabIndex = 7;
            gbatencion.TabStop = false;
            gbatencion.Text = "Modalidad de atencion ";
            // 
            // rbtnEntrega
            // 
            rbtnEntrega.AutoSize = true;
            rbtnEntrega.Location = new Point(211, 41);
            rbtnEntrega.Margin = new Padding(3, 4, 3, 4);
            rbtnEntrega.Name = "rbtnEntrega";
            rbtnEntrega.RightToLeft = RightToLeft.No;
            rbtnEntrega.Size = new Size(192, 24);
            rbtnEntrega.TabIndex = 1;
            rbtnEntrega.TabStop = true;
            rbtnEntrega.Text = "Entraga en aula (+$0.50)";
            rbtnEntrega.UseVisualStyleBackColor = true;
            rbtnEntrega.CheckedChanged += rbtnEntrega_CheckedChanged;
            // 
            // rbtnMostrador
            // 
            rbtnMostrador.AutoSize = true;
            rbtnMostrador.Location = new Point(23, 41);
            rbtnMostrador.Margin = new Padding(3, 4, 3, 4);
            rbtnMostrador.Name = "rbtnMostrador";
            rbtnMostrador.Size = new Size(179, 24);
            rbtnMostrador.TabIndex = 0;
            rbtnMostrador.TabStop = true;
            rbtnMostrador.Text = "Retiro en el mostrador";
            rbtnMostrador.UseVisualStyleBackColor = true;
            // 
            // gbextras
            // 
            gbextras.Controls.Add(chkServilletas);
            gbextras.Controls.Add(chkPostre);
            gbextras.Location = new Point(352, 338);
            gbextras.Margin = new Padding(3, 4, 3, 4);
            gbextras.Name = "gbextras";
            gbextras.Padding = new Padding(3, 4, 3, 4);
            gbextras.Size = new Size(432, 101);
            gbextras.TabIndex = 8;
            gbextras.TabStop = false;
            gbextras.Text = "Extras del pedido";
            // 
            // chkServilletas
            // 
            chkServilletas.AutoSize = true;
            chkServilletas.Location = new Point(236, 55);
            chkServilletas.Margin = new Padding(3, 4, 3, 4);
            chkServilletas.Name = "chkServilletas";
            chkServilletas.Size = new Size(167, 24);
            chkServilletas.TabIndex = 1;
            chkServilletas.Text = "Servilletas/Cubiertos";
            chkServilletas.UseVisualStyleBackColor = true;
            chkServilletas.CheckedChanged += chkServilletas_CheckedChanged;
            // 
            // chkPostre
            // 
            chkPostre.AutoSize = true;
            chkPostre.Location = new Point(18, 55);
            chkPostre.Margin = new Padding(3, 4, 3, 4);
            chkPostre.Name = "chkPostre";
            chkPostre.Size = new Size(184, 24);
            chkPostre.TabIndex = 0;
            chkPostre.Text = "Postre del dia (+ $1.00)";
            chkPostre.UseVisualStyleBackColor = true;
            chkPostre.CheckedChanged += chkPostre_CheckedChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ProducD, CantD, Subtotal });
            listView1.Location = new Point(31, 447);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(566, 116);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // btnAgregar
            // 
            btnAgregar.Location = new Point(355, 181);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(486, 181);
            btnQuitar.Margin = new Padding(3, 4, 3, 4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(86, 31);
            btnQuitar.TabIndex = 11;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(616, 181);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(31, 571);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(50, 20);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "label1";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(705, 477);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(175, 44);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
