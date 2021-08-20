using AppFood;
using AppFood.Models;
using AppFooD.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AppFooD.ViewModel
{
    public class CadastroEnderecoViewModel : BaseViewModel
    {

        private Endereco _Enderecoo;
        public Endereco Enderecoo
        {
            get { return _Enderecoo; }
            set { SetProperty(ref _Enderecoo, value); }
        }
        #region props
        private int _numero;
        public int numero
        {
            get { return _numero; }
            set { SetProperty(ref _numero, value); }
        }

        private string _bairro;
        public string bairro
        {
            get { return _bairro; }
            set { SetProperty(ref _bairro, value); }
        }

        private string _cep;
        public string cep
        {
            get { return _cep; }
            set { SetProperty(ref _cep, value); }
        }

        private string _complemento;
        public string complemento
        {
            get { return _complemento; }
            set { SetProperty(ref _complemento, value); }
        }

        private string _municipio;
        public string municipio
        {
            get { return _municipio; }
            set { SetProperty(ref _municipio, value); }
        }


        private string _rua;
        public string rua
        {
            get { return _rua; }
            set { SetProperty(ref _rua, value); }
        }

        private string _uf;
        public string uf
        {
            get { return _uf; }
            set { SetProperty(ref _uf, value); }
        }
        private string _pontoReferencia;
        public string pontoReferencia
        {
            get { return _pontoReferencia; }
            set { SetProperty(ref _pontoReferencia, value); }
        }
        #endregion
        public ICommand ValidarCommand { get; set; }
        public EnderecoValidator _enderecoValidator { get; set; }
        public Endereco Endereco { get; set; }
        public ICommand GravarEnderecoCommand { get; set; }
        public CadastroEnderecoViewModel()
        {
            Enderecoo = new Endereco();
            _enderecoValidator = new EnderecoValidator();
        }


        public bool GravarEnderecoList(ObservableCollection<Endereco> listEndereco)
        {
            //Endereco = new Endereco
            //{
            //    Numero = numero,
            //    Bairro = bairro,
            //    Cep = cep,
            //    Complemento = complemento,
            //    Municipio = municipio,
            //    PontoReferencia = pontoReferencia,
            //    Rua = rua,
            //    UF = uf
            //};

            var result = _enderecoValidator.Validate(Enderecoo);
            if (result.IsValid)
            {
                listEndereco.Add(Enderecoo);
                LimparCampos();
                App.Current.MainPage.DisplayAlert("Cadastro", "Cadastro Validado com Sucesso", "Ok");
                return true;
            }

            else
            {
                var erros = "";
                foreach (var failure in result.Errors)
                {
                    erros += $",{failure.ErrorMessage}";
                }
                App.Current.MainPage.DisplayAlert("FluentValidation", erros.Substring(1), "Ok");
                return false;
            }
        }
        public void LimparCampos()
        {
            Enderecoo = new Endereco
            {
                Bairro = "",
                Cep = "",
                Complemento = "",
                Municipio = "",
                Numero = 0,
                PontoReferencia = "",
                Rua = "",
                UF = ""
            };
            //numero = 0;
            //uf = "";
            //municipio = "";
            //bairro = "";
            //pontoReferencia = "";
            //cep = "";
            //complemento = "";
            //rua = "";

        }
    }
}
