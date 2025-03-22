namespace FileCalcio
{
    public partial class Form1 : Form
    {
        struct Partita
        {
            public string SquadraCasa;
            public string SquadraOspite;
            public int GolCasa;
            public int GolOspite;

            public Partita(string c, string o, int gc, int go)
            {
                SquadraCasa = c;
                SquadraOspite = o;
                GolCasa = gc;
                GolOspite = go;
            }
        }

        Partita[] partite;
        int partitaCorrente = 0;
        int[] ordineDati = new int[4] { 0, 1, 2, 3 }; //ordine di default, può venire sovrascritto

        public Form1()
        {
            InitializeComponent();
            ordineDati = LoadFile(@"..\..\..\..\data.csv");
            SaveFile(@"..\..\..\..\data.csv", ordineDati);

        }

        private int[] LoadFile(string path)
        {
            partite = new Partita[30];
            int SquadraCasaIndex = -1, SquadraOspiteIndex = -1, GolCasaIndex = -1, GolOspiteIndex = -1;
            using (StreamReader sr = new StreamReader(path))
            {
                int i = 0;
                while (sr.Peek() != -1)
                {
                    string record = sr.ReadLine();
                    string[] campi = record.Split(';');

                    for (int j = 0; j < campi.Length; j++)
                    {
                        if (i == 0)
                        {
                            switch (campi[j])
                            {
                                case "SquadraCasa":
                                    SquadraCasaIndex = j;
                                    break;
                                case "SquadraOspite":
                                    SquadraOspiteIndex = j;
                                    break;
                                case "GolCasa":
                                    GolCasaIndex = j;
                                    break;
                                case "GolOspite":
                                    GolOspiteIndex = j;
                                    break;
                                default:
                                    MessageBox.Show("Nell'intestazione c'è un nome non riconoscuiuto, ignorato");
                                    break;
                            }
                        }
                        else
                        {
                            try
                            {
                                partite[partitaCorrente] = new Partita(campi[SquadraCasaIndex], campi[SquadraOspiteIndex], int.Parse(campi[GolCasaIndex]), int.Parse(campi[GolOspiteIndex]));
                            }
                            catch
                            {
                                MessageBox.Show("Uno dei campi del file non e' converitbile in numero intero");
                            }
                        }
                    }
                    if (i == 0)
                    {
                        if (SquadraCasaIndex == -1 || SquadraOspiteIndex == -1 || GolCasaIndex == -1 || GolOspiteIndex == -1)
                        {
                            MessageBox.Show("Nell'intestazione non ci sono tutti i nomi");
                            return (new int[0]);
                        }
                    }
                    else
                    {
                        partitaCorrente++;
                    }

                    i++;
                }
            }
            return (new int[4] { SquadraCasaIndex, SquadraOspiteIndex, GolCasaIndex, GolOspiteIndex });
        }

        private string getCampo(string[] valori, int[] indici, int indice)
        {
            for (int i = 0; i < valori.Length; i++)
            {
                if (indici[i] == indice)
                {
                    return valori[i];
                }
            }
            MessageBox.Show("Impossibile trovare un campo nella funzione getCampo");
            return "";
        }

        private void SaveFile(string path, int SquadraCasaIndex, int SquadraOspiteIndex, int GolCasaIndex, int GolOspiteIndex)
        {
            try
            {
                File.WriteAllText(path, "");
                using (StreamWriter sw = File.AppendText(path))
                {
                    string[] nomiCampi = new string[4] { "SquadraCasa", "SquadraOspite", "GolCasa", "GolOspite" };
                    int[] indici = new int[4] {SquadraCasaIndex, SquadraOspiteIndex, GolCasaIndex, GolOspiteIndex};
                    for (int i = 0; i<4; i++)
                    {
                        string elemento = getCampo(nomiCampi, indici, i);
                        sw.Write(elemento);
                        if (i != 3)
                        {
                            sw.Write(";");
                        }
                    }
                    sw.WriteLine();

                    for (int i = 0; i<partite.Length; i++)
                    {
                        string[] valoriCampi = new string[4] { partite[i].SquadraCasa, partite[i].SquadraOspite, partite[i].GolCasa.ToString(), partite[i].GolOspite.ToString() };
                        for (int j = 0; j < 4; j++)
                        {
                            string elemento = getCampo(valoriCampi, indici, j);
                            sw.Write(elemento);
                            if (j != 3)
                            {
                                sw.Write(";");
                            }
                        }
                        sw.WriteLine();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Qualcosa è andato storto nella scrittura del file");
            }
        }

        private void SaveFile (string path, int[] ordine)
        {
            SaveFile(path, ordine[0], ordine[1], ordine[2], ordine[3]);
        }

        private void ShowData (int[] ordine)
        {
            lst_elenco.Items.Clear();
            string[] nomiCampi = new string[4] { "SquadraCasa", "SquadraOspite", "GolCasa", "GolOspite" };
            lst_elenco.Items.Add(PadString(new string[4] {
                getCampo(nomiCampi, ordine, 0),
                getCampo(nomiCampi, ordine, 1),
                getCampo(nomiCampi, ordine, 2),
                getCampo(nomiCampi, ordine, 3),
            }));

            for (int i = 0; i < partite.Length; i++)
            {
                string[] valori = new string[4] {
                    partite[i].SquadraCasa.ToString(),
                    partite[i].SquadraOspite.ToString(),
                    partite[i].GolCasa.ToString(),
                    partite[i].GolOspite.ToString()
                };
                lst_elenco.Items.Add(PadString(new string[4] {
                getCampo(valori, ordine, 0),
                getCampo(valori, ordine, 1),
                getCampo(valori, ordine, 2),
                getCampo(valori, ordine, 3),
            }));
            }
        }

        private string PadString(string[] txt)
        {
            string output = "";
            for (int i = 0; i< txt.Length; i++)
            {
                output += txt[i].PadRight(20);
            }
            return output;
        }

    }
}