namespace peixera;

public enum Sexe
    {
        Mascle, Femella, Cap
    }

    public enum Direccio
    {
        Amunt, Avall, Esquerra, Dreta
    }

    public abstract class AnimalMari
    {
        protected static Random rnd = new Random();

        public int X { get; set; }
        public int Y { get; set; }
        public Sexe Sexe { get; set; }
        public Direccio Direccio { get; set; }
        public bool Viu { get; set; } = true;

        public AnimalMari(int mida, Sexe sexe)
        {
            X = rnd.Next(mida);
            Y = rnd.Next(mida);
            Sexe = sexe;
            Direccio = (Direccio)rnd.Next(4);
        }

        public virtual void Moure(int mida)
        {
            switch (Direccio)
            {
                case Direccio.Amunt: X--; break;
                case Direccio.Avall: X++; break;
                case Direccio.Esquerra: Y--; break;
                case Direccio.Dreta: Y++; break;
            }

            if (X < 0) X = mida - 1;
            if (X >= mida) X = 0;
            if (Y < 0) Y = mida - 1;
            if (Y >= mida) Y = 0;
        }

        public abstract void Interactuar(AnimalMari altre, List<AnimalMari> animals, int mida);
    }

