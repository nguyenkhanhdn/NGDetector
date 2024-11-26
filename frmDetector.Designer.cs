
namespace NGDetector
{
    partial class frmDetector
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btImgBrowse = new Button();
            tbImgPath = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnPredict = new Button();
            button2 = new Button();
            button3 = new Button();
            btnClose = new Button();
            openFileDialog1 = new OpenFileDialog();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btImgBrowse);
            groupBox1.Controls.Add(tbImgPath);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(41, 43);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(946, 716);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(572, 405);
            label6.Name = "label6";
            label6.Size = new Size(339, 64);
            label6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(572, 328);
            label7.Name = "label7";
            label7.Size = new Size(210, 45);
            label7.TabIndex = 9;
            label7.Text = "% chẩn đoán:";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(572, 230);
            label5.Name = "label5";
            label5.Size = new Size(339, 64);
            label5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(572, 153);
            label4.Name = "label4";
            label4.Size = new Size(180, 45);
            label4.TabIndex = 7;
            label4.Text = "Chẩn đoán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 551);
            label3.Name = "label3";
            label3.Size = new Size(163, 45);
            label3.TabIndex = 6;
            label3.Text = "Chọn ảnh:";
            // 
            // btImgBrowse
            // 
            btImgBrowse.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btImgBrowse.Location = new Point(410, 616);
            btImgBrowse.Name = "btImgBrowse";
            btImgBrowse.Size = new Size(103, 50);
            btImgBrowse.TabIndex = 5;
            btImgBrowse.Text = "...";
            btImgBrowse.UseVisualStyleBackColor = true;
            btImgBrowse.Click += btImgBrowse_Click;
            // 
            // tbImgPath
            // 
            tbImgPath.Enabled = false;
            tbImgPath.Location = new Point(42, 616);
            tbImgPath.Name = "tbImgPath";
            tbImgPath.Size = new Size(362, 50);
            tbImgPath.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(555, 80);
            label2.Name = "label2";
            label2.Size = new Size(264, 45);
            label2.TabIndex = 2;
            label2.Text = "Kết quả dự đoán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 80);
            label1.Name = "label1";
            label1.Size = new Size(156, 45);
            label1.TabIndex = 1;
            label1.Text = "Ảnh chụp";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(42, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPredict
            // 
            btnPredict.Location = new Point(1036, 67);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(203, 70);
            btnPredict.TabIndex = 1;
            btnPredict.Text = "Chẩn đoán";
            btnPredict.UseVisualStyleBackColor = true;
            btnPredict.Click += btnPredict_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1036, 168);
            button2.Name = "button2";
            button2.Size = new Size(203, 70);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1036, 280);
            button3.Name = "button3";
            button3.Size = new Size(203, 70);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1036, 476);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(203, 70);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(613, 570);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(626, 53);
            comboBox1.TabIndex = 5;
            // 
            // frmDetector
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 804);
            Controls.Add(comboBox1);
            Controls.Add(btnClose);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnPredict);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDetector";
            Text = "Nutrition Guide Detector";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private Button btnPredict;
        private Button button2;
        private Button button3;
        private Button btnClose;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btImgBrowse;
        private TextBox tbImgPath;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
    }
}
