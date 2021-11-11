using System;

public class ContaBancaria : IConta
{
    public int NumeroDaConta { get; set; }
    public int Agencia { get; set; }
    public Pessoa Correntista { get; set; }
    public TipoDaConta Tipo { get; set; }



    public abstract override void DefinirTipoDaConta(int numeroConta, int tipoConta)
    {
        if (numeroConta > 0)
        {
            if (tipoConta == TipoDaConta.CC || tipoConta == tipoConta == TipoDaConta.CP || tipoConta == TipoDaConta.CI
               TipoDaConta = tipoConta;
            else
                throw new ArgumentException("Tipo da conta é inválido!");
        }
        else
        {
            throw new ArgumentException("Numero da conta é inválido!");
        }


    }

}
public interface IConta
{
    public int NumeroDaConta { get; set; }
    public int Agencia { get; set; }
    public TipoDaConta TipoDaConta { get; set; }

    public abstract void DefinirTipoDaConta()
    {

    }


}

public class Pessoa
{
    public string Nome { get; private set; }
    public string Documento { get; private set; }
}


public enum TipoDaConta
{
    [Description("ContaCorrente")]
    CC = 01,

    [Description("ContaPoupanca")]
    CP = 02,

    [Description("Investimento")]
    CI = 03,
}

class ContaContaCorrente : ContaBancaria
{
    static void Main(string[] args)
    {
        var conta = new ContaBancaria();
        conta.NumeroDaConta = 123;
        conta.Correntista = "Marise";
        conta.DefinirTipoDaConta(conta, 01)

    }
}