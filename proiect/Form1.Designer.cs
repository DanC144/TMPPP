namespace proiect
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1_Stomatolog = new ComboBox();
            textBox1_Nume = new TextBox();
            textBox2_Prenume = new TextBox();
            textBox3_Nr_telefon = new TextBox();
            comboBox2_Procedura = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label6_ora = new Label();
            comboBox1_ora = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Stomatolog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Nume pacient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 133);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Prenume pacient";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 185);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 3;
            label4.Text = "Nr_telefon pacient";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 289);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Procedura";
            // 
            // comboBox1_Stomatolog
            // 
            comboBox1_Stomatolog.BackColor = Color.YellowGreen;
            comboBox1_Stomatolog.FormattingEnabled = true;
            comboBox1_Stomatolog.Items.AddRange(new object[] { "Iulia", "Andrian", "Andrei" });
            comboBox1_Stomatolog.Location = new Point(124, 51);
            comboBox1_Stomatolog.Margin = new Padding(2);
            comboBox1_Stomatolog.Name = "comboBox1_Stomatolog";
            comboBox1_Stomatolog.Size = new Size(310, 23);
            comboBox1_Stomatolog.TabIndex = 5;
            comboBox1_Stomatolog.SelectedIndexChanged += comboBox1_Stomatolog_SelectedIndexChanged;
            // 
            // textBox1_Nume
            // 
            textBox1_Nume.BackColor = Color.YellowGreen;
            textBox1_Nume.Location = new Point(127, 103);
            textBox1_Nume.Margin = new Padding(2);
            textBox1_Nume.Name = "textBox1_Nume";
            textBox1_Nume.Size = new Size(306, 23);
            textBox1_Nume.TabIndex = 6;
            textBox1_Nume.TextChanged += textBox1_Nume_TextChanged;
            // 
            // textBox2_Prenume
            // 
            textBox2_Prenume.BackColor = Color.YellowGreen;
            textBox2_Prenume.Location = new Point(127, 157);
            textBox2_Prenume.Margin = new Padding(2);
            textBox2_Prenume.Name = "textBox2_Prenume";
            textBox2_Prenume.Size = new Size(306, 23);
            textBox2_Prenume.TabIndex = 7;
            textBox2_Prenume.TextChanged += textBox2_Prenume_TextChanged;
            // 
            // textBox3_Nr_telefon
            // 
            textBox3_Nr_telefon.BackColor = Color.YellowGreen;
            textBox3_Nr_telefon.Location = new Point(127, 210);
            textBox3_Nr_telefon.Margin = new Padding(2);
            textBox3_Nr_telefon.Name = "textBox3_Nr_telefon";
            textBox3_Nr_telefon.Size = new Size(306, 23);
            textBox3_Nr_telefon.TabIndex = 8;
            textBox3_Nr_telefon.TextChanged += textBox3_Nr_telefon_TextChanged;
            // 
            // comboBox2_Procedura
            // 
            comboBox2_Procedura.BackColor = Color.YellowGreen;
            comboBox2_Procedura.FormattingEnabled = true;
            comboBox2_Procedura.Items.AddRange(new object[] { "Tratarea cariei", "Înălbire", "Extracție", "Control", "Plombare", "Proteza" });
            comboBox2_Procedura.Location = new Point(127, 311);
            comboBox2_Procedura.Margin = new Padding(2);
            comboBox2_Procedura.Name = "comboBox2_Procedura";
            comboBox2_Procedura.Size = new Size(306, 23);
            comboBox2_Procedura.TabIndex = 9;
            comboBox2_Procedura.SelectedIndexChanged += comboBox2_Procedura_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.FloralWhite;
            monthCalendar1.Location = new Point(157, 341);
            monthCalendar1.Margin = new Padding(6, 5, 6, 5);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(466, 51);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1033, 269);
            dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Location = new Point(124, 510);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 12;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.Location = new Point(356, 510);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 13;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6_ora
            // 
            label6_ora.AutoSize = true;
            label6_ora.Location = new Point(127, 238);
            label6_ora.Margin = new Padding(2, 0, 2, 0);
            label6_ora.Name = "label6_ora";
            label6_ora.Size = new Size(26, 15);
            label6_ora.TabIndex = 14;
            label6_ora.Text = "Ora";
            // 
            // comboBox1_ora
            // 
            comboBox1_ora.BackColor = Color.YellowGreen;
            comboBox1_ora.FormattingEnabled = true;
            comboBox1_ora.Items.AddRange(new object[] { "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00" });
            comboBox1_ora.Location = new Point(127, 260);
            comboBox1_ora.Margin = new Padding(2);
            comboBox1_ora.Name = "comboBox1_ora";
            comboBox1_ora.Size = new Size(306, 23);
            comboBox1_ora.TabIndex = 15;
            // 
            // button3
            // 
            button3.BackColor = Color.YellowGreen;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(991, 507);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 16;
            button3.Text = "Undo last changes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.YellowGreen;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(1016, 407);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Salvează";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1517, 563);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1_ora);
            Controls.Add(label6_ora);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox2_Procedura);
            Controls.Add(textBox3_Nr_telefon);
            Controls.Add(textBox2_Prenume);
            Controls.Add(textBox1_Nume);
            Controls.Add(comboBox1_Stomatolog);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1_Stomatolog;
        private TextBox textBox1_Nume;
        private TextBox textBox2_Prenume;
        private TextBox textBox3_Nr_telefon;
        private ComboBox comboBox2_Procedura;
        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label6_ora;
        private ComboBox comboBox1_ora;
        private Button button3;
        private Button button4;
    }
}
