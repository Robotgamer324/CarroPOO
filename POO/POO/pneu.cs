namespace POO
{
    public class Pneu
    {
        public int Aro { get; set; }
        public string Marca { get; set; }
        public int PSIMinimo { get; set; }
        public int PSI { get; set; }
        public int PSIMaximo { get; set; }
        public int Largura { get; set; }
        public int PorcentualBorracha { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int CargaMaxima { get; set; }
        public int CargaAtual { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estourado { get; set; }
        public bool Furado { get; set; }
        public bool Estepe { get; set; }

        public Pneu(int _aro, string _marca, int _pSI, int _pSIMaximo, int _largura, int _velocidadeMaxima, int _cargaMaxima, bool _estepe=false)
        {
            Aro = _aro;
            Marca = _marca;
            PSIMinimo = 0;
            PSI = _pSI;
            PSIMaximo = _pSIMaximo;
            Largura = _largura;
            PorcentualBorracha = 100;
            VelocidadeMaxima = _velocidadeMaxima;
            VelocidadeAtual = 0;
            CargaMaxima = _cargaMaxima;
            CargaAtual = 200;
            Estourado = false;
            Furado=false;
            Estepe = _estepe;
        }

        public void Acelerar(int _impulso)
        {
            if (Furado || Estourado)
            {
                string estado;
                estado = Furado ? "furado" : "estourado";
                Console.WriteLine($"O pneu está {estado}");
                return;
            }
            VelocidadeAtual = VelocidadeAtual +_impulso;
            PorcentualBorracha =PorcentualBorracha -2;
            EstourarPneu();

        }
        public void Frear(int _impulso)
        {
            if (VelocidadeAtual > 0)
            {
                VelocidadeAtual = VelocidadeAtual - _impulso;
                PorcentualBorracha = PorcentualBorracha - 5;
            }
            if (VelocidadeAtual < 0)
                VelocidadeAtual =0;
            if (PorcentualBorracha < 0)
                PorcentualBorracha = 0;

            EstourarPneu();
        }

        private void EstourarPneu()
        {
            if (PorcentualBorracha < 30 || VelocidadeAtual > VelocidadeMaxima || PSI > PSIMaximo || CargaAtual>CargaMaxima)
            {
                Estourado = true;
                VelocidadeAtual = 0;
            }
        }

        public void Furar()
        {
            
            Furado = true;

        }
        public void Remendar()
        {
            Furado = false;
        }
        public void exibir()
        {
            Console.WriteLine("\n\nAro : " + Aro);
            Console.WriteLine("Marca : " + Marca);
            Console.WriteLine("PSIMminimo : " + PSIMinimo);
            Console.WriteLine("PSI : " + PSI);
            Console.WriteLine("PSIMaximo : " + PSIMaximo);
            Console.WriteLine("Largura : " + Largura);
            Console.WriteLine("PorcentualBorracha : " + PorcentualBorracha);
            Console.WriteLine("VelocidadeMaxima : " + VelocidadeMaxima);
            Console.WriteLine("CargaMaxima : " + CargaMaxima);
            Console.WriteLine("CargaAtual : " + CargaAtual);
            Console.WriteLine("VelocidadeAtual : " + VelocidadeAtual);
            Console.WriteLine("Estourado : " + Estourado);
            Console.WriteLine("Furado : " + Furado);

        }
    }
}
