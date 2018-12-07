namespace PRESENTACION
{
    partial class Administrar_Usuarios
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvusu = new System.Windows.Forms.DataGridView();
            this.cmbestusu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomb = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtem = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbucsar = new System.Windows.Forms.TextBox();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusu)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(650, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvusu
            // 
            this.dgvusu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusu.Location = new System.Drawing.Point(12, 211);
            this.dgvusu.Name = "dgvusu";
            this.dgvusu.ReadOnly = true;
            this.dgvusu.Size = new System.Drawing.Size(776, 225);
            this.dgvusu.TabIndex = 39;
            this.dgvusu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusu_CellContentClick);
            // 
            // cmbestusu
            // 
            this.cmbestusu.FormattingEnabled = true;
            this.cmbestusu.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbestusu.Location = new System.Drawing.Point(436, 105);
            this.cmbestusu.Name = "cmbestusu";
            this.cmbestusu.Size = new System.Drawing.Size(139, 21);
            this.cmbestusu.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Email: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Estado del Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id_Usuario:";
            // 
            // txtnomb
            // 
            this.txtnomb.Location = new System.Drawing.Point(115, 67);
            this.txtnomb.Name = "txtnomb";
            this.txtnomb.Size = new System.Drawing.Size(141, 20);
            this.txtnomb.TabIndex = 29;
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(334, 67);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(241, 20);
            this.txtape.TabIndex = 28;
            // 
            // txtdirec
            // 
            this.txtdirec.Location = new System.Drawing.Point(115, 149);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(472, 20);
            this.txtdirec.TabIndex = 27;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(115, 185);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(184, 20);
            this.txttel.TabIndex = 25;
            // 
            // txtem
            // 
            this.txtem.Location = new System.Drawing.Point(349, 185);
            this.txtem.Name = "txtem";
            this.txtem.Size = new System.Drawing.Size(238, 20);
            this.txtem.TabIndex = 24;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(115, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Buscar";
            // 
            // txtbucsar
            // 
            this.txtbucsar.Location = new System.Drawing.Point(502, 19);
            this.txtbucsar.Name = "txtbucsar";
            this.txtbucsar.Size = new System.Drawing.Size(127, 20);
            this.txtbucsar.TabIndex = 45;
            this.txtbucsar.TextChanged += new System.EventHandler(this.txtbucsar_TextChanged);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(650, 36);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 46;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Administrar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.txtbucsar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvusu);
            this.Controls.Add(this.cmbestusu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomb);
            this.Controls.Add(this.txtape);
            this.Controls.Add(this.txtdirec);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtem);
            this.Controls.Add(this.txtid);
            this.Name = "Administrar_Usuarios";
            this.Text = " FarmaSolution.JD                                                                " +
    "         Administrar Usuarios";
            this.Load += new System.EventHandler(this.Administrar_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvusu;
        private System.Windows.Forms.ComboBox cmbestusu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomb;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtem;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbucsar;
        private System.Windows.Forms.Button btnborrar;
    }
}