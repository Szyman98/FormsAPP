namespace ZadanieRekrutacyjne
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubmitButton = new DevExpress.Utils.Layout.TablePanel();
            this.myDataGrid = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lokaleComboBox = new System.Windows.Forms.ComboBox();
            this.toDate = new DevExpress.XtraEditors.DateEdit();
            this.fromDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmitButton)).BeginInit();
            this.SubmitButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10.34F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.66F)});
            this.SubmitButton.Controls.Add(this.myDataGrid);
            this.SubmitButton.Controls.Add(this.simpleButton1);
            this.SubmitButton.Controls.Add(this.lokaleComboBox);
            this.SubmitButton.Controls.Add(this.toDate);
            this.SubmitButton.Controls.Add(this.fromDate);
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmitButton.Location = new System.Drawing.Point(0, 0);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.SubmitButton.Size = new System.Drawing.Size(2078, 1352);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // myDataGrid
            // 
            this.myDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SubmitButton.SetColumn(this.myDataGrid, 1);
            this.myDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGrid.Location = new System.Drawing.Point(364, 7);
            this.myDataGrid.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.myDataGrid.Name = "myDataGrid";
            this.SubmitButton.SetRow(this.myDataGrid, 0);
            this.myDataGrid.RowHeadersWidth = 92;
            this.myDataGrid.Size = new System.Drawing.Size(1708, 1338);
            this.myDataGrid.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.SubmitButton.SetColumn(this.simpleButton1, 0);
            this.simpleButton1.Location = new System.Drawing.Point(6, 543);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.SubmitButton.SetRow(this.simpleButton1, 0);
            this.simpleButton1.Size = new System.Drawing.Size(346, 266);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Zatwierdź";
            this.simpleButton1.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // lokaleComboBox
            // 
            this.lokaleComboBox.FormattingEnabled = true;
            this.lokaleComboBox.Location = new System.Drawing.Point(30, 47);
            this.lokaleComboBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lokaleComboBox.Name = "lokaleComboBox";
            this.lokaleComboBox.Size = new System.Drawing.Size(115, 37);
            this.lokaleComboBox.TabIndex = 9;
            this.lokaleComboBox.Text = "Lokale:";
            // 
            // toDate
            // 
            this.toDate.EditValue = "Do:";
            this.toDate.Location = new System.Drawing.Point(40, 120);
            this.toDate.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.toDate.Name = "toDate";
            this.toDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDate.Size = new System.Drawing.Size(256, 44);
            this.toDate.TabIndex = 7;
            // 
            // fromDate
            // 
            this.fromDate.EditValue = "Od:";
            this.fromDate.Location = new System.Drawing.Point(38, 79);
            this.fromDate.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.fromDate.Name = "fromDate";
            this.fromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDate.Size = new System.Drawing.Size(258, 44);
            this.fromDate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2078, 1352);
            this.Controls.Add(this.SubmitButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubmitButton)).EndInit();
            this.SubmitButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel SubmitButton;
        private DevExpress.XtraEditors.DateEdit toDate;
        private DevExpress.XtraEditors.DateEdit fromDate;
        private System.Windows.Forms.ComboBox lokaleComboBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView myDataGrid;
    }
}

