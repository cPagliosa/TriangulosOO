using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.ConsoleApp
{
    internal class Triangulo
    {
        private decimal largura;
        private decimal comprimento;
        private decimal altura;

        //gerar gets e sets
        public decimal Largura { get => largura; set => largura = value; }
        public decimal Comprimento { get => comprimento; set => comprimento = value; }
        public decimal Altura { get => altura; set => altura = value; }

        //contrutor
        public Triangulo()
        {
        }

        public Boolean ValidarTriangulo(decimal x, decimal y, decimal z)
        {
            if ((x + y) >= z && (x + z) >= y && (y + z) >= x) return true;
            else return false;

        }
        
        public String ReconhecerTriangulo(decimal x, decimal y, decimal z)
        {
            if (this.Equilatero(x, y, z)) return "Triangulo Equilatero";
            else if (this.Isosceles(x, y, z)) return "Tringulo Isosceles";
            else if (this.Escaleno(x, y, z)) return "Tringulo Escaleno";
            else return "Erro na operação!!";
        }

        private Boolean Equilatero(decimal x, decimal y,decimal z)
        {
            if(x == y && y == z) return true;
            else return false;
        }
        private Boolean Isosceles(decimal x, decimal y, decimal z)
        {
            if(x == y && x != z) return true;
            else if(y == z && y != x) return true;
            else if(z == x && y != z) return true;
            else return false;
        }
        private Boolean Escaleno(decimal x, decimal y, decimal z)
        {
            if(x != y && x != z && y != z) return true;
            else return false;
        }
    }
}
