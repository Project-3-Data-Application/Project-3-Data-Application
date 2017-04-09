namespace appdesign
{
    partial class EOPopslaan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Plaats_EOPopslaan = new System.Windows.Forms.TextBox();
            this.gebied_EOPopslaan = new System.Windows.Forms.TextBox();
            this.adres_EOPopslaan = new System.Windows.Forms.TextBox();
            this.psaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset_RotterdamDataSet = new appdesign.Dataset_RotterdamDataSet();
            this.psaTableAdapter = new appdesign.Dataset_RotterdamDataSetTableAdapters.psaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.psaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_RotterdamDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaats:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gebied:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres:";
            // 
            // Plaats_EOPopslaan
            // 
            this.Plaats_EOPopslaan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Plaats_EOPopslaan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plaats_EOPopslaan.ForeColor = System.Drawing.SystemColors.Control;
            this.Plaats_EOPopslaan.Location = new System.Drawing.Point(77, 104);
            this.Plaats_EOPopslaan.Name = "Plaats_EOPopslaan";
            this.Plaats_EOPopslaan.Size = new System.Drawing.Size(148, 21);
            this.Plaats_EOPopslaan.TabIndex = 3;
            // 
            // gebied_EOPopslaan
            // 
            this.gebied_EOPopslaan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gebied_EOPopslaan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebied_EOPopslaan.ForeColor = System.Drawing.SystemColors.Control;
            this.gebied_EOPopslaan.Location = new System.Drawing.Point(77, 159);
            this.gebied_EOPopslaan.Name = "gebied_EOPopslaan";
            this.gebied_EOPopslaan.Size = new System.Drawing.Size(148, 21);
            this.gebied_EOPopslaan.TabIndex = 4;
            // 
            // adres_EOPopslaan
            // 
            this.adres_EOPopslaan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adres_EOPopslaan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adres_EOPopslaan.ForeColor = System.Drawing.SystemColors.Control;
            this.adres_EOPopslaan.Location = new System.Drawing.Point(77, 213);
            this.adres_EOPopslaan.Name = "adres_EOPopslaan";
            this.adres_EOPopslaan.Size = new System.Drawing.Size(148, 21);
            this.adres_EOPopslaan.TabIndex = 5;
            // 
            // psaBindingSource
            // 
            this.psaBindingSource.DataMember = "psa";
            this.psaBindingSource.DataSource = this.dataset_RotterdamDataSet;
            // 
            // dataset_RotterdamDataSet
            // 
            this.dataset_RotterdamDataSet.DataSetName = "Dataset_RotterdamDataSet";
            this.dataset_RotterdamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // psaTableAdapter
            // 
            this.psaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(263, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Gegevens Opslaan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(5, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "Afsluiten";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(5, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 24);
            this.button3.TabIndex = 9;
            this.button3.Text = "Hoofdmenu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(5, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 24);
            this.button4.TabIndex = 10;
            this.button4.Text = "Vorige";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EOPopslaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appdesign.Properties.Resources.EOPopslaan;
            this.ClientSize = new System.Drawing.Size(367, 372);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adres_EOPopslaan);
            this.Controls.Add(this.gebied_EOPopslaan);
            this.Controls.Add(this.Plaats_EOPopslaan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EOPopslaan";
            this.Text = "EOPopslaan";
            this.Load += new System.EventHandler(this.EOPopslaan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.psaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_RotterdamDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Plaats_EOPopslaan;
        private System.Windows.Forms.TextBox gebied_EOPopslaan;
        private System.Windows.Forms.TextBox adres_EOPopslaan;
        private Dataset_RotterdamDataSet dataset_RotterdamDataSet;
        private System.Windows.Forms.BindingSource psaBindingSource;
        private Dataset_RotterdamDataSetTableAdapters.psaTableAdapter psaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}