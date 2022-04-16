
namespace Notes.ListDay.Task2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.PictureBox();
            this.ButtonNotes = new System.Windows.Forms.Button();
            this.ButtonListToDay = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDaraAndTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.ButtonNotes);
            this.panel1.Controls.Add(this.ButtonListToDay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 450);
            this.panel1.TabIndex = 9;
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Image = global::Notes.Properties.Resources.ic_arrow_back_128_28226;
            this.Back.Location = new System.Drawing.Point(115, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(39, 32);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 3;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ButtonNotes
            // 
            this.ButtonNotes.FlatAppearance.BorderSize = 0;
            this.ButtonNotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNotes.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonNotes.Location = new System.Drawing.Point(3, 123);
            this.ButtonNotes.Name = "ButtonNotes";
            this.ButtonNotes.Size = new System.Drawing.Size(127, 34);
            this.ButtonNotes.TabIndex = 2;
            this.ButtonNotes.Text = "Заметки";
            this.ButtonNotes.UseVisualStyleBackColor = false;
            // 
            // ButtonListToDay
            // 
            this.ButtonListToDay.FlatAppearance.BorderSize = 0;
            this.ButtonListToDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonListToDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonListToDay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonListToDay.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonListToDay.Location = new System.Drawing.Point(0, 74);
            this.ButtonListToDay.Name = "ButtonListToDay";
            this.ButtonListToDay.Size = new System.Drawing.Size(127, 34);
            this.ButtonListToDay.TabIndex = 1;
            this.ButtonListToDay.Text = "Список задач";
            this.ButtonListToDay.UseVisualStyleBackColor = false;
            this.ButtonListToDay.Click += new System.EventHandler(this.ButtonListToDay_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonCreate.FlatAppearance.BorderSize = 0;
            this.ButtonCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCreate.Location = new System.Drawing.Point(471, 97);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(127, 34);
            this.ButtonCreate.TabIndex = 10;
            this.ButtonCreate.Text = "Добавить";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(282, 45);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(163, 86);
            this.textBoxTask.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(467, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата и время выполнения задачи";
            // 
            // textBoxDaraAndTime
            // 
            this.textBoxDaraAndTime.Location = new System.Drawing.Point(471, 45);
            this.textBoxDaraAndTime.Multiline = true;
            this.textBoxDaraAndTime.Name = "textBoxDaraAndTime";
            this.textBoxDaraAndTime.Size = new System.Drawing.Size(106, 19);
            this.textBoxDaraAndTime.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(311, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Задача";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDaraAndTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Button ButtonNotes;
        private System.Windows.Forms.Button ButtonListToDay;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDaraAndTime;
        private System.Windows.Forms.Label label1;
    }
}