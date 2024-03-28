using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace Aplicacion_limpieza
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            ocultar_sub_menus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ocultar_sub_menus()
        {
            panelAgenciaSubmenu.Visible = false;
            panelApartamentosSubmenu.Visible = false;
            panelEmpleadoSubmenu.Visible = false;
            panelLimpiezasSubmenu.Visible = false;
        }

        private void sub_menus_logica()
        {
            if(panelAgenciaSubmenu.Visible == true)
            {
                panelAgenciaSubmenu.Visible = false;
            }

            if (panelApartamentosSubmenu.Visible == true)
            {
                panelApartamentosSubmenu.Visible = false;
            }

            if (panelEmpleadoSubmenu.Visible == true)
            {
                panelEmpleadoSubmenu.Visible = false;
            }

            if (panelLimpiezasSubmenu.Visible == true)
            {
                panelLimpiezasSubmenu.Visible = false;
            }
        }

        private void mostrar_submenus(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                sub_menus_logica();
                SubMenu.Visible = true;

            }
            else
                SubMenu.Visible = false;
            
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            mostrar_submenus(panelEmpleadoSubmenu);
        }

        private void btn_agencias_Click(object sender, EventArgs e)
        {
            mostrar_submenus(panelAgenciaSubmenu);
        }

        private void btn_apartamentos_Click(object sender, EventArgs e)
        {
            mostrar_submenus(panelApartamentosSubmenu);
        }

        private void btn_limpiezas_Click(object sender, EventArgs e)
        {
            mostrar_submenus(panelLimpiezasSubmenu);
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_empleados_Click(object sender, EventArgs e)
        {

        }
    }
}
