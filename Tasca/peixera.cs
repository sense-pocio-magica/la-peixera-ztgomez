namespace peixera;
public class Peixera
    {
        public List<AnimalMari> Animals = new List<AnimalMari>();
        public int Mida = 20;

        public void SimularRonda()
        {
            foreach (var a in Animals.Where(a => a.Viu))
                a.Moure(Mida);

            for (int i = 0; i < Animals.Count; i++)
            {
                for (int j = i + 1; j < Animals.Count; j++)
                {
                    if (Animals[i].Viu && Animals[j].Viu &&
                        Animals[i].X == Animals[j].X &&
                        Animals[i].Y == Animals[j].Y)
                    {
                        Animals[i].Interactuar(Animals[j], Animals, Mida);
                        Animals[j].Interactuar(Animals[i], Animals, Mida);
                    }
                }
            }

            Animals = Animals.Where(a => a.Viu).ToList();
        }

        public void MostrarResultats()
        {
            Console.WriteLine($"Peixos: {Animals.OfType<Peix>().Count()}");
            Console.WriteLine($"Taurons: {Animals.OfType<Tauto>().Count()}");
            Console.WriteLine($"Pops: {Animals.OfType<Pop>().Count()}");
            Console.WriteLine($"Tortugues: {Animals.OfType<Tortuga>().Count()}");
        }
    }
