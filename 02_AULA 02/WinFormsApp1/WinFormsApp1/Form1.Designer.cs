﻿namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(363, 192);
            button1.Name = "button1";
            button1.Size = new Size(194, 74);
            button1.TabIndex = 0;
            button1.Text = "Aperte Aqui";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 321);
            label1.Name = "label1";
            label1.Size = new Size(0, 45);
            label1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 31);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 41);
            label2.Name = "label2";
            label2.Size = new Size(267, 38);
            label2.TabIndex = 3;
            label2.Text = "Primeiro Programa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 117);
            label3.Name = "label3";
            label3.Size = new Size(225, 25);
            label3.TabIndex = 4;
            label3.Text = "Digite o Nome do Usuário:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}
