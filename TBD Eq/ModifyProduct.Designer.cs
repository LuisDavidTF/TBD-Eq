
namespace TBD_Eq
{
    partial class ModifyProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyProduct));
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbThirdColor = new System.Windows.Forms.PictureBox();
            this.pbSecondColor = new System.Windows.Forms.PictureBox();
            this.pbFirstColor = new System.Windows.Forms.PictureBox();
            this.btnXL = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnXS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRigth = new System.Windows.Forms.PictureBox();
            this.pbCarousel = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThirdColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarousel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(210)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.pbLeft);
            this.panel2.Controls.Add(this.pbRigth);
            this.panel2.Controls.Add(this.pbCarousel);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnDiscard);
            this.panel2.Controls.Add(this.btnDeleteProduct);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.numCantidad);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pbThirdColor);
            this.panel2.Controls.Add(this.pbSecondColor);
            this.panel2.Controls.Add(this.pbFirstColor);
            this.panel2.Controls.Add(this.btnXL);
            this.panel2.Controls.Add(this.btnL);
            this.panel2.Controls.Add(this.btnM);
            this.panel2.Controls.Add(this.btnS);
            this.panel2.Controls.Add(this.btnXS);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.rtxtDescripcion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 524);
            this.panel2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 35);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Nombre del Producto";
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(790, 446);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(82, 45);
            this.btnDiscard.TabIndex = 26;
            this.btnDiscard.Text = "Descartar Cambios";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(709, 446);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 45);
            this.btnDeleteProduct.TabIndex = 25;
            this.btnDeleteProduct.Text = "Eliminar Producto";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(623, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 45);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Guardar cambios";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPrice.Location = new System.Drawing.Point(736, 63);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 34);
            this.txtPrice.TabIndex = 23;
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.numCantidad.Location = new System.Drawing.Point(896, 337);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(67, 34);
            this.numCantidad.TabIndex = 19;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descripcion:";
            // 
            // pbThirdColor
            // 
            this.pbThirdColor.BackColor = System.Drawing.Color.Fuchsia;
            this.pbThirdColor.Location = new System.Drawing.Point(526, 421);
            this.pbThirdColor.Name = "pbThirdColor";
            this.pbThirdColor.Size = new System.Drawing.Size(37, 32);
            this.pbThirdColor.TabIndex = 15;
            this.pbThirdColor.TabStop = false;
            // 
            // pbSecondColor
            // 
            this.pbSecondColor.BackColor = System.Drawing.Color.White;
            this.pbSecondColor.Location = new System.Drawing.Point(483, 421);
            this.pbSecondColor.Name = "pbSecondColor";
            this.pbSecondColor.Size = new System.Drawing.Size(37, 32);
            this.pbSecondColor.TabIndex = 14;
            this.pbSecondColor.TabStop = false;
            // 
            // pbFirstColor
            // 
            this.pbFirstColor.BackColor = System.Drawing.Color.Black;
            this.pbFirstColor.Location = new System.Drawing.Point(440, 421);
            this.pbFirstColor.Name = "pbFirstColor";
            this.pbFirstColor.Size = new System.Drawing.Size(37, 32);
            this.pbFirstColor.TabIndex = 13;
            this.pbFirstColor.TabStop = false;
            // 
            // btnXL
            // 
            this.btnXL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXL.Location = new System.Drawing.Point(686, 341);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(57, 30);
            this.btnXL.TabIndex = 12;
            this.btnXL.Text = "XL";
            this.btnXL.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Location = new System.Drawing.Point(623, 341);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(57, 30);
            this.btnL.TabIndex = 11;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Location = new System.Drawing.Point(560, 341);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(57, 30);
            this.btnM.TabIndex = 10;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Location = new System.Drawing.Point(497, 341);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(57, 30);
            this.btnS.TabIndex = 9;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnXS
            // 
            this.btnXS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXS.Location = new System.Drawing.Point(434, 341);
            this.btnXS.Name = "btnXS";
            this.btnXS.Size = new System.Drawing.Size(57, 30);
            this.btnXS.TabIndex = 8;
            this.btnXS.Text = "XS";
            this.btnXS.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Colores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tallas:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(852, 69);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 28);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "MXN";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(210)))), ((int)(((byte)(191)))));
            this.rtxtDescripcion.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescripcion.Location = new System.Drawing.Point(421, 138);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(363, 169);
            this.rtxtDescripcion.TabIndex = 3;
            this.rtxtDescripcion.Text = resources.GetString("rtxtDescripcion.Text");
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(497, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 45);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Buscar Producto";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtName.Location = new System.Drawing.Point(424, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 34);
            this.txtName.TabIndex = 33;
            // 
            // pbLeft
            // 
            this.pbLeft.Image = global::TBD_Eq.Properties.Resources.Arrow_left;
            this.pbLeft.Location = new System.Drawing.Point(34, 245);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(35, 38);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft.TabIndex = 36;
            this.pbLeft.TabStop = false;
            // 
            // pbRigth
            // 
            this.pbRigth.Image = global::TBD_Eq.Properties.Resources.Arrow_rigth;
            this.pbRigth.Location = new System.Drawing.Point(337, 245);
            this.pbRigth.Name = "pbRigth";
            this.pbRigth.Size = new System.Drawing.Size(35, 38);
            this.pbRigth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRigth.TabIndex = 35;
            this.pbRigth.TabStop = false;
            // 
            // pbCarousel
            // 
            this.pbCarousel.Image = global::TBD_Eq.Properties.Resources.Ej1;
            this.pbCarousel.Location = new System.Drawing.Point(34, 69);
            this.pbCarousel.Name = "pbCarousel";
            this.pbCarousel.Size = new System.Drawing.Size(338, 399);
            this.pbCarousel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarousel.TabIndex = 34;
            this.pbCarousel.TabStop = false;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 524);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThirdColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarousel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbThirdColor;
        private System.Windows.Forms.PictureBox pbSecondColor;
        private System.Windows.Forms.PictureBox pbFirstColor;
        private System.Windows.Forms.Button btnXL;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnXS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbRigth;
        private System.Windows.Forms.PictureBox pbCarousel;
    }
}