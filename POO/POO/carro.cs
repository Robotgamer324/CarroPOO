using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Carro
    {
        public Pneu PneuDeEstepe { get; set; }

        private Pneu pneuDianteiroEsquerdo;
        public Pneu PneuDianteiroEsquerdo// { get; set; }
        { 
            get 
            {
                return pneuDianteiroEsquerdo;
            }
            set
            {
                if (Ligado)
                {
                    throw new Exception("Seu animal, deslique o carro.");
                } 
                pneuDianteiroEsquerdo = value;
            } 
        }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTraseiroEsquerdo { get; set; }
        public Pneu PneuTraseiroDireito { get; set; }
        public bool Ligado { get; set; }

        public int PercentualDeCombustivel { get; set; }
        public int VelocidadeAtual { get; set; }
        public int VelociadeMaxima { get; set; }

        public int CapacidadeDoTanque { get; set; }

        public int impulso { get; set; }

        public String Marca { get; set; }

        public String Modelo { get; set; }

        public String Cor { get; set; }

        public int Ano { get; set; }
        public String Placa { get; set; }

        public Carro(string _marca, String _modelo, String _cor, int _ano, string _placa, int _CapacidadeDoTanque, int _percentualDeCombustivel)
        {
            Marca = _marca;
            Modelo = _modelo;
            Cor = _cor;
            Ano = _ano;
            Placa = _placa;

            PneuDeEstepe = new Pneu(17, "Michelin", 33, 38, 25, 240, 500, true);
            PneuDianteiroEsquerdo = new Pneu(13, "Michelin", 33, 38, 25, 240, 500, false);
            PneuDianteiroDireito = new Pneu(13, "Michelin", 33, 38, 25, 240, 500, false);
            PneuTraseiroEsquerdo = new Pneu(13, "Michelin", 33, 38, 25, 240, 500, false);
            PneuTraseiroDireito = new Pneu(13, "Michelin", 33, 38, 25, 240, 500, false);
            CapacidadeDoTanque = _CapacidadeDoTanque;
            PercentualDeCombustivel = _percentualDeCombustivel;
            VelocidadeAtual = 0;
            VelociadeMaxima= 0; 
            Ligado = false;
        }

        public void Ligar()
        {
            if (PercentualDeCombustivel > 0)
            {
                Ligado = true;
                PercentualDeCombustivel -= 1;

            }
            
        }
        public void Desligar()
        {
            Ligado = false;
            Parar();
        }
        public void Acelerar(int _impulso)
        {
            if (!Ligado)
            {
                Console.WriteLine("O carro está desligado");
                return;
            }
           
            PercentualDeCombustivel -= 5;
            VelocidadeAtual += _impulso;
            PneuDianteiroEsquerdo.Acelerar(_impulso);
            PneuDianteiroDireito.Acelerar(_impulso);
            PneuTraseiroEsquerdo.Acelerar(_impulso);
            PneuTraseiroDireito.Acelerar(_impulso);
            CarroEstaOperacional();
        }

        private bool CarroEstaOperacional()
        {
            if (PercentualDeCombustivel <= 0)
            {
                PercentualDeCombustivel = 0;
                Console.WriteLine("O carro está sem combustivel");
                Desligar();
                return false;
            }
            if (PneuDianteiroDireito.Estourado || PneuDianteiroDireito.Furado)
            {
                Console.WriteLine("Problema com o penu dianteiro direito");
                Parar();
                return false;
            }
            if (PneuDianteiroEsquerdo.Estourado || PneuDianteiroEsquerdo.Furado)
            {
                Console.WriteLine("Problema com o penu dianteiro esquerdo");
                Parar();
                return false;
            }
            if (PneuTraseiroDireito.Estourado || PneuTraseiroDireito.Furado)
            {
                Console.WriteLine("Problema com o pneu traseiro direito");
                Parar();
                return false;
            }
            if (PneuTraseiroEsquerdo.Estourado || PneuTraseiroEsquerdo.Furado)
            {
                Console.WriteLine("Problema com o  pneu traseiro esquerdo");
                Parar();
                return false;
            }
            if (PneuDeEstepe.Estourado || PneuDeEstepe.Furado)
            {
                Console.WriteLine("Problema com o  pneu de estepe");
                Parar();
                return false;
            }
            return true;
        }

        public void Frear(int _impulso)
        {
            VelocidadeAtual -= _impulso;
            PneuDianteiroEsquerdo.Frear(_impulso);
            PneuDianteiroDireito.Frear(_impulso);
            PneuTraseiroEsquerdo.Frear(_impulso);
            PneuTraseiroDireito.Frear(_impulso);

           if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;

        }
        public void Exibir()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Cor : " + Cor);
            Console.WriteLine("Ano: " + Modelo);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Capacidade Do Tanque: " + CapacidadeDoTanque);
            Console.WriteLine("Pecentual De Combustivel: " + PercentualDeCombustivel);
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("Velocidade Atual: "+ VelocidadeAtual);
            Console.WriteLine("Velocidade Maxima: " + VelociadeMaxima);   
            Console.WriteLine("\nPneu Dianeiro Esquerdo");
            PneuDianteiroEsquerdo.exibir();
            Console.WriteLine("\nPneu Dianeiro direito");
            PneuDianteiroDireito.exibir();
            Console.WriteLine("\nPneu Traseiro Esquerdo");
            PneuTraseiroEsquerdo.exibir();
            Console.WriteLine("\nPneu Traseiro Direito");
            PneuTraseiroDireito.exibir();
            Console.WriteLine("\nPneu Estepe");
            PneuDeEstepe.exibir();
        }
        public void Parar()
        {
            Frear(VelocidadeAtual);
        }

    }
}
