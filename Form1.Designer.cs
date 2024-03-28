namespace Aplicacion_limpieza
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel_ayuda = new System.Windows.Forms.Panel();
            this.panel_mi_negocio = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.panelLimpiezasSubmenu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_limpiezas = new System.Windows.Forms.Button();
            this.panelApartamentosSubmenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_apartamentos = new System.Windows.Forms.Button();
            this.panelAgenciaSubmenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_ver_agencias = new System.Windows.Forms.Button();
            this.btn_agencias = new System.Windows.Forms.Button();
            this.panelEmpleadoSubmenu = new System.Windows.Forms.Panel();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.kryptonSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_editar_empleados = new System.Windows.Forms.Button();
            this.btn_agregar_empleados = new System.Windows.Forms.Button();
            this.btn_ver_empleados = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.panel_mi_negocio.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panelLimpiezasSubmenu.SuspendLayout();
            this.panelApartamentosSubmenu.SuspendLayout();
            this.panelAgenciaSubmenu.SuspendLayout();
            this.panelEmpleadoSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
            // 
            // panel_ayuda
            // 
            this.panel_ayuda.BackColor = System.Drawing.Color.Azure;
            this.panel_ayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ayuda.Location = new System.Drawing.Point(0, 0);
            this.panel_ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.panel_ayuda.Name = "panel_ayuda";
            this.panel_ayuda.Padding = new System.Windows.Forms.Padding(4);
            this.panel_ayuda.Size = new System.Drawing.Size(140, 59);
            this.panel_ayuda.TabIndex = 2;
            // 
            // panel_mi_negocio
            // 
            this.panel_mi_negocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mi_negocio.Controls.Add(this.checkBox1);
            this.panel_mi_negocio.Location = new System.Drawing.Point(184, 11);
            this.panel_mi_negocio.Margin = new System.Windows.Forms.Padding(2);
            this.panel_mi_negocio.Name = "panel_mi_negocio";
            this.panel_mi_negocio.Size = new System.Drawing.Size(703, 49);
            this.panel_mi_negocio.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(67, 29);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel_menu
            // 
            this.panel_menu.AutoScroll = true;
            this.panel_menu.BackColor = System.Drawing.Color.Azure;
            this.panel_menu.Controls.Add(this.btn_reportes);
            this.panel_menu.Controls.Add(this.panelLimpiezasSubmenu);
            this.panel_menu.Controls.Add(this.btn_limpiezas);
            this.panel_menu.Controls.Add(this.panelApartamentosSubmenu);
            this.panel_menu.Controls.Add(this.btn_apartamentos);
            this.panel_menu.Controls.Add(this.panelAgenciaSubmenu);
            this.panel_menu.Controls.Add(this.btn_agencias);
            this.panel_menu.Controls.Add(this.panelEmpleadoSubmenu);
            this.panel_menu.Controls.Add(this.btn_empleados);
            this.panel_menu.Controls.Add(this.btn_inicio);
            this.panel_menu.Controls.Add(this.kryptonSeparator1);
            this.panel_menu.Controls.Add(this.panel_ayuda);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(157, 538);
            this.panel_menu.TabIndex = 4;
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(0, 636);
            this.btn_reportes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_reportes.Size = new System.Drawing.Size(140, 38);
            this.btn_reportes.TabIndex = 13;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = false;
            // 
            // panelLimpiezasSubmenu
            // 
            this.panelLimpiezasSubmenu.AutoSize = true;
            this.panelLimpiezasSubmenu.BackColor = System.Drawing.Color.LightBlue;
            this.panelLimpiezasSubmenu.Controls.Add(this.button7);
            this.panelLimpiezasSubmenu.Controls.Add(this.button8);
            this.panelLimpiezasSubmenu.Controls.Add(this.button9);
            this.panelLimpiezasSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLimpiezasSubmenu.Location = new System.Drawing.Point(0, 540);
            this.panelLimpiezasSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelLimpiezasSubmenu.Name = "panelLimpiezasSubmenu";
            this.panelLimpiezasSubmenu.Size = new System.Drawing.Size(140, 96);
            this.panelLimpiezasSubmenu.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::Aplicacion_limpieza.Properties.Resources.editar;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 64);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(140, 32);
            this.button7.TabIndex = 8;
            this.button7.Text = "Editar / Eliminar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::Aplicacion_limpieza.Properties.Resources.boton_mas;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 32);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(140, 32);
            this.button8.TabIndex = 7;
            this.button8.Text = "Agregar";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Image = global::Aplicacion_limpieza.Properties.Resources.ver;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(140, 32);
            this.button9.TabIndex = 6;
            this.button9.Text = "Visualizar";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btn_limpiezas
            // 
            this.btn_limpiezas.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpiezas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_limpiezas.FlatAppearance.BorderSize = 0;
            this.btn_limpiezas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiezas.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_limpiezas.Image = global::Aplicacion_limpieza.Properties.Resources.limpieza_de_datos;
            this.btn_limpiezas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiezas.Location = new System.Drawing.Point(0, 502);
            this.btn_limpiezas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpiezas.Name = "btn_limpiezas";
            this.btn_limpiezas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_limpiezas.Size = new System.Drawing.Size(140, 38);
            this.btn_limpiezas.TabIndex = 11;
            this.btn_limpiezas.Text = "Limpiezas";
            this.btn_limpiezas.UseVisualStyleBackColor = false;
            this.btn_limpiezas.Click += new System.EventHandler(this.btn_limpiezas_Click);
            // 
            // panelApartamentosSubmenu
            // 
            this.panelApartamentosSubmenu.AutoSize = true;
            this.panelApartamentosSubmenu.BackColor = System.Drawing.Color.LightBlue;
            this.panelApartamentosSubmenu.Controls.Add(this.button2);
            this.panelApartamentosSubmenu.Controls.Add(this.button3);
            this.panelApartamentosSubmenu.Controls.Add(this.button4);
            this.panelApartamentosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApartamentosSubmenu.Location = new System.Drawing.Point(0, 406);
            this.panelApartamentosSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelApartamentosSubmenu.Name = "panelApartamentosSubmenu";
            this.panelApartamentosSubmenu.Size = new System.Drawing.Size(140, 96);
            this.panelApartamentosSubmenu.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Aplicacion_limpieza.Properties.Resources.editar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(140, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Editar / Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Aplicacion_limpieza.Properties.Resources.boton_mas;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(140, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Aplicacion_limpieza.Properties.Resources.ver;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(140, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "Visualizar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_apartamentos
            // 
            this.btn_apartamentos.AutoSize = true;
            this.btn_apartamentos.BackColor = System.Drawing.Color.Transparent;
            this.btn_apartamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_apartamentos.FlatAppearance.BorderSize = 0;
            this.btn_apartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apartamentos.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_apartamentos.Image = global::Aplicacion_limpieza.Properties.Resources.tienda;
            this.btn_apartamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apartamentos.Location = new System.Drawing.Point(0, 368);
            this.btn_apartamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_apartamentos.Name = "btn_apartamentos";
            this.btn_apartamentos.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_apartamentos.Size = new System.Drawing.Size(140, 38);
            this.btn_apartamentos.TabIndex = 9;
            this.btn_apartamentos.Text = "Apartamentos";
            this.btn_apartamentos.UseVisualStyleBackColor = false;
            this.btn_apartamentos.Click += new System.EventHandler(this.btn_apartamentos_Click);
            // 
            // panelAgenciaSubmenu
            // 
            this.panelAgenciaSubmenu.AutoSize = true;
            this.panelAgenciaSubmenu.BackColor = System.Drawing.Color.LightBlue;
            this.panelAgenciaSubmenu.Controls.Add(this.button5);
            this.panelAgenciaSubmenu.Controls.Add(this.button6);
            this.panelAgenciaSubmenu.Controls.Add(this.btn_ver_agencias);
            this.panelAgenciaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAgenciaSubmenu.Location = new System.Drawing.Point(0, 272);
            this.panelAgenciaSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelAgenciaSubmenu.Name = "panelAgenciaSubmenu";
            this.panelAgenciaSubmenu.Size = new System.Drawing.Size(140, 96);
            this.panelAgenciaSubmenu.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Aplicacion_limpieza.Properties.Resources.editar;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 64);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(140, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "Editar / Eliminar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::Aplicacion_limpieza.Properties.Resources.boton_mas;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 32);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(140, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "Agregar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btn_ver_agencias
            // 
            this.btn_ver_agencias.BackColor = System.Drawing.Color.Transparent;
            this.btn_ver_agencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ver_agencias.FlatAppearance.BorderSize = 0;
            this.btn_ver_agencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_agencias.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_agencias.Image = global::Aplicacion_limpieza.Properties.Resources.ver;
            this.btn_ver_agencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver_agencias.Location = new System.Drawing.Point(0, 0);
            this.btn_ver_agencias.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ver_agencias.Name = "btn_ver_agencias";
            this.btn_ver_agencias.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_ver_agencias.Size = new System.Drawing.Size(140, 32);
            this.btn_ver_agencias.TabIndex = 6;
            this.btn_ver_agencias.Text = "Visualizar";
            this.btn_ver_agencias.UseVisualStyleBackColor = false;
            // 
            // btn_agencias
            // 
            this.btn_agencias.BackColor = System.Drawing.Color.Transparent;
            this.btn_agencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agencias.FlatAppearance.BorderSize = 0;
            this.btn_agencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agencias.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_agencias.Image = global::Aplicacion_limpieza.Properties.Resources.tienda;
            this.btn_agencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agencias.Location = new System.Drawing.Point(0, 234);
            this.btn_agencias.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agencias.Name = "btn_agencias";
            this.btn_agencias.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_agencias.Size = new System.Drawing.Size(140, 38);
            this.btn_agencias.TabIndex = 7;
            this.btn_agencias.Text = "Agencias";
            this.btn_agencias.UseVisualStyleBackColor = false;
            this.btn_agencias.Click += new System.EventHandler(this.btn_agencias_Click);
            // 
            // panelEmpleadoSubmenu
            // 
            this.panelEmpleadoSubmenu.AutoSize = true;
            this.panelEmpleadoSubmenu.BackColor = System.Drawing.Color.LightBlue;
            this.panelEmpleadoSubmenu.Controls.Add(this.btn_editar_empleados);
            this.panelEmpleadoSubmenu.Controls.Add(this.btn_agregar_empleados);
            this.panelEmpleadoSubmenu.Controls.Add(this.btn_ver_empleados);
            this.panelEmpleadoSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpleadoSubmenu.Location = new System.Drawing.Point(0, 138);
            this.panelEmpleadoSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelEmpleadoSubmenu.Name = "panelEmpleadoSubmenu";
            this.panelEmpleadoSubmenu.Size = new System.Drawing.Size(140, 96);
            this.panelEmpleadoSubmenu.TabIndex = 6;
            // 
            // btn_empleados
            // 
            this.btn_empleados.BackColor = System.Drawing.Color.Transparent;
            this.btn_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_empleados.Image = global::Aplicacion_limpieza.Properties.Resources.persona;
            this.btn_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleados.Location = new System.Drawing.Point(0, 100);
            this.btn_empleados.Margin = new System.Windows.Forms.Padding(2);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_empleados.Size = new System.Drawing.Size(140, 38);
            this.btn_empleados.TabIndex = 5;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = false;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonSeparator1.Location = new System.Drawing.Point(0, 59);
            this.kryptonSeparator1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(140, 4);
            this.kryptonSeparator1.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.kryptonSeparator1.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.kryptonSeparator1.StateCommon.Separator.Back.Color1 = System.Drawing.Color.Black;
            this.kryptonSeparator1.StateCommon.Separator.Back.Color2 = System.Drawing.Color.Black;
            this.kryptonSeparator1.TabIndex = 3;
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Location = new System.Drawing.Point(184, 77);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(703, 454);
            this.panel_main.TabIndex = 5;
            // 
            // btn_editar_empleados
            // 
            this.btn_editar_empleados.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_editar_empleados.FlatAppearance.BorderSize = 0;
            this.btn_editar_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_empleados.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_empleados.Image = global::Aplicacion_limpieza.Properties.Resources.editar;
            this.btn_editar_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar_empleados.Location = new System.Drawing.Point(0, 64);
            this.btn_editar_empleados.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editar_empleados.Name = "btn_editar_empleados";
            this.btn_editar_empleados.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_editar_empleados.Size = new System.Drawing.Size(140, 32);
            this.btn_editar_empleados.TabIndex = 8;
            this.btn_editar_empleados.Text = "Editar / Eliminar";
            this.btn_editar_empleados.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_empleados
            // 
            this.btn_agregar_empleados.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregar_empleados.FlatAppearance.BorderSize = 0;
            this.btn_agregar_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_empleados.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_empleados.Image = global::Aplicacion_limpieza.Properties.Resources.boton_mas;
            this.btn_agregar_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_empleados.Location = new System.Drawing.Point(0, 32);
            this.btn_agregar_empleados.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar_empleados.Name = "btn_agregar_empleados";
            this.btn_agregar_empleados.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_agregar_empleados.Size = new System.Drawing.Size(140, 32);
            this.btn_agregar_empleados.TabIndex = 7;
            this.btn_agregar_empleados.Text = "Agregar";
            this.btn_agregar_empleados.UseVisualStyleBackColor = false;
            this.btn_agregar_empleados.Click += new System.EventHandler(this.btn_agregar_empleados_Click);
            // 
            // btn_ver_empleados
            // 
            this.btn_ver_empleados.BackColor = System.Drawing.Color.Transparent;
            this.btn_ver_empleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ver_empleados.FlatAppearance.BorderSize = 0;
            this.btn_ver_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_empleados.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_empleados.Image = global::Aplicacion_limpieza.Properties.Resources.ver;
            this.btn_ver_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver_empleados.Location = new System.Drawing.Point(0, 0);
            this.btn_ver_empleados.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ver_empleados.Name = "btn_ver_empleados";
            this.btn_ver_empleados.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_ver_empleados.Size = new System.Drawing.Size(140, 32);
            this.btn_ver_empleados.TabIndex = 6;
            this.btn_ver_empleados.Text = "Visualizar";
            this.btn_ver_empleados.UseVisualStyleBackColor = false;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Image = global::Aplicacion_limpieza.Properties.Resources.casa_icono_silueta__1_;
            this.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inicio.Location = new System.Drawing.Point(0, 63);
            this.btn_inicio.Margin = new System.Windows.Forms.Padding(2);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_inicio.Size = new System.Drawing.Size(140, 37);
            this.btn_inicio.TabIndex = 4;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 538);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_mi_negocio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_mi_negocio.ResumeLayout(false);
            this.panel_mi_negocio.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panelLimpiezasSubmenu.ResumeLayout(false);
            this.panelApartamentosSubmenu.ResumeLayout(false);
            this.panelAgenciaSubmenu.ResumeLayout(false);
            this.panelEmpleadoSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel_ayuda;
        private System.Windows.Forms.Panel panel_mi_negocio;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_main;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private System.Windows.Forms.Panel panelEmpleadoSubmenu;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_editar_empleados;
        private System.Windows.Forms.Button btn_agregar_empleados;
        private System.Windows.Forms.Button btn_ver_empleados;
        private System.Windows.Forms.Panel panelAgenciaSubmenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_ver_agencias;
        private System.Windows.Forms.Button btn_agencias;
        private System.Windows.Forms.Panel panelApartamentosSubmenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_apartamentos;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Panel panelLimpiezasSubmenu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_limpiezas;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

