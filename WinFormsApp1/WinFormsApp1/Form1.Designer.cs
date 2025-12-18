namespace WinFormsApp1
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtInstagram = new TextBox();
            txtFacebook = new TextBox();
            txtLinkedIn = new TextBox();
            btnBuscar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            dataGridView1 = new DataGridView();
            txtEliminarcontacto = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(127, 105);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(127, 134);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 9;
            // 
            // txtInstagram
            // 
            txtInstagram.Location = new Point(127, 164);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.Size = new Size(100, 23);
            txtInstagram.TabIndex = 10;
            // 
            // txtFacebook
            // 
            txtFacebook.Location = new Point(127, 192);
            txtFacebook.Name = "txtFacebook";
            txtFacebook.Size = new Size(100, 23);
            txtFacebook.TabIndex = 11;
            // 
            // txtLinkedIn
            // 
            txtLinkedIn.Location = new Point(127, 221);
            txtLinkedIn.Name = "txtLinkedIn";
            txtLinkedIn.Size = new Size(100, 23);
            txtLinkedIn.TabIndex = 12;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(127, 273);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(239, 273);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(367, 273);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 150);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtEliminarcontacto
            // 
            txtEliminarcontacto.Location = new Point(487, 273);
            txtEliminarcontacto.Name = "txtEliminarcontacto";
            txtEliminarcontacto.Size = new Size(75, 23);
            txtEliminarcontacto.TabIndex = 17;
            txtEliminarcontacto.Text = "Eliminar Contacto";
            txtEliminarcontacto.UseVisualStyleBackColor = true;
            txtEliminarcontacto.Click += txtEliminarcontacto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 18;
            label1.Text = "Agenda Contactos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 76);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 105);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 20;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 137);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 21;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 167);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 22;
            label5.Text = "Instagram";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 192);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 23;
            label6.Text = "Facebook";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 221);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 24;
            label7.Text = "LinkedIn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(697, 323);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEliminarcontacto);
            Controls.Add(dataGridView1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(txtLinkedIn);
            Controls.Add(txtFacebook);
            Controls.Add(txtInstagram);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion  private void dataGridView1_CellContentClick(private 
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtInstagram;
        private TextBox txtFacebook;
        private TextBox txtLinkedIn;
        private Button btnBuscar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private DataGridView dataGridView1;
        private Button txtEliminarcontacto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
