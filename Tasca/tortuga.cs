namespace peixera;

public class Tortuga : AnimalMari
    {
        public Tortuga(int mida, Sexe sexe) : base(mida, sexe) { }

        public override void Interactuar(AnimalMari altre, List<AnimalMari> animals, int mida)
        {
            if (!Viu || !altre.Viu) return;

            if (altre is Tortuga && altre.Sexe == this.Sexe)
            {
                this.Viu = false;
                altre.Viu = false;
            }

            if (altre is Tortuga && altre.Sexe != this.Sexe)
            {
                Tortuga fill = new Tortuga(mida, rnd.Next(2) == 0 ? Sexe.Mascle : Sexe.Femella);
                fill.X = this.X;
                fill.Y = this.Y;
                animals.Add(fill);
            }
        }
    }