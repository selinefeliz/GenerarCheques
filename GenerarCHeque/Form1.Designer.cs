namespace GenerarCHeque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtCompanyName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtAmount = new TextBox();
            txtPayOrderOf = new TextBox();
            txtDollars = new TextBox();
            txtMemo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            rbnWood = new RadioButton();
            rbnBrick = new RadioButton();
            btnPreview = new Button();
            btnPrint = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(15, 9);
            txtCompanyName.Multiline = true;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(178, 87);
            txtCompanyName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 41);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 67);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Amount $";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 12);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 3;
            label3.Text = "No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 142);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 4;
            label4.Text = "Pay to the Order Of";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 188);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 5;
            label5.Text = "Dollars";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 250);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 6;
            label6.Text = "Signed";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 235);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 7;
            label7.Text = "Memo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 268);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 8;
            label8.Text = "000000000";
            // 
            // txtId
            // 
            txtId.Location = new Point(634, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(50, 23);
            txtId.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(507, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(507, 64);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 11;
            // 
            // txtPayOrderOf
            // 
            txtPayOrderOf.Location = new Point(144, 139);
            txtPayOrderOf.Name = "txtPayOrderOf";
            txtPayOrderOf.Size = new Size(453, 23);
            txtPayOrderOf.TabIndex = 12;
            // 
            // txtDollars
            // 
            txtDollars.Location = new Point(48, 180);
            txtDollars.Name = "txtDollars";
            txtDollars.Size = new Size(453, 23);
            txtDollars.TabIndex = 13;
            // 
            // txtMemo
            // 
            txtMemo.Location = new Point(77, 232);
            txtMemo.Name = "txtMemo";
            txtMemo.Size = new Size(157, 23);
            txtMemo.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(173, 268);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 15;
            label9.Text = "123456789";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(467, 250);
            label10.Name = "label10";
            label10.Size = new Size(147, 15);
            label10.TabIndex = 16;
            label10.Text = "____________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wood;
            pictureBox1.Location = new Point(29, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // rbnWood
            // 
            rbnWood.AutoSize = true;
            rbnWood.Location = new Point(145, 316);
            rbnWood.Name = "rbnWood";
            rbnWood.Size = new Size(57, 19);
            rbnWood.TabIndex = 18;
            rbnWood.Text = "Wood";
            rbnWood.UseVisualStyleBackColor = true;
            rbnWood.CheckedChanged += rbnWood_CheckedChanged;
            // 
            // rbnBrick
            // 
            rbnBrick.AutoSize = true;
            rbnBrick.Location = new Point(145, 341);
            rbnBrick.Name = "rbnBrick";
            rbnBrick.Size = new Size(51, 19);
            rbnBrick.TabIndex = 19;
            rbnBrick.Text = "Brick";
            rbnBrick.UseVisualStyleBackColor = true;
            rbnBrick.CheckedChanged += rbnWood_CheckedChanged;
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(450, 328);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(87, 24);
            btnPreview.TabIndex = 20;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(553, 328);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(87, 24);
            btnPrint.TabIndex = 21;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 377);
            Controls.Add(btnPrint);
            Controls.Add(btnPreview);
            Controls.Add(rbnBrick);
            Controls.Add(rbnWood);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtMemo);
            Controls.Add(txtDollars);
            Controls.Add(txtPayOrderOf);
            Controls.Add(txtAmount);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCompanyName);
            Name = "Form1";
            Text = "Check Writer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompanyName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtId;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAmount;
        private TextBox txtPayOrderOf;
        private TextBox txtDollars;
        private TextBox txtMemo;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private RadioButton rbnWood;
        private RadioButton rbnBrick;
        private Button btnPreview;
        private Button btnPrint;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
