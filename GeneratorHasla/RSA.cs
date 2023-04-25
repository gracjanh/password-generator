using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Numerics;

namespace GeneratorHasla
{
    public class RSA
    {
        private BigInteger p;
        private BigInteger q;
        private BigInteger phi;
        private int e;
        private BigInteger d;
        private int k;
        public BigInteger n { get; set; }



        public RSA()
        {
            p = BigInteger.Parse("19469495355310348270990592580191998639221450743640952620236903851789700309402857");
            q = BigInteger.Parse("54875133386847519273109693154204970395475080920935355580245252923343305939004903");
            n = p * q;
            phi = (p - 1) * (q - 1) /*/ GCD(p - 1, q - 1)*/;
            e = 2;
            while (e < phi)
            {
                if (GCD(phi, e) == 1)
                    break;
                else
                    e++;
            }


            k = 2;
            while ((k * phi + 1) % e != 0)
            {
                k++;
            }

            d = (k * phi + 1) / e;  // ze wzoru: d * e mod phi = 1
        }


        public BigInteger Encryption(BigInteger input)
        {
            return BigInteger.ModPow(input, (int)e, n);
        }
        public BigInteger Decryption(BigInteger input)
        {
            return BigInteger.ModPow(input, d, n);
        }
        private BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }







    }
}
