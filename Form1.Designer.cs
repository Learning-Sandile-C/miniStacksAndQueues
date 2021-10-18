
namespace miniStacksAndQueuse
{
    partial class btnScreeningComplete
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
            this.lbFirstQue = new System.Windows.Forms.ListBox();
            this.lbScreening = new System.Windows.Forms.ListBox();
            this.lbVaccination = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNextFirstQue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFirstQue
            // 
            this.lbFirstQue.FormattingEnabled = true;
            this.lbFirstQue.ItemHeight = 15;
            this.lbFirstQue.Location = new System.Drawing.Point(484, 114);
            this.lbFirstQue.Name = "lbFirstQue";
            this.lbFirstQue.Size = new System.Drawing.Size(188, 214);
            this.lbFirstQue.TabIndex = 0;
            // 
            // lbScreening
            // 
            this.lbScreening.FormattingEnabled = true;
            this.lbScreening.ItemHeight = 15;
            this.lbScreening.Location = new System.Drawing.Point(291, 114);
            this.lbScreening.Name = "lbScreening";
            this.lbScreening.Size = new System.Drawing.Size(188, 214);
            this.lbScreening.TabIndex = 0;
            // 
            // lbVaccination
            // 
            this.lbVaccination.FormattingEnabled = true;
            this.lbVaccination.ItemHeight = 15;
            this.lbVaccination.Location = new System.Drawing.Point(99, 114);
            this.lbVaccination.Name = "lbVaccination";
            this.lbVaccination.Size = new System.Drawing.Size(188, 214);
            this.lbVaccination.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(291, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Screening";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(484, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "First que";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(99, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vaccination ";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Location = new System.Drawing.Point(484, 55);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(120, 23);
            this.btnAddNewPerson.TabIndex = 2;
            this.btnAddNewPerson.Text = "Add new person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Screening complete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Screening complete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNextFirstQue
            // 
            this.btnNextFirstQue.Location = new System.Drawing.Point(484, 334);
            this.btnNextFirstQue.Name = "btnNextFirstQue";
            this.btnNextFirstQue.Size = new System.Drawing.Size(120, 23);
            this.btnNextFirstQue.TabIndex = 2;
            this.btnNextFirstQue.Text = "Next";
            this.btnNextFirstQue.UseVisualStyleBackColor = true;
            this.btnNextFirstQue.Click += new System.EventHandler(this.btnNextFirstQue_Click);
            // 
            // btnScreeningComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNextFirstQue);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbVaccination);
            this.Controls.Add(this.lbScreening);
            this.Controls.Add(this.lbFirstQue);
            this.Name = "btnScreeningComplete";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFirstQue;
        private System.Windows.Forms.ListBox lbScreening;
        private System.Windows.Forms.ListBox lbVaccination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNextFirstQue;
    }
}

