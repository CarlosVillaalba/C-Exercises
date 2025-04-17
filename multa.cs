using System;

class Multa
{
    public string NumeroPlaca { get; set; }
    public DateTime Fecha { get; set; }
    public double MontoBase { get; set; }

    public Multa(string numeroPlaca, double montoBase)
    {
        NumeroPlaca = numeroPlaca;
        Fecha = DateTime.Now;
        MontoBase = montoBase;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Placa: {NumeroPlaca}");
        Console.WriteLine($"Fecha: {Fecha}");
        Console.WriteLine($"Monto base: ${MontoBase}");
    }
}

class MultaEstacionamiento : Multa
{
    public string TipoInfraccion { get; set; }

    public MultaEstacionamiento(string numeroPlaca, string tipoInfraccion)
        : base(numeroPlaca, 50) // Monto base: $50
    {
        TipoInfraccion = tipoInfraccion;
    }

    public double CalcularMontoTotal()
    {
        double multaExtra = TipoInfraccion switch
        {
            "Bloqueo de rampa" => 100,
            "Estacionar en zona prohibida" => 75,
            "Exceso de tiempo" => 25,
            _ => 0
        };

        return MontoBase + multaExtra;
    }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"Tipo de infracción: {TipoInfraccion}");
        Console.WriteLine($"Monto total a pagar: ${CalcularMontoTotal()}");
    }
}

class Program
{
    static void Main()
    {
        MultaEstacionamiento multa1 = new MultaEstacionamiento("ABC123", "Bloqueo de rampa");
        multa1.MostrarDetalles();

        Console.WriteLine();

        MultaEstacionamiento multa2 = new MultaEstacionamiento("XYZ789", "Exceso de tiempo");
        multa2.MostrarDetalles();
    }
}
