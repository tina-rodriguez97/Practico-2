namespace Practico_2
{
    partial class PequeñoFormulario
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
            lblNyA = new Label();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblModificar = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblNyA
            // 
            lblNyA.AutoSize = true;
            lblNyA.Location = new Point(24, 34);
            lblNyA.Name = "lblNyA";
            lblNyA.Size = new Size(110, 15);
            lblNyA.TabIndex = 0;
            lblNyA.Text = "Nombre y Apellido:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(24, 99);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(24, 203);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 148);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtDNI
            // 
            txtDNI.AccessibleRole = AccessibleRole.Cursor;
            txtDNI.Location = new Point(132, 91);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(154, 23);
            txtDNI.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 145);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(132, 200);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(154, 23);
            txtApellido.TabIndex = 6;
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.ForeColor = Color.Red;
            lblModificar.Location = new Point(157, 34);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(55, 15);
            lblModificar.TabIndex = 7;
            lblModificar.Text = "modficar";
            // 
            // btnGuardar
            // 
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(37, 250);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 28);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(186, 250);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 28);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // PequeñoFormulario
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 380);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(lblModificar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblDNI);
            Controls.Add(lblNyA);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "PequeñoFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pequeño Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNyA;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblModificar;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}
