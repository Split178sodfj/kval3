namespace WinFormsApp1
{
    partial class Prog_Kval
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
            DGV = new DataGridView();
            buttonUPD = new Button();
            buttonDEL = new Button();
            buttonADD = new Button();
            textBoxSEARCH = new TextBox();
            label2 = new Label();
            textBoxNAME = new TextBox();
            label3 = new Label();
            textBoxPRICE = new TextBox();
            label4 = new Label();
            textBoxVAL = new TextBox();
            label5 = new Label();
            textBoxUNIT = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Dock = DockStyle.Bottom;
            DGV.Location = new Point(0, 149);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowTemplate.Height = 25;
            DGV.Size = new Size(800, 301);
            DGV.TabIndex = 1;
            DGV.SelectionChanged += DGV_SelectionChanged;
            // 
            // buttonUPD
            // 
            buttonUPD.Anchor = AnchorStyles.Left;
            buttonUPD.Location = new Point(242, 25);
            buttonUPD.Name = "buttonUPD";
            buttonUPD.Size = new Size(109, 23);
            buttonUPD.TabIndex = 0;
            buttonUPD.Text = "Редактировать";
            buttonUPD.UseVisualStyleBackColor = true;
            buttonUPD.Click += buttonUPD_Click;
            // 
            // buttonDEL
            // 
            buttonDEL.Anchor = AnchorStyles.Left;
            buttonDEL.Location = new Point(127, 25);
            buttonDEL.Name = "buttonDEL";
            buttonDEL.Size = new Size(109, 23);
            buttonDEL.TabIndex = 0;
            buttonDEL.Text = "Удалить";
            buttonDEL.UseVisualStyleBackColor = true;
            buttonDEL.Click += buttonDEL_Click;
            // 
            // buttonADD
            // 
            buttonADD.Anchor = AnchorStyles.Left;
            buttonADD.Location = new Point(12, 25);
            buttonADD.Name = "buttonADD";
            buttonADD.Size = new Size(109, 23);
            buttonADD.TabIndex = 0;
            buttonADD.Text = "Добавить";
            buttonADD.UseVisualStyleBackColor = true;
            buttonADD.Click += buttonADD_Click;
            // 
            // textBoxSEARCH
            // 
            textBoxSEARCH.Anchor = AnchorStyles.Left;
            textBoxSEARCH.Location = new Point(12, 99);
            textBoxSEARCH.Name = "textBoxSEARCH";
            textBoxSEARCH.Size = new Size(147, 23);
            textBoxSEARCH.TabIndex = 2;
            textBoxSEARCH.TextChanged += textBoxSEARCH_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(503, 16);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Наименование";
            // 
            // textBoxNAME
            // 
            textBoxNAME.Anchor = AnchorStyles.Right;
            textBoxNAME.Location = new Point(599, 12);
            textBoxNAME.Name = "textBoxNAME";
            textBoxNAME.Size = new Size(189, 23);
            textBoxNAME.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(558, 45);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 1;
            label3.Text = "Цена";
            // 
            // textBoxPRICE
            // 
            textBoxPRICE.Anchor = AnchorStyles.Right;
            textBoxPRICE.Location = new Point(599, 41);
            textBoxPRICE.Name = "textBoxPRICE";
            textBoxPRICE.Size = new Size(189, 23);
            textBoxPRICE.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(508, 107);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 1;
            label4.Text = "Ед. измерения";
            // 
            // textBoxVAL
            // 
            textBoxVAL.Anchor = AnchorStyles.Right;
            textBoxVAL.Location = new Point(599, 70);
            textBoxVAL.Name = "textBoxVAL";
            textBoxVAL.Size = new Size(189, 23);
            textBoxVAL.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(521, 78);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 1;
            label5.Text = "Количество";
            // 
            // textBoxUNIT
            // 
            textBoxUNIT.Anchor = AnchorStyles.Right;
            textBoxUNIT.Location = new Point(599, 99);
            textBoxUNIT.Name = "textBoxUNIT";
            textBoxUNIT.Size = new Size(189, 23);
            textBoxUNIT.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxUNIT);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxVAL);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxPRICE);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxNAME);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxSEARCH);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonADD);
            panel1.Controls.Add(buttonDEL);
            panel1.Controls.Add(buttonUPD);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 143);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 1;
            label1.Text = "Поиск по наименованию";
            // 
            // Prog_Kval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(DGV);
            Name = "Prog_Kval";
            Text = "Программа для квалификационного экзамена по билету №33";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DGV;
        private Button buttonUPD;
        private Button buttonDEL;
        private Button buttonADD;
        private TextBox textBoxSEARCH;
        private Label label2;
        private TextBox textBoxNAME;
        private Label label3;
        private TextBox textBoxPRICE;
        private Label label4;
        private TextBox textBoxVAL;
        private Label label5;
        private TextBox textBoxUNIT;
        private Panel panel1;
        private Label label1;
    }
}
