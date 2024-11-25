namespace WindowsFormstabla
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
            panelprincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = SystemColors.ActiveCaption;
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Cursor = Cursors.WaitCursor;
            panelprincipal.Location = new Point(25, 12);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(741, 426);
            panelprincipal.TabIndex = 0;
            panelprincipal.Paint += panel1_Paint;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBoxresultados.Location = new Point(359, 90);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(201, 287);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = SystemColors.MenuHighlight;
            buttonver.Location = new Point(60, 178);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(124, 29);
            buttonver.TabIndex = 3;
            buttonver.Text = "VER TABLA";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(60, 130);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(125, 27);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Tahoma", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelnumero.Location = new Point(53, 88);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(226, 22);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿CUAL TABLA QUIERES?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Swis721 Blk BT", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            labeltitulo.Location = new Point(43, 30);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(319, 34);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Calculadora de Multiplicacion";
            Load += Form1_Load;
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private Button buttonver;
        private TextBox textBoxnum;
        private Label labelnumero;
        private RichTextBox richTextBoxresultados;
    }
}
