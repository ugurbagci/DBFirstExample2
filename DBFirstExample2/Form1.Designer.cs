namespace DBFirstExample2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnToList = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnStarAndWith = new System.Windows.Forms.Button();
            this.btnAny = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnFirstMethod = new System.Windows.Forms.Button();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDistinct = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnFunction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnToList
            // 
            this.btnToList.Location = new System.Drawing.Point(12, 218);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(144, 23);
            this.btnToList.TabIndex = 1;
            this.btnToList.Text = "To List";
            this.btnToList.UseVisualStyleBackColor = true;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(162, 218);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(159, 23);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(12, 247);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(144, 23);
            this.btnContains.TabIndex = 3;
            this.btnContains.Text = "Contains Methodu";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnStarAndWith
            // 
            this.btnStarAndWith.Location = new System.Drawing.Point(162, 247);
            this.btnStarAndWith.Name = "btnStarAndWith";
            this.btnStarAndWith.Size = new System.Drawing.Size(159, 23);
            this.btnStarAndWith.TabIndex = 4;
            this.btnStarAndWith.Text = "StartWith EndsWith";
            this.btnStarAndWith.UseVisualStyleBackColor = true;
            this.btnStarAndWith.Click += new System.EventHandler(this.btnStarAndWith_Click);
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(327, 247);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(110, 23);
            this.btnAny.TabIndex = 5;
            this.btnAny.Text = "Any";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(443, 247);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(120, 23);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(569, 247);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(82, 23);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(657, 247);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(110, 23);
            this.btnMinMax.TabIndex = 8;
            this.btnMinMax.Text = "MinMax";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(327, 218);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(110, 23);
            this.btnOrderBy.TabIndex = 9;
            this.btnOrderBy.Text = "Order By";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            // 
            // btnFirstMethod
            // 
            this.btnFirstMethod.Location = new System.Drawing.Point(443, 218);
            this.btnFirstMethod.Name = "btnFirstMethod";
            this.btnFirstMethod.Size = new System.Drawing.Size(120, 23);
            this.btnFirstMethod.TabIndex = 10;
            this.btnFirstMethod.Text = "First Methodu";
            this.btnFirstMethod.UseVisualStyleBackColor = true;
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(569, 218);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(117, 23);
            this.btnFirstOrDefault.TabIndex = 11;
            this.btnFirstOrDefault.Text = "First Or Default";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Find Metodu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(12, 276);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(144, 23);
            this.btnDistinct.TabIndex = 13;
            this.btnDistinct.Text = "Distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 305);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 14;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(162, 275);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 23);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(327, 275);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(110, 23);
            this.btnGroupBy.TabIndex = 16;
            this.btnGroupBy.Text = "Group By";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(443, 276);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(120, 24);
            this.btnJoin.TabIndex = 17;
            this.btnJoin.Text = "Join İşlemi";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.Location = new System.Drawing.Point(569, 276);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(117, 23);
            this.btnFunction.TabIndex = 18;
            this.btnFunction.Text = "Function";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFirstOrDefault);
            this.Controls.Add(this.btnFirstMethod);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnStarAndWith);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnToList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnStarAndWith;
        private System.Windows.Forms.Button btnAny;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnFirstMethod;
        private System.Windows.Forms.Button btnFirstOrDefault;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnFunction;
    }
}

