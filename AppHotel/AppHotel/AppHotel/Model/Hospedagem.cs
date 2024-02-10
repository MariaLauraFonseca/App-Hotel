using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AppHotel.Model
{
    internal class Hospedagem
    {
        int qnt_adultos;
        Suite quarto_escolhido;

        public Suite QuartoEscolhido
        {
            get => quarto_escolhido;
            set
            {
                if (value == null)
                    throw new Exception("Por favor, selecione sua acomodação");

                quarto_escolhido = value;
            }
        }

        public int QntAdultos
        {
            get => qnt_adultos;
            set
            {
                if (value == 0)
                    throw new Exception("Por favor, selecione a quantidade de adultos");

                qnt_adultos = value;                        
            }
        }

        public int QntCriancas { get; set; }

        public DateTime DataCheckin { get; set; }

        public DateTime DataCheckout { get; set; }

        public int Estadia
        { 
            get
            {
                return DataCheckout.Subtract(DataCheckin).Days;
            }
        }

        public double ValorTotal
        {
            get => ((QntAdultos * QuartoEscolhido.DiariaAdulto) +
                     (QntCriancas * QuartoEscolhido.DiariaCrianca)
                   ) * Estadia;
        }

    } //Fecha classe
} //Fecha namespace
