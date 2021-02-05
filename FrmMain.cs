using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TabelaJuros {
    public partial class FrmMain :XtraForm {

        private const int periodoParcela = 30;

        public FrmMain() {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza a validação do filtro aplicado para o cálculo
        /// </summary>
        /// <param name="valorEmprestimo">Valor do empréstimo</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas</param>
        /// <param name="taxaJuros">Taxa de juros</param>
        /// <returns>True para o filtro válido</returns>
        private bool Validar(decimal valorEmprestimo, int quantidadeParcelas, decimal taxaJuros) {
            if (valorEmprestimo<=0) {
                FecharTelaAguarde();
                XtraMessageBox.Show("Valor do empréstimo deverá ser maior que zero.");
                return false;
            }
            if (quantidadeParcelas <= 0) {
                FecharTelaAguarde();
                XtraMessageBox.Show("Quantidade de parcelas deverá ser maior que zero.");
                return false;
            }
            if (taxaJuros <= 0) {
                FecharTelaAguarde();
                XtraMessageBox.Show("Taxa de juros deverá ser maior que zero.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Realiza o calculo das parcelas
        /// </summary>
        /// <param name="valorEmprestimo">Valor do empréstimo</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas</param>
        /// <param name="taxaJuros">Taxa de juros</param>     
        private void CalcularParcelas(decimal valorEmprestimo, int quantidadeParcelas, decimal taxaJuros) {
            IList<CalculoResult> lista = new List<CalculoResult>();
            decimal valorParcela = valorEmprestimo / quantidadeParcelas;
            int quantidadeDias = periodoParcela;
            for (int i = 1; i <= quantidadeParcelas; i++) {

                CalculoResult calculoResult = new CalculoResult() {
                    Parcela = i,
                    PrincipalParcela = valorParcela,
                    JurosLinear = CalcularJurosLinear(valorParcela, taxaJuros, quantidadeDias),
                    JurosExponencial = CalcularJurosExponencial(valorParcela, taxaJuros, quantidadeDias)
                };
                calculoResult.TotalParcelaLinear = calculoResult.PrincipalParcela + calculoResult.JurosLinear;
                calculoResult.TotalParcelaExponencial = calculoResult.PrincipalParcela + calculoResult.JurosExponencial;
                lista.Add(calculoResult);

                quantidadeDias += periodoParcela;
            }
            gridControlResult.DataSource = lista;
        }

        /// <summary>
        /// Realiza o calculo dos juros linear
        /// </summary>
        /// <param name="valorEmprestimo">Valor do empréstimo</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas</param>
        /// <param name="taxaJuros">Taxa de juros</param>   
        /// <returns>Juros linear calculado</returns>
        private decimal CalcularJurosLinear(decimal valorParcela, decimal taxaJuros, int quantidadeDias) {
            return valorParcela * taxaJuros * quantidadeDias / (100 * periodoParcela);
        }

        /// <summary>
        /// Realiza o calculo dos juros exponencial
        /// </summary>
        /// <param name="valorEmprestimo">Valor do empréstimo</param>
        /// <param name="quantidadeParcelas">Quantidade de parcelas</param>
        /// <param name="taxaJuros">Taxa de juros</param>   
        /// <returns>Juros exponencial calculado</returns>
        private decimal CalcularJurosExponencial(decimal valorParcela, decimal taxaJuros, int quantidadeDias) {
            return valorParcela * Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + taxaJuros / 100), Convert.ToDouble(quantidadeDias / periodoParcela)) -1);
        }


        private void buttonCalcular_Click(object sender, EventArgs e) {
            ExibirTelaAguarde("Processando...");

            decimal valorEmprestimo = Convert.ToDecimal(textEditValorEmprestimo.EditValue);
            int quantidadeParcelas = Convert.ToInt32(textEditQuantidadeParcelas.EditValue);
            decimal taxaJuros = Convert.ToDecimal(textEditTaxaJuros.EditValue);
            if (Validar(valorEmprestimo, quantidadeParcelas, taxaJuros)) {
                CalcularParcelas(valorEmprestimo, quantidadeParcelas, taxaJuros);
            }

            FecharTelaAguarde();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            MaximizeBox = false;
        }

        public void ExibirTelaAguarde(string description) {
            if (SplashScreenManager.Default == null) {
                SplashScreenManager.ShowForm(this, typeof(FrmWaitForm), true, true, ParentFormState.Locked);
            }

            SplashScreenManager.Default.SetWaitFormDescription(description);
        }

        /// <summary>
        /// Fechar interface de Espera.
        /// </summary>
        public void FecharTelaAguarde() {
            try { SplashScreenManager.CloseForm(false); } catch { }
        }
    }

    public class CalculoResult {
        public int Parcela { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal PrincipalParcela { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal JurosLinear { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal TotalParcelaExponencial { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal JurosExponencial { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}")]
        public decimal TotalParcelaLinear { get; set; }
    }
}
