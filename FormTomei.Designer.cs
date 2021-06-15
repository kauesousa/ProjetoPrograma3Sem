namespace Saude_Day
{
    partial class FormTomei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTomei));
            this.lblRemedio = new System.Windows.Forms.Label();
            this.btnTomei = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.remediooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.horaTomouTextBox = new System.Windows.Forms.TextBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.remediooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemedio
            // 
            this.lblRemedio.AutoSize = true;
            this.lblRemedio.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRemedio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRemedio.Location = new System.Drawing.Point(18, 159);
            this.lblRemedio.Name = "lblRemedio";
            this.lblRemedio.Size = new System.Drawing.Size(72, 18);
            this.lblRemedio.TabIndex = 28;
            this.lblRemedio.Text = "Remédio";
            // 
            // btnTomei
            // 
            this.btnTomei.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTomei.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomei.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTomei.Location = new System.Drawing.Point(114, 191);
            this.btnTomei.Name = "btnTomei";
            this.btnTomei.Size = new System.Drawing.Size(96, 33);
            this.btnTomei.TabIndex = 27;
            this.btnTomei.Text = "Tomei";
            this.btnTomei.UseVisualStyleBackColor = false;
            this.btnTomei.Click += new System.EventHandler(this.btnTomei_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.remediooBindingSource;
            this.listBox1.DisplayMember = "Remedio";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(96, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 30);
            this.listBox1.TabIndex = 26;
            // 
            // remediooBindingSource
            // 
            this.remediooBindingSource.DataSource = typeof(SaudeDay.DAL.Remedioo);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // horaTomouTextBox
            // 
            this.horaTomouTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.horaTomouTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.horaTomouTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remediooBindingSource, "HoraTomou", true));
            this.horaTomouTextBox.Location = new System.Drawing.Point(105, 230);
            this.horaTomouTextBox.Multiline = true;
            this.horaTomouTextBox.Name = "horaTomouTextBox";
            this.horaTomouTextBox.Size = new System.Drawing.Size(137, 20);
            this.horaTomouTextBox.TabIndex = 29;
            // 
            // picVoltar
            // 
            this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
            this.picVoltar.Location = new System.Drawing.Point(-2, 12);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(69, 42);
            this.picVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVoltar.TabIndex = 46;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.picVoltar_Click);
            // 
            // FormTomei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 538);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.horaTomouTextBox);
            this.Controls.Add(this.lblRemedio);
            this.Controls.Add(this.btnTomei);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTomei";
            this.Text = "Tomei";
            this.Load += new System.EventHandler(this.FormTomei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remediooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemedio;
        private System.Windows.Forms.Button btnTomei;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource remediooBindingSource;
        private System.Windows.Forms.TextBox horaTomouTextBox;
        private System.Windows.Forms.PictureBox picVoltar;
    }
}