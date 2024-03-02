
namespace NoteTakingApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.messages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttRead = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // messages
            // 
            this.messages.AutoSize = true;
            this.messages.Location = new System.Drawing.Point(39, 159);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(55, 13);
            this.messages.TabIndex = 0;
            this.messages.Text = "Messages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Location = new System.Drawing.Point(108, 81);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(185, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtMessages
            // 
            this.txtMessages.BackColor = System.Drawing.SystemColors.Info;
            this.txtMessages.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtMessages.Location = new System.Drawing.Point(108, 156);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(377, 259);
            this.txtMessages.TabIndex = 1;
            // 
            // bttNew
            // 
            this.bttNew.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bttNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttNew.ForeColor = System.Drawing.SystemColors.Window;
            this.bttNew.ImageKey = "(none)";
            this.bttNew.Location = new System.Drawing.Point(108, 520);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(75, 23);
            this.bttNew.TabIndex = 2;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = false;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttSave.Location = new System.Drawing.Point(256, 520);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 2;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttDelete.Location = new System.Drawing.Point(560, 520);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 2;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttRead
            // 
            this.bttRead.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttRead.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttRead.Location = new System.Drawing.Point(410, 520);
            this.bttRead.Name = "bttRead";
            this.bttRead.Size = new System.Drawing.Size(75, 23);
            this.bttRead.TabIndex = 2;
            this.bttRead.Text = "Read";
            this.bttRead.UseVisualStyleBackColor = false;
            this.bttRead.Click += new System.EventHandler(this.bttRead_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(604, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(273, 334);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(906, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttRead);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messages);
            this.Name = "Form1";
            this.Text = "Take a note";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label messages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttRead;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

