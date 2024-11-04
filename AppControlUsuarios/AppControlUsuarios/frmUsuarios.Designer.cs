namespace AppControlUsuarios
{
    partial class frmUsuarios
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelOpciones = new Panel();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            dgvListaUsuarios = new DataGridView();
            panelNotificaciones = new Panel();
            lblMensaje = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            panelNotificaciones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelOpciones, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvListaUsuarios, 0, 1);
            tableLayoutPanel1.Controls.Add(panelNotificaciones, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(675, 341);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelOpciones
            // 
            panelOpciones.BackColor = SystemColors.ControlDark;
            panelOpciones.Controls.Add(btnActualizar);
            panelOpciones.Controls.Add(btnEliminar);
            panelOpciones.Controls.Add(btnNuevo);
            panelOpciones.Dock = DockStyle.Fill;
            panelOpciones.Location = new Point(0, 0);
            panelOpciones.Margin = new Padding(0);
            panelOpciones.Name = "panelOpciones";
            panelOpciones.Size = new Size(675, 50);
            panelOpciones.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Location = new Point(573, 11);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Location = new Point(492, 11);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.Location = new Point(411, 11);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToDeleteRows = false;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuarios.Dock = DockStyle.Fill;
            dgvListaUsuarios.Location = new Point(0, 50);
            dgvListaUsuarios.Margin = new Padding(0);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.Size = new Size(675, 261);
            dgvListaUsuarios.TabIndex = 1;
            // 
            // panelNotificaciones
            // 
            panelNotificaciones.BackColor = Color.DimGray;
            panelNotificaciones.Controls.Add(lblMensaje);
            panelNotificaciones.Dock = DockStyle.Fill;
            panelNotificaciones.Location = new Point(0, 311);
            panelNotificaciones.Margin = new Padding(0);
            panelNotificaciones.Name = "panelNotificaciones";
            panelNotificaciones.RightToLeft = RightToLeft.Yes;
            panelNotificaciones.Size = new Size(675, 30);
            panelNotificaciones.TabIndex = 2;
            // 
            // lblMensaje
            // 
            lblMensaje.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMensaje.AutoSize = true;
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(610, 3);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 0;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 341);
            Controls.Add(tableLayoutPanel1);
            Name = "frmUsuarios";
            Text = "Control de usuarios";
            tableLayoutPanel1.ResumeLayout(false);
            panelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            panelNotificaciones.ResumeLayout(false);
            panelNotificaciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelOpciones;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnNuevo;
        private DataGridView dgvListaUsuarios;
        private Panel panelNotificaciones;
        private Label lblMensaje;
    }
}
