namespace peixera;

public class Tauto : AnimalMari
    {
        public int Vida { get; set; } = 50;

        public Tauto(int mida, Sexe sexe) : base(mida, sexe) { }

        public override void Moure(int mida)
        {
            base.Moure(mida);
            Vida--;
            if (Vida <= 0) Viu = false;
        }

        public override void Interactuar(AnimalMari altre, List<AnimalMari> animals, int mida)
        {
            if (!Viu || !altre.Viu) return;

            if (!(altre is Tauto) && !(altre is Tortuga))
            {
                altre.Viu = false;
            }

            if (altre is Tauto && altre.Sexe == this.Sexe)
            {
                this.Viu = false;
                altre.Viu = false;
            }

            if (altre is Tauto && altre.Sexe != this.Sexe)
            {
                Tauto fill = new Tauto(mida, rnd.Next(2) == 0 ? Sexe.Mascle : Sexe.Femella);
                fill.X = this.X;
                fill.Y = this.Y;
                animals.Add(fill);
            }

            if (altre is Tortuga)
            {
                Direccio = (Direccio)rnd.Next(4);
            }
        }
    }