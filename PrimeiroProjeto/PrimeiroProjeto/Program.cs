using System.Globalization;

class Conta {
    public int Numero {get; private set;}
    public string Titular {get; set;}
    public double Saldo {get; private set;}

    public Conta (int numero, string titular) {
        Numero = numero;
        Titular = titular;
    }

    public Conta(int numero, string titular, double saldo) : this(numero, titular) {
        Saldo = saldo;
    }

    public override string ToString() {
        return "Conta " + Numero + ", Titular " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }

    public void Depositar(int valor) {
        Saldo += valor;
    }

    public void Sacar(int valor) {
        Saldo -= valor;
    }
}

namespace PrimeiroProjet {
    internal class Program {
        static void Main(string[] args) {

            
        }
    }
}
