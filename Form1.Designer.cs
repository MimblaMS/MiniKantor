namespace MiniKantor
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 235); //rozmiar okna programu
            this.Text = "Form1";

            
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1 (Wyświetla tekst z informacją dotycząca listy wyboru waluty)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz walutę: ";
            // 
            // label2 (Tekst informujący o cenie kupna)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "";
            // 
            // label3 (Tekst informujący o cenie sprzedaży)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "";
            // 
            // label4 (Wyświetli tekst jeśli użytkownik chce kupić walutę)
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "";
            // 
            // label5 (Wyświetli tekst jeśli użytkownik chce sprzedać walutę)
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "";
            // 
            // button1 (Przycisk wywołujący obliczenie transakcji)
            // 
            this.button1.Location = new System.Drawing.Point(33, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Oblicz wartość transakcji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1 (Umożliwia użytkownikowi wybranie pojedynczej opcji z grupy opcji po połączeniu z innymi RadioButton kontrolkami.)
            // 
            this.radioButton1.Location = new System.Drawing.Point(33, 147);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 23);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Chcę sprzedać";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2 (Umożliwia użytkownikowi wybranie pojedynczej opcji z grupy opcji po połączeniu z innymi RadioButton kontrolkami.)
            // 
            this.radioButton2.Location = new System.Drawing.Point(143, 147);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 23);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Chcę kupić";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1 (Do wpisania kwoty transakcji przez użytkownika)
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text= "Tutaj wpisz kwotę transakcji...";
            // 
            // comboBox1 (Umożliwa wybór waluty z listy)
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "CZK", "USD", "EUR"});
            this.comboBox1.Location = new System.Drawing.Point(128, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Name = "Form1";
            this.Text = "Kantor"; //nazwa wyświetlana w oknie programu
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

