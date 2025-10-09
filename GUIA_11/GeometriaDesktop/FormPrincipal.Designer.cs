namespace GeometriaDesktop
{
    partial class FormPrincipal
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
            groupBox1 = new GroupBox();
            btnConfirmarRegistro = new Button();
            btnLimpiar = new Button();
            tbArea = new TextBox();
            tbRadio = new TextBox();
            tbAlto = new TextBox();
            tbAncho = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rbCirculo = new RadioButton();
            rbRectangulo = new RadioButton();
            groupBox3 = new GroupBox();
            btnEliminarRegistro = new Button();
            btnActualizarListado = new Button();
            lvwFiguras = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmarRegistro);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(tbArea);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(tbAlto);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la figura";
            // 
            // btnConfirmarRegistro
            // 
            btnConfirmarRegistro.Location = new Point(389, 87);
            btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            btnConfirmarRegistro.Size = new Size(120, 52);
            btnConfirmarRegistro.TabIndex = 10;
            btnConfirmarRegistro.Text = "Confirmar registro";
            btnConfirmarRegistro.UseVisualStyleBackColor = true;
            btnConfirmarRegistro.Click += btnConfirmarRegistro_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(389, 27);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 52);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(205, 116);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(119, 23);
            tbArea.TabIndex = 8;
            // 
            // tbRadio
            // 
            tbRadio.Enabled = false;
            tbRadio.Location = new Point(205, 82);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(119, 23);
            tbRadio.TabIndex = 7;
            // 
            // tbAlto
            // 
            tbAlto.Location = new Point(205, 51);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(119, 23);
            tbAlto.TabIndex = 6;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(205, 19);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(119, 23);
            tbAncho.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 119);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Area";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 85);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 54);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Alto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 22);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Ancho";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbCirculo);
            groupBox2.Controls.Add(rbRectangulo);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(114, 78);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de figura";
            // 
            // rbCirculo
            // 
            rbCirculo.AutoSize = true;
            rbCirculo.Location = new Point(6, 47);
            rbCirculo.Name = "rbCirculo";
            rbCirculo.Size = new Size(63, 19);
            rbCirculo.TabIndex = 1;
            rbCirculo.TabStop = true;
            rbCirculo.Text = "Circulo";
            rbCirculo.UseVisualStyleBackColor = true;
            rbCirculo.CheckedChanged += rbCirculo_CheckedChanged;
            // 
            // rbRectangulo
            // 
            rbRectangulo.AutoSize = true;
            rbRectangulo.Location = new Point(6, 22);
            rbRectangulo.Name = "rbRectangulo";
            rbRectangulo.Size = new Size(85, 19);
            rbRectangulo.TabIndex = 0;
            rbRectangulo.TabStop = true;
            rbRectangulo.Text = "Rectangulo";
            rbRectangulo.UseVisualStyleBackColor = true;
            rbRectangulo.CheckedChanged += rbRectangulo_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminarRegistro);
            groupBox3.Controls.Add(btnActualizarListado);
            groupBox3.Controls.Add(lvwFiguras);
            groupBox3.Location = new Point(12, 195);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(520, 248);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Listado de figuras";
            // 
            // btnEliminarRegistro
            // 
            btnEliminarRegistro.Location = new Point(389, 129);
            btnEliminarRegistro.Name = "btnEliminarRegistro";
            btnEliminarRegistro.Size = new Size(120, 52);
            btnEliminarRegistro.TabIndex = 2;
            btnEliminarRegistro.Text = "Eliminar registro";
            btnEliminarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnActualizarListado
            // 
            btnActualizarListado.Location = new Point(389, 50);
            btnActualizarListado.Name = "btnActualizarListado";
            btnActualizarListado.Size = new Size(120, 52);
            btnActualizarListado.TabIndex = 1;
            btnActualizarListado.Text = "Actualizar listado";
            btnActualizarListado.UseVisualStyleBackColor = true;
            btnActualizarListado.Click += btnActualizarListado_Click;
            // 
            // lvwFiguras
            // 
            lvwFiguras.Location = new Point(6, 22);
            lvwFiguras.Name = "lvwFiguras";
            lvwFiguras.Size = new Size(366, 215);
            lvwFiguras.TabIndex = 0;
            lvwFiguras.UseCompatibleStateImageBehavior = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 455);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rbCirculo;
        private RadioButton rbRectangulo;
        private Button btnConfirmarRegistro;
        private Button btnLimpiar;
        private TextBox tbArea;
        private TextBox tbRadio;
        private TextBox tbAlto;
        private TextBox tbAncho;
        private GroupBox groupBox3;
        private ListView lvwFiguras;
        private Button btnActualizarListado;
        private Button btnEliminarRegistro;
    }
}
