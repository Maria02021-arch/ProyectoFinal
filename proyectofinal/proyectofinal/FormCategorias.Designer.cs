namespace proyectofinal
{
    partial class FormCategorias
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
            btnAgregar = new Button();
            dgvCategorias = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(308, 106);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 23);
            txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(291, 317);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(188, 68);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(274, 213);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowTemplate.Height = 25;
            dgvCategorias.Size = new Size(221, 89);
            dgvCategorias.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 78);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 184);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Categoria";
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCategorias);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Name = "FormCategorias";
            Text = "FormCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button btnAgregar;
        private DataGridView dgvCategorias;
        private Label label1;
        private Label label2;
    }
}