namespace Takarakuji
{
    partial class Form2
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
            this.labelKekka = new System.Windows.Forms.Label();
            this.labelKingaku = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKekka
            // 
            this.labelKekka.AutoSize = true;
            this.labelKekka.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKekka.Location = new System.Drawing.Point(37, 30);
            this.labelKekka.Name = "labelKekka";
            this.labelKekka.Size = new System.Drawing.Size(72, 24);
            this.labelKekka.TabIndex = 0;
            this.labelKekka.Text = "はずれ";
            // 
            // labelKingaku
            // 
            this.labelKingaku.AutoSize = true;
            this.labelKingaku.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKingaku.Location = new System.Drawing.Point(37, 69);
            this.labelKingaku.Name = "labelKingaku";
            this.labelKingaku.Size = new System.Drawing.Size(50, 24);
            this.labelKingaku.TabIndex = 1;
            this.labelKingaku.Text = "０円";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(137, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelKingaku);
            this.Controls.Add(this.labelKekka);
            this.Name = "Form2";
            this.Text = "くじ結果";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKekka;
        private System.Windows.Forms.Label labelKingaku;
        private System.Windows.Forms.Button button1;
    }
}