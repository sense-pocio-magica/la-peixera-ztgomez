namespace peixera;

public class Pop : AnimalMari
    {
        public Pop(int mida) : base(mida, Sexe.Cap) { }

        public override void Moure(int mida)
        {
            if (Direccio == Direccio.Amunt || Direccio == Direccio.Avall)
                Direccio = Direccio.Esquerra;

            base.Moure(mida);
        }

        public override void Interactuar(AnimalMari altre, List<AnimalMari> animals, int mida)
        {
            if (!Viu || !altre.Viu) return;

            if (altre is Pop)
            {
                Direccio = (Direccio)rnd.Next(4);
            }
            if (altre is Tauto)
            {
                this.Viu = false;
            }
        }
    }
