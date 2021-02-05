namespace TabelaJuros {
    partial class FrmMain {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.buttonCalcular = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.textEditValorEmprestimo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditQuantidadeParcelas = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.textEditTaxaJuros = new DevExpress.XtraEditors.TextEdit();
            this.gridControlResult = new DevExpress.XtraGrid.GridControl();
            this.gridViewResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrincipalParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnJurosLinear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotalParcelaLinear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnJurosExponencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTotalParcelaExponencial = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEditValorEmprestimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuantidadeParcelas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTaxaJuros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCalcular.ImageOptions.Image = global::TabelaJuros.Properties.Resources.calculationoptions_16x16;
            this.buttonCalcular.Location = new System.Drawing.Point(483, 28);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(99, 23);
            this.buttonCalcular.TabIndex = 6;
            this.buttonCalcular.Text = "&Calcular";
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            // 
            // textEditValorEmprestimo
            // 
            this.textEditValorEmprestimo.Location = new System.Drawing.Point(22, 31);
            this.textEditValorEmprestimo.Name = "textEditValorEmprestimo";
            this.textEditValorEmprestimo.Properties.Mask.EditMask = "n2";
            this.textEditValorEmprestimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditValorEmprestimo.Size = new System.Drawing.Size(157, 20);
            this.textEditValorEmprestimo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do empréstimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de parcelas";
            // 
            // textEditQuantidadeParcelas
            // 
            this.textEditQuantidadeParcelas.Location = new System.Drawing.Point(203, 31);
            this.textEditQuantidadeParcelas.Name = "textEditQuantidadeParcelas";
            this.textEditQuantidadeParcelas.Properties.Mask.EditMask = "d";
            this.textEditQuantidadeParcelas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditQuantidadeParcelas.Size = new System.Drawing.Size(146, 20);
            this.textEditQuantidadeParcelas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Taxa de juros";
            // 
            // textEditTaxaJuros
            // 
            this.textEditTaxaJuros.Location = new System.Drawing.Point(373, 31);
            this.textEditTaxaJuros.Name = "textEditTaxaJuros";
            this.textEditTaxaJuros.Properties.Mask.EditMask = "n2";
            this.textEditTaxaJuros.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditTaxaJuros.Size = new System.Drawing.Size(86, 20);
            this.textEditTaxaJuros.TabIndex = 5;
            // 
            // gridControlResult
            // 
            this.gridControlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlResult.Location = new System.Drawing.Point(12, 69);
            this.gridControlResult.MainView = this.gridViewResult;
            this.gridControlResult.Name = "gridControlResult";
            this.gridControlResult.Size = new System.Drawing.Size(803, 361);
            this.gridControlResult.TabIndex = 7;
            this.gridControlResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResult});
            // 
            // gridViewResult
            // 
            this.gridViewResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnParcela,
            this.gridColumnPrincipalParcela,
            this.gridColumnJurosLinear,
            this.gridColumnTotalParcelaLinear,
            this.gridColumnJurosExponencial,
            this.gridColumnTotalParcelaExponencial});
            this.gridViewResult.GridControl = this.gridControlResult;
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.OptionsBehavior.Editable = false;
            this.gridViewResult.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewResult.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnParcela
            // 
            this.gridColumnParcela.Caption = "Parcela";
            this.gridColumnParcela.FieldName = "Parcela";
            this.gridColumnParcela.Name = "gridColumnParcela";
            this.gridColumnParcela.Visible = true;
            this.gridColumnParcela.VisibleIndex = 0;
            // 
            // gridColumnPrincipalParcela
            // 
            this.gridColumnPrincipalParcela.Caption = "Principal parcela";
            this.gridColumnPrincipalParcela.FieldName = "PrincipalParcela";
            this.gridColumnPrincipalParcela.Name = "gridColumnPrincipalParcela";
            this.gridColumnPrincipalParcela.Visible = true;
            this.gridColumnPrincipalParcela.VisibleIndex = 1;
            // 
            // gridColumnJurosLinear
            // 
            this.gridColumnJurosLinear.Caption = "Juros linear";
            this.gridColumnJurosLinear.FieldName = "JurosLinear";
            this.gridColumnJurosLinear.Name = "gridColumnJurosLinear";
            this.gridColumnJurosLinear.Visible = true;
            this.gridColumnJurosLinear.VisibleIndex = 2;
            // 
            // gridColumnTotalParcelaLinear
            // 
            this.gridColumnTotalParcelaLinear.Caption = "Total parcela linear";
            this.gridColumnTotalParcelaLinear.FieldName = "TotalParcelaLinear";
            this.gridColumnTotalParcelaLinear.Name = "gridColumnTotalParcelaLinear";
            this.gridColumnTotalParcelaLinear.Visible = true;
            this.gridColumnTotalParcelaLinear.VisibleIndex = 3;
            // 
            // gridColumnJurosExponencial
            // 
            this.gridColumnJurosExponencial.Caption = "Juros exponencial";
            this.gridColumnJurosExponencial.FieldName = "JurosExponencial";
            this.gridColumnJurosExponencial.Name = "gridColumnJurosExponencial";
            this.gridColumnJurosExponencial.Visible = true;
            this.gridColumnJurosExponencial.VisibleIndex = 4;
            // 
            // gridColumnTotalParcelaExponencial
            // 
            this.gridColumnTotalParcelaExponencial.Caption = "Total parcela exponencial";
            this.gridColumnTotalParcelaExponencial.FieldName = "TotalParcelaExponencial";
            this.gridColumnTotalParcelaExponencial.Name = "gridColumnTotalParcelaExponencial";
            this.gridColumnTotalParcelaExponencial.Visible = true;
            this.gridColumnTotalParcelaExponencial.VisibleIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 442);
            this.Controls.Add(this.gridControlResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEditTaxaJuros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEditQuantidadeParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEditValorEmprestimo);
            this.Controls.Add(this.buttonCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de parcelas";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditValorEmprestimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQuantidadeParcelas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTaxaJuros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton buttonCalcular;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TextEdit textEditValorEmprestimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditQuantidadeParcelas;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEditTaxaJuros;
        private DevExpress.XtraGrid.GridControl gridControlResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResult;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnParcela;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrincipalParcela;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnJurosLinear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotalParcelaLinear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnJurosExponencial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTotalParcelaExponencial;
    }
}

