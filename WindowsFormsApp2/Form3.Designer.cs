
namespace WindowsFormsApp2
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.amount_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.requist_button = new System.Windows.Forms.Button();
            this.address_combobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ship_to_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.show_data_box = new System.Windows.Forms.DataGridView();
            this.customer_id_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.item_id_textBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.show_data_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Costmer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kargo ID";
            // 
            // amount_textBox
            // 
            this.amount_textBox.Location = new System.Drawing.Point(583, 99);
            this.amount_textBox.Name = "amount_textBox";
            this.amount_textBox.Size = new System.Drawing.Size(100, 22);
            this.amount_textBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kargo Amount";
            // 
            // requist_button
            // 
            this.requist_button.Location = new System.Drawing.Point(392, 258);
            this.requist_button.Name = "requist_button";
            this.requist_button.Size = new System.Drawing.Size(118, 32);
            this.requist_button.TabIndex = 29;
            this.requist_button.Text = "Kargo Requist ";
            this.requist_button.UseVisualStyleBackColor = true;
            this.requist_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // address_combobox
            // 
            this.address_combobox.FormattingEnabled = true;
            this.address_combobox.Location = new System.Drawing.Point(283, 165);
            this.address_combobox.Name = "address_combobox";
            this.address_combobox.Size = new System.Drawing.Size(100, 24);
            this.address_combobox.TabIndex = 31;
            this.address_combobox.SelectedIndexChanged += new System.EventHandler(this.address_combobox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "To";
            // 
            // ship_to_textBox
            // 
            this.ship_to_textBox.Location = new System.Drawing.Point(583, 169);
            this.ship_to_textBox.Name = "ship_to_textBox";
            this.ship_to_textBox.Size = new System.Drawing.Size(100, 22);
            this.ship_to_textBox.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(153, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "From";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // show_data_box
            // 
            this.show_data_box.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_data_box.Location = new System.Drawing.Point(176, 339);
            this.show_data_box.MultiSelect = false;
            this.show_data_box.Name = "show_data_box";
            this.show_data_box.ReadOnly = true;
            this.show_data_box.RowHeadersWidth = 51;
            this.show_data_box.RowTemplate.Height = 24;
            this.show_data_box.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.show_data_box.Size = new System.Drawing.Size(527, 171);
            this.show_data_box.TabIndex = 34;
            // 
            // customer_id_textBox
            // 
            this.customer_id_textBox.Location = new System.Drawing.Point(283, 213);
            this.customer_id_textBox.Name = "customer_id_textBox";
            this.customer_id_textBox.Size = new System.Drawing.Size(100, 22);
            this.customer_id_textBox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Customer ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 37;
            this.button1.Text = "show requast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 38);
            this.button6.TabIndex = 49;
            this.button6.Text = "back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Count";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_label.Location = new System.Drawing.Point(709, 490);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(24, 26);
            this.count_label.TabIndex = 51;
            this.count_label.Text = "0";
            // 
            // item_id_textBox
            // 
            this.item_id_textBox.FormattingEnabled = true;
            this.item_id_textBox.Location = new System.Drawing.Point(283, 96);
            this.item_id_textBox.Name = "item_id_textBox";
            this.item_id_textBox.Size = new System.Drawing.Size(100, 24);
            this.item_id_textBox.TabIndex = 52;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 522);
            this.Controls.Add(this.item_id_textBox);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customer_id_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.show_data_box);
            this.Controls.Add(this.ship_to_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.address_combobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.requist_button);
            this.Controls.Add(this.amount_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_data_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button requist_button;
        private System.Windows.Forms.ComboBox address_combobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ship_to_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView show_data_box;
        private System.Windows.Forms.TextBox customer_id_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.ComboBox item_id_textBox;
    }
}