﻿namespace ejercicio_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_add_matrix1 = new System.Windows.Forms.Button();
            this.btn_sum_matrix2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "sumar matriz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "resultado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btn_add_matrix1
            // 
            this.btn_add_matrix1.Location = new System.Drawing.Point(111, 91);
            this.btn_add_matrix1.Name = "btn_add_matrix1";
            this.btn_add_matrix1.Size = new System.Drawing.Size(84, 40);
            this.btn_add_matrix1.TabIndex = 4;
            this.btn_add_matrix1.Text = "agregar num al array";
            this.btn_add_matrix1.UseVisualStyleBackColor = true;
            // 
            // btn_sum_matrix2
            // 
            this.btn_sum_matrix2.Location = new System.Drawing.Point(284, 91);
            this.btn_sum_matrix2.Name = "btn_sum_matrix2";
            this.btn_sum_matrix2.Size = new System.Drawing.Size(84, 40);
            this.btn_sum_matrix2.TabIndex = 5;
            this.btn_sum_matrix2.Text = "agregar num al array";
            this.btn_sum_matrix2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lbl_result
            // 
            this.lbl_result.Location = new System.Drawing.Point(92, 309);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(303, 112);
            this.lbl_result.TabIndex = 7;
            this.lbl_result.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_sum_matrix2);
            this.Controls.Add(this.btn_add_matrix1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add_matrix1;
        private System.Windows.Forms.Button btn_sum_matrix2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_result;
    }
}

