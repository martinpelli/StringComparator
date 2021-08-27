
namespace Practico1_Ejercicio7_TDI
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
            this.tittleLabel = new System.Windows.Forms.Label();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.string2TextBox = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.stringLabel = new System.Windows.Forms.Label();
            this.string2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLabel.Location = new System.Drawing.Point(85, 56);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(317, 31);
            this.tittleLabel.TabIndex = 0;
            this.tittleLabel.Text = "Comparador de Cadenas";
            // 
            // stringTextBox
            // 
            this.stringTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringTextBox.Location = new System.Drawing.Point(60, 163);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(170, 38);
            this.stringTextBox.TabIndex = 1;
            // 
            // string2TextBox
            // 
            this.string2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.string2TextBox.Location = new System.Drawing.Point(268, 163);
            this.string2TextBox.Name = "string2TextBox";
            this.string2TextBox.Size = new System.Drawing.Size(177, 38);
            this.string2TextBox.TabIndex = 2;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(156, 242);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(163, 36);
            this.compareButton.TabIndex = 3;
            this.compareButton.Text = "Comparar";
            this.compareButton.UseVisualStyleBackColor = true;
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringLabel.Location = new System.Drawing.Point(57, 143);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(173, 17);
            this.stringLabel.TabIndex = 4;
            this.stringLabel.Text = "Ingrese la primera cadena";
            // 
            // string2Label
            // 
            this.string2Label.AutoSize = true;
            this.string2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.string2Label.Location = new System.Drawing.Point(265, 143);
            this.string2Label.Name = "string2Label";
            this.string2Label.Size = new System.Drawing.Size(180, 17);
            this.string2Label.TabIndex = 5;
            this.string2Label.Text = "Ingrese la segunda cadena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 344);
            this.Controls.Add(this.string2Label);
            this.Controls.Add(this.stringLabel);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.string2TextBox);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.tittleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.TextBox string2TextBox;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Label string2Label;
    }
}

