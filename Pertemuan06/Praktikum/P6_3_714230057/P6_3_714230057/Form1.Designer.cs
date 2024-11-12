namespace P6_3_714230057
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txHuruf = new System.Windows.Forms.Label();
            this.txAngka = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txAngka1 = new System.Windows.Forms.Label();
            this.txAngka2 = new System.Windows.Forms.Label();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // txHuruf
            // 
            this.txHuruf.AutoSize = true;
            this.txHuruf.Location = new System.Drawing.Point(61, 87);
            this.txHuruf.Name = "txHuruf";
            this.txHuruf.Size = new System.Drawing.Size(49, 20);
            this.txHuruf.TabIndex = 0;
            this.txHuruf.Text = "Huruf";
            // 
            // txAngka
            // 
            this.txAngka.AutoSize = true;
            this.txAngka.Location = new System.Drawing.Point(61, 132);
            this.txAngka.Name = "txAngka";
            this.txAngka.Size = new System.Drawing.Size(55, 20);
            this.txAngka.TabIndex = 1;
            this.txAngka.Text = "Angka";
            // 
            // txEmail
            // 
            this.txEmail.AutoSize = true;
            this.txEmail.Location = new System.Drawing.Point(61, 173);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(48, 20);
            this.txEmail.TabIndex = 2;
            this.txEmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(61, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Angka 1 > Angka 2";
            // 
            // txAngka1
            // 
            this.txAngka1.AutoSize = true;
            this.txAngka1.Location = new System.Drawing.Point(65, 272);
            this.txAngka1.Name = "txAngka1";
            this.txAngka1.Size = new System.Drawing.Size(68, 20);
            this.txAngka1.TabIndex = 4;
            this.txAngka1.Text = "Angka 1";
            // 
            // txAngka2
            // 
            this.txAngka2.AutoSize = true;
            this.txAngka2.Location = new System.Drawing.Point(65, 320);
            this.txAngka2.Name = "txAngka2";
            this.txAngka2.Size = new System.Drawing.Size(68, 20);
            this.txAngka2.TabIndex = 5;
            this.txAngka2.Text = "Angka 2";
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(294, 80);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(304, 26);
            this.txtHuruf.TabIndex = 6;
            this.txtHuruf.Leave += new System.EventHandler(this.txtHuruf_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(294, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtAngka
            // 
            this.txtAngka.Location = new System.Drawing.Point(294, 126);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(304, 26);
            this.txtAngka.TabIndex = 8;
            this.txtAngka.Leave += new System.EventHandler(this.txtAngka_Leave);
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(294, 266);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(304, 26);
            this.txtAngka1.TabIndex = 9;
            this.txtAngka1.TextChanged += new System.EventHandler(this.txtAngka1_TextChanged);
            this.txtAngka1.Leave += new System.EventHandler(this.txtAngka1_Leave);
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(294, 314);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(304, 26);
            this.txtAngka2.TabIndex = 10;
            this.txtAngka2.TextChanged += new System.EventHandler(this.txtAngka2_TextChanged);
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.txAngka2);
            this.Controls.Add(this.txAngka1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txAngka);
            this.Controls.Add(this.txHuruf);
            this.Name = "Form1";
            this.Text = "Huruf";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txHuruf;
        private System.Windows.Forms.Label txAngka;
        private System.Windows.Forms.Label txEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txAngka1;
        private System.Windows.Forms.Label txAngka2;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

