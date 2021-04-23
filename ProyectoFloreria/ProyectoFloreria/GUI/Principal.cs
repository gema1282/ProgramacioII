using GUI.Clientes;
using GUI.Flores;
using GUI.Proveedores;
using GUI.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            customDesign();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
        private void customDesign()
        {
            panelEmpleadoSubMenu.Visible = false;
            panelFloresSubMenu.Visible = false;
            panelVentasSubMenu.Visible = false;
        }
        private void hideSubMenu() 
        {
            if (panelFloresSubMenu.Visible==true) 
            {
                panelFloresSubMenu.Visible = false;
            }
            if (panelEmpleadoSubMenu.Visible == true)
            {
                panelEmpleadoSubMenu.Visible = false;
            }
            if (panelVentasSubMenu.Visible == true)
            {
                panelVentasSubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnFlores_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFloresSubMenu);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpleadoSubMenu);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentasSubMenu);
        }
        private Form active = null;
        private void openChild(Form child)
        {
            if (active!=null)
            {
                active.Close();
            }
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(child);
            panelChildForm.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void btnEmpleadosRegistrar_Click(object sender, EventArgs e)
        {
            openChild(new RegistroEmpleados());
            hideSubMenu();
        }

        private void btnFloresRegistro_Click(object sender, EventArgs e)
        {
            openChild(new AgregarFlores());
            hideSubMenu();
        }

        private void btnEmpleadosEditar_Click(object sender, EventArgs e)
        {
            openChild(new EditarEmpleados());
            hideSubMenu();
        }

        private void btnEmpleadosVer_Click(object sender, EventArgs e)
        {
            openChild(new ConsultarEmpleado());
            hideSubMenu();
        }

        private void btnEmpleadosEliminar_Click(object sender, EventArgs e)
        {
            openChild(new EliminarEmpleado());
            hideSubMenu();
        }

        private void btnFloresEditar_Click(object sender, EventArgs e)
        {
            openChild(new EditarFlores());
            hideSubMenu();
        }

        private void btnFloresEliminar_Click(object sender, EventArgs e)
        {
            openChild(new EliminarFlores());
            hideSubMenu();
        }

        private void btnFloresVer_Click(object sender, EventArgs e)
        {
            openChild(new ConsultarFlores());
            hideSubMenu();
        }

        private void btnVentasRegistrar_Click(object sender, EventArgs e)
        {
            openChild(new RealizarVentas());
            hideSubMenu();
        }

        private void btnVentasVer_Click(object sender, EventArgs e)
        {
            openChild(new ConsultarVentas());
            hideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientesSubMenu);
        }

        private void btnClientesRegistrar_Click(object sender, EventArgs e)
        {
            openChild(new RegistrarClientes());
            hideSubMenu();
        }

        private void btnClientesEditar_Click(object sender, EventArgs e)
        {
            openChild(new EditarClientes());
            hideSubMenu();
        }

        private void btnClientesEliminar_Click(object sender, EventArgs e)
        {
            openChild(new EliminarClientes());
            hideSubMenu();
        }

        private void btnClientesConsultar_Click(object sender, EventArgs e)
        {
            openChild(new ConsultarClientes());
            hideSubMenu();
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProveedoresSubMenu);
        }

        private void btnProveedoresRegistrar_Click(object sender, EventArgs e)
        {
            openChild(new AgregarProveedores());
            hideSubMenu();
        }

        private void btnProveedoresEditar_Click(object sender, EventArgs e)
        {
            openChild(new EditarProveedores());
            hideSubMenu();
        }

        private void btnProveedoresEliminar_Click(object sender, EventArgs e)
        {
            openChild(new EliminarProveedores());
            hideSubMenu();
        }

        private void btnProveedoresConsultar_Click(object sender, EventArgs e)
        {
            openChild(new ConsultarProveedores());
            hideSubMenu();
        }
    }
}
