
namespace Activityno6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.RemoveColumnButton = new System.Windows.Forms.Button();
            this.RemoveRowButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.CurrentCellTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ColumnTextBox = new System.Windows.Forms.TextBox();
            this.RowTextBox = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.UploadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(675, 112);
            this.Button3.Margin = new System.Windows.Forms.Padding(4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 30);
            this.Button3.TabIndex = 49;
            this.Button3.Text = "Row";
            this.Button3.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(247, 112);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 30);
            this.Button2.TabIndex = 48;
            this.Button2.Text = "Column";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // RemoveColumnButton
            // 
            this.RemoveColumnButton.BackColor = System.Drawing.Color.Brown;
            this.RemoveColumnButton.FlatAppearance.BorderSize = 0;
            this.RemoveColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveColumnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveColumnButton.ForeColor = System.Drawing.Color.White;
            this.RemoveColumnButton.Location = new System.Drawing.Point(637, 496);
            this.RemoveColumnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveColumnButton.Name = "RemoveColumnButton";
            this.RemoveColumnButton.Size = new System.Drawing.Size(169, 32);
            this.RemoveColumnButton.TabIndex = 47;
            this.RemoveColumnButton.Text = "Remove Column";
            this.RemoveColumnButton.UseVisualStyleBackColor = false;
            // 
            // RemoveRowButton
            // 
            this.RemoveRowButton.BackColor = System.Drawing.Color.Brown;
            this.RemoveRowButton.FlatAppearance.BorderSize = 0;
            this.RemoveRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveRowButton.ForeColor = System.Drawing.Color.White;
            this.RemoveRowButton.Location = new System.Drawing.Point(273, 496);
            this.RemoveRowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(169, 32);
            this.RemoveRowButton.TabIndex = 46;
            this.RemoveRowButton.Text = "Remove Row";
            this.RemoveRowButton.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(221, 442);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(117, 20);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "Focused Cell :";
            // 
            // CurrentCellTextBox
            // 
            this.CurrentCellTextBox.BackColor = System.Drawing.Color.White;
            this.CurrentCellTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentCellTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentCellTextBox.ForeColor = System.Drawing.Color.Black;
            this.CurrentCellTextBox.Location = new System.Drawing.Point(344, 443);
            this.CurrentCellTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentCellTextBox.Name = "CurrentCellTextBox";
            this.CurrentCellTextBox.ReadOnly = true;
            this.CurrentCellTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CurrentCellTextBox.Size = new System.Drawing.Size(192, 19);
            this.CurrentCellTextBox.TabIndex = 44;
            this.CurrentCellTextBox.Text = " ";
            this.CurrentCellTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(12, 22);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(380, 32);
            this.SearchButton.TabIndex = 43;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ColumnTextBox
            // 
            this.ColumnTextBox.BackColor = System.Drawing.Color.White;
            this.ColumnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColumnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnTextBox.ForeColor = System.Drawing.Color.Black;
            this.ColumnTextBox.Location = new System.Drawing.Point(354, 119);
            this.ColumnTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColumnTextBox.Name = "ColumnTextBox";
            this.ColumnTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColumnTextBox.Size = new System.Drawing.Size(65, 23);
            this.ColumnTextBox.TabIndex = 42;
            this.ColumnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RowTextBox
            // 
            this.RowTextBox.BackColor = System.Drawing.Color.White;
            this.RowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RowTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowTextBox.ForeColor = System.Drawing.Color.Black;
            this.RowTextBox.Location = new System.Drawing.Point(782, 119);
            this.RowTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RowTextBox.Name = "RowTextBox";
            this.RowTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RowTextBox.Size = new System.Drawing.Size(67, 23);
            this.RowTextBox.TabIndex = 41;
            this.RowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Brown;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(208, 148);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(713, 36);
            this.Button1.TabIndex = 40;
            this.Button1.Text = "Datar Grid";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Brown;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(12, 271);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(155, 41);
            this.DeleteButton.TabIndex = 39;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.Brown;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(12, 330);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(155, 41);
            this.PrintButton.TabIndex = 38;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.Color.Chocolate;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(208, 177);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(713, 254);
            this.DataGridView1.TabIndex = 37;
            // 
            // UploadButton
            // 
            this.UploadButton.BackColor = System.Drawing.Color.Brown;
            this.UploadButton.FlatAppearance.BorderSize = 0;
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.ForeColor = System.Drawing.Color.White;
            this.UploadButton.Location = new System.Drawing.Point(12, 209);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(155, 41);
            this.UploadButton.TabIndex = 36;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 569);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.RemoveColumnButton);
            this.Controls.Add(this.RemoveRowButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.CurrentCellTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ColumnTextBox);
            this.Controls.Add(this.RowTextBox);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.UploadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button RemoveColumnButton;
        internal System.Windows.Forms.Button RemoveRowButton;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox CurrentCellTextBox;
        internal System.Windows.Forms.Button SearchButton;
        internal System.Windows.Forms.TextBox ColumnTextBox;
        internal System.Windows.Forms.TextBox RowTextBox;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button DeleteButton;
        internal System.Windows.Forms.Button PrintButton;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button UploadButton;
    }
}