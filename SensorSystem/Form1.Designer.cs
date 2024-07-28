namespace SensorSystem
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtSensorName = new Label();
            txtSensorType = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(530, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(530, 27);
            textBox2.TabIndex = 1;
            // 
            // txtSensorName
            // 
            txtSensorName.AutoSize = true;
            txtSensorName.Location = new Point(150, 69);
            txtSensorName.Name = "txtSensorName";
            txtSensorName.Size = new Size(96, 20);
            txtSensorName.TabIndex = 2;
            txtSensorName.Text = "SensorName:";
            // 
            // txtSensorType
            // 
            txtSensorType.AutoSize = true;
            txtSensorType.Location = new Point(150, 215);
            txtSensorType.Name = "txtSensorType";
            txtSensorType.Size = new Size(91, 20);
            txtSensorType.TabIndex = 3;
            txtSensorType.Text = "SensorType:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(597, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 424);
            Controls.Add(btnSave);
            Controls.Add(txtSensorType);
            Controls.Add(txtSensorName);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Sensor System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label txtSensorName;
        private Label txtSensorType;
        private Button btnSave;
    }
}