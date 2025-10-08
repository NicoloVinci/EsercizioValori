namespace Esercizio_Valori
{
    class CValoreScientifico
    {
        public double Valore { get; set; }
        public string UnitàMisura { get; set; }
        public CValoreScientifico()
        {
            Valore = 0;
            UnitàMisura = "unità non specificata";
        }
        public CValoreScientifico(double valore)
        {
            Valore = valore;
            UnitàMisura = "unità non specificata";
        }
        public CValoreScientifico(double valore, string unitàMisura)
        {
            Valore = valore;
            UnitàMisura = unitàMisura;
        }
        public virtual string ToString()
        {
            return $"{Valore} {UnitàMisura}";
        }
    }
    class CTemperatura : CValoreScientifico
    {
        public CTemperatura() : base()
        {

        }
        public CTemperatura(double valore) : base(valore)
        {

        }
        public CTemperatura(double valore, string unitàMisura) : base(valore)
        {
            if (unitàMisura != "°C" && unitàMisura != "°F" && unitàMisura != "K")
            {
                throw new ArgumentException("Unità di misura non valida per la temperatura, l'unità di misura non è stata settata.");
            }
            else
            {
                this.UnitàMisura = unitàMisura;
            }
        }
        public double ConvertiInCelsius()
        {
            try
            {
                if (this.UnitàMisura == "°F")
                {
                    return (this.Valore - 32) * 5 / 9;
                }
                else if (this.UnitàMisura == "K")
                {
                    return this.Valore - 273.15;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInFahrenheit()
        {
            try
            {
                if (this.UnitàMisura == "°C")
                {
                    return (this.Valore * 9 / 5) + 32;
                }
                else if (this.UnitàMisura == "K")
                {
                    return (this.Valore - 273.15) * 9 / 5 + 32;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInKelvin()
        {
            try
            {
                if (this.UnitàMisura == "°C")
                {
                    return this.Valore + 273.15;
                }
                else if (this.UnitàMisura == "°F")
                {
                    return (this.Valore - 32) * 5 / 9 + 273.15;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }

        public override string ToString()
        {
            return $"Valore: {Valore} {UnitàMisura}; In Celsius: {ConvertiInCelsius()} °C; In Fahrenheit: {ConvertiInFahrenheit()} °F; In Kelvin: {ConvertiInKelvin()} K";
        }
    }
    class CLunghezza : CValoreScientifico
    {
        public CLunghezza() : base()
        {

        }
        public CLunghezza(double valore) : base(valore)
        {

        }
        public CLunghezza(double valore, string unitàMisura) : base(valore)
        {
            if (unitàMisura != "km" && unitàMisura != "hm" && unitàMisura != "dam" && unitàMisura != "m" && unitàMisura != "dm" && unitàMisura != "cm" && unitàMisura != "mm")
            {
                throw new ArgumentException("Unità di misura non valida per la lunghezza, l'unità di misura non è stata settata.");
            }
            else
            {
                this.UnitàMisura = unitàMisura;
            }
        }
        public double ConvertiInKilometri()
        {
            try
            {
                if (this.UnitàMisura == "hm")
                {
                    return this.Valore / 10;
                }
                else if (this.UnitàMisura == "dam")
                {
                    return this.Valore / 100;
                }
                else if (this.UnitàMisura == "m")
                {
                    return this.Valore / 1000;
                }
                else if (this.UnitàMisura == "dm")
                {
                    return this.Valore / 10000;
                }
                else if (this.UnitàMisura == "cm")
                {
                    return this.Valore / 100000;
                }
                else if (this.UnitàMisura == "mm")
                {
                    return this.Valore / 1000000;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInEttometri()
        {
            try
            {
                if (this.UnitàMisura == "km")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "dam")
                {
                    return this.Valore / 10;
                }
                else if (this.UnitàMisura == "m")
                {
                    return this.Valore / 100;
                }
                else if (this.UnitàMisura == "dm")
                {
                    return this.Valore / 1000;
                }
                else if (this.UnitàMisura == "cm")
                {
                    return this.Valore / 10000;
                }
                else if (this.UnitàMisura == "mm")
                {
                    return this.Valore / 100000;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInDecametri()
        {
            try
            {
                if (this.UnitàMisura == "km")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "hm")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "m")
                {
                    return this.Valore / 10;
                }
                else if (this.UnitàMisura == "dm")
                {
                    return this.Valore / 100;
                }
                else if (this.UnitàMisura == "cm")
                {
                    return this.Valore / 1000;
                }
                else if (this.UnitàMisura == "mm")
                {
                    return this.Valore / 10000;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInMetri()
        {
            try
            {
                if (this.UnitàMisura == "km")
                {
                    return this.Valore * 1000;
                }
                else if (this.UnitàMisura == "hm")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "dam")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "dm")
                {
                    return this.Valore * 0.1;
                }
                else if (this.UnitàMisura == "cm")
                {
                    return this.Valore / 100;
                }
                else if (this.UnitàMisura == "mm")
                {
                    return this.Valore / 1000;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInDecimetri()
        {
            try
            {
                if (this.UnitàMisura == "km")
                {
                    return this.Valore * 10000;
                }
                else if (this.UnitàMisura == "hm")
                {
                    return this.Valore * 1000;
                }
                else if (this.UnitàMisura == "dam")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "m")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "cm")
                {
                    return this.Valore / 10;
                }
                else if (this.UnitàMisura == "mm")
                {
                    return this.Valore / 100;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInCentimetri()
        {
            try
            {
                if (this.UnitàMisura == "km")
                {
                    return this.Valore * 100000;
                }
                else if (this.UnitàMisura == "hm")
                {
                    return this.Valore * 10000;
                }
                else if (this.UnitàMisura == "dam")
                {
                    return this.Valore * 1000;
                }
                else if (this.UnitàMisura == "m")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "dm")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "mm")
                {
                    return this.Valore / 10;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInMillimetri()
        {
            try
            {
                if (this.UnitàMisura == "km")
                {
                    return this.Valore * 1000000;
                }
                else if (this.UnitàMisura == "hm")
                {
                    return this.Valore * 100000;
                }
                else if (this.UnitàMisura == "dam")
                {
                    return this.Valore * 10000;
                }
                else if (this.UnitàMisura == "m")
                {
                    return this.Valore * 1000;
                }
                else if (this.UnitàMisura == "dm")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "cm")
                {
                    return this.Valore * 10;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }

        public override string ToString()
        {
            return $"Valore: {Valore} {UnitàMisura}; In km: {ConvertiInKilometri()} km; In hm: {ConvertiInEttometri()} hm; In dam: {ConvertiInDecametri()} dam; In m: {ConvertiInMetri()} m; In dm: {ConvertiInDecimetri()} dm; In cm: {ConvertiInCentimetri()} cm; In mm: {ConvertiInMillimetri()} mm";
        }
    }
    class CMassa : CValoreScientifico
    {
        public CMassa() : base()
        {

        }
        public CMassa(double valore) : base(valore)
        {

        }
        public CMassa(double valore, string unitàMisura) : base(valore)
        {
            if (unitàMisura != "kg" && unitàMisura != "hg" && unitàMisura != "dag" && unitàMisura != "g" && unitàMisura != "dg" && unitàMisura != "cg" && unitàMisura != "mg")
            {
                throw new ArgumentException("Unità di misura non valida per la massa, l'unità di misura non è stata settata.");
            }
            else
            {
                this.UnitàMisura = unitàMisura;
            }
        }
        public double ConvertiInChilogrammi()
        {
            try
            {
                if (this.UnitàMisura == "hg")
                {
                    return this.Valore / 10;
                }
                else if (this.UnitàMisura == "dag")
                {
                    return this.Valore / 100;
                }
                else if (this.UnitàMisura == "g")
                {
                    return this.Valore / 1000;
                }
                else if (this.UnitàMisura == "dg")
                {
                    return this.Valore / 10000;
                }
                else if (this.UnitàMisura == "cg")
                {
                    return this.Valore / 100000;
                }
                else if (this.UnitàMisura == "mg")
                {
                    return this.Valore / 1000000;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInEttogrammi()
        {
            try
            {
                if (this.UnitàMisura == "kg")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "dag")
                {
                    return this.Valore / 10;
                }
                else if (this.UnitàMisura == "g")
                {
                    return this.Valore / 100;
                }
                else if (this.UnitàMisura == "dg")
                {
                    return this.Valore / 1000;
                }
                else if (this.UnitàMisura == "cg")
                {
                    return this.Valore / 10000;
                }
                else if (this.UnitàMisura == "mg")
                {
                    return this.Valore / 100000;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInDecagrammi()
        {
            try
            {
                if (this.UnitàMisura == "kg")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "hg")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "g")
                {
                    return this.Valore / 10;
                }
                else if (this.UnitàMisura == "dg")
                {
                    return this.Valore;
                }
                else if (this.UnitàMisura == "cg")
                {
                    return this.Valore / 1000;
                }
                else if (this.UnitàMisura == "mg")
                {
                    return this.Valore / 10000;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInGrammi()
        {
            try
            {
                if (this.UnitàMisura == "kg")
                {
                    return this.Valore * 1000;
                }
                else if (this.UnitàMisura == "hg")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "dag")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "dg")
                {
                    return this.Valore * 0.1;
                }
                else if (this.UnitàMisura == "cg")
                {
                    return this.Valore * 0.01;
                }
                else if (this.UnitàMisura == "mg")
                {
                    return this.Valore / 1000;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInDecigrammi()
        {
            try
            {
                if (this.UnitàMisura == "kg")
                {
                    return this.Valore * 10000;
                }
                else if (this.UnitàMisura == "hg")
                {
                    return this.Valore * 1000;
                }
                else if (this.UnitàMisura == "dag")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "g")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "cg")
                {
                    return this.Valore / 10;
                }
                else if (this.UnitàMisura == "mg")
                {
                    return this.Valore / 100;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInCentigrammi()
        {
            try
            {
                if (this.UnitàMisura == "kg")
                {
                    return this.Valore * 100000;
                }
                else if (this.UnitàMisura == "hg")
                {
                    return this.Valore * 10000;
                }
                else if (this.UnitàMisura == "dag")
                {
                    return this.Valore * 1000;
                }
                else if (this.UnitàMisura == "g")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "dg")
                {
                    return this.Valore * 10;
                }
                else if (this.UnitàMisura == "mg")
                {
                    return this.Valore / 10;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }
        public double ConvertiInMilligrammi()
        {
            try
            {
                if (this.UnitàMisura == "kg")
                {
                    return this.Valore * 1000000;
                }
                else if (this.UnitàMisura == "hg")
                {
                    return this.Valore * 100000;
                }
                else if (this.UnitàMisura == "dag")
                {
                    return this.Valore * 10000;
                }
                else if (this.UnitàMisura == "g")
                {
                    return this.Valore * 1000;
                }
                else if (this.UnitàMisura == "dg")
                {
                    return this.Valore * 100;
                }
                else if (this.UnitàMisura == "cg")
                {
                    return this.Valore * 10;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Errore durante la conversione, unità di misura non valida. Restituisco il valore originale.");
            }
            return this.Valore;
        }

        public override string ToString()
        {
            return $"Valore: {Valore} {UnitàMisura}; In kg: {ConvertiInChilogrammi()} kg; In hg: {ConvertiInEttogrammi()} hg; In dag: {ConvertiInDecagrammi()} dag; In g: {ConvertiInGrammi()} g; In dg: {ConvertiInDecigrammi()} dg; In cg: {ConvertiInCentigrammi()} cg; In mg: {ConvertiInMilligrammi()} mg";
        }
    }
    internal class Program
    {

        static double ChiediValore(string messaggio)
        {
            Console.Write(messaggio);
            double valore;
            while (!double.TryParse(Console.ReadLine(), out valore))
            {
                Console.WriteLine("Input non valido. Per favore, inserisci un numero decimale:");
            }
            return valore;
        }

        static string ChiediUnitàMisura(string messaggio, string[] unitàValide)
        {
            Console.Write(messaggio);
            string unitàMisura = Console.ReadLine();
            if(messaggio == "Inserisci l'unità di misura per il valore scientifico: ")
            {
                while(unitàMisura == "" || unitàMisura == null || unitàMisura == " ")
                {
                    Console.WriteLine("L'unità di misura non può essere vuota. Riprova:");
                    unitàMisura = Console.ReadLine();
                }
                return unitàMisura;
            }
            while (Array.IndexOf(unitàValide, unitàMisura) == -1)
            {
                Console.WriteLine("Unità di misura non valida. Riprova:");
                unitàMisura = Console.ReadLine();
            }
            return unitàMisura;
        }
        static void Main(string[] args)
        {
            bool exit = true;
            do {
                Console.Clear();
                Console.WriteLine("Benvenuto nell'esercizio sui valori scientifici!");
                Console.WriteLine("Scegli l'oggetto da creare che più si addice alle tue esigenze:");
                Console.WriteLine("1 - Valore scientifico generico (solamente stampabile, nessun'altra operazione disponibile)");
                Console.WriteLine("2 - Temperatura");
                Console.WriteLine("3 - Lunghezza");
                Console.WriteLine("4 - Massa");
                Console.WriteLine("5. - Esci");
                Console.Write("Inserisci il numero corrispondente alla tua scelta: ");
                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        {
                            Console.Clear();
                            CValoreScientifico valoreGenerico = new CValoreScientifico();
                            Console.WriteLine("Hai creato un valore scientifico generico: ");
                            Console.WriteLine(valoreGenerico.ToString());
                            double valore = ChiediValore("Inserisci un valore numerico (decimale) per il valore scientifico: ");
                            valoreGenerico.Valore = valore;
                            string unitàMisura = ChiediUnitàMisura("Inserisci l'unità di misura per il valore scientifico: ", new string[] {});
                            valoreGenerico.UnitàMisura = unitàMisura;
                            Console.WriteLine("Valore scientifico aggiornato: ");
                            Console.WriteLine(valoreGenerico.ToString());
                            Console.WriteLine("\nPremi un tasto per continuare...");
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            CTemperatura temperatura = new CTemperatura();
                            Console.WriteLine("Hai creato una temperatura: ");
                            Console.WriteLine(temperatura.ToString());
                            double valore = ChiediValore("Inserisci un valore numerico (decimale) per la temperatura: ");
                            temperatura.Valore = valore;
                            string unitàMisura = ChiediUnitàMisura("Inserisci l'unità di misura per la temperatura (°C, °F, K): ", new string[] { "°C", "°F", "K" });
                            temperatura.UnitàMisura = unitàMisura;
                            Console.WriteLine("Temperatura aggiornata con relative conversioni: ");
                            Console.WriteLine(temperatura.ToString());
                            Console.WriteLine("\nPremi un tasto per continuare...");
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            CLunghezza lunghezza = new CLunghezza();
                            Console.WriteLine("Hai creato una lunghezza: ");
                            Console.WriteLine(lunghezza.ToString());
                            double valore = ChiediValore("Inserisci un valore numerico (decimale) per la lunghezza: ");
                            lunghezza.Valore = valore;
                            string unitàMisura = ChiediUnitàMisura("Inserisci l'unità di misura per la lunghezza (km, hm, dam, m, dm, cm, mm): ", new string[] { "km", "hm", "dam", "m", "dm", "cm", "mm" });
                            lunghezza.UnitàMisura = unitàMisura;
                            Console.WriteLine("Lunghezza aggiornata con relative conversioni: ");
                            Console.WriteLine(lunghezza.ToString());
                            Console.WriteLine("\nPremi un tasto per continuare...");
                            Console.ReadKey();
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            CMassa massa = new CMassa();
                            Console.WriteLine("Hai creato una massa: ");
                            Console.WriteLine(massa.ToString());
                            double valore = ChiediValore("Inserisci un valore numerico (decimale) per la massa: ");
                            massa.Valore = valore;
                            string unitàMisura = ChiediUnitàMisura("Inserisci l'unità di misura per la massa (kg, hg, dag, g, dg, cg, mg): ", new string[] { "kg", "hg", "dag", "g", "dg", "cg", "mg" });
                            massa.UnitàMisura = unitàMisura;
                            Console.WriteLine("Massa aggiornata con relative conversioni: ");
                            Console.WriteLine(massa.ToString());
                            Console.WriteLine("\nPremi un tasto per continuare...");
                            Console.ReadKey();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Uscita dal programma...");
                            exit = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Scelta non valida. Premi un tasto per riprovare...");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (exit);
        }
    }
}