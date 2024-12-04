using System.Security.Cryptography;

namespace _02Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;       
            Addition();
            Subtraktion();
            Multiplikation();
            Division();
            WahlRechenart();
           
            static void Addition()
            {
                //Console.WriteLine("Gib eine Zahl für die Addition ein:");
                //string eingabe1 = Console.ReadLine();
                //int zahl1 = 0;
                //bool formatOk1 = false;

                //do
                //{
                //    formatOk1 = int.TryParse(eingabe1, out zahl1);
                //    if (formatOk1 == false)
                //    {
                //        Console.WriteLine("Falsches Format! Bitte Wiederhole die Eingabe!");
                //        eingabe1 = Console.ReadLine();
                //        Console.Clear();
                //    }
                //} while (formatOk1 == false);
                //Console.WriteLine("Gib eine zweite Zahl für die Addition ein:");
                //string eingabe2 = Console.ReadLine();
                //int zahl2 = 0;
                //bool formatOk2 = false;

                //do
                //{
                //    formatOk2 = int.TryParse(eingabe2, out zahl2);
                //    if (formatOk2 == false)
                //    {
                //        Console.WriteLine("Falsches Format! Bitte Wiederhole die Eingabe!");
                //        eingabe2 = Console.ReadLine();
                //        Console.Clear();
                //    }
                //} while (formatOk2 == false);

                //int addition = zahl1 + zahl2;
                //Console.WriteLine($"Ergebnis der Addition: {addition}");
            }   // Addition von zwei Zahlen
            static void Subtraktion()
            {
                //Console.WriteLine("Gib eine Zahl ein:");
                //string eingabe1 = Console.ReadLine();
                //int zahl1 = 0;
                //bool formatOk1 = false;

                //do
                //{
                //    formatOk1 = int.TryParse(eingabe1, out zahl1);
                //    if (formatOk1 == false)
                //    {
                //        Console.WriteLine("Falsches Format! Bitte Wiederhole die Eingabe!");
                //        eingabe1 = Console.ReadLine();
                //        Console.Clear();
                //    }
                //} while (formatOk1 == false);
                //Console.WriteLine("Gib eine zweite Zahl ein:");
                //string eingabe2 = Console.ReadLine();
                //int zahl2 = 0;
                //bool formatOk2 = false;

                //do
                //{
                //    formatOk2 = int.TryParse(eingabe2, out zahl2);
                //    if (formatOk2 == false)
                //    {
                //        Console.WriteLine("Falsches Format! Bitte Wiederhole die Eingabe!");
                //        eingabe2 = Console.ReadLine();
                //        Console.Clear();
                //    }
                //} while (formatOk2 == false);

                //int subtaktion = zahl1 - zahl2;
                //Console.WriteLine($"Ergebnis: {subtaktion}");
            }   // Subtraktion von zwei Zahlen
            static void Multiplikation()
            {
                //Console.WriteLine("Gib eine Zahl für die Multiplikation ein:");
                //string eingabe1 = Console.ReadLine();
                //int zahl1 = 0;
                //bool formatOk1 = true;

                //do
                //{
                //    formatOk1 = int.TryParse(eingabe1, out zahl1);
                //    if (formatOk1 == false)
                //    {
                //        Console.WriteLine("Falsches Format! Bitte wiederhole die erste Eingabe!");
                //        eingabe1 = Console.ReadLine();
                //        Console.Clear();
                //    }
                //} while (formatOk1 == false);

                //Console.WriteLine("Gib eine zweite Zahl für die Multiplikation ein:");
                //string eingabe2 = Console.ReadLine();
                //int zahl2 = 0;
                //bool formatOk2 = true;

                //do
                //{
                //    formatOk2 = int.TryParse(eingabe2, out zahl2);
                //    if (formatOk2 == false)
                //    {
                //        Console.WriteLine("Falsches Format! Bitte wiederhole die zweite Eingabe!");
                //        eingabe2 = Console.ReadLine();
                //        Console.Clear();
                //    }
                //} while (formatOk2 == false);

                //int multiplikation = zahl1 * zahl2;
                //Console.WriteLine($"Ergebnis der Multiplikation: {multiplikation}");
            }   // Multiplikation von zwei Zahlen
            static void Division()
            {
                //Console.WriteLine("Gib eine Zahl für die Division ein:");
                //string eingabeDiv1 = Console.ReadLine();
                //int zahlDiv1 = 0;
                //bool formatOkDiv1 = true;
                //do
                //{
                //    formatOkDiv1 = int.TryParse(eingabeDiv1, out zahlDiv1);
                //    if (formatOkDiv1 == false)
                //    {
                //        Console.WriteLine("Falsches Format! Bitte wiederhole die erste Eingabe!");
                //        eingabeDiv1 = Console.ReadLine();
                //        Console.Clear();
                //    }
                //} while (formatOkDiv1 == false);

                //Console.WriteLine("Gib eine zweite Zahl für die Division ein:");
                //string eingabeDiv2 = Console.ReadLine();
                //int zahlDiv2 = 0;
                //bool formatOkDiv2 = true;
                //do
                //{
                //    formatOkDiv2 = int.TryParse(eingabeDiv2, out zahlDiv2);
                //    if (formatOkDiv2 == false)
                //    {
                //        Console.WriteLine("Falsches Format! Bitte wiederhole die zweite Eingabe!");
                //        eingabeDiv2 = Console.ReadLine();
                //        Console.Clear();
                //    }
                //} while (formatOkDiv2 == false);

                //double division = (double)zahlDiv1 / zahlDiv2;
                //Console.WriteLine($"Ergebnis der Division: {division}");
            }   // Division von zwei Zahlen
            static void WahlRechenart()
            {
                bool again = true;      // Für die Wiederholung des Programms   
                do
                {
                    Console.WriteLine("Wähle eine Rechenart aus:\nAddition\t(+)\nSubtraktion\t(-)\nMultiplikation\t(*)\nDivision\t(/)");    
                    string userWahl = Console.ReadLine().ToLower().Trim();      // Auswahl der Rechenart

                    switch (userWahl)       // Auswahl der Rechenart
                    {
                        case "+":       // Addition
                            Console.WriteLine("Gib eine Zahl für die Addition ein:");   
                            string eingabe1 = Console.ReadLine();       // Eingabe der ersten Zahl
                            int zahl1 = 0;
                            bool formatOk1 = false;

                            do
                            {
                                formatOk1 = int.TryParse(eingabe1, out zahl1);      // Prüfung der ersten Eingabe 
                                if (formatOk1 == false)
                                {
                                    Console.WriteLine("Falsches Format! Bitte Wiederhole die erste Eingabe!");
                                    eingabe1 = Console.ReadLine();      // Wiederholung der ersten Eingabe wenn false
                                    Console.Clear();
                                }
                            } while (formatOk1 == false);       

                            Console.WriteLine("Gib eine zweite Zahl für die Addition ein:");    
                            string eingabe2 = Console.ReadLine();       // Eingabe der zweiten Zahl
                            int zahl2 = 0;
                            bool formatOk2 = false;

                            do
                            {
                                formatOk2 = int.TryParse(eingabe2, out zahl2);      // Prüfung der zweiten Eingabe
                                if (formatOk2 == false)
                                {
                                    Console.WriteLine("Falsches Format! Bitte Wiederhole die zweite Eingabe!");
                                    eingabe2 = Console.ReadLine();      // Wiederholuung der zweiten Eingabe wenn false
                                    Console.Clear();
                                }
                            } while (formatOk2 == false);       

                            int addition = zahl1 + zahl2;
                            Console.WriteLine($"Ergebnis der Addition: {addition}");    // Ergebnis der Addition
                            break;
                        case "-":        // Subtraktion
                            Console.WriteLine("Gib eine Zahl für die Subtaktion ein:");
                            string eingabeSub1 = Console.ReadLine();        // Eingabe der ersten Zahl
                            int zahlSub1 = 0;
                            bool formatOkSub1 = false;

                            do
                            {
                                formatOkSub1 = int.TryParse(eingabeSub1, out zahlSub1);     // Prüfung der ersten Eingabe
                                if (formatOkSub1 == false)
                                {
                                    Console.WriteLine("Falsches Format! Bitte Wiederhole die erste Eingabe!");
                                    eingabeSub1 = Console.ReadLine();       // Wiederholung der ersten Eingabe wenn false
                                    Console.Clear();
                                }
                            } while (formatOkSub1 == false);

                            Console.WriteLine("Gib eine zweite Zahl für die Subtaktion ein:");
                            string eingabeSub2 = Console.ReadLine();        // Eingabe der zweiten Zahl
                            int zahlSub2 = 0;
                            bool formatOkSub2 = false;

                            do
                            {
                                formatOkSub2 = int.TryParse(eingabeSub2, out zahlSub2);     // Prüfung der zweiten Eingabe
                                if (formatOkSub2 == false)
                                {
                                    Console.WriteLine("Falsches Format! Bitte Wiederhole die zweite Eingabe!");
                                    eingabeSub2 = Console.ReadLine();       // Wiederholung der zweiten Eingabe
                                    Console.Clear();
                                }
                            } while (formatOkSub2 == false);

                            int subtraktion = zahlSub1 - zahlSub2;
                            Console.WriteLine($"Ergebnis der Subtraktion: {subtraktion}");      // Ergebnis der Subtraktion
                            break;
                        case "*":       // Multiplikation
                            Console.WriteLine("Gib eine Zahl für die Multiplikation ein:");
                            string eingabeMul1 = Console.ReadLine();        // Eingabe der ersten Zahl
                            int zahlMul1 = 0;
                            bool formatOkMul1 = true;

                            do
                            {
                                formatOkMul1 = int.TryParse(eingabeMul1, out zahlMul1);     // Prüfung der ersten Eingabe
                                if (formatOkMul1 == false)
                                {
                                    Console.WriteLine("Falsches Format! Bitte wiederhole die erste Eingabe!");
                                    eingabeMul1 = Console.ReadLine();       // Wiederholung der ersten Eingabe wenn false
                                    Console.Clear();
                                }
                            } while (formatOkMul1 == false);

                            Console.WriteLine("Gib eine zweite Zahl für die Multiplikation ein:");
                            string eingabeMul2 = Console.ReadLine();        // Eingabe der zweiten Zahl
                            int zahlMul2 = 0;
                            bool formatOKMul2 = true;

                            do
                            {
                                formatOKMul2 = int.TryParse(eingabeMul2, out zahlMul2);     // Prüfung der zweiten Eingabe
                                if (formatOKMul2 == false)
                                {
                                    Console.WriteLine("Falsches Format! Bitte wiederhole die zweite Eingabe!");
                                    eingabeMul2 = Console.ReadLine();       // Wiederholung der zweiten Eingabe wenn false
                                    Console.Clear();
                                }
                            } while (formatOKMul2 == false);

                            int multiplikation = zahlMul1 * zahlMul2;
                            Console.WriteLine($"Ergebnis der Multiplikation: {multiplikation}");    // Ergebnis der Multiplikation
                            break;
                        case "/":       // Division
                            Console.WriteLine("Gib eine Zahl für die Division ein:");   
                            string eingabeDiv1 = Console.ReadLine();        // Eingabe der ersten Zahl
                            int zahlDiv1 = 0;
                            bool formatOkDiv1 = true;
                            do
                            {
                                formatOkDiv1 = int.TryParse(eingabeDiv1, out zahlDiv1);     // Prüfung der ersten Eingabe
                                if (formatOkDiv1 == false)
                                {
                                    Console.WriteLine("Falsches Format! Bitte wiederhole die erste Eingabe!");
                                    eingabeDiv1 = Console.ReadLine();       // Wiederholung der ersten Eingabe wenn false
                                    Console.Clear();
                                }
                            } while (formatOkDiv1 == false);

                            Console.WriteLine("Gib eine zweite Zahl für die Division ein:");
                            string eingabeDiv2 = Console.ReadLine();        // Eingabe der zweiten Zahl
                            int zahlDiv2 = 0;
                            bool formatOkDiv2 = true;
                            do
                            {
                                formatOkDiv2 = int.TryParse(eingabeDiv2, out zahlDiv2);     // Prüfung der zweiten Eingabe
                                if (formatOkDiv2 == false)
                                {
                                    Console.WriteLine("Falsches Format! Bitte wiederhole die zweite Eingabe!");
                                    eingabeDiv2 = Console.ReadLine();       // Wiederholung der zweiten Eingabe
                                    Console.Clear();
                                }
                            } while (formatOkDiv2 == false);

                            double division = (double)zahlDiv1 / zahlDiv2;
                            Console.WriteLine($"Ergebnis der Division: {division}");        // Ergebnis der Division
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe!");
                            break;
                    }
                    Console.WriteLine("Möchten Sie weiter machen? (y/n)");  // Für die Wiederholung des Programms
                    string nochmal = Console.ReadLine();
                    Console.Clear();

                    switch (nochmal)
                    {
                        case "y":
                            again = true;
                            break;
                        case "n":
                            again = false;
                            Console.WriteLine("Programm beendet!");
                            break;
                    }
                } while (again == true);

            }   // Wahl der Rechenart





        }
    }
}