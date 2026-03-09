namespace peixera;

class Program
    {
        static void Main(string[] args)
        {
            Peixera p = new Peixera();

            for (int i = 0; i < 10; i++)
            {
                p.Animals.Add(new Peix(p.Mida, Sexe.Mascle));
                p.Animals.Add(new Peix(p.Mida, Sexe.Femella));
            }

            p.Animals.Add(new Tauto(p.Mida, Sexe.Mascle));
            p.Animals.Add(new Tauto(p.Mida, Sexe.Femella));

            p.Animals.Add(new Pop(p.Mida));
            p.Animals.Add(new Pop(p.Mida));

            p.Animals.Add(new Tortuga(p.Mida, Sexe.Mascle));
            p.Animals.Add(new Tortuga(p.Mida, Sexe.Femella));
            p.Animals.Add(new Tortuga(p.Mida, Sexe.Mascle));

            for (int i = 0; i < 100; i++)
                p.SimularRonda();

            p.MostrarResultats();

            Console.ReadLine();
        }
    }