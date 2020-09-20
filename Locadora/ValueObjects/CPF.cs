using System;

namespace Locadora.ValueObjects
{
  public class CPF
  {
    public CPF(string cpf)
    {
      ValidarCamposNulos(cpf);
      CalcularDigitos(cpf, NovePrimeirosDigitos);
      CalcularDigitos(cpf, DezPrimeirosDigitos);
      //ValidarDigito(cpf);

      this.cpf = cpf;
    }

    public string cpf { get; private set; }
    public int NovePrimeirosDigitos
    {
      get => NovePrimeirosDigitos;
      set
      {
        NovePrimeirosDigitos = cpf.Length - 3;
      }
    }
    public int DezPrimeirosDigitos
    {
      get => DezPrimeirosDigitos;
      set
      {
        DezPrimeirosDigitos = cpf.Length - 4;
      }
    }

    private void ValidarCamposNulos(string cpf)
    {
      if (string.IsNullOrEmpty(cpf))
      {
        throw new ArgumentNullException("O campo cpf é obrigatório");
      }
    }

    private void ValidarTamanhoCpf(string cpf)
    {
      const int tamanhoIdealCpf = 11;

      if (cpf.Length - 1 < tamanhoIdealCpf || cpf.Length - 1 > tamanhoIdealCpf)
      {
        throw new ArgumentNullException("O tamanho do CPF está inválido.");
      }
    }

    private void ValidarCpfComNumerosRepetidos(string cpf)
    {

    }
    private void ValidarPrimeiroDigito(string cpf)
    {
      var primeiroDigito = cpf.Substring(0, 1);

    }

    private decimal CalcularDigitos(string cpf, int digito)
    {
      var multiplicadorDigito = 10;
      var somaTotalMultiplicaoDigitos = 0;

      for (int numeroCpfAtual = 0; numeroCpfAtual <= digito; numeroCpfAtual++)
      {
        var multiplicacaoDigito = numeroCpfAtual * multiplicadorDigito;
        somaTotalMultiplicaoDigitos += multiplicacaoDigito;
        multiplicacaoDigito -= 1;
      }

      var totalDivisaoDigitos = (somaTotalMultiplicaoDigitos * 10);
      var restoDivisaoDigitos = totalDivisaoDigitos % 11;
      return restoDivisaoDigitos;
    }

    /*     private bool ValidarPrimeiroDigito(string cpf, int restoDivisaoDigitos)
        {
          var primeiroDigito = cpf.Substring(0, 1);

          if (restoDivisaoDigitos == 10)
          {
            restoDivisaoDigitos = 0;
          }

          if (restoDivisaoDigitos != primeiroDigito)
          {
            throw new InvalidOperationException("O CPF é inválido");
          }

          return 
        } */

  }
}