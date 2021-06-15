namespace Saude_Day
{
    partial class FormAddAlt
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
            System.Windows.Forms.Label dataMarcadaLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label horaMarcadaLabel;
            System.Windows.Forms.Label medidaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label remedioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAlt));
            this.dataMarcadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remediooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.horaMarcadaTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.quantidadeComboBox = new System.Windows.Forms.ComboBox();
            this.medidaComboBox = new System.Windows.Forms.ComboBox();
            this.remedioTextBox = new System.Windows.Forms.TextBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            dataMarcadaLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            horaMarcadaLabel = new System.Windows.Forms.Label();
            medidaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            remedioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.remediooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMarcadaLabel
            // 
            dataMarcadaLabel.AutoSize = true;
            dataMarcadaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataMarcadaLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            dataMarcadaLabel.Location = new System.Drawing.Point(42, 218);
            dataMarcadaLabel.Name = "dataMarcadaLabel";
            dataMarcadaLabel.Size = new System.Drawing.Size(42, 18);
            dataMarcadaLabel.TabIndex = 2;
            dataMarcadaLabel.Text = "Data";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            descricaoLabel.Location = new System.Drawing.Point(42, 328);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(101, 18);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Observações";
            // 
            // horaMarcadaLabel
            // 
            horaMarcadaLabel.AutoSize = true;
            horaMarcadaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaMarcadaLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            horaMarcadaLabel.Location = new System.Drawing.Point(42, 245);
            horaMarcadaLabel.Name = "horaMarcadaLabel";
            horaMarcadaLabel.Size = new System.Drawing.Size(42, 18);
            horaMarcadaLabel.TabIndex = 6;
            horaMarcadaLabel.Text = "Hora";
            // 
            // medidaLabel
            // 
            medidaLabel.AutoSize = true;
            medidaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medidaLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            medidaLabel.Location = new System.Drawing.Point(42, 298);
            medidaLabel.Name = "medidaLabel";
            medidaLabel.Size = new System.Drawing.Size(61, 18);
            medidaLabel.TabIndex = 10;
            medidaLabel.Text = "Medida";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            quantidadeLabel.Location = new System.Drawing.Point(42, 272);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(89, 18);
            quantidadeLabel.TabIndex = 12;
            quantidadeLabel.Text = "Quantidade";
            // 
            // remedioLabel
            // 
            remedioLabel.AutoSize = true;
            remedioLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remedioLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            remedioLabel.Location = new System.Drawing.Point(42, 189);
            remedioLabel.Name = "remedioLabel";
            remedioLabel.Size = new System.Drawing.Size(72, 18);
            remedioLabel.TabIndex = 14;
            remedioLabel.Text = "Remédio";
            // 
            // dataMarcadaDateTimePicker
            // 
            this.dataMarcadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.remediooBindingSource, "DataMarcada", true));
            this.dataMarcadaDateTimePicker.Location = new System.Drawing.Point(137, 216);
            this.dataMarcadaDateTimePicker.Name = "dataMarcadaDateTimePicker";
            this.dataMarcadaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dataMarcadaDateTimePicker.TabIndex = 3;
            // 
            // remediooBindingSource
            // 
            this.remediooBindingSource.DataSource = typeof(SaudeDay.DAL.Remedioo);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remediooBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(45, 349);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(192, 50);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // horaMarcadaTextBox
            // 
            this.horaMarcadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remediooBindingSource, "HoraMarcada", true));
            this.horaMarcadaTextBox.Location = new System.Drawing.Point(137, 243);
            this.horaMarcadaTextBox.Name = "horaMarcadaTextBox";
            this.horaMarcadaTextBox.Size = new System.Drawing.Size(100, 20);
            this.horaMarcadaTextBox.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(137, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 33);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAlt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlt.Location = new System.Drawing.Point(82, 466);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(97, 30);
            this.btnAlt.TabIndex = 17;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Location = new System.Drawing.Point(35, 427);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 33);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.remediooBindingSource;
            this.listBox1.DisplayMember = "Remedio";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(82, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 30);
            this.listBox1.TabIndex = 23;
            // 
            // quantidadeComboBox
            // 
            this.quantidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remediooBindingSource, "Quantidade", true));
            this.quantidadeComboBox.FormattingEnabled = true;
            this.quantidadeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.quantidadeComboBox.Location = new System.Drawing.Point(137, 269);
            this.quantidadeComboBox.Name = "quantidadeComboBox";
            this.quantidadeComboBox.Size = new System.Drawing.Size(100, 21);
            this.quantidadeComboBox.TabIndex = 24;
            // 
            // medidaComboBox
            // 
            this.medidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remediooBindingSource, "Medida", true));
            this.medidaComboBox.FormattingEnabled = true;
            this.medidaComboBox.Items.AddRange(new object[] {
            "Unidade(s)/Gota(s)",
            "Mililitros(s)"});
            this.medidaComboBox.Location = new System.Drawing.Point(137, 298);
            this.medidaComboBox.Name = "medidaComboBox";
            this.medidaComboBox.Size = new System.Drawing.Size(100, 21);
            this.medidaComboBox.TabIndex = 22;
            // 
            // remedioTextBox
            // 
            this.remedioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remediooBindingSource, "Remedio", true));
            this.remedioTextBox.Location = new System.Drawing.Point(137, 187);
            this.remedioTextBox.Name = "remedioTextBox";
            this.remedioTextBox.Size = new System.Drawing.Size(100, 20);
            this.remedioTextBox.TabIndex = 25;
            // 
            // picVoltar
            // 
            this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
            this.picVoltar.Location = new System.Drawing.Point(-6, 12);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(69, 42);
            this.picVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVoltar.TabIndex = 26;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAddAlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(283, 538);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.remedioTextBox);
            this.Controls.Add(this.quantidadeComboBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.medidaComboBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(remedioLabel);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(medidaLabel);
            this.Controls.Add(horaMarcadaLabel);
            this.Controls.Add(this.horaMarcadaTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(dataMarcadaLabel);
            this.Controls.Add(this.dataMarcadaDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddAlt";
            this.Text = "Adicionar e Alterar";
            this.Load += new System.EventHandler(this.FormAddAlt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remediooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource remediooBindingSource;
        private System.Windows.Forms.DateTimePicker dataMarcadaDateTimePicker;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox horaMarcadaTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox quantidadeComboBox;
        private System.Windows.Forms.ComboBox medidaComboBox;
        private System.Windows.Forms.TextBox remedioTextBox;
        private System.Windows.Forms.PictureBox picVoltar;
    }
}