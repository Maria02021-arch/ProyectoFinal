namespace proyectofinal
{
    partial class FormProveedores
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
            txtNombre = new TextBox();
            txtContacto = new TextBox();
            btnAgregar = new Button();
            dgvProveedores = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(276, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(276, 164);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(213, 23);
            txtContacto.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(303, 339);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 71);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(276, 232);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowTemplate.Height = 25;
            dgvProveedores.Size = new Size(213, 70);
            dgvProveedores.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 56);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 140);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "Contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 209);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Contactos";
            //label3.Click += label3_Click;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProveedores);
            Controls.Add(btnAgregar);
            Controls.Add(txtContacto);
            Controls.Add(txtNombre);
            Name = "FormProveedores";
            Text = "FormProveedores";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtContacto;
        private Button btnAgregar;
        private DataGridView dgvProveedores;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}