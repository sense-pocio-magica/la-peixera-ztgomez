namespace peixera;

public class Peix : AnimalMari
    {
        public Peix(int mida, Sexe sexe) : base(mida, sexe) { }

        public override void Interactuar(AnimalMari altre, List<AnimalMari> animals, int mida)
        {
            if (!Viu || !altre.Viu) return;

            if (altre is Peix && altre.Sexe == this.Sexe)
            {
                this.Viu = false;
                altre.Viu = false;
            }

            if (altre is Peix && altre.Sexe != this.Sexe)
            {
                Direccio novaDir;
                do
                {
                    novaDir = (Direccio)rnd.Next(4);
                } while (novaDir == this.Direccio || novaDir == altre.Direccio);

                Peix fill = new Peix(mida, rnd.Next(2) == 0 ? Sexe.Mascle : Sexe.Femella);
                fill.X = this.X;
                fill.Y = this.Y;
                fill.Direccio = novaDir;

                animals.Add(fill);
            }

            if (altre is Tauto)
            {
                this.Viu = false;
            }
        }
    }