namespace RegisztracioAlkalmazas
{
    partial class formRegisztracio
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
            this.labelNev = new System.Windows.Forms.Label();
            this.labelSzulDatum = new System.Windows.Forms.Label();
            this.labelUjHobbi = new System.Windows.Forms.Label();
            this.labelNem = new System.Windows.Forms.Label();
            this.labelKedvenc = new System.Windows.Forms.Label();
            this.textNev = new System.Windows.Forms.TextBox();
            this.textSzulDatum = new System.Windows.Forms.TextBox();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.listBoxKedvencHobbi = new System.Windows.Forms.ListBox();
            this.textUjHobbi = new System.Windows.Forms.TextBox();
            this.buttonHozzaAad = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(26, 48);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(30, 13);
            this.labelNev.TabIndex = 0;
            this.labelNev.Text = "Név:";
            // 
            // labelSzulDatum
            // 
            this.labelSzulDatum.AutoSize = true;
            this.labelSzulDatum.Location = new System.Drawing.Point(26, 75);
            this.labelSzulDatum.Name = "labelSzulDatum";
            this.labelSzulDatum.Size = new System.Drawing.Size(62, 13);
            this.labelSzulDatum.TabIndex = 1;
            this.labelSzulDatum.Text = "Szül.dátum:";
            // 
            // labelUjHobbi
            // 
            this.labelUjHobbi.AutoSize = true;
            this.labelUjHobbi.Location = new System.Drawing.Point(156, 190);
            this.labelUjHobbi.Name = "labelUjHobbi";
            this.labelUjHobbi.Size = new System.Drawing.Size(49, 13);
            this.labelUjHobbi.TabIndex = 2;
            this.labelUjHobbi.Text = "Új hobbi:";
            // 
            // labelNem
            // 
            this.labelNem.AutoSize = true;
            this.labelNem.Location = new System.Drawing.Point(26, 102);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(32, 13);
            this.labelNem.TabIndex = 3;
            this.labelNem.Text = "Nem:";
            // 
            // labelKedvenc
            // 
            this.labelKedvenc.AutoSize = true;
            this.labelKedvenc.Location = new System.Drawing.Point(211, 48);
            this.labelKedvenc.Name = "labelKedvenc";
            this.labelKedvenc.Size = new System.Drawing.Size(82, 13);
            this.labelKedvenc.TabIndex = 4;
            this.labelKedvenc.Text = "Kedvenc hobbi:";
            // 
            // textNev
            // 
            this.textNev.Location = new System.Drawing.Point(90, 48);
            this.textNev.Name = "textNev";
            this.textNev.Size = new System.Drawing.Size(100, 20);
            this.textNev.TabIndex = 5;
            // 
            // textSzulDatum
            // 
            this.textSzulDatum.Location = new System.Drawing.Point(90, 75);
            this.textSzulDatum.Name = "textSzulDatum";
            this.textSzulDatum.Size = new System.Drawing.Size(100, 20);
            this.textSzulDatum.TabIndex = 6;
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.Location = new System.Drawing.Point(127, 98);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.Size = new System.Drawing.Size(33, 17);
            this.radioButtonN.TabIndex = 7;
            this.radioButtonN.TabStop = true;
            this.radioButtonN.Text = "N";
            this.radioButtonN.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(90, 98);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(31, 17);
            this.radioButtonF.TabIndex = 8;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // listBoxKedvencHobbi
            // 
            this.listBoxKedvencHobbi.FormattingEnabled = true;
            this.listBoxKedvencHobbi.Items.AddRange(new object[] {
            "Úszás",
            "Futás",
            "Horgászat",
            "Rajzolás"});
            this.listBoxKedvencHobbi.Location = new System.Drawing.Point(214, 75);
            this.listBoxKedvencHobbi.Name = "listBoxKedvencHobbi";
            this.listBoxKedvencHobbi.Size = new System.Drawing.Size(100, 95);
            this.listBoxKedvencHobbi.TabIndex = 9;
            // 
            // textUjHobbi
            // 
            this.textUjHobbi.Location = new System.Drawing.Point(214, 190);
            this.textUjHobbi.Name = "textUjHobbi";
            this.textUjHobbi.Size = new System.Drawing.Size(100, 20);
            this.textUjHobbi.TabIndex = 10;
            // 
            // buttonHozzaAad
            // 
            this.buttonHozzaAad.Location = new System.Drawing.Point(239, 216);
            this.buttonHozzaAad.Name = "buttonHozzaAad";
            this.buttonHozzaAad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaAad.TabIndex = 11;
            this.buttonHozzaAad.Text = "Hozzáad";
            this.buttonHozzaAad.UseVisualStyleBackColor = true;
            this.buttonHozzaAad.Click += new System.EventHandler(this.ButtonHozzaAad_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(158, 247);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 12;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.ButtonMentes_Click);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(239, 247);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(75, 23);
            this.buttonBetoltes.TabIndex = 13;
            this.buttonBetoltes.Text = "Betöltés";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            // 
            // formRegisztracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 282);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonHozzaAad);
            this.Controls.Add(this.textUjHobbi);
            this.Controls.Add(this.listBoxKedvencHobbi);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonN);
            this.Controls.Add(this.textSzulDatum);
            this.Controls.Add(this.textNev);
            this.Controls.Add(this.labelKedvenc);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.labelUjHobbi);
            this.Controls.Add(this.labelSzulDatum);
            this.Controls.Add(this.labelNev);
            this.Name = "formRegisztracio";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelSzulDatum;
        private System.Windows.Forms.Label labelUjHobbi;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.Label labelKedvenc;
        private System.Windows.Forms.TextBox textNev;
        private System.Windows.Forms.TextBox textSzulDatum;
        private System.Windows.Forms.RadioButton radioButtonN;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.ListBox listBoxKedvencHobbi;
        private System.Windows.Forms.TextBox textUjHobbi;
        private System.Windows.Forms.Button buttonHozzaAad;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetoltes;
    }
}

