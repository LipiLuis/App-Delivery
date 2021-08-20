using AppFooD.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFood.Models
{
    public class EnderecoValidator : AbstractValidator<Endereco>
    {
        public EnderecoValidator()
        {
            RuleFor(x => x.Numero).NotEmpty().WithMessage("Número Obrigatório");
            RuleFor(x => x.Municipio).NotEmpty().WithMessage("Municipio Obrigatório");
            RuleFor(x => x.Rua).NotEmpty().WithMessage("Rua Obrigatório");
            RuleFor(x => x.Bairro).NotEmpty().WithMessage("Bairro Obrigatório");
            RuleFor(x => x.Cep).NotEmpty().WithMessage("Cep Obrigatório");
            RuleFor(x => x.UF).NotEmpty().WithMessage("Estado Obrigatório");
        }      
    }
}
