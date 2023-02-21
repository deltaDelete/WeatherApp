namespace WeatherApp
{
    partial class WeatherForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WeatherDataGrid = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.measureUnitsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.onlyPositive = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherDataGrid
            // 
            this.WeatherDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WeatherDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeatherDataGrid.Location = new System.Drawing.Point(12, 12);
            this.WeatherDataGrid.Name = "WeatherDataGrid";
            this.WeatherDataGrid.ReadOnly = true;
            this.WeatherDataGrid.Size = new System.Drawing.Size(776, 196);
            this.WeatherDataGrid.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(103, 214);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // measureUnitsBox
            // 
            this.measureUnitsBox.FormattingEnabled = true;
            this.measureUnitsBox.Location = new System.Drawing.Point(103, 240);
            this.measureUnitsBox.Name = "measureUnitsBox";
            this.measureUnitsBox.Size = new System.Drawing.Size(121, 21);
            this.measureUnitsBox.TabIndex = 2;
            this.measureUnitsBox.SelectedValueChanged += new System.EventHandler(this.measureUnitsBox_SelectedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ед.измерения";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(103, 296);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // onlyPositive
            // 
            this.onlyPositive.Location = new System.Drawing.Point(103, 267);
            this.onlyPositive.Name = "onlyPositive";
            this.onlyPositive.Size = new System.Drawing.Size(75, 23);
            this.onlyPositive.TabIndex = 5;
            this.onlyPositive.Text = "Вывод \"+\"";
            this.onlyPositive.UseVisualStyleBackColor = true;
            this.onlyPositive.Click += new System.EventHandler(this.onlyPositive_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(103, 326);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 6;
            this.sortButton.Text = "Сортировка";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.onlyPositive);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.measureUnitsBox);
            this.Controls.Add(this.WeatherDataGrid);
            this.Name = "WeatherForm";
            this.Text = "Погода Хакасии";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WeatherDataGrid;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox measureUnitsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button onlyPositive;
        private System.Windows.Forms.Button sortButton;
    }
}

