﻿
namespace CapaDePresentacion
{
    partial class FormUsuarios
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.groupBoxCRUDEntity = new System.Windows.Forms.GroupBox();
            this.buttonEliminarUsuarioEF = new System.Windows.Forms.Button();
            this.buttonActualizarUsuarioEF = new System.Windows.Forms.Button();
            this.buttonInsertarUsuarioEF = new System.Windows.Forms.Button();
            this.groupBoxCRUD_SP = new System.Windows.Forms.GroupBox();
            this.buttonEliminarUsuario = new System.Windows.Forms.Button();
            this.buttonInsertarUsuario = new System.Windows.Forms.Button();
            this.buttonActualizarUsuario = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFacturas = new System.Windows.Forms.ComboBox();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.txtNDoc = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCorreoFormInformacion = new System.Windows.Forms.Label();
            this.lblGeneroFormInformacion = new System.Windows.Forms.Label();
            this.lblFechaNacFormInformacion = new System.Windows.Forms.Label();
            this.lblNumDocFormInformacion = new System.Windows.Forms.Label();
            this.lblTipoDocumFormInformacion = new System.Windows.Forms.Label();
            this.lblApellidosFormInformacion = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.groupBoxCRUDEntity.SuspendLayout();
            this.groupBoxCRUD_SP.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSalir.Location = new System.Drawing.Point(602, 392);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(113, 52);
            this.buttonSalir.TabIndex = 61;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(378, 55);
            this.dataGridViewUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.RowHeadersWidth = 51;
            this.dataGridViewUsuario.RowTemplate.Height = 24;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(377, 320);
            this.dataGridViewUsuario.TabIndex = 60;
            // 
            // groupBoxCRUDEntity
            // 
            this.groupBoxCRUDEntity.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxCRUDEntity.Controls.Add(this.buttonEliminarUsuarioEF);
            this.groupBoxCRUDEntity.Controls.Add(this.buttonActualizarUsuarioEF);
            this.groupBoxCRUDEntity.Controls.Add(this.buttonInsertarUsuarioEF);
            this.groupBoxCRUDEntity.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCRUDEntity.Location = new System.Drawing.Point(14, 389);
            this.groupBoxCRUDEntity.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCRUDEntity.Name = "groupBoxCRUDEntity";
            this.groupBoxCRUDEntity.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCRUDEntity.Size = new System.Drawing.Size(348, 79);
            this.groupBoxCRUDEntity.TabIndex = 59;
            this.groupBoxCRUDEntity.TabStop = false;
            this.groupBoxCRUDEntity.Text = "CRUD Entity Framework";
            // 
            // buttonEliminarUsuarioEF
            // 
            this.buttonEliminarUsuarioEF.BackColor = System.Drawing.Color.Khaki;
            this.buttonEliminarUsuarioEF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarUsuarioEF.Location = new System.Drawing.Point(248, 26);
            this.buttonEliminarUsuarioEF.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminarUsuarioEF.Name = "buttonEliminarUsuarioEF";
            this.buttonEliminarUsuarioEF.Size = new System.Drawing.Size(94, 40);
            this.buttonEliminarUsuarioEF.TabIndex = 17;
            this.buttonEliminarUsuarioEF.Text = "ELIMINAR";
            this.buttonEliminarUsuarioEF.UseVisualStyleBackColor = false;
            this.buttonEliminarUsuarioEF.Click += new System.EventHandler(this.buttonEliminarUsuarioEF_Click);
            // 
            // buttonActualizarUsuarioEF
            // 
            this.buttonActualizarUsuarioEF.BackColor = System.Drawing.Color.Khaki;
            this.buttonActualizarUsuarioEF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarUsuarioEF.Location = new System.Drawing.Point(124, 26);
            this.buttonActualizarUsuarioEF.Margin = new System.Windows.Forms.Padding(2);
            this.buttonActualizarUsuarioEF.Name = "buttonActualizarUsuarioEF";
            this.buttonActualizarUsuarioEF.Size = new System.Drawing.Size(120, 40);
            this.buttonActualizarUsuarioEF.TabIndex = 16;
            this.buttonActualizarUsuarioEF.Text = "ACTUALIZAR";
            this.buttonActualizarUsuarioEF.UseVisualStyleBackColor = false;
            this.buttonActualizarUsuarioEF.Click += new System.EventHandler(this.buttonActualizarUsuarioEF_Click);
            // 
            // buttonInsertarUsuarioEF
            // 
            this.buttonInsertarUsuarioEF.BackColor = System.Drawing.Color.Khaki;
            this.buttonInsertarUsuarioEF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarUsuarioEF.Location = new System.Drawing.Point(14, 26);
            this.buttonInsertarUsuarioEF.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInsertarUsuarioEF.Name = "buttonInsertarUsuarioEF";
            this.buttonInsertarUsuarioEF.Size = new System.Drawing.Size(106, 40);
            this.buttonInsertarUsuarioEF.TabIndex = 15;
            this.buttonInsertarUsuarioEF.Text = "INSERTAR";
            this.buttonInsertarUsuarioEF.UseVisualStyleBackColor = false;
            this.buttonInsertarUsuarioEF.Click += new System.EventHandler(this.buttonInsertarUsuarioEF_Click);
            // 
            // groupBoxCRUD_SP
            // 
            this.groupBoxCRUD_SP.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxCRUD_SP.Controls.Add(this.buttonEliminarUsuario);
            this.groupBoxCRUD_SP.Controls.Add(this.buttonInsertarUsuario);
            this.groupBoxCRUD_SP.Controls.Add(this.buttonActualizarUsuario);
            this.groupBoxCRUD_SP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCRUD_SP.Location = new System.Drawing.Point(14, 296);
            this.groupBoxCRUD_SP.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCRUD_SP.Name = "groupBoxCRUD_SP";
            this.groupBoxCRUD_SP.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCRUD_SP.Size = new System.Drawing.Size(348, 79);
            this.groupBoxCRUD_SP.TabIndex = 58;
            this.groupBoxCRUD_SP.TabStop = false;
            this.groupBoxCRUD_SP.Text = "CRUD ADO .NET";
            this.groupBoxCRUD_SP.Enter += new System.EventHandler(this.groupBoxCRUD_SP_Enter);
            // 
            // buttonEliminarUsuario
            // 
            this.buttonEliminarUsuario.BackColor = System.Drawing.Color.Khaki;
            this.buttonEliminarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarUsuario.Location = new System.Drawing.Point(248, 27);
            this.buttonEliminarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            this.buttonEliminarUsuario.Size = new System.Drawing.Size(94, 40);
            this.buttonEliminarUsuario.TabIndex = 14;
            this.buttonEliminarUsuario.Text = "ELIMINAR";
            this.buttonEliminarUsuario.UseVisualStyleBackColor = false;
            this.buttonEliminarUsuario.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // buttonInsertarUsuario
            // 
            this.buttonInsertarUsuario.BackColor = System.Drawing.Color.Khaki;
            this.buttonInsertarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarUsuario.Location = new System.Drawing.Point(14, 27);
            this.buttonInsertarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInsertarUsuario.Name = "buttonInsertarUsuario";
            this.buttonInsertarUsuario.Size = new System.Drawing.Size(106, 40);
            this.buttonInsertarUsuario.TabIndex = 12;
            this.buttonInsertarUsuario.Text = "INSERTAR";
            this.buttonInsertarUsuario.UseVisualStyleBackColor = false;
            this.buttonInsertarUsuario.Click += new System.EventHandler(this.buttonInsertarUsuario_Click);
            // 
            // buttonActualizarUsuario
            // 
            this.buttonActualizarUsuario.BackColor = System.Drawing.Color.Khaki;
            this.buttonActualizarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarUsuario.Location = new System.Drawing.Point(124, 27);
            this.buttonActualizarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonActualizarUsuario.Name = "buttonActualizarUsuario";
            this.buttonActualizarUsuario.Size = new System.Drawing.Size(120, 40);
            this.buttonActualizarUsuario.TabIndex = 13;
            this.buttonActualizarUsuario.Text = "ACTUALIZAR";
            this.buttonActualizarUsuario.UseVisualStyleBackColor = false;
            this.buttonActualizarUsuario.Click += new System.EventHandler(this.buttonActualizarUsuario_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(222, 55);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(140, 20);
            this.txtNombres.TabIndex = 57;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 22);
            this.lblNombre.TabIndex = 56;
            this.lblNombre.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Ver factura:";
            // 
            // cmbFacturas
            // 
            this.cmbFacturas.FormattingEnabled = true;
            this.cmbFacturas.Location = new System.Drawing.Point(447, 435);
            this.cmbFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFacturas.Name = "cmbFacturas";
            this.cmbFacturas.Size = new System.Drawing.Size(96, 21);
            this.cmbFacturas.TabIndex = 54;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(378, 389);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(165, 34);
            this.btnFacturacion.TabIndex = 53;
            this.btnFacturacion.Text = "Agregar Producto a Inventario";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // txtGenero
            // 
            this.txtGenero.Enabled = false;
            this.txtGenero.Location = new System.Drawing.Point(222, 225);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(140, 20);
            this.txtGenero.TabIndex = 52;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(222, 257);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(140, 20);
            this.txtCorreo.TabIndex = 51;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(222, 192);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(140, 20);
            this.txtFecha.TabIndex = 50;
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Enabled = false;
            this.txtTipoDoc.Location = new System.Drawing.Point(222, 119);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(140, 20);
            this.txtTipoDoc.TabIndex = 49;
            // 
            // txtNDoc
            // 
            this.txtNDoc.Enabled = false;
            this.txtNDoc.Location = new System.Drawing.Point(222, 155);
            this.txtNDoc.Name = "txtNDoc";
            this.txtNDoc.Size = new System.Drawing.Size(140, 20);
            this.txtNDoc.TabIndex = 48;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(221, 87);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(141, 20);
            this.txtApellido.TabIndex = 47;
            // 
            // lblCorreoFormInformacion
            // 
            this.lblCorreoFormInformacion.AutoSize = true;
            this.lblCorreoFormInformacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoFormInformacion.Location = new System.Drawing.Point(11, 255);
            this.lblCorreoFormInformacion.Name = "lblCorreoFormInformacion";
            this.lblCorreoFormInformacion.Size = new System.Drawing.Size(74, 22);
            this.lblCorreoFormInformacion.TabIndex = 46;
            this.lblCorreoFormInformacion.Text = "Correo:";
            // 
            // lblGeneroFormInformacion
            // 
            this.lblGeneroFormInformacion.AutoSize = true;
            this.lblGeneroFormInformacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroFormInformacion.Location = new System.Drawing.Point(11, 222);
            this.lblGeneroFormInformacion.Name = "lblGeneroFormInformacion";
            this.lblGeneroFormInformacion.Size = new System.Drawing.Size(76, 22);
            this.lblGeneroFormInformacion.TabIndex = 45;
            this.lblGeneroFormInformacion.Text = "Género:";
            // 
            // lblFechaNacFormInformacion
            // 
            this.lblFechaNacFormInformacion.AutoSize = true;
            this.lblFechaNacFormInformacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacFormInformacion.Location = new System.Drawing.Point(11, 189);
            this.lblFechaNacFormInformacion.Name = "lblFechaNacFormInformacion";
            this.lblFechaNacFormInformacion.Size = new System.Drawing.Size(183, 22);
            this.lblFechaNacFormInformacion.TabIndex = 44;
            this.lblFechaNacFormInformacion.Text = "Fecha de nacimiento:";
            // 
            // lblNumDocFormInformacion
            // 
            this.lblNumDocFormInformacion.AutoSize = true;
            this.lblNumDocFormInformacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDocFormInformacion.Location = new System.Drawing.Point(11, 152);
            this.lblNumDocFormInformacion.Name = "lblNumDocFormInformacion";
            this.lblNumDocFormInformacion.Size = new System.Drawing.Size(203, 22);
            this.lblNumDocFormInformacion.TabIndex = 43;
            this.lblNumDocFormInformacion.Text = "Número de Documento:";
            // 
            // lblTipoDocumFormInformacion
            // 
            this.lblTipoDocumFormInformacion.AutoSize = true;
            this.lblTipoDocumFormInformacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumFormInformacion.Location = new System.Drawing.Point(11, 116);
            this.lblTipoDocumFormInformacion.Name = "lblTipoDocumFormInformacion";
            this.lblTipoDocumFormInformacion.Size = new System.Drawing.Size(171, 22);
            this.lblTipoDocumFormInformacion.TabIndex = 42;
            this.lblTipoDocumFormInformacion.Text = "Tipo de documento:";
            // 
            // lblApellidosFormInformacion
            // 
            this.lblApellidosFormInformacion.AutoSize = true;
            this.lblApellidosFormInformacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosFormInformacion.Location = new System.Drawing.Point(11, 85);
            this.lblApellidosFormInformacion.Name = "lblApellidosFormInformacion";
            this.lblApellidosFormInformacion.Size = new System.Drawing.Size(90, 22);
            this.lblApellidosFormInformacion.TabIndex = 41;
            this.lblApellidosFormInformacion.Text = "Apellidos:";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(197, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(324, 26);
            this.lblMensaje.TabIndex = 40;
            this.lblMensaje.Text = "Datos Personales De Usuarios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.TabIndex = 39;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 474);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Controls.Add(this.groupBoxCRUDEntity);
            this.Controls.Add(this.groupBoxCRUD_SP);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFacturas);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.txtNDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblCorreoFormInformacion);
            this.Controls.Add(this.lblGeneroFormInformacion);
            this.Controls.Add(this.lblFechaNacFormInformacion);
            this.Controls.Add(this.lblNumDocFormInformacion);
            this.Controls.Add(this.lblTipoDocumFormInformacion);
            this.Controls.Add(this.lblApellidosFormInformacion);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuarios";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.groupBoxCRUDEntity.ResumeLayout(false);
            this.groupBoxCRUD_SP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.GroupBox groupBoxCRUDEntity;
        private System.Windows.Forms.Button buttonEliminarUsuarioEF;
        private System.Windows.Forms.Button buttonActualizarUsuarioEF;
        private System.Windows.Forms.Button buttonInsertarUsuarioEF;
        private System.Windows.Forms.GroupBox groupBoxCRUD_SP;
        private System.Windows.Forms.Button buttonEliminarUsuario;
        private System.Windows.Forms.Button buttonInsertarUsuario;
        private System.Windows.Forms.Button buttonActualizarUsuario;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFacturas;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.TextBox txtNDoc;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCorreoFormInformacion;
        private System.Windows.Forms.Label lblGeneroFormInformacion;
        private System.Windows.Forms.Label lblFechaNacFormInformacion;
        private System.Windows.Forms.Label lblNumDocFormInformacion;
        private System.Windows.Forms.Label lblTipoDocumFormInformacion;
        private System.Windows.Forms.Label lblApellidosFormInformacion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
    }
}