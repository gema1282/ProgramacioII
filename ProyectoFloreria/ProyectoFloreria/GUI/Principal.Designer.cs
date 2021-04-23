
namespace GUI
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelClientesSubMenu = new System.Windows.Forms.Panel();
            this.btnClientesConsultar = new System.Windows.Forms.Button();
            this.btnClientesEliminar = new System.Windows.Forms.Button();
            this.btnClientesEditar = new System.Windows.Forms.Button();
            this.btnClientesRegistrar = new System.Windows.Forms.Button();
            this.panelVentasSubMenu = new System.Windows.Forms.Panel();
            this.btnVentasVer = new System.Windows.Forms.Button();
            this.btnVentasRegistrar = new System.Windows.Forms.Button();
            this.panelEmpleadoSubMenu = new System.Windows.Forms.Panel();
            this.btnEmpleadosVer = new System.Windows.Forms.Button();
            this.btnEmpleadosEliminar = new System.Windows.Forms.Button();
            this.btnEmpleadosEditar = new System.Windows.Forms.Button();
            this.btnEmpleadosRegistrar = new System.Windows.Forms.Button();
            this.panelFloresSubMenu = new System.Windows.Forms.Panel();
            this.btnFloresVer = new System.Windows.Forms.Button();
            this.btnFloresEliminar = new System.Windows.Forms.Button();
            this.btnFloresEditar = new System.Windows.Forms.Button();
            this.btnFloresRegistro = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelProveedoresSubMenu = new System.Windows.Forms.Panel();
            this.btnProveedoresConsultar = new System.Windows.Forms.Button();
            this.btnProveedoresEliminar = new System.Windows.Forms.Button();
            this.btnProveedoresEditar = new System.Windows.Forms.Button();
            this.btnProveedoresRegistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnFlores = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenuLateral.SuspendLayout();
            this.panelClientesSubMenu.SuspendLayout();
            this.panelVentasSubMenu.SuspendLayout();
            this.panelEmpleadoSubMenu.SuspendLayout();
            this.panelFloresSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panelProveedoresSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.Orange;
            this.panelMenuLateral.Controls.Add(this.panelProveedoresSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnProveedores);
            this.panelMenuLateral.Controls.Add(this.panelClientesSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnClientes);
            this.panelMenuLateral.Controls.Add(this.panelVentasSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnVentas);
            this.panelMenuLateral.Controls.Add(this.panelEmpleadoSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnEmpleados);
            this.panelMenuLateral.Controls.Add(this.panelFloresSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnFlores);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 454);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelClientesSubMenu
            // 
            this.panelClientesSubMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.panelClientesSubMenu.Controls.Add(this.btnClientesConsultar);
            this.panelClientesSubMenu.Controls.Add(this.btnClientesEliminar);
            this.panelClientesSubMenu.Controls.Add(this.btnClientesEditar);
            this.panelClientesSubMenu.Controls.Add(this.btnClientesRegistrar);
            this.panelClientesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientesSubMenu.Location = new System.Drawing.Point(0, 680);
            this.panelClientesSubMenu.Name = "panelClientesSubMenu";
            this.panelClientesSubMenu.Size = new System.Drawing.Size(233, 165);
            this.panelClientesSubMenu.TabIndex = 8;
            this.panelClientesSubMenu.Visible = false;
            // 
            // btnClientesConsultar
            // 
            this.btnClientesConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientesConsultar.FlatAppearance.BorderSize = 0;
            this.btnClientesConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesConsultar.ForeColor = System.Drawing.Color.White;
            this.btnClientesConsultar.Location = new System.Drawing.Point(0, 120);
            this.btnClientesConsultar.Name = "btnClientesConsultar";
            this.btnClientesConsultar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientesConsultar.Size = new System.Drawing.Size(233, 40);
            this.btnClientesConsultar.TabIndex = 3;
            this.btnClientesConsultar.Text = "Ver Listado de Clientes";
            this.btnClientesConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesConsultar.UseVisualStyleBackColor = true;
            this.btnClientesConsultar.Click += new System.EventHandler(this.btnClientesConsultar_Click);
            // 
            // btnClientesEliminar
            // 
            this.btnClientesEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientesEliminar.FlatAppearance.BorderSize = 0;
            this.btnClientesEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesEliminar.ForeColor = System.Drawing.Color.White;
            this.btnClientesEliminar.Location = new System.Drawing.Point(0, 80);
            this.btnClientesEliminar.Name = "btnClientesEliminar";
            this.btnClientesEliminar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientesEliminar.Size = new System.Drawing.Size(233, 40);
            this.btnClientesEliminar.TabIndex = 2;
            this.btnClientesEliminar.Text = "Eliminar Cliente";
            this.btnClientesEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesEliminar.UseVisualStyleBackColor = true;
            this.btnClientesEliminar.Click += new System.EventHandler(this.btnClientesEliminar_Click);
            // 
            // btnClientesEditar
            // 
            this.btnClientesEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientesEditar.FlatAppearance.BorderSize = 0;
            this.btnClientesEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesEditar.ForeColor = System.Drawing.Color.White;
            this.btnClientesEditar.Location = new System.Drawing.Point(0, 40);
            this.btnClientesEditar.Name = "btnClientesEditar";
            this.btnClientesEditar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientesEditar.Size = new System.Drawing.Size(233, 40);
            this.btnClientesEditar.TabIndex = 1;
            this.btnClientesEditar.Text = "Editar Cliente";
            this.btnClientesEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesEditar.UseVisualStyleBackColor = true;
            this.btnClientesEditar.Click += new System.EventHandler(this.btnClientesEditar_Click);
            // 
            // btnClientesRegistrar
            // 
            this.btnClientesRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientesRegistrar.FlatAppearance.BorderSize = 0;
            this.btnClientesRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnClientesRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnClientesRegistrar.Name = "btnClientesRegistrar";
            this.btnClientesRegistrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientesRegistrar.Size = new System.Drawing.Size(233, 40);
            this.btnClientesRegistrar.TabIndex = 0;
            this.btnClientesRegistrar.Text = "Registrar Cliente";
            this.btnClientesRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesRegistrar.UseVisualStyleBackColor = true;
            this.btnClientesRegistrar.Click += new System.EventHandler(this.btnClientesRegistrar_Click);
            // 
            // panelVentasSubMenu
            // 
            this.panelVentasSubMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.panelVentasSubMenu.Controls.Add(this.btnVentasVer);
            this.panelVentasSubMenu.Controls.Add(this.btnVentasRegistrar);
            this.panelVentasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentasSubMenu.Location = new System.Drawing.Point(0, 551);
            this.panelVentasSubMenu.Name = "panelVentasSubMenu";
            this.panelVentasSubMenu.Size = new System.Drawing.Size(233, 84);
            this.panelVentasSubMenu.TabIndex = 6;
            // 
            // btnVentasVer
            // 
            this.btnVentasVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentasVer.FlatAppearance.BorderSize = 0;
            this.btnVentasVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasVer.ForeColor = System.Drawing.Color.White;
            this.btnVentasVer.Location = new System.Drawing.Point(0, 40);
            this.btnVentasVer.Name = "btnVentasVer";
            this.btnVentasVer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVentasVer.Size = new System.Drawing.Size(233, 40);
            this.btnVentasVer.TabIndex = 1;
            this.btnVentasVer.Text = "Ver Historial de Ventas";
            this.btnVentasVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasVer.UseVisualStyleBackColor = true;
            this.btnVentasVer.Click += new System.EventHandler(this.btnVentasVer_Click);
            // 
            // btnVentasRegistrar
            // 
            this.btnVentasRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentasRegistrar.FlatAppearance.BorderSize = 0;
            this.btnVentasRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnVentasRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnVentasRegistrar.Name = "btnVentasRegistrar";
            this.btnVentasRegistrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVentasRegistrar.Size = new System.Drawing.Size(233, 40);
            this.btnVentasRegistrar.TabIndex = 0;
            this.btnVentasRegistrar.Text = "Realizar Venta";
            this.btnVentasRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasRegistrar.UseVisualStyleBackColor = true;
            this.btnVentasRegistrar.Click += new System.EventHandler(this.btnVentasRegistrar_Click);
            // 
            // panelEmpleadoSubMenu
            // 
            this.panelEmpleadoSubMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.panelEmpleadoSubMenu.Controls.Add(this.btnEmpleadosVer);
            this.panelEmpleadoSubMenu.Controls.Add(this.btnEmpleadosEliminar);
            this.panelEmpleadoSubMenu.Controls.Add(this.btnEmpleadosEditar);
            this.panelEmpleadoSubMenu.Controls.Add(this.btnEmpleadosRegistrar);
            this.panelEmpleadoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpleadoSubMenu.Location = new System.Drawing.Point(0, 348);
            this.panelEmpleadoSubMenu.Name = "panelEmpleadoSubMenu";
            this.panelEmpleadoSubMenu.Size = new System.Drawing.Size(233, 158);
            this.panelEmpleadoSubMenu.TabIndex = 4;
            // 
            // btnEmpleadosVer
            // 
            this.btnEmpleadosVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleadosVer.FlatAppearance.BorderSize = 0;
            this.btnEmpleadosVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleadosVer.ForeColor = System.Drawing.Color.White;
            this.btnEmpleadosVer.Location = new System.Drawing.Point(0, 120);
            this.btnEmpleadosVer.Name = "btnEmpleadosVer";
            this.btnEmpleadosVer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEmpleadosVer.Size = new System.Drawing.Size(233, 40);
            this.btnEmpleadosVer.TabIndex = 3;
            this.btnEmpleadosVer.Text = "Ver Listado de Empleados";
            this.btnEmpleadosVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleadosVer.UseVisualStyleBackColor = true;
            this.btnEmpleadosVer.Click += new System.EventHandler(this.btnEmpleadosVer_Click);
            // 
            // btnEmpleadosEliminar
            // 
            this.btnEmpleadosEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleadosEliminar.FlatAppearance.BorderSize = 0;
            this.btnEmpleadosEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleadosEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEmpleadosEliminar.Location = new System.Drawing.Point(0, 80);
            this.btnEmpleadosEliminar.Name = "btnEmpleadosEliminar";
            this.btnEmpleadosEliminar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEmpleadosEliminar.Size = new System.Drawing.Size(233, 40);
            this.btnEmpleadosEliminar.TabIndex = 2;
            this.btnEmpleadosEliminar.Text = "Eliminar Empleado";
            this.btnEmpleadosEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleadosEliminar.UseVisualStyleBackColor = true;
            this.btnEmpleadosEliminar.Click += new System.EventHandler(this.btnEmpleadosEliminar_Click);
            // 
            // btnEmpleadosEditar
            // 
            this.btnEmpleadosEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleadosEditar.FlatAppearance.BorderSize = 0;
            this.btnEmpleadosEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleadosEditar.ForeColor = System.Drawing.Color.White;
            this.btnEmpleadosEditar.Location = new System.Drawing.Point(0, 40);
            this.btnEmpleadosEditar.Name = "btnEmpleadosEditar";
            this.btnEmpleadosEditar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEmpleadosEditar.Size = new System.Drawing.Size(233, 40);
            this.btnEmpleadosEditar.TabIndex = 1;
            this.btnEmpleadosEditar.Text = "Editar Empleado";
            this.btnEmpleadosEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleadosEditar.UseVisualStyleBackColor = true;
            this.btnEmpleadosEditar.Click += new System.EventHandler(this.btnEmpleadosEditar_Click);
            // 
            // btnEmpleadosRegistrar
            // 
            this.btnEmpleadosRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleadosRegistrar.FlatAppearance.BorderSize = 0;
            this.btnEmpleadosRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleadosRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnEmpleadosRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleadosRegistrar.Name = "btnEmpleadosRegistrar";
            this.btnEmpleadosRegistrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEmpleadosRegistrar.Size = new System.Drawing.Size(233, 40);
            this.btnEmpleadosRegistrar.TabIndex = 0;
            this.btnEmpleadosRegistrar.Text = "Registrar Empleado";
            this.btnEmpleadosRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleadosRegistrar.UseVisualStyleBackColor = true;
            this.btnEmpleadosRegistrar.Click += new System.EventHandler(this.btnEmpleadosRegistrar_Click);
            // 
            // panelFloresSubMenu
            // 
            this.panelFloresSubMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.panelFloresSubMenu.Controls.Add(this.btnFloresVer);
            this.panelFloresSubMenu.Controls.Add(this.btnFloresEliminar);
            this.panelFloresSubMenu.Controls.Add(this.btnFloresEditar);
            this.panelFloresSubMenu.Controls.Add(this.btnFloresRegistro);
            this.panelFloresSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFloresSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelFloresSubMenu.Name = "panelFloresSubMenu";
            this.panelFloresSubMenu.Size = new System.Drawing.Size(233, 158);
            this.panelFloresSubMenu.TabIndex = 2;
            // 
            // btnFloresVer
            // 
            this.btnFloresVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFloresVer.FlatAppearance.BorderSize = 0;
            this.btnFloresVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloresVer.ForeColor = System.Drawing.Color.White;
            this.btnFloresVer.Location = new System.Drawing.Point(0, 120);
            this.btnFloresVer.Name = "btnFloresVer";
            this.btnFloresVer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFloresVer.Size = new System.Drawing.Size(233, 40);
            this.btnFloresVer.TabIndex = 3;
            this.btnFloresVer.Text = "Ver Listado de Flores";
            this.btnFloresVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloresVer.UseVisualStyleBackColor = true;
            this.btnFloresVer.Click += new System.EventHandler(this.btnFloresVer_Click);
            // 
            // btnFloresEliminar
            // 
            this.btnFloresEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFloresEliminar.FlatAppearance.BorderSize = 0;
            this.btnFloresEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloresEliminar.ForeColor = System.Drawing.Color.White;
            this.btnFloresEliminar.Location = new System.Drawing.Point(0, 80);
            this.btnFloresEliminar.Name = "btnFloresEliminar";
            this.btnFloresEliminar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFloresEliminar.Size = new System.Drawing.Size(233, 40);
            this.btnFloresEliminar.TabIndex = 2;
            this.btnFloresEliminar.Text = "Eliminar Flores";
            this.btnFloresEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloresEliminar.UseVisualStyleBackColor = true;
            this.btnFloresEliminar.Click += new System.EventHandler(this.btnFloresEliminar_Click);
            // 
            // btnFloresEditar
            // 
            this.btnFloresEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFloresEditar.FlatAppearance.BorderSize = 0;
            this.btnFloresEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloresEditar.ForeColor = System.Drawing.Color.White;
            this.btnFloresEditar.Location = new System.Drawing.Point(0, 40);
            this.btnFloresEditar.Name = "btnFloresEditar";
            this.btnFloresEditar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFloresEditar.Size = new System.Drawing.Size(233, 40);
            this.btnFloresEditar.TabIndex = 1;
            this.btnFloresEditar.Text = "Editar Flores";
            this.btnFloresEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloresEditar.UseVisualStyleBackColor = true;
            this.btnFloresEditar.Click += new System.EventHandler(this.btnFloresEditar_Click);
            // 
            // btnFloresRegistro
            // 
            this.btnFloresRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFloresRegistro.FlatAppearance.BorderSize = 0;
            this.btnFloresRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloresRegistro.ForeColor = System.Drawing.Color.White;
            this.btnFloresRegistro.Location = new System.Drawing.Point(0, 0);
            this.btnFloresRegistro.Name = "btnFloresRegistro";
            this.btnFloresRegistro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFloresRegistro.Size = new System.Drawing.Size(233, 40);
            this.btnFloresRegistro.TabIndex = 0;
            this.btnFloresRegistro.Text = "Registrar Flores";
            this.btnFloresRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloresRegistro.UseVisualStyleBackColor = true;
            this.btnFloresRegistro.Click += new System.EventHandler(this.btnFloresRegistro_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Khaki;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(814, 454);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelProveedoresSubMenu
            // 
            this.panelProveedoresSubMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.panelProveedoresSubMenu.Controls.Add(this.btnProveedoresConsultar);
            this.panelProveedoresSubMenu.Controls.Add(this.btnProveedoresEliminar);
            this.panelProveedoresSubMenu.Controls.Add(this.btnProveedoresEditar);
            this.panelProveedoresSubMenu.Controls.Add(this.btnProveedoresRegistrar);
            this.panelProveedoresSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProveedoresSubMenu.Location = new System.Drawing.Point(0, 890);
            this.panelProveedoresSubMenu.Name = "panelProveedoresSubMenu";
            this.panelProveedoresSubMenu.Size = new System.Drawing.Size(233, 165);
            this.panelProveedoresSubMenu.TabIndex = 10;
            this.panelProveedoresSubMenu.Visible = false;
            // 
            // btnProveedoresConsultar
            // 
            this.btnProveedoresConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedoresConsultar.FlatAppearance.BorderSize = 0;
            this.btnProveedoresConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedoresConsultar.ForeColor = System.Drawing.Color.White;
            this.btnProveedoresConsultar.Location = new System.Drawing.Point(0, 120);
            this.btnProveedoresConsultar.Name = "btnProveedoresConsultar";
            this.btnProveedoresConsultar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProveedoresConsultar.Size = new System.Drawing.Size(233, 40);
            this.btnProveedoresConsultar.TabIndex = 3;
            this.btnProveedoresConsultar.Text = "Ver Listado de Proveedores";
            this.btnProveedoresConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedoresConsultar.UseVisualStyleBackColor = true;
            this.btnProveedoresConsultar.Click += new System.EventHandler(this.btnProveedoresConsultar_Click);
            // 
            // btnProveedoresEliminar
            // 
            this.btnProveedoresEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedoresEliminar.FlatAppearance.BorderSize = 0;
            this.btnProveedoresEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedoresEliminar.ForeColor = System.Drawing.Color.White;
            this.btnProveedoresEliminar.Location = new System.Drawing.Point(0, 80);
            this.btnProveedoresEliminar.Name = "btnProveedoresEliminar";
            this.btnProveedoresEliminar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProveedoresEliminar.Size = new System.Drawing.Size(233, 40);
            this.btnProveedoresEliminar.TabIndex = 2;
            this.btnProveedoresEliminar.Text = "Eliminar Proveedor";
            this.btnProveedoresEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedoresEliminar.UseVisualStyleBackColor = true;
            this.btnProveedoresEliminar.Click += new System.EventHandler(this.btnProveedoresEliminar_Click);
            // 
            // btnProveedoresEditar
            // 
            this.btnProveedoresEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedoresEditar.FlatAppearance.BorderSize = 0;
            this.btnProveedoresEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedoresEditar.ForeColor = System.Drawing.Color.White;
            this.btnProveedoresEditar.Location = new System.Drawing.Point(0, 40);
            this.btnProveedoresEditar.Name = "btnProveedoresEditar";
            this.btnProveedoresEditar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProveedoresEditar.Size = new System.Drawing.Size(233, 40);
            this.btnProveedoresEditar.TabIndex = 1;
            this.btnProveedoresEditar.Text = "Editar Proveedor";
            this.btnProveedoresEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedoresEditar.UseVisualStyleBackColor = true;
            this.btnProveedoresEditar.Click += new System.EventHandler(this.btnProveedoresEditar_Click);
            // 
            // btnProveedoresRegistrar
            // 
            this.btnProveedoresRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedoresRegistrar.FlatAppearance.BorderSize = 0;
            this.btnProveedoresRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedoresRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnProveedoresRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnProveedoresRegistrar.Name = "btnProveedoresRegistrar";
            this.btnProveedoresRegistrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProveedoresRegistrar.Size = new System.Drawing.Size(233, 40);
            this.btnProveedoresRegistrar.TabIndex = 0;
            this.btnProveedoresRegistrar.Text = "Registrar Proveedor";
            this.btnProveedoresRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedoresRegistrar.UseVisualStyleBackColor = true;
            this.btnProveedoresRegistrar.Click += new System.EventHandler(this.btnProveedoresRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GUI.Properties.Resources.girasol;
            this.pictureBox1.Location = new System.Drawing.Point(262, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Gold;
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = global::GUI.Properties.Resources.inventario__1_;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedores.Location = new System.Drawing.Point(0, 845);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(233, 45);
            this.btnProveedores.TabIndex = 9;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Gold;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::GUI.Properties.Resources.cliente;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.Location = new System.Drawing.Point(0, 635);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(233, 45);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Gold;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = global::GUI.Properties.Resources.shopping_bag;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.Location = new System.Drawing.Point(0, 506);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(233, 45);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Gold;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = global::GUI.Properties.Resources.man;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 303);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(233, 45);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnFlores
            // 
            this.btnFlores.BackColor = System.Drawing.Color.Gold;
            this.btnFlores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFlores.FlatAppearance.BorderSize = 0;
            this.btnFlores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlores.ForeColor = System.Drawing.Color.White;
            this.btnFlores.Image = global::GUI.Properties.Resources.rosa__1_;
            this.btnFlores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFlores.Location = new System.Drawing.Point(0, 100);
            this.btnFlores.Name = "btnFlores";
            this.btnFlores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFlores.Size = new System.Drawing.Size(233, 45);
            this.btnFlores.TabIndex = 1;
            this.btnFlores.Text = "Flores";
            this.btnFlores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlores.UseVisualStyleBackColor = false;
            this.btnFlores.Click += new System.EventHandler(this.btnFlores_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::GUI.Properties.Resources.girasol;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 454);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelClientesSubMenu.ResumeLayout(false);
            this.panelVentasSubMenu.ResumeLayout(false);
            this.panelEmpleadoSubMenu.ResumeLayout(false);
            this.panelFloresSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelProveedoresSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelVentasSubMenu;
        private System.Windows.Forms.Button btnVentasVer;
        private System.Windows.Forms.Button btnVentasRegistrar;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelEmpleadoSubMenu;
        private System.Windows.Forms.Button btnEmpleadosVer;
        private System.Windows.Forms.Button btnEmpleadosEliminar;
        private System.Windows.Forms.Button btnEmpleadosEditar;
        private System.Windows.Forms.Button btnEmpleadosRegistrar;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel panelFloresSubMenu;
        private System.Windows.Forms.Button btnFloresVer;
        private System.Windows.Forms.Button btnFloresEliminar;
        private System.Windows.Forms.Button btnFloresEditar;
        private System.Windows.Forms.Button btnFloresRegistro;
        private System.Windows.Forms.Button btnFlores;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelClientesSubMenu;
        private System.Windows.Forms.Button btnClientesConsultar;
        private System.Windows.Forms.Button btnClientesEliminar;
        private System.Windows.Forms.Button btnClientesEditar;
        private System.Windows.Forms.Button btnClientesRegistrar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelProveedoresSubMenu;
        private System.Windows.Forms.Button btnProveedoresConsultar;
        private System.Windows.Forms.Button btnProveedoresEliminar;
        private System.Windows.Forms.Button btnProveedoresEditar;
        private System.Windows.Forms.Button btnProveedoresRegistrar;
        private System.Windows.Forms.Button btnProveedores;
    }
}