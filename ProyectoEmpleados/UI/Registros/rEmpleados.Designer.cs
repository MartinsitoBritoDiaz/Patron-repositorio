namespace ProyectoEmpleados.UI.Registros
{
    partial class rEmpleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEmpleados));
            this.EmpleadoIdLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.CelularLabel = new System.Windows.Forms.Label();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.SueldoLabel = new System.Windows.Forms.Label();
            this.IncentivosLabel = new System.Windows.Forms.Label();
            this.EmpleadoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.SueldoTextBox = new System.Windows.Forms.TextBox();
            this.IncentivosTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadoIdLabel
            // 
            this.EmpleadoIdLabel.AutoSize = true;
            this.EmpleadoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadoIdLabel.Location = new System.Drawing.Point(44, 31);
            this.EmpleadoIdLabel.Name = "EmpleadoIdLabel";
            this.EmpleadoIdLabel.Size = new System.Drawing.Size(105, 20);
            this.EmpleadoIdLabel.TabIndex = 0;
            this.EmpleadoIdLabel.Text = "Empleado ID";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(253, 31);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(55, 20);
            this.FechaLabel.TabIndex = 1;
            this.FechaLabel.Text = "Fecha";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(44, 84);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(68, 20);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre";
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionLabel.Location = new System.Drawing.Point(44, 137);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(81, 20);
            this.DireccionLabel.TabIndex = 3;
            this.DireccionLabel.Text = "Direccion";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(44, 190);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(73, 20);
            this.TelefonoLabel.TabIndex = 4;
            this.TelefonoLabel.Text = "Telefono";
            // 
            // CelularLabel
            // 
            this.CelularLabel.AutoSize = true;
            this.CelularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularLabel.Location = new System.Drawing.Point(44, 244);
            this.CelularLabel.Name = "CelularLabel";
            this.CelularLabel.Size = new System.Drawing.Size(62, 20);
            this.CelularLabel.TabIndex = 5;
            this.CelularLabel.Text = "Celular";
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.Location = new System.Drawing.Point(44, 300);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(61, 20);
            this.CedulaLabel.TabIndex = 6;
            this.CedulaLabel.Text = "Cedula";
            // 
            // SueldoLabel
            // 
            this.SueldoLabel.AutoSize = true;
            this.SueldoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SueldoLabel.Location = new System.Drawing.Point(44, 355);
            this.SueldoLabel.Name = "SueldoLabel";
            this.SueldoLabel.Size = new System.Drawing.Size(60, 20);
            this.SueldoLabel.TabIndex = 7;
            this.SueldoLabel.Text = "Sueldo";
            // 
            // IncentivosLabel
            // 
            this.IncentivosLabel.AutoSize = true;
            this.IncentivosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncentivosLabel.Location = new System.Drawing.Point(44, 408);
            this.IncentivosLabel.Name = "IncentivosLabel";
            this.IncentivosLabel.Size = new System.Drawing.Size(84, 20);
            this.IncentivosLabel.TabIndex = 8;
            this.IncentivosLabel.Text = "Incentivos";
            // 
            // EmpleadoIdNumericUpDown
            // 
            this.EmpleadoIdNumericUpDown.Location = new System.Drawing.Point(167, 29);
            this.EmpleadoIdNumericUpDown.Name = "EmpleadoIdNumericUpDown";
            this.EmpleadoIdNumericUpDown.Size = new System.Drawing.Size(55, 22);
            this.EmpleadoIdNumericUpDown.TabIndex = 9;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(314, 29);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(142, 22);
            this.FechaDateTimePicker.TabIndex = 10;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(167, 84);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(412, 22);
            this.NombreTextBox.TabIndex = 11;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(167, 135);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(412, 22);
            this.DireccionTextBox.TabIndex = 12;
            // 
            // SueldoTextBox
            // 
            this.SueldoTextBox.Location = new System.Drawing.Point(167, 355);
            this.SueldoTextBox.Name = "SueldoTextBox";
            this.SueldoTextBox.Size = new System.Drawing.Size(412, 22);
            this.SueldoTextBox.TabIndex = 13;
            // 
            // IncentivosTextBox
            // 
            this.IncentivosTextBox.Location = new System.Drawing.Point(167, 406);
            this.IncentivosTextBox.Name = "IncentivosTextBox";
            this.IncentivosTextBox.Size = new System.Drawing.Size(412, 22);
            this.IncentivosTextBox.TabIndex = 14;
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(167, 190);
            this.TelefonoMaskedTextBox.Mask = "(999)000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(412, 22);
            this.TelefonoMaskedTextBox.TabIndex = 15;
            // 
            // CelularMaskedTextBox
            // 
            this.CelularMaskedTextBox.Location = new System.Drawing.Point(167, 244);
            this.CelularMaskedTextBox.Mask = "000-000-0000";
            this.CelularMaskedTextBox.Name = "CelularMaskedTextBox";
            this.CelularMaskedTextBox.Size = new System.Drawing.Size(412, 22);
            this.CelularMaskedTextBox.TabIndex = 16;
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(167, 300);
            this.CedulaMaskedTextBox.Mask = "000-0000000-0";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(412, 22);
            this.CedulaMaskedTextBox.TabIndex = 17;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(475, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(104, 47);
            this.BuscarButton.TabIndex = 18;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(48, 464);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(101, 51);
            this.NuevoButton.TabIndex = 19;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(257, 464);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(105, 51);
            this.GuardarButton.TabIndex = 20;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButton.Image")));
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButton.Location = new System.Drawing.Point(475, 464);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(104, 51);
            this.BorrarButton.TabIndex = 21;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 543);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.CelularMaskedTextBox);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.IncentivosTextBox);
            this.Controls.Add(this.SueldoTextBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.EmpleadoIdNumericUpDown);
            this.Controls.Add(this.IncentivosLabel);
            this.Controls.Add(this.SueldoLabel);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.CelularLabel);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.DireccionLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.EmpleadoIdLabel);
            this.Name = "rEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.REmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpleadoIdLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label DireccionLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Label CelularLabel;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label SueldoLabel;
        private System.Windows.Forms.Label IncentivosLabel;
        private System.Windows.Forms.NumericUpDown EmpleadoIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox SueldoTextBox;
        private System.Windows.Forms.TextBox IncentivosTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CelularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}